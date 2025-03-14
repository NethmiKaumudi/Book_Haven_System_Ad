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
        public ReportForm()
        {
            InitializeComponent();
            orderService = new OrderService();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                // Get report type
                string reportType = cmbreportType.SelectedItem?.ToString();

                // Get start and end dates
                DateTime startDate = startDatePicker.Value.Date;
                DateTime endDate = endDatePicker.Value.Date;

                if (string.IsNullOrEmpty(reportType))
                {
                    MessageBox.Show("Please select a report type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Fetch Sales Report
                var salesReport = orderService.GetSalesReport(startDate, endDate, reportType);

                // Display the report in the DataGridView
                salesReportGrid.DataSource = salesReport;
                salesReportGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Calculate Total Sales and Total Orders
                decimal totalSales = 0;
                int totalOrders = salesReport.Count;

                foreach (var report in salesReport)
                {
                    totalSales += report.TotalSales;
                }

                txtTotalSales.Text = $"Total Sales: RS{totalSales:F2}";
                txtTotalOrder.Text = $"Total Orders: {totalOrders}";

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

        private void cmbreportType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
