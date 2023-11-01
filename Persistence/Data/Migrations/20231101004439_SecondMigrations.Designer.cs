﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Data;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(FarmaciaAppContext))]
    [Migration("20231101004439_SecondMigrations")]
    partial class SecondMigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdDepartamentoFk")
                        .HasColumnType("int");

                    b.Property<string>("NombreCiudad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdDepartamentoFk");

                    b.ToTable("ciudad", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ContactoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("IdPersonaFk")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdTipoContactoFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPersonaFk");

                    b.HasIndex("IdTipoContactoFk");

                    b.ToTable("contactopersona", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPaisFk")
                        .HasColumnType("int");

                    b.Property<string>("NombreDepartamento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdPaisFk");

                    b.ToTable("departamento", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.DetalleMovInventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("IdInventarionFk")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("IdMovInvFk")
                        .HasColumnType("varchar(10)");

                    b.Property<double>("Precio")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("IdInventarionFk");

                    b.HasIndex("IdMovInvFk");

                    b.ToTable("detallemovinventario", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FacturaActual")
                        .HasColumnType("int");

                    b.Property<int>("FacturaFinal")
                        .HasColumnType("int");

                    b.Property<int>("FacturaInicial")
                        .HasColumnType("int");

                    b.Property<string>("NroResolucion")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("factura", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.FormaPago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreFormaPago")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("formatopago", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Inventario", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("IdCodProductoFk")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdPresentacionFk")
                        .HasColumnType("int");

                    b.Property<string>("NombreInventario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<double>("Precio")
                        .HasColumnType("double");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("StockMax")
                        .HasColumnType("int");

                    b.Property<int>("StockMin")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCodProductoFk")
                        .IsUnique();

                    b.HasIndex("IdPresentacionFk");

                    b.ToTable("inventario", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreMarca")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("marca", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.MovimientoInventario", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<DateOnly>("FechaMovimiento")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaVencimiento")
                        .HasColumnType("date");

                    b.Property<int>("IdFacturaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdFormaPagoFk")
                        .HasColumnType("int");

                    b.Property<string>("IdResponsableFk")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdTipoMovInvFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdFacturaFk");

                    b.HasIndex("IdFormaPagoFk");

                    b.HasIndex("IdResponsableFk");

                    b.HasIndex("IdTipoMovInvFk");

                    b.ToTable("movimientoinventario", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombrePais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateOnly>("FechaRegistro")
                        .HasColumnType("date");

                    b.Property<int>("IdRolPersonaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoDocumentoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPersonaFk")
                        .HasColumnType("int");

                    b.Property<string>("NombrePersona")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdRolPersonaFk");

                    b.HasIndex("IdTipoDocumentoFk");

                    b.HasIndex("IdTipoPersonaFk");

                    b.ToTable("persona", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Presentacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombrePresentacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("presentacion", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdMarcaFk")
                        .HasColumnType("int");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdMarcaFk");

                    b.ToTable("producto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdUserFk")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdUserFk");

                    b.ToTable("refreshtoken", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("rol", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.RolPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreRolPersona")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("rolpersona", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoContacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreTipoContacto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tipocontacto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreTipoDocumento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tipodocumento", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoMovInventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreTipoMovInventario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tipomovinventario", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreTipoPersona")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tipopersona", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.UbicacionPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bis")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Cardinal")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CardinalSec")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CodigoPostal")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdCiudadFk")
                        .HasColumnType("int");

                    b.Property<string>("IdPersonaFk")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Letra")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LetraSec")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("LetraTer")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("NumeroPri")
                        .HasColumnType("int");

                    b.Property<int>("NumeroSec")
                        .HasColumnType("int");

                    b.Property<int>("NumeroTer")
                        .HasColumnType("int");

                    b.Property<string>("TipoDeVia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdCiudadFk")
                        .IsUnique();

                    b.HasIndex("IdPersonaFk")
                        .IsUnique();

                    b.ToTable("ubicacionpersona", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("varchar(225)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.UserRol", b =>
                {
                    b.Property<int>("IdUserFk")
                        .HasColumnType("int");

                    b.Property<int>("IdRolFk")
                        .HasColumnType("int");

                    b.HasKey("IdUserFk", "IdRolFk");

                    b.HasIndex("IdRolFk");

                    b.ToTable("userrol", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.HasOne("Domain.Entities.Departamento", "Departamentos")
                        .WithMany("Ciudades")
                        .HasForeignKey("IdDepartamentoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Domain.Entities.ContactoPersona", b =>
                {
                    b.HasOne("Domain.Entities.Persona", "Personas")
                        .WithMany("ContactoPersonas")
                        .HasForeignKey("IdPersonaFk");

                    b.HasOne("Domain.Entities.TipoContacto", "TipoContactos")
                        .WithMany("ContactoPersonas")
                        .HasForeignKey("IdTipoContactoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personas");

                    b.Navigation("TipoContactos");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.HasOne("Domain.Entities.Pais", "Paises")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPaisFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paises");
                });

            modelBuilder.Entity("Domain.Entities.DetalleMovInventario", b =>
                {
                    b.HasOne("Domain.Entities.Inventario", "Inventarios")
                        .WithMany("DetalleMovInventarios")
                        .HasForeignKey("IdInventarionFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.MovimientoInventario", "MovimientoInventarios")
                        .WithMany("DetalleMovInventarios")
                        .HasForeignKey("IdMovInvFk");

                    b.Navigation("Inventarios");

                    b.Navigation("MovimientoInventarios");
                });

            modelBuilder.Entity("Domain.Entities.Inventario", b =>
                {
                    b.HasOne("Domain.Entities.Producto", "Productos")
                        .WithOne("Inventarios")
                        .HasForeignKey("Domain.Entities.Inventario", "IdCodProductoFk");

                    b.HasOne("Domain.Entities.Presentacion", "Presentaciones")
                        .WithMany("Inventarios")
                        .HasForeignKey("IdPresentacionFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Presentaciones");

                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Domain.Entities.MovimientoInventario", b =>
                {
                    b.HasOne("Domain.Entities.Factura", "Facturas")
                        .WithMany("MovimientoInventarios")
                        .HasForeignKey("IdFacturaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.FormaPago", "FormaPagos")
                        .WithMany("MovimientoInventarios")
                        .HasForeignKey("IdFormaPagoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Persona", "PersonaResponsable")
                        .WithMany("MovimientoInventarios")
                        .HasForeignKey("IdResponsableFk");

                    b.HasOne("Domain.Entities.TipoMovInventario", "TipoMovInventarios")
                        .WithMany("MovimientoInventarios")
                        .HasForeignKey("IdTipoMovInvFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Facturas");

                    b.Navigation("FormaPagos");

                    b.Navigation("PersonaResponsable");

                    b.Navigation("TipoMovInventarios");
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.HasOne("Domain.Entities.RolPersona", "RolPersonas")
                        .WithMany("Personas")
                        .HasForeignKey("IdRolPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TipoDocumento", "TipoDocumentos")
                        .WithMany("Personas")
                        .HasForeignKey("IdTipoDocumentoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TipoPersona", "TipoPersonas")
                        .WithMany("Personas")
                        .HasForeignKey("IdTipoPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RolPersonas");

                    b.Navigation("TipoDocumentos");

                    b.Navigation("TipoPersonas");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.HasOne("Domain.Entities.Marca", "Marcas")
                        .WithMany("Productos")
                        .HasForeignKey("IdMarcaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marcas");
                });

            modelBuilder.Entity("Domain.Entities.RefreshToken", b =>
                {
                    b.HasOne("Domain.Entities.User", "Users")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("IdUserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Entities.UbicacionPersona", b =>
                {
                    b.HasOne("Domain.Entities.Ciudad", "Ciudades")
                        .WithOne("UbicacionPersona")
                        .HasForeignKey("Domain.Entities.UbicacionPersona", "IdCiudadFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Persona", "Personas")
                        .WithOne("UbicacionPersonas")
                        .HasForeignKey("Domain.Entities.UbicacionPersona", "IdPersonaFk");

                    b.Navigation("Ciudades");

                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.UserRol", b =>
                {
                    b.HasOne("Domain.Entities.Rol", "Rols")
                        .WithMany("UserRols")
                        .HasForeignKey("IdRolFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "Users")
                        .WithMany("UserRols")
                        .HasForeignKey("IdUserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rols");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Navigation("UbicacionPersona");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("Domain.Entities.Factura", b =>
                {
                    b.Navigation("MovimientoInventarios");
                });

            modelBuilder.Entity("Domain.Entities.FormaPago", b =>
                {
                    b.Navigation("MovimientoInventarios");
                });

            modelBuilder.Entity("Domain.Entities.Inventario", b =>
                {
                    b.Navigation("DetalleMovInventarios");
                });

            modelBuilder.Entity("Domain.Entities.Marca", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Domain.Entities.MovimientoInventario", b =>
                {
                    b.Navigation("DetalleMovInventarios");
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.Navigation("ContactoPersonas");

                    b.Navigation("MovimientoInventarios");

                    b.Navigation("UbicacionPersonas");
                });

            modelBuilder.Entity("Domain.Entities.Presentacion", b =>
                {
                    b.Navigation("Inventarios");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Navigation("Inventarios");
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Navigation("UserRols");
                });

            modelBuilder.Entity("Domain.Entities.RolPersona", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.TipoContacto", b =>
                {
                    b.Navigation("ContactoPersonas");
                });

            modelBuilder.Entity("Domain.Entities.TipoDocumento", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.TipoMovInventario", b =>
                {
                    b.Navigation("MovimientoInventarios");
                });

            modelBuilder.Entity("Domain.Entities.TipoPersona", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("RefreshTokens");

                    b.Navigation("UserRols");
                });
#pragma warning restore 612, 618
        }
    }
}