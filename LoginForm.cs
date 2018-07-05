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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        //SqlConnection conn = new SqlConnection(@"Data Source=MIRAZ-PC\SQLEXPRESS;Initial Catalog=ClassRoutine;Integrated Security=True");
        SqlConnection conn = new SqlConnection(global::NWUClassRoutine.Properties.Settings.Default.NWUClassRoutineConnectionString1);
        string temp, temp1;
        private void Btn_Signup_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nWUClassRoutineDataSet.LoginInfo' table. You can move, or remove it, as needed.
            

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                temp = textBox1.Text.ToString();
                temp1 = textBox2.Text.ToString();
                string query = "SELECT * FROM LoginInfo WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", temp);
                cmd.Parameters.AddWithValue("@Password", temp1);

                conn.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                ad.Fill(dt);
                if (dt.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Login Sucessful.Click OK to continue", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddCourseForm admin = new AddCourseForm();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username/Password! \n Please try again!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    //passWord.BackColor = Color.Pink;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
