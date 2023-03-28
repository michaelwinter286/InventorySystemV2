﻿// <auto-generated />
using System;
using InventorySystem.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InventorySystem.Migrations
{
    [DbContext(typeof(InvContext))]
    partial class InvContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("InventorySystem.Entities.Item", b =>
                {
                    b.Property<Guid>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("ItemAmt")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemName")
                        .HasColumnType("TEXT");

                    b.Property<int>("ItemPar")
                        .HasColumnType("INTEGER");

                    b.HasKey("ItemId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            ItemId = new Guid("d9a9b282-30c0-4e73-9c94-53afd8944143"),
                            ItemAmt = 6,
                            ItemName = "Hay",
                            ItemPar = 10
                        },
                        new
                        {
                            ItemId = new Guid("91d454b1-1a73-4405-a202-a5aa784804e4"),
                            ItemAmt = 25,
                            ItemName = "Diesel Fuel",
                            ItemPar = 10
                        },
                        new
                        {
                            ItemId = new Guid("01a7c6f6-0cb8-45e7-8ec6-7195623fc7ab"),
                            ItemAmt = 12,
                            ItemName = "Unleaded Fuel",
                            ItemPar = 10
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
