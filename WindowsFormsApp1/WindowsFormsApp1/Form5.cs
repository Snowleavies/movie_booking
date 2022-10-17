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
    public partial class Form5 : Form
    {
        public string[,] cc = new string[7, 20];
        public Form5(string[,] bb)
        {
            InitializeComponent();
            for(int i=0;i<6;i++)
            {
                for(int j=0;j<20;j++)
                {
                    cc[i, j] = bb[i, j];
                }
            }
            
        }
        public string[] ss = new string[5] {"A","B","C","D","E" };
        public string[] red = new string[10];
        int s;
        private void Form5_Load(object sender, EventArgs e)
        {
            
            Random r = new Random();
            Random t = new Random();
            int z,d;
            char f;
            for(int i=0;i<10;i++)
            {
               
                z = r.Next(1, 5);
                d = t.Next(1, 10);
                if(z == 1)
                {
                    red[i] = "A";
                }
                if(z == 2)
                {
                    red[i] = "B";
                }
                if (z == 3)
                {
                    red[i] = "C";
                }
                if (z == 4)
                {
                    red[i] = "D";
                }
                if (z == 5)
                {
                    red[i] = "E";
                }
                red[i] = red[i] + d.ToString(); 
            }

            s = int.Parse(cc[4, 0]);
            label2.Text =  cc[4,0];
            int a = 1, b=0, c=0;
            for(int i =0;i<=4;i++)
            {
                b = 0;
                for(int j =0;j<=9;j++)
                {
                    Button bt = new Button();
                    bt.Name = ss[i]+a;
                    a++;
                    bt.Location = new Point(button1.Location.X + b, button1.Location.Y + c);
                    bt.Text = bt.Name;
                    for(int v=0;v<10;v++)
                    {
                        if(bt.Name == red[v])
                    {
                            bt.BackColor = Color.Red;
                            bt.Enabled = false;
                            break;
                        }
                        else
                        {
                            bt.BackColor = SystemColors.Control;
                        }
                    }
                    
                    
                    bt.Click += new System.EventHandler(this.Button_Click);
                    bt.Size = new Size(50, 50);
                    if(j==2 || j==6)
                    {
                        b = b + 75;
                    }
                    else
                    {
                        b = b + 50;
                    }
                    
                    this.Controls.Add(bt);
                }
                c = c + 50;
                a = 1;
            }
           

        }
        
        private void label6_Click(object sender, EventArgs e)
        {

        }
        
        private void Button_Click(object sender,EventArgs e)
        {
            int u = 0;
            string food = "";
            string item = "";
            Button btn = (Button)sender;
            if(btn.BackColor == Color.Blue)
            {
                s++;
                btn.BackColor = SystemColors.Control;
                foreach (Control c in this.Controls)
                {
                    Button bt = c as Button;
                    if (bt != null)
                    {

                        if (bt.BackColor == Color.Blue)
                        {
                            bt.Enabled = true;
                            item = item + bt.Name + " ";
                            food = food + bt.Name + "\r\n";
                            cc[6, u] = bt.Name;
                            u++;
                        }
                        if(bt.BackColor == SystemColors.Control)
                        {
                            bt.Enabled = true;
                        }
                    
                    }
                }
                label22.Text = item;
             
            }
            else
            {
                s--;
                btn.BackColor = Color.Blue;
                foreach (Control c in this.Controls)
                {
                    Button bt = c as Button;
                    if (bt != null)
                    {
                        if (bt.BackColor == Color.Blue)
                        {
                            item = item + bt.Name + " ";
                            food = food + bt.Name + "\r\n";
                            cc[6, u] = bt.Name;
                            u++;
                        }
                    }
                }
                if (s == 0)
                {
                    foreach (Control c in this.Controls)
                    {
                        Button bt = c as Button;
                        if (bt != null)
                        {
                            if (bt.BackColor == Color.Blue)
                            {
                                bt.Enabled = true;
                            }
                            else
                            {
                                bt.Enabled = false;
                                button4.Enabled = true;
                                button5.Enabled = true;
                            }
                        }
                    }
                    
                }
                label22.Text = item;
             

            }
           
         
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4(cc);
            f4.Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(s!=0)
            {
                MessageBox.Show("選取未確實");
            }
            else
            {
               
                Form f6 = new Form6(cc);
                f6.Show();
                this.Close();
            }
           

        }
    }
}
