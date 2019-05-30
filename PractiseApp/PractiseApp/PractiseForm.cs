using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractiseApp
{
    public partial class PractiseForm : Form
    {
        public PractiseForm()
        {
            InitializeComponent();
        }
        List<string> users = new List<string>();
        List<string> names = new List<string>();
        List<int> ages = new List<int>();

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string user = userTextBox.Text;
                string name = nameTextBox.Text;
                int age = Convert.ToInt32(ageTextBox.Text);

                if (string.IsNullOrEmpty(userTextBox.Text))
                {
                    MessageBox.Show("User ShOULD NOT BE EMPLTY");
                    return;
                }
                if (UserExists(userTextBox.Text))
                {
                    MessageBox.Show("User already exist!");
                    return;
                }

                if (string.IsNullOrEmpty(ageTextBox.Text))
                {
                    MessageBox.Show("Age ShOULD NOT BE EMPLTY");
                    return;
                }



                //age = Convert.ToInt32(ageTextBox.Text);
                users.Add(user);
                names.Add(name);
                ages.Add(age);
                displayRichTextBox.Text = Display();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }
         private string Display()
        {
            string message = "";
            message = "SI\tUser\tName\tAge\n";
            int index = 0;
           
            foreach (string user in users)
            {
                message = message +(index+1)+ "\t" + user + "\t" + names[index] + "\t" + ages[index] + "\n";
                index++;
            }
            return message;
        }
        private bool UserExists(string user)
        {
            bool isExist = false;

            foreach(var userchk in users)
            {
                if (userchk == user)
                    isExist = true;
            }
            return isExist;
        }

        private void PractiseForm_Load(object sender, EventArgs e)
        {

        }
    }

 }

       

           


   
    

