using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_PROYECTO_ONG.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Capacitaciones",
                columns: table => new
                {
                    idcapacitacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha_capacitacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capacitaciones", x => x.idcapacitacion);
                });

            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    idContacto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    consultas = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.idContacto);
                });

            migrationBuilder.CreateTable(
                name: "MetodosPago",
                columns: table => new
                {
                    idmetodo_pago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetodosPago", x => x.idmetodo_pago);
                });

            migrationBuilder.CreateTable(
                name: "Noticias",
                columns: table => new
                {
                    idNoticias = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    informacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    autor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticias", x => x.idNoticias);
                });

            migrationBuilder.CreateTable(
                name: "ODS",
                columns: table => new
                {
                    idODS = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_ODS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ODS", x => x.idODS);
                });

            migrationBuilder.CreateTable(
                name: "ONGs",
                columns: table => new
                {
                    idONG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_ONG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_Creacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ONGs", x => x.idONG);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    idpais = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombrePais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    region = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.idpais);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    idPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    P_nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_nac = table.Column<DateTime>(type: "datetime2", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.idPersona);
                });

            migrationBuilder.CreateTable(
                name: "Presupuestos",
                columns: table => new
                {
                    idpresupuesto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    monto_asignado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    monto_usado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presupuestos", x => x.idpresupuesto);
                });

            migrationBuilder.CreateTable(
                name: "ProyectosONG",
                columns: table => new
                {
                    idproyecto_ONG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_proyecto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_fin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    presupuesto_otorgado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectosONG", x => x.idproyecto_ONG);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    idrol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.idrol);
                });

            migrationBuilder.CreateTable(
                name: "TiposCuenta",
                columns: table => new
                {
                    idtipo_cuenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion_cuenta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposCuenta", x => x.idtipo_cuenta);
                });

            migrationBuilder.CreateTable(
                name: "TiposDonante",
                columns: table => new
                {
                    idtipo_donante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDonante", x => x.idtipo_donante);
                });

            migrationBuilder.CreateTable(
                name: "TiposGasto",
                columns: table => new
                {
                    idtipo_gasto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposGasto", x => x.idtipo_gasto);
                });

            migrationBuilder.CreateTable(
                name: "TiposTransaccion",
                columns: table => new
                {
                    idtipo_transaccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion_transaccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposTransaccion", x => x.idtipo_transaccion);
                });

            migrationBuilder.CreateTable(
                name: "Sedes",
                columns: table => new
                {
                    idsede = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    responsable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ONG_idONG = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedes", x => x.idsede);
                    table.ForeignKey(
                        name: "FK_Sedes_ONGs_ONG_idONG",
                        column: x => x.ONG_idONG,
                        principalTable: "ONGs",
                        principalColumn: "idONG",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    idempleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha_contratacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    salario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Persona_idPersona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.idempleado);
                    table.ForeignKey(
                        name: "FK_Empleados_Personas_Persona_idPersona",
                        column: x => x.Persona_idPersona,
                        principalTable: "Personas",
                        principalColumn: "idPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telefonos",
                columns: table => new
                {
                    idtelefono = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Persona_idPersona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefonos", x => x.idtelefono);
                    table.ForeignKey(
                        name: "FK_Telefonos_Personas_Persona_idPersona",
                        column: x => x.Persona_idPersona,
                        principalTable: "Personas",
                        principalColumn: "idPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voluntarios",
                columns: table => new
                {
                    idvoluntario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    disponibilidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Persona_idPersona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voluntarios", x => x.idvoluntario);
                    table.ForeignKey(
                        name: "FK_Voluntarios_Personas_Persona_idPersona",
                        column: x => x.Persona_idPersona,
                        principalTable: "Personas",
                        principalColumn: "idPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actividades",
                columns: table => new
                {
                    idactividades = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_Actividad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_fin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    proyecto_ONG_idproyecto_ONG = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividades", x => x.idactividades);
                    table.ForeignKey(
                        name: "FK_Actividades_ProyectosONG_proyecto_ONG_idproyecto_ONG",
                        column: x => x.proyecto_ONG_idproyecto_ONG,
                        principalTable: "ProyectosONG",
                        principalColumn: "idproyecto_ONG",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    idEvento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreEvento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcionEvento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaInicio_evento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaFin_evento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lugar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    proyecto_ONG_idproyecto_ONG = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.idEvento);
                    table.ForeignKey(
                        name: "FK_Eventos_ProyectosONG_proyecto_ONG_idproyecto_ONG",
                        column: x => x.proyecto_ONG_idproyecto_ONG,
                        principalTable: "ProyectosONG",
                        principalColumn: "idproyecto_ONG",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProyectoODS",
                columns: table => new
                {
                    proyecto_ONG_idproyecto_ONG = table.Column<int>(type: "int", nullable: false),
                    ODS_idODS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoODS", x => new { x.proyecto_ONG_idproyecto_ONG, x.ODS_idODS });
                    table.ForeignKey(
                        name: "FK_ProyectoODS_ODS_ODS_idODS",
                        column: x => x.ODS_idODS,
                        principalTable: "ODS",
                        principalColumn: "idODS",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProyectoODS_ProyectosONG_proyecto_ONG_idproyecto_ONG",
                        column: x => x.proyecto_ONG_idproyecto_ONG,
                        principalTable: "ProyectosONG",
                        principalColumn: "idproyecto_ONG",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProyectoPaises",
                columns: table => new
                {
                    proyecto_ONG_idproyecto_ONG = table.Column<int>(type: "int", nullable: false),
                    pais_idpais = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoPaises", x => new { x.proyecto_ONG_idproyecto_ONG, x.pais_idpais });
                    table.ForeignKey(
                        name: "FK_ProyectoPaises_Paises_pais_idpais",
                        column: x => x.pais_idpais,
                        principalTable: "Paises",
                        principalColumn: "idpais",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProyectoPaises_ProyectosONG_proyecto_ONG_idproyecto_ONG",
                        column: x => x.proyecto_ONG_idproyecto_ONG,
                        principalTable: "ProyectosONG",
                        principalColumn: "idproyecto_ONG",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CuentasBancarias",
                columns: table => new
                {
                    idcuentaBancaria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    banco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numero_cta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo_cuenta_idtipo_cuenta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentasBancarias", x => x.idcuentaBancaria);
                    table.ForeignKey(
                        name: "FK_CuentasBancarias_TiposCuenta_tipo_cuenta_idtipo_cuenta",
                        column: x => x.tipo_cuenta_idtipo_cuenta,
                        principalTable: "TiposCuenta",
                        principalColumn: "idtipo_cuenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Donantes",
                columns: table => new
                {
                    iddonante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo_donante_idtipo_donante = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donantes", x => x.iddonante);
                    table.ForeignKey(
                        name: "FK_Donantes_TiposDonante_tipo_donante_idtipo_donante",
                        column: x => x.tipo_donante_idtipo_donante,
                        principalTable: "TiposDonante",
                        principalColumn: "idtipo_donante",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gastos",
                columns: table => new
                {
                    idgasto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    monto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tipo_gasto_idtipo_gasto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gastos", x => x.idgasto);
                    table.ForeignKey(
                        name: "FK_Gastos_TiposGasto_tipo_gasto_idtipo_gasto",
                        column: x => x.tipo_gasto_idtipo_gasto,
                        principalTable: "TiposGasto",
                        principalColumn: "idtipo_gasto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    idarea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sede_idsede = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.idarea);
                    table.ForeignKey(
                        name: "FK_Areas_Sedes_sede_idsede",
                        column: x => x.sede_idsede,
                        principalTable: "Sedes",
                        principalColumn: "idsede",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProyectoEmpleados",
                columns: table => new
                {
                    idproyecto_empleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idempleado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoEmpleados", x => x.idproyecto_empleado);
                    table.ForeignKey(
                        name: "FK_ProyectoEmpleados_Empleados_idempleado",
                        column: x => x.idempleado,
                        principalTable: "Empleados",
                        principalColumn: "idempleado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    idusuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empleado_idempleado = table.Column<int>(type: "int", nullable: false),
                    ONG_idONG = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.idusuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Empleados_empleado_idempleado",
                        column: x => x.empleado_idempleado,
                        principalTable: "Empleados",
                        principalColumn: "idempleado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_ONGs_ONG_idONG",
                        column: x => x.ONG_idONG,
                        principalTable: "ONGs",
                        principalColumn: "idONG",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProyectoVoluntarios",
                columns: table => new
                {
                    idproyecto_voluntario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idvoluntario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoVoluntarios", x => x.idproyecto_voluntario);
                    table.ForeignKey(
                        name: "FK_ProyectoVoluntarios_Voluntarios_idvoluntario",
                        column: x => x.idvoluntario,
                        principalTable: "Voluntarios",
                        principalColumn: "idvoluntario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VoluntarioCapacitaciones",
                columns: table => new
                {
                    voluntario_idvoluntario = table.Column<int>(type: "int", nullable: false),
                    capacitacion_idcapacitacion = table.Column<int>(type: "int", nullable: false),
                    tema_capacitacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoluntarioCapacitaciones", x => new { x.voluntario_idvoluntario, x.capacitacion_idcapacitacion });
                    table.ForeignKey(
                        name: "FK_VoluntarioCapacitaciones_Capacitaciones_capacitacion_idcapacitacion",
                        column: x => x.capacitacion_idcapacitacion,
                        principalTable: "Capacitaciones",
                        principalColumn: "idcapacitacion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VoluntarioCapacitaciones_Voluntarios_voluntario_idvoluntario",
                        column: x => x.voluntario_idvoluntario,
                        principalTable: "Voluntarios",
                        principalColumn: "idvoluntario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Donaciones",
                columns: table => new
                {
                    iddonacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    monto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_donacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo_cuenta_idtipo_cuenta = table.Column<int>(type: "int", nullable: false),
                    donante_iddonante = table.Column<int>(type: "int", nullable: false),
                    voluntario_idvoluntario = table.Column<int>(type: "int", nullable: false),
                    CuentaBancariaidcuentaBancaria = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donaciones", x => x.iddonacion);
                    table.ForeignKey(
                        name: "FK_Donaciones_CuentasBancarias_CuentaBancariaidcuentaBancaria",
                        column: x => x.CuentaBancariaidcuentaBancaria,
                        principalTable: "CuentasBancarias",
                        principalColumn: "idcuentaBancaria");
                    table.ForeignKey(
                        name: "FK_Donaciones_Donantes_donante_iddonante",
                        column: x => x.donante_iddonante,
                        principalTable: "Donantes",
                        principalColumn: "iddonante",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donaciones_TiposCuenta_tipo_cuenta_idtipo_cuenta",
                        column: x => x.tipo_cuenta_idtipo_cuenta,
                        principalTable: "TiposCuenta",
                        principalColumn: "idtipo_cuenta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donaciones_Voluntarios_voluntario_idvoluntario",
                        column: x => x.voluntario_idvoluntario,
                        principalTable: "Voluntarios",
                        principalColumn: "idvoluntario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    idfactura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numero_factura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    donador_proveedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    monto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_emision = table.Column<DateTime>(type: "datetime2", nullable: false),
                    metodo_pago_idmetodo_pago = table.Column<int>(type: "int", nullable: false),
                    gasto_idgasto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.idfactura);
                    table.ForeignKey(
                        name: "FK_Facturas_Gastos_gasto_idgasto",
                        column: x => x.gasto_idgasto,
                        principalTable: "Gastos",
                        principalColumn: "idgasto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Facturas_MetodosPago_metodo_pago_idmetodo_pago",
                        column: x => x.metodo_pago_idmetodo_pago,
                        principalTable: "MetodosPago",
                        principalColumn: "idmetodo_pago",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NoticiasAreas",
                columns: table => new
                {
                    Noticias_idNoticias = table.Column<int>(type: "int", nullable: false),
                    area_idarea = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoticiasAreas", x => new { x.Noticias_idNoticias, x.area_idarea });
                    table.ForeignKey(
                        name: "FK_NoticiasAreas_Areas_area_idarea",
                        column: x => x.area_idarea,
                        principalTable: "Areas",
                        principalColumn: "idarea",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NoticiasAreas_Noticias_Noticias_idNoticias",
                        column: x => x.Noticias_idNoticias,
                        principalTable: "Noticias",
                        principalColumn: "idNoticias",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProyectoONGEmpleados",
                columns: table => new
                {
                    proyecto_ONG_idproyecto_ONG = table.Column<int>(type: "int", nullable: false),
                    proyecto_empleado_idproyecto_empleado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoONGEmpleados", x => new { x.proyecto_ONG_idproyecto_ONG, x.proyecto_empleado_idproyecto_empleado });
                    table.ForeignKey(
                        name: "FK_ProyectoONGEmpleados_ProyectoEmpleados_proyecto_empleado_idproyecto_empleado",
                        column: x => x.proyecto_empleado_idproyecto_empleado,
                        principalTable: "ProyectoEmpleados",
                        principalColumn: "idproyecto_empleado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProyectoONGEmpleados_ProyectosONG_proyecto_ONG_idproyecto_ONG",
                        column: x => x.proyecto_ONG_idproyecto_ONG,
                        principalTable: "ProyectosONG",
                        principalColumn: "idproyecto_ONG",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolUsuarios",
                columns: table => new
                {
                    idrol = table.Column<int>(type: "int", nullable: false),
                    usuario_idusuario = table.Column<int>(type: "int", nullable: false),
                    descripcion_rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolUsuarios", x => new { x.idrol, x.usuario_idusuario });
                    table.ForeignKey(
                        name: "FK_RolUsuarios_Roles_idrol",
                        column: x => x.idrol,
                        principalTable: "Roles",
                        principalColumn: "idrol",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolUsuarios_Usuarios_usuario_idusuario",
                        column: x => x.usuario_idusuario,
                        principalTable: "Usuarios",
                        principalColumn: "idusuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProyectoONGVoluntarios",
                columns: table => new
                {
                    proyecto_ONG_idproyecto_ONG = table.Column<int>(type: "int", nullable: false),
                    proyecto_voluntario_idproyecto_voluntario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoONGVoluntarios", x => new { x.proyecto_ONG_idproyecto_ONG, x.proyecto_voluntario_idproyecto_voluntario });
                    table.ForeignKey(
                        name: "FK_ProyectoONGVoluntarios_ProyectoVoluntarios_proyecto_voluntario_idproyecto_voluntario",
                        column: x => x.proyecto_voluntario_idproyecto_voluntario,
                        principalTable: "ProyectoVoluntarios",
                        principalColumn: "idproyecto_voluntario",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProyectoONGVoluntarios_ProyectosONG_proyecto_ONG_idproyecto_ONG",
                        column: x => x.proyecto_ONG_idproyecto_ONG,
                        principalTable: "ProyectosONG",
                        principalColumn: "idproyecto_ONG",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transacciones",
                columns: table => new
                {
                    idtransaccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha_transaccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tipo_transaccion_idtipo_transaccion = table.Column<int>(type: "int", nullable: false),
                    donacion_iddonacion = table.Column<int>(type: "int", nullable: false),
                    gasto_idgasto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacciones", x => x.idtransaccion);
                    table.ForeignKey(
                        name: "FK_Transacciones_Donaciones_donacion_iddonacion",
                        column: x => x.donacion_iddonacion,
                        principalTable: "Donaciones",
                        principalColumn: "iddonacion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transacciones_Gastos_gasto_idgasto",
                        column: x => x.gasto_idgasto,
                        principalTable: "Gastos",
                        principalColumn: "idgasto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transacciones_TiposTransaccion_tipo_transaccion_idtipo_transaccion",
                        column: x => x.tipo_transaccion_idtipo_transaccion,
                        principalTable: "TiposTransaccion",
                        principalColumn: "idtipo_transaccion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_proyecto_ONG_idproyecto_ONG",
                table: "Actividades",
                column: "proyecto_ONG_idproyecto_ONG");

            migrationBuilder.CreateIndex(
                name: "IX_Areas_sede_idsede",
                table: "Areas",
                column: "sede_idsede");

            migrationBuilder.CreateIndex(
                name: "IX_CuentasBancarias_tipo_cuenta_idtipo_cuenta",
                table: "CuentasBancarias",
                column: "tipo_cuenta_idtipo_cuenta");

            migrationBuilder.CreateIndex(
                name: "IX_Donaciones_CuentaBancariaidcuentaBancaria",
                table: "Donaciones",
                column: "CuentaBancariaidcuentaBancaria");

            migrationBuilder.CreateIndex(
                name: "IX_Donaciones_donante_iddonante",
                table: "Donaciones",
                column: "donante_iddonante");

            migrationBuilder.CreateIndex(
                name: "IX_Donaciones_tipo_cuenta_idtipo_cuenta",
                table: "Donaciones",
                column: "tipo_cuenta_idtipo_cuenta");

            migrationBuilder.CreateIndex(
                name: "IX_Donaciones_voluntario_idvoluntario",
                table: "Donaciones",
                column: "voluntario_idvoluntario");

            migrationBuilder.CreateIndex(
                name: "IX_Donantes_tipo_donante_idtipo_donante",
                table: "Donantes",
                column: "tipo_donante_idtipo_donante");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Persona_idPersona",
                table: "Empleados",
                column: "Persona_idPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_proyecto_ONG_idproyecto_ONG",
                table: "Eventos",
                column: "proyecto_ONG_idproyecto_ONG");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_gasto_idgasto",
                table: "Facturas",
                column: "gasto_idgasto");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_metodo_pago_idmetodo_pago",
                table: "Facturas",
                column: "metodo_pago_idmetodo_pago");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_tipo_gasto_idtipo_gasto",
                table: "Gastos",
                column: "tipo_gasto_idtipo_gasto");

            migrationBuilder.CreateIndex(
                name: "IX_NoticiasAreas_area_idarea",
                table: "NoticiasAreas",
                column: "area_idarea");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoEmpleados_idempleado",
                table: "ProyectoEmpleados",
                column: "idempleado");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoODS_ODS_idODS",
                table: "ProyectoODS",
                column: "ODS_idODS");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoONGEmpleados_proyecto_empleado_idproyecto_empleado",
                table: "ProyectoONGEmpleados",
                column: "proyecto_empleado_idproyecto_empleado");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoONGVoluntarios_proyecto_voluntario_idproyecto_voluntario",
                table: "ProyectoONGVoluntarios",
                column: "proyecto_voluntario_idproyecto_voluntario");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoPaises_pais_idpais",
                table: "ProyectoPaises",
                column: "pais_idpais");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoVoluntarios_idvoluntario",
                table: "ProyectoVoluntarios",
                column: "idvoluntario");

            migrationBuilder.CreateIndex(
                name: "IX_RolUsuarios_usuario_idusuario",
                table: "RolUsuarios",
                column: "usuario_idusuario");

            migrationBuilder.CreateIndex(
                name: "IX_Sedes_ONG_idONG",
                table: "Sedes",
                column: "ONG_idONG");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonos_Persona_idPersona",
                table: "Telefonos",
                column: "Persona_idPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Transacciones_donacion_iddonacion",
                table: "Transacciones",
                column: "donacion_iddonacion");

            migrationBuilder.CreateIndex(
                name: "IX_Transacciones_gasto_idgasto",
                table: "Transacciones",
                column: "gasto_idgasto");

            migrationBuilder.CreateIndex(
                name: "IX_Transacciones_tipo_transaccion_idtipo_transaccion",
                table: "Transacciones",
                column: "tipo_transaccion_idtipo_transaccion");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_empleado_idempleado",
                table: "Usuarios",
                column: "empleado_idempleado");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ONG_idONG",
                table: "Usuarios",
                column: "ONG_idONG");

            migrationBuilder.CreateIndex(
                name: "IX_VoluntarioCapacitaciones_capacitacion_idcapacitacion",
                table: "VoluntarioCapacitaciones",
                column: "capacitacion_idcapacitacion");

            migrationBuilder.CreateIndex(
                name: "IX_Voluntarios_Persona_idPersona",
                table: "Voluntarios",
                column: "Persona_idPersona");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actividades");

            migrationBuilder.DropTable(
                name: "Contactos");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "NoticiasAreas");

            migrationBuilder.DropTable(
                name: "Presupuestos");

            migrationBuilder.DropTable(
                name: "ProyectoODS");

            migrationBuilder.DropTable(
                name: "ProyectoONGEmpleados");

            migrationBuilder.DropTable(
                name: "ProyectoONGVoluntarios");

            migrationBuilder.DropTable(
                name: "ProyectoPaises");

            migrationBuilder.DropTable(
                name: "RolUsuarios");

            migrationBuilder.DropTable(
                name: "Telefonos");

            migrationBuilder.DropTable(
                name: "Transacciones");

            migrationBuilder.DropTable(
                name: "VoluntarioCapacitaciones");

            migrationBuilder.DropTable(
                name: "MetodosPago");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Noticias");

            migrationBuilder.DropTable(
                name: "ODS");

            migrationBuilder.DropTable(
                name: "ProyectoEmpleados");

            migrationBuilder.DropTable(
                name: "ProyectoVoluntarios");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "ProyectosONG");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Donaciones");

            migrationBuilder.DropTable(
                name: "Gastos");

            migrationBuilder.DropTable(
                name: "TiposTransaccion");

            migrationBuilder.DropTable(
                name: "Capacitaciones");

            migrationBuilder.DropTable(
                name: "Sedes");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "CuentasBancarias");

            migrationBuilder.DropTable(
                name: "Donantes");

            migrationBuilder.DropTable(
                name: "Voluntarios");

            migrationBuilder.DropTable(
                name: "TiposGasto");

            migrationBuilder.DropTable(
                name: "ONGs");

            migrationBuilder.DropTable(
                name: "TiposCuenta");

            migrationBuilder.DropTable(
                name: "TiposDonante");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
