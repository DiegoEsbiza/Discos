using Conexiones;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EstilosNegocio
    {
        public List<Estilos> Listar()
        {
			List<Estilos> lista = new List<Estilos> ();
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.SetearConsulta("Select Id, Descripcion from ESTILOS");
				datos.EjecutarLectura();

				while (datos.Lector.Read())
				{
					Estilos aux = new Estilos();

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
