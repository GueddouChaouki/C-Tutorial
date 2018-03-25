using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
namespace calculator
{
    public partial class Form1 : MetroForm
    {
        double number1 = 0.0;
        double number2 = 0.0;
        char operation = ' ';
        double result = 0.0;
        public Form1()
        {
            InitializeComponent ();
        }

        private void Form1_Load( object sender , EventArgs e )
        {

        }

        private void buttonX01_Click( object sender , EventArgs e )
        {
            textBoxX1.Text += "1";
        }

        private void buttonX02_Click( object sender , EventArgs e )
        {
            textBoxX1.Text += "2";
        }

        private void buttonX03_Click( object sender , EventArgs e )
        {
            textBoxX1.Text += "3";
        }

        private void buttonX04_Click( object sender , EventArgs e )
        {
            textBoxX1.Text += "4";
        }

        private void buttonX05_Click( object sender , EventArgs e )
        {
            textBoxX1.Text += "5";
        }

        private void buttonX06_Click( object sender , EventArgs e )
        {
            textBoxX1.Text += "6";
        }

        private void buttonX07_Click( object sender , EventArgs e )
        {
            textBoxX1.Text += "7";
        }

        private void buttonX08_Click( object sender , EventArgs e )
        {
            textBoxX1.Text += "8";
        }

        private void buttonX09_Click( object sender , EventArgs e )
        {
            textBoxX1.Text += "9";
        }

        private void buttonX00_Click( object sender , EventArgs e )
        {
            textBoxX1.Text += "0";
        }

        private void buttonXDot_Click( object sender , EventArgs e )
        {
            textBoxX1.Text += ".";

        }

        private void buttonXPlus_Click( object sender , EventArgs e )
        {
            number1 = Convert.ToDouble(textBoxX1.Text);
            textBoxX2.Clear ();
            textBoxX2.Text += textBoxX1.Text+"+";
            textBoxX1.Clear();
            operation = '+';
        }

        private void buttonXMinus_Click( object sender , EventArgs e )
        {
            number1 = Convert.ToDouble ( textBoxX1.Text );
            textBoxX2.Clear ();
            textBoxX2.Text += textBoxX1.Text+"-";
            textBoxX1.Clear();
            operation = '-';
        }

        private void buttonXMult_Click( object sender , EventArgs e )
        {
            number1 = Convert.ToDouble ( textBoxX1.Text );
            textBoxX2.Clear ();
            textBoxX2.Text += textBoxX1.Text+"*";
            textBoxX1.Clear();
            operation = '*';
        }

        private void buttonXDivision_Click( object sender , EventArgs e )
        {
                number1 = Convert.ToDouble ( textBoxX1.Text );
                textBoxX2.Clear ();
                textBoxX2.Text += textBoxX1.Text+"/";
                textBoxX1.Clear ();
                operation = '/';                
        }

        private void buttonXEquals_Click( object sender , EventArgs e )
        {
            
                number2 = Convert.ToDouble ( textBoxX1.Text );
                textBoxX2.Text += textBoxX1.Text;
            switch (operation)
            {
                case '+':
                    
                    result = number1 + number2;
                    textBoxX1.Text = Convert.ToString ( result );
                    break;
                    
                case '-':
                    result = number1 - number2;
                    textBoxX1.Text = Convert.ToString ( result );
                    break;

                case '*':
                    result = number1 * number2;
                    textBoxX1.Text = Convert.ToString ( result );
                    break;

                case '/':
                    result = number1 / number2;
                    textBoxX1.Text = Convert.ToString ( result );
                    break;

                default:
                    textBoxX1.Text = "ERROR";
                    break;

                 

            }
        }

        private void buttonXDelete_Click( object sender , EventArgs e )
        {

           
            MessageBoxEx .Show("not implemented");
            
        }

        private void buttonXBack_Click( object sender , EventArgs e )
        {
            textBoxX1.Clear();
        }

        private void textBoxX2_TextChanged( object sender , EventArgs e )
        {

        }
    }
}
