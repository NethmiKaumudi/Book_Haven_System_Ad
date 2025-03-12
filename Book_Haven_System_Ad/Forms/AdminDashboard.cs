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
    public partial class frmAdminDashboard : Form
    {
        public string Username { get; set; }
        public string Role { get; set; }
        public frmAdminDashboard()
        {
            InitializeComponent();
            //lblusernameRole.Text = $" {username} - {role}";
            //lbldate.Text = $"Today: {DateTime.Now.ToString("yyyy-MM-dd")}";
        }
        public void SetUserInfo(string username, string role)
        {
            Username = username;
            Role = role;
            lblusernameRole.Text = $"{username} - {role}";
            lbldate.Text = $"Today: {DateTime.Now.ToString("yyyy-MM-dd")}";
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

        private void btnUsers_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new frmUser());
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new frmBookForm());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new frmAdminDashboard());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new frmCustomerForm());
        }

    }
}
