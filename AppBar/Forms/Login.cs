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
    
    public partial class Login : Form
    {
        public static Form me;
        public static string AdminPass = "Admin123";
        public static string UserPass = "User123";

        public Login()
        {
            InitializeComponent();
            me = this;
            AdminSettings.ChangeColors(Theme.GetAccentColor()); //NEEDS CHANGE TO USE SAVED VALUES
        }

        private void Loginn()
        {
            if (textboxUsername.Texts == "User")
            {
                if (textboxPassword.Texts == UserPass)
                {
                    Form f = new Form1();
                    f.Show();
                    this.Hide();
                    textboxPassword.Texts = "";
                    textboxUsername.Texts = "";
                }
                else MessageBox.Show("Contraseña Incorrecta");
            }
            else if (textboxUsername.Texts == "Admin")
            {
                if (textboxPassword.Texts == AdminPass)
                {
                    Form f = new AdminMainForm();
                    f.Show();
                    this.Hide();
                }
                else  MessageBox.Show("Contraseña Incorrecta");
            }
            else MessageBox.Show("Usuario Inexistente");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Loginn();
        }

        private void textboxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) Loginn();
        }

        private void textboxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) Loginn();
        }
    }
}
