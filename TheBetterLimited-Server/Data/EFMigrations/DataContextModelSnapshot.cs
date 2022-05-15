﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheBetterLimited_Server.Data;

#nullable disable

namespace TheBetterLimited_Server.Data.EFMigrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TheBetterLimited_Server.Data.Entity.Account", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(5)
                        .HasColumnType("char(5)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("LoginFailedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("LoginFailedCount")
                        .HasColumnType("int(1)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Remarks")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("char(1)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("char(10)");

                    b.Property<string>("_StaffId")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("char(5)");

                    b.Property<DateTime?>("unlockDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("_StaffId");

                    b.ToTable("accounts");
                });

            modelBuilder.Entity("TheBetterLimited_Server.Data.Entity.Department", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(3)
                        .HasColumnType("char(3)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("TheBetterLimited_Server.Data.Entity.Menu", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(3)
                        .HasColumnType("char(3)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("menus");
                });

            modelBuilder.Entity("TheBetterLimited_Server.Data.Entity.Permission", b =>
                {
                    b.Property<string>("_menuId")
                        .HasMaxLength(3)
                        .HasColumnType("char(3)");

                    b.Property<string>("_positionId")
                        .HasMaxLength(3)
                        .HasColumnType("char(3)");

                    b.Property<bool?>("delete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("read")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("write")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("_menuId", "_positionId");

                    b.HasIndex("_positionId");

                    b.ToTable("permissions");
                });

            modelBuilder.Entity("TheBetterLimited_Server.Data.Entity.Position", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(3)
                        .HasColumnType("char(3)");

                    b.Property<string>("_departmentId")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("char(3)");

                    b.Property<string>("jobTitle")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("_departmentId");

                    b.ToTable("positions");
                });

            modelBuilder.Entity("TheBetterLimited_Server.Data.Entity.Staff", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(5)
                        .HasColumnType("char(5)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("_AccountId")
                        .HasMaxLength(5)
                        .HasColumnType("char(5)");

                    b.Property<string>("_departmentId")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("char(3)");

                    b.Property<string>("_positionId")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("char(3)");

                    b.Property<int?>("age")
                        .HasColumnType("integer(2)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("phone")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("sex")
                        .HasColumnType("char(1)");

                    b.HasKey("Id");

                    b.HasIndex("_AccountId");

                    b.HasIndex("_departmentId");

                    b.HasIndex("_positionId");

                    b.ToTable("staffs");
                });

            modelBuilder.Entity("TheBetterLimited_Server.Data.Entity.Account", b =>
                {
                    b.HasOne("TheBetterLimited_Server.Data.Entity.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("_StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("TheBetterLimited_Server.Data.Entity.Permission", b =>
                {
                    b.HasOne("TheBetterLimited_Server.Data.Entity.Menu", "menu")
                        .WithMany("permissions")
                        .HasForeignKey("_menuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheBetterLimited_Server.Data.Entity.Position", "position")
                        .WithMany("permissions")
                        .HasForeignKey("_positionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("menu");

                    b.Navigation("position");
                });

            modelBuilder.Entity("TheBetterLimited_Server.Data.Entity.Position", b =>
                {
                    b.HasOne("TheBetterLimited_Server.Data.Entity.Department", "department")
                        .WithMany()
                        .HasForeignKey("_departmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("department");
                });

            modelBuilder.Entity("TheBetterLimited_Server.Data.Entity.Staff", b =>
                {
                    b.HasOne("TheBetterLimited_Server.Data.Entity.Account", "acc")
                        .WithMany()
                        .HasForeignKey("_AccountId");

                    b.HasOne("TheBetterLimited_Server.Data.Entity.Department", "department")
                        .WithMany("staffs")
                        .HasForeignKey("_departmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheBetterLimited_Server.Data.Entity.Position", "position")
                        .WithMany()
                        .HasForeignKey("_positionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("acc");

                    b.Navigation("department");

                    b.Navigation("position");
                });

            modelBuilder.Entity("TheBetterLimited_Server.Data.Entity.Department", b =>
                {
                    b.Navigation("staffs");
                });

            modelBuilder.Entity("TheBetterLimited_Server.Data.Entity.Menu", b =>
                {
                    b.Navigation("permissions");
                });

            modelBuilder.Entity("TheBetterLimited_Server.Data.Entity.Position", b =>
                {
                    b.Navigation("permissions");
                });
#pragma warning restore 612, 618
        }
    }
}
