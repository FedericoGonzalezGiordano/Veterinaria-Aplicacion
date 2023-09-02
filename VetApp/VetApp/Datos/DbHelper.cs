using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using VetApp.Dominio;

namespace VetApp.Datos
{
    public class DbHelper
    {
        private SqlConnection conexion;
        private string cadenaConexion;
        
        
        
   



        public DbHelper()
        {
               cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=VetApp;Integrated Security=True";
               conexion = new SqlConnection(cadenaConexion);
         
        }
        //public int ProximaAtencion()
        //{
        //    conexion.Open();
        //    SqlCommand comando = new SqlCommand();
        //    comando.Connection = conexion;
        //    comando.CommandType = CommandType.StoredProcedure;
        //    comando.CommandText = "SP_PROXIMO_ID";
        //    SqlParameter parametro = new SqlParameter();//Se pueden poner con parametros, y no ponerlo abajo("@Next",SqlDbType.Int )
        //    parametro.ParameterName = "@next";
        //    parametro.SqlDbType = SqlDbType.Int;
        //    parametro.Direction = ParameterDirection.Output;
        //    comando.Parameters.Add(parametro);
        //    comando.ExecuteNonQuery();
        //    conexion.Close();
        //    return (int)parametro.Value;
        //}

        public void AgregarCliente(Cliente cliente)
        {
            conexion.Open();
            SqlCommand comando=new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_INSERTAR_CLIENTE";
            comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@Sexo", cliente.Sexo);
            comando.ExecuteNonQuery();
            conexion.Close();
           
        }

        public int ProximoCliente()
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_PROXIMO_CLIENTE";
            SqlParameter parametro = new SqlParameter();//Se pueden poner con parametros, y no ponerlo abajo("@Next",SqlDbType.Int )
            parametro.ParameterName = "@nroCliente";
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;
            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();
            conexion.Close();
            return (int)parametro.Value;
        }


        public DataTable Consultar(string nombreSp)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSp;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }
        

    }
}
