using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSsystem_Midterms_Bigalbal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float Frankies = 0.00f;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string button1Item = button1.Text;
            listBox1.Items.Add(button1Item);
            Frankies += 469f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string button2Item = button2.Text;
            listBox1.Items.Add(button2Item);
            Frankies += 469f;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string button3Item = button3.Text;
            listBox1.Items.Add(button3Item);
            Frankies += 479f;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string button4Item = button4.Text;
            listBox1.Items.Add(button4Item);
            Frankies += 219f;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string button5Item = button5.Text;
            listBox1.Items.Add(button5Item);
            Frankies += 189f;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string button6Item = button6.Text;
            listBox1.Items.Add(button6Item);
            Frankies += 129f;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string button7Item = button7.Text;
            listBox1.Items.Add(button7Item);
            Frankies += 209f;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string button8Item = button8.Text;
            listBox1.Items.Add(button8Item);
            Frankies += 160f;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // total 
            textBox1.Text = Frankies.ToString("N");
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //payment
            textBox1.Clear();
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Change
            button10.Enabled = true;
            button9.Enabled = true;
            button12.Enabled = true;
            double Change = double.Parse(textBox1.Text);
            if (Change < Frankies)
                textBox1.Text = "You don't have enough payment.";
            else
                textBox1.Text = $"Your change is {Change - Frankies}";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //next customer
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            listBox1.Items.Clear();
            textBox1.Clear();
            Frankies = 0;
        }
    }
}
