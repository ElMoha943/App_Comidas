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
    public partial class AdminMainForm : Form
    {
        private Form formActual;
        public static AdminMainForm Me;
        public static void changeTheme()
        {
            AdminMainForm.Me.LoadTheme();
        }
        public AdminMainForm()
        {
            InitializeComponent();
            LoadTheme();
            Me = this;
        }

        private void LoadTheme()
        {
            panelTop.BackColor = AdminSettings.themeColor;
            panelLeft.BackColor = AdminSettings.darkColor;
            panelChild.BackColor = AdminSettings.lightColor;
            btnProducts.BackColor = AdminSettings.themeColor;
            btnVentas.BackColor = AdminSettings.themeColor;
            btnSettings.BackColor = AdminSettings.themeColor;
            btnLogout.BackColor = AdminSettings.themeColor;
        }

        private void openChildForm(string Category)
        {
            Form form = new Form();
            if (formActual != null)
            {
                formActual.Close();
            }
            switch (Category)
            {
                case "Productos":
                    form = new AdminProductos();
                    break;
                case "Ventas":
                    form = new AdminVentas();
                    break;
                case "Opciones":
                    form = new AdminSettings();
                    break;
            }
            formActual = form;
            form.TopLevel = false;
            panelChild.Controls.Add(form);
            panelChild.Tag = form;
            form.BringToFront();
            formActual.BackColor = AdminSettings.lightColor;
            form.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            openChildForm("Productos");
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            openChildForm("Ventas");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            openChildForm("Opciones");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {    
            Login.me.Show();
            this.Close();
        }

        private void AdminMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Login.me.Visible)
            {
                Environment.Exit(0);
            }
        }
    }
}
