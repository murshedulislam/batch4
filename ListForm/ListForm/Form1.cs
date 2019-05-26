using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListForm
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {

        }

        private void addTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        int index = 0;
        List<int> numbers = new List<int>();
        string message = "";
        private void AddButton_Click(object sender, EventArgs e)
        {
            
            numbers.Add(Convert.ToInt32(addTextBox.Text));
           
            addTextBox.Text = "";
            message = message + "Index [" + index.ToString() + "] Value" + numbers[index].ToString() + "\n";
            index++;
            showRichTextBox.Text = message;
        }

        private void showRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            message = "";
            foreach(int number in numbers)
            {
                message = message + number.ToString() + "\n";
            }
            showRichTextBox.Text = message;

        }
    }
}
