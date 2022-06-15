﻿// <auto-generated />
using System;
using DatabaseMVC.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseMVC.Infrastructure.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220612150354_AddContractorActiveCase")]
    partial class AddContractorActiveCase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DatabaseMVC.Domain.Model.ContactPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactPersons");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Contractor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("FirstContactPersonId")
                        .HasColumnType("int");

                    b.Property<bool>("HasActiveCase")
                        .HasColumnType("bit");

                    b.Property<int>("HeadquaterId")
                        .HasColumnType("int");

                    b.Property<int?>("SecondaryContactPersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("FirstContactPersonId");

                    b.HasIndex("HeadquaterId");

                    b.HasIndex("SecondaryContactPersonId");

                    b.ToTable("Contractors");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DepartmentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBroken")
                        .HasColumnType("bit");

                    b.Property<bool>("IsInUse")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTakenOutOfState")
                        .HasColumnType("bit");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Devices");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Device");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Headquater", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Headquaters");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Kit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateOfDisassemblyKit")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfSubmissionKit")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.HasIndex("OrderId");

                    b.ToTable("Kits");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Manufacture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufactures");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CaseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContractorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DisassemblyDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("EndApplicationDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("InstallationDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsBattery")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPosibility")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("NextExchangeBattery")
                        .HasColumnType("date");

                    b.Property<DateTime>("ReceivedApplicationDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("RecognizeDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("ContractorId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.SIMCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("IP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsLimitOnInternet")
                        .HasColumnType("bit");

                    b.Property<short?>("LimitGB")
                        .HasColumnType("smallint");

                    b.Property<int>("MSISDN")
                        .HasColumnType("int");

                    b.Property<string>("NumberOnSIMCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("PIN")
                        .HasColumnType("smallint");

                    b.Property<int>("PUK")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SIMCards");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Storage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("InternalDepartmentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManufactureId")
                        .HasColumnType("int");

                    b.Property<int>("TypeOfStorageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ManufactureId");

                    b.HasIndex("TypeOfStorageId");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.TypeOfStorage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeOfStorages");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.CameraDevice", b =>
                {
                    b.HasBaseType("DatabaseMVC.Domain.Model.Device");

                    b.Property<int?>("StorageCamId")
                        .HasColumnType("int");

                    b.Property<string>("TechSpecification")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("StorageCamId");

                    b.HasDiscriminator().HasValue("CameraDevice");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.RecorderDevice", b =>
                {
                    b.HasBaseType("DatabaseMVC.Domain.Model.Device");

                    b.Property<int?>("StorageRecId")
                        .HasColumnType("int");

                    b.HasIndex("StorageRecId");

                    b.HasDiscriminator().HasValue("RecorderDevice");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.RouterDevice", b =>
                {
                    b.HasBaseType("DatabaseMVC.Domain.Model.Device");

                    b.Property<int?>("SIMCardId")
                        .HasColumnType("int");

                    b.HasIndex("SIMCardId");

                    b.HasDiscriminator().HasValue("RouterDevice");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Contractor", b =>
                {
                    b.HasOne("DatabaseMVC.Domain.Model.Department", "Department")
                        .WithMany("Contractors")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DatabaseMVC.Domain.Model.ContactPerson", "FirstContactPerson")
                        .WithMany("FirstContractor")
                        .HasForeignKey("FirstContactPersonId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DatabaseMVC.Domain.Model.Headquater", "Headquater")
                        .WithMany("Contractors")
                        .HasForeignKey("HeadquaterId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DatabaseMVC.Domain.Model.ContactPerson", "SecondaryContactPerson")
                        .WithMany("SecondContractor")
                        .HasForeignKey("SecondaryContactPersonId");

                    b.Navigation("Department");

                    b.Navigation("FirstContactPerson");

                    b.Navigation("Headquater");

                    b.Navigation("SecondaryContactPerson");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Device", b =>
                {
                    b.HasOne("DatabaseMVC.Domain.Model.Manufacture", "Manufacture")
                        .WithMany("Devices")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Manufacture");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Kit", b =>
                {
                    b.HasOne("DatabaseMVC.Domain.Model.Device", "Device")
                        .WithMany("Kits")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DatabaseMVC.Domain.Model.Order", "Order")
                        .WithMany("Kits")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Order", b =>
                {
                    b.HasOne("DatabaseMVC.Domain.Model.Contractor", "Contractor")
                        .WithMany("Orders")
                        .HasForeignKey("ContractorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Contractor");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Storage", b =>
                {
                    b.HasOne("DatabaseMVC.Domain.Model.Manufacture", "Manufacture")
                        .WithMany("Storages")
                        .HasForeignKey("ManufactureId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DatabaseMVC.Domain.Model.TypeOfStorage", "TypeOfStorage")
                        .WithMany("Storages")
                        .HasForeignKey("TypeOfStorageId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Manufacture");

                    b.Navigation("TypeOfStorage");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.CameraDevice", b =>
                {
                    b.HasOne("DatabaseMVC.Domain.Model.Storage", "Storage")
                        .WithMany("CameraDevices")
                        .HasForeignKey("StorageCamId");

                    b.Navigation("Storage");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.RecorderDevice", b =>
                {
                    b.HasOne("DatabaseMVC.Domain.Model.Storage", "Storage")
                        .WithMany("RecorderDevices")
                        .HasForeignKey("StorageRecId");

                    b.Navigation("Storage");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.RouterDevice", b =>
                {
                    b.HasOne("DatabaseMVC.Domain.Model.SIMCard", "SIMCard")
                        .WithMany("RouterDevices")
                        .HasForeignKey("SIMCardId");

                    b.Navigation("SIMCard");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.ContactPerson", b =>
                {
                    b.Navigation("FirstContractor");

                    b.Navigation("SecondContractor");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Contractor", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Department", b =>
                {
                    b.Navigation("Contractors");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Device", b =>
                {
                    b.Navigation("Kits");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Headquater", b =>
                {
                    b.Navigation("Contractors");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Manufacture", b =>
                {
                    b.Navigation("Devices");

                    b.Navigation("Storages");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Order", b =>
                {
                    b.Navigation("Kits");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.SIMCard", b =>
                {
                    b.Navigation("RouterDevices");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.Storage", b =>
                {
                    b.Navigation("CameraDevices");

                    b.Navigation("RecorderDevices");
                });

            modelBuilder.Entity("DatabaseMVC.Domain.Model.TypeOfStorage", b =>
                {
                    b.Navigation("Storages");
                });
#pragma warning restore 612, 618
        }
    }
}
