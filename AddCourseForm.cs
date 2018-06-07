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
            // TODO: This line of code loads data into the 'classRoutineDataSet.RoutineInfo' table. You can move, or remove it, as needed.
            this.routineInfoTableAdapter.Fill(this.classRoutineDataSet.RoutineInfo);
            routineInfoBindingSource.DataSource = this.classRoutineDataSet.RoutineInfo;
            panel1.Enabled = false;

        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                this.classRoutineDataSet.RoutineInfo.AddRoutineInfoRow(this.classRoutineDataSet.RoutineInfo.NewRoutineInfoRow());
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
                routineInfoTableAdapter.Update(this.classRoutineDataSet.RoutineInfo);
                panel1.Enabled = false;
                MessageBox.Show("Record Added to Database");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                routineInfoBindingSource.ResetBindings(false);
            }
        }
    }
}
