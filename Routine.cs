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
using System.Configuration;
namespace NWUClassRoutine
{
    public partial class Routine : Form
    {
        SqlConnection conn = new SqlConnection(global::NWUClassRoutine.Properties.Settings.Default.NWUClassRoutineConnectionString1);
        //SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NWUClassRoutine.Properties.Settings.ClassRoutineConnectionString"].ConnectionString);
        string[,] RoutineArray = new string[25, 41];
        string[] TeacherInitials = new string[50];
        string query,CourseCode,tempCourseCredit, tempCourseCode;
        int[] roomno =new int[25] {401,402,403,404,501,502,503,504,601,602,603,604,701,702,703,704,801,802,803,804,901,902,903,904,401};
        int[] LabRoomNo = new int[3] { 302, 303, 304 };
        int Column;
        int j = 0;
        SqlCommand Sqlcmd;
        SqlDataReader reader, reader1;
        DataTable dbdataset;
        int RoutineArrayRowIndex, RoutineArrayColumnIndex;
        double CourseCredit;
        int column, row, SemesterDeterminingCourseCodeDigit, YearDeterminingCourseCodeDigit;
        string Query1, Query2, Query3, Query4;
        int[] preferredTimeSlots = new int[3];
        public Routine()
        {
            InitializeComponent();
        }
        private void Routine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nWUClassRoutineDataSet.Routine' table. You can move, or remove it, as needed.
            this.routineTableAdapter.Fill(this.nWUClassRoutineDataSet.Routine);
            InitializeComponent();
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            panel1.Enabled = false;
        }

