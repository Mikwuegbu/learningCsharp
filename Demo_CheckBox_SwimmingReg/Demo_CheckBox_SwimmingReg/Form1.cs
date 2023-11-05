using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Programming_Courses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkAll_Click(object sender, EventArgs e)
        {
           
        }

        private void ComputeCost_checkedChanged(object sender, EventArgs e)
        {
            //this method is for the checkboxes

           

            decimal Cost = 0;


            if (chkCsharp.Checked)
            {
                Cost += 20.77m;

            }
            if (chkPython.Checked)
            {
                Cost += 40.90m;
            }
            if (chkJS.Checked)
            {
                Cost += 9.00m;
            }
            if (chkC.Checked)
            {
                Cost += 19.00m;
            }
            if (chkJava.Checked)
            {
                Cost += 55.90m;
            }

            //This methods is for the radio button

            if (radBeginner.Checked)
            {
                Cost += 10;
                newLabel.Text = "Extra $10";
            }
            if (radInterm.Checked)
            {
                Cost -= 10;
                newLabel.Text = "";
            }
            if (radAdvanced.Checked)
            {
                Cost -= 15;
                newLabel.Text = "Discount $15";
            }
            TotalResult.Text = Cost.ToString();
        }
    }
}
