﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TCC.Database;

#nullable disable

namespace TCC.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231017133552_deploy")]
    partial class deploy
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TCC.Models.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Alugados")
                        .HasColumnType("int");

                    b.Property<int>("Disponiveis")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("QuantidadeTotal")
                        .HasColumnType("int");

                    b.Property<double>("ValorUnid")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("EstoqueGeral");
                });

            modelBuilder.Entity("TCC.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Andaimes_10")
                        .HasColumnType("int");

                    b.Property<int>("Andaimes_13")
                        .HasColumnType("int");

                    b.Property<int>("Andaimes_15")
                        .HasColumnType("int");

                    b.Property<int>("Andaimes_20")
                        .HasColumnType("int");

                    b.Property<int>("Bitoneira")
                        .HasColumnType("int");

                    b.Property<int>("Escora_35")
                        .HasColumnType("int");

                    b.Property<int>("Escora_50")
                        .HasColumnType("int");

                    b.Property<int>("Lastro_10")
                        .HasColumnType("int");

                    b.Property<int>("Lastro_15")
                        .HasColumnType("int");

                    b.Property<int>("Lastro_20")
                        .HasColumnType("int");

                    b.Property<int>("Pe_Regulador")
                        .HasColumnType("int");

                    b.Property<int>("Pranchao")
                        .HasColumnType("int");

                    b.Property<int>("Rodanas")
                        .HasColumnType("int");

                    b.Property<int>("Travas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
