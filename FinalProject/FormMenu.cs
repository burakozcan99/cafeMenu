using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {

            //SETTING UP THE ICONS LIST
            ImageList icons = new ImageList();
            icons.ImageSize = new Size(30, 30);

            String[] paths = { };
            paths = Directory.GetFiles("Images");
            try
            {
                foreach (string path in paths)
                {
                    icons.Images.Add(Image.FromFile(path));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            menuList.SmallImageList = icons;

            //LOADING PRODUCT LIST FROM DATABASE
            dbConnection db = new dbConnection();
            db.connection.Open();
            String query = "Select * from Product";
            
            SqlCommand command = new SqlCommand(query, db.connection);
            SqlDataReader dataReader;

            SqlDataAdapter adapter = new SqlDataAdapter(query, db.connection);
            DataSet set = new DataSet();


            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(dataReader["name"].ToString());
                item.SubItems.Add(dataReader["price"].ToString());
                item.SubItems.Add(dataReader["id"].ToString());
                menuList.Items.Add(item);
            }
            db.connection.Close();

            //ICON SELECTION
            for(int i=0; i < menuList.Items.Count; i++)
            {
                int id = int.Parse(menuList.Items[i].SubItems[2].Text);
                if (id < 2000 && id > 999)
                    menuList.Items[i].ImageIndex = 0;
                else if (id < 3000 && id > 1999)
                    menuList.Items[i].ImageIndex = 1;
                else if (id < 4000 && id > 2999)
                    menuList.Items[i].ImageIndex = 2;
                else if (id < 5000 && id > 3999)
                    menuList.Items[i].ImageIndex = 3;
            }
        }

        //MENÜDEN SEÇEREK SEPETE EKLEME
        private void menuList_ItemActivate(object sender, EventArgs e)
        {
            string name = menuList.SelectedItems[0].Text;
            double price = double.Parse(menuList.SelectedItems[0].SubItems[1].Text);
            Product product = new Product(name, price);
            product.addToCart();
        }
        //BUTONA BASARAK SEPETE EKLEME
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = menuList.SelectedItems[0].Text;
            double price = double.Parse(menuList.SelectedItems[0].SubItems[1].Text);
            Product product = new Product(name, price);
            product.addToCart();
        }

        //SEPETTEN SİLME
        private void cartList_ItemActivate(object sender, EventArgs e)
        {
            string name = cartList.SelectedItems[0].Text;
            double price = 0;
            int count = int.Parse(cartList.SelectedItems[0].SubItems[2].Text);

            for (int i = 0; i < menuList.Items.Count; i++)
            {
                if (cartList.SelectedItems[0].Text.Equals(menuList.Items[i].Text))
                {
                    price = double.Parse(menuList.Items[i].SubItems[1].Text);
                }
                else continue;
            }

            Product product = new Product(name, price);
            product.removeFromCart(count);
        }
        //BUTONA BASARAK SEPETTEN SİLME
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string name = cartList.SelectedItems[0].Text;
            double price = 0;
            int count = int.Parse(cartList.SelectedItems[0].SubItems[2].Text);

            for (int i = 0; i < menuList.Items.Count; i++)
            {
                if (cartList.SelectedItems[0].Text.Equals(menuList.Items[i].Text))
                {
                    price = double.Parse(menuList.Items[i].SubItems[1].Text);
                }
                else continue;
            }

            Product product = new Product(name, price);
            product.removeFromCart(count);
        }

        //LİSTEYİ SİLME
        private void buttonClear_Click(object sender, EventArgs e)
        {
            cartList.Items.Clear();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            double price = 0;
            string messagePrice = "COUNT - NAME";
            for (int i=0; i < cartList.Items.Count; i++)
            {
                messagePrice += "\n" + cartList.Items[i].SubItems[2].Text + "           " + cartList.Items[i].Text;
                price += double.Parse(cartList.Items[i].SubItems[1].Text);
            }
            messagePrice += "\n \n Total price: " + price + "\n Do you wish to proceed with transaction?";
            string title = "Finish Transaction";
            string messageComplete = "Transaction complete!" + "\n Thank you for your purchase, your order will arrive shortly.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxButtons button = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(messagePrice, title, buttons);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                DialogResult result2 = MessageBox.Show(messageComplete, title, button);
                if (result == DialogResult.OK)
                    return;
                return;
            }
        }
        private void menuLogoutButton_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();

            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void menuTimer_Tick(object sender, EventArgs e)
        {
            menuTimerLabel.Text = DateTime.Now.ToString();
        }

    }
}
