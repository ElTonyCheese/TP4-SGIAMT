using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SWACTPROY.Models
{
    public class T_OrdenTrabajo
    {
        [Key]
        public int idOrdenTrabajo { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Progreso")]
        [Range(0, 100, ErrorMessage = "dato inválido")]
        public int progreso { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Estado")]
        public string estado { get; set; }

        public int idSolicitud { get; set; }
        
        public T_Solicitud t_Solicitud { get; set; }

        public ICollection<T_Entregables> t_Entregables { get; set; }
    }
}
