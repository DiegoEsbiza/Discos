using Conexiones;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TiposEdicionNegocio
    {
        public List<TiposEdicion> Listar()
        {
            List<TiposEdicion> lista = new List<TiposEdicion>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("Select Id, Descripcion from TIPOSEDICION");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    TiposEdicion aux = new TiposEdicion();

                    aux.id = (int)datos.Lector["Id"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);

                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        
    }
}
