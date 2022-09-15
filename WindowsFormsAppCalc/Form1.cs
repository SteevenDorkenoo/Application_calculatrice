using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.IO;
using System.Security;

namespace WindowsFormsAppCalc
{
    public partial class FormCalc : Form
    {
        private string strnb1, strnb2, operateur;
        public FormCalc()
        {
            InitializeComponent();
            this.strnb1 = this.strnb2 = this.operateur = "";
        }

        private void TraiteBtn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string str = b.Text;

            if (this.operateur == "")
            {
                if (str == ",")
                    strnb1 += ",";
                else
                    strnb1 += b.Text;
                textBoxRes.Text = strnb1;
            }
            else
            {
                if (str == ",")
                    strnb2 += ",";
                else
                    strnb2 += b.Text;
                textBoxRes.Text = strnb2;
            }  
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            double nb1 = Convert.ToDouble(this.strnb1);
            double cosnb1 = Math.Cos(nb1);
            string res = cosnb1.ToString();
            res = res.Substring(0, 16);
            textBoxRes.Text = res;
            this.strnb1 = res;
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            double nb1 = Convert.ToDouble(this.strnb1);
            double cosnb1 = Math.Sin(nb1);
            string res = cosnb1.ToString();
            res = res.Substring(0, 16);
            textBoxRes.Text = res;
            this.strnb1 = res;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            this.operateur = "+";
        }

        private void buttonMoins_Click(object sender, EventArgs e)
        {
            this.operateur = "-";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            this.operateur = "*";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            this.operateur = "/";
        }

        private void buttonEgal_Click(object sender, EventArgs e)
        {
            double nb1 = Convert.ToDouble(this.strnb1);
            double nb2 = Convert.ToDouble(this.strnb2);
            double res = 0;
            switch (this.operateur)
            {
                case "+":
                    res = nb1 + nb2;
                    break;
                case "-":
                    res = nb1 - nb2;
                    break;
                case "*":
                    res = nb1 * nb2;
                    break;
                case "/":
                    res = nb1 / nb2;
                    break;
            }

            textBoxRes.Text = res.ToString();
        }

        private void buttonRac_Click(object sender, EventArgs e)
        {
            double nb1 = Convert.ToDouble(this.strnb1);
            double cosnb1 = Math.Sqrt(nb1);
            string res = cosnb1.ToString();
            res = res.Substring(0, 16);
            textBoxRes.Text = res;
            this.strnb1 = res;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            this.strnb1 = this.strnb2 = this.operateur = "";
            textBoxRes.Text = "";

        }


    }
}
