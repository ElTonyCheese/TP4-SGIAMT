using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SWACTPROY.Models
{
    public class T_Entregables
    {
        [Key]
        public int idEntregable { get; set; }
        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? fecha { get; set; }


        [Display(Name = "Hora inicio")]
        public DateTime? horaInicio { get; set; }

        [Display(Name = "Hora Fin")]
        public DateTime? horaFin { get; set; }

        [Display(Name = "Estado")]
        public string estado { get; set; }
        public int idOrdenTrabajo { get; set; }
        public string idUsuario { get; set; }

        public T_OrdenTrabajo T_OrdenTrabajo { get; set; }

        public T_Usuario t_Usuario { get; set; }

    }
}
