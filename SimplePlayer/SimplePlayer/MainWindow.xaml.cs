using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SimplePlayer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void FirePropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        private MediaState mediaState = MediaState.Stopped;
        internal MediaState MediaState
        {
            get { return mediaState; }
            set
            {
                mediaState = value;
                FirePropertyChanged("PlayButtonName");
            }
        }
        public string PlayButtonName
        {
            get
            {
                return (MediaState == MediaState.Playing) ? "Pause" : "Play";
            }
        }

        private void ButtonOpen_Click(object sender, RoutedEventArgs e)
        {
            var dig = new Microsoft.Win32.OpenFileDialog
            {
                DefaultExt = ".avi",
                Filter = "Video files (*.avi)| *.avi|All files(*.*)|*.*",
                CheckFileExists = true,
            };
            if (dig.ShowDialog(this) == true)
            {
                var filename = dig.FileName;
                if (MediaState == MediaState.Playing || MediaState == MediaState.Paused)
                {
                    Stop();
                }
                media.Source = new Uri(filename);
                media.Play();
            }
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            if (MediaState == MediaState.Playing || MediaState == MediaState.Paused)
            {
                Stop();
            }
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            if (media.Source != null)
            {
                if (MediaState == MediaState.Playing && media.CanPause)
                {
                    Pause();
                }
                else if (MediaState == MediaState.Paused || mediaState == MediaState.Stopped)
                {
                    Play();
                }
            }
        }
        private void media_Loaded(object sender, RoutedEventArgs e)
        {
            media.MediaOpened += new RoutedEventHandler(Media_MediaOpened);
            media.MediaFailed += new EventHandler<ExceptionRoutedEventArgs>(Media_MediaFailed);
            media.MediaEnded += new RoutedEventHandler(Media_MediaEnded);

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (MediaState == MediaState.Playing)
            {
                slider.Value = media.Position.TotalSeconds;
            }
        }

        private void Media_MediaEnded(object sender, RoutedEventArgs e)
        {
        }

        private void Media_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show("Error while loading files", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void Media_MediaOpened(object sender, RoutedEventArgs e)
        {
            slider.Maximum = media.NaturalDuration.TimeSpan.TotalSeconds;
            Stop();
        }

        void Stop()
        {
            media.Stop();
            MediaState = MediaState.Stopped;
        }
        void Play()
        {
            media.Play();
            MediaState = MediaState.Playing;
        }
        void Pause()
        {
            media.Pause();
            MediaState = MediaState.Paused;
        }

        private void slider_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            media.Stop();
            media.Position = TimeSpan.FromSeconds(slider.Value);
            media.Play();
        }
    }
}