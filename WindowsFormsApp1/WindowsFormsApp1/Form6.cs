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
    public partial class Form6 : Form
    {
        public string[,] gg = new string[7, 20];
        public Form6(string[,] cc)
        {
        
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    gg[i, j] = cc[i, j];
                }
            }
            label5.Text = gg[0, 0];
            label9.Text = gg[0, 1];
            label10.Text = gg[0, 2];
            label11.Text = gg[1, 0];
            label15.Text = gg[2, 0];
            label16.Text = gg[2, 1];
            label17.Text = gg[2, 2];
            label18.Text = gg[3, 0];
            if(label11.Text == "信用卡付款")
            {
                label27.Text = "元";
            }
            else
            {
                label27.Text = "點";
            }
            string food = "";
            for(int i=0;i<20;i++)
            {
                food =food + gg[5, i] + "\r\n";
                label26.Text = food;
            }
            food = "";
            for (int i=0;i<6;i++)
            {
                food = food +  cc[6,i]+ "\r\n";
                label20.Text = food;
            }
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            saveFileDialog1.FileName = "XX電影院訂票收據紀錄";
            saveFileDialog1.DefaultExt = ".jpg";
            saveFileDialog1.Filter = "圖片檔 (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg|PDF(*.pdf)|*.pdf";
            if (saveFileDialog1.ShowDialog() ==  DialogResult.OK)
            {
              
            }
        }
    }
}
