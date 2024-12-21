using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formörnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            
            if (textBox1.Text == "Kerem" && textBox2.Text == "123")
            {
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide();
                
            }
            else 
            {
                i++;
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış");
                if (i == 3) 
                {
                    button1.Enabled = false;
                }

            }
           

            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
