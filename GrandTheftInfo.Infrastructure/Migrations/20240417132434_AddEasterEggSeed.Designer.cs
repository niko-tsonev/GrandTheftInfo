﻿// <auto-generated />
using System;
using GrandTheftInfo.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GrandTheftInfo.Infrastructure.Migrations
{
    [DbContext(typeof(GrandTheftInfoDbContext))]
    [Migration("20240417132434_AddEasterEggSeed")]
    partial class AddEasterEggSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GrandTheftInfo.Infrastructure.Data.Models.Cheat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CheatCode")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Platform")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Cheats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CheatCode = "HESOYAM",
                            GameId = 1,
                            Name = "Money cheat",
                            Platform = "PC"
                        },
                        new
                        {
                            Id = 2,
                            CheatCode = "AEZAKMI",
                            GameId = 1,
                            Name = "No police",
                            Platform = "PC"
                        },
                        new
                        {
                            Id = 3,
                            CheatCode = "BAGUVIX",
                            GameId = 1,
                            Name = "God mode cheat",
                            Platform = "PC"
                        },
                        new
                        {
                            Id = 4,
                            CheatCode = "DEDAZNAM",
                            GameId = 2,
                            Name = "Money cheat",
                            Platform = "PC"
                        },
                        new
                        {
                            Id = 5,
                            CheatCode = "BALSAMGO",
                            GameId = 2,
                            Name = "No police",
                            Platform = "PC"
                        },
                        new
                        {
                            Id = 6,
                            CheatCode = "NIZNAM",
                            GameId = 2,
                            Name = "God mode cheat",
                            Platform = "PC"
                        },
                        new
                        {
                            Id = 7,
                            CheatCode = "Down, X, Right, Left, Right, R1, Right, Down, Up, Triangle",
                            GameId = 1,
                            Name = "God mode cheat",
                            Platform = "Playstation"
                        },
                        new
                        {
                            Id = 8,
                            CheatCode = "R1, R2, L1, X, LEFT, DOWN, RIGHT, UP, LEFT, DOWN, RIGHT, UP",
                            GameId = 1,
                            Name = "Money cheat",
                            Platform = "Playstation"
                        },
                        new
                        {
                            Id = 9,
                            CheatCode = "468-555-0100",
                            GameId = 2,
                            Name = "Change weather",
                            Platform = "Playstation"
                        },
                        new
                        {
                            Id = 10,
                            CheatCode = "486-555-0150",
                            GameId = 2,
                            Name = "Weapons 1",
                            Platform = "Playstation"
                        });
                });

            modelBuilder.Entity("GrandTheftInfo.Infrastructure.Data.Models.EasterEgg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrlOne")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageUrlTwo")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("EasterEggs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Located on Gant Bridge, this secret acts as something of a callback to Grand Theft Auto 3's iconic \"you weren't supposed to be able to get here you know\" Easter Egg. To find it, head over to Gant Bridge with a jetpack. Fly to the top of the first tower you pass under while crossing from the San Fierro side. Once you reach the top of the pillar, look to your right. You should see a small sign reading \"There are no Easter Eggs up here. Go away.\"",
                            GameId = 1,
                            ImageUrlOne = "https://oyster.ignimgs.com/mediawiki/apis.ign.com/grand-theft-auto-san-andreas/c/c7/Grand_Theft_Auto_San_Andreas_Gant_Bridge_Easter_Egg.jpg?width=1920",
                            Name = "Secret Message on Gant Bridge"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Gant Bridge actually has a second Easter Egg that's worth seeking out. It can be found listed on a facts board on the San Fierro side of the bridge, close to the diner by Katie's house. Behind the diner is a set of steps, with the board overlooking the walkway. Read the board and you'll see some generic facts about the Gant Bridge. However, the factoids will conclude with something a little less conventional, noting that it \"takes up a staggering 1.27 MB of disk space.\"",
                            GameId = 1,
                            ImageUrlOne = "https://oyster.ignimgs.com/mediawiki/apis.ign.com/grand-theft-auto-san-andreas/e/e1/Grand_Theft_Auto_San_Andreas_Gant_Bridge_Info_Board.jpg?width=1920",
                            Name = "Gant Bridge Information Board"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The Statue of Happiness's face bears a striking resemblance to former U.S. Secretary of State Hillary Clinton. This resemblance, along with the cup of coffee in her right hand, may be a reference to the Hot Coffee controversy which Clinton took investigation in, also suggesting that new regulations be put on video games.",
                            GameId = 2,
                            ImageUrlOne = "https://static.wikia.nocookie.net/gtawiki/images/a/ab/StatueofHappiness-GTA4-statue%27sface.jpg/revision/latest/scale-to-width-down/1000?cb=20100401143154",
                            ImageUrlTwo = "https://static.wikia.nocookie.net/gtawiki/images/f/fa/StatueofHappiness-GTAIV-Statue%27sTorch.jpg/revision/latest?cb=20130813211705",
                            Name = "Face of the statue & the Hot Coffee"
                        },
                        new
                        {
                            Id = 4,
                            Description = "The southern door has a sign: \"No Hidden Content This Way\". This is similar to the sign on top of the Gant Bridge in GTA San Andreas and The Hidden Sign in GTA III.",
                            GameId = 2,
                            ImageUrlOne = "https://static.wikia.nocookie.net/gtawiki/images/7/7b/StatueOfHappiness-GTAIV-NoHiddenContentThisWay.jpg/revision/latest?cb=20140512000301",
                            Name = "\"No Hidden Content This Way\" sign"
                        });
                });

            modelBuilder.Entity("GrandTheftInfo.Infrastructure.Data.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("YearPublished")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Los Santos CJ helps family take over.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c4/GTASABOX.jpg",
                            Name = "GTA San Andreas",
                            YearPublished = new DateTime(2004, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Description = "Niko helps cousing in Liberty City",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/b7/Grand_Theft_Auto_IV_cover.jpg",
                            Name = "GTA IV",
                            YearPublished = new DateTime(2008, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("GrandTheftInfo.Infrastructure.Data.Models.Mission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PlaytroughUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Missions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Ride bikes",
                            GameId = 1,
                            Name = "First SA Mission",
                            PlaytroughUrl = "http://google.com"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Kill ballas",
                            GameId = 1,
                            Name = "Second SA Mission",
                            PlaytroughUrl = "http://google2.com"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Help cousing",
                            GameId = 2,
                            Name = "First GTA 4 Mission",
                            PlaytroughUrl = "http://google3.com"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Save cousing",
                            GameId = 2,
                            Name = "Second GTA 4 Mission",
                            PlaytroughUrl = "http://google4.com"
                        });
                });

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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
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

                    b.Property<string>("Discriminator")
                        .IsRequired()
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

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("GrandTheftInfo.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "21c8ab51-1056-4c31-8e79-c4e41c90d7fb",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c468aaae-462b-4d1d-b434-8efbf3cd9f87",
                            Email = "guest@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "guest@mail.com",
                            NormalizedUserName = "guest@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEIyWNwBephROhCknnCI33in0UH9gBAQrSNQ+CpTjIdf7VQTa2yL4AQH+JFUFzRXkrA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d3d87963-f432-456b-a824-900faab2fc64",
                            TwoFactorEnabled = false,
                            UserName = "guest@mail.com",
                            CreatedOn = new DateTime(2024, 4, 17, 16, 24, 33, 672, DateTimeKind.Local).AddTicks(2976),
                            FirstName = "Guest",
                            IsDeleted = false,
                            LastName = "Guestov",
                            MiddleName = "Guestov",
                            ModifiedOn = new DateTime(2024, 4, 17, 16, 24, 33, 672, DateTimeKind.Local).AddTicks(3013)
                        },
                        new
                        {
                            Id = "5f4bb76c-e097-485f-946d-c8631b8d253a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e4b6e88e-63bd-4135-8031-497e2c71f15d",
                            Email = "admin@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDS1N8/od9eLiJ87KYuR32eYGumbLo/Cu1VAh4VRGQgAlVEC/MJNJBgrQ+zA2J8ceg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "651d6770-c329-448d-8d63-d5f9734f45c4",
                            TwoFactorEnabled = false,
                            UserName = "admin@mail.com",
                            CreatedOn = new DateTime(2024, 4, 17, 16, 24, 33, 673, DateTimeKind.Local).AddTicks(2596),
                            FirstName = "Great",
                            IsDeleted = false,
                            LastName = "Admin",
                            MiddleName = "Adminov",
                            ModifiedOn = new DateTime(2024, 4, 17, 16, 24, 33, 673, DateTimeKind.Local).AddTicks(2598)
                        });
                });

            modelBuilder.Entity("GrandTheftInfo.Infrastructure.Data.Models.Cheat", b =>
                {
                    b.HasOne("GrandTheftInfo.Infrastructure.Data.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("GrandTheftInfo.Infrastructure.Data.Models.EasterEgg", b =>
                {
                    b.HasOne("GrandTheftInfo.Infrastructure.Data.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("GrandTheftInfo.Infrastructure.Data.Models.Mission", b =>
                {
                    b.HasOne("GrandTheftInfo.Infrastructure.Data.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
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
#pragma warning restore 612, 618
        }
    }
}
