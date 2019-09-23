using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SGIAMT.Models
{
    public partial class ENivelxTipoNivel
    {
        [DisplayName("N° de alumno")]
        public int NroAlumno { get; set; }

        [DisplayName("Tipo de nivel")]
        public int PkItnCod { get; set; }
        [DisplayName("nivel")]
        public int PkInCod { get; set; }

        [DisplayName("numero de nivel")]
        public int PkIntnCod { get; set; }

        [DisplayName("Nombre del Alumno")]
        public int PkIuDni { get; set; }

        public ENivel PkInCodNavigation { get; set; }
        public ETipoNivel PkItnCodNavigation { get; set; }
        public EUsuario PkIuDniNavigation { get; set; }
    }
}
