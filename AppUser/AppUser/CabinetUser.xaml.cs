using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;

namespace AppUser
{
    public partial class CabinetUser : Window
    {
        ApplicationContext db;

        public CabinetUser()
        {
            InitializeComponent();
            LoadEvents();
        }

        public void GetIdUser(int Id)
        {
            db = new ApplicationContext();

            List<User> users = db.Users.ToList();
            string strUser = "";
            foreach (User user in users)
            {
                if (user.id == Id)
                {
                    strUser += $"Логин: {user.Login}" + $"\n ФИО: {user.FIO}" + $"\n Почта: {user.Email}" + $"\n Дата рождения: {user.BirthdayDate}";
                }
            }
            LoginUser.Text = strUser;
        }
        public class Event
        {
            public DateTime Date { get; set; }
            public string Description { get; set; }
        }
        public void SaveEventsToJson(List<Event> events)
        {
            string json = JsonConvert.SerializeObject(events);
            File.WriteAllText("events.json", json);
        }
        private void LoadEvents()
        {
            if (File.Exists("events.json"))
            {
                string json = File.ReadAllText("events.json");
                List<Event> events = JsonConvert.DeserializeObject<List<Event>>(json);
                EventsListBox.ItemsSource = events;
            }
        }
        private void SaveEventButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = EventDatePicker.SelectedDate ?? DateTime.Now;
            string description = EventDescriptionTextBox.Text;
            Event newEvent = new Event
            {
                Date = date,
                Description = description
            };
            List<Event> events = new List<Event>();
            if (File.Exists("events.json"))
            {
                string json = File.ReadAllText("events.json");
                events = JsonConvert.DeserializeObject<List<Event>>(json);
            }
            events.Add(newEvent);
            SaveEventsToJson(events);
            LoadEvents();
            MessageBox.Show("Событие сохранено.");
        }
    }
}
