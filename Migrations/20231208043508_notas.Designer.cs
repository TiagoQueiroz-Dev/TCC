﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TCC.Database;

#nullable disable

namespace TCC.Migrations
{
    [DbContext(typeof(BancoContext))]
    [Migration("20231208043508_notas")]
    partial class notas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TCC.Models.EstoqueModel", b =>
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

                    b.Property<decimal>("ValorUnid")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("EstoqueGeral");
                });

            modelBuilder.Entity("TCC.Models.NotaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<long>("CPF_CNPJ")
                        .HasColumnType("BIGINT");

                    b.Property<int>("Cep")
                        .HasColumnType("MEDIUMINT");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("DataEmissao")
                        .HasColumnType("DATE");

                    b.Property<DateTime>("DataRecolhimento")
                        .HasColumnType("DATE");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("StatusNota")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal?>("TaxaEntrega")
                        .HasColumnType("decimal(10,2)");

                    b.Property<long>("Telefone")
                        .HasColumnType("BIGINT");

                    b.Property<decimal>("ValorDesconto")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("ValorPago")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("TCC.Models.PedidoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdNota")
                        .HasColumnType("int");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<int>("QtdDias")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
