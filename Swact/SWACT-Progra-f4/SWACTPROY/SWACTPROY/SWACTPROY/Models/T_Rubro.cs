using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SWACTPROY.Models
{
    public class T_Rubro


    {
        [Key]
        public int idRubro { get; set; }
        public string nombreRubro { get; set; }
        public string detalleRubro { get; set; }
        public ICollection<T_Cliente> t_Clientes { get; set; }
       
        public ICollection<T_Servicio> t_Servicios { get; set; }
    }

}