using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilageCalculator
{
    public partial class Form1 : Form
    {
            int startingMilage;
            int endingMilage;
            double milesTraveled;
            double reimburseRate = .39;
            double amountOwed;
            public Form1()
            { 

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMilage = (int) numericUpDown1.Value;
            endingMilage = (int) numericUpDown2.Value;

            if (startingMilage < endingMilage)
            {
                milesTraveled = endingMilage - startingMilage;
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = "$" + amountOwed;
            }
            else
            {
                MessageBox.Show("The starting milage must be less than the ending milage", "Cannot calculate milage");
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " miles", "Miles Traveled");
        }
    }
}
