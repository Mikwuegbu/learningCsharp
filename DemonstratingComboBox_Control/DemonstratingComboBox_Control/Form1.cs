using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemonstratingComboBox_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This event is triggered when new value is typed into the comboBox
        private void comboStephens_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox.Text = comboStephens.Text;
        }

        private void comboStephens_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox.Text = comboStephens.Text;
        }
    }
}
