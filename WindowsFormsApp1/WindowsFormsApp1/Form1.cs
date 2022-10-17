using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button2.Enabled = false;
        }
        int num = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "aaa" &&  textBox2.Text == "123")
            {
                DialogResult result;
               result= MessageBox.Show("登入成功","登入成功");
                if(result == DialogResult.OK)
                {
                    textBox1.Visible = false;
                    textBox1.Enabled = false;
                    textBox2.Visible = false;
                    textBox2.Enabled = false;
                    button1.Visible = false;
                    button1.Enabled = false;
                    button2.Visible = false;
                    button2.Enabled = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label2.Text = "帳號已登入";
                    button2.Visible = true;
                    button2.Enabled = true;
                    label3.Visible = false;
                    button3.Visible = false;
                    button3.Enabled = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label2.Location = new Point(360, 25);
                    label2.Font = new Font("新細明體", 10, FontStyle.Bold);
                }
            }
            else
            {
                num--;
                DialogResult result;
                result = MessageBox.Show("登入失敗\r\n剩餘次數" + num, "登入失敗",MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                if(result == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox2.ResetText();
                    textBox1.Focus();
                }
            }
         
        }
      
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.ResetText();
            textBox1.Focus();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
        }
    }
}
