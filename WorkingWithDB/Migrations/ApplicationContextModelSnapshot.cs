﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkingWithDB.DBContexts;

#nullable disable

namespace WorkingWithDB.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WorkingWithDB.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WorkingWithDB.Models.OrderProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("TeapotId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("TeapotId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("WorkingWithDB.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("OrderStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Waiting for accepting"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Accepted"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Canceled"
                        });
                });

            modelBuilder.Entity("WorkingWithDB.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "client"
                        });
                });

            modelBuilder.Entity("WorkingWithDB.Models.Teapot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Capacity")
                        .HasColumnType("float");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("Power")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProducingCountry")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Warranty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Teapots");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 2.2999999999999998,
                            Color = "Black",
                            Manufacturer = "Xiaomi",
                            Material = "Plastic + Metal",
                            Power = 2400,
                            Price = 2199.0,
                            ProducingCountry = "China",
                            Quantity = 10,
                            Title = "Teapot 1",
                            Warranty = 12
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 1.5,
                            Color = "Green",
                            Manufacturer = "Xiaomi",
                            Material = "Plastic",
                            Power = 1800,
                            Price = 1899.0,
                            ProducingCountry = "China",
                            Quantity = 5,
                            Title = "Teapot 2",
                            Warranty = 18
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 1.8,
                            Color = "White",
                            Manufacturer = "Tefal",
                            Material = "Plastic + Metal",
                            Power = 2400,
                            Price = 2199.0,
                            ProducingCountry = "China",
                            Quantity = 6,
                            Title = "Teapot 3",
                            Warranty = 24
                        });
                });

            modelBuilder.Entity("WorkingWithDB.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasCheckConstraint("Age", "Age >= 0 AND Age <= 110");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 20,
                            Email = "sashakucheryaev1@gmail.com",
                            FirstName = "Aleksandr",
                            Password = "qwerty123",
                            RoleId = 1,
                            SurName = "Kucheryaiev"
                        },
                        new
                        {
                            Id = 2,
                            Age = 19,
                            Email = "vladimirpetrov2001@gmail.com",
                            FirstName = "Vladimir",
                            Password = "Q_1_w_2_e_3_r_4_t_5_y",
                            RoleId = 2,
                            SurName = "Petrov"
                        },
                        new
                        {
                            Id = 3,
                            Age = 21,
                            Email = "suhomlinskaya132656@gmail.com",
                            FirstName = "Diana",
                            Password = "Suhom__D__132",
                            RoleId = 2,
                            SurName = "Suhomlinskaya"
                        });
                });

            modelBuilder.Entity("WorkingWithDB.Models.Order", b =>
                {
                    b.HasOne("WorkingWithDB.Models.OrderStatus", "OrderStatus")
                        .WithMany()
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorkingWithDB.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderStatus");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WorkingWithDB.Models.OrderProduct", b =>
                {
                    b.HasOne("WorkingWithDB.Models.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorkingWithDB.Models.Teapot", "Teapot")
                        .WithMany("OrderProducts")
                        .HasForeignKey("TeapotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Teapot");
                });

            modelBuilder.Entity("WorkingWithDB.Models.User", b =>
                {
                    b.HasOne("WorkingWithDB.Models.Role", null)
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WorkingWithDB.Models.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("WorkingWithDB.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("WorkingWithDB.Models.Teapot", b =>
                {
                    b.Navigation("OrderProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
