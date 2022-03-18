using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    // PERSON CLASSINA ATILACAK
    public enum Gender
    {
        MALE, FEMALE
    } // PERSON CLASSINA ATILACAK 

    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        // CİNSİYET BELİRLEME START
        Gender sex;
        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMale.Checked == true) { 
            sex = Gender.MALE;
            }
        }
        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            if( radioFemale.Checked == true) { 
            sex = Gender.FEMALE;
            }
        }
        // CİNSİYET BELİRLEME END

        //TELEFON NUMARASI GİRİŞLERİ START
        private void loginBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void signupBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //TELEFON NUMARASI GİRİŞLERİ END

        private void loginSignUpButton_Click(object sender, EventArgs e)
        {
            loginBoxName.Hide(); loginBoxPassword.Hide();
            loginPasswordLabel.Hide(); loginPhoneLabel.Hide(); loginSignUpLabel.Hide();
            loginLoginButton.Hide(); loginSignUpButton.Hide(); closeButton.Hide();
            signupBox.Show();


        }

        private void signupSignUpButton_Click(object sender, EventArgs e)
        {
            dbConnection db = new dbConnection();       
            db.connection.Open();

            SqlCommand command = new SqlCommand("UserAdd", db.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Name", signupBoxName.Text);
            command.Parameters.AddWithValue("@Surname", signupBoxSurname.Text);
            command.Parameters.AddWithValue("@Address", addressCityBox.Text);
            command.Parameters.AddWithValue("@Phone", signupBoxPhone.Text);
            command.Parameters.AddWithValue("@Email", signupBoxEmail.Text);
            command.Parameters.AddWithValue("@Pwd", signupBoxPassword.Text);
            command.ExecuteNonQuery();

            string message = "Registration Successful";
            DialogResult result = MessageBox.Show(message);

            signupBoxName.Text = signupBoxSurname.Text = signupBoxEmail.Text = signupBoxPassword.Text = signupBoxPhone.Text = " ";
            addressCityBox.Text = addressAptBox.Text = addressDoorBox.Text = addressStreetBox.Text = " ";
            radioFemale.Checked = radioMale.Checked = false;
            
            //Exceptionlar (phone no zaten kayıtlı, bilmemne boş olamaz vs.)
            
            signupBox.Hide();
            loginBoxName.Show(); loginBoxPassword.Show();
            loginPasswordLabel.Show(); loginPhoneLabel.Show(); loginSignUpLabel.Show();
            loginLoginButton.Show(); loginSignUpButton.Show(); closeButton.Show();

            db.connection.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            signupBox.Hide();
            loginBoxName.Show(); loginBoxPassword.Show();
            loginPasswordLabel.Show(); loginPhoneLabel.Show(); loginSignUpLabel.Show();
            loginLoginButton.Show(); loginSignUpButton.Show(); closeButton.Show();
        }

        private void loginLoginButton_Click(object sender, EventArgs e)
        {
            if (loginBoxPassword.Text == "admin123")
            {
                FormManagement menu = new FormManagement();
                this.Hide();
                menu.ShowDialog();
                this.Close();


            }
            try {
                dbConnection db = new dbConnection();
                db.connection.Open();
                SqlCommand command = new SqlCommand("select * from Customer where Phone=@UserId and Pwd=@Password", db.connection);
                command.Parameters.AddWithValue("@UserId", loginBoxName.Text);
                command.Parameters.AddWithValue("@Password", loginBoxPassword.Text);
                SqlDataAdapter sda = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Successfully loged in");
                    FormMenu menu = new FormMenu();
                    this.Hide();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter Correct Username and Password");
                    loginBoxName.Clear();
                    loginBoxPassword.Clear();
                    loginBoxName.Focus();
                }
                db.connection.Close();

            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginTimer_Tick(object sender, EventArgs e)
        {
            loginTimerLabel.Text = DateTime.Now.ToString();
        }

    }
}
