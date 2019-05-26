using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayIteration
{
    public partial class Array : Form
    {
        const int size = 5;
        int[] number = new int[size];
        int index = 0;
        public Array()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void displayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void arrayNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            number[index] = Convert.ToInt32(arrayNum.Text);
            arrayNum.Text = "";
            index++;
            string message = "";
            for(int index = 0; index < number.Length; index++)
            {
                if(number[index]!=0)
                    message = message + "Index " + index + " value "+ number[index].ToString() + "\n";
            }
            displayBox.Text = message;
        }

        private void displayBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string message = "";
            for(int index = size-1; index >= 0; index--)
            {
                if (number[index] != 0)
                    message =message + "Index "+index + " Value "+ number[index].ToString() + "\n";
            }
            displayBox2.Text = message;
        }

        private void displaySum_TextChanged(object sender, EventArgs e)
        {

        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int index =0; index < number.Length; index++)
            {
                if(number[index]!=0)
                    sum = sum +number[index];
            }
            displaySum.Text = "Summation = " + sum.ToString();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            int[] number2 = new int[size];
            string message = "";
            for(int index=0; index < number.Length; index++)
            {
                if (number[index] != 0)
                {
                    number2[index] = number[index];
                    message = message + "Index " + index + " Value " + number2[index].ToString() + "\n";
                }
                   
            }
            displaySum.Text = message;
        }

        private void DuplicateButton_Click(object sender, EventArgs e)
        {
            
            string message = "";
            foreach(int j in number)
            {
                
                int count = 1;
                for (int i = 0; i < number.Length; i++)
                {
                    if(j == number[i])
                    {
                        count++;
                        
                    }
                }
                if (count > 1)
                {
                    message = message + "Duplicate = " + j + "\n";
                   
                }
            }
            displaySum.Text = message;
        }
    }
}
