//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MaterialsWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PartNumbers
    {
        public int PKPartNumber { get; set; }
        public string PartNumber { get; set; }
        public Nullable<int> FKCustomer { get; set; }
        public Nullable<bool> Available { get; set; }
    
        public virtual Customers Customers { get; set; }

        [NotMapped]
        public List<Customers> CustomersCol { get; set; }
    }
}