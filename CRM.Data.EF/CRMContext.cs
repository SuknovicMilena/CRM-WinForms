namespace CRM.Data.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using CRM.Domain.Entities;

    public partial class CRMContext : DbContext
    {
        public CRMContext()
            : base("name=CRMContext")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Client>()
                .HasKey(e => e.ClientId)
                .Property(e => e.ClientId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Contact>()
                .HasKey(e => e.ContactId)         
                .Property(e => e.ContactId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Contact>()
                .Property(e => e.ClientId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Projects>()
                .HasKey(e => e.ProjectId)            
                .Property(e => e.ProjectId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Projects>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Projects>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Projects>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Projects>()
                .Property(e => e.ClientId)
                .HasPrecision(18, 0);
        }
    }
}
