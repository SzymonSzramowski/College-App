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

    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }
        public static class DataContainer
        {
            public static String usernameValue = "brak";
            public static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='" + Application.StartupPath + "\\projectDB.mdf'; Integrated Security=True");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            AdminView adminView = new AdminView();
            StudentView studentView = new StudentView();

            DataContainer.conn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select * From Login where Login='"+ loginTextbox.Text + "' and Password='" + passwordTextbox.Text + "'", DataContainer.conn);
            DataTable DT = new DataTable();
            sda.Fill(DT);

            void ResetInputs()
            {
                loginTextbox.Text = "";
                passwordTextbox.Text = "";
            }
            
            if (DT.Rows.Count == 1) {
                DataContainer.usernameValue = loginTextbox.Text;
                if (DT.Rows[0][3].Equals(true))
                {
                    ResetInputs();
                    this.Hide(); 
                    adminView.Show();
                }
                else
                {
                    ResetInputs();
                    this.Hide();
                    studentView.Show();
                }
            }
            else
            {
                MessageBox.Show("Authentication invalid. Please check your username and password");
            }
            DataContainer.conn.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }
    }
}
