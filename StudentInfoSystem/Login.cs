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

namespace StudentInfoSystem
{
    public partial class frmLogin : Form
    {
        #region Form Onload

        /// <summary>
        /// Initialize View
        /// </summary>
        /// 
        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Stop application process on form exit
        /// </summary>
        /// 
        private void frmLogin_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Login

        /// <summary>
        /// Login to application based on the user input credentials
        /// </summary>
        /// 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Jerad\Documents\Visual Studio 2015\Projects\StudentInfoSystem\StudentInfoSystem\PrimaryDB.mdf';Integrated Security=True;");
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT Count(*) FROM tblUsers WHERE Username='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'", sqlConnection);
            DataTable dataTable = new DataTable();

            sqlAdapter.Fill(dataTable);

            if(dataTable.Rows[0][0].ToString() == "1")
            {
                this.Hide();

                if (txtUsername.Text.ToLower() == "admin") {
                    frmAdmin adminMain = new frmAdmin();
                    adminMain.Show();
                }
                else
                {
                    frmMain userMain = new frmMain(txtUsername.Text);
                    userMain.Show();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Username & Password.");
            }
        }

        /// <summary>
        /// Perform login action on enter keypress while on Username textbox
        /// </summary>
        /// 
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnLogin.PerformClick();
            }
        }

        /// <summary>
        /// Perform login action on enter keypress while on Password textbox
        /// </summary>
        /// 
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnLogin.PerformClick();
            }
        }

        #endregion
    }
}
