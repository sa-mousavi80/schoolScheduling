using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolScheduling
{
    public partial class Form1 : Form
    {
        public void setProgram(String[] program)
        {
            textBox1.Text = program[0];
            textBox2.Text = program[1];
            textBox3.Text = program[2];
            textBox4.Text = program[3];
            textBox5.Text = program[4];
            textBox6.Text = program[5];
            textBox7.Text = program[6];
            textBox8.Text = program[7];
            textBox9.Text = program[8];
            textBox10.Text = program[9];
            textBox11.Text = program[10];
            textBox12.Text = program[11];
            textBox13.Text = program[12];
            textBox14.Text = program[13];
            textBox15.Text = program[14];
            textBox16.Text = program[15];
            textBox17.Text = program[16];
            textBox18.Text = program[17];
            textBox19.Text = program[18];
            textBox20.Text = program[19];
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
