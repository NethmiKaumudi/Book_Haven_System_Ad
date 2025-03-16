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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Book_Haven_System_Ad.Forms
{
    public partial class frmUser : Form
    {
        private readonly IUserService _userService;
        List<UserModel> users;
        public string Username { get; set; }
        public string Role { get; set; }
        public frmUser()
        {
            InitializeComponent();
            Username = UserSession.Instance.Username;
            Role = UserSession.Instance.Role;

            lblusernameRole.Text = $"{Username} - {Role}";
            lbldate.Text = $"Today: {DateTime.Now:yyyy-MM-dd}";
            _userService = new UserService();
            LoadUsers();
        }
        private bool ValidateFields()
        {
            bool isValid = true;

            lblUserNameError.Text = "";
            lblErrorPw.Text = "";

            // Regular expression to require at least 4 letters and allow numbers
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()) ||
                !System.Text.RegularExpressions.Regex.IsMatch(txtUserName.Text.Trim(), @"^(?=(.*[A-Za-z]){4,})[A-Za-z0-9]+$"))
            {
                txtUserName.BackColor = System.Drawing.Color.Red;
                lblUserNameError.Text = "Username must be at least 4 letters long.\nIt can contain letters and numbers."; // Multiline error message
                lblUserNameError.ForeColor = System.Drawing.Color.Red;
                isValid = false;
            }
            else
            {
                txtUserName.BackColor = System.Drawing.Color.White;
            }


            // Validate Password: At least 2 letters, 4 numbers, and total length of at least 6 characters
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()) ||
                !System.Text.RegularExpressions.Regex.IsMatch(txtPassword.Text.Trim(), @"^(?=(.*[A-Za-z]){2})(?=(.*\d){4})[A-Za-z\d]{6,}$"))
            {
                txtPassword.BackColor = System.Drawing.Color.Red;
                lblErrorPw.Text = "Password must contain at least 2 letters,\n4 numbers, and a total length of at least 6 characters.";
                lblErrorPw.ForeColor = System.Drawing.Color.Red; 
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
                Clearields();
            }
        }

        private void picLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Clear user session on logout
                UserSession.Instance.Logout();

                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                this.Hide();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard adminDashboard = new frmAdminDashboard();
            //adminDashboard.SetUserInfo(this.Username, this.Role);
            adminDashboard.Show();
            this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new frmUser());

        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new frmBookForm());

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new frmCustomerForm());

        }

        private void btnSalespos_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new frmSales(Username));

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new frmSalesDetailsForm());

        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new frmSupplierForm());

        }

        private void btnPO_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new frmPurchaseOrderForm());

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new ReportForm());

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
