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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }
        string fstpefd,sndpefd,trdpefd,fstpeft,sndpeft,trdpeft;
        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nWUClassRoutineDataSet.RoutineInfo' table. You can move, or remove it, as needed.
            this.routineInfoTableAdapter.Fill(this.nWUClassRoutineDataSet.RoutineInfo);
            // TODO: This line of code loads data into the 'nWUClassRoutineDataSet.RoutineInfo' table. You can move, or remove it, as needed.
            this.routineInfoTableAdapter.Fill(this.nWUClassRoutineDataSet.RoutineInfo);
            routineInfoBindingSource.DataSource = this.nWUClassRoutineDataSet.RoutineInfo;
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel2.Visible = false;

        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                this.nWUClassRoutineDataSet.RoutineInfo.AddRoutineInfoRow(this.nWUClassRoutineDataSet.RoutineInfo.NewRoutineInfoRow());
                routineInfoBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                routineInfoBindingSource.ResetBindings(false);
            }
        }
        
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                fstpefd = textBox13.Text.ToString();
                fstpeft = textBox10.Text.ToString();
                sndpefd = textBox14.Text.ToString();
                sndpeft = textBox11.Text.ToString();
                trdpefd = textBox15.Text.ToString();
                trdpeft = textBox12.Text.ToString();
                textBox5.Text = "[[" + fstpefd + " " +  fstpeft + "]]]";
                textBox6.Text = "[[" + sndpefd + " " +  sndpeft + "]]]";
                textBox7.Text = "[[" + trdpefd + " " +  trdpeft + "]]]";
                routineInfoBindingSource.EndEdit();
                routineInfoTableAdapter.Update(this.nWUClassRoutineDataSet.RoutineInfo);
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel2.Visible = false;
                MessageBox.Show("Record Added to Database");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                routineInfoBindingSource.ResetBindings(false);
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel2.Enabled = true;
            panel2.Visible = true;
        }

        private void Btn_ViewRoutine_Click(object sender, EventArgs e)
        {
            var Routine = new Routine();
            Routine.Show();
        }
    }
}
