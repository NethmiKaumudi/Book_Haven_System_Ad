namespace Book_Haven_System_Ad.Forms
{
    partial class SalesClearkDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesClearkDashboard));
            DashboardPanel = new Panel();
            label1 = new Label();
            txtSerach = new TextBox();
            tblBooks = new DataGridView();
            btnCustomers = new Button();
            btnSalespos = new Button();
            btnDashboard = new Button();
            label2 = new Label();
            lblusernameRole = new Label();
            lbldate = new Label();
            picLogout = new PictureBox();
            ButtonPanel = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox5 = new PictureBox();
            DashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).BeginInit();
            ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // DashboardPanel
            // 
            DashboardPanel.BackColor = SystemColors.ButtonHighlight;
            DashboardPanel.Controls.Add(label1);
            DashboardPanel.Controls.Add(txtSerach);
            DashboardPanel.Controls.Add(tblBooks);
            DashboardPanel.Location = new Point(342, -1);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.Size = new Size(983, 662);
            DashboardPanel.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 35);
            label1.Name = "label1";
            label1.Size = new Size(150, 31);
            label1.TabIndex = 10;
            label1.Text = "Book Details";
            // 
            // txtSerach
            // 
            txtSerach.BackColor = Color.MintCream;
            txtSerach.BorderStyle = BorderStyle.FixedSingle;
            txtSerach.ForeColor = Color.Black;
            txtSerach.Location = new Point(50, 96);
            txtSerach.Name = "txtSerach";
            txtSerach.PlaceholderText = "Serach Title,ISBN,Author";
            txtSerach.Size = new Size(272, 27);
            txtSerach.TabIndex = 9;
            txtSerach.TextChanged += txtSerach_TextChanged;
            // 
            // tblBooks
            // 
            tblBooks.BackgroundColor = Color.Gainsboro;
            tblBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblBooks.Location = new Point(50, 139);
            tblBooks.Name = "tblBooks";
            tblBooks.RowHeadersWidth = 51;
            tblBooks.Size = new Size(901, 475);
            tblBooks.TabIndex = 8;
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
            ButtonPanel.Location = new Point(0, -1);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(348, 662);
            ButtonPanel.TabIndex = 7;
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
            // SalesClearkDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 661);
            Controls.Add(ButtonPanel);
            Controls.Add(DashboardPanel);
            Name = "SalesClearkDashboard";
            Text = "SalesClearkDashboard";
            DashboardPanel.ResumeLayout(false);
            DashboardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).EndInit();
            ButtonPanel.ResumeLayout(false);
            ButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel DashboardPanel;
        private Button btnCustomers;
        private Button btnSalespos;
        private Button btnDashboard;
        private Label label2;
        private Label lblusernameRole;
        private Label lbldate;
        private PictureBox picLogout;
        private Panel ButtonPanel;
        private Label label1;
        private TextBox txtSerach;
        private DataGridView tblBooks;
        private PictureBox pictureBox1;
        private PictureBox pictureBox9;
        private PictureBox pictureBox5;
    }
}