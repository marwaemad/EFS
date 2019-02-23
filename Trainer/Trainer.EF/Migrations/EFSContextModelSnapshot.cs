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

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTime?>("Date");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<bool?>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Place");

                    b.Property<string>("ProfilePicture")
                        .IsRequired();

                    b.Property<string>("RejectReason");

                    b.Property<string>("SubFolderName");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatedBy");

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

                    b.Property<int?>("PredefinedKey");

                    b.Property<string>("ProfilePicture")
                        .IsRequired();

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("Articles_Categories");

                    b.HasData(
                        new { Id = 1, CreatedAt = new DateTime(2019, 2, 23, 12, 40, 16, 348, DateTimeKind.Utc), CreatedBy = "admin", Name = "وصفات الطعام", PredefinedKey = 2, ProfilePicture = "Files/Articles%20Categories/food.png" },
                        new { Id = 2, CreatedAt = new DateTime(2019, 2, 23, 12, 40, 16, 352, DateTimeKind.Utc), CreatedBy = "admin", Name = "الأخبار", PredefinedKey = 1, ProfilePicture = "Files/Articles%20Categories/news.png" }
                    );
                });

            modelBuilder.Entity("Shared.Core.Models.ArticlesImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("ParentId");

                    b.Property<string>("Path")
                        .IsRequired();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("ArticlesImages");
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
                        new { Id = "b3c0d399-61f6-47e1-99eb-c545052992d6", Name = "Trainee" },
                        new { Id = "07ab2dd0-83e1-49a4-a8dc-66d948355392", Name = "Regular User" },
                        new { Id = "7c433dc0-d62b-43da-91d5-5b63e41a902f", Name = "Food Articles Writer" },
                        new { Id = "6a883f63-ef24-4693-a10f-ac30aaca972e", Name = "Articles Writer" }
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

                    b.HasData(
                        new { UserId = "7c654344-ad42-4428-a77a-00a8c1299c3f", RoleId = "1d2b6cf6-8e86-46e9-9df2-2cdfc8f906f3" }
                    );
                });

            modelBuilder.Entity("Shared.Core.Models.AspNetUsers", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(128);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Hometown");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTime?>("LockoutEndDateUtc")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

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
                        new { Id = "7c654344-ad42-4428-a77a-00a8c1299c3f", AccessFailedCount = 0, Email = "ahmedkabbash@gmail.com", EmailConfirmed = true, FullName = "ahmed kabbash", LockoutEnabled = false, PasswordHash = new byte[] { 218, 207, 69, 166, 235, 103, 82, 231, 5, 111, 112, 232, 203, 145, 25, 101, 212, 172, 189, 80, 43, 15, 217, 175, 219, 92, 124, 215, 188, 136, 30, 125, 126, 207, 104, 39, 142, 188, 226, 157, 92, 194, 164, 73, 83, 224, 113, 244, 112, 195, 144, 82, 149, 180, 116, 245, 242, 183, 247, 62, 32, 113, 150, 186 }, PasswordSalt = new byte[] { 172, 161, 120, 109, 175, 39, 49, 189, 229, 25, 155, 132, 44, 199, 46, 159, 254, 171, 123, 40, 135, 81, 15, 127, 153, 134, 150, 60, 127, 46, 81, 187, 213, 212, 12, 48, 180, 194, 242, 114, 6, 131, 161, 196, 165, 5, 179, 81, 135, 114, 11, 128, 78, 135, 139, 76, 163, 112, 151, 120, 240, 247, 168, 41, 53, 192, 53, 75, 105, 193, 192, 202, 122, 56, 193, 2, 183, 122, 106, 58, 69, 26, 162, 26, 143, 33, 92, 13, 34, 24, 17, 163, 166, 15, 94, 228, 217, 49, 20, 159, 189, 187, 225, 29, 221, 252, 78, 137, 60, 206, 145, 249, 135, 127, 179, 21, 62, 8, 49, 239, 213, 204, 83, 18, 43, 113, 208, 73 }, PhoneNumber = "01014991554", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "ahmedkabbash@gmail.com" }
                    );
                });

            modelBuilder.Entity("Shared.Core.Models.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ButtonText");

                    b.Property<string>("ButtonUrl");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("ImagePath")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Banners");
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

                    b.Property<string>("Path")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128);

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

            modelBuilder.Entity("Shared.Core.Models.EntityRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<int>("EntityId");

                    b.Property<int>("EntityTypeId");

                    b.Property<int?>("ItemsForReviewId");

                    b.Property<int>("Rate");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("ItemsForReviewId");

                    b.ToTable("EntityRatings");
                });

            modelBuilder.Entity("Shared.Core.Models.ItemsForReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("ProfilePicture");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("ItemsForReviews");
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

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Description");

                    b.Property<DateTime?>("ExpDate")
                        .HasColumnType("date");

                    b.Property<bool?>("IsActive");

                    b.Property<bool>("IsSpecial");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("ProfilePicture")
                        .IsRequired();

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("RejectReason");

                    b.Property<string>("SubFolderName");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatedBy");

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

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("ParentId");

                    b.Property<string>("ProfilePicture");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Products_Categories");
                });

            modelBuilder.Entity("Shared.Core.Models.ProductsImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ParentId");

                    b.Property<string>("Path")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Products_Images");
                });

            modelBuilder.Entity("Shared.Core.Models.ProgramsImages", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Description");

                    b.Property<int>("ParentId");

                    b.Property<string>("Path")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Programs_Images");
                });

            modelBuilder.Entity("Shared.Core.Models.ProgramsPrices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("ProgramId");

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
                    b.HasOne("Shared.Core.Models.ArticlesCategories", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Articles_Articles_Categories");

                    b.HasOne("Shared.Core.Models.AspNetUsers", "Author")
                        .WithMany("Articles")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shared.Core.Models.ArticlesImages", b =>
                {
                    b.HasOne("Shared.Core.Models.Articles", "Article")
                        .WithMany("Images")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade);
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

            modelBuilder.Entity("Shared.Core.Models.EntityRating", b =>
                {
                    b.HasOne("Shared.Core.Models.AspNetUsers", "Reviwer")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Shared.Core.Models.ItemsForReview")
                        .WithMany("Reviews")
                        .HasForeignKey("ItemsForReviewId");
                });

            modelBuilder.Entity("Shared.Core.Models.Products", b =>
                {
                    b.HasOne("Shared.Core.Models.ProductsCategories", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Products_Products_Subcategories")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Shared.Core.Models.AspNetUsers", "Seller")
                        .WithMany("Products")
                        .HasForeignKey("CreatedBy")
                        .HasConstraintName("FK_Products_AspNetUsers_CreatedBy");
                });

            modelBuilder.Entity("Shared.Core.Models.ProductsCategories", b =>
                {
                    b.HasOne("Shared.Core.Models.ProductsCategories")
                        .WithMany("Subcategories")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("Shared.Core.Models.ProductsImages", b =>
                {
                    b.HasOne("Shared.Core.Models.Products", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ParentId")
                        .HasConstraintName("FK_Products_Images_Products")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shared.Core.Models.ProgramsImages", b =>
                {
                    b.HasOne("Shared.Core.Models.TrainersPrograms", "Program")
                        .WithMany("ProgramsImages")
                        .HasForeignKey("ParentId")
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
