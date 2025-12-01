using API_PROYECTO_ONG.Models;
using Microsoft.EntityFrameworkCore;

namespace API_PROYECTO_ONG.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<TipoDonante> TiposDonante { get; set; }
        public DbSet<TipoCuenta> TiposCuenta { get; set; }
        public DbSet<TipoGasto> TiposGasto { get; set; }
        public DbSet<TipoTransaccion> TiposTransaccion { get; set; }
        public DbSet<ODS> ODS { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<ONG> ONGs { get; set; }

        // Personas / voluntarios / empleados / usuarios
        public DbSet<Telefono> Telefonos { get; set; }
        public DbSet<Voluntario> Voluntarios { get; set; }
        public DbSet<Capacitacion> Capacitaciones { get; set; }
        public DbSet<VoluntarioCapacitacion> VoluntarioCapacitaciones { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<RolUsuario> RolUsuarios { get; set; }

        // Sede / área / noticias
        public DbSet<Sede> Sedes { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Noticias> Noticias { get; set; }
        public DbSet<Noticias_has_area> NoticiasAreas { get; set; }

        // Contacto
        public DbSet<Contacto> Contactos { get; set; }

        // Proyectos / actividades / eventos
        public DbSet<Proyecto_ONG> ProyectosONG { get; set; }
        public DbSet<ProyectoONG_has_ODS> ProyectoODS { get; set; }
        public DbSet<ProyectoONG_has_Pais> ProyectoPaises { get; set; }
        public DbSet<Actividades> Actividades { get; set; }
        public DbSet<ProyectoVoluntario> ProyectoVoluntarios { get; set; }
        public DbSet<ProyectoEmpleado> ProyectoEmpleados { get; set; }
        public DbSet<Proyecto_ONG_has_proyecto_voluntario> ProyectoONGVoluntarios { get; set; }
        public DbSet<Proyecto_ONG_has_proyecto_empleado> ProyectoONGEmpleados { get; set; }
        public DbSet<Evento> Eventos { get; set; }

        // Donantes / cuentas / donaciones
        public DbSet<Donante> Donantes { get; set; }
        public DbSet<CuentaBancaria> CuentasBancarias { get; set; }
        public DbSet<Donacion> Donaciones { get; set; }

        // Gastos / transacciones / presupuesto / facturas
        public DbSet<Gasto> Gastos { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }
        public DbSet<Presupuesto> Presupuestos { get; set; }
        public DbSet<MetodoPago> MetodosPago { get; set; }
        public DbSet<Factura> Facturas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Claves compuestas
            modelBuilder.Entity<VoluntarioCapacitacion>()
                .HasKey(vc => new { vc.voluntario_idvoluntario, vc.capacitacion_idcapacitacion });

            modelBuilder.Entity<RolUsuario>()
                .HasKey(ru => new { ru.idrol, ru.usuario_idusuario });

            modelBuilder.Entity<Noticias_has_area>()
                .HasKey(na => new { na.Noticias_idNoticias, na.area_idarea });

            modelBuilder.Entity<ProyectoONG_has_ODS>()
                .HasKey(po => new { po.proyecto_ONG_idproyecto_ONG, po.ODS_idODS });

            modelBuilder.Entity<ProyectoONG_has_Pais>()
                .HasKey(pp => new { pp.proyecto_ONG_idproyecto_ONG, pp.pais_idpais });

            modelBuilder.Entity<Proyecto_ONG_has_proyecto_voluntario>()
                .HasKey(pv => new { pv.proyecto_ONG_idproyecto_ONG, pv.proyecto_voluntario_idproyecto_voluntario });

            modelBuilder.Entity<Proyecto_ONG_has_proyecto_empleado>()
                .HasKey(pe => new { pe.proyecto_ONG_idproyecto_ONG, pe.proyecto_empleado_idproyecto_empleado });

            base.OnModelCreating(modelBuilder);
        }
    }
}
