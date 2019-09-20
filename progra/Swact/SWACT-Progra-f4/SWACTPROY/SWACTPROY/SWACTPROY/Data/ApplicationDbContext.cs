using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SWACTPROY.Models;

namespace SWACTPROY.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<SWACTPROY.Models.T_Solicitud> T_Solicitud { get; set; }

        public DbSet<SWACTPROY.Models.T_Cotizacion> T_Cotizacion { get; set; }

        public DbSet<SWACTPROY.Models.ApplicationUser> ApplicationUser { get; set; }

        public DbSet<SWACTPROY.Models.T_Cliente> T_Cliente { get; set; }

        public DbSet<SWACTPROY.Models.T_Rubro> T_Rubro { get; set; }

        public DbSet<SWACTPROY.Models.T_Servicio> T_Servicio { get; set; }

        public DbSet<SWACTPROY.Models.T_Entregables> T_Entregables { get; set; }

        public DbSet<SWACTPROY.Models.T_OrdenTrabajo> T_OrdenTrabajo { get; set; }


        public DbSet<SWACTPROY.Models.T_TipoDocumento> T_TipoDocumento { get; set; }

        public DbSet<SWACTPROY.Models.T_Versionamiento> T_Versionamiento { get; set; }

        public DbSet<SWACTPROY.Models.T_Usuario> T_Usuario { get; set; }

    }
}
