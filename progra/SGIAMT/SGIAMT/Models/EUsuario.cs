﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SGIAMT.Models
{
    public partial class EUsuario
    {
        public EUsuario()
        {
            ENivelxTipoNivel = new HashSet<ENivelxTipoNivel>();
        }

        [DisplayName("Dni")]
        [Range(10000000, 99999999, ErrorMessage = "el dni no tiene 8 caracteres ")]
        public int PkIuDni { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Nombre")]
        [StringLength(30, MinimumLength = 0, ErrorMessage = "Ingrese el nombre")]
        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Solo letras")]
        public string VuNombre { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Apellido Paterno")]
        [StringLength(30, MinimumLength = 0, ErrorMessage = "Ingrese el apellido paterno")]
        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Solo letras")]
        public string VuApaterno { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Apellido Materno")]
        [StringLength(30, MinimumLength = 0, ErrorMessage = "Ingrese el apellido materno")]
        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Solo letras")]
        public string VuAmaterno { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Celular")]
        [Range(100000000, 999999999, ErrorMessage = "el Celular tiene 9 caracteres")]
        public int VuCelular { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Correo")]
        [StringLength(30, MinimumLength = 0, ErrorMessage = "Ingrese el Correo")]
        public string VuCorreo { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Direccion")]
        [StringLength(30, MinimumLength = 0, ErrorMessage = "Ingrese el Direccion")]
        public string VuDireccion { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DuFechaNacimiento { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Sexo")]
        [StringLength(30, MinimumLength = 0, ErrorMessage = "Ingrese el Sexo")]
        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Solo letras")]
        public string VuSexo { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [DisplayName("contraseña")]
        public string VuContraseña { get; set; }

        [Required]
        [DisplayName("Estado")]
        public string VuEstado { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Horario")]
        [StringLength(30, MinimumLength = 0, ErrorMessage = "ingrese Horario")]
        public string VuHorario { get; set; }

        [DisplayName("Tipo de Usuario")]
        public int PkItuTipoUsuario { get; set; }

        [DisplayName("Categoria")]
        public int PkIcId { get; set; }

        [DisplayName("distrito")]
        public int PkIdiCod { get; set; }


        public ECategoría PkIc { get; set; }
        public EDistrito PkIdiCodNavigation { get; set; }
        public ETipoUsuario PkItuTipoUsuarioNavigation { get; set; }
        public ICollection<ENivelxTipoNivel> ENivelxTipoNivel { get; set; }
    }
}
