﻿// <auto-generated />
using System;
using MalaDireta.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MalaDireta.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("MalaDireta.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("MalaDireta.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CEP")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EnderecoId");

                    b.ToTable("Enderecoes");
                });

            modelBuilder.Entity("MalaDireta.Models.Cliente", b =>
                {
                    b.HasOne("MalaDireta.Models.Endereco", null)
                        .WithMany("Residentes")
                        .HasForeignKey("EnderecoId");
                });

            modelBuilder.Entity("MalaDireta.Models.Endereco", b =>
                {
                    b.Navigation("Residentes");
                });
#pragma warning restore 612, 618
        }
    }
}
