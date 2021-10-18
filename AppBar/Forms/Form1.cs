using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            btnPromos.BackColor = AdminSettings.themeColor;
            btnPizzas.BackColor = AdminSettings.themeColor;
            btnBurguers.BackColor = AdminSettings.themeColor;
            btnFries.BackColor = AdminSettings.themeColor;
            btnDrinks.BackColor = AdminSettings.themeColor;
            btnDeserts.BackColor = AdminSettings.themeColor;
            btnBuy.BackColor = AdminSettings.themeColor;
            btnCancel.BackColor = AdminSettings.themeColor;
            btnLogout.BackColor = AdminSettings.themeColor;
        }

        //BUTTON EVENTS
        private void btnPromos_Click(object sender, EventArgs e)
        {
            openChildForm("Promos");
        }

        private void btnPizzas_Click(object sender, EventArgs e)
        {
            openChildForm("Pizzas");
        }

        private void btnBurguers_Click(object sender, EventArgs e)
        {
            openChildForm("Burguers");
        }

        private void btnFries_Click(object sender, EventArgs e)
        {
            openChildForm("Fries");
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            openChildForm("Drinks");
        }

        private void btnDeserts_Click(object sender, EventArgs e)
        {
            openChildForm("Deserts");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ventas.ticket.Clear();
            updateGrid();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            float total = 0;
            foreach(Comida c in ventas.ticket)
            {
                total += c.Precio;
            }
            MessageBox.Show("Total a pagar: " + total);
            ventas.ticket.Clear();
            updateGrid();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login.me.Show();
            this.Close();
        }
    }

    public static class ventas
    {
        public static List<Comida> ticket = new List<Comida>();
    }
}
