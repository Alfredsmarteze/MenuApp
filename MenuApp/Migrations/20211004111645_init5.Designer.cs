﻿// <auto-generated />
using System;
using MenuApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MenuApp.Migrations
{
    [DbContext(typeof(MenuContext))]
    [Migration("20211004111645_init5")]
    partial class init5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MenuApp.Models.Menuclass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Controller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataRoute")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<bool>("HasChildren")
                        .HasColumnType("bit");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdApplication")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdMenu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("IdParent")
                        .HasColumnType("int");

                    b.Property<bool>("IsMenu")
                        .HasColumnType("bit");

                    b.Property<string>("MenuText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("menuclasses");
                });

            modelBuilder.Entity("MenuApp.Models.ParentList", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MenuclassId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MenuclassId");

                    b.ToTable("ParentList");
                });

            modelBuilder.Entity("MenuApp.Models.ParentList", b =>
                {
                    b.HasOne("MenuApp.Models.Menuclass", null)
                        .WithMany("ParentNames")
                        .HasForeignKey("MenuclassId");
                });

            modelBuilder.Entity("MenuApp.Models.Menuclass", b =>
                {
                    b.Navigation("ParentNames");
                });
#pragma warning restore 612, 618
        }
    }
}
