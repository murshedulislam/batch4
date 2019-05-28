using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class ArrayForm : Form
    {
        public ArrayForm()
        {
            InitializeComponent();
        }

        private void ArrayForm_Load(object sender, EventArgs e)
        {

            showRichTextBox.Text = Message;

        }
        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string message = "";
            for (int index = size - 1; index >= 0; index--)
                if
        }
    }
}
