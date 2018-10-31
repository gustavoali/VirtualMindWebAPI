namespace VirtualMindWebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VirtualMindContext : DbContext
    {
        public VirtualMindContext()
            : base("name=VirtualMindContext")
        {
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
