using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemonstratingMenuStrip_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a sample of a Menustrip feature\n version 1.0.0"
                + "\nUser LIcense and Agreements has been accepted"
                + "\nYour ID is: DXYHT-23JHU-HDGT6-NKJD4", "About MenuStrip");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you want to save your current word?", "SAVE FILE", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {

            }
            else
            {
                Application.Exit();
            }
        }

        //This menuItem code can change color of texts

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorToolStripMenuItem.ForeColor = colorDialog1.Color;
            if(colorDialog1.ShowDialog() != DialogResult.Abort){
                OutPut.ForeColor = colorDialog1.Color;
            }
        }

        //this MenuItem can change font of texts when clicked

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontToolStripMenuItem.Font = fontDialog1.Font;
            if (fontDialog1.ShowDialog() != DialogResult.Abort)
            {
                OutPut.Font = fontDialog1.Font;
            }
        }
    }
}
