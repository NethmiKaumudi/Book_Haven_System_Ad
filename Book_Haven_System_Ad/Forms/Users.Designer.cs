namespace Book_Haven_System_Ad.Forms
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            DashboardPanel = new Panel();
            txtSerach = new TextBox();
            tblUsers = new DataGridView();
            groupBox1 = new GroupBox();
            btnEdit = new Button();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            cmbUserRoles = new ComboBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            ButtonPanel = new Panel();
            pictureBox6 = new PictureBox();
            picLogout = new PictureBox();
            pictureBox4 = new PictureBox();
            lbldate = new Label();
            btnOrders = new Button();
            lblusernameRole = new Label();
            btnReports = new Button();
            label2 = new Label();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            btnSuppliers = new Button();
            btnSalespos = new Button();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            btnCustomers = new Button();
            btnUsers = new Button();
            pictureBox7 = new PictureBox();
            btnPO = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnDashboard = new Button();
            btnBooks = new Button();
            DashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblUsers).BeginInit();
            groupBox1.SuspendLayout();
            ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DashboardPanel
            // 
            DashboardPanel.BackColor = Color.White;
            DashboardPanel.Controls.Add(txtSerach);
            DashboardPanel.Controls.Add(tblUsers);
            DashboardPanel.Controls.Add(groupBox1);
            DashboardPanel.Controls.Add(label1);
            DashboardPanel.Location = new Point(341, -1);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.Size = new Size(983, 662);
            DashboardPanel.TabIndex = 5;
            // 
            // txtSerach
            // 
            txtSerach.BackColor = Color.MintCream;
            txtSerach.BorderStyle = BorderStyle.FixedSingle;
            txtSerach.ForeColor = Color.Black;
            txtSerach.Location = new Point(55, 254);
            txtSerach.Name = "txtSerach";
            txtSerach.PlaceholderText = "Serach";
            txtSerach.Size = new Size(272, 27);
            txtSerach.TabIndex = 3;
            txtSerach.TextChanged += txtSerach_TextChanged;
            // 
            // tblUsers
            // 
            tblUsers.BackgroundColor = Color.Gainsboro;
            tblUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblUsers.Location = new Point(55, 297);
            tblUsers.Name = "tblUsers";
            tblUsers.RowHeadersWidth = 51;
            tblUsers.Size = new Size(901, 339);
            tblUsers.TabIndex = 2;
            tblUsers.CellContentClick += tblUsers_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(cmbUserRoles);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Location = new Point(55, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(901, 192);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Chocolate;
            btnEdit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ActiveCaptionText;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(301, 128);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(131, 41);
            btnEdit.TabIndex = 39;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.Location = new Point(586, 33);
            label8.Name = "label8";
            label8.Size = new Size(92, 23);
            label8.TabIndex = 38;
            label8.Text = "User Role :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(313, 33);
            label6.Name = "label6";
            label6.Size = new Size(91, 23);
            label6.TabIndex = 36;
            label6.Text = "Password :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(41, 33);
            label5.Name = "label5";
            label5.Size = new Size(104, 23);
            label5.TabIndex = 27;
            label5.Text = "User Name :";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Sienna;
            btnClear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.ImageAlign = ContentAlignment.MiddleLeft;
            btnClear.Location = new Point(612, 128);
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
            btnDelete.Location = new Point(460, 128);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 41);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbUserRoles
            // 
            cmbUserRoles.BackColor = Color.MintCream;
            cmbUserRoles.ForeColor = Color.Black;
            cmbUserRoles.FormattingEnabled = true;
            cmbUserRoles.Items.AddRange(new object[] { "Admin", "Sales Clerk" });
            cmbUserRoles.Location = new Point(586, 70);
            cmbUserRoles.Name = "cmbUserRoles";
            cmbUserRoles.Size = new Size(251, 28);
            cmbUserRoles.TabIndex = 32;
            cmbUserRoles.Text = "Select Role ..";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.MintCream;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(313, 71);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(242, 27);
            txtPassword.TabIndex = 28;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.MintCream;
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.ForeColor = Color.Black;
            txtUserName.Location = new Point(41, 71);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Username";
            txtUserName.Size = new Size(242, 27);
            txtUserName.TabIndex = 27;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(143, 128);
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
            label1.Location = new Point(51, 12);
            label1.Name = "label1";
            label1.Size = new Size(185, 28);
            label1.TabIndex = 0;
            label1.Text = "User Management";
            // 
            // ButtonPanel
            // 
            ButtonPanel.BackColor = Color.DarkGreen;
            ButtonPanel.Controls.Add(pictureBox6);
            ButtonPanel.Controls.Add(picLogout);
            ButtonPanel.Controls.Add(pictureBox4);
            ButtonPanel.Controls.Add(lbldate);
            ButtonPanel.Controls.Add(btnOrders);
            ButtonPanel.Controls.Add(lblusernameRole);
            ButtonPanel.Controls.Add(btnReports);
            ButtonPanel.Controls.Add(label2);
            ButtonPanel.Controls.Add(pictureBox8);
            ButtonPanel.Controls.Add(pictureBox9);
            ButtonPanel.Controls.Add(btnSuppliers);
            ButtonPanel.Controls.Add(btnSalespos);
            ButtonPanel.Controls.Add(pictureBox3);
            ButtonPanel.Controls.Add(pictureBox5);
            ButtonPanel.Controls.Add(btnCustomers);
            ButtonPanel.Controls.Add(btnUsers);
            ButtonPanel.Controls.Add(pictureBox7);
            ButtonPanel.Controls.Add(btnPO);
            ButtonPanel.Controls.Add(pictureBox2);
            ButtonPanel.Controls.Add(pictureBox1);
            ButtonPanel.Controls.Add(btnDashboard);
            ButtonPanel.Controls.Add(btnBooks);
            ButtonPanel.Location = new Point(-1, -2);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(348, 662);
            ButtonPanel.TabIndex = 11;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.ErrorImage = (Image)resources.GetObject("pictureBox6.ErrorImage");
            pictureBox6.Location = new Point(65, 302);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 42);
            pictureBox6.TabIndex = 65;
            pictureBox6.TabStop = false;
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
            picLogout.Click += picLogout_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(65, 410);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 42);
            pictureBox4.TabIndex = 64;
            pictureBox4.TabStop = false;
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
            // btnOrders
            // 
            btnOrders.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(133, 417);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(157, 32);
            btnOrders.TabIndex = 63;
            btnOrders.Text = "Sales Details";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
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
            // btnReports
            // 
            btnReports.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(133, 586);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(157, 32);
            btnReports.TabIndex = 61;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
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
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.Location = new Point(65, 579);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(37, 42);
            pictureBox8.TabIndex = 62;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Location = new Point(65, 135);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(37, 42);
            pictureBox9.TabIndex = 60;
            pictureBox9.TabStop = false;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.Location = new Point(133, 478);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(157, 32);
            btnSuppliers.TabIndex = 54;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnSalespos
            // 
            btnSalespos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalespos.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalespos.Location = new Point(133, 366);
            btnSalespos.Name = "btnSalespos";
            btnSalespos.Size = new Size(157, 32);
            btnSalespos.TabIndex = 56;
            btnSalespos.Text = "Sales(POS)";
            btnSalespos.UseVisualStyleBackColor = true;
            btnSalespos.Click += btnSalespos_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(65, 356);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 42);
            pictureBox3.TabIndex = 53;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.ErrorImage = (Image)resources.GetObject("pictureBox5.ErrorImage");
            pictureBox5.Location = new Point(65, 471);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 42);
            pictureBox5.TabIndex = 55;
            pictureBox5.TabStop = false;
            // 
            // btnCustomers
            // 
            btnCustomers.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(133, 311);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(157, 32);
            btnCustomers.TabIndex = 52;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.Green;
            btnUsers.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(133, 198);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(157, 32);
            btnUsers.TabIndex = 48;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(65, 526);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(37, 42);
            pictureBox7.TabIndex = 58;
            pictureBox7.TabStop = false;
            // 
            // btnPO
            // 
            btnPO.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPO.ImageAlign = ContentAlignment.MiddleLeft;
            btnPO.Location = new Point(133, 536);
            btnPO.Name = "btnPO";
            btnPO.Size = new Size(157, 32);
            btnPO.TabIndex = 57;
            btnPO.Text = "Purchase Stock";
            btnPO.UseVisualStyleBackColor = true;
            btnPO.Click += btnPO_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(65, 244);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 42);
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 191);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 42);
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.White;
            btnDashboard.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.ActiveCaptionText;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(133, 142);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(157, 32);
            btnDashboard.TabIndex = 59;
            btnDashboard.Text = "Dasboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnBooks
            // 
            btnBooks.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooks.ImageAlign = ContentAlignment.MiddleLeft;
            btnBooks.Location = new Point(133, 251);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(157, 32);
            btnBooks.TabIndex = 50;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 661);
            Controls.Add(ButtonPanel);
            Controls.Add(DashboardPanel);
            Name = "frmUser";
            Text = "Users";
            DashboardPanel.ResumeLayout(false);
            DashboardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblUsers).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ButtonPanel.ResumeLayout(false);
            ButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel DashboardPanel;
        private TextBox txtSerach;
        private DataGridView tblUsers;
        private GroupBox groupBox1;
        private Label label8;
        private Label label6;
        private Label label5;
        private Button btnClear;
        private Button btnDelete;
        private ComboBox cmbUserRoles;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnSave;
        private Label label1;
        private Button btnEdit;
        private Panel ButtonPanel;
        private PictureBox picLogout;
        private Label lbldate;
        private Label lblusernameRole;
        private Label label2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private Button btnOrders;
        private Button btnReports;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Button btnSuppliers;
        private Button btnSalespos;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private Button btnCustomers;
        private Button btnUsers;
        private PictureBox pictureBox7;
        private Button btnPO;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Button btnBooks;
    }
}