﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurante.Api.Repository.DataContext;

namespace Restaurante.Api.Migrations
{
    [DbContext(typeof(RestauranteContext))]
    [Migration("20210126010311_adicao-chaveestrangeira-ao-prato")]
    partial class adicaochaveestrangeiraaoprato
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Restaurante.Api.Domain.Entities.Adicional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Adicional");
                });

            modelBuilder.Entity("Restaurante.Api.Domain.Entities.Opcao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Opcao");
                });

            modelBuilder.Entity("Restaurante.Api.Domain.Entities.Prato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<int?>("TipoPratoId")
                        .HasColumnType("integer")
                        .HasColumnName("TipoPratoId");

                    b.HasKey("Id");

                    b.HasIndex("TipoPratoId");

                    b.ToTable("Prato");
                });

            modelBuilder.Entity("Restaurante.Api.Domain.Entities.Refeicao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("NomeRefeicao")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Refeicao");
                });

            modelBuilder.Entity("Restaurante.Api.Domain.Entities.TipoPrato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("TipoPrato");
                });

            modelBuilder.Entity("Restaurante.Api.Domain.Entities.TipoRefeicao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("TipoRefeicao");
                });

            modelBuilder.Entity("Restaurante.Api.Domain.Entities.Prato", b =>
                {
                    b.HasOne("Restaurante.Api.Domain.Entities.TipoPrato", "TipoPrato")
                        .WithMany("Pratos")
                        .HasForeignKey("TipoPratoId")
                        .HasConstraintName("FK_TipoPrato");

                    b.Navigation("TipoPrato");
                });

            modelBuilder.Entity("Restaurante.Api.Domain.Entities.TipoPrato", b =>
                {
                    b.Navigation("Pratos");
                });
#pragma warning restore 612, 618
        }
    }
}
