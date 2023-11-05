using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creating_A_TaxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string inValue;
            double purchaseAmt;
            inValue = txtPurchase.Text;
            purchaseAmt = Convert.ToDouble(inValue);
            inValue = label5.Text;
            inValue = inValue.Remove(inValue.Length - 1, 1);
            double percent = Convert.ToDouble(inValue)/100;
            double ans;
            ans = (purchaseAmt + percent) + purchaseAmt;
            txtTotalDue.Text = String.Format("{0:c}", ans);
        }
    }
}
