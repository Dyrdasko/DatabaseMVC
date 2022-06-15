using DatabaseMVC.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<ContactPerson> ContactPersons { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<RecorderDevice> RecorderDevices { get; set; }
        public DbSet<RouterDevice> RouterDevices { get; set; }
        public DbSet<CameraDevice> CameraDevices { get; set; }
        public DbSet<Headquater> Headquaters { get; set; }
        public DbSet<Kit> Kits { get; set; }
        public DbSet<Manufacture> Manufactures { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<SIMCard> SIMCards { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<TypeOfStorage> TypeOfStorages { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>(o =>
            {
                o.Property(d => d.ReceivedApplicationDate).HasColumnType("date");
                o.Property(d => d.RecognizeDate).HasColumnType("date");
                o.Property(d => d.InstallationDate).HasColumnType("date");
                o.Property(d => d.EndApplicationDate).HasColumnType("date");
                o.Property(d => d.DisassemblyDate).HasColumnType("date");
                o.Property(d => d.NextExchangeBattery).HasColumnType("date");
            });

            modelBuilder.Entity<Contractor>(cont =>
            {
                //cont.HasOne<ContactPerson>(pers => pers.SecondaryContactPerson)
                //.WithMany(cont => cont.SecondContractor)
                //.HasForeignKey(pers => pers.SecondaryContactPersonId)
                //.OnDelete(DeleteBehavior.NoAction)
                //.IsRequired(false);

                cont.HasOne<ContactPerson>(pers => pers.FirstContactPerson)
                .WithMany(cont => cont.FirstContractor)
                .HasForeignKey(pers => pers.FirstContactPersonId)
                .OnDelete(DeleteBehavior.NoAction);

                cont.HasOne<Department>(dep => dep.Department)
                .WithMany(cont => cont.Contractors)
                .HasForeignKey(dep => dep.DepartmentId)
                .OnDelete(DeleteBehavior.NoAction);

                cont.HasOne<Headquater>(head => head.Headquater)
                .WithMany(cont => cont.Contractors)
                .HasForeignKey(head => head.HeadquaterId)
                .OnDelete(DeleteBehavior.NoAction);

                cont.HasMany<Order>(order => order.Orders)
                .WithOne(cont => cont.Contractor)
                .HasForeignKey(order => order.ContractorId)
                .OnDelete(DeleteBehavior.NoAction);
            });

            //modelBuilder.Entity<Device>(d =>
            //{
            //    d.HasMany(k => k.Kits)
            //    .WithOne(u => u.CameraDevice)
            //    .HasForeignKey(u => u.CameraDeviceId);

            //    d.HasMany(k => k.Kits)
            //    .WithOne(u => u.RecorderDevice)
            //    .HasForeignKey(u => u.RecorderDeviceId);

            //    d.HasMany(k => k.Kits)
            //    .WithOne(u => u.RouterDevice)
            //    .HasForeignKey(u => u.RouterDeviceId);
            //});

            modelBuilder.Entity<Storage>(s =>
            {
                s.HasOne<TypeOfStorage>(tos => tos.TypeOfStorage)
                .WithMany(s => s.Storages)
                .HasForeignKey(tos => tos.TypeOfStorageId)
                .OnDelete(DeleteBehavior.NoAction);

                s.HasOne<Manufacture>(m => m.Manufacture)
                .WithMany(s => s.Storages)
                .HasForeignKey(m => m.ManufactureId)
                .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Device>(d =>
            {
                d.HasOne<Manufacture>(m => m.Manufacture)
                .WithMany(d => d.Devices)
                .HasForeignKey(m => m.ManufacturerId)
                .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<CameraDevice>(cd =>
            {
                cd.HasOne<Storage>(s => s.Storage)
                .WithMany(cd => cd.CameraDevices)
                .HasForeignKey(s => s.StorageCamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .IsRequired(false);
            });

            modelBuilder.Entity<RecorderDevice>(rd =>
            {
                rd.HasOne<Storage>(s => s.Storage)
                .WithMany(rd => rd.RecorderDevices)
                .HasForeignKey(s => s.StorageRecId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<RouterDevice>(rd =>
            {
                rd.HasOne<SIMCard>(s => s.SIMCard)
                .WithMany(rd => rd.RouterDevices)
                .HasForeignKey(s => s.SIMCardId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Kit>(k =>
            {
                k.HasOne<Device>(d => d.Device)
                .WithMany(k => k.Kits)
                .HasForeignKey(d => d.DeviceId)
                .OnDelete(DeleteBehavior.NoAction);

                k.HasOne<Order>(o => o.Order)
                .WithMany(k => k.Kits)
                .HasForeignKey(o => o.OrderId);
                //k.HasOne<Device>(d => d.RecorderDevice)
                //.WithMany(k => k.Kits)
                //.HasForeignKey(d => d.RecorderDeviceId);

                //k.HasOne<Device>(d => d.RouterDevice)
                //.WithMany(k => k.Kits)
                //.HasForeignKey(d => d.RouterDeviceId);

                //k.HasOne<Device>(d => d.CameraDevice)
                //.WithMany(k => k.Kits)
                //.HasForeignKey(d => d.CameraDeviceId);
            });
        }
    }
}
