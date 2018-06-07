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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classRoutineData.LoginInfo' table. You can move, or remove it, as needed.
            this.loginInfoTableAdapter.Fill(this.classRoutineData.LoginInfo);
            
            panel1.Enabled = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                panel1.Enabled = false;
                MessageBox.Show("Record Added to Database");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
