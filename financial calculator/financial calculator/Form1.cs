using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL;

namespace financial_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double base_sum;
        double pct;
        int time;
        int interval = 12;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                base_sum = Convert.ToDouble(textBoxBsum.Text);
                pct = Convert.ToDouble(textBoxPct.Text);
                time = Convert.ToInt32(textBoxTime.Text);                
            }
            catch (FormatException)
            {
                throw new Exception("FormatException");
            }

            if (radioButton1.Checked)
                interval = 1;
            else if (radioButton3.Checked)
                interval = 3;
            else if (radioButton6.Checked)
                interval = 6;
            else if (radioButton12.Checked)
                interval = 12;

            var calculate = new Calculator(base_sum, pct, time, interval);
            labelResult.Text = Convert.ToString(calculate.GetSum());
        }
    }
}
