
namespace AppBar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnBuy = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnAdmin = new FontAwesome.Sharp.IconButton();
            this.btnDeserts = new FontAwesome.Sharp.IconButton();
            this.btnDrinks = new FontAwesome.Sharp.IconButton();
            this.btnFries = new FontAwesome.Sharp.IconButton();
            this.btnBurguers = new FontAwesome.Sharp.IconButton();
            this.btnPizzas = new FontAwesome.Sharp.IconButton();
            this.btnPromos = new FontAwesome.Sharp.IconButton();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChild = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnBuy);
            this.panelTop.Controls.Add(this.btnCancel);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1070, 50);
            this.panelTop.TabIndex = 0;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuy.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnBuy.IconColor = System.Drawing.Color.Black;
            this.btnBuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuy.IconSize = 32;
            this.btnBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuy.Location = new System.Drawing.Point(780, 0);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(145, 50);
            this.btnBuy.TabIndex = 7;
            this.btnBuy.Text = "Comprar";
            this.btnBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(925, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 50);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnAdmin);
            this.panelLeft.Controls.Add(this.btnDeserts);
            this.panelLeft.Controls.Add(this.btnDrinks);
            this.panelLeft.Controls.Add(this.btnFries);
            this.panelLeft.Controls.Add(this.btnBurguers);
            this.panelLeft.Controls.Add(this.btnPizzas);
            this.panelLeft.Controls.Add(this.btnPromos);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 50);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(180, 400);
            this.panelLeft.TabIndex = 1;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnAdmin.IconColor = System.Drawing.Color.Black;
            this.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmin.IconSize = 32;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 350);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(180, 50);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnDeserts
            // 
            this.btnDeserts.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeserts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeserts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeserts.FlatAppearance.BorderSize = 0;
            this.btnDeserts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeserts.IconChar = FontAwesome.Sharp.IconChar.IceCream;
            this.btnDeserts.IconColor = System.Drawing.Color.Black;
            this.btnDeserts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeserts.IconSize = 32;
            this.btnDeserts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeserts.Location = new System.Drawing.Point(0, 250);
            this.btnDeserts.Name = "btnDeserts";
            this.btnDeserts.Size = new System.Drawing.Size(180, 50);
            this.btnDeserts.TabIndex = 5;
            this.btnDeserts.Text = "Postres";
            this.btnDeserts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeserts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeserts.UseVisualStyleBackColor = false;
            this.btnDeserts.Click += new System.EventHandler(this.btnDeserts_Click);
            // 
            // btnDrinks
            // 
            this.btnDrinks.BackColor = System.Drawing.SystemColors.Control;
            this.btnDrinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrinks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrinks.FlatAppearance.BorderSize = 0;
            this.btnDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrinks.IconChar = FontAwesome.Sharp.IconChar.GlassCheers;
            this.btnDrinks.IconColor = System.Drawing.Color.Black;
            this.btnDrinks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDrinks.IconSize = 32;
            this.btnDrinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrinks.Location = new System.Drawing.Point(0, 200);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(180, 50);
            this.btnDrinks.TabIndex = 4;
            this.btnDrinks.Text = "Bebida";
            this.btnDrinks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrinks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDrinks.UseVisualStyleBackColor = false;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // btnFries
            // 
            this.btnFries.BackColor = System.Drawing.SystemColors.Control;
            this.btnFries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFries.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFries.FlatAppearance.BorderSize = 0;
            this.btnFries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFries.IconChar = FontAwesome.Sharp.IconChar.Bacon;
            this.btnFries.IconColor = System.Drawing.Color.Black;
            this.btnFries.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFries.IconSize = 32;
            this.btnFries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFries.Location = new System.Drawing.Point(0, 150);
            this.btnFries.Name = "btnFries";
            this.btnFries.Size = new System.Drawing.Size(180, 50);
            this.btnFries.TabIndex = 3;
            this.btnFries.Text = "Guarniciones";
            this.btnFries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFries.UseVisualStyleBackColor = false;
            this.btnFries.Click += new System.EventHandler(this.btnFries_Click);
            // 
            // btnBurguers
            // 
            this.btnBurguers.BackColor = System.Drawing.SystemColors.Control;
            this.btnBurguers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBurguers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBurguers.FlatAppearance.BorderSize = 0;
            this.btnBurguers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBurguers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurguers.IconChar = FontAwesome.Sharp.IconChar.Hamburger;
            this.btnBurguers.IconColor = System.Drawing.Color.Black;
            this.btnBurguers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBurguers.IconSize = 32;
            this.btnBurguers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBurguers.Location = new System.Drawing.Point(0, 100);
            this.btnBurguers.Name = "btnBurguers";
            this.btnBurguers.Size = new System.Drawing.Size(180, 50);
            this.btnBurguers.TabIndex = 2;
            this.btnBurguers.Text = "Hamburguesas";
            this.btnBurguers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBurguers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBurguers.UseVisualStyleBackColor = false;
            this.btnBurguers.Click += new System.EventHandler(this.btnBurguers_Click);
            // 
            // btnPizzas
            // 
            this.btnPizzas.BackColor = System.Drawing.SystemColors.Control;
            this.btnPizzas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPizzas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPizzas.FlatAppearance.BorderSize = 0;
            this.btnPizzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPizzas.IconChar = FontAwesome.Sharp.IconChar.PizzaSlice;
            this.btnPizzas.IconColor = System.Drawing.Color.Black;
            this.btnPizzas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPizzas.IconSize = 32;
            this.btnPizzas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPizzas.Location = new System.Drawing.Point(0, 50);
            this.btnPizzas.Name = "btnPizzas";
            this.btnPizzas.Size = new System.Drawing.Size(180, 50);
            this.btnPizzas.TabIndex = 1;
            this.btnPizzas.Text = "Pizzas";
            this.btnPizzas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPizzas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPizzas.UseVisualStyleBackColor = false;
            this.btnPizzas.Click += new System.EventHandler(this.btnPizzas_Click);
            // 
            // btnPromos
            // 
            this.btnPromos.BackColor = System.Drawing.SystemColors.Control;
            this.btnPromos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPromos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPromos.FlatAppearance.BorderSize = 0;
            this.btnPromos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromos.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnPromos.IconColor = System.Drawing.Color.Black;
            this.btnPromos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPromos.IconSize = 32;
            this.btnPromos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromos.Location = new System.Drawing.Point(0, 0);
            this.btnPromos.Name = "btnPromos";
            this.btnPromos.Size = new System.Drawing.Size(180, 50);
            this.btnPromos.TabIndex = 0;
            this.btnPromos.Text = "Promociones";
            this.btnPromos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPromos.UseVisualStyleBackColor = false;
            this.btnPromos.Click += new System.EventHandler(this.btnPromos_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.dataGridView1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(780, 50);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(290, 400);
            this.panelRight.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(290, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto Piola";
            // 
            // panelChild
            // 
            this.panelChild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(180, 50);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(600, 400);
            this.panelChild.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 70);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 450);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private FontAwesome.Sharp.IconButton btnPromos;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnBuy;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnDeserts;
        private FontAwesome.Sharp.IconButton btnDrinks;
        private FontAwesome.Sharp.IconButton btnFries;
        private FontAwesome.Sharp.IconButton btnBurguers;
        private FontAwesome.Sharp.IconButton btnPizzas;
        private System.Windows.Forms.Panel panelChild;
        private FontAwesome.Sharp.IconButton btnAdmin;
    }
}

