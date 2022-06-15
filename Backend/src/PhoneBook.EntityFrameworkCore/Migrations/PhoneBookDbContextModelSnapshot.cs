﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhoneBook.EntityFrameworkCore;

#nullable disable

namespace PhoneBook.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(PhoneBookDbContext))]
    partial class PhoneBookDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PhoneBook.Domain.Contacts.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DirectBossId")
                        .HasColumnType("int");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DirectBossId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("PhoneBook.Domain.TeamMembers.TeamMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamMembers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Jozef Mayer",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Bernard F",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Fatih Akay",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Mehmet Ozan",
                            TeamId = 3
                        },
                        new
                        {
                            Id = 5,
                            FullName = "Shirin Rezaee",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 6,
                            FullName = "Albert Dario",
                            TeamId = 4
                        },
                        new
                        {
                            Id = 7,
                            FullName = "Stephen Jack",
                            TeamId = 3
                        });
                });

            modelBuilder.Entity("PhoneBook.Domain.Teams.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Frontend"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Analizing"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Testing"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Backend"
                        });
                });

            modelBuilder.Entity("PhoneBook.Domain.Contacts.Contact", b =>
                {
                    b.HasOne("PhoneBook.Domain.TeamMembers.TeamMember", "DirectBoss")
                        .WithMany()
                        .HasForeignKey("DirectBossId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DirectBoss");
                });

            modelBuilder.Entity("PhoneBook.Domain.TeamMembers.TeamMember", b =>
                {
                    b.HasOne("PhoneBook.Domain.Teams.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}