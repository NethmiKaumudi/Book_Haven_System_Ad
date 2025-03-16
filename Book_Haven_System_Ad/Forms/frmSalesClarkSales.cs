using Book_Haven__Application.Business.Interfaces;
using Book_Haven__Application.Business.Services;
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
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Book_Haven_System_Ad.Forms
{
    public partial class frmSalesClarkSales : Form
    {
        private readonly IOrderService _orderService;
        private string _loggedInUser;
        private readonly ICustomerService _customerService; // Add customer service
        private readonly IBookService _bookService;
        private readonly IUserService _userService;
        private Guid _selectedBookId = Guid.Empty; // Default to an empty GUID
        private Guid customerId = Guid.Empty; // Declare a local variable to hold CustomerID

        public string Username { get; set; }
        public string Role { get; set; }

        public frmSalesClarkSales(string loggedInUser)
        {
            InitializeComponent();
            Username = UserSession.Instance.Username;
            Role = UserSession.Instance.Role;

            lblusernameRole.Text = $"{Username} - {Role}";
            lbldate.Text = $"Today: {DateTime.Now:yyyy-MM-dd}";
            _orderService = new OrderService();
            _customerService = new CustomerService();
            _bookService = new BookService();
            _userService = new UserService();
            _loggedInUser = loggedInUser;

            txtOrderId.Text = _orderService.GenerateOrderId();
            txtOrderId.ReadOnly = true;

            txtOrderUserName.Text = _loggedInUser;
            txtOrderUserName.ReadOnly = true;

            // Set up the DataGridView
            SetupDataGridView();
            // Populate discount dropdown with percentage values
            cmbDiscount.Items.Clear();
            cmbDiscount.Items.Add("0");  // No discount
            cmbDiscount.Items.Add("5");
            cmbDiscount.Items.Add("10");
            cmbDiscount.Items.Add("15");
            cmbDiscount.Items.Add("20");

            cmbDiscount.SelectedIndex = 0; // Set default selection to 0%
        }

        private void SetupDataGridView()
        {
            tblOrderCart.Columns.Add("BookID", "Book ID"); // Hidden column for BookID
            tblOrderCart.Columns["BookID"].Visible = false; // Hide it from the UI


            // Add book columns
            tblOrderCart.Columns.Add("BookName", "Book Name");
            tblOrderCart.Columns.Add("Author", "Author");
            tblOrderCart.Columns.Add("Price", "Price");
            tblOrderCart.Columns.Add("Quantity", "Quantity");

            // Set AutoSizeMode to Fill for content columns
            tblOrderCart.Columns["BookName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tblOrderCart.Columns["Author"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tblOrderCart.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tblOrderCart.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
            tblOrderCart.Columns.Add(removeButtonColumn);
        }


        private decimal CalculateSubTotalAmount()
        {
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in tblOrderCart.Rows)
            {
                if (!row.IsNewRow)
                {
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    totalAmount += price * quantity;
                }
            }
            txtSubTotal.Text = "Total Amount: " + totalAmount.ToString("0.00");
            return totalAmount;
        }


        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmOrderAddCustomerPopUp addCustomerForm = new frmOrderAddCustomerPopUp();
            addCustomerForm.ShowDialog();
        }

        private void txtCustomerNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key is pressed
            {
                string customerNumber = txtCustomerNumber.Text.Trim();
                if (!string.IsNullOrEmpty(customerNumber))
                {
                    // Fetch customer details (Name and ID) using a service
                    CustomerModel customer = _customerService.GetCustomerDetailsByNumber(customerNumber);

                    if (customer != null)
                    {
                        // If customer is found, fill in the name and store the customer ID
                        txtCustomerName.Text = customer.Name; // Assuming CustomerName property in CustomerModel
                        customerId = customer.CustomerID; // Assign the Guid
                    }
                    else
                    {
                        // Customer not found
                        DialogResult result = MessageBox.Show(
                            "There is no customer with this number. Would you like to add a new customer?",
                            "Customer Not Found",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (result == DialogResult.Yes)
                        {
                            txtCustomerName.Text = "";
                            txtCustomerNumber.Text = "";
                            frmOrderAddCustomerPopUp addCustomerForm = new frmOrderAddCustomerPopUp();
                            addCustomerForm.ShowDialog();
                            txtCustomerNumber.Focus();
                        }
                    }
                }


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
                        txtPrize.Text = book.Price.ToString("F2");

                        // Move focus to Quantity textbox
                        txtOrderQty.Focus();
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
        private void btnAddtoOrderCart_Click(object sender, EventArgs e)
        {
            // Retrieve values from the text fields
            string bookName = txtBookName.Text.Trim();
            string author = txtAuthor.Text.Trim();
            decimal price = 0;
            int quantity = 0;

            // Check if all fields are valid
            if (string.IsNullOrEmpty(bookName) || string.IsNullOrEmpty(author) ||
                !decimal.TryParse(txtPrize.Text, out price) || !int.TryParse(txtOrderQty.Text, out quantity))
            {
                MessageBox.Show("Please fill in all the fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the book already exists in the DataGridView
            bool bookExists = false;
            foreach (DataGridViewRow row in tblOrderCart.Rows)
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
                tblOrderCart.Rows.Add(_selectedBookId, bookName, author, price.ToString("F2"), quantity);
            }

            // Clear the text fields after adding
            txtBookName.Clear();
            txtAuthor.Clear();
            txtPrize.Clear();
            txtOrderQty.Clear();
            _selectedBookId = Guid.Empty;


            txtBookName.Focus();



            // Recalculate total amount after adding the book
            CalculateSubTotalAmount();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if customer is selected
                if (customerId == Guid.Empty)
                {
                    MessageBox.Show("Please select a customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Retrieve data from UI fields
                decimal totalAmount = decimal.Parse(txtOrderTotal.Text.Trim());
                string deliveryType = cmbDeliveryType.SelectedItem?.ToString();
                string deliveryAddress = txtDeliveryAddress.Text.Trim();
                DateTime orderDate = dtpPosDate.Value;
                string OrderSource = cmbOrderMethod.SelectedItem?.ToString();
                decimal amountPaid = decimal.TryParse(txtAmountPaid.Text, out decimal paid) ? paid : 0; // Parse amount paid
                decimal changeAmount = decimal.TryParse(txtChange.Text, out decimal change) ? change : 0; // Parse change amount
                OrderModel order = new OrderModel
                {
                    OrderID = txtOrderId.Text,
                    CustomerID = customerId,
                    TotalAmount = totalAmount,
                    OrderDate = orderDate,
                    OrderSource = OrderSource, // Use orderSource here
                };

                // Set Status, Delivery, and ProcessedBy based on Order Type
                if (OrderSource == "POS")
                {
                    order.Status = null;
                    order.DeliveryStatus = null;
                    order.DeliveryAddress = null;
                    order.ProcessedBy = txtOrderUserName.Text.Trim();

                }
                else if (OrderSource == "Online")  // Explicitly check for "Online"
                {
                    if (deliveryType == "In-Store Pickup")
                    {
                        order.Status = "Pending";
                        order.DeliveryStatus = "Not Applicable";
                        order.DeliveryAddress = null;
                        order.ProcessedBy = txtOrderUserName.Text.Trim();
                    }
                    else if (deliveryType == "Home Delivery")
                    {
                        order.Status = "Pending";
                        order.DeliveryStatus = "Processing";

                        if (string.IsNullOrEmpty(txtDeliveryAddress.Text))
                        {
                            MessageBox.Show("Delivery address is required for home delivery.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        order.DeliveryAddress = txtDeliveryAddress.Text.Trim();
                        order.ProcessedBy = txtOrderUserName.Text.Trim();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Delivery Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Order Source.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Collect Order Details from DataGridView
                List<OrderDetailsModel> orderDetails = new List<OrderDetailsModel>();
                foreach (DataGridViewRow row in tblOrderCart.Rows)
                {
                    if (row.Cells["BookID"].Value != null && row.Cells["Quantity"].Value != null && row.Cells["Price"].Value != null)
                    {
                        OrderDetailsModel orderDetail = new OrderDetailsModel
                        {
                            OrderDetailID = Guid.NewGuid(),
                            OrderId = order.OrderID,
                            BookID = new Guid(row.Cells["BookID"].Value.ToString()),  // Get BookID from DataGridView
                            Quantity = int.Parse(row.Cells["Quantity"].Value.ToString()),
                            Price = decimal.Parse(row.Cells["Price"].Value.ToString())
                        };
                        orderDetails.Add(orderDetail);
                    }
                }

                // Call the service to save order
                _orderService.AddOrder(order, orderDetails);

                MessageBox.Show("Order successfully placed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Trigger print receipt
                PrintReceipt(order, orderDetails);

                ClearOrderForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void PrintReceipt(OrderModel order, List<OrderDetailsModel> orderDetails)

        {
            // Construct the receipt string with a more visually appealing format
            StringBuilder receipt = new StringBuilder();

            // Header
            receipt.AppendLine("===============================");
            receipt.AppendLine("        YOUR RECEIPT         ");
            receipt.AppendLine("===============================");
            receipt.AppendLine();

            // Order Information
            receipt.AppendLine($"Order ID: {order.OrderID}");
            receipt.AppendLine($"Customer ID: {order.CustomerID}");
            receipt.AppendLine($"Date: {order.OrderDate:yyyy-MM-dd HH:mm:ss}"); // Format date
            receipt.AppendLine();

            // Items Header
            receipt.AppendLine("--- Order Items ---");
            receipt.AppendLine("-------------------------------");
            receipt.AppendLine("Item ID | Qty |    Price");
            receipt.AppendLine("-------------------------------");

            // Order Details
            foreach (var detail in orderDetails)
            {
                receipt.AppendLine($"{detail.BookID,-7} | {detail.Quantity,-3} | {detail.Price,8:C}"); // Formatted columns
            }

            receipt.AppendLine("-------------------------------");

            // Total
            receipt.AppendLine();
            receipt.AppendLine($"Total: {order.TotalAmount,25:C}"); // Right-align total
            receipt.AppendLine();

            // Footer
            receipt.AppendLine("===============================");
            receipt.AppendLine("     Thank You For Your      ");
            receipt.AppendLine("          Purchase!          ");
            receipt.AppendLine("===============================");

            // Display the receipt (replace with actual printing logic)
            MessageBox.Show(receipt.ToString(), "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        private void ClearOrderForm()
        {
            txtCustomerNumber.Clear();
            txtCustomerName.Clear();
            txtOrderTotal.Clear();
            tblOrderCart.Rows.Clear();
        }

        private void cmbOrderMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrderMethod.SelectedItem != null)
            {
                string selectedMethod = cmbOrderMethod.SelectedItem.ToString();

                if (selectedMethod == "POS")
                {
                    groupBoxOnlineOrder.Visible = false; // Hide the combo box if POS is selected
                }
                else if (selectedMethod == "Online")
                {
                    groupBoxOnlineOrder.Visible = true; // Show the combo box if Online is selected
                    groupBoxPosOrders.Visible = false;
                }
            }
        }


        private void tblOrderCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                // Check if the clicked column is the 'Remove' column
                if (e.ColumnIndex == tblOrderCart.Columns["Remove"].Index && e.RowIndex >= 0)
                {
                    try
                    {
                        // Remove the selected row
                        tblOrderCart.Rows.RemoveAt(e.RowIndex);

                        // Recalculate the total amount after removal
                        CalculateSubTotalAmount();
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
                    DataGridViewRow selectedRow = tblOrderCart.Rows[e.RowIndex];

                    // Populate the text fields with values from the selected row
                    txtBookName.Text = selectedRow.Cells["BookName"].Value?.ToString() ?? "";
                    txtAuthor.Text = selectedRow.Cells["Author"].Value?.ToString() ?? "";
                    txtPrize.Text = selectedRow.Cells["Price"].Value?.ToString() ?? "";

                    // Clear the txtQuantity field to allow the user to input a new quantity
                    txtOrderQty.Clear();
                }
            }
        }

        private void cmbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDiscount.SelectedItem != null)
            {
                // Get the subtotal directly from the CalculateSubTotalAmount() method
                decimal subTotal = CalculateSubTotalAmount();

                if (int.TryParse(cmbDiscount.SelectedItem.ToString(), out int discountPercentage))
                {
                    decimal discountAmount = (subTotal * discountPercentage) / 100;
                    decimal total = subTotal - discountAmount;

                    txtOrderTotal.Text = total.ToString("F2"); // Update txtOrderTotal
                }
            }
        }


      
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

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new frmSalesClearkCustomer());

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SalesClearkDashboard adminDashboard = new SalesClearkDashboard();
            //adminDashboard.SetUserInfo(this.Username, this.Role);
            adminDashboard.Show();
            this.Hide();
        }

        private void btnSalespos_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(this, new frmSalesClarkSales(Username));

        }

        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtOrderTotal.Text, out decimal orderTotal) && decimal.TryParse(txtAmountPaid.Text, out decimal amountPaid))
            {
                decimal change = amountPaid - orderTotal;
                txtChange.Text = change.ToString("F2"); // Format to 2 decimal places
            }
            else
            {
                txtChange.Text = "0.00"; // Default to 0 if input is invalid
            }
        }

        private void cmbDeliveryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrderMethod.SelectedItem != null)
            {
                string selectedMethod = cmbOrderMethod.SelectedItem.ToString();

                if (selectedMethod == "In-Store Pickup")
                {
                    txtDeliveryAddress.Visible = false;
                }
                else if (selectedMethod == "Online")
                {
                    txtDeliveryAddress.Visible = true;
                }
            }
        }
    }
}
