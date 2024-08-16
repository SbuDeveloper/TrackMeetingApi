﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrackMngmtMeeting.Infrastructure;

#nullable disable

namespace TrackMngmtMeeting.Infrastructure.Data.Migrations
{
    [DbContext(typeof(TrackMngmtMeetingDbContext))]
    [Migration("20240815202217_ApplicationDbInitial")]
    partial class ApplicationDbInitial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("TrackMngmtMeeting.Domain.Entities.ActionItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MeetingItemId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MeetingItemId");

                    b.ToTable("ActionItems");
                });

            modelBuilder.Entity("TrackMngmtMeeting.Domain.Entities.Meeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MeetingTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MeetingTypeId");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("TrackMngmtMeeting.Domain.Entities.MeetingItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MeetingId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatusId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MeetingId");

                    b.HasIndex("StatusId");

                    b.ToTable("MeetingItems");
                });

            modelBuilder.Entity("TrackMngmtMeeting.Domain.Entities.MeetingItemHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ActionId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MeetingItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatusId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ActionId");

                    b.HasIndex("MeetingItemId");

                    b.HasIndex("StatusId");

                    b.ToTable("MeetingItemHistories");
                });

            modelBuilder.Entity("TrackMngmtMeeting.Domain.Entities.MeetingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MeetingTypes");
                });

            modelBuilder.Entity("TrackMngmtMeeting.Domain.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("TrackMngmtMeeting.Domain.Entities.ActionItem", b =>
                {
                    b.HasOne("TrackMngmtMeeting.Domain.Entities.MeetingItem", "MeetingItem")
                        .WithMany("ActionItems")
                        .HasForeignKey("MeetingItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MeetingItem");
                });

            modelBuilder.Entity("TrackMngmtMeeting.Domain.Entities.Meeting", b =>
                {
                    b.HasOne("TrackMngmtMeeting.Domain.Entities.MeetingType", "MeetingType")
                        .WithMany()
                        .HasForeignKey("MeetingTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MeetingType");
                });

            modelBuilder.Entity("TrackMngmtMeeting.Domain.Entities.MeetingItem", b =>
                {
                    b.HasOne("TrackMngmtMeeting.Domain.Entities.Meeting", "Meeting")
                        .WithMany("MeetingItems")
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrackMngmtMeeting.Domain.Entities.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meeting");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("TrackMngmtMeeting.Domain.Entities.MeetingItemHistory", b =>
                {
                    b.HasOne("TrackMngmtMeeting.Domain.Entities.ActionItem", "Action")
                        .WithMany()
                        .HasForeignKey("ActionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrackMngmtMeeting.Domain.Entities.MeetingItem", "MeetingItem")
                        .WithMany("MeetingItemHistory")
                        .HasForeignKey("MeetingItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrackMngmtMeeting.Domain.Entities.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Action");

                    b.Navigation("MeetingItem");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("TrackMngmtMeeting.Domain.Entities.Meeting", b =>
                {
                    b.Navigation("MeetingItems");
                });

            modelBuilder.Entity("TrackMngmtMeeting.Domain.Entities.MeetingItem", b =>
                {
                    b.Navigation("ActionItems");

                    b.Navigation("MeetingItemHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
