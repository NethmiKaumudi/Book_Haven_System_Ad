namespace Book_Haven_System_Ad.Forms
{
    partial class frmSalesDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesDetailsForm));
            DashboardPanel = new Panel();
            txtSerach = new TextBox();
            tblOrderDetails = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            lblusernameRole = new Label();
            lbldate = new Label();
            picLogout = new PictureBox();
            ButtonPanel = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnOrders = new Button();
            btnReports = new Button();
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
            ((System.ComponentModel.ISupportInitialize)tblOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).BeginInit();
            ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
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
            DashboardPanel.Controls.Add(tblOrderDetails);
            DashboardPanel.Controls.Add(label1);
            DashboardPanel.Location = new Point(341, -1);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.Size = new Size(983, 662);
            DashboardPanel.TabIndex = 13;
            // 
            // txtSerach
            // 
            txtSerach.BackColor = Color.MintCream;
            txtSerach.BorderStyle = BorderStyle.FixedSingle;
            txtSerach.ForeColor = Color.Black;
            txtSerach.Location = new Point(48, 76);
            txtSerach.Name = "txtSerach";
            txtSerach.PlaceholderText = "Serach ";
            txtSerach.Size = new Size(272, 27);
            txtSerach.TabIndex = 3;
            txtSerach.TextChanged += txtSerach_TextChanged;
            // 
            // tblOrderDetails
            // 
            tblOrderDetails.BackgroundColor = Color.Gainsboro;
            tblOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblOrderDetails.Location = new Point(48, 127);
            tblOrderDetails.Name = "tblOrderDetails";
            tblOrderDetails.RowHeadersWidth = 51;
            tblOrderDetails.Size = new Size(921, 339);
            tblOrderDetails.TabIndex = 2;
            tblOrderDetails.CellContentClick += tblOrderDetails_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 22);
            label1.Name = "label1";
            label1.Size = new Size(132, 28);
            label1.TabIndex = 0;
            label1.Text = "Sales Details";
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
            ButtonPanel.Location = new Point(0, 0);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(348, 662);
            ButtonPanel.TabIndex = 12;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.ErrorImage = (Image)resources.GetObject("pictureBox6.ErrorImage");
            pictureBox6.Location = new Point(71, 293);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 42);
            pictureBox6.TabIndex = 65;
            pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(71, 401);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 42);
            pictureBox4.TabIndex = 64;
            pictureBox4.TabStop = false;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.Green;
            btnOrders.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(139, 408);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(157, 32);
            btnOrders.TabIndex = 63;
            btnOrders.Text = "Sales Details";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(139, 577);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(157, 32);
            btnReports.TabIndex = 61;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.Location = new Point(71, 570);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(37, 42);
            pictureBox8.TabIndex = 62;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Location = new Point(71, 126);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(37, 42);
            pictureBox9.TabIndex = 60;
            pictureBox9.TabStop = false;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.Location = new Point(139, 469);
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
            btnSalespos.Location = new Point(139, 357);
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
            pictureBox3.Location = new Point(71, 347);
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
            pictureBox5.Location = new Point(71, 462);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 42);
            pictureBox5.TabIndex = 55;
            pictureBox5.TabStop = false;
            // 
            // btnCustomers
            // 
            btnCustomers.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(139, 302);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(157, 32);
            btnCustomers.TabIndex = 52;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.Transparent;
            btnUsers.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(139, 189);
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
            pictureBox7.Location = new Point(71, 517);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(37, 42);
            pictureBox7.TabIndex = 58;
            pictureBox7.TabStop = false;
            // 
            // btnPO
            // 
            btnPO.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPO.ImageAlign = ContentAlignment.MiddleLeft;
            btnPO.Location = new Point(139, 527);
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
            pictureBox2.Location = new Point(71, 235);
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
            pictureBox1.Location = new Point(71, 182);
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
            btnDashboard.Location = new Point(139, 133);
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
            btnBooks.Location = new Point(139, 242);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(157, 32);
            btnBooks.TabIndex = 50;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            // 
            // frmSalesDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 661);
            Controls.Add(ButtonPanel);
            Controls.Add(DashboardPanel);
            Name = "frmSalesDetailsForm";
            Text = "SalesDetailsForm";
            DashboardPanel.ResumeLayout(false);
            DashboardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblOrderDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).EndInit();
            ButtonPanel.ResumeLayout(false);
            ButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private DataGridView tblOrderDetails;
        private Label label1;
        private Label label2;
        private Label lblusernameRole;
        private Label lbldate;
        private PictureBox picLogout;
        private Panel ButtonPanel;
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