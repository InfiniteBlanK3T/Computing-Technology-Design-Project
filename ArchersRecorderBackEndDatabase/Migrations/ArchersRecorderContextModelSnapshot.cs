﻿// <auto-generated />
using System;
using ArchersRecorderBackEndDatabase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ArchersRecorderBackEndDatabase.Migrations
{
    [DbContext(typeof(ArchersRecorderContext))]
    partial class ArchersRecorderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ArchersRecorderBackEndDatabase.Models.Archers", b =>
                {
                    b.Property<int>("ArcherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArcherId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("GivenName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ArcherId");

                    b.ToTable("Archers");
                });

            modelBuilder.Entity("ArchersRecorderBackEndDatabase.Models.Ends", b =>
                {
                    b.Property<int>("EndId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EndId"));

                    b.Property<int>("ArrowScore1")
                        .HasColumnType("int");

                    b.Property<int>("ArrowScore2")
                        .HasColumnType("int");

                    b.Property<int>("ArrowScore3")
                        .HasColumnType("int");

                    b.Property<int>("ArrowScore4")
                        .HasColumnType("int");

                    b.Property<int>("ArrowScore5")
                        .HasColumnType("int");

                    b.Property<int>("ArrowScore6")
                        .HasColumnType("int");

                    b.Property<int>("RangeID")
                        .HasColumnType("int");

                    b.Property<int>("RoundScoreID")
                        .HasColumnType("int");

                    b.HasKey("EndId");

                    b.HasIndex("RangeID");

                    b.HasIndex("RoundScoreID");

                    b.ToTable("Ends");
                });

            modelBuilder.Entity("ArchersRecorderBackEndDatabase.Models.Equipments", b =>
                {
                    b.Property<string>("EquipmentName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EquipmentName");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("ArchersRecorderBackEndDatabase.Models.Ranges", b =>
                {
                    b.Property<int>("RangeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RangeID"));

                    b.Property<int>("Distance")
                        .HasColumnType("int");

                    b.Property<int>("FaceSize")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfEnds")
                        .HasColumnType("int");

                    b.HasKey("RangeID");

                    b.ToTable("Ranges");
                });

            modelBuilder.Entity("ArchersRecorderBackEndDatabase.Models.RoundRangeMapping", b =>
                {
                    b.Property<int>("RangeId")
                        .HasColumnType("int");

                    b.Property<int>("RoundId")
                        .HasColumnType("int");

                    b.HasKey("RangeId", "RoundId");

                    b.HasIndex("RoundId");

                    b.ToTable("RoundRangeMappings");
                });

            modelBuilder.Entity("ArchersRecorderBackEndDatabase.Models.RoundScores", b =>
                {
                    b.Property<int>("RoundScoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoundScoreId"));

                    b.Property<int>("ArcherId")
                        .HasColumnType("int");

                    b.Property<string>("EquipmentName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RoundId")
                        .HasColumnType("int");

                    b.HasKey("RoundScoreId");

                    b.ToTable("RoundScores");
                });

            modelBuilder.Entity("ArchersRecorderBackEndDatabase.Models.Rounds", b =>
                {
                    b.Property<int>("RoundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoundId"));

                    b.Property<string>("RoundName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TotalArrows")
                        .HasColumnType("int");

                    b.HasKey("RoundId");

                    b.ToTable("Rounds");
                });

            modelBuilder.Entity("ArchersRecorderBackEndDatabase.Models.Ends", b =>
                {
                    b.HasOne("ArchersRecorderBackEndDatabase.Models.Ranges", "Ranges")
                        .WithMany()
                        .HasForeignKey("RangeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArchersRecorderBackEndDatabase.Models.RoundScores", "RoundScores")
                        .WithMany()
                        .HasForeignKey("RoundScoreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ranges");

                    b.Navigation("RoundScores");
                });

            modelBuilder.Entity("ArchersRecorderBackEndDatabase.Models.RoundRangeMapping", b =>
                {
                    b.HasOne("ArchersRecorderBackEndDatabase.Models.Ranges", "Ranges")
                        .WithMany()
                        .HasForeignKey("RangeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArchersRecorderBackEndDatabase.Models.Rounds", "Rounds")
                        .WithMany()
                        .HasForeignKey("RoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ranges");

                    b.Navigation("Rounds");
                });
#pragma warning restore 612, 618
        }
    }
}
