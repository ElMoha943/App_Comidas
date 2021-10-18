using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBar
{
    public partial class AdminMainForm : Form
    {
        private Form formActual;
        public AdminMainForm()
        {
            InitializeComponent();
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
            }
            formActual = form;
            form.TopLevel = false;
            panelChild.Controls.Add(form);
            panelChild.Tag = form;
            form.BringToFront();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //login.show();
            this.Hide();
        }
    }
}
