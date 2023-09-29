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
    public partial class Login : Form
    {
        String username, password;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(username=="admin"&& password=="admin")
            {
                MessageBox.Show("login successfully");
                form4 form4 = new form4();
                form4.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username and password");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text;
        }
    }
}
