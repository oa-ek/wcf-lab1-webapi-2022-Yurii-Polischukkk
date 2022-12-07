﻿// <auto-generated />
using System;
using KeysShop.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KeysShop.Core.Migrations
{
    [DbContext(typeof(KeysShopContext))]
    partial class KeysShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KeysShop.Core.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("KeysShop.Core.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KeyId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("KeyId");

                    b.HasIndex("UserId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("KeysShop.Core.Key", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Count")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Frequency")
                        .HasColumnType("int");

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsKeyless")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOriginal")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<double?>("Sale")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Keys");
                });

            modelBuilder.Entity("KeysShop.Core.User", b =>
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

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasData(
                        new
                        {
                            Id = "48f2cf34-44e0-4b57-bb08-39a5f0199183",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b1818358-34ee-4c2f-b489-0981baac8adf",
                            Email = "manager@keysshop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER@KEYSSHOP.COM",
                            NormalizedUserName = "MANAGER@KEYSSHOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEC2in53DW48WJ5TrBQVvOfDlQyptfiedKJHhUakchAZryztbK/C/ZJhGiWL5knMuoQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "26ce5496-783f-49e6-9f1d-ac0cffeaabec",
                            TwoFactorEnabled = false,
                            UserName = "manager@keysshop.com"
                        },
                        new
                        {
                            Id = "af666120-c6a6-4ff3-bd71-c41cd84cd8aa",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dade217a-d30b-4c19-b2bb-b0de64c5c672",
                            Email = "customer@keysshop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "CUSTOMER@KEYSSHOP.COM",
                            NormalizedUserName = "CUSTOMER@KEYSSHOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMDTqUe3vVHzyhfRriAu/2KsBjvW/DqppfQ9Kkd1JOdbpeRbWs2XG/wUagOwRe8MLw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e902096e-8ffd-4389-8953-ad7f01ed5745",
                            TwoFactorEnabled = false,
                            UserName = "customer@keysshop.com"
                        },
                        new
                        {
                            Id = "52b17208-28fd-4b7c-812f-be6fb3b1f12a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c84ad469-6261-4fa5-a1ff-fa308a86f3ed",
                            Email = "admin@keysshop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@KEYSSHOP.COM",
                            NormalizedUserName = "ADMIN@KEYSSHOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHb1TSUlJ7oVLNEMUn6Jdbl1g8R0xNKxKsogjMlMoevanJd+mBBIzgwaLLQhwYsnig==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1884dad4-a893-4701-91d2-103d0b2c426a",
                            TwoFactorEnabled = false,
                            UserName = "admin@keysshop.com"
                        },
                        new
                        {
                            Id = "8f76fb95-4b9d-4268-a38b-9ababb0d0f49",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "76791673-71b9-48e9-9a03-2134b83655b8",
                            Email = "consultant@keysshop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "CONSULTANT@KEYSSHOP.COM",
                            NormalizedUserName = "CONSULTANT@KEYSSHOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFpxJxSIofKY+BAteQRD5rOdd42uZ7yq2g12NZjn1nc3l6ba0Wxuj/PLcPTI4aQmMQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "36b0afc2-f204-4c7d-8ce2-7834c25ffc4e",
                            TwoFactorEnabled = false,
                            UserName = "consultant@keysshop.com"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = "46121cf9-f89f-4281-818a-a71fa24025ed",
                            ConcurrencyStamp = "590360ac-93d1-4a5d-9a7f-306343df5d84",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "f31dd0ea-35f4-4249-ad3d-b324b4b84716",
                            ConcurrencyStamp = "19a0f3d1-af8f-44f0-9352-eb6449699ee3",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "cd455617-7a76-4fa4-b756-e2f27665db3e",
                            ConcurrencyStamp = "89343623-0a99-4bf2-9e7b-de6572769ef0",
                            Name = "Consultant",
                            NormalizedName = "CONSULTANT"
                        },
                        new
                        {
                            Id = "492fa3ab-c89c-4b84-8b95-a66a454211dd",
                            ConcurrencyStamp = "41abcb92-eb0d-4ac7-a1a0-14104d9109d0",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
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

                    b.HasData(
                        new
                        {
                            UserId = "52b17208-28fd-4b7c-812f-be6fb3b1f12a",
                            RoleId = "46121cf9-f89f-4281-818a-a71fa24025ed"
                        },
                        new
                        {
                            UserId = "52b17208-28fd-4b7c-812f-be6fb3b1f12a",
                            RoleId = "f31dd0ea-35f4-4249-ad3d-b324b4b84716"
                        },
                        new
                        {
                            UserId = "52b17208-28fd-4b7c-812f-be6fb3b1f12a",
                            RoleId = "492fa3ab-c89c-4b84-8b95-a66a454211dd"
                        },
                        new
                        {
                            UserId = "52b17208-28fd-4b7c-812f-be6fb3b1f12a",
                            RoleId = "cd455617-7a76-4fa4-b756-e2f27665db3e"
                        },
                        new
                        {
                            UserId = "48f2cf34-44e0-4b57-bb08-39a5f0199183",
                            RoleId = "f31dd0ea-35f4-4249-ad3d-b324b4b84716"
                        },
                        new
                        {
                            UserId = "48f2cf34-44e0-4b57-bb08-39a5f0199183",
                            RoleId = "492fa3ab-c89c-4b84-8b95-a66a454211dd"
                        },
                        new
                        {
                            UserId = "af666120-c6a6-4ff3-bd71-c41cd84cd8aa",
                            RoleId = "492fa3ab-c89c-4b84-8b95-a66a454211dd"
                        },
                        new
                        {
                            UserId = "8f76fb95-4b9d-4268-a38b-9ababb0d0f49",
                            RoleId = "492fa3ab-c89c-4b84-8b95-a66a454211dd"
                        },
                        new
                        {
                            UserId = "8f76fb95-4b9d-4268-a38b-9ababb0d0f49",
                            RoleId = "cd455617-7a76-4fa4-b756-e2f27665db3e"
                        });
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

            modelBuilder.Entity("KeysShop.Core.Feedback", b =>
                {
                    b.HasOne("KeysShop.Core.Key", null)
                        .WithMany("feedbacks")
                        .HasForeignKey("KeyId");

                    b.HasOne("KeysShop.Core.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("KeysShop.Core.Key", b =>
                {
                    b.HasOne("KeysShop.Core.Brand", "Brand")
                        .WithMany("Keys")
                        .HasForeignKey("BrandId");

                    b.Navigation("Brand");
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
                    b.HasOne("KeysShop.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("KeysShop.Core.User", null)
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

                    b.HasOne("KeysShop.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("KeysShop.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KeysShop.Core.Brand", b =>
                {
                    b.Navigation("Keys");
                });

            modelBuilder.Entity("KeysShop.Core.Key", b =>
                {
                    b.Navigation("feedbacks");
                });
#pragma warning restore 612, 618
        }
    }
}
