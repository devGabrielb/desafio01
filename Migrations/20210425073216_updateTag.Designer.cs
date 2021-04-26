﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using desafio01.Data;

namespace desafio01.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210425073216_updateTag")]
    partial class updateTag
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("desafio01.Models.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ToolId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ToolId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("desafio01.Models.Tool", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(1500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tools");
                });

            modelBuilder.Entity("desafio01.Models.Tag", b =>
                {
                    b.HasOne("desafio01.Models.Tool", null)
                        .WithMany("Tags")
                        .HasForeignKey("ToolId");
                });

            modelBuilder.Entity("desafio01.Models.Tool", b =>
                {
                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}
