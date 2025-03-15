using Book_Haven__Application.Business.Interfaces;
using Book_Haven__Application.Business.Services;
using Book_Haven__Application.Data.Models;
using Book_Haven_System_Ad.Business.Interfaces;
using Book_Haven_System_Ad.Business.Services;
using Book_Haven_System_Ad.Data.Repository;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Book_Haven_System_Ad.Forms
{
    public partial class frmSales : Form
    {
        private readonly IOrderService _orderService;
        private string _loggedInUser;
        private readonly ICustomerService _customerService;
        private readonly IBookService _bookService;
        private readonly IUserService _userService;
        private Guid _selectedBookId = Guid.Empty;
        private Guid customerId = Guid.Empty;
        public string Username { get; set; }
        public string Role { get; set; }

        public frmSales(string loggedInUser)
        {
            InitializeComponent();
            _orderService = new OrderService();
            _customerService = new CustomerService();
            _bookService = new BookService();
            _userService = new UserService();
            _loggedInUser = loggedInUser;

            txtOrderId.Text = _orderService.GenerateOrderId();
            txtOrderId.ReadOnly = true;

            txtOrderUserName.Text = _loggedInUser;
            txtOrderUserName.ReadOnly = true;

            SetupDataGridView();
            cmbDiscount.Items.Clear();
            cmbDiscount.Items.Add("0");
            cmbDiscount.Items.Add("5");
            cmbDiscount.Items.Add("10");
            cmbDiscount.Items.Add("15");
            cmbDiscount.Items.Add("20");

            cmbDiscount.SelectedIndex = 0;

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
            if (e.KeyCode == Keys.Enter)
            {
                string customerNumber = txtCustomerNumber.Text.Trim();
                if (!string.IsNullOrEmpty(customerNumber))
                {
                    CustomerModel customer = _customerService.GetCustomerDetailsByNumber(customerNumber);

                    if (customer != null)
                    {
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

                    BookModel book = _bookService.GetBookByName(bookName);

                    if (book != null)
                    {
                        _selectedBookId = book.BookID;

                        txtAuthor.Text = book.Author;
                        txtPrize.Text = book.Price.ToString("F2");

                        txtOrderQty.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Book not found. Please enter a valid book name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _selectedBookId = Guid.Empty;
                    }
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


        private void cmbOrderMethod_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbOrderMethod.SelectedItem != null)
            {
                string selectedMethod = cmbOrderMethod.SelectedItem.ToString();

                if (selectedMethod == "POS")
                {
                    groupBoxOnlineOrder.Visible = false;
                }
                else if (selectedMethod == "Online")
                {
                    groupBoxOnlineOrder.Visible = true;
                    groupBoxPosOrders.Visible = false;
                }
            }
        }

        private void cmbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDiscount.SelectedItem != null)
            {
                decimal subTotal = CalculateSubTotalAmount();

                if (int.TryParse(cmbDiscount.SelectedItem.ToString(), out int discountPercentage))
                {
                    decimal discountAmount = (subTotal * discountPercentage) / 100;
                    decimal total = subTotal - discountAmount;

                    txtOrderTotal.Text = total.ToString("F2");
                }
            }
        }

        private void btnAddtoOrderCart_Click_1(object sender, EventArgs e)
        {
            string bookName = txtBookName.Text.Trim();
            string author = txtAuthor.Text.Trim();
            decimal price = 0;
            int quantity = 0;

            if (string.IsNullOrEmpty(bookName) || string.IsNullOrEmpty(author) ||
                !decimal.TryParse(txtPrize.Text, out price) || !int.TryParse(txtOrderQty.Text, out quantity))
            {
                MessageBox.Show("Please fill in all the fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool bookExists = false;
            foreach (DataGridViewRow row in tblOrderCart.Rows)
            {
                if (row.Cells["BookName"].Value != null && row.Cells["BookName"].Value.ToString() == bookName &&
                    row.Cells["Author"].Value != null && row.Cells["Author"].Value.ToString() == author)
                {
                    row.Cells["Quantity"].Value = Convert.ToInt32(row.Cells["Quantity"].Value) + quantity;
                    bookExists = true;
                    break;
                }
            }

            if (!bookExists)
            {
                tblOrderCart.Rows.Add(_selectedBookId, bookName, author, price.ToString("F2"), quantity);
            }

            txtBookName.Clear();
            txtAuthor.Clear();
            txtPrize.Clear();
            txtOrderQty.Clear();
            _selectedBookId = Guid.Empty;


            txtBookName.Focus();



            CalculateSubTotalAmount();
        }

        private void tblOrderCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.ColumnIndex == tblOrderCart.Columns["Remove"].Index && e.RowIndex >= 0)
                {
                    try
                    {
                        tblOrderCart.Rows.RemoveAt(e.RowIndex);

                        CalculateSubTotalAmount();
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show("Cannot remove the new row.", "Error");
                    }
                }
                else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = tblOrderCart.Rows[e.RowIndex];

                    txtBookName.Text = selectedRow.Cells["BookName"].Value?.ToString() ?? "";
                    txtAuthor.Text = selectedRow.Cells["Author"].Value?.ToString() ?? "";
                    txtPrize.Text = selectedRow.Cells["Price"].Value?.ToString() ?? "";

                    txtOrderQty.Clear();
                }
            }
        }

        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtOrderTotal.Text, out decimal orderTotal) && decimal.TryParse(txtAmountPaid.Text, out decimal amountPaid))
            {
                decimal change = amountPaid - orderTotal;
                txtChange.Text = change.ToString("F2");
            }
            else
            {
                txtChange.Text = "0.00";
            }

        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
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
                decimal amountPaid = decimal.TryParse(txtAmountPaid.Text, out decimal paid) ? paid : 0;
                decimal changeAmount = decimal.TryParse(txtChange.Text, out decimal change) ? change : 0;
                OrderModel order = new OrderModel
                {
                    OrderID = txtOrderId.Text,
                    CustomerID = customerId,
                    TotalAmount = totalAmount,
                    OrderDate = orderDate,
                    OrderSource = OrderSource,
                };

                // Set Status, Delivery, and ProcessedBy based on Order Type
                if (OrderSource == "POS")
                {
                    order.Status = null;
                    order.DeliveryStatus = null;
                    order.DeliveryAddress = null;
                    order.ProcessedBy = txtOrderUserName.Text.Trim();

                }
                // Explicitly check for "Online"
                else if (OrderSource == "Online")
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

                List<OrderDetailsModel> orderDetails = new List<OrderDetailsModel>();
                foreach (DataGridViewRow row in tblOrderCart.Rows)
                {
                    if (row.Cells["BookID"].Value != null && row.Cells["Quantity"].Value != null && row.Cells["Price"].Value != null)
                    {
                        OrderDetailsModel orderDetail = new OrderDetailsModel
                        {
                            OrderDetailID = Guid.NewGuid(),
                            OrderId = order.OrderID,
                            BookID = new Guid(row.Cells["BookID"].Value.ToString()),
                            Quantity = int.Parse(row.Cells["Quantity"].Value.ToString()),
                            Price = decimal.Parse(row.Cells["Price"].Value.ToString())
                        };
                        orderDetails.Add(orderDetail);
                    }
                }

                _orderService.AddOrder(order, orderDetails);

                MessageBox.Show("Order successfully placed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            receipt.AppendLine($"Date: {order.OrderDate:yyyy-MM-dd HH:mm:ss}");
            receipt.AppendLine();

            // Items Header
            receipt.AppendLine("--- Order Items ---");
            receipt.AppendLine("-------------------------------");
            receipt.AppendLine("Item ID | Qty |    Price");
            receipt.AppendLine("-------------------------------");

            // Order Details
            foreach (var detail in orderDetails)
            {
                receipt.AppendLine($"{detail.BookID,-7} | {detail.Quantity,-3} | {detail.Price,8:C}");
            }

            receipt.AppendLine("-------------------------------");

            // Total
            receipt.AppendLine();
            receipt.AppendLine($"Total: {order.TotalAmount,25:C}");

            // Footer
            receipt.AppendLine("===============================");
            receipt.AppendLine("     Thank You For Your      ");
            receipt.AppendLine("          Purchase!          ");
            receipt.AppendLine("===============================");

            MessageBox.Show(receipt.ToString(), "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void ClearOrderForm()
        {
            txtCustomerNumber.Clear();
            txtCustomerName.Clear();
            txtOrderTotal.Clear();
            tblOrderCart.Rows.Clear();
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
