﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyTrips;

namespace MyTrips.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyTrips.Models.City", b =>
                {
                    b.Property<int>("id");

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("MyTrips.Models.Host", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cityId");

                    b.Property<string>("class")
                        .IsRequired();

                    b.Property<string>("country")
                        .IsRequired();

                    b.Property<string>("date")
                        .IsRequired();

                    b.Property<int>("guest");

                    b.Property<string>("hotelName")
                        .IsRequired();

                    b.Property<string>("location")
                        .IsRequired();

                    b.Property<decimal>("price");

                    b.Property<int>("stars");

                    b.Property<string>("thumb")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Host");
                });
#pragma warning restore 612, 618
        }
    }
}
