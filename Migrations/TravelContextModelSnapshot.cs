﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TravelCountdownApi.Context;

namespace TravelCountdownApi.Migrations
{
    [DbContext(typeof(TravelContext))]
    partial class TravelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("TravelCountdownApi.Model.TravelDestination", b =>
                {
                    b.Property<int>("TravelDestinationId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Name");

                    b.Property<DateTime>("TravelDate");

                    b.Property<DateTime>("Updated");

                    b.HasKey("TravelDestinationId");

                    b.ToTable("TravelDestinations");
                });
#pragma warning restore 612, 618
        }
    }
}