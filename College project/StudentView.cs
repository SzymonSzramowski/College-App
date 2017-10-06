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
    public partial class StudentView : Form
    {
        LoginView loginView = new LoginView();

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='" + Application.StartupPath + "\\projectDB.mdf'; Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        string username;

        public StudentView()
        {
            InitializeComponent();
        }

        private void StudentView_Load(object sender, EventArgs e)
        {
            username = LoginView.DataContainer.usernameValue;
            usernameLabel.Text = username;
            cmd.Connection = conn;

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

            conn.Open();
            cmd.CommandText = "select Subject, Grade, Description, AddedBy, Date from Grades where Username ='" + username + "'";
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridViewStudentGrades.DataSource = dt;
            conn.Close();
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
    }
}
