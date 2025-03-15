using Book_Haven__Application.Data.Models;
using Book_Haven_System_Ad.Business.Interfaces;
using Book_Haven_System_Ad.Business.Services;
using Book_Haven_System_Ad.Data.Models;
using Book_Haven_System_Ad.Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Book_Haven_System_Ad.Forms
{
    public partial class frmPurchaseOrderForm : Form
    {
        private readonly IPurchaseOrderService _purchaseOrderService;
        private List<PurchaseOrderDetailsModel> orderDetailsList = new List<PurchaseOrderDetailsModel>();
        private readonly ISupplierService _supplierService;
        private List<SupplierModel> suppliers = new List<SupplierModel>();
        List<PurchaseOrderModel> purchaseOrders = new List<PurchaseOrderModel>();
        private Guid _selectedBookId = Guid.Empty; // Default to an empty GUID

        private readonly IBookService _bookService;
        private List<BookModel> books = new List<BookModel>();

        public string Username { get; set; }
        public string Role { get; set; }
        public frmPurchaseOrderForm()
        {
            InitializeComponent();
            _purchaseOrderService = new PurchaseOrderService();
            _supplierService = new SupplierService();
            _bookService = new BookService();
            supplierNameLoad();

            // Set up the DataGridView
            SetupDataGridView();

            // Wire the event for cell button clicks
            tblSelectedBooks.CellContentClick += tblSelectedBooks_CellContentClick;
            LoadPurchaseOrders();
            tblPurchaseOrders.CellFormatting += tblPurchaseOrders_CellFormatting;

        }

        private void tblPurchaseOrders_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {

            if (tblPurchaseOrders.Columns[e.ColumnIndex].Name == "Status" && e.RowIndex >= 0)
            {

                string status = e.Value.ToString();



                if (status == "Pending")
                {
                    e.CellStyle.BackColor = Color.Green; // Green for Pending
                }
                else if (status == "Received")
                {
                    e.CellStyle.BackColor = Color.Blue; // Blue for Received
                }
                else if (status == "Canceled")
                {
                    e.CellStyle.BackColor = Color.Red; // Red for Canceled
                }
                else
                {
                    e.CellStyle.BackColor = Color.White; // Default color
                }
            }

            // Apply color for the "Edit" button column
            if (tblPurchaseOrders.Columns[e.ColumnIndex].Name == "Action" && e.RowIndex >= 0)
            {
                e.CellStyle.BackColor = Color.Brown;  // Brown background for button
                e.CellStyle.ForeColor = Color.White;  // White text color
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center the text
                e.CellStyle.Font = new Font("Arial", 8, FontStyle.Bold);  // Set font size and style
            }
        }

        private void LoadPurchaseOrders()
        {
            // Get all purchase orders from the service
            var purchaseOrders = _purchaseOrderService.GetAllPurchaseOrders();

            // Flatten the purchase orders and set them into DataGridView
            var dataSource = purchaseOrders.SelectMany(po => po.OrderDetails, (po, pod) => new
            {
                po.PurchaseOrderID,
                po.SupplierID,
                po.OrderDate,
                pod.BookID,
                po.TotalAmount,
                po.Status,
                pod.Quantity,
                Action = "Edit"  // Static value for edit button
            }).ToList();

            // Set the data source of the DataGridView
            tblPurchaseOrders.DataSource = dataSource;

            // Add the "Edit" button column dynamically
            if (!tblPurchaseOrders.Columns.Contains("Action"))
            {
                DataGridViewButtonColumn ActionColumn = new DataGridViewButtonColumn
                {
                    Name = "Action",
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Flat // Make the button flat
                };

                // Set the button's background color to brown and text color to white
                ActionColumn.DefaultCellStyle.BackColor = Color.Brown;
                ActionColumn.DefaultCellStyle.ForeColor = Color.White;

                // Add the "Edit" button column to the DataGridView
                tblPurchaseOrders.Columns.Add(ActionColumn);
            }

            // Optionally, resize the columns
            tblPurchaseOrders.AutoResizeColumns();
        }

        private void tblPurchaseOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Ensure the clicked cell is not a header row
            if (e.RowIndex >= 0 && tblPurchaseOrders.Columns[e.ColumnIndex].Name == "Action")
            {
                // Get the selected PurchaseOrderID
                Guid purchaseOrderID = (Guid)tblPurchaseOrders.Rows[e.RowIndex].Cells["PurchaseOrderID"].Value;
                string currentStatus = tblPurchaseOrders.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                // Show a dropdown or input box for editing status
                string newStatus = PromptForStatus(currentStatus);
                if (!string.IsNullOrEmpty(newStatus) && newStatus != currentStatus)
                {
                    // Update status in the database
                    bool updated = _purchaseOrderService.UpdatePurchaseOrderStatus(purchaseOrderID, newStatus);

                    if (updated)
                    {
                        MessageBox.Show("Status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh data grid
                        LoadPurchaseOrders();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private string PromptForStatus(string currentStatus)
        {
            using (Form prompt = new Form())
            {
                prompt.Width = 300;
                prompt.Height = 200;
                prompt.Text = "Edit Status";

                Label label = new Label() { Left = 20, Top = 20, Text = "Select new status:" };
                ComboBox dropdown = new ComboBox() { Left = 20, Top = 50, Width = 200 };
                dropdown.Items.AddRange(new string[] { "Pending", "Received", "Canceled" });
                dropdown.SelectedItem = currentStatus;

                Button confirmation = new Button() { Text = "OK", Left = 20, Width = 80, Top = 100 };
                confirmation.DialogResult = DialogResult.OK;

                prompt.Controls.Add(label);
                prompt.Controls.Add(dropdown);
                prompt.Controls.Add(confirmation);

                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? dropdown.SelectedItem.ToString() : null;
            }
        }

        public void supplierNameLoad()
        {

            // Clear ComboBox first
            cmbSupplierNames.Items.Clear();

            // Fetch the supplier data from the service layer
            suppliers = _supplierService.GetAll();

            // Optionally, add a default option to prompt user to select a supplier
            suppliers.Insert(0, new SupplierModel { SupplierName = "Please select a supplier" });

            // Bind the supplier names to the ComboBox
            cmbSupplierNames.DataSource = suppliers;
            cmbSupplierNames.DisplayMember = "SupplierName";  // Show supplier names in ComboBox
            cmbSupplierNames.ValueMember = "SupplierId";

            // Set the ComboBox to display the default message initially
            cmbSupplierNames.SelectedIndex = 0;
        }
        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate if there are any rows in the DataGridView.
                if (tblSelectedBooks.Rows.Count == 0)
                {
                    MessageBox.Show("No items selected for the purchase order.");
                    return;
                }

                // Create a new PurchaseOrderModel
                var purchaseOrder = new PurchaseOrderModel
                {
                    PurchaseOrderID = Guid.NewGuid(), // Generate a new GUID for the order
                    SupplierID = (cmbSupplierNames.SelectedItem as SupplierModel)?.SupplierID ?? Guid.Empty,
                    OrderDate = dtpPODate.Value, // Get the selected date from the DateTimePicker control
                    Status = "Pending", // Set the status to 'Pending'
                    TotalAmount = 0 // Initialize TotalAmount to 0, it will be calculated later
                };

                // List to hold the purchase order details
                List<PurchaseOrderDetailsModel> orderDetails = new List<PurchaseOrderDetailsModel>();

                // Loop through the DataGridView rows to populate the order details
                decimal totalAmount = 0;
                foreach (DataGridViewRow row in tblSelectedBooks.Rows)
                {
                    if (row.Cells["BookID"].Value != null && row.Cells["Quantity"].Value != null && row.Cells["Price"].Value != null)
                    {
                        var orderDetail = new PurchaseOrderDetailsModel
                        {
                            PurchaseOrderDetailID = Guid.NewGuid(), // Generate a unique ID for the detail
                            PurchaseOrderID = purchaseOrder.PurchaseOrderID, // Link this detail to the Purchase Order
                            BookID = new Guid(row.Cells["BookID"].Value.ToString()), // Get BookID from DataGridView
                            Quantity = Convert.ToInt32(row.Cells["Quantity"].Value), // Get Quantity from DataGridView
                            Price = Convert.ToDecimal(row.Cells["Price"].Value) // Get Price from DataGridView
                        };

                        // Calculate the total price for this order detail and add to totalAmount
                        totalAmount += orderDetail.Quantity * orderDetail.Price;

                        // Add the detail to the list
                        orderDetails.Add(orderDetail);
                    }
                }

                // Set the TotalAmount for the Purchase Order
                purchaseOrder.TotalAmount = totalAmount;

                // Now call the service to create the purchase order
                var purchaseOrderService = new PurchaseOrderService();
                bool result = purchaseOrderService.CreatePurchaseOrder(purchaseOrder, orderDetails);

                if (result)
                {
                    MessageBox.Show("Purchase Order has been created successfully!");
                    // Optionally, clear the form or reset the UI
                    // **Clear DataGridView (tblSelectedBooks)**
                    tblSelectedBooks.Rows.Clear();

                    // **Reset Supplier-related fields**
                    cmbSupplierNames.SelectedIndex = -1; // Clear supplier selection
                    dtpPODate.Value = DateTime.Now; // Reset date to current date
                    txtConatctPersonName.Text = " ";
                    txtContactNumber.Text = " ";
                    // **Reset Labels**
                    lblTotalAmount.Text = "0.00";
                    cmbSupplierNames.Focus();

                }
                else
                {
                    MessageBox.Show("Failed to create Purchase Order. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private decimal CalculateTotalAmount()
        {
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in tblSelectedBooks.Rows)
            {
                if (!row.IsNewRow)
                {
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    totalAmount += price * quantity;
                }
            }
            lblTotalAmount.Text = "Total Amount: " + totalAmount.ToString("0.00");
            return totalAmount;
        }

        private void tblSelectedBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked column is the 'Remove' column
            if (e.ColumnIndex == tblSelectedBooks.Columns["Remove"].Index && e.RowIndex >= 0)
            {
                try
                {
                    // Remove the selected row
                    tblSelectedBooks.Rows.RemoveAt(e.RowIndex);

                    // Recalculate the total amount after removal
                    CalculateTotalAmount();
                }
                catch (InvalidOperationException ex)
                {
                    // Optionally, show a message if the row removal fails
                    MessageBox.Show("Cannot remove the new row.", "Error");
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // For all other columns
            {
                // Get the selected row
                DataGridViewRow selectedRow = tblSelectedBooks.Rows[e.RowIndex];

                // Populate the text fields with values from the selected row
                txtBookName.Text = selectedRow.Cells["BookName"].Value?.ToString() ?? "";
                txtAuthor.Text = selectedRow.Cells["Author"].Value?.ToString() ?? "";
                txtPrice.Text = selectedRow.Cells["Price"].Value?.ToString() ?? "";

                // Clear the txtQuantity field to allow the user to input a new quantity
                txtQuantity.Clear();
            }
        }



        private void SetupDataGridView()
        {
            tblSelectedBooks.Columns.Add("BookID", "Book ID"); // Hidden column for BookID
            tblSelectedBooks.Columns["BookID"].Visible = false; // Hide it from the UI


            // Add book columns
            tblSelectedBooks.Columns.Add("BookName", "Book Name");
            tblSelectedBooks.Columns.Add("Author", "Author");
            tblSelectedBooks.Columns.Add("Price", "Price");
            tblSelectedBooks.Columns.Add("Quantity", "Quantity");

            // Set AutoSizeMode to Fill for content columns
            tblSelectedBooks.Columns["BookName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tblSelectedBooks.Columns["Author"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tblSelectedBooks.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tblSelectedBooks.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Add a button column for removing a row
            DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn();
            removeButtonColumn.HeaderText = "Action";
            removeButtonColumn.Name = "Remove";
            removeButtonColumn.Text = "Remove";
            removeButtonColumn.UseColumnTextForButtonValue = true;

            // Set the button's background color to red using FlatStyle and ButtonStyle
            removeButtonColumn.FlatStyle = FlatStyle.Flat;  // Use FlatStyle
            removeButtonColumn.DefaultCellStyle.BackColor = Color.Red; // Set cell backcolor to red
            removeButtonColumn.DefaultCellStyle.ForeColor = Color.White; // Keep text white

            // Set AutoSizeMode to AllCells and MinimumWidth for the button column
            removeButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            removeButtonColumn.MinimumWidth = 80; // Adjust as needed

            // Adjust DefaultCellStyle for the button column
            removeButtonColumn.DefaultCellStyle.Padding = new Padding(5, 2, 5, 2); // Add padding
            removeButtonColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center align

            // Add the button column to the DataGridView
            tblSelectedBooks.Columns.Add(removeButtonColumn);
        }

        private void btnAddToTable_Click(object sender, EventArgs e)
        {

            // Retrieve values from the text fields
            string bookName = txtBookName.Text.Trim();
            string author = txtAuthor.Text.Trim();
            decimal price = 0;
            int quantity = 0;

            // Check if all fields are valid
            if (string.IsNullOrEmpty(bookName) || string.IsNullOrEmpty(author) ||
                !decimal.TryParse(txtPrice.Text, out price) || !int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Please fill in all the fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the book already exists in the DataGridView
            bool bookExists = false;
            foreach (DataGridViewRow row in tblSelectedBooks.Rows)
            {
                // Check if the BookName and Author match
                if (row.Cells["BookName"].Value != null && row.Cells["BookName"].Value.ToString() == bookName &&
                    row.Cells["Author"].Value != null && row.Cells["Author"].Value.ToString() == author)
                {
                    // Update the quantity of the existing book
                    row.Cells["Quantity"].Value = Convert.ToInt32(row.Cells["Quantity"].Value) + quantity;
                    bookExists = true;
                    break;
                }
            }

            if (!bookExists)
            {
                // Add the book information to the DataGridView (tblSelectedBooks)
                tblSelectedBooks.Rows.Add(_selectedBookId, bookName, author, price.ToString("F2"), quantity);
            }

            // Clear the text fields after adding
            txtBookName.Clear();
            txtAuthor.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            _selectedBookId = Guid.Empty;
            // Set focus back to the book name text field
            txtBookName.Focus();



            // Recalculate total amount after adding the book
            CalculateTotalAmount();

        }



        private void cmbSupplierNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplierNames.SelectedItem != null)
            {
                // Get the selected supplier
                SupplierModel selectedSupplier = (SupplierModel)cmbSupplierNames.SelectedItem;

                // Set the contact details in the corresponding text boxes
                txtConatctPersonName.Text = selectedSupplier.ContactName;
                txtContactNumber.Text = selectedSupplier.ContactPhone;
            }
        }




        private void txtBookName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string bookName = txtBookName.Text.Trim();

                if (!string.IsNullOrEmpty(bookName))
                {
                    // Fetch book details based on book name
                    BookModel book = _bookService.GetBookByName(bookName);

                    if (book != null)
                    {
                        // Store bookId for later use
                        _selectedBookId = book.BookID;

                        // Set other details
                        txtAuthor.Text = book.Author;
                        txtPrice.Text = book.Price.ToString("F2");

                        // Move focus to Quantity textbox
                        txtQuantity.Focus();
                    }
                    else
                    {
                        // Display error message
                        MessageBox.Show("Book not found. Please enter a valid book name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _selectedBookId = Guid.Empty; // Reset bookId
                    }
                }

                // Prevent default behavior
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // tbl purchse order deilails
        private void txtSerach_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSerach.Text.Trim();

            // Fetch all purchase orders
            var purchaseOrders = _purchaseOrderService.GetAllPurchaseOrders();

            if (string.IsNullOrEmpty(searchTerm))
            {
                // If no search term is provided, display all purchase orders
                tblPurchaseOrders.DataSource = purchaseOrders.SelectMany(po => po.OrderDetails, (po, pod) => new
                {
                    po.PurchaseOrderID,
                    po.SupplierID,
                    po.OrderDate,
                    pod.BookID,
                    po.TotalAmount,
                    po.Status,
                    pod.Quantity,
                    Action = "Edit"  // Static value for the Edit button
                }).ToList();
            }
            else
            {
                // Filter the purchase orders based on search term
                var filteredPurchaseOrders = purchaseOrders.Where(po =>
                    (!string.IsNullOrEmpty(po.Status) && po.Status.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)) ||
                    (po.OrderDate.ToString("yyyy-MM-dd").Contains(searchTerm)) || // Search by Order Date (formatted as YYYY-MM-DD)
                    (po.TotalAmount.ToString().Contains(searchTerm)) // Search by Total Amount (Price)
                ).SelectMany(po => po.OrderDetails, (po, pod) => new
                {
                    po.PurchaseOrderID,
                    po.SupplierID,
                    po.OrderDate,
                    pod.BookID,
                    po.TotalAmount,
                    po.Status,
                    pod.Quantity,
                    Action = "Edit"
                }).ToList();

                tblPurchaseOrders.DataSource = filteredPurchaseOrders;
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard adminDashboard = new frmAdminDashboard();
            adminDashboard.SetUserInfo(this.Username, this.Role);
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
