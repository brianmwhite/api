﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using alexandria.api.Helpers;

#nullable disable

namespace alexandria_api.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20240510151553_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("DeviceType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DeviceName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EbookDirectory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SavePathTemplate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Vendor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DeviceTypes");
                });

            modelBuilder.Entity("KnownDevice", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DeviceName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EbookDirectory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SavePathTemplate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Vendor")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("KnownDevices");
                });
#pragma warning restore 612, 618
        }
    }
}
