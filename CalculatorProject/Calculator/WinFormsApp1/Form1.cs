using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{

    
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String OperationPerformed;
        bool isOperationPerformed=false;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {

        }


        private void button_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" ||(isOperationPerformed))
                textBox_Result.Clear();
            isOperationPerformed = false;

            Button button = (Button)sender;
            if(button.Text==".")
            {
                if(!textBox_Result.Text.Contains("."))
                {
                    textBox_Result.Text = textBox_Result.Text + button.Text;
                }
            }
            else
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                buttonEqualsTo.PerformClick();
                OperationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + OperationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                OperationPerformed = button.Text;
                resultValue = double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + OperationPerformed;
                isOperationPerformed = true;
            }

        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            labelCurrentOperation.Text = "";
            resultValue = 0;
        }

        private void EqualsTo_Click(object sender, EventArgs e)
        {
            switch(OperationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / double.Parse(textBox_Result.Text)).ToString();
                    break;

            }
            resultValue = double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
