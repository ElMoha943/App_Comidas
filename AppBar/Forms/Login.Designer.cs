
namespace AppBar
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnLogin = new RJCodeAdvance.RJControls.RJButton();
            this.textboxUsername = new RJCodeAdvance.RJControls.RJTextBox();
            this.textboxPassword = new RJCodeAdvance.RJControls.RJTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 0;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(65, 228);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textboxUsername
            // 
            this.textboxUsername.BackColor = System.Drawing.SystemColors.Window;
            this.textboxUsername.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textboxUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textboxUsername.BorderRadius = 0;
            this.textboxUsername.BorderSize = 2;
            this.textboxUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxUsername.Location = new System.Drawing.Point(13, 151);
            this.textboxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textboxUsername.Multiline = false;
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textboxUsername.PasswordChar = false;
            this.textboxUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textboxUsername.PlaceholderText = "Usuario";
            this.textboxUsername.Size = new System.Drawing.Size(250, 32);
            this.textboxUsername.TabIndex = 1;
            this.textboxUsername.Texts = "";
            this.textboxUsername.UnderlinedStyle = false;
            this.textboxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxUsername_KeyPress);
            // 
            // textboxPassword
            // 
            this.textboxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textboxPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textboxPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textboxPassword.BorderRadius = 0;
            this.textboxPassword.BorderSize = 2;
            this.textboxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxPassword.Location = new System.Drawing.Point(13, 190);
            this.textboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPassword.Multiline = false;
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textboxPassword.PasswordChar = true;
            this.textboxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textboxPassword.PlaceholderText = "********";
            this.textboxPassword.Size = new System.Drawing.Size(250, 32);
            this.textboxPassword.TabIndex = 2;
            this.textboxPassword.Texts = "";
            this.textboxPassword.UnderlinedStyle = false;
            this.textboxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxPassword_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppBar.Properties.Resources.Pizza_slice_icon;
            this.pictureBox1.Location = new System.Drawing.Point(65, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "V2.0 By ElMoha943";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.textboxUsername);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Appbar | Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton btnLogin;
        private RJCodeAdvance.RJControls.RJTextBox textboxUsername;
        private RJCodeAdvance.RJControls.RJTextBox textboxPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}