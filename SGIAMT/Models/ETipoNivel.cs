using System;
using System.Collections.Generic;

namespace SGIAMT.Models
{
    public partial class ETipoNivel
    {
        public ETipoNivel()
        {
            ENivelxTipoNivel = new HashSet<ENivelxTipoNivel>();
        }

        public int PkItnCod { get; set; }
        public string ItnNombreTipoNivel { get; set; }

        public ICollection<ENivelxTipoNivel> ENivelxTipoNivel { get; set; }
    }
}
