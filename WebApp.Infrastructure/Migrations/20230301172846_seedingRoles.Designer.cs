﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Infrastructure.DBContexts;

#nullable disable

namespace WebApp.Infrastructure.Migrations
{
    [DbContext(typeof(WebAppDBContext))]
    [Migration("20230301172846_seedingRoles")]
    partial class seedingRoles
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", "auth");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", "auth");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", "auth");
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

                    b.UseTptMappingStrategy();

                    b.HasData(
                        new
                        {
                            UserId = "618fdfd2-f08b-413d-876a-04fec17f9e3f",
                            RoleId = "d0b1b383-e64c-4f42-b732-7ffbe8f3666b"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", "auth");
                });

            modelBuilder.Entity("WebApp.Core.Entities.Auth.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceTokenId")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsBasedEmail")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsFemale")
                        .HasColumnType("bit");

                    b.Property<bool>("IsInactive")
                        .HasColumnType("bit");

                    b.Property<string>("LastLang")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LocalPhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

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

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecondLocalPhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SecondPhoneNumber")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UserInsertDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserInsertId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime?>("UserUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserUpdateId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("UserInsertId");

                    b.HasIndex("UserUpdateId");

                    b.ToTable("Users", "auth");

                    b.HasData(
                        new
                        {
                            Id = "618fdfd2-f08b-413d-876a-04fec17f9e3f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "618fdfd2-f08b-413d-876a-04fec17f9e3f",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsBasedEmail = false,
                            IsFemale = false,
                            IsInactive = false,
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAIAAYagAAAAEAPI4PseCEuI5aNJ95q8TW8DNq36VsHP2JXE9e7BXHuR1TbvKLTDj/EK+NoXcszrpg==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "727b8949-3274-4765-89ef-2c53d5df2946",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("WebApp.Core.Entities.Auth.Role", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<bool>("IsInactive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UserInsertDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserInsertId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("UserUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserUpdateId")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("UserInsertId");

                    b.HasIndex("UserUpdateId");

                    b.ToTable("Roles", "auth");

                    b.HasData(
                        new
                        {
                            Id = "d0b1b383-e64c-4f42-b732-7ffbe8f3666b",
                            ConcurrencyStamp = "f4912daa-a439-43ea-9c5d-dbd590789948",
                            Name = "Admin",
                            NormalizedName = "admin",
                            IsInactive = false
                        });
                });

            modelBuilder.Entity("WebApp.Core.Entities.Auth.UserRoles", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserRole<string>");

                    b.Property<bool>("IsInactive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UserInsertDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserInsertId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("UserUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserUpdateId")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("UserInsertId");

                    b.HasIndex("UserUpdateId");

                    b.ToTable("UserRoles", "auth");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WebApp.Core.Entities.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebApp.Core.Entities.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WebApp.Core.Entities.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebApp.Core.Entities.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApp.Core.Entities.Auth.User", b =>
                {
                    b.HasOne("WebApp.Core.Entities.Auth.User", "UserInsert")
                        .WithMany()
                        .HasForeignKey("UserInsertId");

                    b.HasOne("WebApp.Core.Entities.Auth.User", "UserUpdate")
                        .WithMany()
                        .HasForeignKey("UserUpdateId");

                    b.OwnsMany("WebApp.Core.Entities.Auth.UserRefreshToken", "RefreshTokens", b1 =>
                        {
                            b1.Property<long>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<long>("Id"));

                            b1.Property<string>("Agent")
                                .HasMaxLength(400)
                                .HasColumnType("nvarchar(400)");

                            b1.Property<DateTime>("CreatedOn")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime>("ExpiresOn")
                                .HasColumnType("datetime2");

                            b1.Property<string>("IpAdress")
                                .HasMaxLength(200)
                                .HasColumnType("nvarchar(200)");

                            b1.Property<string>("RefreshToken")
                                .IsRequired()
                                .HasMaxLength(400)
                                .HasColumnType("nvarchar(400)");

                            b1.Property<DateTime?>("RevokedOn")
                                .HasColumnType("datetime2");

                            b1.Property<string>("UserId")
                                .IsRequired()
                                .HasColumnType("nvarchar(450)");

                            b1.HasKey("Id");

                            b1.HasIndex("UserId");

                            b1.ToTable("UserRefreshTokens", "auth");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsMany("WebApp.Core.Entities.Auth.UserValidationToken", "ValidationTokens", b1 =>
                        {
                            b1.Property<long>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<long>("Id"));

                            b1.Property<string>("Agent")
                                .HasMaxLength(400)
                                .HasColumnType("nvarchar(400)");

                            b1.Property<DateTime>("CreatedOn")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime>("ExpiresOn")
                                .HasColumnType("datetime2");

                            b1.Property<string>("IpAdress")
                                .HasMaxLength(200)
                                .HasColumnType("nvarchar(200)");

                            b1.Property<DateTime?>("RevokedOn")
                                .HasColumnType("datetime2");

                            b1.Property<string>("UserId")
                                .IsRequired()
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("ValidationCode")
                                .IsRequired()
                                .HasMaxLength(6)
                                .HasColumnType("nvarchar(6)");

                            b1.Property<string>("ValidationToken")
                                .IsRequired()
                                .HasMaxLength(400)
                                .HasColumnType("nvarchar(400)");

                            b1.Property<bool>("isUsed")
                                .HasColumnType("bit");

                            b1.HasKey("Id");

                            b1.HasIndex("UserId");

                            b1.ToTable("UserValidationTokens", "auth");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.Navigation("RefreshTokens");

                    b.Navigation("UserInsert");

                    b.Navigation("UserUpdate");

                    b.Navigation("ValidationTokens");
                });

            modelBuilder.Entity("WebApp.Core.Entities.Auth.Role", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithOne()
                        .HasForeignKey("WebApp.Core.Entities.Auth.Role", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Core.Entities.Auth.User", "UserInsert")
                        .WithMany()
                        .HasForeignKey("UserInsertId");

                    b.HasOne("WebApp.Core.Entities.Auth.User", "UserUpdate")
                        .WithMany()
                        .HasForeignKey("UserUpdateId");

                    b.Navigation("UserInsert");

                    b.Navigation("UserUpdate");
                });

            modelBuilder.Entity("WebApp.Core.Entities.Auth.UserRoles", b =>
                {
                    b.HasOne("WebApp.Core.Entities.Auth.User", "UserInsert")
                        .WithMany()
                        .HasForeignKey("UserInsertId");

                    b.HasOne("WebApp.Core.Entities.Auth.User", "UserUpdate")
                        .WithMany()
                        .HasForeignKey("UserUpdateId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", null)
                        .WithOne()
                        .HasForeignKey("WebApp.Core.Entities.Auth.UserRoles", "UserId", "RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserInsert");

                    b.Navigation("UserUpdate");
                });
#pragma warning restore 612, 618
        }
    }
}
