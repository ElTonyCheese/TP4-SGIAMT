using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;


namespace SWACTPROY.Models
{
    public class T_Versionamiento
    {
         [Key]
        public int idVersion { get; set; }

        [DisplayName("Nombre de la cotizacion")]
        public string nombrepdf { get; set; }

        [DisplayName("Precio (Soles)")]
        public int? precio { get; set; }

        [DisplayName("Duracion (meses)")]
        public  string duracion { get; set; }

        [DisplayName("Fecha de envìo")]
        public DateTime? fechaCreacion { get; set; }
      
        public DateTime? fechaModificacion { get; set; }

        [DisplayName("Detalle")]
        public string detalleRespuesta { get; set; }

        [DisplayName("Estado")]
        public string estado { get; set; }
        public int idCotizacion { get; set; }
        public int? idSolicitud { get; set; }
        public T_Cotizacion T_Cotizacion { get; set; }



        
    }
}
