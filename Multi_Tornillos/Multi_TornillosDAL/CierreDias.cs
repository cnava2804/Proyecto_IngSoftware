//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Multi_TornillosDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CierreDias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CierreDias()
        {
            this.Bitacora = new HashSet<Bitacora>();
        }
    
        public int CierreDia_Id { get; set; }
        public Nullable<decimal> CierreDiaTotal { get; set; }
        public Nullable<System.DateTime> CierreDiaFecha { get; set; }
        public Nullable<int> CierreDiaCatidadUnlps { get; set; }
        public Nullable<int> CierreDiaCatidadDoslps { get; set; }
        public Nullable<int> CierreDiaCatidadCincolps { get; set; }
        public Nullable<int> CierreDiaCatidadDiezlps { get; set; }
        public Nullable<int> CierreDiaCatidadVeintelps { get; set; }
        public Nullable<int> CierreDiaCatidadCincuentalps { get; set; }
        public Nullable<int> CierreDiaCatidadCienlps { get; set; }
        public Nullable<int> CierreDiaCatidadDoscientoslps { get; set; }
        public Nullable<int> CierreDiaCatidadQuinientos { get; set; }
        public Nullable<int> CierreDiaCatidadCincocent { get; set; }
        public Nullable<int> CierreDiaCatidadDiezcent { get; set; }
        public Nullable<int> CierreDiaCatidadVeintecent { get; set; }
        public Nullable<int> CierreDiaCatidadCincuentacent { get; set; }
        public int SaldoInicial_Id { get; set; }
        public int UsuarioId { get; set; }
        public int CajaId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bitacora> Bitacora { get; set; }
        public virtual Caja Caja { get; set; }
        public virtual Caja Caja1 { get; set; }
        public virtual SaldosIniciales SaldosIniciales { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
