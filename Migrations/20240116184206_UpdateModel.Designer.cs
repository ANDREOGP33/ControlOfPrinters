﻿// <auto-generated />
using ControlOfPrinters.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControlOfPrinters.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240116184206_UpdateModel")]
    partial class UpdateModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("ControlOfPrinters.Entities.Printer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sector")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Serial")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("printers");
                });
#pragma warning restore 612, 618
        }
    }
}
