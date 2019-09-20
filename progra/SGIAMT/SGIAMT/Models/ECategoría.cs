using System;
using System.Collections.Generic;

namespace SGIAMT.Models
{
    public partial class ECategoría
    {
        public ECategoría()
        {
            EUsuario = new HashSet<EUsuario>();
        }

        public int PkIcId { get; set; }
        public string VcNombreCat { get; set; }

        public ICollection<EUsuario> EUsuario { get; set; }
    }
}
