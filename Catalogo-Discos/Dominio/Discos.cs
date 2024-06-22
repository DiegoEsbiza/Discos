using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Discos
    {
        public int id { get; set; }
        [DisplayName("Título")]
        public string titulo { get; set; }
        [DisplayName("Fecha de lanzamiento")]
        public DateTime fechaLanzamiento { get; set; }
        [DisplayName("Cantidad de canciones")]
        public int cantidadCanciones { get; set; }
        public string urlImagenTapa { get; set; }
        [DisplayName("Estilo")]
        public Estilos estilos { get; set; }
        [DisplayName("Formato de edición")]
        public TiposEdicion tipoEdicion { get; set; }
    }
}
