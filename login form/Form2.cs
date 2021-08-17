using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }


        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "annie" && textBox2.Text == "12345")
            {
                MessageBox.Show("Login succesful");
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
