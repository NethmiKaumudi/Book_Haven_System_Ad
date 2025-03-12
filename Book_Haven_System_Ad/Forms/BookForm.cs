using Book_Haven__Application.Data.Models;
using Book_Haven_System_Ad.Business.Interfaces;
using Book_Haven_System_Ad.Business.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Haven_System_Ad.Forms
{
    public partial class frmBookForm : Form
    {
        private readonly IBookService _bookService;

        public frmBookForm()
        {
            InitializeComponent();
            _bookService = new BookService();
            LoadBooks();
        }
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || txtTitle.Text.Length < 2 || !Regex.IsMatch(txtTitle.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Title is required and must be at least 5 characters long, containing only letters, numbers, and spaces.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return false;
            }

            // Validate Author (Must be at least 3 characters and contain only letters and spaces)
            if (string.IsNullOrWhiteSpace(txtAuthor.Text) || txtAuthor.Text.Length < 3 || !Regex.IsMatch(txtAuthor.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Author name is required and must be at least 5 characters long, containing only letters and spaces.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAuthor.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Enter a valid price greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Quantity must be a valid number (0 or greater).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return; // Validate before adding

            try
            {
                var book = new BookModel
                {
                    Title = txtTitle.Text,
                    Author = txtAuthor.Text,
                    ISBN = txtIsbn.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Stock = int.Parse(txtStock.Text)
                };

                _bookService.AddBook(book);
                LoadBooks();
                MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookId.Text)) return;

            try
            {
                var bookId = Guid.Parse(txtBookId.Text);
                var existingBook = _bookService.GetBookById(bookId);

                if (existingBook == null)
                {
                    MessageBox.Show("Book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update only modified fields
                var updatedBook = new BookModel
                {
                    BookID = bookId,
                    Title = txtTitle.Text != existingBook.Title ? txtTitle.Text : existingBook.Title,
                    Author = txtAuthor.Text != existingBook.Author ? txtAuthor.Text : existingBook.Author,
                    ISBN = txtIsbn.Text != existingBook.ISBN ? txtIsbn.Text : existingBook.ISBN,
                    Price = decimal.Parse(txtPrice.Text) != existingBook.Price ? decimal.Parse(txtPrice.Text) : existingBook.Price,
                    Stock = int.Parse(txtStock.Text) != existingBook.Stock ? int.Parse(txtStock.Text) : existingBook.Stock
                };

                _bookService.UpdateBook(updatedBook);
                LoadBooks();
                MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var bookId = txtBookId.Text;

                if (string.IsNullOrWhiteSpace(bookId))
                {
                    MessageBox.Show("Please select a book to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this book?", "Delete Book", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    var bookID = Guid.Parse(bookId);
                    _bookService.DeleteBook(bookID);
                    LoadBooks();
                    MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtIsbn.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            txtBookId.Clear();
            txtTitle.Focus();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
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

        private void tblBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblBooks.Rows[e.RowIndex];

                txtBookId.Text = row.Cells["BookID"].Value.ToString();
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtAuthor.Text = row.Cells["Author"].Value.ToString();
                txtIsbn.Text = row.Cells["ISBN"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard dashboardForm = new frmAdminDashboard();
            dashboardForm.Show();
            this.Hide();
        }
    }
}
