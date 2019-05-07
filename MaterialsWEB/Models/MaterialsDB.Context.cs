﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MaterialsEntities : DbContext
    {
        public MaterialsEntities()
            : base("name=MaterialsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Buildings> Buildings { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<PartNumbers> PartNumbers { get; set; }
    
        public virtual int InsertBuildings(string buildingName, Nullable<bool> available)
        {
            var buildingNameParameter = buildingName != null ?
                new ObjectParameter("BuildingName", buildingName) :
                new ObjectParameter("BuildingName", typeof(string));
    
            var availableParameter = available.HasValue ?
                new ObjectParameter("Available", available) :
                new ObjectParameter("Available", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertBuildings", buildingNameParameter, availableParameter);
        }
    
        public virtual int InsertCustomers(string customerName, string prefix, Nullable<int> fKBuilding, Nullable<bool> available)
        {
            var customerNameParameter = customerName != null ?
                new ObjectParameter("CustomerName", customerName) :
                new ObjectParameter("CustomerName", typeof(string));
    
            var prefixParameter = prefix != null ?
                new ObjectParameter("Prefix", prefix) :
                new ObjectParameter("Prefix", typeof(string));
    
            var fKBuildingParameter = fKBuilding.HasValue ?
                new ObjectParameter("FKBuilding", fKBuilding) :
                new ObjectParameter("FKBuilding", typeof(int));
    
            var availableParameter = available.HasValue ?
                new ObjectParameter("Available", available) :
                new ObjectParameter("Available", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertCustomers", customerNameParameter, prefixParameter, fKBuildingParameter, availableParameter);
        }
    
        public virtual int InsertPartNumber(string partNumber, Nullable<int> fKCustomer, Nullable<bool> available)
        {
            var partNumberParameter = partNumber != null ?
                new ObjectParameter("PartNumber", partNumber) :
                new ObjectParameter("PartNumber", typeof(string));
    
            var fKCustomerParameter = fKCustomer.HasValue ?
                new ObjectParameter("FKCustomer", fKCustomer) :
                new ObjectParameter("FKCustomer", typeof(int));
    
            var availableParameter = available.HasValue ?
                new ObjectParameter("Available", available) :
                new ObjectParameter("Available", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertPartNumber", partNumberParameter, fKCustomerParameter, availableParameter);
        }
    
        public virtual ObjectResult<consulta_Result> consulta()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<consulta_Result>("consulta");
        }
    
        public virtual ObjectResult<consultaP_Result> consultaP(string partNumber, string customer)
        {
            var partNumberParameter = partNumber != null ?
                new ObjectParameter("PartNumber", partNumber) :
                new ObjectParameter("PartNumber", typeof(string));
    
            var customerParameter = customer != null ?
                new ObjectParameter("Customer", customer) :
                new ObjectParameter("Customer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<consultaP_Result>("consultaP", partNumberParameter, customerParameter);
        }
    }
}
