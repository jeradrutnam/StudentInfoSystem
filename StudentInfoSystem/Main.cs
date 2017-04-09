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
using System.IO;

namespace StudentInfoSystem
{
    public partial class frmMain : Form
    {
        #region Database Connection

        public SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Jerad\Documents\Visual Studio 2015\Projects\StudentInfoSystem\StudentInfoSystem\PrimaryDB.mdf';Integrated Security=True;");

        #endregion

        #region Form Onload

        string imageLocation = "";

        /// <summary>
        /// Get logged in user display name from database
        /// and update the display name lable
        /// </summary>
        /// 
        private void updateUserName(string username)
        {
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM [dbo].[tblUsers] WHERE [USERNAME]='user'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlAdapter.Fill(dataTable);

            string displayName = dataTable.Rows[0]["DISPLAY_NAME"].ToString();

            if (displayName != "")
            {
                lblLoginName.Text = displayName;
                txtSettingsName.Text = displayName;
            }
            else
            {
                lblLoginName.Text = username;
            }
        }

        /// <summary>
        /// Get logged in user user image from database
        /// and update the profile image
        /// </summary>
        /// 
        private void updateUserImage()
        {
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM [dbo].[tblUsers] WHERE [USERNAME]='user'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlAdapter.Fill(dataTable);

            byte[] image = (byte[])(dataTable.Rows[0]["USER_IMAGE"]);

            if(image != null)
            {
                MemoryStream memoryStream = new MemoryStream(image);
                picBoxUserImage.Image = Image.FromStream(memoryStream);
            }
            
        }

        /// <summary>
        /// Fill list view with students details
        /// </summary>
        /// 
        public frmMain(string username)
        {
            InitializeComponent();

            tabCtrlContent.Appearance = TabAppearance.FlatButtons;
            tabCtrlContent.ItemSize = new Size(0, 1);
            tabCtrlContent.SizeMode = TabSizeMode.Fixed;

            updateUserName(username);

            SqlCommand sqlQuery = new SqlCommand("SELECT * FROM tblStudents", sqlConnection);
            populate(sqlQuery);

            updateUserImage();
        }

        /// <summary>
        /// Stop application process on form exit
        /// </summary>
        /// 
        private void frmMain_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Logout application on logout button click
        /// </summary>
        /// 
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        #endregion

        #region Populate Students Details

        /// <summary>
        /// Read students details from the database and attach them 
        /// to the listview by the requested sql query
        /// </summary>
        /// 
        private void populate(SqlCommand sqlQuery)
        {
            try
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlQuery);
                DataTable dataTable = new DataTable();

                sqlAdapter.Fill(dataTable);

                listView.Items.Clear();

                foreach (DataRow dataReader in dataTable.Rows)
                {
                    string dateOfBirth = Convert.ToDateTime(dataReader["DOB"]).ToShortDateString();
                    string admissionDate = Convert.ToDateTime(dataReader["ADMISSION_DATE"]).ToShortDateString();

                    ListViewItem item = new ListViewItem(dataReader["ID"].ToString());
                    item.SubItems.Add(dataReader["FIRST_NAME"].ToString() + " " + dataReader["LAST_NAME"].ToString());
                    item.SubItems.Add(dataReader["ADDRESS"].ToString());
                    item.SubItems.Add(dateOfBirth);
                    item.SubItems.Add(dataReader["TELEPHONE"].ToString());
                    item.SubItems.Add(admissionDate);

                    listView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Overview

        private void btnOverview_Click(object sender, EventArgs e)
        {
            tabCtrlContent.SelectTab(tabOverview);
        }

        #endregion

        #region Students

        /// <summary>
        /// Show students details listview on button "Students" click
        /// </summary>
        /// 
        private void btnStudents_Click(object sender, EventArgs e)
        {
            tabCtrlContent.SelectTab(tabStudents);
        }

        #endregion

        #region Settings

        /// <summary>
        /// Show settings form on button "Settings" click
        /// </summary>
        /// 
        private void btnSettings_Click(object sender, EventArgs e)
        {
            tabCtrlContent.SelectTab(tabSettings);
        }

        /// <summary>
        /// Fill display name and show seetings form on button "Settings" click
        /// </summary>
        ///
        private void btnSettingsBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG (*.jpg)|*.jpg|GIF (*.gif)|*.gif|PNG (*.png)|*.png|All Files (*.*)|*.*";
            openFileDialog.Title = "Select an Image";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = openFileDialog.FileName.ToString();
                picBoxSettingsUserImage.ImageLocation = imageLocation;
            }
        }

        /// <summary>
        /// Update selected image & display name on the database on "Save" button click
        /// </summary>
        /// 
        private void btnSettingsSave_Click(object sender, EventArgs e)
        {
            byte[] image = null;
            FileStream fileStream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            image = binaryReader.ReadBytes((int)fileStream.Length);

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE [dbo].[tblUsers] SET " +
                    "[DISPLAY_NAME]='" + txtSettingsName.Text + "', [USER_IMAGE]=@image WHERE [USERNAME]='user'", sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@image", image));
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            updateUserImage();
            lblLoginName.Text = txtSettingsName.Text;

            MessageBox.Show("Saved!");
        }

        #endregion

        #region Search/Filter Students Details

        /// <summary>
        /// Filter student details list based on given user input
        /// </summary>
        /// 
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlCommand sqlQuery;
            if (txtSearch.Text == "")
            {
                sqlQuery = new SqlCommand("SELECT * FROM tblStudents", sqlConnection);
            }
            else
            {
                sqlQuery = new SqlCommand("SELECT * FROM tblStudents WHERE " +
                    "[FIRST_NAME] LIKE '" + txtSearch.Text + "%' OR " +
                    "[LAST_NAME] LIKE '" + txtSearch.Text + "%'", sqlConnection);
            }

            populate(sqlQuery);
        }

        #endregion
    }
}
