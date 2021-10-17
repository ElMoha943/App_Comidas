using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBar
{
    public class Comida
    {
        string nombre;
        float precio;
        Image imagen;
        string categoria;

        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public Image Imagen { get => imagen; set => imagen = value; }
        public string Categoria { get => categoria; set => categoria = value; }
    }
}
