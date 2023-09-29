using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authent
{
    public partial class Register : Form
    {
        String username, password, confirmpassword;
        public Register()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                MessageBox.Show("username should have atleast 3 to 16  characters");
                return;
            }
             else if (password != confirmpassword)
            {
                MessageBox.Show("paasword and confirmpassword are not matched");
                return;
            }
            else
            {
                MessageBox.Show("Registered successfully");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            confirmpassword = textBox3.Text;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
