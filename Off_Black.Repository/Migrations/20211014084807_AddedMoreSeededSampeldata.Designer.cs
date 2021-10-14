﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Off_Black.DB;

namespace Off_Black.Migrations
{
    [DbContext(typeof(OffBlackContext))]
    [Migration("20211014084807_AddedMoreSeededSampeldata")]
    partial class AddedMoreSeededSampeldata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Off_Black.Repository.Entities.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Catagories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            Name = "Sweaaters And Hoodies"
                        },
                        new
                        {
                            CategoryID = 2,
                            Name = "Pants And Sweatpants"
                        },
                        new
                        {
                            CategoryID = 3,
                            Name = "T-shirts"
                        },
                        new
                        {
                            CategoryID = 4,
                            Name = "Jackets"
                        });
                });

            modelBuilder.Entity("Off_Black.Repository.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FK_UserID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.HasIndex("FK_UserID")
                        .IsUnique()
                        .HasFilter("[FK_UserID] IS NOT NULL");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = 1,
                            Adress = "Test 1",
                            Email = "Test1@test.com",
                            FK_UserID = 1,
                            FirstName = "Peter",
                            LastName = "Hymøller",
                            PhoneNumber = "29045781",
                            ZipCode = "6400"
                        },
                        new
                        {
                            CustomerID = 2,
                            Adress = "Test 2",
                            Email = "Test2@test.com",
                            FirstName = "Casper",
                            LastName = "Koch",
                            PhoneNumber = "29045782",
                            ZipCode = "6400"
                        },
                        new
                        {
                            CustomerID = 3,
                            Adress = "Test 3",
                            Email = "Test3@test.com",
                            FK_UserID = 2,
                            FirstName = "Nickolai",
                            LastName = "Heuck",
                            PhoneNumber = "29045783",
                            ZipCode = "6400"
                        },
                        new
                        {
                            CustomerID = 4,
                            Adress = "Test 4",
                            Email = "Test4@test.com",
                            FirstName = "Jan",
                            LastName = "Andersen",
                            PhoneNumber = "29045784",
                            ZipCode = "6400"
                        });
                });

            modelBuilder.Entity("Off_Black.Repository.Entities.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FK_CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("FK_CustomerID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Off_Black.Repository.Entities.OrderItem", b =>
                {
                    b.Property<int>("OrderItmeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("FK_OrderID")
                        .HasColumnType("int");

                    b.Property<int>("FK_ProductID")
                        .HasColumnType("int");

                    b.HasKey("OrderItmeID");

                    b.HasIndex("FK_OrderID");

                    b.HasIndex("FK_ProductID");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Off_Black.Repository.Entities.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("FK_CategoryID")
                        .HasColumnType("int");

                    b.Property<bool>("ManWoman")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductID");

                    b.HasIndex("FK_CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            Amount = 21,
                            FK_CategoryID = 1,
                            ManWoman = false,
                            Price = 3832.00m,
                            ProductDescription = "Long sleeves oversized hooded sweatshirt in black featuring Off logo on the front. Caravaggio arrows printed on the back. Crewneck collar. Rib knit collar, cuffs and hem. Kangaroo pocket.",
                            ProductImagePath = "~/Img/Men-Caravaggio-Hoodie.png",
                            ProductName = "Caravaggio Arrows Hoodie"
                        },
                        new
                        {
                            ProductID = 2,
                            Amount = 50,
                            FK_CategoryID = 3,
                            ManWoman = false,
                            Price = 2316.00m,
                            ProductDescription = "Short sleeves T-shirt in black featuring Caravaggio painting on the front. Crewneck collar. Slim fit.",
                            ProductImagePath = "~/Img/Men-Caravaggio-tshirt.png",
                            ProductName = "Caravaggio Painting S/S T-Shirt"
                        },
                        new
                        {
                            ProductID = 3,
                            Amount = 12,
                            FK_CategoryID = 2,
                            ManWoman = false,
                            Price = 7073.00m,
                            ProductDescription = "Straight leg formal pants in black. Logo patch sewn at front. Pockets at back. Button closure. Zip-fly. Four-pocket styling.",
                            ProductImagePath = "~/Img/Men-Formal-pants.jpg",
                            ProductName = "Formal Pants"
                        },
                        new
                        {
                            ProductID = 4,
                            Amount = 26,
                            FK_CategoryID = 4,
                            ManWoman = false,
                            Price = 13430.00m,
                            ProductDescription = "Hybrid padded leather shirt in black featuring metallic swimming logo at chest and knitted sleeves. Rib knit collar cuffs and hem.",
                            ProductImagePath = "~/Img/Men-Padded-leather-shirt.png",
                            ProductName = "Padded Leather Shirt"
                        },
                        new
                        {
                            ProductID = 5,
                            Amount = 25,
                            FK_CategoryID = 1,
                            ManWoman = true,
                            Price = 5052.00m,
                            ProductDescription = "Long sleeves hooded sweatshirt with sprayed multicolor pattern allover. Elasticized hem and cuffs. Black strings.",
                            ProductImagePath = "~/Img/Woman-Offkat-Allover-Spay-Hoodie.png",
                            ProductName = "Offkat Allover Spray Hoodie"
                        },
                        new
                        {
                            ProductID = 6,
                            Amount = 40,
                            FK_CategoryID = 3,
                            ManWoman = true,
                            Price = 2231.00m,
                            ProductDescription = "Sleeveless bodysuit in black with OFF printed in white at chest.",
                            ProductImagePath = "~/Img/Woman-Ribbed-Bodysuit.png",
                            ProductName = "Ribbed Bodysuit"
                        },
                        new
                        {
                            ProductID = 7,
                            Amount = 30,
                            FK_CategoryID = 2,
                            ManWoman = true,
                            Price = 8715.00m,
                            ProductDescription = "Formal pant with multicolor pattern allover. Pockets at front and back. Zip fly. Belt loops.",
                            ProductImagePath = "~/Img/Woman-Offkat-cady-Pants.png",
                            ProductName = "Offkat Cady Pants"
                        },
                        new
                        {
                            ProductID = 8,
                            Amount = 28,
                            FK_CategoryID = 4,
                            ManWoman = true,
                            Price = 15704.00m,
                            ProductDescription = "Tomboy jacket in multicolor pattern allover. Pockets at front. Breast pocket. Buttons closure",
                            ProductImagePath = "~/Img/Woman-Offkat-tomboy-jacket.png",
                            ProductName = "Offkat Tomboy Jacket"
                        });
                });

            modelBuilder.Entity("Off_Black.Repository.Entities.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FK_CustomerID")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            FK_CustomerID = 1
                        },
                        new
                        {
                            UserID = 2,
                            FK_CustomerID = 3
                        });
                });

            modelBuilder.Entity("Off_Black.Repository.Entities.Customer", b =>
                {
                    b.HasOne("Off_Black.Repository.Entities.User", "User")
                        .WithOne("Customer")
                        .HasForeignKey("Off_Black.Repository.Entities.Customer", "FK_UserID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Off_Black.Repository.Entities.Order", b =>
                {
                    b.HasOne("Off_Black.Repository.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("FK_CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Off_Black.Repository.Entities.OrderItem", b =>
                {
                    b.HasOne("Off_Black.Repository.Entities.Order", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("FK_OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Off_Black.Repository.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("FK_ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Off_Black.Repository.Entities.Product", b =>
                {
                    b.HasOne("Off_Black.Repository.Entities.Category", "Catagory")
                        .WithMany("Products")
                        .HasForeignKey("FK_CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Catagory");
                });

            modelBuilder.Entity("Off_Black.Repository.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Off_Black.Repository.Entities.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Off_Black.Repository.Entities.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Off_Black.Repository.Entities.User", b =>
                {
                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
