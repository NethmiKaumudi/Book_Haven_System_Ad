namespace Book_Haven_System_Ad.Forms
{
    partial class frmOrderAddCustomerPopUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtCustomerName = new TextBox();
            txtCustomerId = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(txtCustomerId);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Location = new Point(31, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 310);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.Location = new Point(35, 176);
            label9.Name = "label9";
            label9.Size = new Size(79, 23);
            label9.TabIndex = 43;
            label9.Text = "Address :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.Location = new Point(36, 139);
            label8.Name = "label8";
            label8.Size = new Size(131, 23);
            label8.TabIndex = 42;
            label8.Text = "PhoneNumber :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.Location = new Point(38, 95);
            label7.Name = "label7";
            label7.Size = new Size(60, 23);
            label7.TabIndex = 41;
            label7.Text = "Email :";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.MintCream;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.ForeColor = Color.Black;
            txtAddress.Location = new Point(194, 177);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(246, 27);
            txtAddress.TabIndex = 39;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.MintCream;
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.ForeColor = Color.Black;
            txtPhoneNumber.Location = new Point(194, 138);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtPhoneNumber.Size = new Size(213, 27);
            txtPhoneNumber.TabIndex = 38;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.MintCream;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(194, 97);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email ";
            txtEmail.Size = new Size(310, 27);
            txtEmail.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(37, 59);
            label6.Name = "label6";
            label6.Size = new Size(144, 23);
            label6.TabIndex = 36;
            label6.Text = "Customer Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(37, 23);
            label5.Name = "label5";
            label5.Size = new Size(113, 23);
            label5.TabIndex = 27;
            label5.Text = "Customer Id :";
            // 
            // txtCustomerName
            // 
            txtCustomerName.BackColor = Color.MintCream;
            txtCustomerName.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerName.ForeColor = Color.Black;
            txtCustomerName.Location = new Point(194, 54);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Name ";
            txtCustomerName.Size = new Size(259, 27);
            txtCustomerName.TabIndex = 28;
            // 
            // txtCustomerId
            // 
            txtCustomerId.BackColor = Color.MintCream;
            txtCustomerId.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerId.ForeColor = Color.Black;
            txtCustomerId.Location = new Point(194, 21);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.PlaceholderText = "Customer Id ";
            txtCustomerId.ReadOnly = true;
            txtCustomerId.Size = new Size(174, 27);
            txtCustomerId.TabIndex = 27;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(176, 237);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 41);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, -4);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 2;
            label1.Text = "Customer Management";
            // 
            // frmOrderAddCustomerPopUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 363);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmOrderAddCustomerPopUp";
            Text = "OrderAddCustomerPopUp";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtAddress;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private Label label6;
        private Label label5;
        private TextBox txtCustomerName;
        private TextBox txtCustomerId;
        private Button btnSave;
        private Label label1;
    }
}