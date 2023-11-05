using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Name of Student: IKWUEGBU UCHECHUKWU MARK
//Reg No: MOUAU/CME/16/92564
//Course: CSE 416 (COMMERCIAL PROGRAMMING)

namespace Win_Calc_GUI
{
    public partial class MyBasic_Calc : Form
    {
        //Declaring my Variables

        double value = 0;
        string Operation = " ";
        bool Operation_pressed = false;

        public MyBasic_Calc()
        {
            InitializeComponent();
        }
 

        private void button_Click(object sender, EventArgs e)
        {
            if ((Result.Text == "0")|| (Operation_pressed))
                Result.Clear();
            Operation_pressed = false;

            //Number Input Keys
            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
  
        }

        //BackSpace
        private void button5_Click(object sender, EventArgs e)
        {
            if (Result.Text != string.Empty)
            {
                int ResultTxtLenght = Result.Text.Length;
                if (ResultTxtLenght != 1)
                {
                    Result.Text = Result.Text.Remove(ResultTxtLenght - 1);
                }
                else
                {
                    Result.Text = "0";
                }
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
              Button b = (Button)sender;
              Operation = b.Text;
              value = Double.Parse(Result.Text);
              Operation_pressed = true;
              equation.Text = value + " " + Operation;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch(Operation)
            {
                case "+":
                    Result.Text = (value + Double.Parse(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = (value - Double.Parse(Result.Text)).ToString();
                    break;
                case "*":
                    Result.Text = (value * Double.Parse(Result.Text)).ToString();
                    break;
                case "/":
                    Result.Text = (value / Double.Parse(Result.Text)).ToString();
                    break;
                default:
                    break;

            } //end switch
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
            equation.Text = string.Empty;
        }

        private void button_ClickDot(object sender, EventArgs e)
        {
            if (Result.Text.Contains("."))
            {
                Result.Text = Result.Text;
            }
            else
            {
                Result.Text += ".";
            }
        }
        
    }
}
