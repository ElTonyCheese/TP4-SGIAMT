using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SWACTPROY.Models
{
    public class T_Servicio
    {
        [Key]
        public int idServicio { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Nombre de Servicio")]
        [StringLength(30, MinimumLength = 3,ErrorMessage ="minimo 3 caracteres")]
        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Solo letras")]
        public string nombreServicio { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Detalle")]
        [StringLength(1000, MinimumLength = 10,ErrorMessage ="minimo 10 caracteres")]
        public string detalle { get; set; }

        public int idRubro { get; set; }

        public T_Rubro T_Rubro { get; set; }

        public ICollection<T_Solicitud> t_Solicituds { get; set; }
    }
}
