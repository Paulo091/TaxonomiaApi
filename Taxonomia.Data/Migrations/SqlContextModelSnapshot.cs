﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Taxonomia.Data.DbContexts.SqlContext;

#nullable disable

namespace Taxonomia.Data.Migrations
{
    [DbContext(typeof(SqlContext))]
    partial class SqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Taxonomia.Domain.ClasseEntity.Classe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FiloId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FiloId");

                    b.ToTable("Classe", (string)null);
                });

            modelBuilder.Entity("Taxonomia.Domain.DominioEntity.Dominio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dominio", (string)null);
                });

            modelBuilder.Entity("Taxonomia.Domain.EspecieEntity.Especie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GeneroId");

                    b.ToTable("Especie", (string)null);
                });

            modelBuilder.Entity("Taxonomia.Domain.FamiliaEntity.Familia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrdemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrdemId");

                    b.ToTable("Familia", (string)null);
                });

            modelBuilder.Entity("Taxonomia.Domain.FiloEntity.Filo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReinoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReinoId");

                    b.ToTable("Filo", (string)null);
                });

            modelBuilder.Entity("Taxonomia.Domain.GeneroEntity.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FamiliaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FamiliaId");

                    b.ToTable("Genero", (string)null);
                });

            modelBuilder.Entity("Taxonomia.Domain.OrdemEntity.Ordem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClasseId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClasseId");

                    b.ToTable("Ordem", (string)null);
                });

            modelBuilder.Entity("Taxonomia.Domain.OrganismoEntity.Organismo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EspecieId")
                        .HasColumnType("int");

                    b.Property<string>("NomeCientifico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeComum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EspecieId");

                    b.ToTable("Organismo", (string)null);
                });

            modelBuilder.Entity("Taxonomia.Domain.ReinoEntity.Reino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DominioId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DominioId");

                    b.ToTable("Reino", (string)null);
                });

            modelBuilder.Entity("Taxonomia.Domain.ClasseEntity.Classe", b =>
                {
                    b.HasOne("Taxonomia.Domain.FiloEntity.Filo", "Filo")
                        .WithMany("Classe")
                        .HasForeignKey("FiloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filo");
                });

            modelBuilder.Entity("Taxonomia.Domain.EspecieEntity.Especie", b =>
                {
                    b.HasOne("Taxonomia.Domain.GeneroEntity.Genero", "Genero")
                        .WithMany("Especie")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("Taxonomia.Domain.FamiliaEntity.Familia", b =>
                {
                    b.HasOne("Taxonomia.Domain.OrdemEntity.Ordem", "Ordem")
                        .WithMany("Familia")
                        .HasForeignKey("OrdemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ordem");
                });

            modelBuilder.Entity("Taxonomia.Domain.FiloEntity.Filo", b =>
                {
                    b.HasOne("Taxonomia.Domain.ReinoEntity.Reino", "Reino")
                        .WithMany("Filo")
                        .HasForeignKey("ReinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reino");
                });

            modelBuilder.Entity("Taxonomia.Domain.GeneroEntity.Genero", b =>
                {
                    b.HasOne("Taxonomia.Domain.FamiliaEntity.Familia", "Familia")
                        .WithMany("Genero")
                        .HasForeignKey("FamiliaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Familia");
                });

            modelBuilder.Entity("Taxonomia.Domain.OrdemEntity.Ordem", b =>
                {
                    b.HasOne("Taxonomia.Domain.ClasseEntity.Classe", "Classe")
                        .WithMany("Ordem")
                        .HasForeignKey("ClasseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classe");
                });

            modelBuilder.Entity("Taxonomia.Domain.OrganismoEntity.Organismo", b =>
                {
                    b.HasOne("Taxonomia.Domain.EspecieEntity.Especie", "Especie")
                        .WithMany("Organismo")
                        .HasForeignKey("EspecieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especie");
                });

            modelBuilder.Entity("Taxonomia.Domain.ReinoEntity.Reino", b =>
                {
                    b.HasOne("Taxonomia.Domain.DominioEntity.Dominio", "Dominio")
                        .WithMany("Reino")
                        .HasForeignKey("DominioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dominio");
                });

            modelBuilder.Entity("Taxonomia.Domain.ClasseEntity.Classe", b =>
                {
                    b.Navigation("Ordem");
                });

            modelBuilder.Entity("Taxonomia.Domain.DominioEntity.Dominio", b =>
                {
                    b.Navigation("Reino");
                });

            modelBuilder.Entity("Taxonomia.Domain.EspecieEntity.Especie", b =>
                {
                    b.Navigation("Organismo");
                });

            modelBuilder.Entity("Taxonomia.Domain.FamiliaEntity.Familia", b =>
                {
                    b.Navigation("Genero");
                });

            modelBuilder.Entity("Taxonomia.Domain.FiloEntity.Filo", b =>
                {
                    b.Navigation("Classe");
                });

            modelBuilder.Entity("Taxonomia.Domain.GeneroEntity.Genero", b =>
                {
                    b.Navigation("Especie");
                });

            modelBuilder.Entity("Taxonomia.Domain.OrdemEntity.Ordem", b =>
                {
                    b.Navigation("Familia");
                });

            modelBuilder.Entity("Taxonomia.Domain.ReinoEntity.Reino", b =>
                {
                    b.Navigation("Filo");
                });
#pragma warning restore 612, 618
        }
    }
}
