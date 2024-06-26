﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WS.Context;

#nullable disable

namespace WS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240626165015_MigracaoInicial")]
    partial class MigracaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WS.Models.ClinicaPregressa", b =>
                {
                    b.Property<int>("MyProperty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Alergias")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cirurgias")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DoencasInfecciosas")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MedicamentosContinuo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Outros")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TransfusaoSangue")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MyProperty");

                    b.ToTable("ClinicaPregressa");
                });

            modelBuilder.Entity("WS.Models.ExameClinico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Empresa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Funcao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Idade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Ocupacao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ExameClinico");
                });

            modelBuilder.Entity("WS.Models.HistoricoOcupacional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AcidentesTrabalho")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FuncoesAnteriores")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("HistoricoOcupacional");
                });
#pragma warning restore 612, 618
        }
    }
}