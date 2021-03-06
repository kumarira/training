﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PODbEntities : DbContext
    {
        public PODbEntities()
            : base("name=PODbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ITEM> ITEMs { get; set; }
        public virtual DbSet<PODETAIL> PODETAILs { get; set; }
        public virtual DbSet<POMASTER> POMASTERs { get; set; }
        public virtual DbSet<SUPPLIER> SUPPLIERs { get; set; }
    
        public virtual int usp_addupdate_PO(string pAction, string pPONO, string pSUPLNO, string pITEM, Nullable<int> pQTY)
        {
            var pActionParameter = pAction != null ?
                new ObjectParameter("pAction", pAction) :
                new ObjectParameter("pAction", typeof(string));
    
            var pPONOParameter = pPONO != null ?
                new ObjectParameter("pPONO", pPONO) :
                new ObjectParameter("pPONO", typeof(string));
    
            var pSUPLNOParameter = pSUPLNO != null ?
                new ObjectParameter("pSUPLNO", pSUPLNO) :
                new ObjectParameter("pSUPLNO", typeof(string));
    
            var pITEMParameter = pITEM != null ?
                new ObjectParameter("pITEM", pITEM) :
                new ObjectParameter("pITEM", typeof(string));
    
            var pQTYParameter = pQTY.HasValue ?
                new ObjectParameter("pQTY", pQTY) :
                new ObjectParameter("pQTY", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_addupdate_PO", pActionParameter, pPONOParameter, pSUPLNOParameter, pITEMParameter, pQTYParameter);
        }
    }
}
