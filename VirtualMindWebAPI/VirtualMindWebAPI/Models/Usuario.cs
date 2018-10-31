namespace VirtualMindWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class Usuario
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string email { get; set; }

        public string password { get; set; }
    }
}
