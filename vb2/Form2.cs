using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vb2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("apakah anada mau ke form selanjutnya = " + textBox1.Text);

            this.Hide();
            //kode di atas ntuk menutup form yang berpindah 

            Form3 form2 = new Form3();
            form2.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string correctPassword = textBox2.Text;
            string userInput = textBox2.Text;  
            if (userInput == correctPassword)
            {
                label4.Text = "password benar. akses di terima.";
                label4.ForeColor = Color.Blue;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
