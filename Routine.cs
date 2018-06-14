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
    public partial class Routine : Form
    {
        public Routine()
        {
            InitializeComponent();
        }

        private void Routine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classRoutineDataSet.FinalRoutine' table. You can move, or remove it, as needed.
            this.finalRoutineTableAdapter.Fill(this.classRoutineDataSet.FinalRoutine);
            
        }
    }
}
