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

namespace Book_Haven_System_Ad.Forms
{
    public partial class frmSalesDetailsForm : Form
    {
        private readonly IOrderService _orderService;
        public string Username { get; set; }
        public string Role { get; set; }
        public frmSalesDetailsForm()
        {
            InitializeComponent();
            _orderService = new OrderService();
            LoadOrderDetails();

        }

        private void LoadOrderDetails()
        {
            try
            {
                List<OrderModel> orders = _orderService.GetAllOrders();

                DataTable dt = new DataTable();
                dt.Columns.Add("Order ID");
                dt.Columns.Add("Customer ID");
                dt.Columns.Add("Total Amount");
                dt.Columns.Add("Status");
                dt.Columns.Add("DeliveryType");
                dt.Columns.Add("DeliveryStatus");
                dt.Columns.Add("Order Date");
                dt.Columns.Add("Processed By");

                if (orders.Count > 0)
                {
                    foreach (var order in orders)
                    {
                        dt.Rows.Add(
                            order.OrderID ?? "No Data",
                            order.CustomerID != Guid.Empty ? order.CustomerID.ToString() : "No Data",
                            order.TotalAmount > 0 ? order.TotalAmount.ToString("N2") : "No Data",
                            !string.IsNullOrEmpty(order.Status) ? order.Status : "No Data",
                            !string.IsNullOrEmpty(order.DeliveryType) ? order.DeliveryType : "No Data",
                            !string.IsNullOrEmpty(order.DeliveryStatus) ? order.DeliveryStatus : "No Data",
                            order.OrderDate != DateTime.MinValue ? order.OrderDate.ToString("yyyy-MM-dd") : "No Data",
                            !string.IsNullOrEmpty(order.ProcessedBy) ? order.ProcessedBy : "No Data"
                        );
                    }
                }
                else
                {
                    dt.Rows.Add("No Data", "No Data", "No Data", "No Data", "No Data", "No Data", "No Data", "No Data");
                }

                tblOrderDetails.DataSource = dt;
                AddActionButtons();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void AddActionButtons()
        {
            if (tblOrderDetails.Columns["Edit"] == null)
            {
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
                {
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true,
                    Name = "Edit",
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        BackColor = Color.LightBlue // Background color for Edit button
                    }
                };

                tblOrderDetails.Columns.Add(editButton);
            }

            if (tblOrderDetails.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                {
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    Name = "Delete",
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        BackColor = Color.OrangeRed // Background color for Delete button
                    }
                };

                tblOrderDetails.Columns.Add(deleteButton);
            }
        }



