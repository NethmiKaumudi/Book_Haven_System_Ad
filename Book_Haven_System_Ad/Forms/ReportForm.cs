using Book_Haven_System_Ad.Business.Interfaces;
using Book_Haven_System_Ad.Business.Services;
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
    public partial class ReportForm : Form
    {
        private readonly IOrderService orderService;
        public string Username { get; set; }
        public string Role { get; set; }
        public ReportForm()
        {
            InitializeComponent();
            Username = UserSession.Instance.Username;
            Role = UserSession.Instance.Role;

            lblusernameRole.Text = $"{Username} - {Role}";
            lbldate.Text = $"Today: {DateTime.Now:yyyy-MM-dd}";
            orderService = new OrderService();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                string reportType = cmbreportType.SelectedItem?.ToString();

                DateTime startDate = startDatePicker.Value.Date;
                DateTime endDate = endDatePicker.Value.Date;

                if (string.IsNullOrEmpty(reportType))
                {
                    MessageBox.Show("Please select a report type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var salesReport = orderService.GetSalesReport(startDate, endDate, reportType);

                salesReportGrid.DataSource = salesReport;
                salesReportGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                decimal totalSales = 0;
                int totalOrders = salesReport.Count;

                foreach (var report in salesReport)
                {
                    totalSales += report.TotalSales;
                }

                txtTotalSales.Text = $" RS{totalSales:F2}";
                txtTotalOrder.Text = $" {totalOrders}";

                //// Best Selling Books Report
                //var bestSellingBooks = orderService.GetBestSellingBooksReport(startDate, endDate);
                //bestSellingBooksGrid.DataSource = bestSellingBooks;
                //bestSellingBooksGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //// Inventory Status Report
                //var inventoryStatus = orderService.GetInventoryStatusReport();
                //inventoryStatusGrid.DataSource = inventoryStatus;
                //inventoryStatusGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //public void SetUserInfo(string username, string role)
        //{
        //    Username = username;
        //    Role = role;
        //    lblusernameRole.Text = $"{username} - {role}";
        //    lbldate.Text = $"Today: {DateTime.Now.ToString("yyyy-MM-dd")}";
        //}

        private void picLogout_Click(object sender, EventArgs e)
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
    }
}
