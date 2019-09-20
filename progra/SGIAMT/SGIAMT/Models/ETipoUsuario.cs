using System;
using System.Collections.Generic;

namespace SGIAMT.Models
{
    public partial class ETipoUsuario
    {
        public ETipoUsuario()
        {
            EUsuario = new HashSet<EUsuario>();
        }

        public int PkItuTipoUsuario { get; set; }
        public string VtuNombreTipoUsuario { get; set; }

        public ICollection<EUsuario> EUsuario { get; set; }
    }
}
