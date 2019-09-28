using System;
using System.Collections.Generic;

namespace SGIAMT.Models
{
    public partial class TPago
    {
        public int PkIpId { get; set; }
        public decimal? VpValor { get; set; }
        public DateTime? VpFecha { get; set; }
        public string VpMes { get; set; }
        public int? VpAño { get; set; }
        public byte[] VpPdf { get; set; }
        public int? FkIuDni { get; set; }
        public int? FkIcpId { get; set; }

        public TConceptoPago FkIcp { get; set; }
        public TUsuario FkIuDniNavigation { get; set; }
    }
}
