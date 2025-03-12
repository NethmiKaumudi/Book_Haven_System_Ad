namespace Book_Haven_System_Ad.Forms
{
    partial class frmSupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierForm));
            DashboardPanel = new Panel();
            groupBox1 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtContactPhoneNumber = new TextBox();
            txtContactEmail = new TextBox();
            txtConatctPersonName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            txtSupplierName = new TextBox();
            txtSupplierId = new TextBox();
            btnSave = new Button();
            txtSerach = new TextBox();
            tblSuppliers = new DataGridView();
            label1 = new Label();
            ButtonPanel = new Panel();
            btnReports = new Button();
            pictureBox8 = new PictureBox();
            picLogout = new PictureBox();
            lbldate = new Label();
            btnSuppliers = new Button();
            pictureBox5 = new PictureBox();
            lblusernameRole = new Label();
            label2 = new Label();
            btnPO = new Button();
            pictureBox9 = new PictureBox();
            btnDashboard = new Button();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            btnSalespos = new Button();
            pictureBox4 = new PictureBox();
            btnOrders = new Button();
            pictureBox3 = new PictureBox();
            btnCustomers = new Button();
            pictureBox2 = new PictureBox();
            btnBooks = new Button();
            pictureBox1 = new PictureBox();
            btnUsers = new Button();
            DashboardPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblSuppliers).BeginInit();
            ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DashboardPanel
            // 
            DashboardPanel.BackColor = Color.White;
            DashboardPanel.Controls.Add(groupBox1);
            DashboardPanel.Controls.Add(txtSerach);
            DashboardPanel.Controls.Add(tblSuppliers);
            DashboardPanel.Controls.Add(label1);
            DashboardPanel.Location = new Point(341, -1);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.Size = new Size(983, 662);
            DashboardPanel.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtContactPhoneNumber);
            groupBox1.Controls.Add(txtContactEmail);
            groupBox1.Controls.Add(txtConatctPersonName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(txtSupplierName);
            groupBox1.Controls.Add(txtSupplierId);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Location = new Point(55, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(901, 192);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.Location = new Point(290, 73);
            label9.Name = "label9";
            label9.Size = new Size(201, 23);
            label9.TabIndex = 43;
            label9.Text = "Conatct Phone Number :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.Location = new Point(38, 73);
            label8.Name = "label8";
            label8.Size = new Size(125, 23);
            label8.TabIndex = 42;
            label8.Text = "Contact Email :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.Location = new Point(519, 11);
            label7.Name = "label7";
            label7.Size = new Size(186, 23);
            label7.TabIndex = 41;
            label7.Text = "Contact Person Name :";
            // 
            // txtContactPhoneNumber
            // 
            txtContactPhoneNumber.BackColor = Color.MintCream;
            txtContactPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtContactPhoneNumber.ForeColor = Color.Black;
            txtContactPhoneNumber.Location = new Point(293, 99);
            txtContactPhoneNumber.Name = "txtContactPhoneNumber";
            txtContactPhoneNumber.PlaceholderText = "Contact Phone Number";
            txtContactPhoneNumber.Size = new Size(246, 27);
            txtContactPhoneNumber.TabIndex = 39;
            // 
            // txtContactEmail
            // 
            txtContactEmail.BackColor = Color.MintCream;
            txtContactEmail.BorderStyle = BorderStyle.FixedSingle;
            txtContactEmail.ForeColor = Color.Black;
            txtContactEmail.Location = new Point(41, 99);
            txtContactEmail.Name = "txtContactEmail";
            txtContactEmail.PlaceholderText = "Contact Email";
            txtContactEmail.Size = new Size(213, 27);
            txtContactEmail.TabIndex = 38;
            // 
            // txtConatctPersonName
            // 
            txtConatctPersonName.BackColor = Color.MintCream;
            txtConatctPersonName.BorderStyle = BorderStyle.FixedSingle;
            txtConatctPersonName.ForeColor = Color.Black;
            txtConatctPersonName.Location = new Point(519, 39);
            txtConatctPersonName.Name = "txtConatctPersonName";
            txtConatctPersonName.PlaceholderText = "Conatct Person Name";
            txtConatctPersonName.Size = new Size(310, 27);
            txtConatctPersonName.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(229, 11);
            label6.Name = "label6";
            label6.Size = new Size(132, 23);
            label6.TabIndex = 36;
            label6.Text = "Supplier Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(37, 11);
            label5.Name = "label5";
            label5.Size = new Size(101, 23);
            label5.TabIndex = 27;
            label5.Text = "Supplier Id :";
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
            // txtSupplierName
            // 
            txtSupplierName.BackColor = Color.MintCream;
            txtSupplierName.BorderStyle = BorderStyle.FixedSingle;
            txtSupplierName.ForeColor = Color.Black;
            txtSupplierName.Location = new Point(232, 39);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.PlaceholderText = "Supplier Name";
            txtSupplierName.Size = new Size(259, 27);
            txtSupplierName.TabIndex = 28;
            // 
            // txtSupplierId
            // 
            txtSupplierId.BackColor = Color.MintCream;
            txtSupplierId.BorderStyle = BorderStyle.FixedSingle;
            txtSupplierId.ForeColor = Color.Black;
            txtSupplierId.Location = new Point(41, 39);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.PlaceholderText = "Supplie Id ";
            txtSupplierId.ReadOnly = true;
            txtSupplierId.Size = new Size(174, 27);
            txtSupplierId.TabIndex = 27;
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
            // tblSuppliers
            // 
            tblSuppliers.BackgroundColor = Color.Gainsboro;
            tblSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblSuppliers.Location = new Point(55, 297);
            tblSuppliers.Name = "tblSuppliers";
            tblSuppliers.RowHeadersWidth = 51;
            tblSuppliers.Size = new Size(901, 339);
            tblSuppliers.TabIndex = 2;
            tblSuppliers.CellContentClick += tblSuppliers_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 12);
            label1.Name = "label1";
            label1.Size = new Size(221, 28);
            label1.TabIndex = 0;
            label1.Text = "Supplier Management";
            // 
            // ButtonPanel
            // 
            ButtonPanel.BackColor = Color.DarkGreen;
            ButtonPanel.Controls.Add(btnReports);
            ButtonPanel.Controls.Add(pictureBox8);
            ButtonPanel.Controls.Add(picLogout);
            ButtonPanel.Controls.Add(lbldate);
            ButtonPanel.Controls.Add(btnSuppliers);
            ButtonPanel.Controls.Add(pictureBox5);
            ButtonPanel.Controls.Add(lblusernameRole);
            ButtonPanel.Controls.Add(label2);
            ButtonPanel.Controls.Add(btnPO);
            ButtonPanel.Controls.Add(pictureBox9);
            ButtonPanel.Controls.Add(btnDashboard);
            ButtonPanel.Controls.Add(pictureBox7);
            ButtonPanel.Controls.Add(pictureBox6);
            ButtonPanel.Controls.Add(btnSalespos);
            ButtonPanel.Controls.Add(pictureBox4);
            ButtonPanel.Controls.Add(btnOrders);
            ButtonPanel.Controls.Add(pictureBox3);
            ButtonPanel.Controls.Add(btnCustomers);
            ButtonPanel.Controls.Add(pictureBox2);
            ButtonPanel.Controls.Add(btnBooks);
            ButtonPanel.Controls.Add(pictureBox1);
            ButtonPanel.Controls.Add(btnUsers);
            ButtonPanel.Location = new Point(0, 0);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(348, 662);
            ButtonPanel.TabIndex = 11;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(128, 602);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(157, 32);
            btnReports.TabIndex = 23;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.Location = new Point(60, 592);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(37, 42);
            pictureBox8.TabIndex = 24;
            pictureBox8.TabStop = false;
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
            // btnSuppliers
            // 
            btnSuppliers.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.Location = new Point(128, 494);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(157, 32);
            btnSuppliers.TabIndex = 9;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(60, 487);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 42);
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
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
            // btnPO
            // 
            btnPO.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPO.ImageAlign = ContentAlignment.MiddleLeft;
            btnPO.Location = new Point(128, 552);
            btnPO.Name = "btnPO";
            btnPO.Size = new Size(157, 32);
            btnPO.TabIndex = 13;
            btnPO.Text = "Purchase Stock";
            btnPO.UseVisualStyleBackColor = true;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Location = new Point(60, 141);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(37, 42);
            pictureBox9.TabIndex = 18;
            pictureBox9.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.ActiveCaptionText;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(128, 148);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(157, 32);
            btnDashboard.TabIndex = 17;
            btnDashboard.Text = "Dasboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(60, 542);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(37, 42);
            pictureBox7.TabIndex = 14;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(60, 426);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 42);
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            // 
            // btnSalespos
            // 
            btnSalespos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalespos.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalespos.Location = new Point(128, 433);
            btnSalespos.Name = "btnSalespos";
            btnSalespos.Size = new Size(157, 32);
            btnSalespos.TabIndex = 11;
            btnSalespos.Text = "Sales(POS)";
            btnSalespos.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(60, 367);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 42);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // btnOrders
            // 
            btnOrders.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(128, 374);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(157, 32);
            btnOrders.TabIndex = 7;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(60, 310);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 42);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // btnCustomers
            // 
            btnCustomers.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(128, 317);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(157, 32);
            btnCustomers.TabIndex = 5;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(60, 250);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 42);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnBooks
            // 
            btnBooks.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooks.ImageAlign = ContentAlignment.MiddleLeft;
            btnBooks.Location = new Point(128, 257);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(157, 32);
            btnBooks.TabIndex = 3;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(60, 197);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 42);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.Green;
            btnUsers.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(128, 204);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(157, 32);
            btnUsers.TabIndex = 1;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = false;
            // 
            // frmSupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 661);
            Controls.Add(ButtonPanel);
            Controls.Add(DashboardPanel);
            Name = "frmSupplierForm";
            Text = "SupplierForm";
            DashboardPanel.ResumeLayout(false);
            DashboardPanel.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblSuppliers).EndInit();
            ButtonPanel.ResumeLayout(false);
            ButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel DashboardPanel;
        private TextBox txtSerach;
        private DataGridView tblSuppliers;
        private Label label1;
        private Panel ButtonPanel;
        private Button btnReports;
        private PictureBox pictureBox8;
        private PictureBox picLogout;
        private Label lbldate;
        private Button btnSuppliers;
        private PictureBox pictureBox5;
        private Label lblusernameRole;
        private Label label2;
        private Button btnPO;
        private PictureBox pictureBox9;
        private Button btnDashboard;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private Button btnSalespos;
        private PictureBox pictureBox4;
        private Button btnOrders;
        private PictureBox pictureBox3;
        private Button btnCustomers;
        private PictureBox pictureBox2;
        private Button btnBooks;
        private PictureBox pictureBox1;
        private Button btnUsers;
        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtContactPhoneNumber;
        private TextBox txtContactEmail;
        private TextBox txtConatctPersonName;
        private Label label6;
        private Label label5;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtSupplierName;
        private TextBox txtSupplierId;
        private Button btnSave;
    }
}