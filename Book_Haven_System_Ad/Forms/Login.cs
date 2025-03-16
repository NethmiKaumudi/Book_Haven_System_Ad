using Book_Haven__Application.Business.Interfaces;
using Book_Haven__Application.Business.Services;
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
    public partial class frmLogin : Form
    {
        private readonly IUserService _userService;

        public frmLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            _userService = new UserService();

        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            string role = _userService.Login(username, password);

            if (role != null)
            {
                UserSession.Instance.SetUser(username, role);

                if (role == "Admin")
                {
                    frmAdminDashboard adminDashboard = new frmAdminDashboard();
                    adminDashboard.Show();
                }
                else if (role == "Sales Clerk")
                {
                    SalesClearkDashboard salesDashboard = new SalesClearkDashboard();
                    salesDashboard.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }

        private void chkShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
