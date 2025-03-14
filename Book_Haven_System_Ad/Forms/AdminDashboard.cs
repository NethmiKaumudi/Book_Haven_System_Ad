using Book_Haven__Application.Data.Models;
using Book_Haven_System_Ad.Business.Interfaces;
using Book_Haven_System_Ad.Business.Services;
using Book_Haven_System_Ad.Data.Models;
using Book_Haven_System_Ad.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Book_Haven_System_Ad.Forms
{
    public partial class frmAdminDashboard : Form
    {
        private System.Windows.Forms.Timer timer;

        public string Username { get; set; }
        public string Role { get; set; }
        private readonly IBookService bookService;
        private readonly IOrderService _orderService;


        public frmAdminDashboard()
        {
            InitializeComponent();
            bookService = new BookService();
            _orderService = new OrderService();
            InitializeTimer();

            LoadLowStockBooks();
            tblSalesPerformance.Columns.Add("ProcessedByColumn", "Processed By");
            tblSalesPerformance.Columns.Add("TotalSalesColumn", "Total Sales");
            LoadTodaySalesData();    
            LoadYesterdaySalesData();
        }
      
        public void LoadTodaySalesData()
        {
            LoadSalesData(DateTime.Now); 
        }

        public void LoadYesterdaySalesData()
        {
            LoadSalesData(DateTime.Now.AddDays(-1)); 
        }

        public void LoadSalesData(DateTime date)
        {
            try
            {
                List<OrderSalesData> salesData = _orderService.GetSalesByProcessedBy(date);
                tblSalesPerformance.Rows.Clear(); // Clear previous data

                CultureInfo sriLankanCulture = new CultureInfo("si-LK"); // Use Sri Lankan culture

                foreach (var data in salesData)
                {
                    // Format TotalSales as Sri Lankan Rupees
                    string formattedSales = data.TotalSales.ToString("C", sriLankanCulture);
                    tblSalesPerformance.Rows.Add(data.ProcessedBy, formattedSales);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading sales data: {ex.Message}");
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                var lowStockBooks = bookService.GetLowStockBooks(); // Get the updated low stock books
                Console.WriteLine($"Fetched {lowStockBooks.Count} low stock books.");
                UpdateLowStockBooksUI(lowStockBooks); // Update the UI with the latest stock status
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Initialize the timer to check stock periodically (every 1 hour)
        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3600000; // 1 hour (3600000 milliseconds)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        // Method to immediately load low stock books when the dashboard is accessed
        private void LoadLowStockBooks()
        {
            try
            {
                var lowStockBooks = bookService.GetLowStockBooks(); // Get the current low stock books
                UpdateLowStockBooksUI(lowStockBooks); // Update the UI immediately
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading low stock books: {ex.Message}");
            }
        }

        // Update the UI with the list of low stock books
        private void UpdateLowStockBooksUI(List<BookModel> lowStockBooks)
        {
            checkedListBoxLawStock.Items.Clear();  // Clear existing items

            // Sort the list by stock (ascending order)
            var orderedBooks = lowStockBooks.OrderBy(book => book.Stock).ToList();

            // Add books to the CheckedListBox with a color for low stock
            foreach (var book in orderedBooks)
            {
                string bookInfo = $"Title: {book.Title} - Stock: {book.Stock} is out of stock, please restock again!";

                // Add item to CheckedListBox
                checkedListBoxLawStock.Items.Add(bookInfo);

                // If stock is low (e.g., <= 5), change the text color
                if (book.Stock <= 5)
                {
                    // Set item color to red for low stock
                    checkedListBoxLawStock.ForeColor = Color.Red;
                }
                else
                {
                    // Set item color to black (default)
                    checkedListBoxLawStock.ForeColor = Color.Black;
                }
            }
        }
        private void checkedListBoxLawStock_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the index of the item being checked or unchecked
            int index = e.Index;

            // Defer the removal until after the event
            this.BeginInvoke(new Action(() =>
            {
                if (e.NewValue == CheckState.Checked)
                {
                    var bookInfo = checkedListBoxLawStock.Items[index].ToString();
                    Console.WriteLine($"Item checked: {bookInfo}");

                    // Remove the item from the list immediately when it's checked
                    checkedListBoxLawStock.Items.RemoveAt(index);
                }
            }));
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard adminDashboard = new frmAdminDashboard();
            adminDashboard.SetUserInfo(this.Username, this.Role);
            adminDashboard.Show();
            this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

        }

        private void btnBooks_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnSalespos_Click(object sender, EventArgs e)
        {

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {

        }

        private void btnPO_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }
    }
}
