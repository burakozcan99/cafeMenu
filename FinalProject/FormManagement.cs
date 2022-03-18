using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FormManagement : Form
    {
        int AddID = 0;
        int UpdateID = 0;
        private void radioHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHamburger.Checked == true)
            {
                for (int i = 0; i < menuList.Items.Count; i++)
                {
                    if (int.Parse(menuList.Items[i].SubItems[2].Text) > 1999)
                    {
                        AddID = int.Parse(menuList.Items[i - 1].SubItems[2].Text) + 1;
                        break;
                    }
                }
            }
        }
        private void radioChips_CheckedChanged(object sender, EventArgs e)
        {
            if (radioChips.Checked == true)
            {
                for (int i = 0; i < menuList.Items.Count; i++)
                {
                    if (int.Parse(menuList.Items[i].SubItems[2].Text) > 2999)
                    {
                        AddID = int.Parse(menuList.Items[i - 1].SubItems[2].Text) + 1;
                        break;
                    }
                }
            }
        }
        private void radioDrink_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDrink.Checked == true)
            {
                for (int i = 0; i < menuList.Items.Count; i++)
                {
                    if (int.Parse(menuList.Items[i].SubItems[2].Text) > 3999)
                    {
                        AddID = int.Parse(menuList.Items[i - 1].SubItems[2].Text) + 1;
                        break;
                    }
                }
            }
        }
        private void radioDessert_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDessert.Checked == true)
            {
                for (int i = 0; i < menuList.Items.Count; i++)
                {
                    if (int.Parse(menuList.Items[i].SubItems[2].Text) > 4999)
                    {
                        AddID = int.Parse(menuList.Items[i - 1].SubItems[2].Text) + 1;
                        break;
                    }
                }
            }
        }

        private void ProductAdd(string name, string price, int id)
        {
            try
            {
                dbConnection db = new dbConnection();
                db.connection.Open();

                SqlCommand command = new SqlCommand("ProductAdd", db.connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Price", price);
                command.ExecuteNonQuery();

                addNameBox.Text = addPriceBox.Text = "";
                radioChips.Checked = radioDessert.Checked = radioDrink.Checked = radioHamburger.Checked = false;

                menuList.Items.Clear();
                LoadList();

                db.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ProductDelete(int id)
        {
            try
            {

                dbConnection db = new dbConnection();
                db.connection.Open();

                SqlCommand command = new SqlCommand("ProductDelete", db.connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();

                menuList.Items.Clear();
                LoadList();

                db.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        public FormManagement()
        {
            InitializeComponent();
        }

        private void LoadList()
        {
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
        }

        private void FormManagement_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        private void menuList_ItemActivate(object sender, EventArgs e)
        {
            string carryName = menuList.SelectedItems[0].SubItems[0].Text;
            string carryPrice = menuList.SelectedItems[0].SubItems[1].Text;
            int id = int.Parse(menuList.SelectedItems[0].SubItems[2].Text);
            UpdateID = id;

            addNameBox.Text = carryName;
            addPriceBox.Text = carryPrice;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = addNameBox.Text;
            string price = addPriceBox.Text;
            ProductAdd(name, price, AddID);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(menuList.SelectedItems[0].SubItems[2].Text);
            ProductDelete(id);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string UpdateName = addNameBox.Text;
            string UpdatePrice = addPriceBox.Text;

            ProductDelete(UpdateID);
            ProductAdd(UpdateName, UpdatePrice, AddID);
        }

    }
 }

