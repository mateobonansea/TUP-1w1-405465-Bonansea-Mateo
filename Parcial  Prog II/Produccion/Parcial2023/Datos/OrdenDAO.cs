using Produccion.Datos;
using Produccion.Domino;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2023.Dominio;
using System.Collections;

namespace Parcial2023.Datos
{
    internal class OrdenDAO : IOrdenDao
    {

        public int CrearOrden(OrdenProduccion nuevaOrden)
        {
            int nro_orden = 0;
            SqlConnection cnn = DBHelper.GetInstancia().GetConexion();
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmdMaestro = new SqlCommand("SP_INSERTAR_MAESTRO", cnn, t);

                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@modelo", nuevaOrden.Modelo) ;
                cmdMaestro.Parameters.AddWithValue("@fecha", nuevaOrden.Fecha);
                cmdMaestro.Parameters.AddWithValue("@estado", nuevaOrden.Estado);
                cmdMaestro.Parameters.AddWithValue("@cantidad", nuevaOrden.Cantidad);

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "nro_orden";
                parametro.Direction = ParameterDirection.Output;
                parametro.DbType = DbType.Int32;

                cmdMaestro.Parameters.Add(parametro);
                cmdMaestro.ExecuteNonQuery();

                nro_orden = Convert.ToInt32(parametro.Value);

                int detalle = 1;
                foreach (DetalleOrden d in nuevaOrden.Listadetalles)
                {
                    SqlCommand cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@nro_orden", nro_orden);
                    cmdDetalle.Parameters.AddWithValue("@id", detalle);
                    cmdDetalle.Parameters.AddWithValue("@componente", d.Componente.Codigo);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", d.Cantidad);

                    cmdDetalle.ExecuteNonQuery();
                    
                    detalle++;
                }

                t.Commit();
            }

            catch
            {
                if (t != null)
                    t.Rollback();
            }
            finally { cnn.Close(); }
            return nro_orden;
        }

        public List<Componente> ObtenerComponentes()
        {
           List<Componente> lista = new List<Componente>();

            DataTable dataTable = DBHelper.GetInstancia().Consultar("SP_CONSULTAR_COMPONENTES");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                int codigo = Convert.ToInt32(dataRow["codigo"]);
                string nombre = dataRow["nombre"].ToString();

                Componente componente = new Componente(codigo, nombre);

                lista.Add(componente);

            }
            return lista;
        }
    }
}
