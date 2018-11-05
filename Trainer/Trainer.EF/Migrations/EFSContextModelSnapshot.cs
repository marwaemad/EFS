﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trainer.EF;

namespace Trainer.EF.Migrations
{
    [DbContext(typeof(EFSContext))]
    partial class EFSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shared.Core.Models.Articles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorId")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("ProfilePicture")
                        .IsRequired();

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Shared.Core.Models.ArticlesCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ProfilePicture")
                        .IsRequired();

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("Articles_Categories");
                });

            modelBuilder.Entity("Shared.Core.Models.AspNetRoles", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new { Id = "1d2b6cf6-8e86-46e9-9df2-2cdfc8f906f3", Name = "Admin" },
                        new { Id = "3ea04402-1b6a-4239-bde4-ef514521d7b8", Name = "Client" },
                        new { Id = "24375a82-6a48-4dc5-98cc-ffc4d9930e92", Name = "ProductOwner" },
                        new { Id = "36414a7f-ef7f-485e-9ccb-ea884193b06e", Name = "RegularUser" },
                        new { Id = "e1b95863-759a-434e-b9dc-2f3bd70e343b", Name = "Trainer" }
                    );
                });

            modelBuilder.Entity("Shared.Core.Models.AspNetUserClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Shared.Core.Models.AspNetUserLogins", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("UserId")
                        .HasMaxLength(128);

                    b.HasKey("LoginProvider", "ProviderKey", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Shared.Core.Models.AspNetUserRoles", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(128);

                    b.Property<string>("RoleId")
                        .HasMaxLength(128);

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Shared.Core.Models.AspNetUsers", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(128);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Hometown");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTime?>("LockoutEndDateUtc")
                        .HasColumnType("datetime");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ProfilePicture");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new { Id = "7c654344-ad42-4428-a77a-00a8c1299c3f", AccessFailedCount = 0, Email = "ahmedkabbash@gmail.com", EmailConfirmed = true, FirstName = "ahmed", LastName = "kabbash", LockoutEnabled = false, PasswordHash = "1234", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "Admin" }
                    );
                });

            modelBuilder.Entity("Shared.Core.Models.Calories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(128);

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Calories");
                });

            modelBuilder.Entity("Shared.Core.Models.Championships", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Place")
                        .IsRequired();

                    b.Property<string>("ProfilePicture")
                        .IsRequired();

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("Championships");
                });

            modelBuilder.Entity("Shared.Core.Models.Clients", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Shared.Core.Models.ClientsDocuments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnName("ClientID")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Path")
                        .IsRequired();

                    b.Property<bool>("SentToClient");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Clients_Documents");
                });

            modelBuilder.Entity("Shared.Core.Models.ClientsImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Path")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Clients_Images");
                });

            modelBuilder.Entity("Shared.Core.Models.ClientsMeasurments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<byte>("TypeId");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(128);

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(8, 2)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Clients_Measurments");
                });

            modelBuilder.Entity("Shared.Core.Models.ClientsOverloads", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<byte>("TypeId");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(128);

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(8, 2)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Clients_Overloads");
                });

            modelBuilder.Entity("Shared.Core.Models.Measurments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<byte>("TypeId");

                    b.HasKey("Id");

                    b.ToTable("Measurments");
                });

            modelBuilder.Entity("Shared.Core.Models.MigrationHistory", b =>
                {
                    b.Property<string>("MigrationId")
                        .HasMaxLength(150);

                    b.Property<string>("ContextKey")
                        .HasMaxLength(300);

                    b.Property<byte[]>("Model")
                        .IsRequired();

                    b.Property<string>("ProductVersion")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("MigrationId", "ContextKey");

                    b.ToTable("__MigrationHistory");
                });

            modelBuilder.Entity("Shared.Core.Models.Overloads", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<byte>("TypeId");

                    b.HasKey("Id");

                    b.ToTable("Overloads");
                });

            modelBuilder.Entity("Shared.Core.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Description");

                    b.Property<DateTime?>("ExpDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<DateTime?>("ProdDate")
                        .HasColumnType("date");

                    b.Property<string>("ProfilePicture")
                        .IsRequired();

                    b.Property<decimal>("Rate");

                    b.Property<int>("SubcategoryId");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("SubcategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Shared.Core.Models.ProductsCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ProfilePicture");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("Products_Categories");
                });

            modelBuilder.Entity("Shared.Core.Models.ProductsImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Path")
                        .IsRequired();

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Products_Images");
                });

            modelBuilder.Entity("Shared.Core.Models.ProductsOwners", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(128);

                    b.Property<string>("ContactInfo")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Products_Owners");
                });

            modelBuilder.Entity("Shared.Core.Models.ProductsRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<int>("ProductId");

                    b.Property<int>("Rate");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductsRatings");
                });

            modelBuilder.Entity("Shared.Core.Models.ProductsSubcategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ProfilePicture");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products_Subcategories");
                });

            modelBuilder.Entity("Shared.Core.Models.ProgramsImages", b =>
                {
                    b.Property<int>("Id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Path")
                        .IsRequired();

                    b.Property<int>("ProgramId");

                    b.HasKey("Id");

                    b.HasIndex("ProgramId");

                    b.ToTable("Programs_Images");
                });

            modelBuilder.Entity("Shared.Core.Models.ProgramsPrices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("ProgramId");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("ProgramId");

                    b.ToTable("Programs_Prices");
                });

            modelBuilder.Entity("Shared.Core.Models.Trainers", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(128);

                    b.Property<string>("Bio")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("Shared.Core.Models.TrainersPrograms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("ProfilePicture")
                        .IsRequired();

                    b.Property<string>("TrainerId")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("TrainerId");

                    b.ToTable("Trainers_Programs");
                });

            modelBuilder.Entity("Shared.Core.Models.Articles", b =>
                {
                    b.HasOne("Shared.Core.Models.AspNetUsers", "Author")
                        .WithMany("Articles")
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("FK_Articles_AspNetUsers");

                    b.HasOne("Shared.Core.Models.ArticlesCategories", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Articles_Articles_Categories");
                });

            modelBuilder.Entity("Shared.Core.Models.AspNetUserClaims", b =>
                {
                    b.HasOne("Shared.Core.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shared.Core.Models.AspNetUserLogins", b =>
                {
                    b.HasOne("Shared.Core.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shared.Core.Models.AspNetUserRoles", b =>
                {
                    b.HasOne("Shared.Core.Models.AspNetRoles", "Role")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Shared.Core.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shared.Core.Models.Clients", b =>
                {
                    b.HasOne("Shared.Core.Models.AspNetUsers", "IdNavigation")
                        .WithOne("Clients")
                        .HasForeignKey("Shared.Core.Models.Clients", "Id")
                        .HasConstraintName("FK_Clients_dbo.AspNetUsers")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shared.Core.Models.ClientsDocuments", b =>
                {
                    b.HasOne("Shared.Core.Models.Clients", "Client")
                        .WithMany("ClientsDocuments")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("FK_Clients_Documents_Clients");
                });

            modelBuilder.Entity("Shared.Core.Models.ClientsImages", b =>
                {
                    b.HasOne("Shared.Core.Models.Clients", "Client")
                        .WithMany("ClientsImages")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("FK_Clients_Images_Clients");
                });

            modelBuilder.Entity("Shared.Core.Models.ClientsMeasurments", b =>
                {
                    b.HasOne("Shared.Core.Models.Clients", "Client")
                        .WithMany("ClientsMeasurments")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("FK_Clients_Measurments_Clients");
                });

            modelBuilder.Entity("Shared.Core.Models.ClientsOverloads", b =>
                {
                    b.HasOne("Shared.Core.Models.Clients", "Client")
                        .WithMany("ClientsOverloads")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("FK_Clients_Overloads_Clients");
                });

            modelBuilder.Entity("Shared.Core.Models.Products", b =>
                {
                    b.HasOne("Shared.Core.Models.ProductsOwners", "Owner")
                        .WithMany("Products")
                        .HasForeignKey("OwnerId")
                        .HasConstraintName("FK_Products_Products_Owners");

                    b.HasOne("Shared.Core.Models.ProductsSubcategories", "Subcategory")
                        .WithMany("Products")
                        .HasForeignKey("SubcategoryId")
                        .HasConstraintName("FK_Products_Products_Subcategories");
                });

            modelBuilder.Entity("Shared.Core.Models.ProductsImages", b =>
                {
                    b.HasOne("Shared.Core.Models.Products", "Product")
                        .WithMany("ProductsImages")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Products_Images_Products");
                });

            modelBuilder.Entity("Shared.Core.Models.ProductsOwners", b =>
                {
                    b.HasOne("Shared.Core.Models.AspNetUsers", "IdNavigation")
                        .WithOne("ProductsOwners")
                        .HasForeignKey("Shared.Core.Models.ProductsOwners", "Id")
                        .HasConstraintName("FK_Products_Owners_dbo.AspNetUsers")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shared.Core.Models.ProductsRating", b =>
                {
                    b.HasOne("Shared.Core.Models.Products", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shared.Core.Models.ProductsSubcategories", b =>
                {
                    b.HasOne("Shared.Core.Models.ProductsCategories", "Category")
                        .WithMany("ProductsSubcategories")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Products_Subcategories_Products_Categories");
                });

            modelBuilder.Entity("Shared.Core.Models.ProgramsImages", b =>
                {
                    b.HasOne("Shared.Core.Models.TrainersPrograms", "Program")
                        .WithMany("ProgramsImages")
                        .HasForeignKey("ProgramId")
                        .HasConstraintName("FK_Programs_Images_Trainers_Programs");
                });

            modelBuilder.Entity("Shared.Core.Models.ProgramsPrices", b =>
                {
                    b.HasOne("Shared.Core.Models.TrainersPrograms", "Program")
                        .WithMany("ProgramsPrices")
                        .HasForeignKey("ProgramId")
                        .HasConstraintName("FK_Programs_Prices_Trainers_Programs");
                });

            modelBuilder.Entity("Shared.Core.Models.Trainers", b =>
                {
                    b.HasOne("Shared.Core.Models.AspNetUsers", "IdNavigation")
                        .WithOne("Trainers")
                        .HasForeignKey("Shared.Core.Models.Trainers", "Id")
                        .HasConstraintName("FK_Trainers_dbo_AspNetUsers")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shared.Core.Models.TrainersPrograms", b =>
                {
                    b.HasOne("Shared.Core.Models.Trainers", "Trainer")
                        .WithMany("TrainersPrograms")
                        .HasForeignKey("TrainerId")
                        .HasConstraintName("FK_Trainers_Programs_Trainers");
                });
#pragma warning restore 612, 618
        }
    }
}
