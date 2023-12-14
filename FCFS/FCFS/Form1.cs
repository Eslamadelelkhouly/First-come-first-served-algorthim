using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCFS
{
    public partial class Form1 : Form
    {
        ArrayList array = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            array.Add(Convert.ToInt32(textBox2.Text));
            array.Add(Convert.ToInt32(textBox3.Text));
            array.Add(Convert.ToInt32(textBox4.Text));
            array.Add(Convert.ToInt32(textBox5.Text));

            foreach (var item in array)
            {
                checkedListBox1.Items.Add(item);
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(checkedListBox1.Items[0] + "000");
            if (checkedListBox1.Items[0].ToString() == textBox2.Text)
            {
                textBox1.Text = label3.Text;
            }
            else if (checkedListBox1.Items[0].ToString() == textBox3.Text)
            {
                timer1.Interval = Convert.ToInt32(textBox3.Text + "000");
                textBox1.Text = label4.Text;
            }
            else if (checkedListBox1.Items[0].ToString() == textBox4.Text)
            {
                timer1.Interval = Convert.ToInt32(textBox4.Text + "000");
                textBox1.Text = label5.Text;
            }
            else if (checkedListBox1.Items[0].ToString() == textBox5.Text)
            {
                timer1.Interval = Convert.ToInt32(textBox5.Text + "000");
                textBox1.Text = label6.Text;
            }
            checkedListBox1.Items.RemoveAt(0);

            if(checkedListBox1.Items.Count <= 0)
            {
                MessageBox.Show("Processor is Idel and Wait the processes !!");
                timer1.Stop();
            }
        }
    }
}
