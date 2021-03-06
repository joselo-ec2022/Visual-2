// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModeloDB;

namespace ModeloDB.Migrations
{
    [DbContext(typeof(ListadoDB))]
    [Migration("20220120231941_InicioSGT")]
    partial class InicioSGT
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sistema_contador.Entidad.Aportes", b =>
                {
                    b.Property<int>("AportesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("aporte_patronal")
                        .HasColumnType("real");

                    b.Property<float>("aporte_personal_dado")
                        .HasColumnType("real");

                    b.Property<int>("tiempo_aportado")
                        .HasColumnType("int");

                    b.Property<string>("total_decimo_dado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AportesId");

                    b.ToTable("Aportes");
                });

            modelBuilder.Entity("Sistema_contador.Entidad.Cargo", b =>
                {
                    b.Property<int>("CargoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre_cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo_departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo_funcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CargoId");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("Sistema_contador.Entidad.Empleado", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CargoId")
                        .HasColumnType("int");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpleadoId");

                    b.HasIndex("CargoId");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("Sistema_contador.Entidad.Nomina", b =>
                {
                    b.Property<int>("NominaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CargoId")
                        .HasColumnType("int");

                    b.Property<int?>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<int?>("SueldoId")
                        .HasColumnType("int");

                    b.HasKey("NominaId");

                    b.HasIndex("CargoId");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("SueldoId");

                    b.ToTable("Nomina");
                });

            modelBuilder.Entity("Sistema_contador.Entidad.Sueldo", b =>
                {
                    b.Property<int>("SueldoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("estado_sueldo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("fecha_pago")
                        .HasColumnType("datetime2");

                    b.Property<double>("sueldo_estipulado")
                        .HasColumnType("float");

                    b.HasKey("SueldoId");

                    b.ToTable("Sueldo");
                });

            modelBuilder.Entity("Sistema_contador.Entidad.Sueldo_final", b =>
                {
                    b.Property<int>("Sueldo_FinalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("sueldo_anual_final")
                        .HasColumnType("real");

                    b.Property<float>("sueldo_base")
                        .HasColumnType("real");

                    b.Property<float>("sueldo_descontado")
                        .HasColumnType("real");

                    b.Property<float>("sueldo_recibido")
                        .HasColumnType("real");

                    b.Property<string>("tipo_decimo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("total_decimo_recibido")
                        .HasColumnType("real");

                    b.HasKey("Sueldo_FinalId");

                    b.ToTable("Sueldo_final");
                });

            modelBuilder.Entity("Sistema_contador.Entidad.Empleado", b =>
                {
                    b.HasOne("Sistema_contador.Entidad.Cargo", null)
                        .WithMany("Trabajadores")
                        .HasForeignKey("CargoId");
                });

            modelBuilder.Entity("Sistema_contador.Entidad.Nomina", b =>
                {
                    b.HasOne("Sistema_contador.Entidad.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId");

                    b.HasOne("Sistema_contador.Entidad.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("EmpleadoId");

                    b.HasOne("Sistema_contador.Entidad.Sueldo", "Sueldo")
                        .WithMany()
                        .HasForeignKey("SueldoId");

                    b.Navigation("Cargo");

                    b.Navigation("Empleado");

                    b.Navigation("Sueldo");
                });

            modelBuilder.Entity("Sistema_contador.Entidad.Cargo", b =>
                {
                    b.Navigation("Trabajadores");
                });
#pragma warning restore 612, 618
        }
    }
}