        private void Btn_ViewRoutine_Click(object sender, EventArgs e)
        {
           viewRoutine();
        }
        public void update()
        {
            fillTableWithNoSubject();
            InsertSingleCourseIntoPosition();
            conn = new SqlConnection(global::NWUClassRoutine.Properties.Settings.Default.NWUClassRoutineConnectionString1);
            for (int i = 0; i < 25; i++)
            {
                conn.Open();
                query = "INSERT INTO Routine([RowNumber],[[Term&Section&Department]]],[[Monday 8:00-9:15]]] ,[[Monday 9:15-10:30]]],[[Monday 10:45-12:00]]],[[Monday 12:00-1:15]]],[[Monday 2:00-3:15]]],[[Monday 3:15-4:30]]],[[Tuesday 8:00-9:15]]],[[Tuesday 9:15-10:30]]],[[Tuesday 10:45-12:00]]],[[Tuesday 12:00-1:15]]],[[Tuesday 2:00-3:15]]],[[Tuesday 3:15-4:30]]],[[Wednesday 8:00-9:15]]],[[Wednesday 9:15-10:30]]],[[Wednesday 10:45-12:00]]],[[Wednesday 12:00-1:15]]],[[Wednesday 2:00-3:15]]],[[Wednesday 3:15-4:30]]],[[Thursday 8:00-9:15]]],[[Thursday 9:15-10:30]]],[[Thursday 10:45-12:00]]],[[Thursday 12:00-1:15]]],[[Thursday 2:00-3:15]]],[[Thursday 3:15-4:30]]],[[Friday 8:00-9:15]]],[[Friday 9:15-10:30]]],[[Friday 10:45-12:00]]],[[Friday 12:00-1:15]]],[[Friday 2:00-3:15]]],[[Friday 3:15-4:30]]],[[Saturday 8:00-9:15]]],[[Saturday 9:15-10:30]]],[[Saturday 10:45-12:00]]],[[Saturday 12:00-1:15]]],[[Saturday 2:00-3:15]]],[[Saturday 3:15-4:30]]],[RoomNo]) values( '" + i +"','"+ year(i) + "','" + RoutineArray[i, 1] + "','" + RoutineArray[i, 2] + "','" + RoutineArray[i, 3] + "','" + RoutineArray[i, 4] + "','" + RoutineArray[i, 5] + "','" + RoutineArray[i, 6] + "','" + RoutineArray[i, 7] + "','" + RoutineArray[i, 8] + "','" + RoutineArray[i, 9] + "','" + RoutineArray[i, 10] + "','" + RoutineArray[i, 11] + "','" + RoutineArray[i, 12] + "','" + RoutineArray[i, 13] + "','" + RoutineArray[i, 14] + "','" + RoutineArray[i, 15] + "','" + RoutineArray[i, 16] + "','" + RoutineArray[i, 17] + "','" + RoutineArray[i, 18] + "','" + RoutineArray[i, 19] + "','" + RoutineArray[i, 20] + "','" + RoutineArray[i, 21] + "','" + RoutineArray[i, 22] + "','" + RoutineArray[i, 23] + "','" + RoutineArray[i, 24] + "','" + RoutineArray[i, 25] + "','" + RoutineArray[i, 26] + "','" + RoutineArray[i, 27] + "','" + RoutineArray[i, 28] + "','" + RoutineArray[i, 29] + "','" + RoutineArray[i, 30] + "','" + RoutineArray[i, 31] + "','" + RoutineArray[i, 32] + "','" + RoutineArray[i, 33] + "','" + RoutineArray[i, 34] + "','" + RoutineArray[i, 35] + "','" + RoutineArray[i, 36] +  "','" + roomno[i] + "')";
                
                  Sqlcmd = new SqlCommand(query, conn);
                    
                    Sqlcmd.ExecuteNonQuery();
                    conn.Close();
                
            }
            
        }
        public void fillTableWithNoSubject()
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 41; j++)
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
                conn = new SqlConnection(global::NWUClassRoutine.Properties.Settings.Default.NWUClassRoutineConnectionString1);
                query = "SELECT * from Routine";
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
                //dataGridView1.Columns.Remove("[RowNumber]");
                //dataGridView1.Refresh();
                MessageBox.Show("Done");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            else if (row % 24 == 8)
                year = "2nd Year 1st Semester(B)";
            else if (row % 24 == 9)
                year = "2nd Year 2nd Semester(A)";
            else if (row % 24 == 10)
                year = "2nd Year 2nd Semester(B)";
            else if (row % 24 == 11)
                year = "2nd Year 3rd Semester(A)";
            else if (row % 24 == 12)
                year = "2nd Year 3rd Semester(B)";
            else if (row % 24 == 13)
                year = "3rd Year 1st Semester(A)";
            else if (row % 24 == 14)
                year = "3rd Year 1st Semester(B)";
            else if (row % 24 == 15)
                year = "3rd Year 2nd Semester(A)";
            else if (row % 24 == 16)
                year = "3rd Year 2nd Semester(B)";
            else if (row % 24 == 17)
                year = "3rd Year 3rd Semester(A)";
            else if (row % 24 == 18)
                year = "3rd Year 3rd Semester(B)";
            else if (row % 24 == 19)
                year = "4th Year 1st Semester(A)";
            else if (row % 24 == 20)
                year = "4th Year 1st Semester(B)";
            else if (row % 24 == 21)
                year = "4th Year 2nd Semester(A)";
            else if (row % 24 == 22)
                year = "4th Year 2nd Semester(B)";
            else if (row % 24 == 23)
                year = "4th Year 3rd Semester(A)";
            else if (row % 24 == 0)
                year = "4th Year 3rd Semester(B)";
            else
                year = "Day";
            return year;
        }
        public void ColumnIDPulling()
        {
            
            try
            {

                string query1, query2, query3, query4, id1, id2, id3,id4;
                int[] column = new int[3];
                int tempColumn;
                conn = new SqlConnection(global::NWUClassRoutine.Properties.Settings.Default.NWUClassRoutineConnectionString1);
                conn.Open();
                query4 = "select TeacherInitials from RoutineInfo where RowNumber=1";
                id4 = new SqlCommand(query4, conn).ExecuteScalar().ToString();
                query1 = string.Format("select [[PreferredDay&TimeSlot1]]] from RoutineInfo where TeacherInitials = '{0}'",id4);
                query2 = "select [[PreferredDay&TimeSlot2]]] from RoutineInfo where TeacherInitials = 'MRI'";
                query3 = "select [[PreferredDay&TimeSlot3]]] from RoutineInfo where TeacherInitials = 'MRI'";
                
                id1 = new SqlCommand(query1, conn).ExecuteScalar().ToString();
                id2 = new SqlCommand(query2, conn).ExecuteScalar().ToString();
                id3 = new SqlCommand(query3, conn).ExecuteScalar().ToString();
                
                if (id1 != null)
                {
                    query = string.Format("select ordinal_position from information_schema.columns c where table_name = 'Routine' and table_schema = 'dbo' and column_name ='{0}'", id2);
                    reader = new SqlCommand(query, conn).ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            column[1] = reader.GetInt32(0);
                            tempColumn = column[1];
                        }
                    }
                    else
                    {
                        //textBox1.Text = "NF";
                    }
                }
                reader.Close();
                if (id2 != null)
                {
                    query = string.Format("select ordinal_position from information_schema.columns c where table_name = 'Routine' and table_schema = 'dbo' and column_name ='{0}'", id2);
                    reader = new SqlCommand(query, conn).ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            column[1] = reader.GetInt32(0);

                        }
                    }
                    else
                    {
                        //textBox1.Text = "NF";
                    }
                }
                reader.Close();
                if (id3 != null)
                {
                    query = string.Format("select ordinal_position from information_schema.columns c where table_name = 'Routine' and table_schema = 'dbo' and column_name ='{0}'", id3);
                    reader = new SqlCommand(query, conn).ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            column[2] = reader.GetInt32(0);
                        }
                    }
                    else
                    {
                        //textBox1.Text = "NF";
                    }
                }

                reader.Close();
                Column = column[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Column ID Pulling", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (conn != null) conn.Close();
            
        }
        private void Btn_Generate_Click(object sender, EventArgs e)
        {
            j = 0;
            RoutineArrayRowIndex = 0;
            RoutineArrayColumnIndex = 0;
            update();
            // viewRoutine();
            fillTableWithNoSubject();
            viewRoutine();
            MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            panel1.Enabled = true;
        }

        //Warning confusing code ahead
        public void CheckArray()
        {
            try
            {
                conn = new SqlConnection(global::NWUClassRoutine.Properties.Settings.Default.NWUClassRoutineConnectionString1);
                conn.Open();
                query = "Select CourseCredit from RoutineInfo where Teacherinitials = 'MRI'";
                tempCourseCredit = new SqlCommand(query, conn).ExecuteScalar().ToString();
                Query1 = "Select CourseCode from RoutineInfo where Teacherinitials = 'MRI'";
                tempCourseCode = new SqlCommand(Query1, conn).ExecuteScalar().ToString();
                CourseCredit = Double.Parse(tempCourseCredit);
                //CourseCredit = Double.Parse(tempCourseCredit);
                CourseCode = Convert.ToString(tempCourseCode);
                YearDeterminingCourseCodeDigit = Convert.ToInt32(CourseCode.Substring(4, 1));
                if (YearDeterminingCourseCodeDigit == 1)
                    row = 1;
                else if (YearDeterminingCourseCodeDigit == 2)
                    row = 7;
                else if (YearDeterminingCourseCodeDigit == 3)
                    row = 13;
                else
                    row = 19;
                SemesterDeterminingCourseCodeDigit = Convert.ToInt32(CourseCode.Substring(5, 1));
                if (CourseCredit == 1.5 || CourseCredit == 0.75)
                {
                    DoubleTimeSlotAssign();
                }
                else
                {
                    SingleTimeSlotAssign();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check Array", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close(); 
            }

        }
        public void ArrayConditionForSemesterTheory()
        {
            string TI, CCE;
            conn = new SqlConnection(global::NWUClassRoutine.Properties.Settings.Default.NWUClassRoutineConnectionString1);
            conn.Open();
            query = "select TeacherInitials from RoutineInfo where RowNumber=1";
            TI = new SqlCommand(query, conn).ExecuteScalar().ToString();
            conn.Close();
            CCE = CourseCode + " " + TI;
            try
            {
                //1st semester
                if (SemesterDeterminingCourseCodeDigit == 1)
                {
                    RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] = CCE;
                    RoutineArray[RoutineArrayRowIndex + 1, RoutineArrayColumnIndex+1] = CCE;
                }
                //2nd semester
                else if (SemesterDeterminingCourseCodeDigit == 2)
                {
                    RoutineArray[RoutineArrayRowIndex + 2, RoutineArrayColumnIndex] = CCE;
                    RoutineArray[RoutineArrayRowIndex + 3, RoutineArrayColumnIndex+1] = CCE;
                }
                //3rd semester
                else
                {
                    RoutineArray[RoutineArrayRowIndex + 4, RoutineArrayColumnIndex] = CCE;
                    RoutineArray[RoutineArrayRowIndex + 5, RoutineArrayColumnIndex+1] = CCE;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Array Condition For Semester Theory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void ArrayConditionForSemesterLab()
        {
            string TI,CCE;
            conn = new SqlConnection(global::NWUClassRoutine.Properties.Settings.Default.NWUClassRoutineConnectionString1);
            conn.Open();
            query = "select TeacherInitials from RoutineInfo where RowNumber=1";
            TI = new SqlCommand(query,conn).ExecuteScalar().ToString();
            conn.Close();
            CCE = CourseCode + " " +TI;
            try
            {
                //1st semester
                if (SemesterDeterminingCourseCodeDigit == 1)
                {
                    RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] = CCE;
                    RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex + 1] = CCE;
                    RoutineArray[RoutineArrayRowIndex + 1, RoutineArrayColumnIndex + 2] = CCE;
                    RoutineArray[RoutineArrayRowIndex + 1, RoutineArrayColumnIndex + 3] = CCE;
                    roomno[RoutineArrayRowIndex] = 301;
                    roomno[RoutineArrayRowIndex+1] = 302;
                }
                //2nd semester
                else if (SemesterDeterminingCourseCodeDigit == 2)
                {
                    RoutineArray[RoutineArrayRowIndex + 2, RoutineArrayColumnIndex] = CCE;
                    RoutineArray[RoutineArrayRowIndex + 2, RoutineArrayColumnIndex + 1] = CCE;
                    RoutineArray[RoutineArrayRowIndex + 3, RoutineArrayColumnIndex + 2] = CCE;
                    RoutineArray[RoutineArrayRowIndex + 3, RoutineArrayColumnIndex + 3] = CCE;
                    roomno[RoutineArrayRowIndex + 2] = 303;
                    roomno[RoutineArrayRowIndex + 3] = 304;
                }
                //3rd semester
                else
                {
                    RoutineArray[RoutineArrayRowIndex + 4, RoutineArrayColumnIndex] = CCE;
                    RoutineArray[RoutineArrayRowIndex + 4, RoutineArrayColumnIndex + 1] = CCE;
                    RoutineArray[RoutineArrayRowIndex + 5, RoutineArrayColumnIndex + 2] = CCE;
                    RoutineArray[RoutineArrayRowIndex + 5, RoutineArrayColumnIndex + 3] = CCE;
                    roomno[RoutineArrayRowIndex + 4] = 301;
                    roomno[RoutineArrayRowIndex + 5] = 302;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Array Condition For Semester Lab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void SingleTimeSlotAssign()
        {
            int column;
            ColumnIDPulling();
            column = Column;
            try
            {
                for (RoutineArrayRowIndex = 1; RoutineArrayRowIndex <= 25; RoutineArrayRowIndex++)
                {
                    for (RoutineArrayColumnIndex = 1; RoutineArrayColumnIndex <= 41; RoutineArrayColumnIndex++)
                    {
                        //Monday
                        if (RoutineArrayRowIndex == row && RoutineArrayColumnIndex == column && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-" && column <=41 )
                        {
                            ArrayConditionForSemesterTheory();
                        }
                        //Tuesday
                        else if (RoutineArrayRowIndex == row  && RoutineArrayColumnIndex == column + 6 && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-" && column + 6 <= 41)
                        {
                            ArrayConditionForSemesterTheory();
                        }
                        //Wednesday
                        else if (RoutineArrayRowIndex == row  && RoutineArrayColumnIndex == column + 12 && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-" && column + 12 <= 41)
                        {
                            ArrayConditionForSemesterTheory();
                        }
                        //Thursday
                        else if (RoutineArrayRowIndex == row  && RoutineArrayColumnIndex == column + 18 && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-" && column + 18 <= 41)
                        {
                            ArrayConditionForSemesterTheory();
                        }
                        //Friday
                        else if (RoutineArrayRowIndex == row && RoutineArrayColumnIndex == column + 24  && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-" && column + 24 <= 41)
                        {
                            ArrayConditionForSemesterTheory();
                        }
                        //Saturday
                        else if (RoutineArrayRowIndex == row && RoutineArrayColumnIndex == column + 30 && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-" && column + 30<= 41)
                        {
                            ArrayConditionForSemesterTheory();
                        }
                        ////Monday
                        else if (RoutineArrayRowIndex == row && RoutineArrayColumnIndex == column + 36 && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-" && column + 36 <= 41)
                        {
                            ArrayConditionForSemesterTheory();
                        }
                        else if (RoutineArrayRowIndex == row && RoutineArrayColumnIndex == column && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-" && column + 36 <= 41)
                        {
                            ArrayConditionForSemesterTheory();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Single Time Slot Assign", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void DoubleTimeSlotAssign()
        {
            int column;
            ColumnIDPulling();
            column = Column;
            try
            {
                for (RoutineArrayRowIndex = 1; RoutineArrayRowIndex <= 25; RoutineArrayRowIndex++)
                {
                    for (RoutineArrayColumnIndex = 1; RoutineArrayColumnIndex <= 41; RoutineArrayColumnIndex++)
                    {
                        //Monday
                        if (RoutineArrayRowIndex == row && RoutineArrayColumnIndex == column && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-")
                        {
                            ArrayConditionForSemesterLab();
                        }
                        //Tuesday
                        else if (RoutineArrayRowIndex == row && RoutineArrayColumnIndex == column + 6 && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-")
                        {
                            ArrayConditionForSemesterLab();
                        }
                        //Wednesday
                        else if (RoutineArrayRowIndex == row && RoutineArrayColumnIndex == column + 12 && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-")
                        {
                            ArrayConditionForSemesterLab();
                        }
                        //Thursday
                        else if (RoutineArrayRowIndex == row && RoutineArrayColumnIndex == column + 18  && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-")
                        {
                            ArrayConditionForSemesterLab();
                        }
                        //Friday
                        else if (RoutineArrayRowIndex == row && RoutineArrayColumnIndex == column + 24 && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-" && column + 24 <= 41)
                        {
                            ArrayConditionForSemesterLab();
                        }
                        //Saturday
                        else if (RoutineArrayRowIndex == row && RoutineArrayColumnIndex == column + 30 && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-" && column + 30 <= 41)
                        {
                            ArrayConditionForSemesterLab();
                        }
                        ////Monday
                        else if (RoutineArrayRowIndex == row && RoutineArrayColumnIndex == column + 36 && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-" && column + 36 <= 41)
                        {
                            ArrayConditionForSemesterLab();
                        }
                        else if (RoutineArrayRowIndex == row && RoutineArrayColumnIndex == column && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-" && column + 36 <= 41)
                        {
                            ArrayConditionForSemesterLab();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Double Time Slot Assign", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void InsertSingleCourseIntoPosition()
        {
            CheckArray();
        }
        public void QueryBuilder()
        {
            /*
             * query = "select PreferredTimeSlot1 from RoutineInfo where TeacherInitials = 'MRI'";
                id = new SqlCommand(query, conn).ExecuteScalar().ToString();
                if (id != null)
                {
                    //textBox1.Text = id;

                    query = string.Format("select ordinal_position from information_schema.columns c where table_name = 'FinalRoutine' and table_schema = 'dbo' and column_name ='{0}'", id);
                    //string query = ("select ordinal_position from information_schema.columns c where table_name = 'FinalRoutine' and table_schema = 'dbo' and column_name =[9:15-10:30]");
                    reader = new SqlCommand(query, conn).ExecuteReader();
             * */
           // Query1 = string.Format("Select TeacherInitials where RowNumber = '{0}'", RowNumberDataGridView);
           // TeacherInitials = Query1;
          //  Query2 = string.Format("Select CourseCredit where TeacherInitials='{0}'", TeacherInitial);
        }








    }
}
