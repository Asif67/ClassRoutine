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
       
        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database.RoutineInfo' table. You can move, or remove it, as needed.
            this.routineInfoTableAdapter.Fill(this.database.RoutineInfo);
            routineInfoBindingSource.DataSource = this.database.RoutineInfo;
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel2.Visible = false;

        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                this.database.RoutineInfo.AddRoutineInfoRow(this.database.RoutineInfo.NewRoutineInfoRow());
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
                routineInfoBindingSource.EndEdit();
                routineInfoTableAdapter.Update(this.database.RoutineInfo);
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
    }
}
