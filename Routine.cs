using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NWUClassRoutine
{
    public partial class Routine : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MIRAZ-PC\SQLEXPRESS;Initial Catalog=ClassRoutine;Integrated Security=True");
        string[,] RoutineArray = new string[121, 11];
        int[] Lab = new int[3] { 0, 4, 7 };
        string query;
        int[] roomno = new int[24] { 401, 402, 403, 404, 501, 502, 503, 504, 601, 602, 603, 604, 701, 702, 703, 704, 801, 802, 803, 804, 901, 902, 903, 904 };
        int j = 0;
        SqlCommand Sqlcmd;
        SqlDataReader reader;
        public Routine()
        {
            InitializeComponent();
        }
        DataTable dbdataset;
        private void Routine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classRoutineDataSet.FinalRoutine' table. You can move, or remove it, as needed.
            this.finalRoutineTableAdapter.Fill(this.classRoutineDataSet.FinalRoutine);
            InitializeComponent();
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Btn_ViewRoutine_Click(object sender, EventArgs e)
        {
           viewRoutine();
        }
        public void update()
        {
            fillTableWithNoSubject();
            query = "DELETE FinalRoutine where [Term&Section&Department] != ' year'"; // Problem
            Sqlcmd = new SqlCommand(query, conn);
            conn.Open();
            Sqlcmd.ExecuteNonQuery();
            conn.Close();
            for (int i = 1; i < 121; i++)
            {
                if (i >= 23 || i >= 47 || i >= 71 || i >= 95 || i >= 119 || i >= 121)
                {

                    query = "INSERT INTO FinalRoutine([Term&Section&Department],[8:00-9:15],[9:15-10:30],[10:45-12:00],[12:00-1:15],[2:00-3:15],[3:15-4:30],RowNumber,roomno) values( '" + year(i) + "','" + RoutineArray[i, 1] + "','" + RoutineArray[i, 2] + "','" + RoutineArray[i, 3] + "','" + RoutineArray[i, 4] + "','" + RoutineArray[i, 5] + "','" + RoutineArray[i, 6] + "','" + i + "','" + roomno[j] + "')";
                    if (j == 23)
                    {
                        j--;
                    }
                    else
                    {
                        j++;
                    }
                }
                else
                {
                    query = "INSERT INTO FinalRoutine([Term&Section&Department],[8:00-9:15],[9:15-10:30],[10:45-12:00],[12:00-1:15],[2:00-3:15],[3:15-4:30],RowNumber,roomno) values( '" + year(i) + "','" + RoutineArray[i, 1] + "','" + RoutineArray[i, 2] + "','" + RoutineArray[i, 3] + "','" + RoutineArray[i, 4] + "','" + RoutineArray[i, 5] + "','" + RoutineArray[i, 6] + "','" + i + "','" + roomno[i] + "')";
                }
                Sqlcmd = new SqlCommand(query, conn);
                conn.Open();
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void fillTableWithNoSubject()
        {
            for (int i = 0; i < 121; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    RoutineArray[i, j] = "-";
                }
            }
            //dataPrint();
        }
        public void viewRoutine()
        {
            try
            {
                query = "SELECT * from FinalRoutine";
                Sqlcmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = Sqlcmd;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
                //dataGridView1.Columns.Remove("rownum");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public string year(int row)
        {
            string year;
            year = "";
            if (row % 24 == 1)
                year = "1st Year 1st Semester(A)";
            else if (row % 24 == 2)
                year = "1st Year 1st Semester(B)";
            else if (row % 24 == 3)
                year = "1st Year 2nd Semester(A)";
            else if (row % 24 == 4)
                year = "1st Year 2nd Semester(B)";
            else if (row % 24 == 5)
                year = "1st Year 3rd Semester(A)";
            else if (row % 24 == 6)
                year = "1st Year 3rd Semester(B)";
            else if (row % 24 == 7)
                year = "2nd Year 1st Semester(A)";
            else if (row % 24 == 7)
                year = "2nd Year 1st Semester(B)";
            else if (row % 24 == 8)
                year = "2nd Year 2nd Semester(A)";
            else if (row % 24 == 9)
                year = "2nd Year 2nd Semester(B)";
            else if (row % 24 == 10)
                year = "2nd Year 3rd Semester(A)";
            else if (row % 24 == 11)
                year = "2nd Year 3rd Semester(B)";
            else if (row % 24 == 12)
                year = "3rd Year 1st Semester(A)";
            else if (row % 24 == 13)
                year = "3rd Year 1st Semester(B)";
            else if (row % 24 == 14)
                year = "3rd Year 2nd Semester(A)";
            else if (row % 24 == 15)
                year = "3rd Year 2nd Semester(B)";
            else if (row % 24 == 16)
                year = "3rd Year 3rd Semester(A)";
            else if (row % 24 == 17)
                year = "3rd Year 3rd Semester(B)";
            else if (row % 24 == 18)
                year = "4th Year 1st Semester(A)";
            else if (row % 24 == 19)
                year = "4th Year 1st Semester(B)";
            else if (row % 24 == 20)
                year = "4th Year 2nd Semester(A)";
            else if (row % 24 == 21)
                year = "4th Year 2nd Semester(B)";
            else if (row % 24 == 22)
                year = "4th Year 3rd Semester(A)";
            else if (row % 24 == 23)
                year = "4th Year 3rd Semester(B)";
            else
                year = "Day";
            return year;
        }

        private void Btn_Generate_Click(object sender, EventArgs e)
        {
            j = 0;
            update();
            viewRoutine();
        }
    }
}
