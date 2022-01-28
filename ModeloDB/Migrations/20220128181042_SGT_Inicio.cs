using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloDB.Migrations
{
    public partial class SGT_Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Descuentos",
                columns: table => new
                {
                    NominaId = table.Column<int>(type: "int", nullable: false),
                    AportesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descuentos", x => new { x.NominaId, x.AportesId });
                });

            migrationBuilder.CreateTable(
                name: "empleados",
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
                    sueldosSueldoId = table.Column<int>(type: "int", nullable: true),
                    SueldoId = table.Column<int>(type: "int", nullable: false),
                    CargoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleados", x => x.EmpleadoId);
                });

            migrationBuilder.CreateTable(
                name: "sueldo_finales",
                columns: table => new
                {
                    Sueldo_FinalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sueldo_base = table.Column<double>(type: "float", nullable: false),
                    sueldo_descontado = table.Column<double>(type: "float", nullable: false),
                    tipo_decimo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sueldo_recibido = table.Column<double>(type: "float", nullable: false),
                    sueldo_anual_final = table.Column<double>(type: "float", nullable: false),
                    total_decimo_recibido = table.Column<double>(type: "float", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sueldo_finales", x => x.Sueldo_FinalId);
                    table.ForeignKey(
                        name: "FK_sueldo_finales_empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sueldos",
                columns: table => new
                {
                    SueldoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sueldo_estipulado = table.Column<double>(type: "float", nullable: false),
                    estado_sueldo = table.Column<bool>(type: "bit", nullable: false),
                    fecha_pago = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sueldos", x => x.SueldoId);
                    table.ForeignKey(
                        name: "FK_sueldos_empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sueldos_empleados_EmpleadoId1",
                        column: x => x.EmpleadoId1,
                        principalTable: "empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "aportes",
                columns: table => new
                {
                    AportesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aporte_patronal_dado = table.Column<double>(type: "float", nullable: false),
                    aporte_personal_dado = table.Column<double>(type: "float", nullable: false),
                    total_decimo_dado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiempo_aportado = table.Column<int>(type: "int", nullable: false),
                    Sueldo_finalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aportes", x => x.AportesId);
                    table.ForeignKey(
                        name: "FK_aportes_sueldo_finales_Sueldo_finalId",
                        column: x => x.Sueldo_finalId,
                        principalTable: "sueldo_finales",
                        principalColumn: "Sueldo_FinalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nominas",
                columns: table => new
                {
                    NominaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SueldoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nominas", x => x.NominaId);
                    table.ForeignKey(
                        name: "FK_nominas_sueldos_SueldoId",
                        column: x => x.SueldoId,
                        principalTable: "sueldos",
                        principalColumn: "SueldoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cargos",
                columns: table => new
                {
                    CargoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo_departamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo_funcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NominaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargos", x => x.CargoId);
                    table.ForeignKey(
                        name: "FK_cargos_nominas_NominaId",
                        column: x => x.NominaId,
                        principalTable: "nominas",
                        principalColumn: "NominaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_aportes_Sueldo_finalId",
                table: "aportes",
                column: "Sueldo_finalId");

            migrationBuilder.CreateIndex(
                name: "IX_cargos_NominaId",
                table: "cargos",
                column: "NominaId");

            migrationBuilder.CreateIndex(
                name: "IX_Descuentos_AportesId",
                table: "Descuentos",
                column: "AportesId");

            migrationBuilder.CreateIndex(
                name: "IX_empleados_CargoId",
                table: "empleados",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_empleados_sueldosSueldoId",
                table: "empleados",
                column: "sueldosSueldoId");

            migrationBuilder.CreateIndex(
                name: "IX_nominas_SueldoId",
                table: "nominas",
                column: "SueldoId");

            migrationBuilder.CreateIndex(
                name: "IX_sueldo_finales_EmpleadoId",
                table: "sueldo_finales",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_sueldos_EmpleadoId",
                table: "sueldos",
                column: "EmpleadoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_sueldos_EmpleadoId1",
                table: "sueldos",
                column: "EmpleadoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Descuentos_aportes_AportesId",
                table: "Descuentos",
                column: "AportesId",
                principalTable: "aportes",
                principalColumn: "AportesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Descuentos_nominas_NominaId",
                table: "Descuentos",
                column: "NominaId",
                principalTable: "nominas",
                principalColumn: "NominaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_empleados_cargos_CargoId",
                table: "empleados",
                column: "CargoId",
                principalTable: "cargos",
                principalColumn: "CargoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_empleados_sueldos_sueldosSueldoId",
                table: "empleados",
                column: "sueldosSueldoId",
                principalTable: "sueldos",
                principalColumn: "SueldoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cargos_nominas_NominaId",
                table: "cargos");

            migrationBuilder.DropForeignKey(
                name: "FK_empleados_cargos_CargoId",
                table: "empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_empleados_sueldos_sueldosSueldoId",
                table: "empleados");

            migrationBuilder.DropTable(
                name: "Descuentos");

            migrationBuilder.DropTable(
                name: "aportes");

            migrationBuilder.DropTable(
                name: "sueldo_finales");

            migrationBuilder.DropTable(
                name: "nominas");

            migrationBuilder.DropTable(
                name: "cargos");

            migrationBuilder.DropTable(
                name: "sueldos");

            migrationBuilder.DropTable(
                name: "empleados");
        }
    }
}
