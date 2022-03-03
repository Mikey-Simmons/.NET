﻿// <auto-generated />
using System;
using L06HandsOnEntity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace L06HandsOnEntity.Migrations
{
    [DbContext(typeof(AliensContext))]
    partial class AliensContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("L06HandsOnEntity.Models.Alien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlanetOfOrigin")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("numberOfArms")
                        .HasColumnType("INTEGER");

                    b.Property<int>("numberOfHeads")
                        .HasColumnType("INTEGER");

                    b.Property<int>("numberOfLegs")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Aliens");
                });
#pragma warning restore 612, 618
        }
    }
}