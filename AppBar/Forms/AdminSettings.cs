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
            textboxSetUserpass.BorderColor = darkColor;
            textboxSetAdminpass.BorderColor = darkColor;
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
                    AdminVentas.Pallete = ChartColorPalette.Fire;
                    break;
                case "amarillo":
                    themeColor = Color.FromArgb(255, 140, 0);
                    AdminVentas.Pallete = ChartColorPalette.EarthTones;
                    break;
                case "verde":
                    themeColor = Color.FromArgb(0, 204, 106);
                    AdminVentas.Pallete = ChartColorPalette.BrightPastel;
                    break;
                case "azul":
                    themeColor = Color.FromArgb(0, 99, 177);
                    AdminVentas.Pallete = ChartColorPalette.SeaGreen;
                    break;
                case "morado":
                    themeColor = Color.FromArgb(116, 77, 169);
                    AdminVentas.Pallete = ChartColorPalette.Berry;
                    break;
            }
            ChangeColors(themeColor);
            LoadTheme();
        }


        private bool validatePassword(string pass)
        {
            bool upper = false, lower = false, digit = false, simbol = false, len = false;
            if (pass.Length >= 8) len = true;
            for (int i = 0; i < pass.Length; i++)
            {
                if (Char.IsUpper(pass, i)) upper = true;
                else if (Char.IsLower(pass, i)) lower = true;
                else if (Char.IsDigit(pass, i)) digit = true;
                else simbol = true;
            }
            if (upper == true && lower == true && digit == true && len == true)
                return true;
            else
                return false;
        }
        private void btnSetUserpass_Click(object sender, EventArgs e)
        {
            if (validatePassword(textboxSetUserpass.Texts))
            {
                Login.UserPass = textboxSetUserpass.Texts;
                MessageBox.Show("Contraseña cambiada!");
            }
            else
            {
                ToolTip myToolTip = new ToolTip();
                myToolTip.IsBalloon = true;
                myToolTip.Show("Esa contraseña no es valida", this.textboxSetUserpass);
            }  
        }

        private void btnSetAdminpass_Click(object sender, EventArgs e)
        {
            if (validatePassword(textboxSetAdminpass.Texts))
            {
                Login.AdminPass = textboxSetAdminpass.Texts;
                MessageBox.Show("Contraseña cambiada!");
            }
            else
            {
                ToolTip myToolTip = new ToolTip();
                myToolTip.IsBalloon = true;
                myToolTip.Show("Esa contraseña no es valida", this.textboxSetAdminpass);
            }
                
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
