﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PostoSocial.Models;

#nullable disable

namespace PostoSocial.Migrations
{
    [DbContext(typeof(PostoContext))]
    [Migration("20241024202828_update")]
    partial class update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PostoSocial.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicturePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AccountId = 1,
                            Email = "andrew.honey@southeasttech.edu",
                            Password = "ice",
                            ProfilePicturePath = "butterfly",
                            UserName = "samuraiofice"
                        });
                });

            modelBuilder.Entity("PostoSocial.Models.Forum", b =>
                {
                    b.Property<int>("ForumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ForumId"), 1L, 1);

                    b.Property<string>("ForumDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ForumName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ForumRules")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ForumId");

                    b.ToTable("Forums");

                    b.HasData(
                        new
                        {
                            ForumId = 1,
                            ForumDescription = "Forum for Posto...",
                            ForumName = "Posto",
                            ForumRules = "There are no rules currently."
                        });
                });

            modelBuilder.Entity("PostoSocial.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ForumId")
                        .HasColumnType("int");

                    b.Property<string>("PostBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostId");

                    b.HasIndex("AccountId");

                    b.HasIndex("ForumId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            AccountId = 1,
                            CategoryId = 1,
                            ForumId = 1,
                            PostBody = "This is Posto Social Media",
                            PostTitle = "Yeet"
                        },
                        new
                        {
                            PostId = 2,
                            AccountId = 1,
                            CategoryId = 1,
                            ForumId = 1,
                            PostBody = "welcome",
                            PostTitle = "Yo, second post"
                        },
                        new
                        {
                            PostId = 3,
                            AccountId = 1,
                            CategoryId = 1,
                            ForumId = 1,
                            PostBody = "lorem ipsum",
                            PostTitle = "I make so many posts"
                        },
                        new
                        {
                            PostId = 4,
                            AccountId = 1,
                            CategoryId = 1,
                            ForumId = 1,
                            PostBody = "To zanarkand",
                            PostTitle = "dos amet"
                        },
                        new
                        {
                            PostId = 5,
                            AccountId = 1,
                            CategoryId = 1,
                            ForumId = 1,
                            PostBody = "cheese",
                            PostTitle = "Lol, I'm so random"
                        });
                });

            modelBuilder.Entity("PostoSocial.Models.Post", b =>
                {
                    b.HasOne("PostoSocial.Models.Account", "User")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PostoSocial.Models.Forum", "Forum")
                        .WithMany()
                        .HasForeignKey("ForumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Forum");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
