using System;
using System.Data;
using System.Data.SqlClient;

namespace AppBar
{
    class DB
    {
        private SqlConnection Conexion = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=comida;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        //MUESTRA TODOS LOS productos
        public DataTable Mostrar()
        {
            comando.Connection = AbrirConexion();
            comando.CommandText = "select * from productos;";
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
        }

        //ELIMINA UN PRODUCTO
        public void Eliminar(int id)
        {
            comando.Connection = AbrirConexion();
            comando.CommandText = "DELETE FROM productos WHERE id=" + id + ";";
            comando.ExecuteNonQuery();
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
