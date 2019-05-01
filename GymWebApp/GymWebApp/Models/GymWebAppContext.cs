using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace GymWebApp.Models
{
    public class GymWebAppContext : DbContext
    {

        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public GymWebAppContext() : base("name=GymWebAppContext")
        {
        }

        public System.Data.Entity.DbSet<GymWebApp.Models.Empresa> Empresa { get; set; }

        public System.Data.Entity.DbSet<GymWebApp.Models.Cliente> Cliente { get; set; }

        public System.Data.Entity.DbSet<GymWebApp.Models.Clases> Clases { get; set; }
        public System.Data.Entity.DbSet<GymWebApp.Models.Entrenador> Entrenador { get; set; }
        public System.Data.Entity.DbSet<GymWebApp.Models.Plan> Plan { get; set; }
        public System.Data.Entity.DbSet<GymWebApp.Models.Usuario> Usuario { get; set; }


    }
}
