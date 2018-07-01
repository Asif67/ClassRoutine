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
        string query,CourseCode="CSE-4201",tempCourseCredit;
        int[] roomno =new int[121] {401,402,403,404,501,502,503,504,601,602,603,604,701,702,703,704,801,802,803,804,901,902,903,904,401,402,403,404,501,502,503,504,601,602,603,604,701,702,703,704,801,802,803,804,901,902,903,904,401,402,403,404,501,502,503,504,601,602,603,604,701,702,703,704,801,802,803,804,901,902,903,904,401,402,403,404,501,502,503,504,601,602,603,604,701,702,703,704,801,802,803,804,901,902,903,904,401,402,403,404,501,502,503,504,601,602,603,604,701,702,703,704,801,802,803,804,901,902,903,904,401};
        int[] LabRoomNo = new int[3] { 302, 303, 304 };
        int Column;
        int j = 0;
        SqlCommand Sqlcmd;
        SqlDataReader reader, reader1;
        DataTable dbdataset;
        int RoutineArrayRowIndex, RoutineArrayColumnIndex;
        double CourseCredit;
        int column, row, SemesterDeterminingCourseCodeDigit, YearDeterminingCourseCodeDigit;
        public Routine()
        {
            InitializeComponent();
        }
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
            InsertSingleCourseIntoPosition();
            conn = new SqlConnection(@"Data Source=MIRAZ-PC\SQLEXPRESS;Initial Catalog=ClassRoutine;Integrated Security=True");
            query = "DELETE FinalRoutine where [Term&Section&Department] != ' year'"; // Problem
            Sqlcmd = new SqlCommand(query, conn);
            conn.Open();
            Sqlcmd.ExecuteNonQuery();
            conn.Close();
            for (int i = 1; i < 121; i++)
            {
                    query = "INSERT INTO FinalRoutine([Term&Section&Department],[8:00-9:15],[9:15-10:30],[10:45-12:00],[12:00-1:15],[2:00-3:15],[3:15-4:30],RowNumber,roomno) values( '" + year(i) + "','" + RoutineArray[i, 1] + "','" + RoutineArray[i, 2] + "','" + RoutineArray[i, 3] + "','" + RoutineArray[i, 4] + "','" + RoutineArray[i, 5] + "','" + RoutineArray[i, 6] + "','" + i + "','" + roomno[i] + "')";
                    Sqlcmd = new SqlCommand(query, conn);
                    conn.Open();
                    Sqlcmd.ExecuteNonQuery();
                    conn.Close();
                /*if (i >= 23 || i >= 47 || i >= 71 || i >= 95 || i >= 119 || i >= 121)
                {

                    query = "INSERT INTO FinalRoutine([Term&Section&Department],[8:00-9:15],[9:15-10:30],[10:45-12:00],[12:00-1:15],[2:00-3:15],[3:15-4:30],RowNumber,roomno) values( '" + year(i) + "','" + RoutineArray[i, 1] + "','" + RoutineArray[i, 2] + "','" + RoutineArray[i, 3] + "','" + RoutineArray[i, 4] + "','" + RoutineArray[i, 5] + "','" + RoutineArray[i, 6] + "','" + i + "','" + roomno[j] + "')";
                    Sqlcmd = new SqlCommand(query, conn);
                    conn.Open();
                    Sqlcmd.ExecuteNonQuery();
                    conn.Close();
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
                    Sqlcmd = new SqlCommand(query, conn);
                    conn.Open();
                    Sqlcmd.ExecuteNonQuery();
                    conn.Close();
                }
                /*Sqlcmd = new SqlCommand(query, conn);
                conn.Open();
                Sqlcmd.ExecuteNonQuery();
                conn.Close();*/
            }
            
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
                conn = new SqlConnection(@"Data Source=MIRAZ-PC\SQLEXPRESS;Initial Catalog=ClassRoutine;Integrated Security=True");
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

                string query, id, selection = "NM";
                conn = new SqlConnection(@"Data Source=MIRAZ-PC\SQLEXPRESS;Initial Catalog=ClassRoutine;Integrated Security=True");
                conn.Open();
                query = "select PreferredTimeSlot1 from RoutineInfo where TeacherInitials = 'MRI'";
                id = new SqlCommand(query, conn).ExecuteScalar().ToString();
                if (id != null)
                {
                    //textBox1.Text = id;

                    query = string.Format("select ordinal_position from information_schema.columns c where table_name = 'FinalRoutine' and table_schema = 'dbo' and column_name ='{0}'", id);
                    //string query = ("select ordinal_position from information_schema.columns c where table_name = 'FinalRoutine' and table_schema = 'dbo' and column_name =[9:15-10:30]");
                    reader = new SqlCommand(query, conn).ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Column = reader.GetInt32(0);
                            //textBox1.Text = Convert.ToString(Column);
                            // textBox1.Text = Convert.ToString(id);

                        }
                    }
                    else
                    {
                        //textBox1.Text = "NF";
                    }
                }

                reader.Close();
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
            viewRoutine();
            MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Warning confusing code ahead
        public void CheckArray()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=MIRAZ-PC\SQLEXPRESS;Initial Catalog=ClassRoutine;Integrated Security=True");
                conn.Open();
                query = "Select CourseCredit from RoutineInfo where TeacherInitials = 'SY'";
                tempCourseCredit = new SqlCommand(query, conn).ExecuteScalar().ToString();
                CourseCredit = Double.Parse(tempCourseCredit);
                CourseCredit = Double.Parse(tempCourseCredit);
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
            try
            {
                //1st semester
                if (SemesterDeterminingCourseCodeDigit == 1)
                {
                    RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] = CourseCode;
                    RoutineArray[RoutineArrayRowIndex + 1, RoutineArrayColumnIndex+1] = CourseCode;
                }
                //2nd semester
                else if (SemesterDeterminingCourseCodeDigit == 2)
                {
                    RoutineArray[RoutineArrayRowIndex + 2, RoutineArrayColumnIndex] = CourseCode;
                    RoutineArray[RoutineArrayRowIndex + 3, RoutineArrayColumnIndex+1] = CourseCode;
                }
                //3rd semester
                else
                {
                    RoutineArray[RoutineArrayRowIndex + 4, RoutineArrayColumnIndex] = CourseCode;
                    RoutineArray[RoutineArrayRowIndex + 5, RoutineArrayColumnIndex+1] = CourseCode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Array Condition For Semester Theory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void ArrayConditionForSemesterLab()
        {
            try
            {
                //1st semester
                if (SemesterDeterminingCourseCodeDigit == 1)
                {
                    RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] = CourseCode;
                    RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex + 1] = CourseCode;
                    RoutineArray[RoutineArrayRowIndex + 1, RoutineArrayColumnIndex+2] = CourseCode;
                    RoutineArray[RoutineArrayRowIndex + 1, RoutineArrayColumnIndex + 3] = CourseCode;
                    roomno[RoutineArrayRowIndex] = 301;
                    roomno[RoutineArrayRowIndex+1] = 302;
                }
                //2nd semester
                else if (SemesterDeterminingCourseCodeDigit == 2)
                {
                    RoutineArray[RoutineArrayRowIndex + 2, RoutineArrayColumnIndex] = CourseCode;
                    RoutineArray[RoutineArrayRowIndex + 2, RoutineArrayColumnIndex + 1] = CourseCode;
                    RoutineArray[RoutineArrayRowIndex + 3, RoutineArrayColumnIndex+2] = CourseCode;
                    RoutineArray[RoutineArrayRowIndex + 3, RoutineArrayColumnIndex + 3] = CourseCode;
                    roomno[RoutineArrayRowIndex + 2] = 303;
                    roomno[RoutineArrayRowIndex + 3] = 304;
                }
                //3rd semester
                else
                {
                    RoutineArray[RoutineArrayRowIndex + 4, RoutineArrayColumnIndex] = CourseCode;
                    RoutineArray[RoutineArrayRowIndex + 4, RoutineArrayColumnIndex + 1] = CourseCode;
                    RoutineArray[RoutineArrayRowIndex + 5, RoutineArrayColumnIndex+2] = CourseCode;
                    RoutineArray[RoutineArrayRowIndex + 5, RoutineArrayColumnIndex + 3] = CourseCode;
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
            ColumnIDPulling();
            column = Column-2;
            try
            {
                for (RoutineArrayRowIndex = 1; RoutineArrayRowIndex <= 121; RoutineArrayRowIndex++)
                {
                    for (RoutineArrayColumnIndex = 1; RoutineArrayColumnIndex <= 6; RoutineArrayColumnIndex++)
                    {
                        //Monday
                        if (RoutineArrayRowIndex == row && RoutineArrayColumnIndex == column && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-")
                        {
                            ArrayConditionForSemesterTheory();
                        }
                        //Tuesday
                        else if (RoutineArrayRowIndex == row + 24 && RoutineArrayColumnIndex == column && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-")
                        {
                            ArrayConditionForSemesterTheory();
                        }
                        //Wednesday
                        else if (RoutineArrayRowIndex == row + 72 && RoutineArrayColumnIndex == column && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-")
                        {
                            ArrayConditionForSemesterTheory();
                        }
                        //Thursday
                        else if (RoutineArrayRowIndex == row + 96 && RoutineArrayColumnIndex == column && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-")
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
            ColumnIDPulling();
            column = Column-2;
            try
            {
                for (RoutineArrayRowIndex = 1; RoutineArrayRowIndex <= 121; RoutineArrayRowIndex++)
                {
                    for (RoutineArrayColumnIndex = 1; RoutineArrayColumnIndex <= 6; RoutineArrayColumnIndex++)
                    {
                        //Monday
                        if (RoutineArrayRowIndex == row && RoutineArrayColumnIndex == column && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-")
                        {
                            ArrayConditionForSemesterLab();
                        }
                        //Tuesday
                        else if (RoutineArrayRowIndex == row + 24 && RoutineArrayColumnIndex == column && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-")
                        {
                            ArrayConditionForSemesterLab();
                        }
                        //Wednesday
                        else if (RoutineArrayRowIndex == row + 72 && RoutineArrayColumnIndex == column && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-")
                        {
                            ArrayConditionForSemesterLab();
                        }
                        //Thursday
                        else if (RoutineArrayRowIndex == row + 96 && RoutineArrayColumnIndex == column && RoutineArray[RoutineArrayRowIndex, RoutineArrayColumnIndex] == "-")
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

        }








    }
}
