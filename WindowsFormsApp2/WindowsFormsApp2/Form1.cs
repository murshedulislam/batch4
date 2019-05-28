using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const int size = 10;
            string[] Name = new string[size];
            string[] Mobile_No = new string[size];
            string[] Address = new string[size];
            string[] Item = new string[size];
            int[] quantity = new int[size];
            int[] Rate = new int[size];
            int[] TotalPrice = new int[size];
            int Index = 0;
           int SearchRate(int item)
            {
                int FixdReat = 0;
                if (item == 0)
                { FixdReat = 0; }
                else if (item == 1)
                { FixdReat = 120; }
                else if (item == 2)
                { FixdReat = 100; }
                else if (item == 3)
                { FixdReat = 90; }
                else if (item == 4)
                { FixdReat = 80; }
                return FixdReat;
            }

            void Clear()
            {
                nameTextBox.Text = "";
                contactNoTextBox.Text = "";
                addressTextBox.Text = "";
                orderComboBox.Text = "";
                quantityTextBox.Text = "";
            }
            void AddButton_Click(object EventArgs )
            {
                string Output = "";
                int rate = SearchRate(Convert.ToInt32(orderComboBox.SelectedIndex));
                int Quantity = Convert.ToInt32(quantityTextBox.Text);
                int price = rate * Quantity;
                Name[Index] = nameTextBox.Text;
                Mobile_No[Index] = contactNoTextBox.Text;
                Address[Index] = addressTextBox.Text;
                Item[Index] = orderComboBox.Text;
                quantity[Index] = Quantity;
                Rate[Index] = rate;
                TotalPrice[Index] = price;
                Index++;
                for (int i = 0; i < Name.Length; i++)
                {
                    if (!string.IsNullOrEmpty(Name[i]))
                    {
                        Output = Output + "Customer Name is : " + Name[i] + Environment.NewLine + "Mobile No : " + Mobile_No[i] +
                               Environment.NewLine + "Address : " + Address[i] + Environment.NewLine + "Item Name : " +
                               Item[i] + Environment.NewLine + "Rate : " + Rate[i] + Environment.NewLine + "Quantity :" +
                               quantity[i] + Environment.NewLine + "Total Price : " + TotalPrice[i] + Environment.NewLine + "Thank You Sir \n" +
                               Environment.NewLine + Environment.NewLine;
                    }
                }
                OutputTextBox.Text = Output;
                Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
