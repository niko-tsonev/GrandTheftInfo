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
    [Migration("20240424101514_AddNewestSeedDb")]
    partial class AddNewestSeedDb
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
                            CheatCode = "R1, R2, L1, X, LEFT, DOWN, RIGHT, UP, LEFT, DOWN, RIGHT, UP",
                            GameId = 1,
                            Name = "Health, Armor, and Money ($250,000)",
                            Platform = "Playstation"
                        },
                        new
                        {
                            Id = 2,
                            CheatCode = "L1, R1, SQUARE, R1, LEFT, R2, R1, LEFT, SQUARE, DOWN, L1, L1",
                            GameId = 1,
                            Name = "Infinite Ammo",
                            Platform = "Playstation"
                        },
                        new
                        {
                            Id = 3,
                            CheatCode = "Down, X, Right, Left, Right, R1, Right, Down, Up, Triangle",
                            GameId = 1,
                            Name = "(Almost) Infinite Health",
                            Platform = "Playstation"
                        },
                        new
                        {
                            Id = 4,
                            CheatCode = "HESOYAM",
                            GameId = 1,
                            Name = "Health, Armor, and Money ($250,000)",
                            Platform = "PC"
                        },
                        new
                        {
                            Id = 5,
                            CheatCode = "FULLCLIP",
                            GameId = 1,
                            Name = "Infinite Ammo",
                            Platform = "PC"
                        },
                        new
                        {
                            Id = 6,
                            CheatCode = "486-555-0150",
                            GameId = 2,
                            Name = "Weapons 1",
                            Platform = "Playstation"
                        },
                        new
                        {
                            Id = 7,
                            CheatCode = "265-555-2423",
                            GameId = 2,
                            Name = "Presidente",
                            Platform = "Playstation"
                        },
                        new
                        {
                            Id = 8,
                            CheatCode = "267-555-0150",
                            GameId = 2,
                            Name = "Raise wanted level",
                            Platform = "Playstation"
                        },
                        new
                        {
                            Id = 9,
                            CheatCode = "938-555-0100",
                            GameId = 2,
                            Name = "Spawn a Jetmax boat",
                            Platform = "PC"
                        },
                        new
                        {
                            Id = 10,
                            CheatCode = "486-555-0150",
                            GameId = 2,
                            Name = "Weapons 1",
                            Platform = "PC"
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
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrlOne")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageUrlTwo")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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
                            ImageUrlOne = "https://static.wikia.nocookie.net/gtawiki/images/a/ab/StatueofHappiness-GTA4-statue%27sface.jpg",
                            ImageUrlTwo = "https://static.wikia.nocookie.net/gtawiki/images/f/fa/StatueofHappiness-GTAIV-Statue%27sTorch.jpg",
                            Name = "Face of the statue & the Hot Coffee"
                        },
                        new
                        {
                            Id = 4,
                            Description = "The southern door has a sign: \"No Hidden Content This Way\". This is similar to the sign on top of the Gant Bridge in GTA San Andreas and The Hidden Sign in GTA III.",
                            GameId = 2,
                            ImageUrlOne = "https://static.wikia.nocookie.net/gtawiki/images/7/7b/StatueOfHappiness-GTAIV-NoHiddenContentThisWay.jpg",
                            Name = "\"No Hidden Content This Way\" sign"
                        });
                });

            modelBuilder.Entity("GrandTheftInfo.Infrastructure.Data.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DatePublished")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DatePublished = new DateTime(2004, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Grand Theft Auto: San Andreas is a 2004 action-adventure game developed by Rockstar North and published by Rockstar Games. It is the seventh title in the Grand Theft Auto series, following 2002's Grand Theft Auto: Vice City. Set within the fictional state of San Andreas, the game follows Carl \"CJ\" Johnson, who returns home after his mother's murder and finds his old gang has lost much of their territory. Over the course of the game, he attempts to re-establish the gang, clashes with corrupt authorities and powerful criminals, and gradually unravels the truth behind his mother's murder.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c4/GTASABOX.jpg",
                            Name = "GTA San Andreas"
                        },
                        new
                        {
                            Id = 2,
                            DatePublished = new DateTime(2008, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Grand Theft Auto IV is a 2008 action-adventure game developed by Rockstar North and published by Rockstar Games. It is the sixth main entry in the Grand Theft Auto series, following 2004's Grand Theft Auto: San Andreas, and the eleventh instalment overall. Set in the fictional Liberty City, based on New York City, the single-player story follows Eastern European war veteran Niko Bellic and his attempts to escape his past while under pressure from high-profile criminals. The open world design lets players freely roam Liberty City, consisting of three main islands, and the neighbouring state of ",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/b7/Grand_Theft_Auto_IV_cover.jpg",
                            Name = "GTA IV"
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
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PlaytroughUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Missions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Carl Johnson returns to Los Santos after spending five years in Liberty City when his brother Sweet Johnson informs him about his mother's death. However, when he reaches home to Grove Street, he gets captured by C.R.A.S.H. officers, who take his money and force him to get into their car before dropping him off at Jefferson, a Ballas territory.",
                            GameId = 1,
                            Name = "In the Beginning",
                            PlaytroughUrl = "https://www.youtube.com/embed/OpTizzox2Qo?si=K5xZIWQwL6kFdpgW"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Carl meets Ryder at his house in Grove Street, though Ryder is not that happy to see Carl back. Ryder tells Carl that a pizza owner keeps painting over Grove Street tags and decides to give him some shame.",
                            GameId = 1,
                            Name = "Ryder",
                            PlaytroughUrl = "https://www.youtube.com/embed/LbqKA7cYCQM?si=CIn-_iEtDviV6LUS"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Carl visits Sweet and Big Smoke at Sweet's house. Sweet questions Carl about what made him return to the hood, and gives him a spray can to let him spray over some enemy graffiti. Sweet, however, changes his mind and decides to go with him.",
                            GameId = 1,
                            Name = "Tagging Up Turf",
                            PlaytroughUrl = "https://www.youtube.com/embed/HRduC_IkmFA?si=-dFIz96gsCFNCgwP"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Sweet, Big Smoke, and Ryder are discussing the rise in crack cocaine in the city. After a brief argument, Ryder and CJ decide to take care of the business.",
                            GameId = 1,
                            Name = "Cleaning the Hood",
                            PlaytroughUrl = "https://www.youtube.com/embed/fUjfkGgZNIk?si=xrtBeDGMPzpePcOr"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Big Smoke, Sweet, and Ryder go to eat, and CJ joins them. They head to Cluckin' Bell and get some orders. While eating, they spot the same Ballas who chased them earlier heading towards Grove Street.",
                            GameId = 1,
                            Name = "Drive-Thru",
                            PlaytroughUrl = "https://www.youtube.com/embed/E1aTlYlfzRk?si=SwSKVp536zSowgDS"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Watch the Introduction, before meeting Roman Bellic and driving him to his apartment.",
                            GameId = 2,
                            Name = "The Cousins Bellic",
                            PlaytroughUrl = "https://www.youtube.com/embed/Qo_9uifCivI?si=WTKXuLH87oVARRO6"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Drive Roman to a hardware store, receive his old phone and escape from the loan sharks.",
                            GameId = 2,
                            Name = "It's Your Call",
                            PlaytroughUrl = "https://www.youtube.com/embed/c1_fKy1gcdI?si=uqo3XBtEymWZUnyL"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Pick up Mallorie Bardas and Michelle from the subway station, drive them to Michelle's place, and go buy new clothes.",
                            GameId = 2,
                            Name = "Three's a Crowd",
                            PlaytroughUrl = "https://www.youtube.com/embed/vQEVBOQTjfE?si=uuf7SCZJrVfTqE_N"
                        });
                });

            modelBuilder.Entity("GrandTheftInfo.Infrastructure.Data.Models.SaveGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BlobUri")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("SaveGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BlobUri = "https://grandtheftinfo.blob.core.windows.net/blobgrandtheftinfo/test1.rar",
                            Description = "GTA San Andreas 100 Save",
                            FileName = "test1.rar",
                            GameId = 1
                        },
                        new
                        {
                            Id = 2,
                            BlobUri = "https://grandtheftinfo.blob.core.windows.net/blobgrandtheftinfo/test2.rar",
                            Description = "GTA San Andreas 60 Save",
                            FileName = "test2.rar",
                            GameId = 1
                        },
                        new
                        {
                            Id = 3,
                            BlobUri = "https://grandtheftinfo.blob.core.windows.net/blobgrandtheftinfo/test3.rar",
                            Description = "GTA 4 100 Save",
                            FileName = "test3.rar",
                            GameId = 2
                        });
                });

            modelBuilder.Entity("GrandTheftInfo.Infrastructure.Data.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Radio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RadioImageUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GameId = 1,
                            Name = "Rick James - Cold Blooded",
                            Radio = "Bounce FM",
                            RadioImageUrl = "https://i1.sndcdn.com/artworks-000072126799-6e0z41-t500x500.jpg",
                            VideoUrl = "https://www.youtube.com/watch?v=Vm4jJQFXWp4&ab_channel=Micahisgod"
                        },
                        new
                        {
                            Id = 2,
                            GameId = 1,
                            Name = "Ohio Players - Love Rollercoaster",
                            Radio = "Bounce FM",
                            RadioImageUrl = "https://i1.sndcdn.com/artworks-000072126799-6e0z41-t500x500.jpg",
                            VideoUrl = "https://www.youtube.com/watch?v=Gm8lcoPZtBY&ab_channel=drewsmusical"
                        },
                        new
                        {
                            Id = 3,
                            GameId = 2,
                            Name = "Mobb Deep - Dirty New Yorker",
                            Radio = "The Beat 102.7",
                            RadioImageUrl = "https://i.ibb.co/sjXcxBw/The-Beat-102-7-29.png",
                            VideoUrl = "https://www.youtube.com/watch?v=o1kO1JM1T6A&ab_channel=VevoMusicGroup"
                        },
                        new
                        {
                            Id = 4,
                            GameId = 2,
                            Name = "Nas - War Is Necessary",
                            Radio = "The Beat 102.7",
                            RadioImageUrl = "https://i.ibb.co/sjXcxBw/The-Beat-102-7-29.png",
                            VideoUrl = "https://www.youtube.com/watch?v=PIwb70xCqaQ&ab_channel=RapIsTheRealShit"
                        },
                        new
                        {
                            Id = 5,
                            GameId = 1,
                            Name = "The Edge - David McCallum",
                            Radio = "Fusion FM",
                            RadioImageUrl = "https://static.wikia.nocookie.net/gtawiki/images/6/65/Fusion-FM-Logo%2C_IV.png",
                            VideoUrl = "https://www.youtube.com/embed/y05mMRJrUnE?si=w5bWjYkcXIzQdclZ"
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

                    b.HasData(
                        new
                        {
                            Id = "0a87523a-a2a7-4743-8c5f-aff061686200",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fe684972-26ff-4dc5-b2f1-30b83772a266",
                            Email = "guest@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "guest@mail.com",
                            NormalizedUserName = "guest@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEHKzih2RD5K6/pCg/LWvjajctgZPUmjRjob8FJfX/8mUAy6nWCCKpD6af9+yaT+Eew==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ce8c60e8-a409-45dc-9384-27d0b3e0bb42",
                            TwoFactorEnabled = false,
                            UserName = "guest@mail.com"
                        },
                        new
                        {
                            Id = "dc07746a-9b68-44ae-b193-4cb4a65e3593",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d6b785d5-0e6c-43a2-8c7c-eece6b138107",
                            Email = "admin@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEC73LQUoNQl2jpE5WeyvdB8QNNDmDwzaU7UgIGJ2mmUq+++sZa5Hy/0tFtPj8ODzSw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1f1e02c1-dd35-46e2-a6ca-8c1365178d3b",
                            TwoFactorEnabled = false,
                            UserName = "admin@mail.com"
                        });
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

            modelBuilder.Entity("GrandTheftInfo.Infrastructure.Data.Models.SaveGame", b =>
                {
                    b.HasOne("GrandTheftInfo.Infrastructure.Data.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("GrandTheftInfo.Infrastructure.Data.Models.Song", b =>
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
