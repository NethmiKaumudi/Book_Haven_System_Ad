namespace Book_Haven_System_Ad.Forms
{
    partial class frmSalesClarkSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesClarkSales));
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            btnAddtoOrderCart = new Button();
            label14 = new Label();
            txtOrderQty = new TextBox();
            label15 = new Label();
            txtPrize = new TextBox();
            label17 = new Label();
            label18 = new Label();
            txtAuthor = new TextBox();
            txtBookName = new TextBox();
            tblOrderCart = new DataGridView();
            cmbOrderMethod = new ComboBox();
            label3 = new Label();
            groupBoxOnlineOrder = new GroupBox();
            label4 = new Label();
            cmbDeliveryType = new ComboBox();
            txtDeliveryAddress = new TextBox();
            label35 = new Label();
            groupBoxPosOrders = new GroupBox();
            txtAmountPaid = new TextBox();
            label22 = new Label();
            label23 = new Label();
            txtChange = new TextBox();
            label36 = new Label();
            label33 = new Label();
            txtOrderId = new TextBox();
            txtSubTotal = new TextBox();
            txtOrderTotal = new TextBox();
            btnOrder = new Button();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            cmbDiscount = new ComboBox();
            btnAddNewCustomer = new Button();
            label12 = new Label();
            txtCustomerName = new TextBox();
            label11 = new Label();
            txtCustomerNumber = new TextBox();
            label13 = new Label();
            dtpPosDate = new DateTimePicker();
            label16 = new Label();
            txtOrderUserName = new TextBox();
            label1 = new Label();
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
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblOrderCart).BeginInit();
            groupBoxOnlineOrder.SuspendLayout();
            groupBoxPosOrders.SuspendLayout();
            ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(cmbOrderMethod);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(groupBoxOnlineOrder);
            groupBox2.Controls.Add(groupBoxPosOrders);
            groupBox2.Controls.Add(label36);
            groupBox2.Controls.Add(label33);
            groupBox2.Controls.Add(txtOrderId);
            groupBox2.Controls.Add(txtSubTotal);
            groupBox2.Controls.Add(txtOrderTotal);
            groupBox2.Controls.Add(btnOrder);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(cmbDiscount);
            groupBox2.Controls.Add(btnAddNewCustomer);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtCustomerName);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtCustomerNumber);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(dtpPosDate);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(txtOrderUserName);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(348, -3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(997, 714);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(btnAddtoOrderCart);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtOrderQty);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtPrize);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(txtBookName);
            groupBox1.Controls.Add(tblOrderCart);
            groupBox1.Location = new Point(37, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(914, 230);
            groupBox1.TabIndex = 114;
            groupBox1.TabStop = false;
            // 
            // btnAddtoOrderCart
            // 
            btnAddtoOrderCart.BackColor = Color.Sienna;
            btnAddtoOrderCart.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddtoOrderCart.ForeColor = SystemColors.ActiveCaptionText;
            btnAddtoOrderCart.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddtoOrderCart.Location = new Point(671, 81);
            btnAddtoOrderCart.Name = "btnAddtoOrderCart";
            btnAddtoOrderCart.Size = new Size(198, 37);
            btnAddtoOrderCart.TabIndex = 71;
            btnAddtoOrderCart.Text = "Add to Cart";
            btnAddtoOrderCart.UseVisualStyleBackColor = false;
            btnAddtoOrderCart.Click += btnAddtoOrderCart_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label14.Location = new Point(666, 12);
            label14.Name = "label14";
            label14.Size = new Size(86, 23);
            label14.TabIndex = 79;
            label14.Text = "Quantity :";
            // 
            // txtOrderQty
            // 
            txtOrderQty.BackColor = Color.MintCream;
            txtOrderQty.BorderStyle = BorderStyle.FixedSingle;
            txtOrderQty.ForeColor = Color.Black;
            txtOrderQty.Location = new Point(669, 40);
            txtOrderQty.Name = "txtOrderQty";
            txtOrderQty.PlaceholderText = "Quantity";
            txtOrderQty.Size = new Size(187, 27);
            txtOrderQty.TabIndex = 78;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label15.Location = new Point(457, 14);
            label15.Name = "label15";
            label15.Size = new Size(56, 23);
            label15.TabIndex = 77;
            label15.Text = "Prize :";
            // 
            // txtPrize
            // 
            txtPrize.BackColor = Color.MintCream;
            txtPrize.BorderStyle = BorderStyle.FixedSingle;
            txtPrize.ForeColor = Color.Black;
            txtPrize.Location = new Point(459, 42);
            txtPrize.Name = "txtPrize";
            txtPrize.PlaceholderText = "Prize";
            txtPrize.Size = new Size(187, 27);
            txtPrize.TabIndex = 76;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label17.Location = new Point(225, 14);
            label17.Name = "label17";
            label17.Size = new Size(72, 23);
            label17.TabIndex = 75;
            label17.Text = "Author :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label18.Location = new Point(39, 12);
            label18.Name = "label18";
            label18.Size = new Size(109, 23);
            label18.TabIndex = 72;
            label18.Text = "Book Name :";
            // 
            // txtAuthor
            // 
            txtAuthor.BackColor = Color.MintCream;
            txtAuthor.BorderStyle = BorderStyle.FixedSingle;
            txtAuthor.ForeColor = Color.Black;
            txtAuthor.Location = new Point(228, 42);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.PlaceholderText = "Author";
            txtAuthor.Size = new Size(199, 27);
            txtAuthor.TabIndex = 74;
            // 
            // txtBookName
            // 
            txtBookName.BackColor = Color.MintCream;
            txtBookName.BorderStyle = BorderStyle.FixedSingle;
            txtBookName.ForeColor = Color.Black;
            txtBookName.Location = new Point(41, 40);
            txtBookName.Name = "txtBookName";
            txtBookName.PlaceholderText = "BookName";
            txtBookName.Size = new Size(174, 27);
            txtBookName.TabIndex = 73;
            txtBookName.KeyDown += txtBookName_KeyDown;
            // 
            // tblOrderCart
            // 
            tblOrderCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblOrderCart.Location = new Point(45, 124);
            tblOrderCart.Name = "tblOrderCart";
            tblOrderCart.RowHeadersWidth = 51;
            tblOrderCart.Size = new Size(830, 94);
            tblOrderCart.TabIndex = 70;
            tblOrderCart.CellContentClick += tblOrderCart_CellContentClick;
            // 
            // cmbOrderMethod
            // 
            cmbOrderMethod.FormattingEnabled = true;
            cmbOrderMethod.Items.AddRange(new object[] { "POS", "Online" });
            cmbOrderMethod.Location = new Point(177, 185);
            cmbOrderMethod.Name = "cmbOrderMethod";
            cmbOrderMethod.Size = new Size(151, 28);
            cmbOrderMethod.TabIndex = 112;
            cmbOrderMethod.SelectedIndexChanged += cmbOrderMethod_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 10);
            label3.Name = "label3";
            label3.Size = new Size(197, 28);
            label3.TabIndex = 110;
            label3.Text = "Order Management";
            // 
            // groupBoxOnlineOrder
            // 
            groupBoxOnlineOrder.BackColor = Color.Silver;
            groupBoxOnlineOrder.Controls.Add(label4);
            groupBoxOnlineOrder.Controls.Add(cmbDeliveryType);
            groupBoxOnlineOrder.Controls.Add(txtDeliveryAddress);
            groupBoxOnlineOrder.Controls.Add(label35);
            groupBoxOnlineOrder.Location = new Point(472, 513);
            groupBoxOnlineOrder.Name = "groupBoxOnlineOrder";
            groupBoxOnlineOrder.Size = new Size(479, 121);
            groupBoxOnlineOrder.TabIndex = 109;
            groupBoxOnlineOrder.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(12, 14);
            label4.Name = "label4";
            label4.Size = new Size(123, 23);
            label4.TabIndex = 116;
            label4.Text = "Delivery Type :";
            // 
            // cmbDeliveryType
            // 
            cmbDeliveryType.FormattingEnabled = true;
            cmbDeliveryType.Items.AddRange(new object[] { "In-Store Pickup", "Home Delivery" });
            cmbDeliveryType.Location = new Point(177, 10);
            cmbDeliveryType.Name = "cmbDeliveryType";
            cmbDeliveryType.Size = new Size(287, 28);
            cmbDeliveryType.TabIndex = 115;
            cmbDeliveryType.SelectedIndexChanged += cmbDeliveryType_SelectedIndexChanged;
            // 
            // txtDeliveryAddress
            // 
            txtDeliveryAddress.BackColor = Color.MintCream;
            txtDeliveryAddress.BorderStyle = BorderStyle.FixedSingle;
            txtDeliveryAddress.ForeColor = Color.Black;
            txtDeliveryAddress.Location = new Point(179, 57);
            txtDeliveryAddress.Name = "txtDeliveryAddress";
            txtDeliveryAddress.Size = new Size(285, 27);
            txtDeliveryAddress.TabIndex = 108;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label35.Location = new Point(13, 57);
            label35.Name = "label35";
            label35.Size = new Size(147, 23);
            label35.TabIndex = 107;
            label35.Text = "Delivery Address :";
            // 
            // groupBoxPosOrders
            // 
            groupBoxPosOrders.BackColor = Color.Silver;
            groupBoxPosOrders.Controls.Add(txtAmountPaid);
            groupBoxPosOrders.Controls.Add(label22);
            groupBoxPosOrders.Controls.Add(label23);
            groupBoxPosOrders.Controls.Add(txtChange);
            groupBoxPosOrders.Location = new Point(41, 513);
            groupBoxPosOrders.Name = "groupBoxPosOrders";
            groupBoxPosOrders.Size = new Size(406, 122);
            groupBoxPosOrders.TabIndex = 108;
            groupBoxPosOrders.TabStop = false;
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.BackColor = Color.MintCream;
            txtAmountPaid.BorderStyle = BorderStyle.FixedSingle;
            txtAmountPaid.ForeColor = Color.Black;
            txtAmountPaid.Location = new Point(178, 23);
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.Size = new Size(199, 27);
            txtAmountPaid.TabIndex = 93;
            txtAmountPaid.TextChanged += txtAmountPaid_TextChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label22.Location = new Point(25, 23);
            label22.Name = "label22";
            label22.Size = new Size(119, 23);
            label22.TabIndex = 83;
            label22.Text = "Amount Paid :";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label23.Location = new Point(25, 58);
            label23.Name = "label23";
            label23.Size = new Size(78, 23);
            label23.TabIndex = 84;
            label23.Text = "Change :";
            // 
            // txtChange
            // 
            txtChange.BackColor = Color.MintCream;
            txtChange.BorderStyle = BorderStyle.FixedSingle;
            txtChange.ForeColor = Color.Black;
            txtChange.Location = new Point(178, 58);
            txtChange.Name = "txtChange";
            txtChange.ReadOnly = true;
            txtChange.Size = new Size(199, 27);
            txtChange.TabIndex = 92;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label36.Location = new Point(35, 186);
            label36.Name = "label36";
            label36.Size = new Size(129, 23);
            label36.TabIndex = 107;
            label36.Text = "Order Method :";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label33.Location = new Point(388, 54);
            label33.Name = "label33";
            label33.Size = new Size(83, 23);
            label33.TabIndex = 96;
            label33.Text = "Order Id :";
            // 
            // txtOrderId
            // 
            txtOrderId.BackColor = Color.MintCream;
            txtOrderId.BorderStyle = BorderStyle.FixedSingle;
            txtOrderId.ForeColor = Color.Black;
            txtOrderId.Location = new Point(390, 81);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.PlaceholderText = "Order Id";
            txtOrderId.Size = new Size(205, 27);
            txtOrderId.TabIndex = 95;
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = Color.MintCream;
            txtSubTotal.BorderStyle = BorderStyle.FixedSingle;
            txtSubTotal.ForeColor = Color.Black;
            txtSubTotal.Location = new Point(139, 460);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(190, 27);
            txtSubTotal.TabIndex = 91;
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.BackColor = Color.MintCream;
            txtOrderTotal.BorderStyle = BorderStyle.FixedSingle;
            txtOrderTotal.ForeColor = Color.Black;
            txtOrderTotal.Location = new Point(669, 462);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.Size = new Size(192, 27);
            txtOrderTotal.TabIndex = 90;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Green;
            btnOrder.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrder.ForeColor = SystemColors.ActiveCaptionText;
            btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrder.Location = new Point(598, 647);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(167, 41);
            btnOrder.TabIndex = 88;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label21.Location = new Point(598, 465);
            label21.Name = "label21";
            label21.Size = new Size(55, 23);
            label21.TabIndex = 82;
            label21.Text = "Total :";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label20.Location = new Point(40, 465);
            label20.Name = "label20";
            label20.Size = new Size(89, 23);
            label20.TabIndex = 81;
            label20.Text = "Sub Total :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label19.Location = new Point(351, 465);
            label19.Name = "label19";
            label19.Size = new Size(86, 23);
            label19.TabIndex = 78;
            label19.Text = "Discount :";
            // 
            // cmbDiscount
            // 
            cmbDiscount.FormattingEnabled = true;
            cmbDiscount.Location = new Point(457, 462);
            cmbDiscount.Name = "cmbDiscount";
            cmbDiscount.Size = new Size(127, 28);
            cmbDiscount.TabIndex = 77;
            cmbDiscount.SelectedIndexChanged += cmbDiscount_SelectedIndexChanged;
            // 
            // btnAddNewCustomer
            // 
            btnAddNewCustomer.BackColor = Color.Chocolate;
            btnAddNewCustomer.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNewCustomer.ForeColor = SystemColors.ActiveCaptionText;
            btnAddNewCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddNewCustomer.Location = new Point(485, 138);
            btnAddNewCustomer.Name = "btnAddNewCustomer";
            btnAddNewCustomer.Size = new Size(191, 37);
            btnAddNewCustomer.TabIndex = 76;
            btnAddNewCustomer.Text = "Add New Customer";
            btnAddNewCustomer.UseVisualStyleBackColor = false;
            btnAddNewCustomer.Click += btnAddNewCustomer_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label12.Location = new Point(265, 119);
            label12.Name = "label12";
            label12.Size = new Size(144, 23);
            label12.TabIndex = 75;
            label12.Text = "Customer Name :";
            // 
            // txtCustomerName
            // 
            txtCustomerName.BackColor = Color.MintCream;
            txtCustomerName.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerName.ForeColor = Color.Black;
            txtCustomerName.Location = new Point(268, 145);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Customer Name ";
            txtCustomerName.Size = new Size(205, 27);
            txtCustomerName.TabIndex = 74;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label11.Location = new Point(35, 119);
            label11.Name = "label11";
            label11.Size = new Size(208, 23);
            label11.TabIndex = 73;
            label11.Text = "Customer Phone number:";
            // 
            // txtCustomerNumber
            // 
            txtCustomerNumber.BackColor = Color.MintCream;
            txtCustomerNumber.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerNumber.ForeColor = Color.Black;
            txtCustomerNumber.Location = new Point(40, 145);
            txtCustomerNumber.Name = "txtCustomerNumber";
            txtCustomerNumber.PlaceholderText = "Customer Phone number";
            txtCustomerNumber.Size = new Size(205, 27);
            txtCustomerNumber.TabIndex = 72;
            txtCustomerNumber.KeyDown += txtCustomerNumber_KeyDown;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label13.Location = new Point(37, 52);
            label13.Name = "label13";
            label13.Size = new Size(95, 23);
            label13.TabIndex = 70;
            label13.Text = "Order Date";
            // 
            // dtpPosDate
            // 
            dtpPosDate.Location = new Point(40, 78);
            dtpPosDate.Name = "dtpPosDate";
            dtpPosDate.Size = new Size(322, 27);
            dtpPosDate.TabIndex = 64;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label16.Location = new Point(612, 54);
            label16.Name = "label16";
            label16.Size = new Size(90, 23);
            label16.TabIndex = 63;
            label16.Text = "UserName";
            // 
            // txtOrderUserName
            // 
            txtOrderUserName.BackColor = Color.MintCream;
            txtOrderUserName.BorderStyle = BorderStyle.FixedSingle;
            txtOrderUserName.ForeColor = Color.Black;
            txtOrderUserName.Location = new Point(614, 81);
            txtOrderUserName.Name = "txtOrderUserName";
            txtOrderUserName.PlaceholderText = "UserName";
            txtOrderUserName.Size = new Size(205, 27);
            txtOrderUserName.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(612, 470);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 57;
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
            ButtonPanel.Location = new Point(-4, -3);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(354, 710);
            ButtonPanel.TabIndex = 12;
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
            btnDashboard.BackColor = Color.White;
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
            btnSalespos.BackColor = Color.Green;
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
            // frmSalesClarkSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 709);
            Controls.Add(ButtonPanel);
            Controls.Add(groupBox2);
            Name = "frmSalesClarkSales";
            Text = "frmSalesClarkSales";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblOrderCart).EndInit();
            groupBoxOnlineOrder.ResumeLayout(false);
            groupBoxOnlineOrder.PerformLayout();
            groupBoxPosOrders.ResumeLayout(false);
            groupBoxPosOrders.PerformLayout();
            ButtonPanel.ResumeLayout(false);
            ButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btnAddtoOrderCart;
        private Label label14;
        private TextBox txtOrderQty;
        private Label label15;
        private TextBox txtPrize;
        private Label label17;
        private Label label18;
        private TextBox txtAuthor;
        private TextBox txtBookName;
        private DataGridView tblOrderCart;
        private ComboBox cmbOrderMethod;
        private Label label3;
        private GroupBox groupBoxOnlineOrder;
        private Label label4;
        private ComboBox cmbDeliveryType;
        private TextBox txtDeliveryAddress;
        private Label label35;
        private GroupBox groupBoxPosOrders;
        private TextBox txtAmountPaid;
        private Label label22;
        private Label label23;
        private TextBox txtChange;
        private Label label36;
        private Label label33;
        private TextBox txtOrderId;
        private TextBox txtSubTotal;
        private TextBox txtOrderTotal;
        private Button btnOrder;
        private Label label21;
        private Label label20;
        private Label label19;
        private ComboBox cmbDiscount;
        private Button btnAddNewCustomer;
        private Label label12;
        private TextBox txtCustomerName;
        private Label label11;
        private TextBox txtCustomerNumber;
        private Label label13;
        private DateTimePicker dtpPosDate;
        private Label label16;
        private TextBox txtOrderUserName;
        private Label label1;
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