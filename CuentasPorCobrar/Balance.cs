//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CuentasPorCobrar
{
    using System;
    using System.Collections.Generic;
    
    public partial class Balance
    {
        public int IdCliente { get; set; }
        public System.DateTime FechaCorte { get; set; }
        public decimal AntiguedadPromedioSaldos { get; set; }
        public decimal Monto { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
