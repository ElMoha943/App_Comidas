using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppBar.Forms;

namespace AppBar
{
    public partial class Form1 : Form
    {
        private Form formActual;
        readonly BindingSource bs = new BindingSource();
        private float total=0;

        public Form1()
        {
            InitializeComponent(); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTheme();

            //TICKET DATAGRID
            bs.DataSource = ventas.ticket;
            updateGrid();
            dataGridView1.Columns["imagen"].Visible = false;
            dataGridView1.Columns["categoria"].Visible = false;

            //OPEN PROMOS FORM
            openChildForm("Promos");
            btnPromos.BackColor = AdminSettings.lightColor;
        }

        public void updateGrid()
        {
            dataGridView1.DataSource = bs;
            bs.ResetBindings(false);
        }

        private void openChildForm(string Category)
        {
            Form form = new Form();
            if (formActual != null) 
                formActual.Close();
            form = new FormDisplay(this, Category);
            formActual = form;
            form.TopLevel = false;
            panelChild.Controls.Add(form);
            panelChild.Tag = form;
            form.BringToFront();
            form.BackColor = AdminSettings.lightColor;
            form.Show();
        }
        private void LoadTheme()
        {
            panelTop.BackColor = AdminSettings.themeColor;
            panelLeft.BackColor = AdminSettings.darkColor;
            panelChild.BackColor = AdminSettings.lightColor;
            resetBtnColor();
            btnBuy.BackColor = AdminSettings.themeColor;
            btnCancel.BackColor = AdminSettings.themeColor;
            btnLogout.BackColor = AdminSettings.themeColor;
            dataGridView1.BackgroundColor = AdminSettings.themeColor;
            dataGridView1.GridColor = AdminSettings.darkColor;
        }

        private void resetBtnColor()
        {
            btnPromos.BackColor = AdminSettings.themeColor;
            btnPizzas.BackColor = AdminSettings.themeColor;
            btnBurguers.BackColor = AdminSettings.themeColor;
            btnFries.BackColor = AdminSettings.themeColor;
            btnDrinks.BackColor = AdminSettings.themeColor;
            btnDeserts.BackColor = AdminSettings.themeColor;
        }

        //BUTTON EVENTS
        private void btnPromos_Click(object sender, EventArgs e)
        {
            openChildForm("Promos");
            resetBtnColor();
            btnPromos.BackColor = AdminSettings.lightColor;
        }

        private void btnPizzas_Click(object sender, EventArgs e)
        {
            openChildForm("Pizzas");
            resetBtnColor();
            btnPizzas.BackColor = AdminSettings.lightColor;
        }

        private void btnBurguers_Click(object sender, EventArgs e)
        {
            openChildForm("Burguers");
            resetBtnColor();
            btnBurguers.BackColor = AdminSettings.lightColor;
        }

        private void btnFries_Click(object sender, EventArgs e)
        {
            openChildForm("Fries");
            resetBtnColor();
            btnFries.BackColor = AdminSettings.lightColor;
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            openChildForm("Drinks");
            resetBtnColor();
            btnDrinks.BackColor = AdminSettings.lightColor;
        }

        private void btnDeserts_Click(object sender, EventArgs e)
        {
            openChildForm("Deserts");
            resetBtnColor();
            btnDeserts.BackColor = AdminSettings.lightColor;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ventas.ticket.Clear();
            updateGrid();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            DB database = new DB();
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += printDocument1_PrintPage;
            try
            {
                printDocument1.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Imprimir: \n" + ex.Message);
            }
            try { 
                database.InsertarV(total, DateTime.Today, ventas.ticket);
                MessageBox.Show("Venta realizada y guardada exitosamente!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar la venta en la base de datos: \n"+ex.Message);
            }
            ventas.ticket.Clear();
            total = 0;
            updateGrid();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login.me.Show();
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial",12);
            int width = 300, height = 20;
            e.Graphics.DrawString("--- TICKET ---",font, Brushes.Black, new RectangleF(0, height += 20 , width, 20));
            foreach (Comida c in ventas.ticket)
            {
                total += c.Precio;
                e.Graphics.DrawString(c.Nombre+".........."+c.Precio, font, Brushes.Black, new RectangleF(1, height += 20, width, 20));
            }
            e.Graphics.DrawString("--- ------ ---", font, Brushes.Black, new RectangleF(0, height += 20, width, 20));
            e.Graphics.DrawString("Total: "+total, font, Brushes.Black, new RectangleF(0, height += 20, width, 20));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Login.me.Visible)
            {
                Environment.Exit(0);
            }
        }
    }

    public static class ventas
    {
        public static List<Comida> ticket = new List<Comida>();
    }
}
