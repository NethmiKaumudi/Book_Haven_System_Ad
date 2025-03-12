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

    public partial class frmSupplierForm : Form
    {
        private readonly ISupplierService _supplierService;
        public frmSupplierForm()
        {
            InitializeComponent();
            _supplierService = new SupplierService();
            LoadSuppliers();
        }
        private bool ValidateSupplierFields()
        {
            ResetFieldBorders();

            bool isValid = true;

            try
            {
                // Supplier Name validation
                if (string.IsNullOrWhiteSpace(txtSupplierName.Text) ||
                    txtSupplierName.Text.Length < 3 ||
                    !Regex.IsMatch(txtSupplierName.Text, @"^[a-zA-Z\s]+$"))
                {
                    txtSupplierName.BackColor = Color.LightCoral;
                    throw new Exception("Supplier Name is required and must be at least 3 characters long, containing only letters and spaces.");
                }

                // Contact Person Name validation
                if (string.IsNullOrWhiteSpace(txtConatctPersonName.Text) ||
                    txtConatctPersonName.Text.Length < 3 ||
                    !Regex.IsMatch(txtConatctPersonName.Text, @"^[a-zA-Z\s]+$"))
                {
                    txtConatctPersonName.BackColor = Color.LightCoral;
                    throw new Exception("Contact Person Name is required and must be at least 3 characters long, containing only letters and spaces.");
                }

                // Supplier Email validation
                if (!Regex.IsMatch(txtContactEmail.Text, @"^[a-zA-Z0-9._%+-]+@(gmail\.com|yahoo\.com|outlook\.com)$"))
                {
                    txtContactEmail.BackColor = Color.LightCoral;
                    throw new Exception("Enter a valid email address (Only @gmail.com, @yahoo.com, @outlook.com are allowed).");
                }

                // Supplier Phone Number validation (Valid Sri Lankan phone number)
                if (!Regex.IsMatch(txtContactPhoneNumber.Text, @"^(?:07\d{8}|\+94-7\d{8})$"))
                {
                    txtContactPhoneNumber.BackColor = Color.LightCoral;
                    throw new Exception("Enter a valid Sri Lankan phone number (e.g., 0765814060 or +94-765814060).");
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
            // Reset background color for all supplier-related fields to white
            txtSupplierName.BackColor = Color.White;
            txtConatctPersonName.BackColor = Color.White;
            txtContactEmail.BackColor = Color.White;
            txtContactPhoneNumber.BackColor = Color.White;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateSupplierFields()) return;

            try
            {
                // Create a new SupplierModel object from the form inputs
                var supplier = new SupplierModel
                {
                    SupplierName = txtSupplierName.Text,
                    ContactName = txtConatctPersonName.Text,
                    ContactEmail = txtContactEmail.Text,
                    ContactPhone = txtContactPhoneNumber.Text,
                    IsDeleted = false // assuming you have a flag for logical deletion
                };

                // Save the new supplier
                _supplierService.Add(supplier);

                // Show success message
                MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload suppliers list
                LoadSuppliers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the supplier. Details: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSupplierId.Text))
            {
                MessageBox.Show("Supplier ID is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var supplierId = Guid.Parse(txtSupplierId.Text);

                // Fetch the existing supplier
                var existingSupplier = _supplierService.GetById(supplierId);

                if (existingSupplier == null)
                {
                    MessageBox.Show("Supplier not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update the fields only if they have changed
                var updatedSupplier = new SupplierModel
                {
                    SupplierID = supplierId,
                    SupplierName = txtSupplierName.Text != existingSupplier.SupplierName ? txtSupplierName.Text : existingSupplier.SupplierName,
                    ContactName = txtConatctPersonName.Text != existingSupplier.ContactName ? txtConatctPersonName.Text : existingSupplier.ContactName,
                    ContactEmail = txtContactEmail.Text != existingSupplier.ContactEmail ? txtContactEmail.Text : existingSupplier.ContactEmail,
                    ContactPhone = txtContactPhoneNumber.Text != existingSupplier.ContactPhone ? txtContactPhoneNumber.Text : existingSupplier.ContactPhone
                };

                // Save the updated supplier
                _supplierService.Update(updatedSupplier);

                // Reload the suppliers list to reflect changes
                LoadSuppliers();

                MessageBox.Show("Supplier updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields(); // Optionally clear fields after updating
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid Supplier ID format. Please ensure the ID is a valid GUID. Error: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierId.Text))
            {
                MessageBox.Show("Please select a supplier to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var supplierId = Guid.Parse(txtSupplierId.Text);
                    _supplierService.SoftDelete(supplierId);

                    LoadSuppliers();

                    MessageBox.Show("Supplier deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();

        }


        private void tblSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = tblSuppliers.Rows[e.RowIndex];

                txtSupplierId.Text = row.Cells["SupplierID"].Value.ToString();
                txtSupplierName.Text = row.Cells["SupplierName"].Value.ToString();
                txtConatctPersonName.Text = row.Cells["ContactName"].Value.ToString();
                txtContactEmail.Text = row.Cells["ContactEmail"].Value.ToString();
                txtContactPhoneNumber.Text = row.Cells["ContactPhone"].Value.ToString();
            }
        }
        private void LoadSuppliers()
        {
            try
            {
                // Get all suppliers from the service
                var suppliers = _supplierService.GetAll();

                // Bind the suppliers list to the DataGridView
                tblSuppliers.DataSource = suppliers;

                // Set header texts for the relevant columns
                tblSuppliers.Columns["SupplierID"].HeaderText = "Supplier ID";
                tblSuppliers.Columns["SupplierName"].HeaderText = "Supplier Name";
                tblSuppliers.Columns["ContactName"].HeaderText = "Contact Person";
                tblSuppliers.Columns["ContactPhone"].HeaderText = "Phone Number";
                tblSuppliers.Columns["ContactEmail"].HeaderText = "Email Address";

                // Hide unnecessary columns
                foreach (DataGridViewColumn column in tblSuppliers.Columns)
                {
                    if (column.Name != "SupplierID" && column.Name != "SupplierName" && column.Name != "ContactName" &&
                        column.Name != "ContactPhone" && column.Name != "ContactEmail" )
                    {
                        column.Visible = false;
                    }
                }

                // Auto-size columns to fit the DataGridView width
                tblSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading suppliers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ClearFields()
        {
            txtSupplierId.Text = "";
            txtSupplierName.Text = "";
            txtConatctPersonName.Text = "";
            txtContactEmail.Text = "";
            txtContactPhoneNumber.Text = "";
        }

        private void txtSerach_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSerach.Text.Trim().ToLower();

            // If the search query is empty, reset the list or show all records
            if (string.IsNullOrEmpty(searchQuery))
            {
                // Example: Show all suppliers or reload the original list
                LoadSuppliers();
                return;
            }

            // Filter suppliers or items based on the search query
            var filteredSuppliers = _supplierService.GetAll()
                .Where(s => s.SupplierName.ToLower().Contains(searchQuery) ||
                            s.ContactName.ToLower().Contains(searchQuery) ||
                            s.ContactEmail.ToLower().Contains(searchQuery) ||
                            s.ContactPhone.Contains(searchQuery))
                .ToList();

            // Display the filtered list (this may vary depending on your UI setup)
            tblSuppliers.DataSource = filteredSuppliers;

        }
    }
}
