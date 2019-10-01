using System;
using System.Collections.Generic;

namespace SGIAMT.Models
{
    public partial class EDistrito
    {
        public EDistrito()
        {
            EUsuario = new HashSet<EUsuario>();
        }

        public int PkIdiCod { get; set; }
        public string VdiNombreDis { get; set; }

        public ICollection<EUsuario> EUsuario { get; set; }
    }
}
