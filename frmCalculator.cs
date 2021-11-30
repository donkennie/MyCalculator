using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool blnFirstNumber;
            bool blnSecondNumber;
            string strFirstNumber = txtFirstNumber.Text;
            string strSecondNumber = txtSecondNumber.Text;
            blnFirstNumber = CheckIfStringIsValidNumber(strFirstNumber);
            blnSecondNumber = CheckIfStringIsValidNumber(strSecondNumber);
            if(blnFirstNumber == true && blnSecondNumber == true)
            {
                lblAnswer.Text = (double.Parse(strFirstNumber) + double.Parse(strSecondNumber)).ToString();
            }
            else
            {
                MessageBox.Show("Please enter a number", "Error");
            }
        
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            bool blnFirstNumber;
            bool blnSecondNumber;
            string strFirstNumber = txtFirstNumber.Text;
            string strSecondNumber = txtSecondNumber.Text;
            blnFirstNumber = CheckIfStringIsValidNumber(strFirstNumber);
            blnSecondNumber = CheckIfStringIsValidNumber(strSecondNumber);
            if (blnFirstNumber == true && blnSecondNumber == true)
            {
                lblAnswer.Text = (double.Parse(strFirstNumber) - double.Parse(strSecondNumber)).ToString();
            }
            else
            {
                MessageBox.Show("Please enter a number", "Error");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = (double.Parse(txtFirstNumber.Text) * double.Parse(txtSecondNumber.Text)).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = (double.Parse(txtFirstNumber.Text) / double.Parse(txtSecondNumber.Text)).ToString();
        }

        private bool CheckIfStringIsValidNumber(string strStringInQuestion)
        {
            bool blnFlag = false;
            foreach (char character in strStringInQuestion)
            {

                if (character > '0' && character < '9')
                {
                    blnFlag = true;
                }

                else if (txtFirstNumber.Text== "." || txtFirstNumber.Text== "0")
                {
                    if (!txtFirstNumber.Text.Contains("."))
                    {
                        blnFlag = false;
                    }
                    blnFlag =true;
                    
                }
                else if (txtFirstNumber.Text.Contains("-"))
                {
                    blnFlag = true;
                    if (!txtFirstNumber.Text.Contains("-"))
                    {
                        blnFlag = false;
                    }
                }
                else
                {
                    blnFlag = false;
                    break;
                }
                
            }
            return blnFlag;
        }
    }
}
