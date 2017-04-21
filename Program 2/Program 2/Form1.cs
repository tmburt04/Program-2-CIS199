// Tim Burton
// Program 2
// 3-10
// CIS 199-75-4152
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form1 : Form
    {
        string day; // actual Registration day
        string day1 = "Wednesday, April 1st ", day2 = "Thursday, April 2nd ", day3 = "Friday, April 3rd ", day4 = "Monday, April 6th ", day5 = "Tuesday, April 7th ", day6 = "Wednesday, April 8th "; // defines the possible registration days
        string time; // actual Registration time
        string time1 = "8:30", time2 = "10:00", time3 = "11:30", time4 = "2:00", time5 = "4:00"; // Possible registration times
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text; // gets last name from user
            char letter = name[0]; // converts last name to first letter of last name
            if (SeniorRadioButton.Checked || JuniorRadioButton.Checked)
            {
                if (SeniorRadioButton.Checked)
                {
                    day = day1;
                }
                else
                {
                    day = day2;
                }
                if (letter <= 'a' || letter >= 'd')
                {
                    time = time2;
                }
                else if (letter <= 'e' || letter >= 'i')
                {
                    time = time3;
                }
                else if (letter <= 'j' || letter >= 'o')
                {
                    time = time4;
                }
                else if (letter <= 'p' || letter >= 's')
                {
                    time = time5;
                }
                else
                {
                    time = time1;
                }
            }

            if (SophomoreRadioButton.Checked || FreshmanRadioButton.Checked)
            {
                if (SophomoreRadioButton.Checked)
                {
                    if (letter <= 'f' || letter >= 't')
                    {
                        day = day3;
                    }
                    else
                    {
                        day = day4;
                    }
                }
                else
                {
                    if (letter <= 'f' || letter >= 't')
                    {
                        day = day5;
                    }
                    else
                    {
                        day = day6;
                    }
                }
                if (letter <= 'b' || (letter >= 'm' || letter <= 'o'))
                {
                    time = time3;
                }
                else if ((letter >= 'c' || letter <= 'd') || (letter >= 'p' || letter <= 'q'))
                {
                    time = time4;
                }
                else if ((letter >= 'e' || letter <= 'f') || (letter >= 'r' || letter <= 's'))
                {
                    time = time5;
                }
                else if ((letter >= 't' || letter <= 'v') || (letter >= 'g' || letter <= 'i'))
                {
                    time = time1;
                }
                else if ((letter >= 'w' || letter <= 'z') || (letter >= 'j' || letter <= 'l'))
                {
                    time = time2;
                }
            }
            MessageBox.Show("You may register " + day + "at " + time + "."); // Tells user the registration day
        }
    }
}

