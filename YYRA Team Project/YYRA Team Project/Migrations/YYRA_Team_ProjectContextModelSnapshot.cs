﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YYRA_Team_Project.Data;

namespace YYRA_Team_Project.Migrations
{
    [DbContext(typeof(YYRA_Team_ProjectContext))]
    partial class YYRA_Team_ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YYRA_Team_Project.Models.ClientInfo", b =>
                {
                    b.Property<int>("C_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("P_Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("U_Address1")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("U_Address2")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("U_City")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("U_ID")
                        .HasColumnType("int");

                    b.Property<string>("U_State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("U_Zipcode")
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.HasKey("C_ID");

                    b.ToTable("ClientInformation");
                });

            modelBuilder.Entity("YYRA_Team_Project.Models.Quote", b =>
                {
                    b.Property<int>("QID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("Q_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q_Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Q_Gallons")
                        .HasColumnType("int");

                    b.Property<float>("Q_Price")
                        .HasColumnType("real");

                    b.Property<float>("Q_Total")
                        .HasColumnType("real");

                    b.HasKey("QID", "UserID");

                    b.ToTable("Quote");
                });

            modelBuilder.Entity("YYRA_Team_Project.Models.User", b =>
                {
                    b.Property<int>("U_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("U_Address1")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("U_Address2")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("U_City")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("U_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("U_FullName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("U_Pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)")
                        .HasMaxLength(16);

                    b.Property<string>("U_Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("U_State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("U_Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)")
                        .HasMaxLength(16);

                    b.Property<string>("U_Zipcode")
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.HasKey("U_ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("YYRA_Team_Project.Models.UserCred", b =>
                {
                    b.Property<int>("U_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("U_Pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)")
                        .HasMaxLength(16);

                    b.Property<string>("U_Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("U_Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)")
                        .HasMaxLength(16);

                    b.HasKey("U_ID");

                    b.ToTable("UserCredentials");
                });
#pragma warning restore 612, 618
        }
    }
}
