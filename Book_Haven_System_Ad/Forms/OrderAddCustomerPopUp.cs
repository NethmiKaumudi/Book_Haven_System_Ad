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
    public partial class frmOrderAddCustomerPopUp : Form
    {
        private readonly ICustomerService _customerService;

        public frmOrderAddCustomerPopUp()
        {
            InitializeComponent();
            _customerService = new CustomerService();

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
                 ClearFields();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the customer.\nDetails: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            txtCustomerId.Text = "";
            txtCustomerName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
        }
    }
}
