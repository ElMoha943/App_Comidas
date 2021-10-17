﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppBar
{

    public partial class Admin : Form
    {
        DB database = new DB();
        bool editMode = false;
        int id;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            loadTheme();
            try
            {
                dataGridView1.DataSource = database.Mostrar();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadTheme()
        {
            Color theme = Theme.GetAccentColor();
            Color light = ControlPaint.Light(theme);
            Color dark = ControlPaint.Dark(theme);
            this.BackColor = light;
            btnAdd.BackColor = theme;
            btnUpdate.BackColor = theme;
            btnDelete.BackColor = theme;
            textboxName.BackColor = theme;
            textboxName.BorderColor = dark;
            textboxPrice.BackColor = theme;
            textboxPrice.BorderColor = dark;
            textboxCategory.BackColor = theme;
            textboxCategory.BorderColor = dark;
        }

        private void MostrarProductos()
        {
            DB database = new DB(); //REFRESCA EL OBJETO
            dataGridView1.DataSource = database.Mostrar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            DialogResult dr = of.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(of.FileName);
            }
        }
        private byte[] ConvertirImg()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.GetBuffer();
        }

        private MemoryStream ByteImage()
        {
            byte[] img = (byte[])dataGridView1.CurrentRow.Cells["imagen"].Value;
            MemoryStream ms = new MemoryStream(img);
            return ms;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(editMode == false)
            {
                try
                {
                    database.Insertar(textboxName.Texts, float.Parse(textboxPrice.Texts), ConvertirImg(), textboxCategory.Texts);
                    MessageBox.Show("Producto añadido correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }     
            else
            {
                try
                {
                    database.Editar(textboxName.Texts, float.Parse(textboxPrice.Texts), ConvertirImg(), textboxCategory.Texts, id);
                    MessageBox.Show("Producto editado correctamente");
                    editMode = false;
                    btnAdd.Text = "Añadir Producto";
                    textboxName.Texts = "";
                    textboxPrice.Texts = "";
                    textboxCategory.Texts = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MostrarProductos();
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if(editMode == false)
                {
                    id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                    editMode = true;
                    textboxName.Texts = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString(); ;
                    textboxPrice.Texts = dataGridView1.CurrentRow.Cells["precio"].Value.ToString(); ;
                    textboxCategory.Texts = dataGridView1.CurrentRow.Cells["categoria"].Value.ToString();
                    pictureBox1.Image = Image.FromStream(ByteImage());
                    btnAdd.Text = "Guardar Cambios";
                    btnUpdate.Text = "Cancelar Edicion";
                }
                else
                {
                    editMode = false;
                    btnAdd.Text = "Añadir Producto";
                    textboxName.Texts = "";
                    textboxPrice.Texts = "";
                    textboxCategory.Texts = "";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                    database.Eliminar(id);
                    MessageBox.Show("Producto borrado correctamente");
                    MostrarProductos();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                
        }
    }
}
