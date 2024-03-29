﻿// <auto-generated />
using System;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(PublicacionesContext))]
    [Migration("20240305152828_ChangesInPublicacionesImage")]
    partial class ChangesInPublicacionesImage
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Models.Imagen", b =>
                {
                    b.Property<int>("ImagenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImagenId"));

                    b.Property<byte[]>("Contenido")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PublicacionId")
                        .HasColumnType("int");

                    b.Property<string>("Ruta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImagenId");

                    b.HasIndex("PublicacionId");

                    b.ToTable("Imagen");
                });

            modelBuilder.Entity("API.Models.Publicacion", b =>
                {
                    b.Property<int>("PublicacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PublicacionId"));

                    b.Property<int>("Ambientes")
                        .HasColumnType("int");

                    b.Property<DateTime>("Antiguedad")
                        .HasColumnType("datetime2");

                    b.Property<string>("CoordenadasUbicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("M2")
                        .HasColumnType("float");

                    b.Property<int>("TipoOperacion")
                        .HasColumnType("int");

                    b.Property<int>("TipoPropiedad")
                        .HasColumnType("int");

                    b.HasKey("PublicacionId");

                    b.ToTable("Publicaciones");
                });

            modelBuilder.Entity("API.Models.Imagen", b =>
                {
                    b.HasOne("API.Models.Publicacion", null)
                        .WithMany("Imagenes")
                        .HasForeignKey("PublicacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.Publicacion", b =>
                {
                    b.Navigation("Imagenes");
                });
#pragma warning restore 612, 618
        }
    }
}
