using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace SWACTPROY.Models
{
    public class T_Solicitud
    {
        [Key]
        public int idSolicitud { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Detalle")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Minimo 10 carácteres")]
        public string detalle { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Estado")]
        public string estado { get; set; }
        public string ordentrabajo { get; set; }
        public int idCliente { get; set; }

        public int idServicio { get; set; }

        public T_Cliente T_Cliente { get; set; }
        public T_Servicio T_Servicio { get; set; }

        public ICollection<T_Cotizacion> t_Cotizacions { get; set; }


    }
}
