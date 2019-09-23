using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SWACTPROY.Models
{
    public class T_Cliente
    {
        [Key]
        public int idCliente { get; set; }

        public string idUsuario { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Razón Social")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Minimo 3 caracteres")]
        public string razonSocial { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Ruc")]
        [Range(10000000000,99999999999,ErrorMessage ="Ingresar Ruc Valido")]
        public long ruc { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Dirección")]
        [StringLength(30, MinimumLength = 10,ErrorMessage ="Ingrese direccion valida")]
        public string direccion { get; set; }

        public int idRubro { get; set; }

        public T_Rubro T_Rubro { get; set; }

        public T_Usuario T_Usuario { get; set; }

        public ICollection<T_Solicitud> t_Solicituds { get; set; }


    }
}
