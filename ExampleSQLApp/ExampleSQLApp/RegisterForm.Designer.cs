namespace ExampleSQLApp
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.UserNameField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Авторизация = new System.Windows.Forms.FlowLayoutPanel();
            this.Close_BTN = new System.Windows.Forms.Label();
            this.UserSurameField = new System.Windows.Forms.TextBox();
            this.Logintextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Авторизация.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 119);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogin.Location = new System.Drawing.Point(272, 282);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(160, 39);
            this.buttonLogin.TabIndex = 11;
            this.buttonLogin.Text = "Зарегистрироваться";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // PassBox
            // 
            this.PassBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassBox.Location = new System.Drawing.Point(71, 192);
            this.PassBox.MaximumSize = new System.Drawing.Size(215, 46);
            this.PassBox.MinimumSize = new System.Drawing.Size(215, 46);
            this.PassBox.Multiline = true;
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(215, 46);
            this.PassBox.TabIndex = 10;
            this.PassBox.TextChanged += new System.EventHandler(this.PassBox_TextChanged);
            this.PassBox.Enter += new System.EventHandler(this.PassBox_Enter);
            this.PassBox.Leave += new System.EventHandler(this.PassBox_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 189);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // UserNameField
            // 
            this.UserNameField.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameField.Location = new System.Drawing.Point(71, 125);
            this.UserNameField.Multiline = true;
            this.UserNameField.Name = "UserNameField";
            this.UserNameField.Size = new System.Drawing.Size(215, 46);
            this.UserNameField.TabIndex = 8;
            this.UserNameField.TextChanged += new System.EventHandler(this.UserNameField_TextChanged);
            this.UserNameField.Enter += new System.EventHandler(this.UserNameField_Enter);
            this.UserNameField.Leave += new System.EventHandler(this.UserNameField_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Авторизация
            // 
            this.Авторизация.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Авторизация.Controls.Add(this.label1);
            this.Авторизация.Controls.Add(this.Close_BTN);
            this.Авторизация.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Авторизация.Location = new System.Drawing.Point(0, 0);
            this.Авторизация.Name = "Авторизация";
            this.Авторизация.Size = new System.Drawing.Size(700, 119);
            this.Авторизация.TabIndex = 6;
            // 
            // Close_BTN
            // 
            this.Close_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_BTN.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_BTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Close_BTN.Location = new System.Drawing.Point(675, 0);
            this.Close_BTN.Name = "Close_BTN";
            this.Close_BTN.Size = new System.Drawing.Size(18, 19);
            this.Close_BTN.TabIndex = 1;
            this.Close_BTN.Text = "X";
            this.Close_BTN.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Close_BTN.Click += new System.EventHandler(this.Close_BTN_Click);
            // 
            // UserSurameField
            // 
            this.UserSurameField.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserSurameField.Location = new System.Drawing.Point(384, 126);
            this.UserSurameField.Multiline = true;
            this.UserSurameField.Name = "UserSurameField";
            this.UserSurameField.Size = new System.Drawing.Size(215, 46);
            this.UserSurameField.TabIndex = 12;
            this.UserSurameField.Enter += new System.EventHandler(this.UserSurameField_Enter);
            this.UserSurameField.Leave += new System.EventHandler(this.UserSurameField_Leave);
            // 
            // Logintextbox
            // 
            this.Logintextbox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Logintextbox.Location = new System.Drawing.Point(384, 189);
            this.Logintextbox.Multiline = true;
            this.Logintextbox.Name = "Logintextbox";
            this.Logintextbox.PasswordChar = '*';
            this.Logintextbox.Size = new System.Drawing.Size(215, 46);
            this.Logintextbox.TabIndex = 13;
            this.Logintextbox.UseSystemPasswordChar = true;
            this.Logintextbox.Enter += new System.EventHandler(this.Logintextbox_Enter);
            this.Logintextbox.Leave += new System.EventHandler(this.Logintextbox_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(272, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "Авторизоваться";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Logintextbox);
            this.Controls.Add(this.UserSurameField);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.UserNameField);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Авторизация);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Авторизация.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox UserNameField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel Авторизация;
        private System.Windows.Forms.Label Close_BTN;
        private System.Windows.Forms.TextBox UserSurameField;
        private System.Windows.Forms.TextBox Logintextbox;
        private System.Windows.Forms.Button button1;
    }
}