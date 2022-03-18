using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    class Product
    {
        public int id;
        public string name;
        public double price;

        public Product() { }

        public Product(int i, string name, double price)
        {
            SetID(id);
            SetName(name);
            SetPrice(price);
        }

        public Product(string name, double price)
        {
            SetName(name);
            SetPrice(price);
        }

        public void SetID(int id) 
        {
            this.id = id;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }

        public int GetID()
        {
            return id;
        }
        public string GetName()
        {
            return name;
        }
        public double GetPrice()
        {
            return price;
        }

        public void addToCart()
        {
            ListView cartList = Application.OpenForms["FormMenu"].Controls["cartList"] as ListView;

            //Sepette varsa count ve price artırıyor:
            for (int i = 0; i < cartList.Items.Count; i++)
            {
                if (name == cartList.Items[i].Text)
                {
                    string count = (double.Parse(cartList.Items[i].SubItems[2].Text) + 1).ToString();
                    string newPrice = (double.Parse(count) * price).ToString();
                    cartList.Items[i].SubItems.Clear();
                    cartList.Items[i].Text = name;
                    cartList.Items[i].SubItems.Add(newPrice);
                    cartList.Items[i].SubItems.Add(count);
                    return;
                }
                else continue;
            }

            //Sepette yoksa ekliyor:
            ListViewItem item = new ListViewItem();
            item.Text = name;
            item.SubItems.Add(price.ToString());
            item.SubItems.Add("1");
            cartList.Items.Add(item);
        }
        public void removeFromCart(int count)
        {
            ListView cartList = Application.OpenForms["FormMenu"].Controls["cartList"] as ListView;

            int index = 0;

            //Sepetteki indexi belirleme:
            for (int i = 0; i < cartList.Items.Count; i++)
            {
                if (cartList.Items[i].Text.Equals(name))
                {
                    index = i;
                }
                else continue;
            }

            //Count 1 ise siliyor, değil ise count ve price azaltıyor:
            if (count == 1)
            {
                cartList.Items[index].Remove();
            }
            else
            {
                cartList.SelectedItems[0].SubItems[1].Text = (double.Parse(cartList.SelectedItems[0].SubItems[1].Text) - price).ToString();
                cartList.SelectedItems[0].SubItems[2].Text = ((count - 1).ToString());
            }
        }
    }
}
