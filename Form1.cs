using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysIntElements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArraySum_Click(object sender, EventArgs e)
        {
            string input = txtNumbers.Text;

            string[] StrNumbers = input.Split(','); 

            int[] numbers = new int [StrNumbers.Length];
            int sum = 0;
            bool Error = false;

            for (int i = 0; i < StrNumbers.Length; i++)
            {
                if (!int.TryParse(StrNumbers[i], out int number))
                {
                    MessageBox.Show("Invalid Value: " + StrNumbers[i]);
                    Error = true;
                    break;
                }
                numbers[i] = number;
                sum += number;
            }

            if (!Error)
            {
                lblResult.Text = "The sum is: " + sum;
            }
        }
    }
}
