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
    public partial class Form3 : Form
    {
        public string[,] aa = new string[5,3] ;
        public Form3(string[,] tt)
        {
            int i = 0;
          
            InitializeComponent();
            aa[0,0] = tt[0, 0];
            aa[0, 1] = tt[0, 1];
            aa[0, 2] = tt[0, 2];
        }
        int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, sum=0, sum1=0;

        private void button5_Click(object sender, EventArgs e)
        {
            num3++;
            textBox3.Text = num3.ToString(); 
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sum = num1 + num2 + num3;
            if (sum >= 6)
            {
                button1.Enabled = false;
                button3.Enabled = false;
                button5.Enabled = false;
                num1 = 6 - num3 - num2;
                textBox1.Text = num1.ToString();
            }
            else
            {
                button1.Enabled = true;
                button3.Enabled = true;
                button5.Enabled = true;
            }
            if (sum <= 0)
            {
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                num1 = 0;
                textBox1.Text = "0";
            }
            else
            {
                if (num3 <= 0)
                {
                    num3 = 0;
                    textBox3.Text = "0";
                    button6.Enabled = false;
                }
                else
                {
                    button6.Enabled = true;
                }
                if (num2 <= 0)
                {
                    num2 = 0;
                    textBox2.Text = "0";
                    button4.Enabled = false;
                }
                else
                {
                    button4.Enabled = true;
                }
                if (num1 <= 0)
                {
                    num1 = 0;
                    textBox1.Text = "0";
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }
            }

            sum1 = num1 * 270 + num2 * 200 + num3 * 180;
            label9.Text = sum1.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sum = num1 + num2 + num3;
            if (sum >= 6)
            {
                button1.Enabled = false;
                button3.Enabled = false;
                button5.Enabled = false;
                num2 = 6 - num1 - num3;
                textBox2.Text = num2.ToString();
            }
            else
            {
                button1.Enabled = true;
                button3.Enabled = true;
                button5.Enabled = true;
            }
            if (sum <= 0)
            {
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                num2 = 0;
                textBox2.Text = "0";
            }
            else
            {
                if (num3 <= 0)
                {
                    num3 = 0;
                    textBox3.Text = "0";
                    button6.Enabled = false;
                }
                else
                {
                    button6.Enabled = true;
                }
                if (num2 <= 0)
                {
                    num2 = 0;
                    textBox2.Text = "0";
                    button4.Enabled = false;
                }
                else
                {
                    button4.Enabled = true;
                }
                if (num1 <= 0)
                {
                    num1 = 0;
                    textBox1.Text = "0";
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }
            }

            sum1 = num1 * 270 + num2 * 200 + num3 * 180;
            label9.Text = sum1.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            sum = num1 + num2 + num3;
            if (sum >= 6)
            {
                button1.Enabled = false;
                button3.Enabled = false;
                button5.Enabled = false;
                num3 = 6 - num1 - num2;
                textBox3.Text = num3.ToString();
            }
            else
            {
                button1.Enabled = true;
                button3.Enabled = true;
                button5.Enabled = true;
            }
            if (sum <= 0)
            {
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                num3 = 0;
                textBox3.Text = "0";
            }
            else
            {
                if (num3 <= 0)
                {
                    num3 = 0;
                    textBox3.Text = "0";
                    button6.Enabled = false;
                }
                else
                {
                    button6.Enabled = true;
                }
                if (num2 <= 0)
                {
                    num2 = 0;
                    textBox2.Text = "0";
                    button4.Enabled = false;
                }
                else
                {
                    button4.Enabled = true;
                }
                if (num1 <= 0)
                {
                    num1 = 0;
                    textBox1.Text = "0";
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }
            }

            sum1 = num1 * 270 + num2 * 200 + num3 * 180;
            label9.Text = sum1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1--;
            textBox1.Text = num1.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num2--;
            textBox2.Text = num2.ToString();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num4--;
            textBox4.Text = num4.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num4++;
            textBox4.Text = num4.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num5--;
            textBox5.Text = num5.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num5++;
            textBox5.Text = num5.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num6--;
            textBox6.Text = num6.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num6++;
            textBox6.Text = num6.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            sum = num4 + num5 + num6;
            if(sum>=6)
            {
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                num4 = 6 - num5 - num6;
                textBox4.Text = num4.ToString();
            }
            else
            {
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
            }
            if(sum<=0)
            {
                button10.Enabled = false;
                button12.Enabled = false;
                button11.Enabled = false;
                num4 = 0;
                textBox4.Text = num4.ToString();
            }
            else
            {
                if (num5 <= 0)
                {
                    num5 = 0;
                    textBox5.Text = "0";
                    button11.Enabled = false;
                }
                else
                {
                    button11.Enabled = true;
                }
                if (num4 <= 0)
                {
                    num4 = 0;
                    textBox4.Text = "0";
                    button10.Enabled = false;
                }
                else
                {
                    button10.Enabled = true;
                }
                if (num6 <= 0)
                {
                    num6 = 0;
                    textBox6.Text = "0";
                    button12.Enabled = false;
                }
                else
                {
                    button12.Enabled = true;
                }
            }
          
            sum1 = num4 * 100 + num5 * 75 + num6 * 70;
            label12.Text = sum1.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            sum = num4 + num5 + num6;
            if (sum >= 6)
            {
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                num5 = 6 - num4 - num6;
                textBox5.Text = num5.ToString();
            }
            else
            {
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
            }
            if (sum <= 0)
            {
                button11.Enabled = false;
                button10.Enabled = false;
                button12.Enabled = false;
                num5 = 0;
                textBox5.Text = "0";
            }
            else
            {
                if (num5 <= 0)
                {
                    num5 = 0;
                    textBox5.Text = "0";
                    button11.Enabled = false;
                }
                else
                {
                    button11.Enabled = true;
                }
                if (num4 <= 0)
                {
                    num4 = 0;
                    textBox4.Text = "0";
                    button10.Enabled = false;
                }
                else
                {
                    button10.Enabled = true;
                }
                if (num6 <= 0)
                {
                    num6 = 0;
                    textBox6.Text = "0";
                    button12.Enabled = false;
                }
                else
                {
                    button12.Enabled = true;
                }
                
            }
        
            sum1 = num4 * 100 + num5 * 75 + num6 * 70;
            label12.Text = sum1.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            sum = num4 + num5 + num6;
            if (sum >= 6)
            {
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                num6 = 6 - num4 - num5;
                textBox6.Text = num6.ToString();
            }
            else
            {
                button9.Enabled = true;
                button8.Enabled = true;
                button7.Enabled = true;
            }
            if (sum <= 0)
            {
                button12.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                num6 = 0;
                textBox6.Text = "0";
            }
            else
            {
                if (num5 <= 0)
                {
                    num5 = 0;
                    textBox5.Text = "0";
                    button11.Enabled = false;
                }
                else
                {
                    button11.Enabled = true;
                }
                if (num4 <= 0)
                {
                    num4 = 0;
                    textBox4.Text = "0";
                    button10.Enabled = false;
                }
                else
                {
                    button10.Enabled = true;
                }
                if (num6 <= 0)
                {
                    num6 = 0;
                    textBox6.Text = "0";
                    button12.Enabled = false;
                }
                else
                {
                    button12.Enabled = true;
                }
            }
        
            sum1 = num4 * 100 + num5 * 75 + num6 * 70;
            label12.Text = sum1.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(sum == 0)
            {
                MessageBox.Show("選取未確實");
            }
            else
            {
                aa[4, 0] = sum.ToString();
                if (aa[1, 0] == "信用卡付款")
                {
                    aa[2, 0] = num1.ToString();
                    aa[2, 1] = num2.ToString();
                    aa[2, 2] = num3.ToString();
                }
                else
                {
                    aa[2, 0] = num4.ToString();
                    aa[2, 1] = num5.ToString();
                    aa[2, 2] = num6.ToString();
                }
                aa[3, 0] = sum1.ToString();
                Form f4 = new Form4(aa);
                f4.Show();
                this.Close();
            }
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
                f2.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num3--;
            textBox3.Text = num3.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num2++;
            textBox2.Text = num2.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1++;
            textBox1.Text = num1.ToString();
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox1.Enabled = false;
            groupBox2.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            textBox4.Text = num4.ToString();
            textBox5.Text = num5.ToString();
            textBox6.Text = num6.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                groupBox2.Visible = false;
                groupBox2.Enabled = false;
                groupBox1.Visible = true;
                groupBox1.Enabled = true;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                num4 = 0;
                num5 = 0;
                num6 = 0;
                sum = 0;
                sum1 = 0;
                aa[1, 0] = "信用卡付款";
            }
   
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text = "0";
                groupBox2.Visible = true;
                groupBox2.Enabled = true;
                groupBox1.Visible = false;
                groupBox1.Enabled = false;
                groupBox4.Visible = true;
                groupBox3.Visible = false;
                num1 = 0;
                num2 = 0;
                num3 = 0;
                sum = 0;
                sum1 = 0;
                aa[1, 0] = "XX電影院會員卡";
            }
      
        }
    }
}
