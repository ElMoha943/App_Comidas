using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AppBar
{
    class DB
    {
        private readonly SqlConnection Conexion = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=comida;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

        SqlDataReader leer;
        readonly DataTable tabla = new DataTable();
        readonly SqlCommand comando = new SqlCommand();

        //CREA UNA NUEVA VENTA
        public void InsertarV(float total, DateTime fecha, List<Comida> Productos)
        {
            comando.Connection = AbrirConexion();
            comando.CommandText = "INSERT INTO ventas output INSERTED.ID VALUES(@total, @fecha)";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@total", total);
            comando.Parameters.AddWithValue("@fecha", fecha);
            int id = (int)comando.ExecuteScalar();
            comando.Parameters.Clear();
            foreach (Comida c in Productos)
            {
                comando.CommandText = "INSERT INTO ventas_prod VALUES(@nombre, @precio, @id_venta)";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@nombre", c.Nombre);
                comando.Parameters.AddWithValue("@precio", c.Precio);
                comando.Parameters.AddWithValue("@id_venta", id);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            CerrarConexion();
        }

        //MUESTRA TODOS LOS PRODUCTOS/VENTAS
        public DataTable Mostrar(string table)
        {
            comando.Connection = AbrirConexion();
            comando.CommandText = "select * from "+table+";";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            CerrarConexion();
            return tabla;
        }

        public DataTable Mostrarpv(int id)
        {
            comando.Connection = AbrirConexion();
            comando.CommandText = "select * from ventas_prod where id_venta = "+ id +";";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            CerrarConexion();
            return tabla;
        }

        //CREA UN PRODUCTO NUEVO
        public void Insertar(string nombre, float precio, byte[] imagen, string categoria)
        {

            comando.Connection = AbrirConexion();
            comando.CommandText = "INSERT INTO productos VALUES(@nombre, @precio, @imagen, @categoria)";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@imagen", imagen);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CerrarConexion();
        }

        //EDITA UN PRODUCTO
        public void Editar(string nombre, float precio, byte[] imagen, string categoria, int id)
        {

            comando.Connection = AbrirConexion();
            comando.CommandText = "UPDATE productos SET nombre = @nombre, precio = @precio, imagen= @imagen, categoria = @categoria WHERE id = @id";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@imagen", imagen);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            CerrarConexion();
        }

        //ELIMINA UN PRODUCTO
        public void Eliminar(int id)
        {
            comando.Connection = AbrirConexion();
            comando.CommandText = "DELETE FROM productos WHERE id=" + id + ";";
            comando.ExecuteNonQuery();
            CerrarConexion();
        }

        //BUSCA UN PRODUCTO EN ESPECIFICO
        public DataTable Buscar(int id)
        {
            comando.Connection = AbrirConexion();
            comando.CommandText = "SELECT * from productos WHERE id=" + id + ";";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            CerrarConexion();
            return tabla;
        }
    }
}
