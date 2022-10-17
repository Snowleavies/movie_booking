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
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
            label4.Visible = false;
            label6.Visible = false;
            tt[0, 0] = "";
            tt[0, 1] = "";
            tt[0, 2] = " ";
        }
        public string[,] tt = new string[3,3];
        private void button1_Click(object sender, EventArgs e)
        {
            if(tt[0,0] == ""|| tt[0,1] == "" || tt[0,2] == "")
            {
                MessageBox.Show("選取未確實");
              
            }
            else
            {
                Form f3 = new Form3(tt);
                f3.Show();
                this.Close();
            }
          
        }
         int a;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            label4.Text = comboBox1.SelectedItem.ToString();
            tt[0,0] = comboBox1.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            label6.Text = comboBox2.SelectedItem.ToString();
            tt[0,1] = comboBox2.SelectedItem.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            label8.Text = dateTimePicker1.Value.ToShortDateString();
            tt[0, 2] = label8.Text;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
