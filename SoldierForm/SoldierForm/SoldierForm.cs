using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoldierForm
{
    public partial class SoldierForm : Form
    {
        public SoldierForm()
        {
            InitializeComponent();
        }
        List<string> numbers = new List<string>();
        List<string> names = new List<string>();
        List<double> averages = new List<double>();
        List<int> totals = new List<int>();
        private void SvaeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string number = soldierNumTextBox.Text;
                string name = soldierNameTextBox.Text;
                string test1 = scoreOneTextBox.Text;
                string test2 = scoreTwoTextBox.Text;
                string test3 = scoreThreeTextBox.Text;
                string test4 = scoreFourTextBox.Text;
                soldierNumLabel.Text = "";

                if (String.IsNullOrEmpty(number))
                {
                    soldierNumLabel.Text = "Name field cannot be empty";
                    return;
                }
                foreach (string numchk in numbers)
                {
                    if (numchk == number)
                    {
                        soldierNumLabel.Text = "Soldier Name already exists";
                        return;
                    }
                }

                for (int i = 0; i < test1.Length; i++)
                {
                    if (!Char.IsDigit(test1[i]))
                    {
                        scoreOneTextBox.Text = "";
                        return;
                    }
                }
                for (int i = 0; i < test2.Length; i++)
                {
                    if (!Char.IsDigit(test2[i]))
                    {
                        scoreTwoTextBox.Text = "";
                        return;
                    }
                }
                for (int i = 0; i < test3.Length; i++)
                {
                    if (!Char.IsDigit(test3[i]))
                    {
                        scoreThreeTextBox.Text = "";
                        return;
                    }
                }
                for (int i = 0; i < test4.Length; i++)
                {
                    if (!Char.IsDigit(test4[i]))
                    {
                        scoreFourTextBox.Text = "";
                        return;
                    }
                }
                double average = (Convert.ToInt32(test1) + Convert.ToInt32(test2) + Convert.ToInt32(test3) + Convert.ToInt32(test4)) / 4.0;
                int total = Convert.ToInt32(test1) + Convert.ToInt32(test2) + Convert.ToInt32(test3) + Convert.ToInt32(test4);
                numbers.Add(number);
                names.Add(name);
                averages.Add(average);
                totals.Add(total);
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
            message = "Soldier NO.\t|Soldier Name\t|Average Score\t|Total Score\n";
            for (int index = 0; index < names.Count; index++)
            {
                message = message + numbers[index] + "\t" + names[index] + "\t" + averages[index] + "\t" + totals[index] + "\n";
            }
            return message;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {


            string message;
            int count =0;
            if (numberRadioButton.Checked == true)
            {
                count = 0;
                message = "";
                string number = searchTextBox.Text;
                for (int index = 0; index < numbers.Count; index++)
                {
                    if (number == numbers[index])
                    {
                        count++;
                        message = "Soldier NO.\t|Soldier Name\t|Average Score\t|Total Score\n";
                        message = message + numbers[index] + "\t" + names[index] + "\t" + averages[index] + "\t" + totals[index] + "\n";
                    }
                }
                displayRichTextBox.Text = message;
            }

            

            if (nameRadioButton.Checked == true)
            {
                count = 0;
                message = "";
                string name = searchTextBox.Text;
                for (int index = 0; index < names.Count; index++)
                {
                    if (name == names[index])
                    {
                        count++;
                        message = "Soldier NO.\t|Soldier Name\t|Average Score\t|Total Score\n";
                        message = message + numbers[index] + "\t" + names[index] + "\t" + averages[index] + "\t" + totals[index] + "\n";
                    }
                }
                displayRichTextBox.Text = message;
               

            }

            if (count == 0)
            {
                searchLabel.Text = "Person Not found";
            }

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            displayRichTextBox.Text = Display();
            int max = totals[0];
            for(int i = 0; i < totals.Count; i++)
            {
                if (max < totals[i])
                    max = totals[i];
            }
            scoreTextBox.Text = max.ToString();
            double max1 = averages[0];
            for (int i = 0; i < averages.Count; i++)
            {
                if (max1 < averages[i])
                    max1 = averages[i];
            }
            averageTextBox.Text = max1.ToString();

        }
    }
}
