namespace ProjectAlpha1
{
    partial class loginform
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
///  Required method for Designer support - do not modify
///  the contents of this method with the code editor.
/// </summary>
private void InitializeComponent()
        {
            this.labname = new System.Windows.Forms.Label();
            this.labpassword = new System.Windows.Forms.Label();
            this.BTNlogin = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.labLoginupper = new System.Windows.Forms.Label();
            this.BTNexit = new System.Windows.Forms.Button();
            this.CHKpass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_Cmbobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labname.ForeColor = System.Drawing.Color.LightGray;
            this.labname.Location = new System.Drawing.Point(187, 205);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(70, 18);
            this.labname.TabIndex = 0;
            this.labname.Text = "User_ID";
            this.labname.Click += new System.EventHandler(this.label1_Click);
            // 
            // labpassword
            // 
            this.labpassword.AutoSize = true;
            this.labpassword.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labpassword.ForeColor = System.Drawing.Color.LightGray;
            this.labpassword.Location = new System.Drawing.Point(166, 265);
            this.labpassword.Name = "labpassword";
            this.labpassword.Size = new System.Drawing.Size(91, 18);
            this.labpassword.TabIndex = 1;
            this.labpassword.Text = "Password";
            this.labpassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // BTNlogin
            // 
            this.BTNlogin.BackColor = System.Drawing.Color.Black;
            this.BTNlogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNlogin.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTNlogin.ForeColor = System.Drawing.Color.LightGray;
            this.BTNlogin.Location = new System.Drawing.Point(302, 365);
            this.BTNlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNlogin.Name = "BTNlogin";
            this.BTNlogin.Size = new System.Drawing.Size(179, 31);
            this.BTNlogin.TabIndex = 2;
            this.BTNlogin.Text = "Login";
            this.BTNlogin.UseVisualStyleBackColor = false;
            this.BTNlogin.Click += new System.EventHandler(this.BTNlogin_Click);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_username.Location = new System.Drawing.Point(303, 196);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(196, 27);
            this.txt_username.TabIndex = 4;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_password.Location = new System.Drawing.Point(303, 261);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(196, 27);
            this.txt_password.TabIndex = 5;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // labLoginupper
            // 
            this.labLoginupper.AutoSize = true;
            this.labLoginupper.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labLoginupper.ForeColor = System.Drawing.Color.LightGray;
            this.labLoginupper.Location = new System.Drawing.Point(329, 98);
            this.labLoginupper.Name = "labLoginupper";
            this.labLoginupper.Size = new System.Drawing.Size(134, 41);
            this.labLoginupper.TabIndex = 6;
            this.labLoginupper.Text = "LOGIN";
            // 
            // BTNexit
            // 
            this.BTNexit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNexit.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTNexit.ForeColor = System.Drawing.Color.LightGray;
            this.BTNexit.Location = new System.Drawing.Point(576, 365);
            this.BTNexit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNexit.Name = "BTNexit";
            this.BTNexit.Size = new System.Drawing.Size(86, 31);
            this.BTNexit.TabIndex = 8;
            this.BTNexit.Text = "EXIT";
            this.BTNexit.UseVisualStyleBackColor = false;
            this.BTNexit.Click += new System.EventHandler(this.BTNexit_Click);
            // 
            // CHKpass
            // 
            this.CHKpass.AutoSize = true;
            this.CHKpass.BackColor = System.Drawing.Color.Black;
            this.CHKpass.ForeColor = System.Drawing.Color.Transparent;
            this.CHKpass.Location = new System.Drawing.Point(329, 304);
            this.CHKpass.Name = "CHKpass";
            this.CHKpass.Size = new System.Drawing.Size(132, 24);
            this.CHKpass.TabIndex = 9;
            this.CHKpass.Text = "Show Password";
            this.CHKpass.UseVisualStyleBackColor = false;
            this.CHKpass.CheckedChanged += new System.EventHandler(this.CHKpass_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(122, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "RESTAURANT MANAGEMENT SYSTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Login_Cmbobox
            // 
            this.Login_Cmbobox.FormattingEnabled = true;
            this.Login_Cmbobox.Location = new System.Drawing.Point(312, 145);
            this.Login_Cmbobox.Name = "Login_Cmbobox";
            this.Login_Cmbobox.Size = new System.Drawing.Size(169, 28);
            this.Login_Cmbobox.TabIndex = 11;
            this.Login_Cmbobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(811, 471);
            this.Controls.Add(this.Login_Cmbobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CHKpass);
            this.Controls.Add(this.BTNexit);
            this.Controls.Add(this.labLoginupper);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.BTNlogin);
            this.Controls.Add(this.labpassword);
            this.Controls.Add(this.labname);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Login";
            this.Load += new System.EventHandler(this.loginform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labname;
        private Label labpassword;
        private Button BTNlogin;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label labLoginupper;
        private Button BTNexit;
        private CheckBox CHKpass;
        private Label label1;
        private ComboBox Login_Cmbobox;
    }
}