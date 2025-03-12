using Book_Haven__Application.Business.Interfaces;
using Book_Haven__Application.Business.Services;
using Book_Haven__Application.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Haven_System_Ad.Forms
{
    public partial class frmUser : Form
    {
        private readonly IUserService _userService;
        List<UserModel> users;
        public frmUser()
        {
            InitializeComponent();
            _userService = new UserService();
            LoadUsers();
        }
        private bool ValidateFields()
        {
            bool isValid = true;

            // Validate Username
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                txtUserName.BackColor = System.Drawing.Color.Red;
                isValid = false;
            }
            else
            {
                txtUserName.BackColor = System.Drawing.Color.White;
            }

            // Validate Password
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                txtPassword.BackColor = System.Drawing.Color.Red;
                isValid = false;
            }
            else
            {
                txtPassword.BackColor = System.Drawing.Color.White;
            }

            // Validate Role
            if (cmbUserRoles.SelectedItem == null)
            {
                cmbUserRoles.BackColor = System.Drawing.Color.Red;
                isValid = false;
            }
            else
            {
                cmbUserRoles.BackColor = System.Drawing.Color.White;
            }

            return isValid;
        }
        private void LoadUsers()
        {
            try
            {
                users = _userService.GetAllUsers();

                // Bind the user list to the DataGridView
                tblUsers.DataSource = null;  // Reset DataSource
                tblUsers.DataSource = users;

                // Ensure columns exist before modifying
                if (tblUsers.Columns.Count > 0)
                {
                    tblUsers.Columns["UserID"].HeaderText = "User ID";
                    tblUsers.Columns["Username"].HeaderText = "Username";
                    tblUsers.Columns["Role"].HeaderText = "Role";

                    // Hide unwanted columns
                    foreach (DataGridViewColumn column in tblUsers.Columns)
                    {
                        if (column.Name != "UserID" && column.Name != "Username" && column.Name != "Role")
                        {
                            column.Visible = false;
                        }
                    }

                    // Auto-size columns to fit within the DataGridView width
                    tblUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    tblUsers.Columns["UserID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    tblUsers.Columns["Username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    tblUsers.Columns["Role"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}");
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                string username = txtUserName.Text;
                string password = txtPassword.Text;
                string role = cmbUserRoles.SelectedItem.ToString();

                _userService.RegisterUser(username, password, role);
                MessageBox.Show("User registered successfully!");
                Clearields();
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Logic for logging out (e.g., clear session, close form)

                // For example: Show the login form
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                this.Hide();


            }
        }
        private void Clearields()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            cmbUserRoles.Items.Clear();
        }












        private void tblUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = tblUsers.Rows[e.RowIndex];
                txtUserName.Text = selectedRow.Cells["Username"].Value.ToString();
                cmbUserRoles.Text = selectedRow.Cells["Role"].Value.ToString();
                txtPassword.Text = ""; // Keep password empty for security
            }
        }

        private void txtSerach_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSerach.Text.Trim().ToLower(); // Convert input to lowercase

            if (string.IsNullOrEmpty(searchTerm))
            {
                tblUsers.DataSource = users;  // Ensure 'users' contains the original full list
            }
            else
            {
                // Ensure no null values cause errors
                var filteredUsers = users
                    .Where(u => (u.Username != null && u.Username.ToLower().Contains(searchTerm)) ||
                                (u.Role != null && u.Role.ToLower().Contains(searchTerm)))
                    .ToList();

                // Bind the filtered list to the DataGridView
                tblUsers.DataSource = null;  // Reset before rebinding
                tblUsers.DataSource = filteredUsers;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
                {
                    MessageBox.Show("Please select a user to edit.");
                    return;
                }

                if (string.IsNullOrEmpty(cmbUserRoles.Text.Trim()))
                {
                    MessageBox.Show("Please select a role.");
                    return;
                }

                string username = txtUserName.Text.Trim();
                string newRole = cmbUserRoles.Text.Trim();
                string newPassword = txtPassword.Text.Trim();

                // Check if Role has changed
                bool isRoleChanged = !string.IsNullOrEmpty(newRole);

                // Only update password if a new password is entered
                string passwordToUpdate = string.IsNullOrEmpty(newPassword) ? null : newPassword;

                // Prevent unnecessary updates
                if (!isRoleChanged && passwordToUpdate == null)
                {
                    MessageBox.Show("No changes detected. Please update either Role or Password.");
                    return;
                }

                // Update user (only sending password if it was changed)
                _userService.UpdateUserByUsername(username, passwordToUpdate, newRole);

                LoadUsers();
                MessageBox.Show("User updated successfully!");

                // Clear password field after updating to prevent accidental reuse
                txtPassword.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clearields();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;

            // Confirm deletion
            var result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _userService.SoftDeleteUser(username);  // selectedUsername is the username of the selected user

                LoadUsers();  
                Clearields() ;
            }
        }
    }
}
