using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SWACTPROY.Models
{
    public class T_Usuario
    {

        [Key]
        public string idUsuario { get; set; }
        public string email { get; set; }
        public string contraseña { get; set; }
       
        public string nombre { get; set; }


        public string apellidopaterno { get; set; }



        public string apellidomaterno { get; set; }

        public int iddocumento { get; set; }

        public int documento { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public  string estado { get; set; }

        public string idRol { get; set; }

        public ICollection <T_Cliente> t_Clientes { get; set; }
        
    }
}
