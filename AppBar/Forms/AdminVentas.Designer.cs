
namespace AppBar
{
    partial class AdminVentas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminVentas));
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnInspeccionar = new RJCodeAdvance.RJControls.RJButton();
            this.labelGanancias = new System.Windows.Forms.Label();
            this.comboboxDate = new RJCodeAdvance.RJControls.RJComboBox();
            this.labelVentasRecientes = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // panelRight
            // 
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.dataGridView1);
            this.panelRight.Controls.Add(this.labelVentasRecientes);
            this.panelRight.Controls.Add(this.btnInspeccionar);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(604, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(286, 400);
            this.panelRight.TabIndex = 1;
            // 
            // btnInspeccionar
            // 
            this.btnInspeccionar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnInspeccionar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnInspeccionar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInspeccionar.BorderRadius = 0;
            this.btnInspeccionar.BorderSize = 0;
            this.btnInspeccionar.FlatAppearance.BorderSize = 0;
            this.btnInspeccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInspeccionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInspeccionar.ForeColor = System.Drawing.Color.White;
            this.btnInspeccionar.Location = new System.Drawing.Point(79, 348);
            this.btnInspeccionar.Name = "btnInspeccionar";
            this.btnInspeccionar.Size = new System.Drawing.Size(150, 40);
            this.btnInspeccionar.TabIndex = 1;
            this.btnInspeccionar.Text = "Inspeccionar";
            this.btnInspeccionar.TextColor = System.Drawing.Color.White;
            this.btnInspeccionar.UseVisualStyleBackColor = false;
            this.btnInspeccionar.Click += new System.EventHandler(this.btnInspeccionar_Click);
            // 
            // labelGanancias
            // 
            this.labelGanancias.AutoSize = true;
            this.labelGanancias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGanancias.Location = new System.Drawing.Point(12, 9);
            this.labelGanancias.Name = "labelGanancias";
            this.labelGanancias.Size = new System.Drawing.Size(181, 19);
            this.labelGanancias.TabIndex = 2;
            this.labelGanancias.Text = "Grafico de Ganancias";
            // 
            // comboboxDate
            // 
            this.comboboxDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboboxDate.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboboxDate.BorderSize = 2;
            this.comboboxDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboboxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboboxDate.ForeColor = System.Drawing.Color.DimGray;
            this.comboboxDate.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboboxDate.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboboxDate.ListTextColor = System.Drawing.Color.DimGray;
            this.comboboxDate.Location = new System.Drawing.Point(398, 6);
            this.comboboxDate.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboboxDate.Name = "comboboxDate";
            this.comboboxDate.Padding = new System.Windows.Forms.Padding(2);
            this.comboboxDate.Size = new System.Drawing.Size(200, 30);
            this.comboboxDate.TabIndex = 3;
            this.comboboxDate.Texts = "";
            this.comboboxDate.OnSelectedIndexChanged += new System.EventHandler(this.comboboxDate_OnSelectedIndexChanged);
            // 
            // labelVentasRecientes
            // 
            this.labelVentasRecientes.AutoSize = true;
            this.labelVentasRecientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVentasRecientes.Location = new System.Drawing.Point(75, 9);
            this.labelVentasRecientes.Name = "labelVentasRecientes";
            this.labelVentasRecientes.Size = new System.Drawing.Size(138, 19);
            this.labelVentasRecientes.TabIndex = 4;
            this.labelVentasRecientes.Text = "Ventas Recientes";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 42);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(582, 346);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
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
            this.dataGridView1.Location = new System.Drawing.Point(22, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 300);
            this.dataGridView1.TabIndex = 5;
            // 
            // AdminVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 400);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.comboboxDate);
            this.Controls.Add(this.labelGanancias);
            this.Controls.Add(this.panelRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminVentas";
            this.Text = "AdminVentas";
            this.Load += new System.EventHandler(this.AdminVentas_Load);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Panel panelRight;
        private RJCodeAdvance.RJControls.RJButton btnInspeccionar;
        private System.Windows.Forms.Label labelGanancias;
        private System.Windows.Forms.Label labelVentasRecientes;
        private RJCodeAdvance.RJControls.RJComboBox comboboxDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}