using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == string.Empty){
                label4.Visible = true;
            }
            if (this.textBox1.Text != string.Empty){
                label4.Visible = false;
            }
            if (this.textBox4.Text == string.Empty){
                label11.Visible = true;
            }
            if (this.textBox4.Text != string.Empty){
                label11.Visible = false;
            }
            if (this.textBox3.Text == string.Empty){
                label10.Visible = true;
            }
            if (this.textBox3.Text != string.Empty){
                label10.Visible = false;
            }
            if (checkBox1.Checked != true){
                label8.Visible = true;
            }
            if (checkBox1.Checked == true)
            {
                label8.Visible = false;
            }
            if (comboBox1.SelectedIndex <= -1){
                label12.Visible = true;
            }
            if (comboBox1.SelectedIndex > -1){
                label12.Visible = false;
            }
            if (comboBox2.SelectedIndex <= -1){
                label6.Visible = true;
            }
            if (comboBox2.SelectedIndex > -1){
                label6.Visible = false;
            }
            int dateyear = dateTimePicker1.Value.Date.Year;
            int curryear = DateTime.Now.Year;
            if (curryear - 18 < dateyear || curryear-30 >= dateyear){
                label9.Visible = true;
            }
            if (curryear - 18 >= dateyear && curryear - 30 < dateyear)
            {
                label9.Visible = false;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
