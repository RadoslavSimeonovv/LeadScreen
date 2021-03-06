// <auto-generated />
using LeadScreen.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeadScreen.Data.Migrations
{
    [DbContext(typeof(LeadScreenContext))]
    [Migration("20220428210235_initialCreateAndSeedTables")]
    partial class initialCreateAndSeedTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LeadScreen.Data.Entities.Lead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pincode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubAreaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubAreaId");

                    b.ToTable("Lead");
                });

            modelBuilder.Entity("LeadScreen.Data.Entities.Subarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pincode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subarea");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mladost 1",
                            Pincode = "1784"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Lyulin",
                            Pincode = "1336"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Musagenitsa",
                            Pincode = "1797"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Nadejda",
                            Pincode = "1220"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Obelya",
                            Pincode = "1387"
                        });
                });

            modelBuilder.Entity("LeadScreen.Data.Entities.Lead", b =>
                {
                    b.HasOne("LeadScreen.Data.Entities.Subarea", "Subarea")
                        .WithMany("Leads")
                        .HasForeignKey("SubAreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
