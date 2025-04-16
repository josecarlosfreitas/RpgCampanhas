﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RpgCampanhas.Data;

#nullable disable

namespace RpgCampanhas.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250415170035_AddImagePathToEntities")]
    partial class AddImagePathToEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RpgCampanhas.Models.Campanha", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("MestreId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MestreId");

                    b.ToTable("Campanhas");
                });

            modelBuilder.Entity("RpgCampanhas.Models.Ficha3det", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<int>("Armadura")
                        .HasColumnType("int");

                    b.Property<string>("Desvantagens")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DinheiroEItens")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Forca")
                        .HasColumnType("int");

                    b.Property<int>("Habilidade")
                        .HasColumnType("int");

                    b.Property<string>("Historia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MagiasConhecidas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("NpcId")
                        .HasColumnType("bigint");

                    b.Property<long?>("PersonagemId")
                        .HasColumnType("bigint");

                    b.Property<int>("PoderDeFogo")
                        .HasColumnType("int");

                    b.Property<int?>("Pontos")
                        .HasColumnType("int");

                    b.Property<int?>("PontosDeExperiencia")
                        .HasColumnType("int");

                    b.Property<int>("PontosDeMagia")
                        .HasColumnType("int");

                    b.Property<int>("PontosDeVida")
                        .HasColumnType("int");

                    b.Property<int>("Resistencia")
                        .HasColumnType("int");

                    b.Property<string>("TiposDeDano")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vantagens")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NpcId");

                    b.HasIndex("PersonagemId");

                    b.ToTable("Ficha3Dets");
                });

            modelBuilder.Entity("RpgCampanhas.Models.Historia", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CampanhaId")
                        .HasColumnType("bigint");

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CampanhaId");

                    b.ToTable("Historias");
                });

            modelBuilder.Entity("RpgCampanhas.Models.Local", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CampanhaId")
                        .HasColumnType("bigint");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mapa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CampanhaId");

                    b.ToTable("Locais");
                });

            modelBuilder.Entity("RpgCampanhas.Models.NPC", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CampanhaId")
                        .HasColumnType("bigint");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoFicha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CampanhaId");

                    b.ToTable("NPCs");
                });

            modelBuilder.Entity("RpgCampanhas.Models.Nota", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AutorId")
                        .HasColumnType("bigint");

                    b.Property<long>("CampanhaId")
                        .HasColumnType("bigint");

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("CampanhaId");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("RpgCampanhas.Models.Personagem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CampanhaId")
                        .HasColumnType("bigint");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("JogadorId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoFicha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CampanhaId");

                    b.HasIndex("JogadorId");

                    b.ToTable("Personagens");
                });

            modelBuilder.Entity("RpgCampanhas.Models.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("RpgCampanhas.Models.Campanha", b =>
                {
                    b.HasOne("RpgCampanhas.Models.Usuario", "Mestre")
                        .WithMany("Campanhas")
                        .HasForeignKey("MestreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mestre");
                });

            modelBuilder.Entity("RpgCampanhas.Models.Ficha3det", b =>
                {
                    b.HasOne("RpgCampanhas.Models.NPC", "Npc")
                        .WithMany("Ficha3Dets")
                        .HasForeignKey("NpcId");

                    b.HasOne("RpgCampanhas.Models.Personagem", "Personagem")
                        .WithMany("Ficha3Dets")
                        .HasForeignKey("PersonagemId");

                    b.Navigation("Npc");

                    b.Navigation("Personagem");
                });

            modelBuilder.Entity("RpgCampanhas.Models.Historia", b =>
                {
                    b.HasOne("RpgCampanhas.Models.Campanha", "Campanha")
                        .WithMany("Historias")
                        .HasForeignKey("CampanhaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campanha");
                });

            modelBuilder.Entity("RpgCampanhas.Models.Local", b =>
                {
                    b.HasOne("RpgCampanhas.Models.Campanha", "Campanha")
                        .WithMany("Locais")
                        .HasForeignKey("CampanhaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campanha");
                });

            modelBuilder.Entity("RpgCampanhas.Models.NPC", b =>
                {
                    b.HasOne("RpgCampanhas.Models.Campanha", "Campanha")
                        .WithMany("NPCs")
                        .HasForeignKey("CampanhaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campanha");
                });

            modelBuilder.Entity("RpgCampanhas.Models.Nota", b =>
                {
                    b.HasOne("RpgCampanhas.Models.Usuario", "Autor")
                        .WithMany("Notas")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RpgCampanhas.Models.Campanha", "Campanha")
                        .WithMany("Notas")
                        .HasForeignKey("CampanhaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Campanha");
                });

            modelBuilder.Entity("RpgCampanhas.Models.Personagem", b =>
                {
                    b.HasOne("RpgCampanhas.Models.Campanha", "Campanha")
                        .WithMany("Personagens")
                        .HasForeignKey("CampanhaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RpgCampanhas.Models.Usuario", "Jogador")
                        .WithMany("Personagens")
                        .HasForeignKey("JogadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campanha");

                    b.Navigation("Jogador");
                });

            modelBuilder.Entity("RpgCampanhas.Models.Campanha", b =>
                {
                    b.Navigation("Historias");

                    b.Navigation("Locais");

                    b.Navigation("NPCs");

                    b.Navigation("Notas");

                    b.Navigation("Personagens");
                });

            modelBuilder.Entity("RpgCampanhas.Models.NPC", b =>
                {
                    b.Navigation("Ficha3Dets");
                });

            modelBuilder.Entity("RpgCampanhas.Models.Personagem", b =>
                {
                    b.Navigation("Ficha3Dets");
                });

            modelBuilder.Entity("RpgCampanhas.Models.Usuario", b =>
                {
                    b.Navigation("Campanhas");

                    b.Navigation("Notas");

                    b.Navigation("Personagens");
                });
#pragma warning restore 612, 618
        }
    }
}
