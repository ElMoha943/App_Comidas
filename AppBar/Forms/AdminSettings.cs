using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBar.Forms
{
    public partial class AdminSettings : Form
    {
        public static Color themeColor;
        public static Color lightColor;
        public static Color darkColor;
        public static Color sdarkColor;
        public static Color slightColor;
        public AdminSettings()
        {
            InitializeComponent();
        }

        private void AdminSettings_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnSyncTheme_Click(object sender, EventArgs e)
        {
            ChangeColors(Theme.GetAccentColor());
            LoadTheme();
        }

        public static void ChangeColors(Color theme)
        {
            themeColor = theme;
            lightColor = ControlPaint.Light(themeColor);
            darkColor = ControlPaint.Dark(themeColor);
            //Unused Colors
            slightColor = ControlPaint.LightLight(themeColor);
            sdarkColor = ControlPaint.DarkDark(themeColor);
        }

        private void LoadTheme()
        {
            panelCenter.BackColor = lightColor;
            panelRight.BackColor = lightColor;
            btnSetAdminpass.BackColor = themeColor;
            btnSetAdminpass.BorderColor = darkColor;
            btnSetUserpass.BackColor = themeColor;
            btnSetUserpass.BorderColor = darkColor;
            btnSyncDate.BackColor = themeColor;
            btnSyncDate.BorderColor = darkColor;
            btnSyncTheme.BackColor = themeColor;
            btnSyncTheme.BorderColor = darkColor;
            textboxSetAdminpass.BorderColor = darkColor;
            textboxSetUserpass.BorderColor = darkColor;
            comboboxSetTheme.BorderColor = darkColor;
            datePicker.SkinColor = themeColor;
            datePicker.BorderColor = darkColor;
            rjCircularPictureBox1.BorderColor = darkColor;
            rjCircularPictureBox1.BorderColor2 = sdarkColor;
            AdminMainForm.changeTheme();
        }

        private void comboboxSetTheme_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboboxSetTheme.Texts)
            {
                case "rojo":
                    themeColor = Color.FromArgb(232,17,35);
                    break;
                case "amarillo":
                    themeColor = Color.FromArgb(255, 140, 0);
                    break;
                case "verde":
                    themeColor = Color.FromArgb(0, 204, 106);
                    break;
                case "azul":
                    themeColor = Color.FromArgb(0, 99, 177);
                    break;
                case "morado":
                    themeColor = Color.FromArgb(116, 77, 169);
                    break;
            }
            ChangeColors(themeColor);
        }

        private void btnSetUserpass_Click(object sender, EventArgs e)
        {
            Login.UserPass = textboxSetUserpass.Texts;
            MessageBox.Show("Contraseña cambiada!");
        }

        private void btnSetAdminpass_Click(object sender, EventArgs e)
        {
            Login.AdminPass = textboxSetAdminpass.Texts;
            MessageBox.Show("Contraseña cambiada!");
        }

        private void iconGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ElMoha943");
        }

        private void iconTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/Valendidio943");
        }

        private void iconDiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discordapp.com/users/259183988604796945/");
        }

    }
}
