using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AppBar.Forms;

namespace AppBar
{
    public partial class AdminVentas : Form
    {
        public static ChartColorPalette Pallete = new ChartColorPalette();
        public AdminVentas()
        {
            InitializeComponent();
        }

        private void AdminVentas_Load(object sender, EventArgs e)
        {
            DB database = new DB();
            DataTable dt = new DataTable();
            dt = database.Mostrar("ventas");
            chart1.DataSource = dataGridView1.DataSource = dt;
            chart1.Series[0].XValueMember = "fecha";
            chart1.Series[0].YValueMembers = "total";
            chart1.DataBind();
            LoadTheme();
        }
        private void LoadTheme()
        {
            chart1.Palette = Pallete;
            this.BackColor = AdminSettings.lightColor;
            panelRight.BackColor = AdminSettings.lightColor;
            dataGridView1.BackgroundColor = AdminSettings.themeColor;
            dataGridView1.GridColor = AdminSettings.darkColor;
            comboboxDate.BorderColor = AdminSettings.darkColor;
        }

        private void btnInspeccionar_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            int id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
            string message = "";
            DataTable dt = db.Mostrarpv(id);
            for (int i = 0;i<dt.Rows.Count;i++)
            {
                message += dt.Rows[i]["Nombre"] +" $"+ dt.Rows[i]["Precio"]+"\n";
            }
            MessageBox.Show(message);
        }

        private void comboboxDate_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            //...
        }
    }
}
