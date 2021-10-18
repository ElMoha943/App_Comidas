
namespace AppBar.Forms
{
    partial class AdminSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSettings));
            this.panelRight = new System.Windows.Forms.Panel();
            this.iconDiscord = new FontAwesome.Sharp.IconButton();
            this.iconTwitter = new FontAwesome.Sharp.IconButton();
            this.iconGitHub = new FontAwesome.Sharp.IconButton();
            this.labelSpam = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.comboboxSetTheme = new RJCodeAdvance.RJControls.RJComboBox();
            this.btnSyncTheme = new RJCodeAdvance.RJControls.RJButton();
            this.labelTheme = new System.Windows.Forms.Label();
            this.btnSyncDate = new RJCodeAdvance.RJControls.RJButton();
            this.labelDate = new System.Windows.Forms.Label();
            this.datePicker = new RJCodeAdvance.RJControls.RJDatePicker();
            this.labelSetAdminpass = new System.Windows.Forms.Label();
            this.labelSetUserpass = new System.Windows.Forms.Label();
            this.btnSetUserpass = new RJCodeAdvance.RJControls.RJButton();
            this.textboxSetAdminpass = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnSetAdminpass = new RJCodeAdvance.RJControls.RJButton();
            this.textboxSetUserpass = new RJCodeAdvance.RJControls.RJTextBox();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.iconDiscord);
            this.panelRight.Controls.Add(this.iconTwitter);
            this.panelRight.Controls.Add(this.iconGitHub);
            this.panelRight.Controls.Add(this.labelSpam);
            this.panelRight.Controls.Add(this.rjCircularPictureBox1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(597, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(293, 400);
            this.panelRight.TabIndex = 0;
            // 
            // iconDiscord
            // 
            this.iconDiscord.FlatAppearance.BorderSize = 0;
            this.iconDiscord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconDiscord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconDiscord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconDiscord.IconChar = FontAwesome.Sharp.IconChar.Discord;
            this.iconDiscord.IconColor = System.Drawing.Color.Black;
            this.iconDiscord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDiscord.Location = new System.Drawing.Point(180, 218);
            this.iconDiscord.Name = "iconDiscord";
            this.iconDiscord.Size = new System.Drawing.Size(75, 50);
            this.iconDiscord.TabIndex = 4;
            this.iconDiscord.UseVisualStyleBackColor = true;
            this.iconDiscord.Click += new System.EventHandler(this.iconDiscord_Click);
            // 
            // iconTwitter
            // 
            this.iconTwitter.FlatAppearance.BorderSize = 0;
            this.iconTwitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconTwitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconTwitter.IconChar = FontAwesome.Sharp.IconChar.Twitter;
            this.iconTwitter.IconColor = System.Drawing.Color.Black;
            this.iconTwitter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTwitter.Location = new System.Drawing.Point(120, 218);
            this.iconTwitter.Name = "iconTwitter";
            this.iconTwitter.Size = new System.Drawing.Size(75, 50);
            this.iconTwitter.TabIndex = 3;
            this.iconTwitter.UseVisualStyleBackColor = true;
            this.iconTwitter.Click += new System.EventHandler(this.iconTwitter_Click);
            // 
            // iconGitHub
            // 
            this.iconGitHub.FlatAppearance.BorderSize = 0;
            this.iconGitHub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconGitHub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconGitHub.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.iconGitHub.IconColor = System.Drawing.Color.Black;
            this.iconGitHub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconGitHub.Location = new System.Drawing.Point(60, 218);
            this.iconGitHub.Name = "iconGitHub";
            this.iconGitHub.Size = new System.Drawing.Size(75, 50);
            this.iconGitHub.TabIndex = 2;
            this.iconGitHub.UseVisualStyleBackColor = true;
            this.iconGitHub.Click += new System.EventHandler(this.iconGithub_Click);
            // 
            // labelSpam
            // 
            this.labelSpam.AutoSize = true;
            this.labelSpam.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpam.Location = new System.Drawing.Point(37, 190);
            this.labelSpam.Name = "labelSpam";
            this.labelSpam.Size = new System.Drawing.Size(244, 25);
            this.labelSpam.TabIndex = 1;
            this.labelSpam.Text = "Created by ElMoha943";
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = global::AppBar.Properties.Resources.asuka_evangelion;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(65, 12);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(175, 175);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rjCircularPictureBox1.TabIndex = 0;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.comboboxSetTheme);
            this.panelCenter.Controls.Add(this.btnSyncTheme);
            this.panelCenter.Controls.Add(this.labelTheme);
            this.panelCenter.Controls.Add(this.btnSyncDate);
            this.panelCenter.Controls.Add(this.labelDate);
            this.panelCenter.Controls.Add(this.datePicker);
            this.panelCenter.Controls.Add(this.labelSetAdminpass);
            this.panelCenter.Controls.Add(this.labelSetUserpass);
            this.panelCenter.Controls.Add(this.btnSetUserpass);
            this.panelCenter.Controls.Add(this.textboxSetAdminpass);
            this.panelCenter.Controls.Add(this.btnSetAdminpass);
            this.panelCenter.Controls.Add(this.textboxSetUserpass);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(597, 400);
            this.panelCenter.TabIndex = 1;
            // 
            // comboboxSetTheme
            // 
            this.comboboxSetTheme.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboboxSetTheme.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboboxSetTheme.BorderSize = 2;
            this.comboboxSetTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboboxSetTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboboxSetTheme.ForeColor = System.Drawing.Color.DimGray;
            this.comboboxSetTheme.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboboxSetTheme.Items.AddRange(new object[] {
            "rojo",
            "amarillo",
            "verde",
            "azul",
            "morado"});
            this.comboboxSetTheme.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboboxSetTheme.ListTextColor = System.Drawing.Color.DimGray;
            this.comboboxSetTheme.Location = new System.Drawing.Point(182, 61);
            this.comboboxSetTheme.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboboxSetTheme.Name = "comboboxSetTheme";
            this.comboboxSetTheme.Padding = new System.Windows.Forms.Padding(2);
            this.comboboxSetTheme.Size = new System.Drawing.Size(250, 30);
            this.comboboxSetTheme.TabIndex = 25;
            this.comboboxSetTheme.Texts = "";
            this.comboboxSetTheme.OnSelectedIndexChanged += new System.EventHandler(this.comboboxSetTheme_OnSelectedIndexChanged);
            // 
            // btnSyncTheme
            // 
            this.btnSyncTheme.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSyncTheme.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSyncTheme.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSyncTheme.BorderRadius = 0;
            this.btnSyncTheme.BorderSize = 0;
            this.btnSyncTheme.FlatAppearance.BorderSize = 0;
            this.btnSyncTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyncTheme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSyncTheme.ForeColor = System.Drawing.Color.White;
            this.btnSyncTheme.Location = new System.Drawing.Point(439, 57);
            this.btnSyncTheme.Name = "btnSyncTheme";
            this.btnSyncTheme.Size = new System.Drawing.Size(150, 40);
            this.btnSyncTheme.TabIndex = 24;
            this.btnSyncTheme.Text = "Sincronizar";
            this.btnSyncTheme.TextColor = System.Drawing.Color.White;
            this.btnSyncTheme.UseVisualStyleBackColor = false;
            this.btnSyncTheme.Click += new System.EventHandler(this.btnSyncTheme_Click);
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTheme.Location = new System.Drawing.Point(7, 68);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(127, 19);
            this.labelTheme.TabIndex = 23;
            this.labelTheme.Text = "Color del Tema";
            // 
            // btnSyncDate
            // 
            this.btnSyncDate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSyncDate.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSyncDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSyncDate.BorderRadius = 0;
            this.btnSyncDate.BorderSize = 0;
            this.btnSyncDate.Enabled = false;
            this.btnSyncDate.FlatAppearance.BorderSize = 0;
            this.btnSyncDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyncDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSyncDate.ForeColor = System.Drawing.Color.White;
            this.btnSyncDate.Location = new System.Drawing.Point(439, 11);
            this.btnSyncDate.Name = "btnSyncDate";
            this.btnSyncDate.Size = new System.Drawing.Size(150, 40);
            this.btnSyncDate.TabIndex = 22;
            this.btnSyncDate.Text = "Sincronizar";
            this.btnSyncDate.TextColor = System.Drawing.Color.White;
            this.btnSyncDate.UseVisualStyleBackColor = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(7, 22);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(150, 19);
            this.labelDate.TabIndex = 21;
            this.labelDate.Text = "Fecha del Sistema";
            // 
            // datePicker
            // 
            this.datePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePicker.BorderSize = 0;
            this.datePicker.Enabled = false;
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePicker.Location = new System.Drawing.Point(182, 14);
            this.datePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(250, 35);
            this.datePicker.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.datePicker.TabIndex = 20;
            this.datePicker.TextColor = System.Drawing.Color.White;
            // 
            // labelSetAdminpass
            // 
            this.labelSetAdminpass.AutoSize = true;
            this.labelSetAdminpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetAdminpass.Location = new System.Drawing.Point(10, 158);
            this.labelSetAdminpass.Name = "labelSetAdminpass";
            this.labelSetAdminpass.Size = new System.Drawing.Size(155, 19);
            this.labelSetAdminpass.TabIndex = 19;
            this.labelSetAdminpass.Text = "Contraseña Admin";
            // 
            // labelSetUserpass
            // 
            this.labelSetUserpass.AutoSize = true;
            this.labelSetUserpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetUserpass.Location = new System.Drawing.Point(10, 112);
            this.labelSetUserpass.Name = "labelSetUserpass";
            this.labelSetUserpass.Size = new System.Drawing.Size(158, 19);
            this.labelSetUserpass.TabIndex = 14;
            this.labelSetUserpass.Text = "Contraseña Usuario";
            // 
            // btnSetUserpass
            // 
            this.btnSetUserpass.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSetUserpass.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSetUserpass.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSetUserpass.BorderRadius = 0;
            this.btnSetUserpass.BorderSize = 0;
            this.btnSetUserpass.FlatAppearance.BorderSize = 0;
            this.btnSetUserpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetUserpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSetUserpass.ForeColor = System.Drawing.Color.White;
            this.btnSetUserpass.Location = new System.Drawing.Point(439, 103);
            this.btnSetUserpass.Name = "btnSetUserpass";
            this.btnSetUserpass.Size = new System.Drawing.Size(150, 40);
            this.btnSetUserpass.TabIndex = 18;
            this.btnSetUserpass.Text = "Establecer";
            this.btnSetUserpass.TextColor = System.Drawing.Color.White;
            this.btnSetUserpass.UseVisualStyleBackColor = false;
            this.btnSetUserpass.Click += new System.EventHandler(this.btnSetUserpass_Click);
            // 
            // textboxSetAdminpass
            // 
            this.textboxSetAdminpass.BackColor = System.Drawing.SystemColors.Window;
            this.textboxSetAdminpass.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textboxSetAdminpass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textboxSetAdminpass.BorderRadius = 0;
            this.textboxSetAdminpass.BorderSize = 2;
            this.textboxSetAdminpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSetAdminpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxSetAdminpass.Location = new System.Drawing.Point(182, 106);
            this.textboxSetAdminpass.Margin = new System.Windows.Forms.Padding(4);
            this.textboxSetAdminpass.Multiline = false;
            this.textboxSetAdminpass.Name = "textboxSetAdminpass";
            this.textboxSetAdminpass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textboxSetAdminpass.PasswordChar = true;
            this.textboxSetAdminpass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textboxSetAdminpass.PlaceholderText = "";
            this.textboxSetAdminpass.Size = new System.Drawing.Size(250, 32);
            this.textboxSetAdminpass.TabIndex = 17;
            this.textboxSetAdminpass.Texts = "";
            this.textboxSetAdminpass.UnderlinedStyle = false;
            // 
            // btnSetAdminpass
            // 
            this.btnSetAdminpass.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSetAdminpass.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSetAdminpass.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSetAdminpass.BorderRadius = 0;
            this.btnSetAdminpass.BorderSize = 0;
            this.btnSetAdminpass.FlatAppearance.BorderSize = 0;
            this.btnSetAdminpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetAdminpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSetAdminpass.ForeColor = System.Drawing.Color.White;
            this.btnSetAdminpass.Location = new System.Drawing.Point(439, 149);
            this.btnSetAdminpass.Name = "btnSetAdminpass";
            this.btnSetAdminpass.Size = new System.Drawing.Size(150, 40);
            this.btnSetAdminpass.TabIndex = 16;
            this.btnSetAdminpass.Text = "Establecer";
            this.btnSetAdminpass.TextColor = System.Drawing.Color.White;
            this.btnSetAdminpass.UseVisualStyleBackColor = false;
            this.btnSetAdminpass.Click += new System.EventHandler(this.btnSetAdminpass_Click);
            // 
            // textboxSetUserpass
            // 
            this.textboxSetUserpass.BackColor = System.Drawing.SystemColors.Window;
            this.textboxSetUserpass.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textboxSetUserpass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textboxSetUserpass.BorderRadius = 0;
            this.textboxSetUserpass.BorderSize = 2;
            this.textboxSetUserpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxSetUserpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxSetUserpass.Location = new System.Drawing.Point(182, 152);
            this.textboxSetUserpass.Margin = new System.Windows.Forms.Padding(4);
            this.textboxSetUserpass.Multiline = false;
            this.textboxSetUserpass.Name = "textboxSetUserpass";
            this.textboxSetUserpass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textboxSetUserpass.PasswordChar = true;
            this.textboxSetUserpass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textboxSetUserpass.PlaceholderText = "";
            this.textboxSetUserpass.Size = new System.Drawing.Size(250, 32);
            this.textboxSetUserpass.TabIndex = 15;
            this.textboxSetUserpass.Texts = "";
            this.textboxSetUserpass.UnderlinedStyle = false;
            // 
            // AdminSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 400);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminSettings";
            this.Text = "AdminSettings";
            this.Load += new System.EventHandler(this.AdminSettings_Load);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRight;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private FontAwesome.Sharp.IconButton iconGitHub;
        private System.Windows.Forms.Label labelSpam;
        private System.Windows.Forms.Panel panelCenter;
        private RJCodeAdvance.RJControls.RJComboBox comboboxSetTheme;
        private RJCodeAdvance.RJControls.RJButton btnSyncTheme;
        private System.Windows.Forms.Label labelTheme;
        private RJCodeAdvance.RJControls.RJButton btnSyncDate;
        private System.Windows.Forms.Label labelDate;
        private RJCodeAdvance.RJControls.RJDatePicker datePicker;
        private System.Windows.Forms.Label labelSetAdminpass;
        private System.Windows.Forms.Label labelSetUserpass;
        private RJCodeAdvance.RJControls.RJButton btnSetUserpass;
        private RJCodeAdvance.RJControls.RJTextBox textboxSetAdminpass;
        private RJCodeAdvance.RJControls.RJButton btnSetAdminpass;
        private RJCodeAdvance.RJControls.RJTextBox textboxSetUserpass;
        private FontAwesome.Sharp.IconButton iconDiscord;
        private FontAwesome.Sharp.IconButton iconTwitter;
    }
}