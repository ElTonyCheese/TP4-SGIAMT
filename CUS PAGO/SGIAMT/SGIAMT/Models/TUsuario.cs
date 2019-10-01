using System;
using System.Collections.Generic;

namespace SGIAMT.Models
{
    public partial class TUsuario
    {
        public TUsuario()
        {
            TPago = new HashSet<TPago>();
        }

        public int PkIuDni { get; set; }
        public string VuNombre { get; set; }
        public string VuApaterno { get; set; }
        public string VuAmaterno { get; set; }

        public ICollection<TPago> TPago { get; set; }
    }
}
