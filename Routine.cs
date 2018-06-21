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
        int[] Roomno = new int[24] { 401, 402, 403, 404, 501, 502, 503, 504, 601, 602, 603, 604, 701, 702, 703, 704, 801, 802, 803, 804, 901, 902, 903, 904 };
        int j = 0;
        int i;
        int Column;
        
        int  row, k, rowAddition, temprow;
        string CourseCode = "CSE-1101", C, temp;
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
            //CheckArray();
            dataGridView1.Refresh();
            textBox1.Text = Convert.ToString(ColumnIDPulling());
        }

        private void Btn_ViewRoutine_Click(object sender, EventArgs e)
        {
            viewRoutine();
        }
        public void update()
        {
            fillTableWithNoSubject();
            // InsertSingleCourseIntoPosition();
            query = "DELETE FinalRoutine where [Term&Section&Department] != ' year'"; // Problem
            CheckArray();
            Sqlcmd = new SqlCommand(query, conn);
            conn.Open();
            Sqlcmd.ExecuteNonQuery();
            conn.Close();
            j = 1;
            for (int i = 1; i < 121; i++)
            {
                if (i >= 23 || i >= 47 || i >= 71 || i >= 95 || i >= 119 || i >= 121)
                {

                    query = "INSERT INTO FinalRoutine([Term&Section&Department],[8:00-9:15],[9:15-10:30],[10:45-12:00],[12:00-1:15],[2:00-3:15],[3:15-4:30],RowNumber,roomno) values( '" + year(i) + "','" + RoutineArray[i, 1] + "','" + RoutineArray[i, 2] + "','" + RoutineArray[i, 3] + "','" + RoutineArray[i, 4] + "','" + RoutineArray[i, 5] + "','" + RoutineArray[i, 6] + "','" + i + "','" + Roomno[j] + "')";
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
                    query = "INSERT INTO FinalRoutine([Term&Section&Department],[8:00-9:15],[9:15-10:30],[10:45-12:00],[12:00-1:15],[2:00-3:15],[3:15-4:30],RowNumber,roomno) values( '" + year(i) + "','" + RoutineArray[i, 1] + "','" + RoutineArray[i, 2] + "','" + RoutineArray[i, 3] + "','" + RoutineArray[i, 4] + "','" + RoutineArray[i, 5] + "','" + RoutineArray[i, 6] + "','" + i + "','" + Roomno[i] + "')";
                }
                Sqlcmd = new SqlCommand(query, conn);
                conn.Open();
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
                
            }
            //MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dataGridView1.Refresh();
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
        public int ColumnIDPulling()
        {
            
            try
            {

                string query, id, selection = "NM";
                conn = new SqlConnection(@"Data Source=MIRAZ-PC\SQLEXPRESS;Initial Catalog=ClassRoutine;Integrated Security=True");
                conn.Open();
                query = "select PreferredTimeSlot1 from RoutineInfo where TeacherInitials = 'MRI'";
                id = new SqlCommand(query, conn).ExecuteScalar().ToString();
                //textBox1.Text = id;
                conn.Close();
                if (id != null)
                {
                    //textBox1.Text = id;
                    conn.Open();
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
                        //.Text = "NF";
                    }
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message" + "ColumIDPulling", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            //if (conn != null) conn.Close();
            //textBox1.Text = Convert.ToString(Column);
            return Column;
        }
        //Waring Cofusing Code ahead. LOL.
        public void CheckArray()
        {
            try
            {
                double CourseCredit;
                string tempCourseCredit;
                // for (k = 1; k <= 8; k++)
                //scanf("%c", &Course[k]);
                temprow = int.Parse(CourseCode.Substring(5, 1));
                if (temprow == 1)
                    row = 1;
                else if (temprow == 2)
                    row = 7;
                else if (temprow == 3)
                    row = 13;
                else
                    row = 19;
                rowAddition = int.Parse(CourseCode.Substring(6, 1));
                //textBox1.Text = Convert.ToString(rowAddition);
                conn.Open();
                query = "Select CourseCredit from RoutineInfo where TeacherInitials = 'MRI'";
                Sqlcmd.ExecuteNonQuery();
                tempCourseCredit = new SqlCommand(query, conn).ExecuteScalar().ToString(); 
                CourseCredit = Double.Parse(tempCourseCredit);
                //textBox1.Text = tempCourseCredit;
                textBox1.Text = "working";
                //scanf("%d %c %f", &column, &C, &CourseCredit);
                if (CourseCredit == 1.5 || CourseCredit == 0.75)
                {
                    DoubleTimeSlotAssign();
                }
                else
                {
                    SingleTimeSlotAssign();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message" + "CheckArray", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }
        public void ArrayConditionForSemesterTheory()
         {
             j = ColumnIDPulling();
             try
             {
                 //1st semester
                 if (rowAddition == 1)
                 {
                     RoutineArray[i, j] = CourseCode;
                     RoutineArray[i + 1, j] = CourseCode;
                 }
                 //2nd semester
                 else if (rowAddition == 2)
                 {
                     RoutineArray[i + 2, j] = CourseCode;
                     RoutineArray[i + 3, j] = CourseCode;
                 }
                 //3rd semester
                 else
                 {
                     RoutineArray[i + 4, j] = CourseCode;
                     RoutineArray[i + 5, j] = CourseCode;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Message" + "ArrayConditionForSemesterTheory()", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }
        public void ArrayConditionForSemesterLab()
         {
             j = ColumnIDPulling();
             try
             {
                 //1st semester
                 if (rowAddition == 1)
                 {
                     RoutineArray[i, j] = CourseCode;
                     RoutineArray[i, j + 1] = CourseCode;
                     RoutineArray[i + 1, j] = CourseCode;
                     RoutineArray[i + 1, j + 1] = CourseCode;
                     Roomno[i - 1] = 301;
                     Roomno[i] = 302;
                 }
                 //2nd semester
                 else if (rowAddition == 2)
                 {
                     RoutineArray[i + 2, j] = CourseCode;
                     RoutineArray[i + 2, j + 1] = CourseCode;
                     RoutineArray[i + 3, j] = CourseCode;
                     RoutineArray[i + 3, j + 1] = CourseCode;
                     Roomno[i + 2 - 1] = 303;
                     Roomno[i + 3 - 1] = 304;
                 }
                 //3rd semester
                 else
                 {
                     RoutineArray[i + 4, j] = CourseCode;
                     RoutineArray[i + 4, j + 1] = CourseCode;
                     RoutineArray[i + 5, j] = CourseCode;
                     RoutineArray[i + 5, j + 1] = CourseCode;
                     Roomno[i + 4 - 1] = 301;
                     Roomno[i + 5 - 1] = 302;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Message" + "ArrayConditionForSemesterLab()", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             
         }
        public void SingleTimeSlotAssign()
         {
             try
             {
                 //ColumnIDPulling();
                 for (i = 1; i <= 121; i++)
                 {
                     for (j = 1; j <= 6; j++)
                     {
                         //Monday
                         if (i == row && j == Column && RoutineArray[i, j] == "-")
                         {
                             ArrayConditionForSemesterTheory();
                         }
                         //Tuesday
                         else if (i == row + 24 && j == Column && RoutineArray[i, j] == "-")
                         {
                             ArrayConditionForSemesterTheory();
                         }
                         //Wednesday
                         else if (i == row + 72 && j == Column && RoutineArray[i, j] == "-")
                         {
                             ArrayConditionForSemesterTheory();
                         }
                         //Thursday
                         else if (i == row + 96 && j == Column && RoutineArray[i, j] == "-")
                         {
                             ArrayConditionForSemesterTheory();
                         }
                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Message" + "SingleTimeSlotAssign()", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             
         }
        public void DoubleTimeSlotAssign()
         {
             //ColumnIDPulling(); 
             try
             {
                 for (i = 1; i <= 121; i++)
                 {
                     for (j = 1; j <= 6; j++)
                     {
                         //Monday
                         if (i == row && j == Column && RoutineArray[i, j] == "-")
                         {
                             ArrayConditionForSemesterLab();
                         }
                         //Tuesday
                         else if (i == row + 24 && j == Column && RoutineArray[i, j] == "-")
                         {
                             ArrayConditionForSemesterLab();
                         }
                         //Wednesday
                         else if (i == row + 72 && j == Column && RoutineArray[i, j] == "-")
                         {
                             ArrayConditionForSemesterLab();
                         }
                         //Thursday
                         else if (i == row + 96 && j == Column && RoutineArray[i, j] == "-")
                         {
                             ArrayConditionForSemesterLab();
                         }
                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             
         }
        public void Clean()
        {
            query = "DELETE FinalRoutine "; // Problem
            Sqlcmd = new SqlCommand(query, conn);
            conn.Open();
            Sqlcmd.ExecuteNonQuery();
            conn.Close();
        }
        private void Btn_Generate_Click(object sender, EventArgs e)
        {
            try
            {
                Clean();
                j = 0;
                update();
                viewRoutine();
                MessageBox.Show("Update Successful");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message" + "Generate_Button" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        /* public void CProgram()
         {
         int i, j;
         float CourseCredit;
         int column, row, k, rowAddition, temprow;
         string CourseCode, C, temp;

        /* FillTDArrayWithNoSubject()
         {
             for (i = 1; i <= 121; i++)
             {
                 for (j = 1; j <= 6; j++)
                 {
                     RoutineArray[i,j] = "-";
                 }
             }
         }
         public void CheckArray()
         {

            // for (k = 1; k <= 8; k++)
                 //scanf("%c", &Course[k]);
             temprow = int.Parse(CourseCode.Substring(5,1));
             if (temprow == 1)
                 row = 1;
             else if (temprow == 2)
                 row = 7;
             else if (temprow == 3)
                 row = 13;
             else
                 row = 19;
             rowAddition = int.Parse(CourseCode.Substring(6, 1));
                 //scanf("%d %c %f", &column, &C, &CourseCredit);
             if (CourseCredit == 1.5 || CourseCredit == 0.75)
             {
                 DoubleTimeSlotAssign();
             }
             else
             {
                 SingleTimeSlotAssign();
             }

         }
         ArrayConditionForSemesterTheory()
         {
             //1st semester
             if (rowAddition == 1)
             {
                 RoutineArray[i,j] = CourseCode;
                 RoutineArray[i + 1][j] = CourseCode;
             }
             //2nd semester
             else if (rowAddition == 2)
             {
                 RoutineArray[i + 2][j] = CourseCode;
                 RoutineArray[i + 3][j] = CourseCode;
             }
             //3rd semester
             else
             {
                 RoutineArray[i + 4][j] = CourseCode;
                 RoutineArray[i + 5][j] = CourseCode;
             }
         }
         ArrayCourseCodeonditionForSemesterLab()
         {
             //1st semester
             if (rowAddition == 1)
             {
                 RoutineArray[i,j] = CourseCode;
                 RoutineArray[i][j + 1] = CourseCode;
                 RoutineArray[i + 1][j] = CourseCode;
                 RoutineArray[i + 1][j + 1] = CourseCode;
                 Roomno[i - 1] = 301;
                 Roomno[i] = 302;
             }
             //2nd semester
             else if (rowAddition == 2)
             {
                 RoutineArray[i + 2][j] = CourseCode;
                 RoutineArray[i + 2][j + 1] = CourseCode;
                 RoutineArray[i + 3][j] = CourseCode;
                 RoutineArray[i + 3][j + 1] = CourseCode;
                 Roomno[i + 2 - 1] = 303;
                 Roomno[i + 3 - 1] = 304;
             }
             //3rd semester
             else
             {
                 RoutineArray[i + 4][j] = CourseCode;
                 RoutineArray[i + 4][j + 1] = CourseCode;
                 RoutineArray[i + 5][j] = CourseCode;
                 RoutineArray[i + 5][j + 1] = CourseCode;
                 Roomno[i + 4 - 1] = 301;
                 Roomno[i + 5 - 1] = 302;
             }
         }
         SingleTimeSlotAssign()
         {
             for (i = 1; i <= 121; i++)
             {
                 for (j = 1; j <= 6; j++)
                 {
                     //Monday
                     if (i == row && j == column && RoutineArray[i,j] == "-")
                     {
                         ArrayConditionForSemesterTheory();
                     }
                     //Tuesday
                     else if (i == row + 24 && j == column && RoutineArray[i,j] == "-")
                     {
                         ArrayConditionForSemesterTheory();
                     }
                     //Wednesday
                     else if (i == row + 72 && j == column && RoutineArray[i,j] == "-")
                     {
                         ArrayConditionForSemesterTheory();
                     }
                     //Thursday
                     else if (i == row + 96 && j == column && RoutineArray[i,j] == "-")
                     {
                         ArrayConditionForSemesterTheory();
                     }
                 }
             }
         }
         DoubleTimeSlotAssign()
         {
             for (i = 1; i <= 121; i++)
             {
                 for (j = 1; j <= 6; j++)
                 {
                     //Monday
                     if (i == row && j == column && RoutineArray[i,j] == "-")
                     {
                         ArrayConditionForSemesterLab();
                     }
                     //Tuesday
                     else if (i == row + 24 && j == column && RoutineArray[i,j] == "-")
                     {
                         ArrayConditionForSemesterLab();
                     }
                     //Wednesday
                     else if (i == row + 72 && j == column && RoutineArray[i,j] == "-")
                     {
                         ArrayConditionForSemesterLab();
                     }
                     //Thursday
                     else if (i == row + 96 && j == column && RoutineArray[i,j] == "-")
                     {
                         ArrayConditionForSemesterLab();
                     }
                 }
             }
         }
         /*ShowArray()
         {
             printf("\n");
             for (i = 1; i < 121; i++)
             {
                 printf("[%d]", i);
                 for (j = 1; j <= 6; j++)
                 {
                     printf(" %c ", RoutineArray[i,j]);
                 }
                 printf("%d", Roomno[i - 1]);
                 printf("\n");
             }
         }
         InsertSingleCourseIntoPosition()
         {
             //FillTDArrayWithNoSubject();
             CheckArray();
             //ShowArray();
         }
        

     }*/
    }
}
