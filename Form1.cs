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
            // TODO: This line of code loads data into the 'classRoutineDataSet.LoginInfo' table. You can move, or remove it, as needed.
            this.loginInfoTableAdapter.Fill(this.classRoutineDataSet.LoginInfo);
            loginInfoBindingSource.DataSource = this.classRoutineDataSet.LoginInfo;
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
                this.classRoutineDataSet.LoginInfo.AddLoginInfoRow(this.classRoutineDataSet.LoginInfo.NewLoginInfoRow());
                loginInfoBindingSource.MoveLast();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginInfoBindingSource.ResetBindings(false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                loginInfoBindingSource.EndEdit();
                loginInfoTableAdapter.Update(this.classRoutineDataSet.LoginInfo);
                panel1.Enabled = false;
                MessageBox.Show("Record Added to database");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginInfoBindingSource.ResetBindings(false);
            }
        }
    }
}
