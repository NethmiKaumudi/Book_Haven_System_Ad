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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Book_Haven_System_Ad.Forms
{
    public partial class SalesClearkDashboard : Form
    {
        private readonly IBookService _bookService;
        public string Username { get; set; }
        public string Role { get; set; }
        public SalesClearkDashboard()
        {

            InitializeComponent();
            _bookService = new BookService();

            LoadBooks();

        }
        private void LoadBooks()
        {
            try
            {
                // Get all books from the service
                var books = _bookService.GetAllBooks();

                // Bind the books list to the DataGridView
                tblBooks.DataSource = books;

                // Set header texts for the relevant columns
                tblBooks.Columns["BookID"].HeaderText = "Book ID";
                tblBooks.Columns["Title"].HeaderText = "Title";
                tblBooks.Columns["Author"].HeaderText = "Author";
                tblBooks.Columns["ISBN"].HeaderText = "ISBN";
                tblBooks.Columns["Price"].HeaderText = "Price (LKR)";
                tblBooks.Columns["Stock"].HeaderText = "Stock";

                foreach (DataGridViewColumn column in tblBooks.Columns)
                {
                    if (column.Name != "BookID" && column.Name != "Title" && column.Name != "Author" &&
                        column.Name != "ISBN" && column.Name != "Price" && column.Name != "Stock")
                    {
                        column.Visible = false;
                    }
                }

                // Auto-size columns to fit the DataGridView width
                tblBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSerach_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSerach.Text.Trim();

            var books = _bookService.GetAllBooks().Where(b => !b.IsDeleted).ToList(); // Exclude deleted books

            if (string.IsNullOrEmpty(searchTerm))
            {
                tblBooks.DataSource = books;
            }
            else
            {
                var filteredBooks = books.Where(b => b.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                                     (b.Author != null && b.Author.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)) ||
                                                     (b.ISBN != null && b.ISBN.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)))
                                         .ToList();

                tblBooks.DataSource = filteredBooks;
            }
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

                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                this.Hide();


            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new frmCustomerForm());

        }

        private void btnSalespos_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new frmSales(Username));

        }
    }
}
