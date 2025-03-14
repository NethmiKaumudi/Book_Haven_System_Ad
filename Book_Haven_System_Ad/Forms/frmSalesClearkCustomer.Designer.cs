namespace Book_Haven_System_Ad.Forms
{
    partial class frmSalesClearkCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesClearkCustomer));
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnSave = new Button();
            txtCustomerId = new TextBox();
            txtCustomerName = new TextBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            label5 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tblCustomers = new DataGridView();
            txtSerach = new TextBox();
            DashboardPanel = new Panel();
            ButtonPanel = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox9 = new PictureBox();
            picLogout = new PictureBox();
            lbldate = new Label();
            lblusernameRole = new Label();
            label2 = new Label();
            btnDashboard = new Button();
            pictureBox5 = new PictureBox();
            btnSalespos = new Button();
            btnCustomers = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblCustomers).BeginInit();
            DashboardPanel.SuspendLayout();
            ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 12);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 0;
            label1.Text = "Customer Management";
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
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(txtCustomerId);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Location = new Point(55, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(901, 192);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(143, 132);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 41);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtCustomerId
            // 
            txtCustomerId.BackColor = Color.MintCream;
            txtCustomerId.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerId.ForeColor = Color.Black;
            txtCustomerId.Location = new Point(41, 39);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.PlaceholderText = "Customer Id ";
            txtCustomerId.ReadOnly = true;
            txtCustomerId.Size = new Size(174, 27);
            txtCustomerId.TabIndex = 27;
            // 
            // txtCustomerName
            // 
            txtCustomerName.BackColor = Color.MintCream;
            txtCustomerName.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerName.ForeColor = Color.Black;
            txtCustomerName.Location = new Point(232, 39);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Name ";
            txtCustomerName.Size = new Size(259, 27);
            txtCustomerName.TabIndex = 28;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Chocolate;
            btnEdit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ActiveCaptionText;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(299, 132);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(131, 41);
            btnEdit.TabIndex = 33;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(460, 132);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 41);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Sienna;
            btnClear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.ImageAlign = ContentAlignment.MiddleLeft;
            btnClear.Location = new Point(612, 132);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(131, 41);
            btnClear.TabIndex = 35;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(37, 11);
            label5.Name = "label5";
            label5.Size = new Size(113, 23);
            label5.TabIndex = 27;
            label5.Text = "Customer Id :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(229, 11);
            label6.Name = "label6";
            label6.Size = new Size(144, 23);
            label6.TabIndex = 36;
            label6.Text = "Customer Name :";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.MintCream;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(522, 39);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email ";
            txtEmail.Size = new Size(310, 27);
            txtEmail.TabIndex = 37;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.MintCream;
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.ForeColor = Color.Black;
            txtPhoneNumber.Location = new Point(41, 99);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtPhoneNumber.Size = new Size(213, 27);
            txtPhoneNumber.TabIndex = 38;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.MintCream;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.ForeColor = Color.Black;
            txtAddress.Location = new Point(293, 99);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(246, 27);
            txtAddress.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.Location = new Point(520, 11);
            label7.Name = "label7";
            label7.Size = new Size(60, 23);
            label7.TabIndex = 41;
            label7.Text = "Email :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.Location = new Point(38, 73);
            label8.Name = "label8";
            label8.Size = new Size(131, 23);
            label8.TabIndex = 42;
            label8.Text = "PhoneNumber :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.Location = new Point(290, 73);
            label9.Name = "label9";
            label9.Size = new Size(79, 23);
            label9.TabIndex = 43;
            label9.Text = "Address :";
            // 
            // tblCustomers
            // 
            tblCustomers.BackgroundColor = Color.Gainsboro;
            tblCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblCustomers.Location = new Point(55, 297);
            tblCustomers.Name = "tblCustomers";
            tblCustomers.RowHeadersWidth = 51;
            tblCustomers.Size = new Size(901, 339);
            tblCustomers.TabIndex = 2;
            tblCustomers.CellContentClick += tblCustomers_CellContentClick;
            // 
            // txtSerach
            // 
            txtSerach.BackColor = Color.MintCream;
            txtSerach.BorderStyle = BorderStyle.FixedSingle;
            txtSerach.ForeColor = Color.Black;
            txtSerach.Location = new Point(55, 254);
            txtSerach.Name = "txtSerach";
            txtSerach.PlaceholderText = "Serach ";
            txtSerach.Size = new Size(272, 27);
            txtSerach.TabIndex = 3;
            txtSerach.TextChanged += txtSerach_TextChanged;
            // 
            // DashboardPanel
            // 
            DashboardPanel.BackColor = Color.White;
            DashboardPanel.Controls.Add(txtSerach);
            DashboardPanel.Controls.Add(tblCustomers);
            DashboardPanel.Controls.Add(groupBox1);
            DashboardPanel.Controls.Add(label1);
            DashboardPanel.Location = new Point(342, 1);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.Size = new Size(983, 662);
            DashboardPanel.TabIndex = 13;
            // 
            // ButtonPanel
            // 
            ButtonPanel.BackColor = Color.DarkGreen;
            ButtonPanel.Controls.Add(pictureBox1);
            ButtonPanel.Controls.Add(pictureBox9);
            ButtonPanel.Controls.Add(picLogout);
            ButtonPanel.Controls.Add(lbldate);
            ButtonPanel.Controls.Add(lblusernameRole);
            ButtonPanel.Controls.Add(label2);
            ButtonPanel.Controls.Add(btnDashboard);
            ButtonPanel.Controls.Add(pictureBox5);
            ButtonPanel.Controls.Add(btnSalespos);
            ButtonPanel.Controls.Add(btnCustomers);
            ButtonPanel.Location = new Point(1, 1);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(348, 662);
            ButtonPanel.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Location = new Point(70, 218);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 42);
            pictureBox1.TabIndex = 83;
            pictureBox1.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Location = new Point(70, 139);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(37, 42);
            pictureBox9.TabIndex = 79;
            pictureBox9.TabStop = false;
            // 
            // picLogout
            // 
            picLogout.BackColor = Color.Transparent;
            picLogout.BackgroundImage = (Image)resources.GetObject("picLogout.BackgroundImage");
            picLogout.BackgroundImageLayout = ImageLayout.Zoom;
            picLogout.ErrorImage = null;
            picLogout.Location = new Point(261, 57);
            picLogout.Name = "picLogout";
            picLogout.Size = new Size(62, 55);
            picLogout.TabIndex = 22;
            picLogout.TabStop = false;
            picLogout.Click += picLogout_Click;
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbldate.ForeColor = SystemColors.ButtonFace;
            lbldate.Location = new Point(24, 57);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(0, 23);
            lbldate.TabIndex = 21;
            // 
            // lblusernameRole
            // 
            lblusernameRole.AutoSize = true;
            lblusernameRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblusernameRole.ForeColor = SystemColors.ButtonFace;
            lblusernameRole.Location = new Point(186, 21);
            lblusernameRole.Name = "lblusernameRole";
            lblusernameRole.Size = new Size(0, 23);
            lblusernameRole.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(24, 16);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 19;
            label2.Text = "Dashboard";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Green;
            btnDashboard.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.ActiveCaptionText;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(138, 147);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(157, 32);
            btnDashboard.TabIndex = 39;
            btnDashboard.Text = "Dasboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(70, 297);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 42);
            pictureBox5.TabIndex = 71;
            pictureBox5.TabStop = false;
            // 
            // btnSalespos
            // 
            btnSalespos.BackColor = Color.White;
            btnSalespos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalespos.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalespos.Location = new Point(138, 297);
            btnSalespos.Name = "btnSalespos";
            btnSalespos.Size = new Size(157, 32);
            btnSalespos.TabIndex = 35;
            btnSalespos.Text = "Sales(Pos)";
            btnSalespos.UseVisualStyleBackColor = false;
            btnSalespos.Click += btnSalespos_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(138, 218);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(157, 32);
            btnCustomers.TabIndex = 29;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // frmSalesClearkCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 661);
            Controls.Add(ButtonPanel);
            Controls.Add(DashboardPanel);
            Name = "frmSalesClearkCustomer";
            Text = "frmSalesClearkCustomer";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblCustomers).EndInit();
            DashboardPanel.ResumeLayout(false);
            DashboardPanel.PerformLayout();
            ButtonPanel.ResumeLayout(false);
            ButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtAddress;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private Label label6;
        private Label label5;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtCustomerName;
        private TextBox txtCustomerId;
        private Button btnSave;
        private DataGridView tblCustomers;
        private TextBox txtSerach;
        private Panel DashboardPanel;
        private Panel ButtonPanel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox9;
        private PictureBox picLogout;
        private Label lbldate;
        private Label lblusernameRole;
        private Label label2;
        private Button btnDashboard;
        private PictureBox pictureBox5;
        private Button btnSalespos;
        private Button btnCustomers;
    }
}