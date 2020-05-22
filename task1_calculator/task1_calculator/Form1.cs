using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1_calculator
{
    public partial class Form1 : Form
    {

        List<double> inputNumbers = new List<double>();
        List<String> operations = new List<string>();
        double number = 0;
        double numberAfterDot = 0;
        int currentNum = 0;
        String numDot = null;
        bool breakTrigger = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            currentNum = 1;
            if (numDot == null)
            {
                //compute number and show it on display: 
                number = number * 10 + currentNum;
                textBox_Results.Text = number.ToString();
            }

            //for decimal numbers:
            if (numDot != null)
            {
                numberAfterDot = numberAfterDot * 10 + currentNum;
                String decimalNum = number + "," + numberAfterDot;
                textBox_Results.Text = decimalNum;
                number = double.Parse(decimalNum);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            currentNum = 0;
            if (numDot == null)
            {
                number = number * 10 + currentNum;
                textBox_Results.Text = number.ToString();
            }

            if (numDot != null)
            {
                numberAfterDot = numberAfterDot * 10 + currentNum;
                String decimalNum = number + "," + numberAfterDot;
                textBox_Results.Text = decimalNum;
                number = double.Parse(decimalNum);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentNum = 2;
            if (numDot == null)
            {
                number = number * 10 + currentNum;
                textBox_Results.Text = number.ToString();
            }

            if (numDot != null)
            {
                numberAfterDot = numberAfterDot * 10 + currentNum;
                String decimalNum = number + "," + numberAfterDot;
                textBox_Results.Text = decimalNum;
                number = double.Parse(decimalNum);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentNum = 3;
            if (numDot == null)
            {
                number = number * 10 + currentNum;
                textBox_Results.Text = number.ToString();
            }

            if (numDot != null)
            {
                numberAfterDot = numberAfterDot * 10 + currentNum;
                String decimalNum = number + "," + numberAfterDot;
                textBox_Results.Text = decimalNum;
                number = double.Parse(decimalNum);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentNum = 4;
            if (numDot == null)
            {
                number = number * 10 + currentNum;
                textBox_Results.Text = number.ToString();
            }

            if (numDot != null)
            {
                numberAfterDot = numberAfterDot * 10 + currentNum;
                String decimalNum = number + "," + numberAfterDot;
                textBox_Results.Text = decimalNum;
                number = double.Parse(decimalNum);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentNum = 5;
            if (numDot == null)
            {
                number = number * 10 + currentNum;
                textBox_Results.Text = number.ToString();
            }

            if (numDot != null)
            {
                numberAfterDot = numberAfterDot * 10 + currentNum;
                String decimalNum = number + "," + numberAfterDot;
                textBox_Results.Text = decimalNum;
                number = double.Parse(decimalNum);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentNum = 6;
            if (numDot == null)
            {
                number = number * 10 + currentNum;
                textBox_Results.Text = number.ToString();
            }

            if (numDot != null)
            {
                numberAfterDot = numberAfterDot * 10 + currentNum;
                String decimalNum = number+ "," +numberAfterDot;
                textBox_Results.Text = decimalNum;
                number  = double.Parse(decimalNum);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentNum = 7;
            if (numDot == null)
            {
                number = number * 10 + currentNum;
                textBox_Results.Text = number.ToString();
            }

            if (numDot != null)
            {
                numberAfterDot = numberAfterDot * 10 + currentNum;
                String decimalNum = number + "," + numberAfterDot;
                textBox_Results.Text = decimalNum;
                number = double.Parse(decimalNum);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentNum = 8;
            if (numDot == null)
            {
                number = number * 10 + currentNum;
                textBox_Results.Text = number.ToString();
            }

            if (numDot != null)
            {
                numberAfterDot = numberAfterDot * 10 + currentNum;
                String decimalNum = number + "," + numberAfterDot;
                textBox_Results.Text = decimalNum;
                number = double.Parse(decimalNum);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentNum = 9;
            if(numDot == null ){
                number = number * 10 + currentNum;
                textBox_Results.Text = number.ToString();
                }
            
            if(numDot != null)
            {
                numberAfterDot = numberAfterDot * 10 + currentNum;
                String decimalNum = number + "," + numberAfterDot;
                textBox_Results.Text = decimalNum;
                number = double.Parse(decimalNum);
                
            }
        }

        private void button11_Click(object sender, EventArgs e) //. decimal point
        {
            numDot = ",";
            textBox_Results.Text = number+numDot; 
        }

        private void button12_Click(object sender, EventArgs e) // + adding
        {
            inputNumbers.Add(number);
            number = 0;
            numberAfterDot = 0;
            numDot = null;
            String plus = "+";
            operations.Add(plus);
        }

        private void button13_Click(object sender, EventArgs e) // - substracting
        {
            inputNumbers.Add(number);
            number = 0;
            numberAfterDot = 0;
            numDot = null;
            String minus = "-";
            operations.Add(minus);
        }

        private void button14_Click(object sender, EventArgs e) // * multiplying
        {
            inputNumbers.Add(number);
            number = 0;
            numberAfterDot = 0;
            numDot = null;
            String multiply = "*";
            operations.Add(multiply);
        }

        private void button15_Click(object sender, EventArgs e) // / dividing
        {
            inputNumbers.Add(number);
            number = 0;
            numberAfterDot = 0;
            numDot = null;
            String divide = "/";
            operations.Add(divide);
        }

        private void button16_Click(object sender, EventArgs e) // C clear all
        {
            number = 0;
            inputNumbers.Clear();
            operations.Clear();
            textBox_Results.Text = "0";
            numberAfterDot = 0;
            currentNum = 0;
            numDot = null;
        }

        private void button17_Click(object sender, EventArgs e) // = computing
        {
            inputNumbers.Add(number);
            textBox_Results.Text = inputNumbers.ElementAt(0).ToString();
            
            
            for (int i = 0; i <= inputNumbers.Count; i++)
            {
                // * and / have priority
                if (operations.Contains("*")){

                    int isOn = operations.IndexOf("*");
                    double result=inputNumbers.ElementAt(isOn) * inputNumbers.ElementAt(isOn + 1);
                    inputNumbers.RemoveAt(isOn + 1);
                    inputNumbers[isOn]=result;
                    operations.RemoveAt(isOn);
                                        
                }
                else if (operations.Contains("/"))
                {
                    int isOn = operations.IndexOf("/");

                    if(inputNumbers.ElementAt(isOn+1) == 0)
                    {
                        breakTrigger = true; //error:dividing by zero
                        break;
                    }

                    double result = inputNumbers.ElementAt(isOn) / inputNumbers.ElementAt(isOn + 1);
                    inputNumbers.RemoveAt(isOn + 1);
                    inputNumbers[isOn] = result;
                    operations.RemoveAt(isOn);
                    
                }
                //+ and -
                else if (operations.Contains("+"))
                {
                    int isOn = operations.IndexOf("+");
                    double result = inputNumbers.ElementAt(isOn) + inputNumbers.ElementAt(isOn + 1);
                    inputNumbers.RemoveAt(isOn + 1);
                    inputNumbers[isOn] = result;
                    operations.RemoveAt(isOn);
                    
                }
                else if (operations.Contains("-"))
                {
                    int isOn = operations.IndexOf("-");
                    double result = inputNumbers.ElementAt(isOn) - inputNumbers.ElementAt(isOn + 1);
                    inputNumbers.RemoveAt(isOn + 1);
                    inputNumbers[isOn] = result;
                    operations.RemoveAt(isOn);
                    
                }
                
            }

            if (breakTrigger)
            {
                textBox_Results.Text = "Error.";
                breakTrigger = false;
            }
            else
            {
                textBox_Results.Text = inputNumbers.ElementAt(0).ToString();
            }
            
            number = 0;
            inputNumbers.Clear();
            operations.Clear();
            numberAfterDot = 0;
            currentNum = 0;
            numDot = null;
            
        }          
            
    }
}
