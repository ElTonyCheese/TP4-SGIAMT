using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SGIAMT.Models
{
    public partial class ENivelxTipoNivel
    {
        [DisplayName("numero de nivel")]
        public int PkIntnCod { get; set; }

        [DisplayName("nivel")]
        public int FkInCod { get; set; }

        [DisplayName("Tipo de nivel")]
        public int FkItnCod { get; set; }

        [DisplayName("N° de alumno")]
        public int NroAlumno { get; set; }

        [DisplayName("Nombre del Alumno")]
        public int FkIuDni { get; set; }

        public ENivel FkInCodNavigation { get; set; }
        public ETipoNivel FkItnCodNavigation { get; set; }
        public EUsuario FkIuDniNavigation { get; set; }
    }
}
