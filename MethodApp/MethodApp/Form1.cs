using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodApp
{
    
    public partial class Methods : Form
    {
        public Methods()
        {
            InitializeComponent();
        }

        int size = 5;
        int[] numbers = new int[5];
        int index = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addTextBox_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void AddButton_Click(object sender, EventArgs e)
        {
            
            numbers[index] = Convert.ToInt32(addTextBox.Text);
            showRichTextBox.Text = Show();
            index++;
            addTextBox.Text = "";
        }

        private string Show()
        {
            string message = "";
            for(int index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] != 0)
                {
                    message = message + "Index [" + index.ToString() + "] Value " + numbers[index] + "\n";
                       
                }
            }
            return message;
        }

        private void showRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            showRichTextBox.Text = Show();
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string message = "";
            message = Show();
            message = message + "Reverse values are : \n";
            for(int index = size - 1; index >= 0; index--)
            {
                if (numbers[index] != 0)
                {
                    message = message + "Index [" + index.ToString() + "] Value " + numbers[index] + "\n";
                }
                
            }

            showRichTextBox.Text = message;
        }

       

    }

}
