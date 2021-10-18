using System;
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
    public partial class FormDisplay : Form
    {
        public List<Comida> Comidas = new List<Comida>();
        readonly DB database = new DB();
        readonly DataTable dt = new DataTable();
        readonly Form1 form;
        public FormDisplay(Form1 frm1, string categoria)
        {
            form = frm1;
            this.BackColor = ControlPaint.Light(Theme.GetAccentColor());
            int x = 0 , y = 0, cant=0;
            InitializeComponent();
            dt = database.Mostrar();
            Console.WriteLine("Entrys: " + dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Comida food = new Comida();
                food.Nombre = dt.Rows[i]["nombre"].ToString();
                food.Precio = float.Parse(dt.Rows[i]["precio"].ToString());
                MemoryStream bb = ByteImage(i);
                food.Imagen = Image.FromStream(bb);
                food.Categoria = dt.Rows[i]["categoria"].ToString();
                Comidas.Add(food);
            }
            foreach (Comida food in Comidas)
            {
                if (categoria == food.Categoria)
                {
                    cant += 1;
                    Panel p = new Panel();
                    p.Size = new Size(150, 100);
                    p.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(p);
                    p.Location = new Point(x,y);
                    if (cant%4 == 0)
                    {
                        x = 0;
                        y += 100;
                        cant = 0;
                    }
                    else
                    {
                        x += 150;
                    }
                    p.BringToFront();

                    Label l = new Label();
                    l.Size = new Size(146, 24);
                    l.Text = "$" + food.Precio + " " + food.Nombre;
                    l.Font = new Font("Arial", 12, FontStyle.Bold);
                    l.TextAlign = ContentAlignment.MiddleCenter;
                    p.Controls.Add(l);
                    l.Dock = DockStyle.Top;


                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(148, 70);
                    pb.Image = food.Imagen;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Cursor = Cursors.Hand;
                    p.Controls.Add(pb);
                    pb.Dock = DockStyle.Top;

                    //AÑADIR EVENTOS ONCLICK
                    pb.Click += (sender, e) => addItem(sender, e, food);

                    Console.WriteLine("Producto Añadido");
                }
            }
        }

        private void addItem(object sender, EventArgs e, Comida food)
        {
            ventas.ticket.Add(food);
            form.updateGrid();
        }

        private MemoryStream ByteImage(int i)
        {
            byte[] img = (byte[])dt.Rows[i]["imagen"];
            MemoryStream ms = new MemoryStream(img);
            return ms;
        }
    }
}
