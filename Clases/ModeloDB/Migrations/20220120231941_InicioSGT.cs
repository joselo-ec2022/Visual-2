using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloDB.Migrations
{
    public partial class InicioSGT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aportes",
                columns: table => new
                {
                    AportesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aporte_patronal = table.Column<float>(type: "real", nullable: false),
                    aporte_personal_dado = table.Column<float>(type: "real", nullable: false),
                    total_decimo_dado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiempo_aportado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aportes", x => x.AportesId);
                });

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    CargoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo_departamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo_funcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.CargoId);
                });

            migrationBuilder.CreateTable(
                name: "Sueldo",
                columns: table => new
                {
                    SueldoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sueldo_estipulado = table.Column<double>(type: "float", nullable: false),
                    estado_sueldo = table.Column<bool>(type: "bit", nullable: false),
                    fecha_pago = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sueldo", x => x.SueldoId);
                });

            migrationBuilder.CreateTable(
                name: "Sueldo_final",
                columns: table => new
                {
                    Sueldo_FinalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sueldo_base = table.Column<float>(type: "real", nullable: false),
                    sueldo_descontado = table.Column<float>(type: "real", nullable: false),
                    tipo_decimo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sueldo_recibido = table.Column<float>(type: "real", nullable: false),
                    sueldo_anual_final = table.Column<float>(type: "real", nullable: false),
                    total_decimo_recibido = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sueldo_final", x => x.Sueldo_FinalId);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CargoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.EmpleadoId);
                    table.ForeignKey(
                        name: "FK_Empleado_Cargo_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargo",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nomina",
                columns: table => new
                {
                    NominaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpleadoId = table.Column<int>(type: "int", nullable: true),
                    CargoId = table.Column<int>(type: "int", nullable: true),
                    SueldoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomina", x => x.NominaId);
                    table.ForeignKey(
                        name: "FK_Nomina_Cargo_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargo",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Nomina_Empleado_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleado",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Nomina_Sueldo_SueldoId",
                        column: x => x.SueldoId,
                        principalTable: "Sueldo",
                        principalColumn: "SueldoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_CargoId",
                table: "Empleado",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Nomina_CargoId",
                table: "Nomina",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Nomina_EmpleadoId",
                table: "Nomina",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Nomina_SueldoId",
                table: "Nomina",
                column: "SueldoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aportes");

            migrationBuilder.DropTable(
                name: "Nomina");

            migrationBuilder.DropTable(
                name: "Sueldo_final");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Sueldo");

            migrationBuilder.DropTable(
                name: "Cargo");
        }
    }
}
