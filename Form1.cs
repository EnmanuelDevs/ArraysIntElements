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
            string[] numbersStr = txtNumbers.Text.Split(',');

            int[] numbers = Array.ConvertAll(numbersStr, int.Parse);

            int sum = 0; 

            foreach (int number in numbers)
            sum += number;

            lblResult.Text = "Sum is: " + sum;
        }
    }
}
