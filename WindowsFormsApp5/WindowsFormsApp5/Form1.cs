using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
      
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();
           

            string message = "For\n";
            for (int i= 0; i< numbers.Count; i ++)
            {
                message = message + numbers[i] + "\n";
            

            }
            message = message + "Foreach\n";
            foreach (int number in numbers)
            {
                message = message + numbers + "\n";
            }

            showRichTextBox.Text = message;

        }
    }
}
