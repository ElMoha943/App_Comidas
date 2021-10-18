
namespace AppBar
{
    partial class AdminProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textboxName = new RJCodeAdvance.RJControls.RJTextBox();
            this.labelProdNombre = new System.Windows.Forms.Label();
            this.labelProdPrice = new System.Windows.Forms.Label();
            this.textboxPrice = new RJCodeAdvance.RJControls.RJTextBox();
            this.labelProdCategory = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new RJCodeAdvance.RJControls.RJButton();
            this.btnDelete = new RJCodeAdvance.RJControls.RJButton();
            this.btnUpdate = new RJCodeAdvance.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textboxCategory = new RJCodeAdvance.RJControls.RJComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(586, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // textboxName
            // 
            this.textboxName.BackColor = System.Drawing.SystemColors.Window;
            this.textboxName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textboxName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textboxName.BorderRadius = 0;
            this.textboxName.BorderSize = 2;
            this.textboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxName.Location = new System.Drawing.Point(81, 123);
            this.textboxName.Margin = new System.Windows.Forms.Padding(4);
            this.textboxName.Multiline = false;
            this.textboxName.Name = "textboxName";
            this.textboxName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textboxName.PasswordChar = false;
            this.textboxName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textboxName.PlaceholderText = "";
            this.textboxName.Size = new System.Drawing.Size(200, 31);
            this.textboxName.TabIndex = 1;
            this.textboxName.Texts = "";
            this.textboxName.UnderlinedStyle = false;
            // 
            // labelProdNombre
            // 
            this.labelProdNombre.AutoSize = true;
            this.labelProdNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdNombre.Location = new System.Drawing.Point(6, 132);
            this.labelProdNombre.Name = "labelProdNombre";
            this.labelProdNombre.Size = new System.Drawing.Size(64, 17);
            this.labelProdNombre.TabIndex = 2;
            this.labelProdNombre.Text = "Nombre";
            // 
            // labelProdPrice
            // 
            this.labelProdPrice.AutoSize = true;
            this.labelProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdPrice.Location = new System.Drawing.Point(6, 171);
            this.labelProdPrice.Name = "labelProdPrice";
            this.labelProdPrice.Size = new System.Drawing.Size(54, 17);
            this.labelProdPrice.TabIndex = 4;
            this.labelProdPrice.Text = "Precio";
            // 
            // textboxPrice
            // 
            this.textboxPrice.BackColor = System.Drawing.SystemColors.Window;
            this.textboxPrice.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textboxPrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textboxPrice.BorderRadius = 0;
            this.textboxPrice.BorderSize = 2;
            this.textboxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxPrice.Location = new System.Drawing.Point(81, 162);
            this.textboxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPrice.Multiline = false;
            this.textboxPrice.Name = "textboxPrice";
            this.textboxPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textboxPrice.PasswordChar = false;
            this.textboxPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textboxPrice.PlaceholderText = "";
            this.textboxPrice.Size = new System.Drawing.Size(200, 31);
            this.textboxPrice.TabIndex = 3;
            this.textboxPrice.Texts = "";
            this.textboxPrice.UnderlinedStyle = false;
            // 
            // labelProdCategory
            // 
            this.labelProdCategory.AutoSize = true;
            this.labelProdCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdCategory.Location = new System.Drawing.Point(6, 210);
            this.labelProdCategory.Name = "labelProdCategory";
            this.labelProdCategory.Size = new System.Drawing.Size(78, 17);
            this.labelProdCategory.TabIndex = 6;
            this.labelProdCategory.Text = "Categoria";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppBar.Properties.Resources.box_document_outline_share_top_upload_icon_1320195323221671611;
            this.pictureBox1.InitialImage = global::AppBar.Properties.Resources.box_document_outline_share_top_upload_icon_1320195323221671611;
            this.pictureBox1.Location = new System.Drawing.Point(42, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(42, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 40);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Añadir Producto";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDelete.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(228, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(210, 40);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Eliminar Producto";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(12, 348);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(210, 40);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Editar Producto";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textboxCategory);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textboxName);
            this.panel1.Controls.Add(this.labelProdNombre);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.textboxPrice);
            this.panel1.Controls.Add(this.labelProdPrice);
            this.panel1.Controls.Add(this.labelProdCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(604, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 400);
            this.panel1.TabIndex = 12;
            // 
            // textboxCategory
            // 
            this.textboxCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textboxCategory.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textboxCategory.BorderSize = 1;
            this.textboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.textboxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textboxCategory.ForeColor = System.Drawing.Color.DimGray;
            this.textboxCategory.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.textboxCategory.Items.AddRange(new object[] {
            "Promos",
            "Pizzas",
            "Burguers",
            "Fries",
            "Drinks",
            "Desserts"});
            this.textboxCategory.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.textboxCategory.ListTextColor = System.Drawing.Color.DimGray;
            this.textboxCategory.Location = new System.Drawing.Point(81, 203);
            this.textboxCategory.MinimumSize = new System.Drawing.Size(200, 30);
            this.textboxCategory.Name = "textboxCategory";
            this.textboxCategory.Padding = new System.Windows.Forms.Padding(1);
            this.textboxCategory.Size = new System.Drawing.Size(200, 30);
            this.textboxCategory.TabIndex = 10;
            this.textboxCategory.Texts = "";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RJCodeAdvance.RJControls.RJTextBox textboxName;
        private System.Windows.Forms.Label labelProdNombre;
        private System.Windows.Forms.Label labelProdPrice;
        private RJCodeAdvance.RJControls.RJTextBox textboxPrice;
        private System.Windows.Forms.Label labelProdCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJCodeAdvance.RJControls.RJButton btnAdd;
        private RJCodeAdvance.RJControls.RJButton btnDelete;
        private RJCodeAdvance.RJControls.RJButton btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJComboBox textboxCategory;
    }
}