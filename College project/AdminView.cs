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

namespace College_project
{
    public partial class AdminView : Form
    {
        LoginView loginView = new LoginView();
        
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='" + Application.StartupPath + "\\projectDB.mdf'; Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        string username;

        public AdminView()
        {
            InitializeComponent();
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
           
            username = LoginView.DataContainer.usernameValue;
            usernameLabel.Text = username;
            cmd.Connection = conn;
            loadMessageList();
        }

        private void postMessageButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(postMessageTextbox.Text) && postMessageTextbox.Text.Length >= 0)
            {
                MessageBox.Show("Message is empty");
            }
            else
            {
                conn.Open();
                cmd.CommandText = "insert into MessageList (message, username) values ('" + postMessageTextbox.Text + "', '" + username + "')";
                cmd.ExecuteNonQuery();
                cmd.Clone();
                conn.Close();
                
                postMessageTextbox.Text = "";

                loadMessageList();

            }

        }
        private void loadMessageList()
        {
            messageListBox.Items.Clear();
            conn.Open();
            cmd.CommandText = "select * from MessageList";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    messageListBox.Items.Insert(0, dr[1].ToString());
                }
            }
            conn.Close();
        }
        private void loadGradeList()
        {
            cmd.CommandText = "select Username, Grade, Subject, Description, AddedBy, Date from Grades where Username ='" + selectStudentTextbox.Text + "'";
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridViewStudentGrades.DataSource = dt;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginView.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void selectStudentButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            loadGradeList();
            conn.Close();
        }

        private void addGradeButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select * from Login where Login ='" + addGradeStudentTextbox.Text + "' and isAdmin = 0", conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if(string.IsNullOrWhiteSpace(addGradeStudentTextbox.Text) && addGradeStudentTextbox.Text.Length >= 0 &&
                string.IsNullOrWhiteSpace(addGradeSubjectTextbox.Text) && addGradeSubjectTextbox.Text.Length >= 0 &&
                string.IsNullOrWhiteSpace(addGradeMarkTextbox.Text) && addGradeMarkTextbox.Text.Length >= 0)
            {
                MessageBox.Show("Please fill in the required fields");
            }
            else
            {
                if (dt.Rows.Count == 1)
                {
                    cmd.CommandText = "insert into Grades (Username, Grade, Subject, Description, AddedBy, Date) values ('" + addGradeStudentTextbox.Text + "', '" + addGradeMarkTextbox.Text + "', '" + addGradeSubjectTextbox.Text + "', '" + addGradeDescriptionTextbox.Text + "', '" + username + "', '" + DateTime.Today.ToString("dd-MM-yyyy") + "')";
                    cmd.ExecuteNonQuery();
                    loadGradeList();
                    resetAddGradeInputs();
                    MessageBox.Show("Grade added");
                }
                else
                {
                    MessageBox.Show("Student not found");
                }
            }

            conn.Close();
        }
        private void resetAddGradeInputs()
        {
            addGradeStudentTextbox.Text = "";
            addGradeMarkTextbox.Text = "";
            addGradeSubjectTextbox.Text = "";
            addGradeDescriptionTextbox.Text = "";
        }
    }
}
