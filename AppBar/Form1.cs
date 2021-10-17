using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32; //USED FOR THEME CHANGE EVENT

namespace AppBar
{
    public partial class Form1 : Form
    {
        private UserPreferenceChangedEventHandler UserPreferenceChanged;
        private Form formActual;
        readonly BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent(); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //THEME
            LoadTheme();
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);

            //TICKET DATAGRID
            bs.DataSource = sexo.ticket;
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
            {
                formActual.Close();
                if (formActual is Admin){
                    panelRight.Size = new Size(290, 400);
                }
            }
            if (Category == "Admin")
            {
                form = new Admin();
                panelRight.Size = new Size(0, 0);
            }
            else
            {
                form = new FormDisplay(this, Category);
            }
            formActual = form;
            form.TopLevel = false;
            panelChild.Controls.Add(form);
            panelChild.Tag = form;
            form.BringToFront();
            form.Show();
        }

        //THEME METODS
        private void Form_Disposed(object sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if(e.Category==UserPreferenceCategory.General || e.Category == UserPreferenceCategory.VisualStyle)
            {
                LoadTheme();
            }
        }

        private void LoadTheme()
        {
            var themeColor = Theme.GetAccentColor();
            var lightColor = ControlPaint.Light(themeColor);
            var darkColor = ControlPaint.Dark(themeColor);
            //Apply Color
            panelTop.BackColor = themeColor;
            panelLeft.BackColor = darkColor;
            panelChild.BackColor = lightColor;
            btnPromos.BackColor = themeColor;
            btnPizzas.BackColor = themeColor;
            btnBurguers.BackColor = themeColor;
            btnFries.BackColor = themeColor;
            btnDrinks.BackColor = themeColor;
            btnDeserts.BackColor = themeColor;
            btnBuy.BackColor = themeColor;
            btnCancel.BackColor = themeColor;

            if (formActual != null) formActual.BackColor = lightColor;
        }

        //BUTTON EVENTS
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            openChildForm("Admin");
        }
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
            sexo.ticket.Clear();
            updateGrid();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

            //...
            sexo.ticket.Clear();
            updateGrid();
        }

    }

    public static class sexo
    {
        public static List<Comida> ticket = new List<Comida>();
    }
}
