using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float num1;
        string process = "";
        
        public Form1()
        {
            InitializeComponent();
            tbDisplay.AutoEllipsis = true;
            clearSymbolLabel();
        }

        void clearSymbolLabel()
        {
            tbSymDisplay.Text = "";
        }
        
        void enableSymbols()
        {
            btnSymMinus.Enabled = true;
            btnSymPlus.Enabled = true;
            btnSymMul.Enabled = true;
            btnSymDiv.Enabled = true;
            btnSymDot.Enabled = true;
        }
        void disableSymbols()
        {
            btnSymMinus.Enabled = false;
            btnSymPlus.Enabled = false;
            btnSymMul.Enabled = false;
            btnSymDiv.Enabled = false;
            btnSymDot.Enabled = false;
        }
        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" || tbDisplay.ForeColor == Color.Gray)
            {
                tbDisplay.Text = "";
            }
            tbDisplay.Text = tbDisplay.Text + btnNum0.Text;
            tbDisplay.ForeColor = Color.White;
            clearSymbolLabel();
            enableSymbols();
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" || tbDisplay.ForeColor == Color.Gray)
            {
                tbDisplay.Text = "";
            }

            tbDisplay.Text = tbDisplay.Text + btnNum1.Text;
            tbDisplay.ForeColor = Color.White;
            clearSymbolLabel();
            enableSymbols();
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" || tbDisplay.ForeColor == Color.Gray)
            {
                tbDisplay.Text = "";
            }

            tbDisplay.Text = tbDisplay.Text + btnNum2.Text;
            tbDisplay.ForeColor = Color.White;
            clearSymbolLabel();
            enableSymbols();
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" || tbDisplay.ForeColor == Color.Gray)
            {
                tbDisplay.Text = "";
            }

            tbDisplay.Text = tbDisplay.Text + btnNum3.Text;
            tbDisplay.ForeColor = Color.White;
            clearSymbolLabel();
            enableSymbols();
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" || tbDisplay.ForeColor == Color.Gray)
            {
                tbDisplay.Text = "";
            }

            tbDisplay.Text = tbDisplay.Text + btnNum4.Text;
            tbDisplay.ForeColor = Color.White;
            clearSymbolLabel();
            enableSymbols();
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" || tbDisplay.ForeColor == Color.Gray)
            {
                tbDisplay.Text = "";
            }

            tbDisplay.Text = tbDisplay.Text + btnNum5.Text;
            tbDisplay.ForeColor = Color.White;
            clearSymbolLabel();
            enableSymbols();
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" || tbDisplay.ForeColor == Color.Gray)
            {
                tbDisplay.Text = "";
            }

            tbDisplay.Text = tbDisplay.Text + btnNum6.Text;
            tbDisplay.ForeColor = Color.White;
            clearSymbolLabel();
            enableSymbols();
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" || tbDisplay.ForeColor == Color.Gray)
            {
                tbDisplay.Text = "";
            }

            tbDisplay.Text = tbDisplay.Text + btnNum7.Text;
            tbDisplay.ForeColor = Color.White;
            clearSymbolLabel();
            enableSymbols();
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" || tbDisplay.ForeColor == Color.Gray)
            {
                tbDisplay.Text = "";
            }

            tbDisplay.Text = tbDisplay.Text + btnNum8.Text;
            tbDisplay.ForeColor = Color.White;
            clearSymbolLabel();
            enableSymbols();
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" || tbDisplay.ForeColor == Color.Gray)
            {
                tbDisplay.Text = "";
            }

            tbDisplay.Text = tbDisplay.Text + btnNum9.Text;
            tbDisplay.ForeColor = Color.White;
            clearSymbolLabel();
            enableSymbols();
        }

        private void btnSymClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "0";
            tbDisplay.ForeColor = Color.White;
            enableSymbols();
        }
        private void btnSymPlus_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text != "")
            {
                num1 = float.Parse(tbDisplay.Text);
                tbDisplay.Focus();
                process = "plus";
                tbSymDisplay.Text = btnSymPlus.Text;
                tbDisplay.ForeColor = Color.Gray;
                disableSymbols();
            }

        }


        private void btnSymMinus_Click(object sender, EventArgs e)
        {
            if(tbDisplay.Text != "")
            {
                num1 = float.Parse(tbDisplay.Text);
                tbDisplay.Focus();
                process = "minus";
                tbSymDisplay.Text = btnSymPlus.Text;
                tbDisplay.ForeColor = Color.Gray;
                disableSymbols();
            }

        }

        private void btnSymMul_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text != "")
            {
                num1 = float.Parse(tbDisplay.Text);

                tbDisplay.Focus();
                process = "multiply";
                tbSymDisplay.Text = btnSymPlus.Text;
                tbDisplay.ForeColor = Color.Gray;
                disableSymbols();
            }
        }

        private void btnSymDiv_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text != "")
            {
                num1 = float.Parse(tbDisplay.Text);

                tbDisplay.Focus();
                process = "divide";
                tbSymDisplay.Text = btnSymPlus.Text;
                tbDisplay.ForeColor = Color.Gray;
                disableSymbols();
            }
        }

        private void btnSymEqu_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text != "")
            {
                compute(process);
            }
            void compute(string process)
            {
                float answer = 0;

                if(process == "plus")
                {
                    answer = num1 + float.Parse(tbDisplay.Text);
                    tbDisplay.Text = answer.ToString();
                }
                else if (process == "minus")
                {
                    answer = num1 - float.Parse(tbDisplay.Text);
                    tbDisplay.Text = answer.ToString();
                }
                else if (process == "multiply")
                {
                    answer = num1 * float.Parse(tbDisplay.Text);
                    tbDisplay.Text = answer.ToString();
                }
                else if (process == "divide")
                {
                    answer = num1 / float.Parse(tbDisplay.Text);
                    tbDisplay.Text = answer.ToString();
                }
                enableSymbols();
            }
        }

        private void btnSymDot_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text != "")
            {
                tbDisplay.Text = (float.Parse(tbDisplay.Text) / 10).ToString();
                tbDisplay.ForeColor = Color.White;
                clearSymbolLabel();
                enableSymbols();
            }


        }
    }
}
