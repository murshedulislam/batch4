using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int size = 10;
            int[] number = new int[size];

            number[3] = 10;
            number[0] = 20;
            number[9] = 30;
            string message = "";
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    message = message + "Element at index [" + index + "]is : " + number[index].ToString() + "\"n;
                        }
            showRichTextBox.Text = message;
        }
      
        private void Form1_Load(object sender, EventArgs e
private void button2_Click_1(object sender, EventArgs e)
        {
            const int size = 10;
            int[] number = new int[size];
        }

        
private void button3_Click_1(object sender, EventArgs e)
        {

            string message = "";
         for (int index = Size-1;index >=0; index--)
            {
                if (number[index] != 0)
                    message = message + "Element at index [" + index + "]is : " + number[index].ToString() + "\"n;
                        }
  
    }
    showRichTextBox.Text = message;
private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    
}
