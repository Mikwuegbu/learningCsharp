using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemostratingListBox_CLUBFORM
{
    public partial class ClubForm : Form
    {
        public ClubForm()
        {
            InitializeComponent();
        }

        private void lstBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxResult.Text = lstBoxEvents.Text; // This code displays selected Item in the TextBox
            string Result = " ";
            foreach(string activity in lstBoxEvents.SelectedItems)
            {
                Result += activity + "  ";
            }
            txtBoxResult.Text = Result;
            lstBoxEvents.Items.Add("Others");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
           if (txtAddNewEvent.Text == "")
            {
                 MessageBox.Show("Please input an Event", "Error!");   
            }
            else
            {
                lstBoxEvents.Items.Add(txtAddNewEvent.Text);
                txtAddNewEvent.Clear();
            }
        }
    }
}
