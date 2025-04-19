namespace InventoryManagementSystem.Forms
{
    partial class LoginForm
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
            lblQuantity = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(22, 67);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(70, 20);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(112, 64);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(292, 27);
            txtPassword.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 5;
            label1.Text = "User Name";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(112, 22);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(292, 27);
            txtUsername.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(310, 113);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 163);
            Controls.Add(btnLogin);
            Controls.Add(lblQuantity);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuantity;
        private TextBox txtPassword;
        private Label label1;
        private TextBox txtUsername;
        private Button btnLogin;
    }
}