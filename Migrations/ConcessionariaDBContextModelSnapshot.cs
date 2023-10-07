﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using concessionaria_WEBAPI.Data;

#nullable disable

namespace Concessionaria.cs.Migrations
{
    [DbContext(typeof(ConcessionariaDBContext))]
    partial class ConcessionariaDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("concessionaria_WEBAPI.Models.ClienteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<long>("Telefone")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("concessionaria_WEBAPI.Models.DocumentoModel", b =>
                {
                    b.Property<string>("PlacaDoc")
                        .HasColumnType("TEXT");

                    b.Property<bool>("CRLV")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IPVA")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlacaDoc");

                    b.ToTable("Documento");
                });

            modelBuilder.Entity("concessionaria_WEBAPI.Models.FuncionarioModel", b =>
                {
                    b.Property<int>("IdFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AnoContratatado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cargo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Salario")
                        .HasColumnType("TEXT");

                    b.HasKey("IdFuncionario");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("concessionaria_WEBAPI.Models.GaragemModel", b =>
                {
                    b.Property<int>("IdVaga")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlacaVaga")
                        .HasColumnType("TEXT");

                    b.HasKey("IdVaga");

                    b.ToTable("Garagem");
                });

            modelBuilder.Entity("concessionaria_WEBAPI.Models.MensalistaModel", b =>
                {
                    b.Property<int>("CpfMensalista")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DiaDaLocacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.HasKey("CpfMensalista");

                    b.ToTable("Mensalista");
                });

            modelBuilder.Entity("concessionaria_WEBAPI.Models.OficinaModel", b =>
                {
                    b.Property<int>("IdCarroOficina")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Procedimento")
                        .IsRequired()
                        .HasMaxLength(511)
                        .HasColumnType("TEXT");

                    b.HasKey("IdCarroOficina");

                    b.ToTable("Oficina");
                });

            modelBuilder.Entity("concessionaria_WEBAPI.Models.PedidoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FuncionarioId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MensalistaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("VeiculoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("MensalistaId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("concessionaria_WEBAPI.Models.VeiculoModel", b =>
                {
                    b.Property<int>("IdVeiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnoVeiculo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ModeloVeiculo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PedidoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlacaVeiculo")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TipoVeiculo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Valor")
                        .HasColumnType("TEXT");

                    b.HasKey("IdVeiculo");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("concessionaria_WEBAPI.Models.PedidoModel", b =>
                {
                    b.HasOne("concessionaria_WEBAPI.Models.ClienteModel", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("concessionaria_WEBAPI.Models.FuncionarioModel", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId");

                    b.HasOne("concessionaria_WEBAPI.Models.MensalistaModel", "Mensalista")
                        .WithMany()
                        .HasForeignKey("MensalistaId");

                    b.HasOne("concessionaria_WEBAPI.Models.VeiculoModel", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId");

                    b.Navigation("Cliente");

                    b.Navigation("Funcionario");

                    b.Navigation("Mensalista");

                    b.Navigation("Veiculo");
                });
#pragma warning restore 612, 618
        }
    }
}