        private void tblOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure valid row and column indices
            {
                string orderId = tblOrderDetails.Rows[e.RowIndex].Cells["Order ID"].Value?.ToString(); // Use ?. to avoid null exceptions

                if (string.IsNullOrEmpty(orderId) || orderId == "No Data")
                {
                    MessageBox.Show("No data available for this action.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (tblOrderDetails.Columns[e.ColumnIndex].Name == "Edit")
                {
                    var selectedRow = tblOrderDetails.Rows[e.RowIndex]; // Assign to the field

                    string currentStatus = selectedRow.Cells["Status"].Value?.ToString();
                    string currentDeliveryType = selectedRow.Cells["DeliveryType"].Value?.ToString();
                    string currentDeliveryStatus = selectedRow.Cells["DeliveryStatus"].Value?.ToString();

                    Form editForm = new Form
                    {
                        Text = "Edit Order",
                        Width = 400,
                        Height = 250,
                        FormBorderStyle = FormBorderStyle.FixedDialog,
                        StartPosition = FormStartPosition.CenterScreen
                    };

                    Label lblStatus = new Label() { Text = "Status:", Left = 20, Top = 20, Width = 100 };
                    ComboBox cmbStatus = new ComboBox() { Left = 150, Top = 20, Width = 200 };
                    cmbStatus.Items.AddRange(new string[] { "Pending", "Shipped", "Delivered", "Canceled" });
                    cmbStatus.SelectedItem = currentStatus;

                    Label lblDeliveryType = new Label() { Text = "Delivery Type:", Left = 20, Top = 60, Width = 100 };
                    ComboBox cmbDeliveryType = new ComboBox() { Left = 150, Top = 60, Width = 200 };
                    cmbDeliveryType.Items.AddRange(new string[] { "In-Store Pickup", "Home Delivery" });
                    cmbDeliveryType.SelectedItem = currentDeliveryType;

                    Label lblDeliveryStatus = new Label() { Text = "Delivery Status:", Left = 20, Top = 100, Width = 100 };
                    ComboBox cmbDeliveryStatus = new ComboBox() { Left = 150, Top = 100, Width = 200 };
                    cmbDeliveryStatus.Items.AddRange(new string[] { "Not Applicable", "Processing", "Out for Delivery", "Delivered" });
                    cmbDeliveryStatus.SelectedItem = currentDeliveryStatus;

                    Button btnSave = new Button() { Text = "Save", Left = 80, Width = 100, Height = 40, Top = 150 };
                    Button btnCancel = new Button() { Text = "Cancel", Left = 200, Width = 100, Height = 40, Top = 150 };

                    btnSave.Click += (saveSender, saveE) =>
                    {
                        if (selectedRow != null)
                        {
                            selectedRow.Cells["Status"].Value = cmbStatus.SelectedItem?.ToString();
                            selectedRow.Cells["DeliveryType"].Value = cmbDeliveryType.SelectedItem?.ToString();
                            selectedRow.Cells["DeliveryStatus"].Value = cmbDeliveryStatus.SelectedItem?.ToString();

                            _orderService.EditOrder(new OrderModel
                            {
                                OrderID = orderId,
                                Status = cmbStatus.SelectedItem?.ToString(),
                                DeliveryType = cmbDeliveryType.SelectedItem?.ToString(),
                                DeliveryStatus = cmbDeliveryStatus.SelectedItem?.ToString()
                            });

                            MessageBox.Show("Order updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadOrderDetails(); // Reload data after update
                            editForm.Close();
                        }
                    };

                    btnCancel.Click += (cancelSender, cancelE) => { editForm.Close(); };

                    editForm.Controls.Add(lblStatus);
                    editForm.Controls.Add(cmbStatus);
                    editForm.Controls.Add(lblDeliveryType);
                    editForm.Controls.Add(cmbDeliveryType);
                    editForm.Controls.Add(lblDeliveryStatus);
                    editForm.Controls.Add(cmbDeliveryStatus);
                    editForm.Controls.Add(btnSave);
                    editForm.Controls.Add(btnCancel);

                    editForm.ShowDialog();
                }
                else if (tblOrderDetails.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to soft delete Order {orderId}?", "Confirm Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        _orderService.SoftDeleteOrder(orderId);
                        LoadOrderDetails();
                    }
                }
            }

        }

        private void txtSerach_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSerach.Text.Trim().ToLower();

            // If the search query is empty, reset the list or show all records
            if (string.IsNullOrEmpty(searchQuery))
            {
                // Example: Show all orders or reload the original list
                LoadOrderDetails(); // Reload original data
                return;
            }

            try
            {
                // Filter orders based on the search query
                List<OrderModel> filteredOrders = _orderService.GetAllOrders()
                    .Where(o =>
                        (o.OrderID != null && o.OrderID.ToLower().Contains(searchQuery)) ||
                        (o.CustomerID != Guid.Empty && o.CustomerID.ToString().ToLower().Contains(searchQuery)) ||
                        (o.TotalAmount.ToString().ToLower().Contains(searchQuery)) ||
                        (o.Status != null && o.Status.ToLower().Contains(searchQuery)) ||
                        (o.DeliveryType != null && o.DeliveryType.ToLower().Contains(searchQuery)) ||
                        (o.DeliveryStatus != null && o.DeliveryStatus.ToLower().Contains(searchQuery)) ||
                        (o.OrderDate != DateTime.MinValue && o.OrderDate.ToString("yyyy-MM-dd").ToLower().Contains(searchQuery)) ||
                        (o.ProcessedBy != null && o.ProcessedBy.ToLower().Contains(searchQuery))
                    )
                    .ToList();

                // Display the filtered list
                DataTable dt = new DataTable();
                dt.Columns.Add("Order ID");
                dt.Columns.Add("Customer ID");
                dt.Columns.Add("Total Amount");
                dt.Columns.Add("Status");
                dt.Columns.Add("DeliveryType");
                dt.Columns.Add("DeliveryStatus");
                dt.Columns.Add("Order Date");
                dt.Columns.Add("Processed By");

                if (filteredOrders.Count > 0)
                {
                    foreach (var order in filteredOrders)
                    {
                        dt.Rows.Add(
                            order.OrderID ?? "No Data",
                            order.CustomerID != Guid.Empty ? order.CustomerID.ToString() : "No Data",
                            order.TotalAmount > 0 ? order.TotalAmount.ToString("N2") : "No Data",
                            !string.IsNullOrEmpty(order.Status) ? order.Status : "No Data",
                            !string.IsNullOrEmpty(order.DeliveryType) ? order.DeliveryType : "No Data",
                            !string.IsNullOrEmpty(order.DeliveryStatus) ? order.DeliveryStatus : "No Data",
                            order.OrderDate != DateTime.MinValue ? order.OrderDate.ToString("yyyy-MM-dd") : "No Data",
                            !string.IsNullOrEmpty(order.ProcessedBy) ? order.ProcessedBy : "No Data"
                        );
                    }
                }
                else
                {
                    dt.Rows.Add("No Data", "No Data", "No Data", "No Data", "No Data", "No Data", "No Data", "No Data");
                }

                tblOrderDetails.DataSource = dt;
                AddActionButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
