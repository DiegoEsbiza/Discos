using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Conexiones;

namespace Negocio
{
    public class DiscosNegocio
    {
        public List<Discos> Listar()
        {
			List<Discos> lista = new List<Discos>();
			AccesoDatos datos = new AccesoDatos();
			
			try
			{
				datos.SetearConsulta("SELECT D.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Id, E.Descripcion Estilo, T.Id, T.Descripcion Tipo FROM ESTILOS E, DISCOS D, TIPOSEDICION T where E.Id = D.IdEstilo and T.Id = D.IdEstilo");
				datos.EjecutarLectura();

				while (datos.Lector.Read())
				{
					Discos aux = new Discos();

					aux.id = (int)datos.Lector["Id"];
					aux.titulo = (string)datos.Lector["Titulo"];
					aux.fechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
					aux.cantidadCanciones = (int)datos.Lector["CantidadCanciones"];

					if (!(datos.Lector["UrlImagenTapa"] is DBNull))
						aux.urlImagenTapa = (string)datos.Lector["UrlImagenTapa"];

					aux.estilos = new Estilos();
					aux.estilos.id = (int)datos.Lector["Id"];
					aux.estilos.descripcion = (string)datos.Lector["Estilo"];
					aux.tipoEdicion = new TiposEdicion();
					aux.tipoEdicion.id = (int)datos.Lector["Id"];
					aux.tipoEdicion.descripcion = (string)datos.Lector["Tipo"];

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

		public void Agregar()
		{
			AccesoDatos datos = new AccesoDatos();

			try
			{

			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public void Editar()
		{
			AccesoDatos datos = new AccesoDatos();

			try
			{

			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public void Eliminar()
		{
			try
			{

			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
    }
}
