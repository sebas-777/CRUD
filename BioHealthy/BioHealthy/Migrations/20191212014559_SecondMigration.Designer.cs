﻿// <auto-generated />
using System;
using BioHealthy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BioHealthy.Migrations
{
    [DbContext(typeof(EmpleadosContext))]
    [Migration("20191212014559_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BioHealthy.Models.Empleado", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnName("nvarchar(250)");

                    b.Property<string>("Cargo")
                        .HasColumnName("nvarchar(50)");

                    b.Property<string>("Ciudad")
                        .HasColumnName("varchar(25)");

                    b.Property<int>("Documento")
                        .HasColumnName("varchar(20)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnName("date(15)");

                    b.Property<DateTime>("Hora")
                        .HasColumnName("date(10)");

                    b.Property<string>("Nombre")
                        .HasColumnName("varchar(30)");

                    b.HasKey("EmpleadoId");

                    b.ToTable("Empleados");
                });
#pragma warning restore 612, 618
        }
    }
}
