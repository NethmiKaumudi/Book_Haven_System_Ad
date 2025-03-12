namespace Book_Haven_System_Ad.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel2 = new Panel();
            chkShowPassword = new CheckBox();
            label1 = new Label();
            label4 = new Label();
            btnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 450);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(41, 248);
            label5.Name = "label5";
            label5.Size = new Size(196, 41);
            label5.TabIndex = 7;
            label5.Text = "Book Haven";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(chkShowPassword);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUserName);
            panel2.Location = new Point(291, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(509, 450);
            panel2.TabIndex = 5;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(241, 255);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(151, 27);
            chkShowPassword.TabIndex = 6;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 53);
            label1.Name = "label1";
            label1.Size = new Size(105, 41);
            label1.TabIndex = 0;
            label1.Text = "Login ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(101, 254);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkGreen;
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(195, 304);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(106, 39);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(101, 220);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(101, 155);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 2;
            label2.Text = "User Name :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(241, 213);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(189, 27);
            txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(241, 148);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(189, 27);
            txtUserName.TabIndex = 0;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmLogin";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label5;
        private Panel panel2;
        private CheckBox chkShowPassword;
        private Label label1;
        private Label label4;
        private Button btnLogin;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtUserName;
    }
}