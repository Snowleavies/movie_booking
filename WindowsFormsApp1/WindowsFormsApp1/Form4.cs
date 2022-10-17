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
    public partial class Form4 : Form
    {
        public string[,] bb = new string[6, 20];
        int num = 0;
        public Form4(string[,]aa)
        {
            InitializeComponent();
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<3;j++)
                {
                    bb[i, j] = aa[i, j];
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if(bb[1,0]== "信用卡付款")
            {
                groupBox2.Text = "金額結算";
                label2.Text = "總金額為:";
                label4.Text = "元";
                label3.Text = bb[3, 0];
            }
            else
            {
                groupBox2.Text = "點數結算";
                label2.Text = "總點數為:";
                label4.Text = "點";
                label3.Text = bb[3, 0];
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("爆米花   50元/20點");
            listBox1.Items.Add("熱狗堡   40元/15點");
            listBox1.Items.Add("薯  條   30元/10點");
            listBox1.Items.Add("吉拿棒   35元/13點");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("可樂      30元/10點");
            listBox1.Items.Add("雪碧      30元/10點");
            listBox1.Items.Add("檸檬紅茶  30元/10點");
            listBox1.Items.Add("無糖綠茶  20元/8 點");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(label3.Text), a=0;
            foreach(object o in listBox1.SelectedItems)
            {
                for(int i = 0;i<int.Parse(textBox1.Text);i++)
                {
                    if (bb[1, 0] == "信用卡付款")
                    {
                        if(o.ToString() == "可樂      30元/10點" || o.ToString() == "雪碧      30元/10點" || o.ToString() == "檸檬紅茶  30元/10點")
                        {
                            num++;
                            a = 10;
                            sum = sum + a;
                            a = 0;
                            if(num==20)
                            {
                                button1.Enabled = false;
                            }
                        }
                        if(o.ToString() == "無糖綠茶  20元/8 點")
                        {
                            num++;
                            a = 8;
                            sum = sum + a;
                            a = 0;
                            if (num == 20)
                            {
                                button1.Enabled = false;
                            }
                        }
                        if (o.ToString() == "爆米花   50元 / 20點")
                        {
                            num++;
                            a = 20;
                            sum = sum + a;
                            a = 0;
                            if (num == 20)
                            {
                                button1.Enabled = false;
                            }
                        }
                        if (o.ToString() == "熱狗堡   40元/15點")
                        {
                            num++;
                            a = 15;
                            sum = sum + a;
                            a = 0;
                            if (num == 20)
                            {
                                button1.Enabled = false;
                            }
                        }
                        if (o.ToString() == "薯  條   30元/10點")
                        {
                            num++;
                            a = 10;
                            sum = sum + a;
                            a = 0;
                            if (num == 20)
                            {
                                button1.Enabled = false;
                            }
                        }
                        if (o.ToString() == "吉拿棒   35元/13點")
                        {
                            num++;
                            a = 13;
                            sum = sum + a;
                            a = 0;
                            if (num == 20)
                            {
                                button1.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        if (o.ToString() == "可樂      30元/10點" || o.ToString() == "雪碧      30元/10點" || o.ToString() == "檸檬紅茶  30元/10點")
                        {
                            num++;
                            a = 30;
                            sum = sum + a;
                            a = 0;
                            if (num == 20)
                            {
                                button1.Enabled = false;
                            }
                        }
                        if (o.ToString() =="無糖綠茶  20元 / 8 點")
                        {
                            num++;
                            a = 20;
                            sum = sum + a;
                            a = 0;
                            if (num == 20)
                            {
                                button1.Enabled = false;
                            }
                        }
                        if (o.ToString() == "爆米花   50元 / 20點")
                        {
                            num++;
                            a = 50;
                            sum = sum + a;
                            a = 0;
                            if (num == 20)
                            {
                                button1.Enabled = false;
                            }
                        }
                        if (o.ToString() == "熱狗堡   40元/15點")
                        {
                            num++;
                            a = 40;
                            sum = sum + a;
                            a = 0;
                            if (num == 20)
                            {
                                button1.Enabled = false;
                            }
                        }
                        if (o.ToString() == "薯  條   30元/10點")
                        {
                            num++;
                            a = 30;
                            sum = sum + a;
                            a = 0;
                            if (num == 20)
                            {
                                button1.Enabled = false;
                            }
                        }
                        if (o.ToString() == "吉拿棒   35元/13點")
                        {
                            num++;
                            a = 35;
                            sum = sum + a;
                            a = 0;
                            if (num == 20)
                            {
                                button1.Enabled = false;
                            }
                        }
                    
}
                        listBox2.Items.Add(o);
                }
            }
            label3.Text = sum.ToString();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(int.Parse(textBox1.Text)<=0 )
            {
                textBox1.Text = "0";
                    }
            if(int.Parse(textBox1.Text) > 20)
            {
                textBox1.Text = "20";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num = 0;
            listBox2.Items.Clear();
            label3.Text = bb[3, 0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3(bb);
            f3.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int b = 0;
            foreach(object o in listBox2.Items)
            {
                bb[5, b] = o.ToString();
                b++;
            }
            bb[3, 0] = label3.Text;
            Form f5 = new Form5(bb);
            f5.Show();
            this.Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
