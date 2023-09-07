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
            SqlCommand comando = new SqlCommand();
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

        public DataTable ConsultarMascota(string nombreSp, Parametro p )
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSp;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }
        //public bool ConfirmarAtencion(Cliente cliente, Mascota mascota, Atencion atencion)
        //{
        //    bool resultado = true;
        //    SqlTransaction t = null;
        //           try
        //            {
        //                conexion.Open();

        //                 t = conexion.BeginTransaction();
        //                SqlCommand cmd = new SqlCommand("SP_INSERTAR_MASCOTA", conexion, t);
        //                cmd.Transaction = t;
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.AddWithValue("@nombre", mascota.Nombre);
        //                cmd.Parameters.AddWithValue("@edad", mascota.Edad);
        //                cmd.Parameters.AddWithValue("@tipo", mascota.Tipo);
        //                cmd.Parameters.AddWithValue("cliente", cliente.IdCliente);
        //                SqlParameter param = new SqlParameter("@id_mascota", SqlDbType.Int);
        //                param.Direction = ParameterDirection.Output;
        //                cmd.Parameters.Add(param);
        //                cmd.ExecuteNonQuery();
        //                int nroMascota = Convert.ToInt32(param.Value);

        //                int cAtencion = 1;
        //                foreach (Atencion a in mascota.lstAtenciones)
        //                {
        //                    SqlCommand cmdAtencion = new SqlCommand("SP_INSERTAR_ATENCION", conexion, t );
        //                    cmdAtencion.CommandType = CommandType.StoredProcedure;
        //                    cmdAtencion.Parameters.AddWithValue("@descripcion", atencion.Descripcion);
        //                    cmdAtencion.Parameters.AddWithValue("@importe", atencion.Importe);
        //                    cmdAtencion.Parameters.AddWithValue("@fecha", atencion.Fecha);
        //                    cmdAtencion.Parameters.AddWithValue("@mascota", nroMascota);
        //                    cmdAtencion.ExecuteNonQuery();
        //                    cAtencion++;
        //                }


        //            }
        //            catch (Exception)
        //            {
        //                if (t != null)
        //                    t.Rollback();
        //                resultado = false;

        //            }
        //            finally
        //            {
        //                if (conexion != null && conexion.State == ConnectionState.Open)
        //                    conexion.Close();
        //            }
        //            return resultado;
        //}
        public bool Confirmar(Cliente cliente, Mascota mascota, Atencion atencion)
        {
            bool resultado = true;
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_INSERTAR_MASCOTA", conexion, t);
                cmd.Transaction = t;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", mascota.Nombre);
                cmd.Parameters.AddWithValue("@edad", mascota.Edad);
                cmd.Parameters.AddWithValue("@tipo", mascota.Tipo);
                cmd.Parameters.AddWithValue("cliente", cliente.IdCliente);
                SqlParameter param = new SqlParameter("@id_mascota", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                int nroMascota = Convert.ToInt32(param.Value);

                int cAtencion = 1;
                foreach (Atencion a in mascota.lstAtenciones)
                {
                    SqlCommand cmdAtencion = new SqlCommand("SP_INSERTAR_ATENCION", conexion, t);
                    cmdAtencion.CommandType = CommandType.StoredProcedure;
                    cmdAtencion.Parameters.AddWithValue("@descripcion", atencion.Descripcion);
                    cmdAtencion.Parameters.AddWithValue("@importe", atencion.Importe);
                    cmdAtencion.Parameters.AddWithValue("@fecha", atencion.Fecha);
                    cmdAtencion.Parameters.AddWithValue("@mascota", nroMascota);
                    cmdAtencion.ExecuteNonQuery();
                    cAtencion++;
                }
                t.Commit();

            }
            catch (Exception)
            {
                if (t != null)
                 t.Rollback();
                    resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return resultado;
        }
    }
}


    

