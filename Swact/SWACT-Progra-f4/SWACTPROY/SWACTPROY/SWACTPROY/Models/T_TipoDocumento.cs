using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SWACTPROY.Models
{
    public class T_TipoDocumento
    {
        [Key]
        public int idDocumento { get; set; }


        public string nombreDoc { get; set; }

        public ICollection<T_Usuario> T_Usuarios { get; set; }
    }
}
