using System;
using System.Collections.Generic;

namespace SGIAMT.Models
{
    public partial class ENivel
    {
        public ENivel()
        {
            ENivelxTipoNivel = new HashSet<ENivelxTipoNivel>();
        }

        public int PkInCod { get; set; }
        public string VnNombreNivel { get; set; }

        public ICollection<ENivelxTipoNivel> ENivelxTipoNivel { get; set; }
    }
}
