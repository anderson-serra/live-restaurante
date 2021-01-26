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
    [Migration("20210126014114_adiciona-relacao-muitos-para-muitos")]
    partial class adicionarelacaomuitosparamuitos
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

                    b.Property<int>("TipoPratoId")
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

                    b.Property<int?>("PratoId")
                        .HasColumnType("int");

                    b.Property<int>("TipoRefeicaoId")
                        .HasColumnType("integer")
                        .HasColumnName("TipoRefeicaoId");

                    b.HasKey("Id");

                    b.HasIndex("PratoId");

                    b.HasIndex("TipoRefeicaoId");

                    b.ToTable("Refeicao");
                });

            modelBuilder.Entity("Restaurante.Api.Domain.Entities.RefeicaoPrato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("PratoId")
                        .HasColumnType("int");

                    b.Property<int>("RefeicaoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PratoId");

                    b.HasIndex("RefeicaoId");

                    b.ToTable("RefeicaoPrato");
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
                        .HasConstraintName("FK_TipoPrato")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoPrato");
                });

            modelBuilder.Entity("Restaurante.Api.Domain.Entities.Refeicao", b =>
                {
                    b.HasOne("Restaurante.Api.Domain.Entities.Prato", null)
                        .WithMany("Refeicoes")
                        .HasForeignKey("PratoId");

                    b.HasOne("Restaurante.Api.Domain.Entities.TipoRefeicao", "TipoRefeicao")
                        .WithMany("Refeicoes")
                        .HasForeignKey("TipoRefeicaoId")
                        .HasConstraintName("FK_TipoRefeicao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoRefeicao");
                });

            modelBuilder.Entity("Restaurante.Api.Domain.Entities.RefeicaoPrato", b =>
                {
                    b.HasOne("Restaurante.Api.Domain.Entities.Prato", "Prato")
                        .WithMany("RefeicaoPratos")
                        .HasForeignKey("PratoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restaurante.Api.Domain.Entities.Refeicao", "Refeicao")
                        .WithMany("RefeicaoPratos")
                        .HasForeignKey("RefeicaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prato");

                    b.Navigation("Refeicao");
                });

            modelBuilder.Entity("Restaurante.Api.Domain.Entities.Prato", b =>
                {
                    b.Navigation("RefeicaoPratos");

                    b.Navigation("Refeicoes");
                });

            modelBuilder.Entity("Restaurante.Api.Domain.Entities.Refeicao", b =>
                {
                    b.Navigation("RefeicaoPratos");
                });

            modelBuilder.Entity("Restaurante.Api.Domain.Entities.TipoPrato", b =>
                {
                    b.Navigation("Pratos");
                });

            modelBuilder.Entity("Restaurante.Api.Domain.Entities.TipoRefeicao", b =>
                {
                    b.Navigation("Refeicoes");
                });
#pragma warning restore 612, 618
        }
    }
}
