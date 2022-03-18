namespace FinalProject
{
    partial class FormLogin
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.signupBoxPhone = new System.Windows.Forms.TextBox();
            this.signupPhoneLabel = new System.Windows.Forms.Label();
            this.signupSignUpButton = new System.Windows.Forms.Button();
            this.AddressBox = new System.Windows.Forms.GroupBox();
            this.addressCityBox = new System.Windows.Forms.TextBox();
            this.addressStreetBox = new System.Windows.Forms.TextBox();
            this.addressAptBox = new System.Windows.Forms.TextBox();
            this.addressDoorBox = new System.Windows.Forms.TextBox();
            this.addressLabelNo = new System.Windows.Forms.Label();
            this.addressLabelStreet = new System.Windows.Forms.Label();
            this.addressLabelCity = new System.Windows.Forms.Label();
            this.addressLabelApt = new System.Windows.Forms.Label();
            this.GenderBox = new System.Windows.Forms.GroupBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.signupBoxPassword = new System.Windows.Forms.TextBox();
            this.signupBoxEmail = new System.Windows.Forms.TextBox();
            this.signupPasswordLabel = new System.Windows.Forms.Label();
            this.signupBoxName = new System.Windows.Forms.TextBox();
            this.signupEmailLabel = new System.Windows.Forms.Label();
            this.signupNameLabel = new System.Windows.Forms.Label();
            this.loginSignUpLabel = new System.Windows.Forms.Label();
            this.loginSignUpButton = new System.Windows.Forms.Button();
            this.loginLoginButton = new System.Windows.Forms.Button();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.loginPhoneLabel = new System.Windows.Forms.Label();
            this.loginBoxPassword = new System.Windows.Forms.TextBox();
            this.loginBoxName = new System.Windows.Forms.TextBox();
            this.signupBox = new System.Windows.Forms.GroupBox();
            this.signupSurnameLabel = new System.Windows.Forms.Label();
            this.signupBoxSurname = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginTimerLabel = new System.Windows.Forms.Label();
            this.loginTimer = new System.Windows.Forms.Timer(this.components);
            this.AddressBox.SuspendLayout();
            this.GenderBox.SuspendLayout();
            this.signupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // signupBoxPhone
            // 
            this.signupBoxPhone.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signupBoxPhone.Location = new System.Drawing.Point(106, 390);
            this.signupBoxPhone.MaxLength = 11;
            this.signupBoxPhone.Name = "signupBoxPhone";
            this.signupBoxPhone.Size = new System.Drawing.Size(177, 25);
            this.signupBoxPhone.TabIndex = 11;
            this.signupBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.signupBoxPhone_KeyPress);
            // 
            // signupPhoneLabel
            // 
            this.signupPhoneLabel.AutoSize = true;
            this.signupPhoneLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signupPhoneLabel.Location = new System.Drawing.Point(7, 396);
            this.signupPhoneLabel.Name = "signupPhoneLabel";
            this.signupPhoneLabel.Size = new System.Drawing.Size(79, 19);
            this.signupPhoneLabel.TabIndex = 10;
            this.signupPhoneLabel.Text = "Phone No:";
            // 
            // signupSignUpButton
            // 
            this.signupSignUpButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signupSignUpButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signupSignUpButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signupSignUpButton.Location = new System.Drawing.Point(208, 421);
            this.signupSignUpButton.Name = "signupSignUpButton";
            this.signupSignUpButton.Size = new System.Drawing.Size(75, 32);
            this.signupSignUpButton.TabIndex = 9;
            this.signupSignUpButton.Text = "Sign Up";
            this.signupSignUpButton.UseVisualStyleBackColor = false;
            this.signupSignUpButton.Click += new System.EventHandler(this.signupSignUpButton_Click);
            // 
            // AddressBox
            // 
            this.AddressBox.Controls.Add(this.addressCityBox);
            this.AddressBox.Controls.Add(this.addressStreetBox);
            this.AddressBox.Controls.Add(this.addressAptBox);
            this.AddressBox.Controls.Add(this.addressDoorBox);
            this.AddressBox.Controls.Add(this.addressLabelNo);
            this.AddressBox.Controls.Add(this.addressLabelStreet);
            this.AddressBox.Controls.Add(this.addressLabelCity);
            this.AddressBox.Controls.Add(this.addressLabelApt);
            this.AddressBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddressBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddressBox.Location = new System.Drawing.Point(13, 240);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(270, 144);
            this.AddressBox.TabIndex = 2;
            this.AddressBox.TabStop = false;
            this.AddressBox.Text = "Address";
            // 
            // addressCityBox
            // 
            this.addressCityBox.Location = new System.Drawing.Point(68, 15);
            this.addressCityBox.Name = "addressCityBox";
            this.addressCityBox.Size = new System.Drawing.Size(196, 25);
            this.addressCityBox.TabIndex = 9;
            // 
            // addressStreetBox
            // 
            this.addressStreetBox.Location = new System.Drawing.Point(68, 45);
            this.addressStreetBox.Name = "addressStreetBox";
            this.addressStreetBox.Size = new System.Drawing.Size(196, 25);
            this.addressStreetBox.TabIndex = 10;
            // 
            // addressAptBox
            // 
            this.addressAptBox.Location = new System.Drawing.Point(68, 76);
            this.addressAptBox.Name = "addressAptBox";
            this.addressAptBox.Size = new System.Drawing.Size(196, 25);
            this.addressAptBox.TabIndex = 11;
            // 
            // addressDoorBox
            // 
            this.addressDoorBox.Location = new System.Drawing.Point(68, 107);
            this.addressDoorBox.Name = "addressDoorBox";
            this.addressDoorBox.Size = new System.Drawing.Size(196, 25);
            this.addressDoorBox.TabIndex = 12;
            // 
            // addressLabelNo
            // 
            this.addressLabelNo.AutoSize = true;
            this.addressLabelNo.Location = new System.Drawing.Point(6, 113);
            this.addressLabelNo.Name = "addressLabelNo";
            this.addressLabelNo.Size = new System.Drawing.Size(47, 19);
            this.addressLabelNo.TabIndex = 3;
            this.addressLabelNo.Text = "Door:";
            // 
            // addressLabelStreet
            // 
            this.addressLabelStreet.AutoSize = true;
            this.addressLabelStreet.Location = new System.Drawing.Point(6, 51);
            this.addressLabelStreet.Name = "addressLabelStreet";
            this.addressLabelStreet.Size = new System.Drawing.Size(53, 19);
            this.addressLabelStreet.TabIndex = 1;
            this.addressLabelStreet.Text = "Street:";
            // 
            // addressLabelCity
            // 
            this.addressLabelCity.AutoSize = true;
            this.addressLabelCity.Location = new System.Drawing.Point(6, 21);
            this.addressLabelCity.Name = "addressLabelCity";
            this.addressLabelCity.Size = new System.Drawing.Size(38, 19);
            this.addressLabelCity.TabIndex = 0;
            this.addressLabelCity.Text = "City:";
            // 
            // addressLabelApt
            // 
            this.addressLabelApt.AutoSize = true;
            this.addressLabelApt.Location = new System.Drawing.Point(6, 82);
            this.addressLabelApt.Name = "addressLabelApt";
            this.addressLabelApt.Size = new System.Drawing.Size(45, 19);
            this.addressLabelApt.TabIndex = 2;
            this.addressLabelApt.Text = "Apt. :";
            // 
            // GenderBox
            // 
            this.GenderBox.Controls.Add(this.radioFemale);
            this.GenderBox.Controls.Add(this.radioMale);
            this.GenderBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GenderBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenderBox.Location = new System.Drawing.Point(13, 168);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(270, 61);
            this.GenderBox.TabIndex = 8;
            this.GenderBox.TabStop = false;
            this.GenderBox.Text = "Gender";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(169, 24);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(75, 23);
            this.radioFemale.TabIndex = 1;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            this.radioFemale.CheckedChanged += new System.EventHandler(this.radioFemale_CheckedChanged);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(38, 24);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(60, 23);
            this.radioMale.TabIndex = 0;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            this.radioMale.CheckedChanged += new System.EventHandler(this.radioMale_CheckedChanged);
            // 
            // signupBoxPassword
            // 
            this.signupBoxPassword.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signupBoxPassword.Location = new System.Drawing.Point(106, 128);
            this.signupBoxPassword.MaxLength = 16;
            this.signupBoxPassword.Name = "signupBoxPassword";
            this.signupBoxPassword.Size = new System.Drawing.Size(177, 25);
            this.signupBoxPassword.TabIndex = 7;
            // 
            // signupBoxEmail
            // 
            this.signupBoxEmail.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signupBoxEmail.Location = new System.Drawing.Point(106, 97);
            this.signupBoxEmail.Name = "signupBoxEmail";
            this.signupBoxEmail.Size = new System.Drawing.Size(177, 25);
            this.signupBoxEmail.TabIndex = 5;
            // 
            // signupPasswordLabel
            // 
            this.signupPasswordLabel.AutoSize = true;
            this.signupPasswordLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signupPasswordLabel.Location = new System.Drawing.Point(9, 134);
            this.signupPasswordLabel.Name = "signupPasswordLabel";
            this.signupPasswordLabel.Size = new System.Drawing.Size(77, 19);
            this.signupPasswordLabel.TabIndex = 3;
            this.signupPasswordLabel.Text = "Password:";
            // 
            // signupBoxName
            // 
            this.signupBoxName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signupBoxName.Location = new System.Drawing.Point(106, 35);
            this.signupBoxName.Name = "signupBoxName";
            this.signupBoxName.Size = new System.Drawing.Size(177, 25);
            this.signupBoxName.TabIndex = 4;
            // 
            // signupEmailLabel
            // 
            this.signupEmailLabel.AutoSize = true;
            this.signupEmailLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signupEmailLabel.Location = new System.Drawing.Point(9, 103);
            this.signupEmailLabel.Name = "signupEmailLabel";
            this.signupEmailLabel.Size = new System.Drawing.Size(55, 19);
            this.signupEmailLabel.TabIndex = 1;
            this.signupEmailLabel.Text = "E-mail:";
            // 
            // signupNameLabel
            // 
            this.signupNameLabel.AutoSize = true;
            this.signupNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signupNameLabel.Location = new System.Drawing.Point(9, 41);
            this.signupNameLabel.Name = "signupNameLabel";
            this.signupNameLabel.Size = new System.Drawing.Size(53, 19);
            this.signupNameLabel.TabIndex = 0;
            this.signupNameLabel.Text = "Name:";
            // 
            // loginSignUpLabel
            // 
            this.loginSignUpLabel.AutoSize = true;
            this.loginSignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginSignUpLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginSignUpLabel.Location = new System.Drawing.Point(86, 377);
            this.loginSignUpLabel.Name = "loginSignUpLabel";
            this.loginSignUpLabel.Size = new System.Drawing.Size(100, 16);
            this.loginSignUpLabel.TabIndex = 6;
            this.loginSignUpLabel.Text = "Not a member?";
            // 
            // loginSignUpButton
            // 
            this.loginSignUpButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginSignUpButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginSignUpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginSignUpButton.Location = new System.Drawing.Point(89, 398);
            this.loginSignUpButton.Name = "loginSignUpButton";
            this.loginSignUpButton.Size = new System.Drawing.Size(88, 68);
            this.loginSignUpButton.TabIndex = 5;
            this.loginSignUpButton.Text = "Sign Up";
            this.loginSignUpButton.UseVisualStyleBackColor = false;
            this.loginSignUpButton.Click += new System.EventHandler(this.loginSignUpButton_Click);
            // 
            // loginLoginButton
            // 
            this.loginLoginButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginLoginButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginLoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginLoginButton.Location = new System.Drawing.Point(195, 398);
            this.loginLoginButton.Name = "loginLoginButton";
            this.loginLoginButton.Size = new System.Drawing.Size(88, 68);
            this.loginLoginButton.TabIndex = 4;
            this.loginLoginButton.Text = "Login";
            this.loginLoginButton.UseVisualStyleBackColor = false;
            this.loginLoginButton.Click += new System.EventHandler(this.loginLoginButton_Click);
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.AutoSize = true;
            this.loginPasswordLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginPasswordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginPasswordLabel.Location = new System.Drawing.Point(84, 247);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Size = new System.Drawing.Size(113, 28);
            this.loginPasswordLabel.TabIndex = 3;
            this.loginPasswordLabel.Text = "Password";
            // 
            // loginPhoneLabel
            // 
            this.loginPhoneLabel.AutoSize = true;
            this.loginPhoneLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginPhoneLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginPhoneLabel.Location = new System.Drawing.Point(84, 135);
            this.loginPhoneLabel.Name = "loginPhoneLabel";
            this.loginPhoneLabel.Size = new System.Drawing.Size(181, 28);
            this.loginPhoneLabel.TabIndex = 2;
            this.loginPhoneLabel.Text = "Phone or E-mail";
            // 
            // loginBoxPassword
            // 
            this.loginBoxPassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginBoxPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBoxPassword.Location = new System.Drawing.Point(89, 278);
            this.loginBoxPassword.MaxLength = 16;
            this.loginBoxPassword.Name = "loginBoxPassword";
            this.loginBoxPassword.Size = new System.Drawing.Size(194, 20);
            this.loginBoxPassword.TabIndex = 1;
            // 
            // loginBoxName
            // 
            this.loginBoxName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginBoxName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBoxName.Location = new System.Drawing.Point(89, 165);
            this.loginBoxName.Name = "loginBoxName";
            this.loginBoxName.Size = new System.Drawing.Size(194, 20);
            this.loginBoxName.TabIndex = 0;
            this.loginBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginBoxName_KeyPress);
            // 
            // signupBox
            // 
            this.signupBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signupBox.Controls.Add(this.signupSurnameLabel);
            this.signupBox.Controls.Add(this.signupBoxSurname);
            this.signupBox.Controls.Add(this.buttonBack);
            this.signupBox.Controls.Add(this.signupSignUpButton);
            this.signupBox.Controls.Add(this.signupBoxPhone);
            this.signupBox.Controls.Add(this.signupNameLabel);
            this.signupBox.Controls.Add(this.signupPhoneLabel);
            this.signupBox.Controls.Add(this.signupBoxName);
            this.signupBox.Controls.Add(this.signupEmailLabel);
            this.signupBox.Controls.Add(this.AddressBox);
            this.signupBox.Controls.Add(this.signupBoxEmail);
            this.signupBox.Controls.Add(this.GenderBox);
            this.signupBox.Controls.Add(this.signupPasswordLabel);
            this.signupBox.Controls.Add(this.signupBoxPassword);
            this.signupBox.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signupBox.Location = new System.Drawing.Point(32, 116);
            this.signupBox.Name = "signupBox";
            this.signupBox.Size = new System.Drawing.Size(299, 470);
            this.signupBox.TabIndex = 12;
            this.signupBox.TabStop = false;
            this.signupBox.Text = "Sign Up";
            this.signupBox.Visible = false;
            // 
            // signupSurnameLabel
            // 
            this.signupSurnameLabel.AutoSize = true;
            this.signupSurnameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signupSurnameLabel.Location = new System.Drawing.Point(9, 72);
            this.signupSurnameLabel.Name = "signupSurnameLabel";
            this.signupSurnameLabel.Size = new System.Drawing.Size(72, 19);
            this.signupSurnameLabel.TabIndex = 13;
            this.signupSurnameLabel.Text = "Surname:";
            // 
            // signupBoxSurname
            // 
            this.signupBoxSurname.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signupBoxSurname.Location = new System.Drawing.Point(106, 66);
            this.signupBoxSurname.Name = "signupBoxSurname";
            this.signupBoxSurname.Size = new System.Drawing.Size(177, 25);
            this.signupBoxSurname.TabIndex = 14;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBack.Location = new System.Drawing.Point(13, 421);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 32);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeButton.Location = new System.Drawing.Point(144, 474);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(88, 40);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "CAFE NAME CAFE NAME";
            // 
            // loginTimerLabel
            // 
            this.loginTimerLabel.AutoSize = true;
            this.loginTimerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginTimerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginTimerLabel.Location = new System.Drawing.Point(29, 9);
            this.loginTimerLabel.Name = "loginTimerLabel";
            this.loginTimerLabel.Size = new System.Drawing.Size(0, 16);
            this.loginTimerLabel.TabIndex = 15;
            // 
            // loginTimer
            // 
            this.loginTimer.Enabled = true;
            this.loginTimer.Interval = 1000;
            this.loginTimer.Tick += new System.EventHandler(this.loginTimer_Tick);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(360, 598);
            this.ControlBox = false;
            this.Controls.Add(this.loginTimerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.signupBox);
            this.Controls.Add(this.loginBoxPassword);
            this.Controls.Add(this.loginLoginButton);
            this.Controls.Add(this.loginSignUpButton);
            this.Controls.Add(this.loginSignUpLabel);
            this.Controls.Add(this.loginPhoneLabel);
            this.Controls.Add(this.loginBoxName);
            this.Controls.Add(this.loginPasswordLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.AddressBox.ResumeLayout(false);
            this.AddressBox.PerformLayout();
            this.GenderBox.ResumeLayout(false);
            this.GenderBox.PerformLayout();
            this.signupBox.ResumeLayout(false);
            this.signupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label loginSignUpLabel;
        private System.Windows.Forms.Button loginSignUpButton;
        private System.Windows.Forms.Button loginLoginButton;
        private System.Windows.Forms.Label loginPasswordLabel;
        private System.Windows.Forms.Label loginPhoneLabel;
        private System.Windows.Forms.TextBox loginBoxPassword;
        private System.Windows.Forms.TextBox loginBoxName;
        private System.Windows.Forms.Label signupPasswordLabel;
        private System.Windows.Forms.Label signupEmailLabel;
        private System.Windows.Forms.Label signupNameLabel;
        private System.Windows.Forms.GroupBox GenderBox;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.TextBox signupBoxPassword;
        private System.Windows.Forms.TextBox signupBoxEmail;
        private System.Windows.Forms.TextBox signupBoxName;
        private System.Windows.Forms.GroupBox AddressBox;
        private System.Windows.Forms.TextBox addressCityBox;
        private System.Windows.Forms.TextBox addressStreetBox;
        private System.Windows.Forms.TextBox addressAptBox;
        private System.Windows.Forms.TextBox addressDoorBox;
        private System.Windows.Forms.Label addressLabelNo;
        private System.Windows.Forms.Label addressLabelApt;
        private System.Windows.Forms.Label addressLabelStreet;
        private System.Windows.Forms.Label addressLabelCity;
        private System.Windows.Forms.Button signupSignUpButton;
        private System.Windows.Forms.TextBox signupBoxPhone;
        private System.Windows.Forms.Label signupPhoneLabel;
        private System.Windows.Forms.GroupBox signupBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loginTimerLabel;
        private System.Windows.Forms.Timer loginTimer;
        private System.Windows.Forms.Label signupSurnameLabel;
        private System.Windows.Forms.TextBox signupBoxSurname;
    }
}

