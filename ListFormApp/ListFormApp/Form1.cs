using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListFormApp
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }
        List<int> numbers = new List<int>();
        List<string> names = new List<string>();
        private void ListForm_Load(object sender, EventArgs e)
        {

        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            numbers.Add(Convert.ToInt32(numberTextBox.Text));
            names.Add(nameTextBox.Text);
            numberTextBox.Text = "";
            nameTextBox.Text = "";
        }

        private void showRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowBoxButton_Click(object sender, EventArgs e)
        {
            string message = "";
            int index = 0;
            foreach (int number in numbers)
            {
                message = message + "Names :"+names[index] + " Number :"+number.ToString()+"\n";
                index++;
            }

            showRichTextBox.Text = message;
        }
    }
}
