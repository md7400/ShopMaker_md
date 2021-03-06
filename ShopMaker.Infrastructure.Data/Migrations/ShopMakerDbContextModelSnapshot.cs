﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopMaker.Infrastructure.Data.Context;

namespace ShopMaker.Infrastructure.Data.Migrations
{
    [DbContext(typeof(ShopMakerDbContext))]
    partial class ShopMakerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShopMaker.Domain.Models.User.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(96)")
                        .HasMaxLength(96);

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("ShopMaker.Domain.Models.User.DocumentType", b =>
                {
                    b.Property<int>("DocumentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TitleDocument")
                        .IsRequired()
                        .HasColumnType("nvarchar(96)")
                        .HasMaxLength(96);

                    b.HasKey("DocumentTypeId");

                    b.ToTable("DocumentTypes");
                });

            modelBuilder.Entity("ShopMaker.Domain.Models.User.SecurityQuestion", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuestionTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<int?>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("QuestionId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("SecurityQuestions");
                });

            modelBuilder.Entity("ShopMaker.Domain.Models.User.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmationCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<DateTime>("CreateUserDate")
                        .HasColumnType("datetime2")
                        .HasMaxLength(64);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmation")
                        .HasColumnType("bit");

                    b.Property<string>("IdentificationCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("LastLoginIp")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<DateTime>("LastUserLoginDate")
                        .HasColumnType("datetime2")
                        .HasMaxLength(64);

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)")
                        .HasMaxLength(16);

                    b.Property<bool>("MobileConfirmation")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)")
                        .HasMaxLength(16);

                    b.Property<bool>("PhoneConfirmation")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("RegisterIp")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<bool>("StatusUser")
                        .HasColumnType("bit")
                        .HasMaxLength(64);

                    b.Property<bool>("TwoFactorAuthentication")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ShopMaker.Domain.Models.User.UserAddress", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(2048)")
                        .HasMaxLength(2048);

                    b.Property<int?>("CitiesCityId")
                        .HasColumnType("int");

                    b.Property<string>("CityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(16)")
                        .HasMaxLength(16);

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasMaxLength(1024);

                    b.HasKey("AddressId");

                    b.HasIndex("CitiesCityId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAddresses");
                });

            modelBuilder.Entity("ShopMaker.Domain.Models.User.UserDocument", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AcceptedDocument")
                        .HasColumnType("bit")
                        .HasMaxLength(96);

                    b.Property<DateTime>("CreateDocumentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Document")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<int>("DocumentTypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasMaxLength(96);

                    b.HasKey("DocumentId");

                    b.HasIndex("DocumentTypeId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("UserDocuments");
                });

            modelBuilder.Entity("ShopMaker.Domain.Models.User.UserProfile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Biography")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(4096);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Family")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProfileId");

                    b.HasIndex("UserId");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("ShopMaker.Domain.Models.User.SecurityQuestion", b =>
                {
                    b.HasOne("ShopMaker.Domain.Models.User.User", "Users")
                        .WithMany()
                        .HasForeignKey("UsersUserId");
                });

            modelBuilder.Entity("ShopMaker.Domain.Models.User.UserAddress", b =>
                {
                    b.HasOne("ShopMaker.Domain.Models.User.City", "Cities")
                        .WithMany()
                        .HasForeignKey("CitiesCityId");

                    b.HasOne("ShopMaker.Domain.Models.User.User", "Users")
                        .WithMany("UserAddresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShopMaker.Domain.Models.User.UserDocument", b =>
                {
                    b.HasOne("ShopMaker.Domain.Models.User.DocumentType", "DocumentType")
                        .WithOne("UserDocuments")
                        .HasForeignKey("ShopMaker.Domain.Models.User.UserDocument", "DocumentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopMaker.Domain.Models.User.User", "User")
                        .WithMany("UserDocuments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShopMaker.Domain.Models.User.UserProfile", b =>
                {
                    b.HasOne("ShopMaker.Domain.Models.User.User", null)
                        .WithMany("UserProfiles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
