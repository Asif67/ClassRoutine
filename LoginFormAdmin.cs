using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NWUClassRoutine
{
    public partial class LoginFormAdmin : Form
    {
        public LoginFormAdmin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form1 = new LoginForm();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form2 = new Form1();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uid="admin", pass="123456";
            if(textBox1.Text==uid && textBox2.Text == pass)
            {
                MessageBox.Show("LogIn Successful");
                var form3 = new AddCourseForm();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Wrong Input");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
