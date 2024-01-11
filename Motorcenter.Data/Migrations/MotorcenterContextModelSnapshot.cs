﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Motorcenter.Data.Contexts;

#nullable disable

namespace Motorcenter.Data.Migrations
{
    [DbContext(typeof(MotorcenterContext))]
    partial class MotorcenterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Motorcenter.Data.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Motorcenter.Data.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OptionType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Motorcenter.Data.Entities.Filter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OptionType")
                        .HasColumnType("int");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Filters");
                });

            modelBuilder.Entity("Motorcenter.Data.Entities.Fuel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OptionType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Fuels");
                });

            modelBuilder.Entity("Motorcenter.Data.Entities.Mileage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Range")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mileages");
                });

            modelBuilder.Entity("Motorcenter.Data.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("MileageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("MileageId");

                    b.HasIndex("YearId")
                        .IsUnique();

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Motorcenter.Data.Entities.VehicleColor", b =>
                {
                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.HasKey("VehicleId", "ColorId");

                    b.HasIndex("ColorId");

                    b.ToTable("VehicleColors");
                });

            modelBuilder.Entity("Motorcenter.Data.Entities.VehicleFuel", b =>
                {
                    b.Property<int>("FuelId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("FuelId", "VehicleId");

                    b.HasIndex("VehicleId");

                    b.ToTable("VehicleFuels");
                });

            modelBuilder.Entity("Motorcenter.Data.Entities.VehicleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bike")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Boat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Car")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Jetski")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Moped")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Snowmobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VehicleTypes");
                });

            modelBuilder.Entity("Motorcenter.Data.Entities.VehicleTypeFilter", b =>
                {
                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("int");

                    b.Property<int>("FilterId")
                        .HasColumnType("int");

                    b.HasKey("VehicleTypeId", "FilterId");

                    b.HasIndex("FilterId");

                    b.ToTable("VehicleTypeFilers");
                });

            modelBuilder.Entity("Motorcenter.Data.Entities.VehicleTypeVehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("int");

                    b.HasKey("VehicleId", "VehicleTypeId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("vehicleTypeVehicles");
                });

            modelBuilder.Entity("Motorcenter.Data.Entities.Year", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Range")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Years");
                });

            modelBuilder.Entity("Motorcenter.Data.Entities.Vehicle", b =>
                {
                    b.HasOne("Motorcenter.Data.Entities.Brand", "Brand")
                        .WithMany("Vehicles")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Motorcenter.Data.Entities.Mileage", "Mileage")
                        .WithMany("Vehicles")
                        .HasForeignKey("MileageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Motorcenter.Data.Entities.Year", "Year")
                        .WithOne("Vehicles")
                        .HasForeignKey("Motorcenter.Data.Entities.Vehicle", "YearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Mileage");

                    b.Navigation("Year");
                });

            modelBuilder.Entity("Motorcenter.Data.Entities.VehicleColor", b =>
                {
                    b.HasOne("Motorcenter.Data.Entities.Color", null)
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Motorcenter.Data.Entities.Vehicle", null)
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Motorcenter.Data.Entities.VehicleFuel", b =>
                {
                    b.HasOne("Motorcenter.Data.Entities.Fuel", null)
                        .WithMany()
                        .HasForeignKey("FuelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Motorcenter.Data.Entities.Vehicle", null)
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Motorcenter.Data.Entities.VehicleTypeFilter", b =>
                {
                    b.HasOne("Motorcenter.Data.Entities.Filter", null)
                        .WithMany()
                        .HasForeignKey("FilterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Motorcenter.Data.Entities.VehicleType", null)
                        .WithMany()
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Motorcenter.Data.Entities.VehicleTypeVehicle", b =>
                {
                    b.HasOne("Motorcenter.Data.Entities.Vehicle", null)
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Motorcenter.Data.Entities.VehicleType", null)
                        .WithMany()
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Motorcenter.Data.Entities.Brand", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Motorcenter.Data.Entities.Mileage", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Motorcenter.Data.Entities.Year", b =>
                {
                    b.Navigation("Vehicles")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
