//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Predavanje6___EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Slucajevi
    {
        public int Id { get; set; }
        public int BrojZarazenih { get; set; }
        public int BrojUmrlih { get; set; }
        public int BrojIzlijecenih { get; set; }
        public int DrzavaId { get; set; }
    
        public virtual Drzave Drzave { get; set; }
    }
}
