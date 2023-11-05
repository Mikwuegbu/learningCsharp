using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyNotePad
{
    public partial class mainNote : Form
    {
        public mainNote()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text != string.Empty)
            {
                if (MessageBox.Show("Do you want to save changes to Untitled", "MyNotePad", MessageBoxButtons.YesNoCancel)
                    == DialogResult.Yes)
                {
                                    
                }
            }
        }
    }
}


