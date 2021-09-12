using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorTestWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        double num;
        char operation;
        bool isShow = false;
        private void btnClicked(object sender, EventArgs e)
        {
            if (isShow == true)
            {
                txtAnswer.Text = string.Empty;
                isShow = false;
            }
            Button btn = sender as Button;
            switch (btn.Text)
            {
                case "0": txtAnswer.Text += "0";lblRes.Text+="0"; break;
                case "1": txtAnswer.Text += "1"; lblRes.Text += "1"; break;
                case "2": txtAnswer.Text += "2"; lblRes.Text += "2"; break;
                case "3": txtAnswer.Text += "3"; lblRes.Text += "3"; break;
                case "4": txtAnswer.Text += "4"; lblRes.Text += "4"; break;
                case "5": txtAnswer.Text += "5"; lblRes.Text += "5"; break;
                case "6": txtAnswer.Text += "6"; lblRes.Text += "6"; break;
                case "7": txtAnswer.Text += "7"; lblRes.Text += "7"; break;
                case "8": txtAnswer.Text += "8"; lblRes.Text += "8"; break;
                case "9": txtAnswer.Text += "9"; lblRes.Text += "9"; break;
                case ".": txtAnswer.Text += "."; lblRes.Text += "."; break;
                default: txtAnswer.Text += string.Empty; break;
            }
        }

        private void operatorClicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            num = double.Parse(txtAnswer.Text);
            lblRes.Text = txtAnswer.Text;
            isShow = true;
            switch (btn.Text)
            {
                case "+": operation = '+'; lblRes.Text+=" + "; break;
                case "-": operation = '-'; lblRes.Text += " - "; break;
                case "*": operation = '*'; lblRes.Text += " * "; break;
                case "/": operation = '/'; lblRes.Text += " / "; break;
                case "%": operation = '%'; lblRes.Text += " % "; break;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondNum = double.Parse(txtAnswer.Text);
            switch (operation)
            {
                case '+': txtAnswer.Text = (num + secondNum).ToString(); lblRes.Text+="="+txtAnswer.Text; break;
                case '-': txtAnswer.Text = (num - secondNum).ToString(); lblRes.Text += "=" + txtAnswer.Text; break;
                case '*': txtAnswer.Text = (num * secondNum).ToString(); lblRes.Text += "=" + txtAnswer.Text; break;
                case '/': if (secondNum == 0) { txtAnswer.Text = lblRes.Text = "Cannot Divide By Zero"; } else { txtAnswer.Text = (num / secondNum).ToString(); lblRes.Text += txtAnswer.Text; } break;
                case '%': txtAnswer.Text = (num % secondNum).ToString(); lblRes.Text += "=" + txtAnswer.Text; break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = string.Empty;
            lblRes.Text = string.Empty;
        }

        private void btnSqRoot_Click(object sender, EventArgs e)
        {
            if (num != 0)
            {
                txtAnswer.Text = (Math.Sqrt(num)).ToString();
                lblRes.Text = txtAnswer.Text;
            }
        }

    }
}
