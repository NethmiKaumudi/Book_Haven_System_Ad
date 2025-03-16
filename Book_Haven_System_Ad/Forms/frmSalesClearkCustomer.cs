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
    public partial class frmSalesClearkCustomer : Form
    {
        private readonly ICustomerService _customerService;
        public string Username { get; set; }
        public string Role { get; set; }
        public frmSalesClearkCustomer()
        {
            InitializeComponent();
            Username = UserSession.Instance.Username;
            Role = UserSession.Instance.Role;

            lblusernameRole.Text = $"{Username} - {Role}";
            lbldate.Text = $"Today: {DateTime.Now:yyyy-MM-dd}";
            _customerService = new CustomerService();
            LoadCustomers();
        }
        private bool ValidateFields()
        {
            // Reset all field borders
            ResetFieldBorders();

            bool isValid = true;

            try
            {
                // Name validation
                if (string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                    txtCustomerName.Text.Length < 3 ||
                    !Regex.IsMatch(txtCustomerName.Text, @"^[a-zA-Z\s]+$"))
                {
                    txtCustomerName.BackColor = Color.LightCoral;
                    throw new Exception("Name is required and must be at least 3 characters long, containing only letters and spaces.");
                }

                // Email validation
                if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z0-9._%+-]+@(gmail\.com|yahoo\.com|outlook\.com)$"))
                {
                    txtEmail.BackColor = Color.LightCoral;
                    throw new Exception("Enter a valid email address (Only @gmail.com, @yahoo.com, @outlook.com are allowed).");
                }

                // Phone number validation
                if (!Regex.IsMatch(txtPhoneNumber.Text, @"^(?:07\d{8}|\+94-7\d{8})$"))
                {
                    txtPhoneNumber.BackColor = Color.LightCoral;
                    throw new Exception("Enter a valid Sri Lankan phone number (e.g., 0765814060 or +94-765814060).");
                }

                // Address validation
                if (string.IsNullOrWhiteSpace(txtAddress.Text) || txtAddress.Text.Length < 5)
                {
                    txtAddress.BackColor = Color.LightCoral;
                    throw new Exception("Address is required and must be at least 5 characters long.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            return isValid;
        }

        private void ResetFieldBorders()
        {
            txtCustomerName.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            txtPhoneNumber.BackColor = Color.White;
            txtAddress.BackColor = Color.White;
        }
        private void LoadCustomers()
        {
            try
            {
                var customers = _customerService.GetAllCustomers().Where(c => !c.IsDeleted).ToList();
                tblCustomers.DataSource = customers;

                tblCustomers.Columns["CustomerID"].HeaderText = "Customer ID";
                tblCustomers.Columns["Name"].HeaderText = "Name";
                tblCustomers.Columns["Email"].HeaderText = "Email";
                tblCustomers.Columns["Phone"].HeaderText = "Phone";
                tblCustomers.Columns["Address"].HeaderText = "Address";

                foreach (DataGridViewColumn column in tblCustomers.Columns)
                {
                    if (column.Name != "CustomerID" && column.Name != "Name" && column.Name != "Email" &&
                        column.Name != "Phone" && column.Name != "Address")
                    {
                        column.Visible = false;
                    }
                }

                tblCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            try
            {
                var customer = new CustomerModel
                {
                    Name = txtCustomerName.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhoneNumber.Text,
                    Address = txtAddress.Text,
                    IsDeleted = false
                };

                _customerService.Save(customer);
                MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the customer.\nDetails: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCustomerId.Text))
                {
                    MessageBox.Show("Customer ID is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var customerId = Guid.Parse(txtCustomerId.Text);

                var existingCustomer = _customerService.GetCustomerById(customerId);

                if (existingCustomer == null)
                {
                    MessageBox.Show("Customer not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var updatedCustomer = new CustomerModel
                {
                    CustomerID = customerId,
                    Name = txtCustomerName.Text != existingCustomer.Name ? txtCustomerName.Text : existingCustomer.Name,
                    Email = txtEmail.Text != existingCustomer.Email ? txtEmail.Text : existingCustomer.Email,
                    Phone = txtPhoneNumber.Text != existingCustomer.Phone ? txtPhoneNumber.Text : existingCustomer.Phone,
                    Address = txtAddress.Text != existingCustomer.Address ? txtAddress.Text : existingCustomer.Address
                };

                _customerService.Edit(updatedCustomer);

                LoadCustomers();

                MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid Customer ID format. Please ensure the ID is a valid GUID. Error: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtCustomerId.Text))
                {
                    MessageBox.Show("Please select a customer to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var customerId = Guid.Parse(txtCustomerId.Text);

                    _customerService.Delete(customerId);

                    LoadCustomers();

                    MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error: Invalid customer ID format. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtCustomerId.Text = "";
            txtCustomerName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
        }
        private void txtSerach_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSerach.Text.Trim();

            var customers = _customerService.GetAllCustomers().Where(c => !c.IsDeleted).ToList();

            if (string.IsNullOrEmpty(searchTerm))
            {
                tblCustomers.DataSource = customers;
            }
            else
            {
                var filteredCustomers = customers.Where(c => c.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                                              (c.Email != null && c.Email.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)) ||
                                                              (c.Phone != null && c.Phone.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)))
                                                  .ToList();

                tblCustomers.DataSource = filteredCustomers;
            }
        }

        private void tblCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblCustomers.Rows[e.RowIndex];

                txtCustomerId.Text = row.Cells["CustomerID"].Value.ToString();
                txtCustomerName.Text = row.Cells["Name"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["Phone"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
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
    }
}
