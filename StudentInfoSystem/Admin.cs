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
    public partial class frmAdmin : Form
    {
        #region Database Connection

        public SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Jerad\Documents\Visual Studio 2015\Projects\StudentInfoSystem\StudentInfoSystem\PrimaryDB.mdf';Integrated Security=True;");

        #endregion

        #region Form Onload

        /// <summary>
        /// Get logged in user display name from database
        /// and update the display name lable
        /// </summary>
        /// 
        private void updateUserName()
        {
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM [dbo].[tblUsers] WHERE [USERNAME]='admin'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlAdapter.Fill(dataTable);

            string displayName = dataTable.Rows[0]["DISPLAY_NAME"].ToString();

            if (displayName != null)
            {
                lblLoginName.Text = "Login as " + displayName;
            }
            else
            {
                lblLoginName.Text = "Login as admin";
            }

        }

        /// <summary>
        /// Fill list view with students details
        /// </summary>
        /// 
        public frmAdmin()
        {
            InitializeComponent();

            tabCtrlContent.Appearance = TabAppearance.FlatButtons;
            tabCtrlContent.ItemSize = new Size(0, 1);
            tabCtrlContent.SizeMode = TabSizeMode.Fixed;

            updateUserName();

            SqlCommand sqlQuery = new SqlCommand("SELECT * FROM tblStudents", sqlConnection);
            populate(sqlQuery);
        }

        /// <summary>
        /// Stop application process on form exit
        /// </summary>
        /// 
        private void frmAdmin_Closed(object sender, FormClosedEventArgs e)
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

        #region Search/Filter Student Details

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

        #region Add New Student

        /// <summary>
        /// Show add new student details form on button "New" click
        /// </summary>
        /// 
        private void btnNew_Click(object sender, EventArgs e)
        {
            tabCtrlContent.SelectTab(tabAddStudent);
        }

        /// <summary>
        /// Reset fields on add new student details form
        /// </summary>
        /// 
        private void resetAddStudentFeilds()
        {
            txtAddFirstName.Text = "";
            txtAddLastName.Text = "";
            txtAddAddress.Text = "";
            datePickerAddDOB.Value = DateTime.Now;
            txtAddContact.Text = "";
            datePickerAddAdmissionDate.Value = DateTime.Now;
        }

        /// <summary>
        /// Insert filled user inputs to the database on "Add" button click
        /// </summary>
        /// 
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddFirstName.Text.Trim()))
            {
                MessageBox.Show("Please fill the First Name to continue");
            }
            else if (String.IsNullOrEmpty(txtAddAddress.Text.Trim()))
            {
                MessageBox.Show("Please fill the Address to continue");
            }
            else
            {
                sqlConnection.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("INSERT INTO [dbo].[tblStudents] " +
                    "([FIRST_NAME], [LAST_NAME], [DOB], [ADDRESS], [TELEPHONE], [ADMISSION_DATE]) VALUES ('" +
                        txtAddFirstName.Text + "', '" +
                        txtAddLastName.Text + "', '" +
                        datePickerAddDOB.Value + "', '" +
                        txtAddAddress.Text + "', '" +
                        txtAddContact.Text + "', '" +
                        datePickerAddAdmissionDate.Value + "')", sqlConnection);
                sqlAdapter.SelectCommand.ExecuteNonQuery();

                sqlAdapter.SelectCommand.CommandText = "SELECT @@Identity";
                string addedRecordID = sqlAdapter.SelectCommand.ExecuteScalar().ToString();

                sqlConnection.Close();

                string dateOfBirth = Convert.ToDateTime(datePickerAddDOB.Value).ToShortDateString();
                string admissionDate = Convert.ToDateTime(datePickerAddAdmissionDate.Value).ToShortDateString();

                ListViewItem item = new ListViewItem(addedRecordID);
                item.SubItems.Add(txtAddFirstName.Text + " " + txtAddLastName.Text);
                item.SubItems.Add(txtAddAddress.Text);
                item.SubItems.Add(dateOfBirth);
                item.SubItems.Add(txtAddContact.Text);
                item.SubItems.Add(admissionDate);

                listView.Items.Add(item);

                resetAddStudentFeilds();

                tabCtrlContent.SelectTab(tabOverview);

                MessageBox.Show("Added Student Details!");
            }
        }

        /// <summary>
        /// Reset form add new student details form and go back to 
        /// listview on "Cancel" button click
        /// </summary>
        /// 
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            tabCtrlContent.SelectTab(tabOverview);
            resetAddStudentFeilds();
        }

        #endregion

        #region Edit/Update Student Details

        /// <summary>
        /// Fill and Show edit student details form on button "Edit" click
        /// </summary>
        /// 
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                string id = listView.SelectedItems[0].SubItems[0].Text;

                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM [dbo].[tblStudents] WHERE [ID]=" + id, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);

                lblEditIDValue.Text = id;
                txtEditFirstName.Text = dataTable.Rows[0]["FIRST_NAME"].ToString();
                txtEditLastName.Text = dataTable.Rows[0]["LAST_NAME"].ToString();
                txtEditAddress.Text = dataTable.Rows[0]["ADDRESS"].ToString();
                datePickerEditDOB.Value = Convert.ToDateTime(dataTable.Rows[0]["DOB"]);
                txtEditContact.Text = dataTable.Rows[0]["TELEPHONE"].ToString();
                datePickerEditAdmissionDate.Value = Convert.ToDateTime(dataTable.Rows[0]["ADMISSION_DATE"]);

                tabCtrlContent.SelectTab(tabEditStudent);
            }
            else
            {
                MessageBox.Show("Please select a student to update");
            }

        }

        /// <summary>
        /// Reset fields on edit student details form
        /// </summary>
        /// 
        private void resetEditStudentFeilds()
        {
            txtEditFirstName.Text = "";
            txtEditLastName.Text = "";
            txtEditAddress.Text = "";
            datePickerEditDOB.Value = DateTime.Now;
            txtEditContact.Text = "";
            datePickerEditAdmissionDate.Value = DateTime.Now;
        }

        /// <summary>
        /// Update filled user inputs on the database on "Update" button click
        /// </summary>
        /// 
        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEditFirstName.Text.Trim()))
            {
                MessageBox.Show("First Name cannot be empty");
            }
            else if (String.IsNullOrEmpty(txtEditAddress.Text.Trim()))
            {
                MessageBox.Show("Address cannot be empty");
            }
            else
            {
                sqlConnection.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("UPDATE [dbo].[tblStudents] SET " +
                    "[FIRST_NAME]='" + txtEditFirstName.Text + "'," +
                    "[LAST_NAME]='" + txtEditLastName.Text + "'," +
                    "[DOB]='" + datePickerEditDOB.Value + "'," +
                    "[ADDRESS]='" + txtEditAddress.Text + "'," +
                    "[TELEPHONE]='" + txtEditContact.Text + "'," +
                    "[ADMISSION_DATE]='" + datePickerEditAdmissionDate.Value + "' " +
                    "WHERE [ID]=" + lblEditIDValue.Text, sqlConnection);
                sqlAdapter.SelectCommand.ExecuteNonQuery();
                sqlConnection.Close();

                string dateOfBirth = Convert.ToDateTime(datePickerEditDOB.Value).ToShortDateString();
                string admissionDate = Convert.ToDateTime(datePickerEditAdmissionDate.Value).ToShortDateString();

                listView.SelectedItems[0].SubItems[1].Text = txtEditFirstName.Text + " " + txtEditLastName.Text;
                listView.SelectedItems[0].SubItems[2].Text = txtEditAddress.Text;
                listView.SelectedItems[0].SubItems[3].Text = dateOfBirth;
                listView.SelectedItems[0].SubItems[4].Text = txtEditContact.Text;
                listView.SelectedItems[0].SubItems[5].Text = admissionDate;

                resetEditStudentFeilds();

                tabCtrlContent.SelectTab(tabOverview);

                MessageBox.Show("Student Details Updated!");
            }
        }

        /// <summary>
        /// Reset form edit student details form and go back to 
        /// listview on "Cancel" button click
        /// </summary>
        /// 
        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            tabCtrlContent.SelectTab(tabOverview);
            resetEditStudentFeilds();
        }

        #endregion

        #region Delete Student Details

        /// <summary>
        /// Delete selected student details on "Delete" button click
        /// </summary>
        /// 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this detail?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string id = listView.SelectedItems[0].SubItems[0].Text;

                    sqlConnection.Open();
                    SqlDataAdapter sqlAdapter = new SqlDataAdapter("DELETE FROM [dbo].[tblStudents] WHERE [ID]=" + id, sqlConnection);
                    sqlAdapter.SelectCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    listView.SelectedItems[0].Remove();

                    MessageBox.Show("Student Detail Deleted!");
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete");
            }
        }

        #endregion
    }
}
