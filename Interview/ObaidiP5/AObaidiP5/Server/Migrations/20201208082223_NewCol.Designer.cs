﻿// <auto-generated />
using AObaidiP5.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AObaidiP5.Server.Migrations
{
    [DbContext(typeof(SnowBoardDbContext))]
    [Migration("20201208082223_NewCol")]
    partial class NewCol
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AObaidiP5.Shared.SnowBoard", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BindingOption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Images")
                        .HasColumnType("tinyint");

                    b.Property<bool>("IncludeBindings")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRegularFoot")
                        .HasColumnType("bit");

                    b.Property<double>("Lenght")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("OrderId");

                    b.ToTable("SnowBoardstb");
                });
#pragma warning restore 612, 618
        }
    }
}
