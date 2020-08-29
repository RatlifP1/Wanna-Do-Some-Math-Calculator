/* 
Class:			ISTA 220 Programming Fundamentals in C#
Student:		Paul J. Ratliff
Instructor:		Christine Lee
Date:			07/08/2020
Description:	The app will ask the user which type of mathematical action 
                they would like or if they wish to exit, if the user inputs 
                a mathematical operator then ask the user  to provide 2 numbers; 
                if the user inputs something other than a math operator the 
                program writes to the screen "Thanks for stopping by!" and exits. 

                Notes: 
                
                sending the form to another form and closing the orginal for when there is an error https://www.youtube.com/watch?v=T06aHrAqfRw

Revised:
Revised by:
Revision:

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3DMathApp_RatliffPaul07292020
{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (expressionName.Text == "ADD")
                {
                    expEntry.Text = "+";
                    addValues();
                }
                else if (expressionName.Text == "SUBTRACT")
                {
                    expEntry.Text = "-";
                    subtractValues();
                }
                else if (expressionName.Text == "DIVIDE")
                {
                    expEntry.Text = "/";
                    divideValues();
                }
                else if (expressionName.Text == "MULTIPLY")
                {
                    expEntry.Text = "*";
                    multiplyValues();
                }
                else
                {
                    this.Close();
                    th = new Thread(opennewform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }

            }
            catch (DivideByZeroException)
            {
                formula.Text = "You tried to divide by zero. Try again";

            }

            catch (FormatException fEx)
            {
                result.Text = fEx.Message;
                this.Close();
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            catch (OverflowException oEx)
            {
                result.Text = oEx.Message;
                this.Close();
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            catch (InvalidOperationException ioEx)
            {
                result.Text = ioEx.Message;
                this.Close();
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            catch (Exception ex)
            {
                result.Text = ex.Message;

                this.Close();
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            finally
            {
                correct.Text = "IS THERE ANY MESSAGES IN YOUR FORMUALA";
            }

        }

        private void opennewform(object obj)
        {
            Application.Run(new CloseingMessage());
        }
        private void addValues()

        {
            int lhs = int.Parse(mathB1.Text);
            int rhs = int.Parse(mathB2.Text);
            int outcome = 0;
            outcome = lhs + rhs;
            formula.Text = $"{lhs} + {rhs}";
            result.Text = outcome.ToString();
        }
        private void subtractValues()
        {
            int lhs = int.Parse(mathB1.Text);
            int rhs = int.Parse(mathB2.Text);
            int outcome = 0;
            outcome = lhs - rhs;
            formula.Text = $"{lhs} - {rhs}";
            result.Text = outcome.ToString();
        }
        private void divideValues()
        {

                int lhs = int.Parse(mathB1.Text);
                int rhs = int.Parse(mathB2.Text);
                int outcome = 0;
                outcome = lhs / rhs;
                formula.Text = $"{lhs} / {rhs}";
                result.Text = outcome.ToString();
            }


        
        private void multiplyValues()
        {
            int lhs = int.Parse(mathB1.Text);
            int rhs = int.Parse(mathB2.Text);
            int outcome = 0;
            outcome = lhs * rhs;
            formula.Text = $"{lhs} * {rhs}";
            result.Text = outcome.ToString();
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
