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
        private void PractiseForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string user = userTextBox.Text;
                string name;
                int age;
                string chkage = ageTextBox.Text;
                checkLabel.Text = "";
                checkAgeLabel.Text = "";

                if (UserExists(user))
                {
                    checkLabel.Text = user + " already exists";
                    return;
                }
                if (String.IsNullOrEmpty(user))
                {
                    checkLabel.Text = "User Field is empty";
                    return;
                }

                if (String.IsNullOrEmpty(ageTextBox.Text))
                {
                    checkAgeLabel.Text = "The age field is empty.";
                    return;
                }
                for(int i = 0; i < (ageTextBox.Text).Length; i++)
                {
                    if (!Char.IsDigit(chkage[i]))
                    {
                        checkAgeLabel.Text = "The age field will only contain integers.";
                        return;
                    }
                }

                user = userTextBox.Text;
                name = nameTextBox.Text;
                age = Convert.ToInt32(ageTextBox.Text);

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
            message = "SI\tUsers\tNames\tAges\n";
            for(int index = 0; index < users.Count; index++)
            {
                message = message + index + "\t" + users[index] + "\t" + names[index] + "\t" + ages[index] + "\n";
            }
            return message;

        }
        
        private bool UserExists(string user)
        {
            bool isExists = false;

            foreach(string userchk in users)
            {
                if (userchk == user)
                    isExists = true;
            }

            return isExists;
        }

            }

        }

       

           


   
    

