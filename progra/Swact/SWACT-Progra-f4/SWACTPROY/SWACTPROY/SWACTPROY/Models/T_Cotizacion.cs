using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace SWACTPROY.Models
{
    public class T_Cotizacion
    {
        [Key]
        public int idCotizacion { get; set; }

        [DisplayName("Cotizacion")]
        public string nombrepdf { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Precio (Soles)")]
        [Range(10000,9999999,ErrorMessage ="Ingresar precio vàlido")]
        public int? precio { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Duracion (meses)")]
        [RegularExpression("^[0-9]{1,12}$", ErrorMessage = "Ingrese duracion vàlida")]
        public string duracion { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Estado")]
        public string estado { get; set; }

        public int idSolicitud { get; set; }

        public T_Solicitud T_Solicitud { get; set; }

        public ICollection<T_Versionamiento> t_Versionamientos { get; set; }

        

    }
}
