namespace Book_Haven_System_Ad.Forms
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            groupBox2 = new GroupBox();
            label7 = new Label();
            txtTotalOrder = new TextBox();
            txtTotalSales = new TextBox();
            label6 = new Label();
            label5 = new Label();
            salesReportGrid = new DataGridView();
            btnGenerateReport = new Button();
            label4 = new Label();
            label1 = new Label();
            endDatePicker = new DateTimePicker();
            cmbreportType = new ComboBox();
            label13 = new Label();
            startDatePicker = new DateTimePicker();
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
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)salesReportGrid).BeginInit();
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
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtTotalOrder);
            groupBox2.Controls.Add(txtTotalSales);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(salesReportGrid);
            groupBox2.Controls.Add(btnGenerateReport);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(endDatePicker);
            groupBox2.Controls.Add(cmbreportType);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(startDatePicker);
            groupBox2.Location = new Point(348, -3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(997, 759);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 97);
            label7.Name = "label7";
            label7.Size = new Size(208, 28);
            label7.TabIndex = 123;
            label7.Text = "Report Management";
            // 
            // txtTotalOrder
            // 
            txtTotalOrder.Location = new Point(525, 612);
            txtTotalOrder.Name = "txtTotalOrder";
            txtTotalOrder.Size = new Size(203, 27);
            txtTotalOrder.TabIndex = 122;
            // 
            // txtTotalSales
            // 
            txtTotalSales.Location = new Point(158, 612);
            txtTotalSales.Name = "txtTotalSales";
            txtTotalSales.Size = new Size(203, 27);
            txtTotalSales.TabIndex = 121;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(385, 613);
            label6.Name = "label6";
            label6.Size = new Size(106, 23);
            label6.TabIndex = 120;
            label6.Text = "Total Orders:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(33, 613);
            label5.Name = "label5";
            label5.Size = new Size(103, 23);
            label5.TabIndex = 119;
            label5.Text = " Total Sales :";
            // 
            // salesReportGrid
            // 
            salesReportGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesReportGrid.Location = new Point(33, 300);
            salesReportGrid.Name = "salesReportGrid";
            salesReportGrid.RowHeadersWidth = 51;
            salesReportGrid.Size = new Size(929, 301);
            salesReportGrid.TabIndex = 116;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.Sienna;
            btnGenerateReport.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateReport.ForeColor = SystemColors.ActiveCaptionText;
            btnGenerateReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerateReport.Location = new Point(599, 257);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(198, 37);
            btnGenerateReport.TabIndex = 115;
            btnGenerateReport.Text = "Genarate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(26, 166);
            label4.Name = "label4";
            label4.Size = new Size(160, 23);
            label4.TabIndex = 114;
            label4.Text = " Sales Report Type :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(516, 206);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 113;
            label1.Text = "End Date :";
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(611, 202);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(322, 27);
            endDatePicker.TabIndex = 112;
            // 
            // cmbreportType
            // 
            cmbreportType.FormattingEnabled = true;
            cmbreportType.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly" });
            cmbreportType.Location = new Point(210, 164);
            cmbreportType.Name = "cmbreportType";
            cmbreportType.Size = new Size(223, 28);
            cmbreportType.TabIndex = 111;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label13.Location = new Point(33, 207);
            label13.Name = "label13";
            label13.Size = new Size(96, 23);
            label13.TabIndex = 70;
            label13.Text = "Start Date :";
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(158, 203);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(322, 27);
            startDatePicker.TabIndex = 64;
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
            ButtonPanel.Location = new Point(-1, -3);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(348, 759);
            ButtonPanel.TabIndex = 10;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.ErrorImage = (Image)resources.GetObject("pictureBox6.ErrorImage");
            pictureBox6.Location = new Point(57, 347);
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
            picLogout.Click += picLogout_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(57, 455);
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
            btnOrders.Location = new Point(125, 462);
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
            btnReports.BackColor = Color.Green;
            btnReports.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(125, 631);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(157, 32);
            btnReports.TabIndex = 61;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
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
            pictureBox8.Location = new Point(57, 624);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(37, 42);
            pictureBox8.TabIndex = 62;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Location = new Point(57, 180);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(37, 42);
            pictureBox9.TabIndex = 60;
            pictureBox9.TabStop = false;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.Location = new Point(125, 523);
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
            btnSalespos.Location = new Point(125, 411);
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
            pictureBox3.Location = new Point(57, 401);
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
            pictureBox5.Location = new Point(57, 516);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 42);
            pictureBox5.TabIndex = 55;
            pictureBox5.TabStop = false;
            // 
            // btnCustomers
            // 
            btnCustomers.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(125, 356);
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
            btnUsers.Location = new Point(125, 243);
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
            pictureBox7.Location = new Point(57, 571);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(37, 42);
            pictureBox7.TabIndex = 58;
            pictureBox7.TabStop = false;
            // 
            // btnPO
            // 
            btnPO.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPO.ImageAlign = ContentAlignment.MiddleLeft;
            btnPO.Location = new Point(125, 581);
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
            pictureBox2.Location = new Point(57, 289);
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
            pictureBox1.Location = new Point(57, 236);
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
            btnDashboard.Location = new Point(125, 187);
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
            btnBooks.Location = new Point(125, 296);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(157, 32);
            btnBooks.TabIndex = 50;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 755);
            Controls.Add(groupBox2);
            Controls.Add(ButtonPanel);
            Name = "ReportForm";
            Text = "ReportForm";
            Load += ReportForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)salesReportGrid).EndInit();
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

        private GroupBox groupBox2;
        private Label label4;
        private Label label1;
        private DateTimePicker endDatePicker;
        private ComboBox cmbreportType;
        private Label label13;
        private DateTimePicker startDatePicker;
        private Panel ButtonPanel;
        private PictureBox picLogout;
        private Label lbldate;
        private Label lblusernameRole;
        private Label label2;
        private DataGridView inventoryStatusGrid;
        private DataGridView bestSellingBooksGrid;
        private DataGridView salesReportGrid;
        private Button btnGenerateReport;
        private Label label6;
        private Label label5;
        private TextBox txtTotalOrder;
        private TextBox txtTotalSales;
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
        private Label label7;
    }
}