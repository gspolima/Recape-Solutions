﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recape.Data;

namespace Recape.Data.Migrations
{
    [DbContext(typeof(RecapeDbContext))]
    partial class RecapeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Recape.Models.Agendamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataHorario")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicoId")
                        .HasColumnType("int");

                    b.Property<string>("PacienteId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PacienteId");

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("Recape.Models.Especialidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Especialidades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Pediatria"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Cardiologia"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Pneumologia"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Clínica Geral"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Oftalmologia"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Ortopedia"
                        });
                });

            modelBuilder.Entity("Recape.Models.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EspecialidadeId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadeId");

                    b.ToTable("Medicos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EspecialidadeId = 1,
                            Nome = "Dra. Adama Cadaval"
                        },
                        new
                        {
                            Id = 2,
                            EspecialidadeId = 2,
                            Nome = "Dr. Raúl Abelho"
                        },
                        new
                        {
                            Id = 3,
                            EspecialidadeId = 4,
                            Nome = "Dr. Ismael Veleda"
                        },
                        new
                        {
                            Id = 4,
                            EspecialidadeId = 2,
                            Nome = "Dr. Alberto Mourão"
                        },
                        new
                        {
                            Id = 5,
                            EspecialidadeId = 6,
                            Nome = "Dr. Teófilo Saldanha"
                        },
                        new
                        {
                            Id = 6,
                            EspecialidadeId = 7,
                            Nome = "Dr. Rúben Medeiros"
                        },
                        new
                        {
                            Id = 7,
                            EspecialidadeId = 2,
                            Nome = "Dra. Adriana Rosário"
                        },
                        new
                        {
                            Id = 8,
                            EspecialidadeId = 5,
                            Nome = "Dr. Arthur Nazário"
                        });
                });

            modelBuilder.Entity("Recape.Models.Poltrona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<byte>("Numero")
                        .HasColumnType("tinyint");

                    b.Property<int>("ViagemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ViagemId");

                    b.ToTable("Poltronas");
                });

            modelBuilder.Entity("Recape.Models.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClienteId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PoltronaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PoltronaId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Recape.Models.Viagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataPartida")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<float>("DuracaoEmHoras")
                        .HasColumnType("real");

                    b.Property<string>("Origem")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Viagens");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataPartida = new DateTime(2021, 10, 25, 16, 20, 0, 0, DateTimeKind.Unspecified),
                            Destino = "Recife",
                            DuracaoEmHoras = 28f,
                            Origem = "Fortaleza",
                            Preco = 120.0
                        },
                        new
                        {
                            Id = 2,
                            DataPartida = new DateTime(2021, 10, 23, 6, 0, 0, 0, DateTimeKind.Unspecified),
                            Destino = "Juazeiro do Norte",
                            DuracaoEmHoras = 20f,
                            Origem = "Fortaleza",
                            Preco = 90.0
                        },
                        new
                        {
                            Id = 3,
                            DataPartida = new DateTime(2021, 11, 2, 22, 30, 0, 0, DateTimeKind.Unspecified),
                            Destino = "Belo Horizonte",
                            DuracaoEmHoras = 24f,
                            Origem = "Salvador",
                            Preco = 100.0
                        },
                        new
                        {
                            Id = 4,
                            DataPartida = new DateTime(2021, 11, 5, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            Destino = "Brasília",
                            DuracaoEmHoras = 36f,
                            Origem = "Porto Alegre",
                            Preco = 180.0
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Recape.Models.Agendamento", b =>
                {
                    b.HasOne("Recape.Models.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Recape.Models.Medico", b =>
                {
                    b.HasOne("Recape.Models.Especialidade", "Especialidade")
                        .WithMany()
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialidade");
                });

            modelBuilder.Entity("Recape.Models.Poltrona", b =>
                {
                    b.HasOne("Recape.Models.Viagem", "Viagem")
                        .WithMany("Poltronas")
                        .HasForeignKey("ViagemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Viagem");
                });

            modelBuilder.Entity("Recape.Models.Reserva", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("Recape.Models.Poltrona", "Poltrona")
                        .WithMany()
                        .HasForeignKey("PoltronaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Poltrona");
                });

            modelBuilder.Entity("Recape.Models.Viagem", b =>
                {
                    b.Navigation("Poltronas");
                });
#pragma warning restore 612, 618
        }
    }
}
