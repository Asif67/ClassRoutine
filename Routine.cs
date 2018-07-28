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
        string id, id2;
        //varaibles for using in main code
        List<string> Column1 = new List<string>();
        List<string> Column2 = new List<string>();
        List<string> CourseCode = new List<string>();
        List<string> CourseCredit = new List<string>();
        List<string> TeacherInitials = new List<string>();
        //varaibles for using in main code
        string[,] RoutineArray = new string[25,41];
        string query,tempCourseCredit, tempCourseCode;
        int[] roomno =new int[25] {401,402,403,404,501,502,503,504,601,602,603,604,701,702,703,704,801,802,803,804,901,902,903,904,401};
        int[] LabRoomNo = new int[3] { 302, 303, 304 };
        int Column;
        int j = 0;
        SqlCommand Sqlcmd;
        SqlDataReader reader, reader1;
        DataTable dbdataset;
        int RoutineArrayRowIndex, RoutineArrayColumnIndex;
        int column, row, SemesterDeterminingCourseCodeDigit, yearCADeterminingCourseCodeDigit;
        string Query1, Query2, Query3, Query4;
        int[] preferredTimeSlots = new int[3];
        struct Stuffs
        {
            public int column1, column2, column3, row, k, rowAddition, temprow, tempColumn, priority;
            public string Course, C, temp, year, semester, TeacherStatus, Tailer1, Tailer2;
            public double CourseCredit;
        };
        //Variables for CheckArray
        string[,] m = new string[73, 40];
        string[] Roomno = new string[73] { "301", "304", "401", "402", "403", "404", "501", "502", "503", "504", "601", "602", "603", "604", "701", "702", "703", "704", "801", "802", "803", "804", "901", "902", "903", "904", "301", "304", "401", "402", "403", "404", "501", "502", "503", "504", "601", "602", "603", "604", "701", "702", "703", "704", "801", "802", "803", "804", "901", "902", "903", "904", "301", "304", "401", "402", "403", "404", "501", "502", "503", "504", "601", "602", "603", "604", "701", "702", "703", "704", "801", "802", "803" };
        string[] Term = new string[72] { "1st year 1st semester(A)", "1st year 1st semester(B)", "1st year 2nd semester(A)", "1st year 2nd semester(B)", "1st year 3rd semester(A)", "1st year 3rd semester(B)", "2nd year 1st semester(A)", "2nd year 1st semester(B)", "2nd year 2nd semester(A)", "2nd year 2nd semester(B)", "2nd year 3rd semester(A)", "2nd year 3rd semester(B)", "3rd year 1st semester(A)", "3rd year 1st semester(B)", "3rd year 2nd semester(A)", "3rd year 2nd semester(B)", "3rd year 3rd semester(A)", "3rd year 3rd semester(B)", "4th year 1st semester(A)", "4th year 1st semester(B)", "4th year 2nd semester(A)", "4th year 2nd semester(B)", "4th year 3rd semester(A)", "4th year 3rd semester(B)", "1st year 1st semester(A)", "1st year 1st semester(B)", "1st year 2nd semester(A)", "1st year 2nd semester(B)", "1st year 3rd semester(A)", "1st year 3rd semester(B)", "2nd year 1st semester(A)", "2nd year 1st semester(B)", "2nd year 2nd semester(A)", "2nd year 2nd semester(B)", "2nd year 3rd semester(A)", "2nd year 3rd semester(B)", "3rd year 1st semester(A)", "3rd year 1st semester(B)", "3rd year 2nd semester(A)", "3rd year 2nd semester(B)", "3rd year 3rd semester(A)", "3rd year 3rd semester(B)", "4th year 1st semester(A)", "4th year 1st semester(B)", "4th year 2nd semester(A)", "4th year 2nd semester(B)", "4th year 3rd semester(A)", "4th year 3rd semester(B)", "1st year 1st semester(A)", "1st year 1st semester(B)", "1st year 2nd semester(A)", "1st year 2nd semester(B)", "1st year 3rd semester(A)", "1st year 3rd semester(B)", "2nd year 1st semester(A)", "2nd year 1st semester(B)", "2nd year 2nd semester(A)", "2nd year 2nd semester(B)", "2nd year 3rd semester(A)", "2nd year 3rd semester(B)", "3rd year 1st semester(A)", "3rd year 1st semester(B)", "3rd year 2nd semester(A)", "3rd year 2nd semester(B)", "3rd year 3rd semester(A)", "3rd year 3rd semester(B)", "4th year 1st semester(A)", "4th year 1st semester(B)", "4th year 2nd semester(A)", "4th year 2nd semester(B)", "4th year 3rd semester(A)", "4th year 3rd semester(B)" };
        string[] RowNo = new string[74] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73" };
        string[] Header = new string[39] { "RN", "TM", "MPS1", "MPS2", "MPS3", "MPS4", "MPS5", "MPS6", "TPS1", "TPS2", "TPS3", "TPS4", "TPS5", "TPS6", "WPS1", "WPS2", "WPS3", "WPS4", "WPS5", "WPS6", "TPS1", "TPS2", "TPS3", "TPS4", "TPS5", "TPS6", "FPS1", "FPS2", "FPS3", "FPS4", "FPS5", "FPS6", "SPS1", "SPS2", "SPS3", "SPS4", "SPS5", "SPS6", "RMN" };
        string[] Tailer1 = new string[72] { " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt", " 301 Alt", " 302 Alt" };
        string[] Tailer2 = new string[72] { " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302", " 301", " 302" };
        int[] column1 = new int[72];
        int[] column2 = new int[72];
        int[] column3 = new int[72];
        int[] rowAddition = new int[72];
        int[] temprow = new int[72];
        int[] tempColumn = new int[72];
        int[] priority = new int[72];
        int h, k;
        string[] Course = new string[72];
        string C;
        string[] semester = new string[72];
        string[] TeacherStatus = new string[72];
        //Variables for Check Array
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
            DataExtraction();
            CheckArray();
            for(int i=0;i<25;i++)
            {
                for(int j=0;j<40;j++)
                {
                    RoutineArray[i, j]=m[i,j];
                }
            }
            fillTableWithNoSubject();
            //InsertSingleCourseIntoPosition();
            conn = new SqlConnection(global::NWUClassRoutine.Properties.Settings.Default.NWUClassRoutineConnectionString1);
            for (int i = 0; i < 25; i++)
            {
                conn.Open();
                //query = "INSERT INTO Routine([RowNumber],[[Term&Section&Department]]],[[Monday 8:00-9:15]]] ,[[Monday 9:15-10:30]]],[[Monday 10:45-12:00]]],[[Monday 12:00-1:15]]],[[Monday 2:00-3:15]]],[[Monday 3:15-4:30]]],[[Tuesday 8:00-9:15]]],[[Tuesday 9:15-10:30]]],[[Tuesday 10:45-12:00]]],[[Tuesday 12:00-1:15]]],[[Tuesday 2:00-3:15]]],[[Tuesday 3:15-4:30]]],[[Wednesday 8:00-9:15]]],[[Wednesday 9:15-10:30]]],[[Wednesday 10:45-12:00]]],[[Wednesday 12:00-1:15]]],[[Wednesday 2:00-3:15]]],[[Wednesday 3:15-4:30]]],[[Thursday 8:00-9:15]]],[[Thursday 9:15-10:30]]],[[Thursday 10:45-12:00]]],[[Thursday 12:00-1:15]]],[[Thursday 2:00-3:15]]],[[Thursday 3:15-4:30]]],[[Friday 8:00-9:15]]],[[Friday 9:15-10:30]]],[[Friday 10:45-12:00]]],[[Friday 12:00-1:15]]],[[Friday 2:00-3:15]]],[[Friday 3:15-4:30]]],[[Saturday 8:00-9:15]]],[[Saturday 9:15-10:30]]],[[Saturday 10:45-12:00]]],[[Saturday 12:00-1:15]]],[[Saturday 2:00-3:15]]],[[Saturday 3:15-4:30]]],[RoomNo]) values( '" + i +"','"+ year(i) + "','" + RoutineArray[i, 1] + "','" + RoutineArray[i, 2] + "','" + RoutineArray[i, 3] + "','" + RoutineArray[i, 4] + "','" + RoutineArray[i, 5] + "','" + RoutineArray[i, 6] + "','" + RoutineArray[i, 7] + "','" + RoutineArray[i, 8] + "','" + RoutineArray[i, 9] + "','" + RoutineArray[i, 10] + "','" + RoutineArray[i, 11] + "','" + RoutineArray[i, 12] + "','" + RoutineArray[i, 13] + "','" + RoutineArray[i, 14] + "','" + RoutineArray[i, 15] + "','" + RoutineArray[i, 16] + "','" + RoutineArray[i, 17] + "','" + RoutineArray[i, 18] + "','" + RoutineArray[i, 19] + "','" + RoutineArray[i, 20] + "','" + RoutineArray[i, 21] + "','" + RoutineArray[i, 22] + "','" + RoutineArray[i, 23] + "','" + RoutineArray[i, 24] + "','" + RoutineArray[i, 25] + "','" + RoutineArray[i, 26] + "','" + RoutineArray[i, 27] + "','" + RoutineArray[i, 28] + "','" + RoutineArray[i, 29] + "','" + RoutineArray[i, 30] + "','" + RoutineArray[i, 31] + "','" + RoutineArray[i, 32] + "','" + RoutineArray[i, 33] + "','" + RoutineArray[i, 34] + "','" + RoutineArray[i, 35] + "','" + RoutineArray[i, 36] +  "','" + roomno[i] + "')";
                query = "INSERT INTO Routine([RowNumber],[[Term&Section&Department]]],[[Monday 8:00-9:15]]] ,[[Monday 9:15-10:30]]],[[Monday 10:45-12:00]]],[[Monday 12:00-1:15]]],[[Monday 2:00-3:15]]],[[Monday 3:15-4:30]]],[[Tuesday 8:00-9:15]]],[[Tuesday 9:15-10:30]]],[[Tuesday 10:45-12:00]]],[[Tuesday 12:00-1:15]]],[[Tuesday 2:00-3:15]]],[[Tuesday 3:15-4:30]]],[[Wednesday 8:00-9:15]]],[[Wednesday 9:15-10:30]]],[[Wednesday 10:45-12:00]]],[[Wednesday 12:00-1:15]]],[[Wednesday 2:00-3:15]]],[[Wednesday 3:15-4:30]]],[[Thursday 8:00-9:15]]],[[Thursday 9:15-10:30]]],[[Thursday 10:45-12:00]]],[[Thursday 12:00-1:15]]],[[Thursday 2:00-3:15]]],[[Thursday 3:15-4:30]]],[[Friday 8:00-9:15]]],[[Friday 9:15-10:30]]],[[Friday 10:45-12:00]]],[[Friday 12:00-1:15]]],[[Friday 2:00-3:15]]],[[Friday 3:15-4:30]]],[[Saturday 8:00-9:15]]],[[Saturday 9:15-10:30]]],[[Saturday 10:45-12:00]]],[[Saturday 12:00-1:15]]],[[Saturday 2:00-3:15]]],[[Saturday 3:15-4:30]]],[RoomNo]) values( '" + i + "','" + year(i) + "','" + RoutineArray[i, 1] + "','" + RoutineArray[i, 2] + "','" + RoutineArray[i, 3] + "','" + RoutineArray[i, 4] + "','" + RoutineArray[i, 5] + "','" + RoutineArray[i, 6] + "','" + RoutineArray[i, 7] + "','" + RoutineArray[i, 8] + "','" + RoutineArray[i, 9] + "','" + RoutineArray[i, 10] + "','" + RoutineArray[i, 11] + "','" + RoutineArray[i, 12] + "','" + RoutineArray[i, 13] + "','" + RoutineArray[i, 14] + "','" + RoutineArray[i, 15] + "','" + RoutineArray[i, 16] + "','" + RoutineArray[i, 17] + "','" + RoutineArray[i, 18] + "','" + RoutineArray[i, 19] + "','" + RoutineArray[i, 20] + "','" + RoutineArray[i, 21] + "','" + RoutineArray[i, 22] + "','" + RoutineArray[i, 23] + "','" + RoutineArray[i, 24] + "','" + RoutineArray[i, 25] + "','" + RoutineArray[i, 26] + "','" + RoutineArray[i, 27] + "','" + RoutineArray[i, 28] + "','" + RoutineArray[i, 29] + "','" + RoutineArray[i, 30] + "','" + RoutineArray[i, 31] + "','" + RoutineArray[i, 32] + "','" + RoutineArray[i, 33] + "','" + RoutineArray[i, 34] + "','" + RoutineArray[i, 35] + "','" + RoutineArray[i, 36] + "','" + roomno[i] + "')";

                Sqlcmd = new SqlCommand(query, conn);
                    
                    Sqlcmd.ExecuteNonQuery();
                    conn.Close();
                
            }
            
        }
        public void fillTableWithNoSubject()
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 40; j++)
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
        public void DataExtraction()
        {
            SqlConnection cnn;
            int result;
            SqlDataReader reader;

            try
            {

                cnn = new SqlConnection(global::NWUClassRoutine.Properties.Settings.Default.NWUClassRoutineConnectionString1);
                cnn.Open();
                //Preferred Time SLot1
                SqlDataAdapter da = new SqlDataAdapter("select PreferredDayNTimeSlot1 from RoutineInfo", cnn);
                DataSet ds = new DataSet();
                da.Fill(ds, "RoutineInfo");
                List<string> PrefferedDayTimeSlot1 = new List<string>();
                foreach (DataRow row in ds.Tables["RoutineInfo"].Rows)
                {
                    PrefferedDayTimeSlot1.Add(row["PreferredDayNTimeSlot1"].ToString());
                }
                //listBox1.DataSource = PrefferedDayTimeSlot1;
                for (int i = 0; i < PrefferedDayTimeSlot1.Count; i++)
                {
                    id = PrefferedDayTimeSlot1[i];
                    string query = ("select ordinal_position from information_schema.columns c where table_name = 'Routine' and table_schema = 'dbo' and column_name ='[" + id + "]'");
                    reader = new SqlCommand(query, cnn).ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result = reader.GetInt32(0);
                            //textBox1.Text = Convert.ToString(result);
                            //comboBox1.Text = Convert.ToString(result);
                            //listBox1.Text = Convert.ToString(result);
                            Column1.Add(Convert.ToString(result));

                        }

                    }

                    else
                    {

                        // Console.WriteLine("No rows found.");
                        //textBox1.Text = "NF";

                    }

                    reader.Close();


                }
                //Preferred Time SLot1
                //Preferred Time SLot2
                SqlDataAdapter da2 = new SqlDataAdapter("select PreferredDayNTimeSlot2 from RoutineInfo", cnn);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2, "RoutineInfo");
                List<string> PrefferedDayTimeSlot2 = new List<string>();
                foreach (DataRow row in ds2.Tables["RoutineInfo"].Rows)
                {
                    PrefferedDayTimeSlot2.Add(row["PreferredDayNTimeSlot2"].ToString());
                }
                //listBox2.DataSource = PrefferedDayTimeSlot2;
                for (int i = 0; i < PrefferedDayTimeSlot2.Count; i++)
                {
                    id2 = PrefferedDayTimeSlot2[i];
                    string query = ("select ordinal_position from information_schema.columns c where table_name = 'Routine' and table_schema = 'dbo' and column_name ='[" + id2 + "]'");
                    reader = new SqlCommand(query, cnn).ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result = reader.GetInt32(0);
                            //textBox4.Text = Convert.ToString(result);
                            //comboBox.Text = Convert.ToString(result);
                            //listBox2.Text = Convert.ToString(result);
                            Column2.Add(Convert.ToString(result));

                        }

                    }

                    else
                    {

                        // Console.WriteLine("No rows found.");
                        //textBox1.Text = "NF";

                    }

                    reader.Close();


                }
                //Preferred Time SLot2
                ////CourseCredit
                SqlDataAdapter da3 = new SqlDataAdapter("select CourseCredit from RoutineInfo", cnn);
                DataSet ds3 = new DataSet();
                da3.Fill(ds3, "RoutineInfo");
                foreach (DataRow row in ds3.Tables["RoutineInfo"].Rows)
                {
                    CourseCredit.Add(row["CourseCredit"].ToString());
                }
                ////CourseCredit
                //CourseCode
                SqlDataAdapter da4 = new SqlDataAdapter("select CourseCode from RoutineInfo", cnn);
                DataSet ds4 = new DataSet();
                da4.Fill(ds4, "RoutineInfo");
                foreach (DataRow row in ds4.Tables["RoutineInfo"].Rows)
                {
                    CourseCode.Add(row["CourseCode"].ToString());
                }
                //CourseCode
                //CourseCode
                SqlDataAdapter da5 = new SqlDataAdapter("select TeacherInitials from RoutineInfo", cnn);
                DataSet ds5 = new DataSet();
                da5.Fill(ds5, "RoutineInfo");
                foreach (DataRow row in ds5.Tables["RoutineInfo"].Rows)
                {
                    TeacherInitials.Add(row["TeacherInitials"].ToString());
                }
                //CourseCode
                //Print
                //Column1 & Column2 are list ouputs of column id Pulling
                //listBox1.DataSource = Column1;
                //listBox2.DataSource = Column2;
                //listBox3.DataSource = CourseCredit;
                //listBox4.DataSource = CourseCode;
                //listBox5.DataSource = TeacherInitials;
                ////Column1 & Column2 are list ouputs of column id Pulling
                ////Checking List Elements
                ////1st element index is 0;
                //textBox5.Text = Column1[0];
                //textBox6.Text = Column2[0];
                //textBox7.Text = CourseCode[0];
                //textBox8.Text = CourseCredit[0];
                //textBox9.Text = TeacherInitials[0];
                ////1st element index is 0;
                //textBox10.Text = Column1[1];
                //textBox11.Text = Column2[1];
                //textBox12.Text = CourseCode[1];
                //textBox13.Text = CourseCredit[1];
                //textBox14.Text = TeacherInitials[1];

                //textBox15.Text = Column1[2];
                //textBox16.Text = Column2[2];
                //textBox17.Text = CourseCode[2];
                //textBox18.Text = CourseCredit[2];
                //textBox19.Text = TeacherInitials[2];
                //Checking List Elements
                //Print
                cnn.Close();


            

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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
            Stuffs[] Stacks = new Stuffs[72];
            Stuffs temp;
            //RoomNo Assign
            for (int i = 0; i < 73; i++)
            {
                m[i, 39] = Roomno[i];
            }
            //RoomNo Assign
            //RowNo Assign
            for (int i = 0; i < 73; i++)
            {
                m[i,0] = RowNo[i];
            }
            //RowNo Assign
            //main Code
            //priority set
            //Taking Inputs
            int h = 1;
            string tempcc;
            string tempps1,tempps2;
            h = CourseCode.Count;
            for (int i = 0; i < h; i++)
            {

                //List to Stack array
                Stacks[i+1].Course = CourseCode[i];
                Stacks[i+1].TeacherStatus = TeacherStatus[i];
                tempcc = CourseCredit[i];
                Stacks[i+1].CourseCredit = double.Parse(tempcc);
                //List to Stack array
                if (Stacks[i+1].CourseCredit == 0.75 || Stacks[i+1].CourseCredit == 1.5)
                {
                    //List to Stack array
                    tempps1 = Column1[i];
                    Stacks[i+1].column1 = int.Parse(tempps1);
                    //List to Stack array
                }
                else
                {
                    //List to Stack array
                    tempps1 = Column1[i];
                    Stacks[i+1].column1 = int.Parse(tempps1);
                    tempps2 = Column2[i];
                    Stacks[i+1].column2 = int.Parse(tempps2);
                    //List to Stack array
                }
                if (Stacks[i+1].TeacherStatus == "VisitingFacultyMember")
                {
                    Stacks[i+1].priority = 1;
                }
                else if (Stacks[i+1].TeacherStatus == "SeniorLecturer")
                {
                    Stacks[i+1].priority = 2;
                }
                else if (Stacks[i+1].TeacherStatus == "Lecturer")
                {
                    Stacks[i+1].priority = 3;
                }

            }
            //Taking Inputs
            //Bubble Sorting
            for (int i = 1; i < h; i++)
            {
                for (int j = 0; j < h - i; j++)
                {

                    if (Stacks[j].priority > Stacks[j + 1].priority)
                    {
                        temp = Stacks[j];
                        Stacks[j] = Stacks[j + 1];
                        Stacks[j + 1] = temp;
                    }
                }

            }
            
            //priority set
            //BubbleSorting
            //main Routine GenerationCode
            for (int i = 0; i < h; i++)
            {
                Stacks[i+1].year = (Stacks[i+1].Course).Substring(4, 1);
                Stacks[i+1].semester = (Stacks[i+1].Course).Substring(5, 1);
                if (Stacks[i+1].year == "-" && Stacks[i+1].semester != "-")
                {
                    Stacks[i+1].year = (Stacks[i+1].Course).Substring(5, 1);
                    Stacks[i+1].semester = (Stacks[i+1].Course).Substring(6, 1);
                }
                Stacks[i+1].temprow = Convert.ToInt32((Stacks[i+1].year));
                Stacks[i+1].rowAddition = Convert.ToInt32((Stacks[i+1].semester));
                if (Stacks[i+1].temprow == 1)
                    Stacks[i+1].row = 1;
                else if (Stacks[i+1].temprow == 2)
                    Stacks[i+1].row = 7;
                else if (Stacks[i+1].temprow == 3)
                    Stacks[i+1].row = 13;
                else
                    Stacks[i+1].row = 19;
                Stacks[i+1].column1 = 1;
                Stacks[i+1].column2 = 7;
                Stacks[i+1].column3 = 14;
                for (int k = 1; k < 73; k++)
                {
                    for (int l = 1; l < 40; l++)
                    {
                        //Condition Working fine(1.1,1.2,1.3,2.1 first condition)
                        //Condition Working fine(Priority Overlapping)
                        if (Stacks[i+1].CourseCredit == 0.75)
                        {
                            //Double Time Slot Assign2
                            //Preferred Time Slot 1
                            if (k == Stacks[i+1].row && l == Stacks[i+1].column1)
                            {
                                //1st semester
                                if (Stacks[i+1].rowAddition == 1)
                                {
                                    if (Stacks[i].column1 != Stacks[i+1].column1)
                                    {
                                        if ((l + 2) < 39 && l + 3 <= 39)
                                        {
                                            m[k,l + 1] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 1,l + 4] = Stacks[i+1].Course + " 302" + " Alt";
                                            m[k,l + 2] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 1,l + 3] = Stacks[i+1].Course + " 302" + " Alt";
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-" && m[k,l - 3] == "-")
                                        {
                                            m[k,l - 1] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 1,l - 2] = Stacks[i+1].Course + " 302" + " Alt";
                                            m[k,l + 1] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 1,l - 3] = Stacks[i+1].Course + " 302" + " Alt";
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k,Stacks[i+1].tempColumn] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 1,Stacks[i+1].tempColumn + 2] = Stacks[i+1].Course + " 302" + " Alt";
                                            m[k,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 1,Stacks[i+1].tempColumn + 3] = Stacks[i+1].Course + " 302" + " Alt";
                                        }
                                    }
                                    else
                                    {
                                        C = Stacks[i].Course;
                                        if ((l + 2) < 39 && l + 3 <= 39)
                                        {
                                            //PC
                                            m[k,l + 1] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 1,l + 4] = Stacks[i+1].Course + " 302" + " Alt";
                                            m[k,l + 2] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 1,l + 3] = Stacks[i+1].Course + " 302" + " Alt";
                                            //PC
                                            //swap
                                            m[k,l + 5] = C + " 301" + " Alt"; ;
                                            m[k + 1,l + 8] = C + " 302" + " Alt"; ;
                                            m[k,l + 6] = C + " 301" + " Alt"; ;
                                            m[k + 1,l + 7] = C + " 302" + " Alt"; ;
                                            //swap
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-" && m[k,l - 3] == "-")
                                        {
                                            m[k,l - 1] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 1,l - 2] = Stacks[i+1].Course + " 302" + " Alt";
                                            m[k,l + 1] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 1,l - 3] = Stacks[i+1].Course + " 302" + " Alt";
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k,Stacks[i+1].tempColumn] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 1,Stacks[i+1].tempColumn + 2] = Stacks[i+1].Course + " 302" + " Alt";
                                            m[k,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 1,Stacks[i+1].tempColumn + 3] = Stacks[i+1].Course + " 302" + " Alt";
                                        }
                                    }
                                }
                                //2nd semester
                                else if (Stacks[i+1].rowAddition == 2)
                                {
                                    /*m[k+2,l+1]=Stacks[i+1].Course+" 301"+" Alt";
                                    m[k+3,l+1]=Stacks[i+1].Course+" 302"+" Alt";
                                    m[k+2,l+1]=Stacks[i+1].Course+" 301"+" Alt";
                                    m[k+3,l+1]=Stacks[i+1].Course+" 302"+" Alt";*/
                                    if (Stacks[i].column1 != Stacks[i+1].column1)
                                    {
                                        if ((l + 2) < 39 && l + 3 <= 39)
                                        {
                                            m[k + 2,l + 1] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 3,l + 4] = Stacks[i+1].Course + " 302" + " Alt";
                                            m[k + 2,l + 2] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 3,l + 3] = Stacks[i+1].Course + " 302" + " Alt";
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-" && m[k,l - 3] == "-")
                                        {
                                            m[k + 2,l - 1] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 3,l - 2] = Stacks[i+1].Course + " 302" + " Alt";
                                            m[k + 2,l + 1] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 3,l - 3] = Stacks[i+1].Course + " 302" + " Alt";
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k + 2,Stacks[i+1].tempColumn] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 3,Stacks[i+1].tempColumn + 2] = Stacks[i+1].Course + " 302" + " Alt";
                                            m[k + 2,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 3,Stacks[i+1].tempColumn + 3] = Stacks[i+1].Course + " 302" + " Alt";
                                        }
                                    }

                                }
                                //3rd semester
                                else
                                {
                                    /*m[k+4,l+1]=Stacks[i+1].Course+" 301"+" Alt";
                                    m[k+5,l+1]=Stacks[i+1].Course+" 302"+" Alt";
                                    m[k+4,l+1]=Stacks[i+1].Course+" 301"+" Alt";
                                    m[k+5,l+2]=Stacks[i+1].Course+" 302"+" Alt";*/
                                    if (Stacks[i].column1 != Stacks[i+1].column1)
                                    {
                                        if ((l + 2) < 39 && l + 3 <= 39)
                                        {
                                            m[k + 4,l + 1] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 5,l + 4] = Stacks[i+1].Course + " 302" + " Alt";
                                            m[k + 4,l + 2] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 5,l + 3] = Stacks[i+1].Course + " 302" + " Alt";
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-" && m[k,l - 3] == "-")
                                        {
                                            m[k + 4,l - 1] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 5,l - 2] = Stacks[i+1].Course + " 302" + " Alt";
                                            m[k + 4,l + 1] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 5,l - 3] = Stacks[i+1].Course + " 302" + " Alt";
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k + 4,Stacks[i+1].tempColumn] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 5,Stacks[i+1].tempColumn + 2] = Stacks[i+1].Course + " 302" + " Alt";
                                            m[k + 4,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course + " 301" + " Alt";
                                            m[k + 5,Stacks[i+1].tempColumn + 3] = Stacks[i+1].Course + " 302" + " Alt";
                                        }
                                    }
                                }

                            }
                            //Double Time Slot Assign2

                        }
                        //Condition Working fine(1.1,1.2,1.3,2.1 first condition)
                        //Condition Working fine(Priority Overlapping)
                        //Condition Working fine(1.1,1.2,1.3,2.1 first condition)
                        //Condition Working fine(Priority Overlapping)
                        else if (Stacks[i+1].CourseCredit == 1.5)
                        {
                            //Double Time Slot1 Assign
                            //Preferred Time Slot 1
                            if (k == Stacks[i+1].row && l == Stacks[i+1].column1)
                            {
                                //1st semester
                                if (Stacks[i+1].rowAddition == 1)
                                {
                                    /*m[k,l+1]=Stacks[i+1].Course+" 301";
                                    m[k+1,l+1]=Stacks[i+1].Course+" 302";
                                    m[k,l+1]=Stacks[i+1].Course+" 301";
                                    m[k+1,l+2]=Stacks[i+1].Course+" 302";*/
                                    if (Stacks[i].column1 != Stacks[i+1].column1)
                                    {
                                        if ((l + 2) < 39 && l + 3 <= 39)
                                        {
                                            m[k,l + 1] = Stacks[i+1].Course + " 301";
                                            m[k,l + 2] = Stacks[i+1].Course + " 301";
                                            m[k + 1,l + 4] = Stacks[i+1].Course + " 302";
                                            m[k + 1,l + 3] = Stacks[i+1].Course + " 302";
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-" && m[k,l - 3] == "-")
                                        {
                                            m[k,l - 1] = Stacks[i+1].Course + " 301";
                                            m[k + 1,l - 2] = Stacks[i+1].Course + " 302";
                                            m[k,l + 1] = Stacks[i+1].Course + " 301";
                                            m[k + 1,l - 3] = Stacks[i+1].Course + " 302";
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k,Stacks[i+1].tempColumn] = Stacks[i+1].Course + " 301";
                                            m[k + 1,Stacks[i+1].tempColumn + 2] = Stacks[i+1].Course + " 302";
                                            m[k,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course + " 301";
                                            m[k + 1,Stacks[i+1].tempColumn + 3] = Stacks[i+1].Course + " 302";
                                        }
                                    }
                                    else
                                    {
                                        C = Stacks[i].Course;
                                        if ((l + 2) < 39 && l + 3 <= 39)
                                        {
                                            //PC
                                            m[k,l + 1] = Stacks[i+1].Course + " 301";
                                            m[k,l + 2] = Stacks[i+1].Course + " 301";
                                            m[k + 1,l + 4] = Stacks[i+1].Course + " 302";
                                            m[k + 1,l + 3] = Stacks[i+1].Course + " 302";
                                            //PC
                                            //Swap
                                            m[k,l + 5] = C + " 301";
                                            m[k,l + 6] = C + " 301";
                                            m[k + 1,l + 8] = C + " 302";
                                            m[k + 1,l + 7] = C + " 302";
                                            //Swap
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-" && m[k,l - 3] == "-")
                                        {
                                            m[k,l - 1] = Stacks[i+1].Course + " 301";
                                            m[k + 1,l - 2] = Stacks[i+1].Course + " 302";
                                            m[k,l + 1] = Stacks[i+1].Course + " 301";
                                            m[k + 1,l - 3] = Stacks[i+1].Course + " 302";
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k,Stacks[i+1].tempColumn] = Stacks[i+1].Course + " 301";
                                            m[k + 1,Stacks[i+1].tempColumn + 2] = Stacks[i+1].Course + " 302";
                                            m[k,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course + " 301";
                                            m[k + 1,Stacks[i+1].tempColumn + 3] = Stacks[i+1].Course + " 302";
                                        }
                                    }
                                }
                                //2nd semester
                                else if (Stacks[i+1].rowAddition == 2)
                                {
                                    /*m[k+2,l+1]=Stacks[i+1].Course+" 301";
                                    m[k+3,l+1]=Stacks[i+1].Course+" 302";
                                    m[k+2,l+1]=Stacks[i+1].Course+" 301";
                                    m[k+3,l+1]=Stacks[i+1].Course+" 302";*/
                                    if (Stacks[i].column1 != Stacks[i+1].column1)
                                    {
                                        if ((l + 2) < 39 && l + 3 <= 39)
                                        {
                                            m[k + 2,l + 1] = Stacks[i+1].Course + " 301";
                                            m[k + 3,l + 4] = Stacks[i+1].Course + " 302";
                                            m[k + 2,l + 2] = Stacks[i+1].Course + " 301";
                                            m[k + 3,l + 3] = Stacks[i+1].Course + " 302";
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-" && m[k,l - 3] == "-")
                                        {
                                            m[k + 2,l - 1] = Stacks[i+1].Course + " 301";
                                            m[k + 3,l - 2] = Stacks[i+1].Course + " 302";
                                            m[k + 2,l + 1] = Stacks[i+1].Course + " 301";
                                            m[k + 3,l - 3] = Stacks[i+1].Course + " 302";
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k + 2,Stacks[i+1].tempColumn] = Stacks[i+1].Course + " 301";
                                            m[k + 3,Stacks[i+1].tempColumn + 2] = Stacks[i+1].Course + " 302";
                                            m[k + 2,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course + " 301";
                                            m[k + 3,Stacks[i+1].tempColumn + 3] = Stacks[i+1].Course + " 302";
                                        }

                                    }
                                    else
                                    {
                                        C = Stacks[i].Course;
                                        if ((l + 2) < 39 && l + 3 <= 39)
                                        {
                                            //PC
                                            m[k + 2,l + 1] = Stacks[i+1].Course + " 301";
                                            m[k + 3,l + 4] = Stacks[i+1].Course + " 302";
                                            m[k + 2,l + 2] = Stacks[i+1].Course + " 301";
                                            m[k + 3,l + 3] = Stacks[i+1].Course + " 302";
                                            //PC
                                            m[k + 2,l + 5] = C + " 301";
                                            m[k + 3,l + 8] = C + " 302";
                                            m[k + 2,l + 6] = C + " 301";
                                            m[k + 3,l + 7] = C + " 302";
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-" && m[k,l - 3] == "-")
                                        {
                                            m[k + 2,l - 1] = Stacks[i+1].Course + " 301";
                                            m[k + 3,l - 2] = Stacks[i+1].Course + " 302";
                                            m[k + 2,l + 1] = Stacks[i+1].Course + " 301";
                                            m[k + 3,l - 3] = Stacks[i+1].Course + " 302";
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k + 2,Stacks[i+1].tempColumn] = Stacks[i+1].Course + " 301";
                                            m[k + 3,Stacks[i+1].tempColumn + 2] = Stacks[i+1].Course + " 302";
                                            m[k + 2,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course + " 301";
                                            m[k + 3,Stacks[i+1].tempColumn + 3] = Stacks[i+1].Course + " 302";
                                        }
                                    }
                                }
                                //3rd semester
                                else
                                {
                                    /*m[k+4,l+1]=Stacks[i+1].Course+" 301";
                                    m[k+5,l+1]=Stacks[i+1].Course+" 302";
                                    m[k+4,l+1]=Stacks[i+1].Course+" 301";
                                    m[k+5,l+2]=Stacks[i+1].Course+" 302";*/
                                    if ((l + 2) < 39 && l + 3 <= 39)
                                    {
                                        m[k + 4,l + 1] = Stacks[i+1].Course + " 301";
                                        m[k + 5,l + 3] = Stacks[i+1].Course + " 302";
                                        m[k + 4,l + 2] = Stacks[i+1].Course + " 301";
                                        m[k + 5,l + 4] = Stacks[i+1].Course + " 302";
                                    }
                                    else if (m[k,l - 1] == "-" && m[k,l - 2] == "-" && m[k,l - 3] == "-")
                                    {
                                        m[k + 4,l - 1] = Stacks[i+1].Course + " 301";
                                        m[k + 5,l - 2] = Stacks[i+1].Course + " 302";
                                        m[k + 4,l] = Stacks[i+1].Course + " 301";
                                        m[k + 5,l - 3] = Stacks[i+1].Course + " 302";
                                    }
                                    else
                                    {
                                        Stacks[i+1].tempColumn = 2;
                                        m[k + 4,Stacks[i+1].tempColumn] = Stacks[i+1].Course + " 301";
                                        m[k + 5,Stacks[i+1].tempColumn + 2] = Stacks[i+1].Course + " 302";
                                        m[k + 4,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course + " 301";
                                        m[k + 5,Stacks[i+1].tempColumn + 3] = Stacks[i+1].Course + " 302";
                                    }
                                }
                            }
                            //Double Time Slot1 Assign

                        }
                        //Condition Working fine(1.1,1.2,1.3,2.1 first condition)
                        //Condition Working fine(Priority Overlapping)
                        //Condition Working fine(1.1,1.2,1.3,2.1 first condition)
                        //Condition Working fine(Priority Overlapping)
                        else
                        {
                            //Single Time Slot Assign
                            //Preferred Time Slot 1
                            if (k == Stacks[i+1].row && l == Stacks[i+1].column1)
                            {
                                //1st semester
                                if (Stacks[i+1].rowAddition == 1)
                                {
                                    /*m[k,l+1]=Stacks[i+1].Course;
                                    m[k+1,l+1]=Stacks[i+1].Course;*/
                                    if (Stacks[i].column1 != Stacks[i+1].column1)
                                    {
                                        if ((l + 1) < 39 && l + 2 <= 39)
                                        {
                                            m[k,l + 1] = Stacks[i+1].Course;
                                            m[k + 1,l + 2] = Stacks[i+1].Course;
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-")
                                        {
                                            m[k,l - 1] = Stacks[i+1].Course;
                                            m[k + 1,l - 2] = Stacks[i+1].Course;
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k,Stacks[i+1].tempColumn] = Stacks[i+1].Course;
                                            m[k + 1,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course;
                                        }
                                    }
                                    else
                                    {
                                        C = Stacks[i].Course;
                                        if ((l + 1) < 39 && l + 2 <= 39)
                                        {
                                            m[k,l + 1] = Stacks[i+1].Course;
                                            m[k + 1,l + 2] = Stacks[i+1].Course;
                                            m[k,l + 2] = C;
                                            m[k + 1,l + 3] = C;
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-" && m[k,l - 3] == "-")
                                        {
                                            m[k,l - 1] = Stacks[i+1].Course;
                                            m[k + 1,l - 2] = Stacks[i+1].Course;
                                            m[k,l - 2] = C;
                                            m[k + 1,l - 3] = C;
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k,Stacks[i+1].tempColumn] = Stacks[i+1].Course;
                                            m[k + 1,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course;
                                            m[k,Stacks[i+1].tempColumn + 1] = C;
                                            m[k + 1,Stacks[i+1].tempColumn + 2] = C;
                                        }
                                    }
                                }
                                //2nd semester
                                else if (Stacks[i+1].rowAddition == 2)
                                {
                                    /*m[k+2,l+1]=Stacks[i+1].Course;
                                    m[k+3,l+1]=Stacks[i+1].Course;*/
                                    if (Stacks[i].column1 != Stacks[i+1].column1)
                                    {
                                        if ((l + 1) < 39 && l + 2 <= 39)
                                        {
                                            m[k + 2,l + 1] = Stacks[i+1].Course;
                                            m[k + 3,l + 2] = Stacks[i+1].Course;
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-")
                                        {
                                            m[k + 2,l - 1] = Stacks[i+1].Course;
                                            m[k + 3,l - 2] = Stacks[i+1].Course;
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k + 2,Stacks[i+1].tempColumn] = Stacks[i+1].Course;
                                            m[k + 3,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course;
                                        }
                                    }
                                    else
                                    {
                                        C = Stacks[i].Course;
                                        if ((l + 1) < 39 && l + 2 <= 39)
                                        {
                                            m[k + 2,l + 1] = Stacks[i+1].Course;
                                            m[k + 3,l + 2] = Stacks[i+1].Course;
                                            m[k + 2,l + 2] = C;
                                            m[k + 3,l + 3] = C;
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-")
                                        {
                                            m[k + 2,l - 1] = Stacks[i+1].Course;
                                            m[k + 3,l - 2] = Stacks[i+1].Course;
                                            m[k + 2,l - 2] = C;
                                            m[k + 3,l - 3] = C;
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k + 2,Stacks[i+1].tempColumn] = Stacks[i+1].Course;
                                            m[k + 3,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course;
                                            m[k + 2,Stacks[i+1].tempColumn + 1] = C;
                                            m[k + 3,Stacks[i+1].tempColumn + 2] = C;
                                        }
                                    }
                                }
                                //3rd semester
                                else
                                {
                                    /*m[k+4,l+1]=Stacks[i+1].Course;
                                    m[k+5,l+1]=Stacks[i+1].Course;*/
                                    if (Stacks[i].column1 != Stacks[i+1].column1)
                                    {
                                        if ((l + 2) < 39 && l + 3 <= 39)
                                        {
                                            m[k + 4,l + 1] = Stacks[i+1].Course;
                                            m[k + 5,l + 2] = Stacks[i+1].Course;
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-" && m[k,l - 3] == "-")
                                        {
                                            m[k + 4,l - 1] = Stacks[i+1].Course;
                                            m[k + 5,l - 2] = Stacks[i+1].Course;
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k + 4,Stacks[i+1].tempColumn] = Stacks[i+1].Course;
                                            m[k + 5,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course;
                                        }
                                    }
                                    else
                                    {
                                        C = Stacks[i].Course;
                                        if ((l + 2) < 39 && l + 3 <= 39)
                                        {
                                            m[k + 4,l + 1] = Stacks[i+1].Course;
                                            m[k + 5,l + 2] = Stacks[i+1].Course;
                                            m[k + 4,l + 2] = C;
                                            m[k + 5,l + 3] = C;
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-" && m[k,l - 3] == "-")
                                        {
                                            m[k + 4,l - 1] = Stacks[i+1].Course;
                                            m[k + 5,l - 2] = Stacks[i+1].Course;
                                            m[k + 4,l - 2] = C;
                                            m[k + 5,l - 3] = C;
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k + 4,Stacks[i+1].tempColumn] = Stacks[i+1].Course;
                                            m[k + 5,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course;
                                            m[k + 4,Stacks[i+1].tempColumn + 1] = C;
                                            m[k + 5,Stacks[i+1].tempColumn + 2] = C;
                                        }
                                    }
                                }
                            }
                            //Preferred Time Slot 2
                            else if (k == Stacks[i+1].row && l == Stacks[i+1].column2)
                            {
                                //1st semester
                                if (Stacks[i+1].rowAddition == 1)
                                {
                                    /*m[k,l+1]=Stacks[i+1].Course;
                                    m[k+1,l+1]=Stacks[i+1].Course;*/
                                    if (Stacks[i].column2 != Stacks[i+1].column2)
                                    {
                                        if ((l + 1) < 39 && l + 2 <= 39)
                                        {
                                            m[k,l + 1] = Stacks[i+1].Course;
                                            m[k + 1,l + 2] = Stacks[i+1].Course;
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-")
                                        {
                                            m[k,l - 1] = Stacks[i+1].Course;
                                            m[k + 1,l - 2] = Stacks[i+1].Course;
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k,Stacks[i+1].tempColumn] = Stacks[i+1].Course;
                                            m[k + 1,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course;
                                        }
                                    }
                                    else
                                    {
                                        C = Stacks[i].Course;
                                        if ((l + 1) < 39 && l + 2 <= 39)
                                        {
                                            m[k,l + 1] = Stacks[i+1].Course;
                                            m[k + 1,l + 2] = Stacks[i+1].Course;
                                            m[k,l + 2] = C;
                                            m[k + 1,l + 3] = C;
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-" && m[k,l - 3] == "-")
                                        {
                                            m[k,l - 1] = Stacks[i+1].Course;
                                            m[k + 1,l - 2] = Stacks[i+1].Course;
                                            m[k,l - 2] = C;
                                            m[k + 1,l - 3] = C;
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k,Stacks[i+1].tempColumn] = Stacks[i+1].Course;
                                            m[k + 1,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course;
                                            m[k,Stacks[i+1].tempColumn + 1] = C;
                                            m[k + 1,Stacks[i+1].tempColumn + 2] = C;
                                        }
                                    }
                                }
                                //2nd semester
                                else if (Stacks[i+1].rowAddition == 2)
                                {
                                    /*m[k+2,l+1]=Stacks[i+1].Course;
                                    m[k+3,l+1]=Stacks[i+1].Course;*/
                                    if (Stacks[i].column2 != Stacks[i+1].column2)
                                    {
                                        if ((l + 1) < 39 && l + 2 <= 39)
                                        {
                                            m[k + 2,l + 1] = Stacks[i+1].Course;
                                            m[k + 3,l + 2] = Stacks[i+1].Course;
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-")
                                        {
                                            m[k + 2,l - 1] = Stacks[i+1].Course;
                                            m[k + 3,l - 2] = Stacks[i+1].Course;
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k + 2,Stacks[i+1].tempColumn] = Stacks[i+1].Course;
                                            m[k + 3,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course;
                                        }
                                    }
                                    else
                                    {
                                        C = Stacks[i].Course;
                                        if ((l + 1) < 39 && l + 2 <= 39)
                                        {
                                            m[k + 2,l + 1] = Stacks[i+1].Course;
                                            m[k + 3,l + 2] = Stacks[i+1].Course;
                                            m[k + 2,l + 2] = C;
                                            m[k + 3,l + 3] = C;
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-")
                                        {
                                            m[k + 2,l - 1] = Stacks[i+1].Course;
                                            m[k + 3,l - 2] = Stacks[i+1].Course;
                                            m[k + 2,l - 2] = C;
                                            m[k + 3,l - 3] = C;
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k + 2,Stacks[i+1].tempColumn] = Stacks[i+1].Course;
                                            m[k + 3,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course;
                                            m[k + 2,Stacks[i+1].tempColumn + 1] = C;
                                            m[k + 3,Stacks[i+1].tempColumn + 2] = C;
                                        }
                                    }
                                }
                                //3rd semester
                                else
                                {
                                    /*m[k+4,l+1]=Stacks[i+1].Course;
                                    m[k+5,l+1]=Stacks[i+1].Course;*/
                                    if (Stacks[i].column2 != Stacks[i+1].column2)
                                    {
                                        if ((l + 2) < 39 && l + 3 <= 39)
                                        {
                                            m[k + 4,l + 1] = Stacks[i+1].Course;
                                            m[k + 5,l + 2] = Stacks[i+1].Course;
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-" && m[k,l - 3] == "-")
                                        {
                                            m[k + 4,l - 1] = Stacks[i+1].Course;
                                            m[k + 5,l - 2] = Stacks[i+1].Course;
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k + 4,Stacks[i+1].tempColumn] = Stacks[i+1].Course;
                                            m[k + 5,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course;
                                        }
                                    }
                                    else
                                    {
                                        C = Stacks[i].Course;
                                        if ((l + 2) < 39 && l + 3 <= 39)
                                        {
                                            m[k + 4,l + 1] = Stacks[i+1].Course;
                                            m[k + 5,l + 2] = Stacks[i+1].Course;
                                            m[k + 4,l + 2] = C;
                                            m[k + 5,l + 3] = C;
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-" && m[k,l - 3] == "-")
                                        {
                                            m[k + 4,l - 1] = Stacks[i+1].Course;
                                            m[k + 5,l - 2] = Stacks[i+1].Course;
                                            m[k + 4,l - 2] = C;
                                            m[k + 5,l - 3] = C;
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k + 4,Stacks[i+1].tempColumn] = Stacks[i+1].Course;
                                            m[k + 5,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course;
                                            m[k + 4,Stacks[i+1].tempColumn + 1] = C;
                                            m[k + 5,Stacks[i+1].tempColumn + 2] = C;
                                        }
                                    }
                                }

                            }
                            //Preferred Time Slot 3
                            else if (k == Stacks[i+1].row && l == Stacks[i+1].column3)
                            {
                                //1st semester
                                if (Stacks[i+1].rowAddition == 1)
                                {
                                    /*m[k,l+1]=Stacks[i+1].Course;
                                    m[k+1,l+1]=Stacks[i+1].Course;*/
                                    if (Stacks[i].column3 != Stacks[i+1].column3)
                                    {
                                        if ((l + 1) < 39 && l + 2 <= 39)
                                        {
                                            m[k,l + 1] = Stacks[i+1].Course;
                                            m[k + 1,l + 2] = Stacks[i+1].Course;
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-")
                                        {
                                            m[k,l - 1] = Stacks[i+1].Course;
                                            m[k + 1,l - 2] = Stacks[i+1].Course;
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k,Stacks[i+1].tempColumn] = Stacks[i+1].Course;
                                            m[k + 1,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course;
                                        }
                                    }
                                    else
                                    {
                                        C = Stacks[i].Course;
                                        if ((l + 1) < 39 && l + 2 <= 39)
                                        {
                                            m[k,l + 1] = Stacks[i+1].Course;
                                            m[k + 1,l + 2] = Stacks[i+1].Course;
                                            m[k,l + 2] = C;
                                            m[k + 1,l + 3] = C;
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-" && m[k,l - 3] == "-")
                                        {
                                            m[k,l - 1] = Stacks[i+1].Course;
                                            m[k + 1,l - 2] = Stacks[i+1].Course;
                                            m[k,l - 2] = C;
                                            m[k + 1,l - 3] = C;
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k,Stacks[i+1].tempColumn] = Stacks[i+1].Course;
                                            m[k + 1,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course;
                                            m[k,Stacks[i+1].tempColumn + 1] = C;
                                            m[k + 1,Stacks[i+1].tempColumn + 2] = C;
                                        }
                                    }
                                }
                                //2nd semester
                                else if (Stacks[i+1].rowAddition == 2)
                                {
                                    /*m[k+2,l+1]=Stacks[i+1].Course;
                                    m[k+3,l+1]=Stacks[i+1].Course;*/
                                    if (Stacks[i].column3 != Stacks[i+1].column3)
                                    {
                                        if ((l + 1) < 39 && l + 2 <= 39)
                                        {
                                            m[k + 2,l + 1] = Stacks[i+1].Course;
                                            m[k + 3,l + 2] = Stacks[i+1].Course;
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-")
                                        {
                                            m[k + 2,l - 1] = Stacks[i+1].Course;
                                            m[k + 3,l - 2] = Stacks[i+1].Course;
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k + 2,Stacks[i+1].tempColumn] = Stacks[i+1].Course;
                                            m[k + 3,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course;
                                        }
                                    }
                                    else
                                    {
                                        C = Stacks[i].Course;
                                        if ((l + 1) < 39 && l + 2 <= 39)
                                        {
                                            m[k + 2,l + 1] = Stacks[i+1].Course;
                                            m[k + 3,l + 2] = Stacks[i+1].Course;
                                            m[k + 2,l + 2] = C;
                                            m[k + 3,l + 3] = C;
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-")
                                        {
                                            m[k + 2,l - 1] = Stacks[i+1].Course;
                                            m[k + 3,l - 2] = Stacks[i+1].Course;
                                            m[k + 2,l - 2] = C;
                                            m[k + 3,l - 3] = C;
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k + 2,Stacks[i+1].tempColumn] = Stacks[i+1].Course;
                                            m[k + 3,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course;
                                            m[k + 2,Stacks[i+1].tempColumn + 1] = C;
                                            m[k + 3,Stacks[i+1].tempColumn + 2] = C;
                                        }
                                    }
                                }
                                //3rd semester
                                else
                                {
                                    /*m[k+4,l+1]=Stacks[i+1].Course;
                                    m[k+5,l+1]=Stacks[i+1].Course;*/
                                    if (Stacks[i].column3 != Stacks[i+1].column3)
                                    {
                                        if ((l + 2) < 39 && l + 3 <= 39)
                                        {
                                            m[k + 4,l + 1] = Stacks[i+1].Course;
                                            m[k + 5,l + 2] = Stacks[i+1].Course;
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-" && m[k,l - 3] == "-")
                                        {
                                            m[k + 4,l - 1] = Stacks[i+1].Course;
                                            m[k + 5,l - 2] = Stacks[i+1].Course;
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k + 4,Stacks[i+1].tempColumn] = Stacks[i+1].Course;
                                            m[k + 5,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course;
                                        }
                                    }
                                    else
                                    {
                                        C = Stacks[i].Course;
                                        if ((l + 2) < 39 && l + 3 <= 39)
                                        {
                                            m[k + 4,l + 1] = Stacks[i+1].Course;
                                            m[k + 5,l + 2] = Stacks[i+1].Course;
                                            m[k + 4,l + 2] = C;
                                            m[k + 5,l + 3] = C;
                                        }
                                        else if (m[k,l - 1] == "-" && m[k,l - 2] == "-" && m[k,l - 3] == "-")
                                        {
                                            m[k + 4,l - 1] = Stacks[i+1].Course;
                                            m[k + 5,l - 2] = Stacks[i+1].Course;
                                            m[k + 4,l - 2] = C;
                                            m[k + 5,l - 3] = C;
                                        }
                                        else
                                        {
                                            Stacks[i+1].tempColumn = 2;
                                            m[k + 4,Stacks[i+1].tempColumn] = Stacks[i+1].Course;
                                            m[k + 5,Stacks[i+1].tempColumn + 1] = Stacks[i+1].Course;
                                            m[k + 4,Stacks[i+1].tempColumn + 1] = C;
                                            m[k + 5,Stacks[i+1].tempColumn + 2] = C;
                                        }
                                    }
                                }

                            }
                            //Single Time Slot Assign
                        }
                        //Condition Working fine(1.1,1.2,1.3,2.1 first condition)
                        //Condition Working fine(Priority Overlapping)
                    }

                }
            }
            //main Routine GenerationCode
            //main code

        }
        
    }
}
