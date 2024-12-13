﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEB.Models;

#nullable disable

namespace WEB.Migrations
{
    [DbContext(typeof(BerberContext))]
    [Migration("20241212163705_v6")]
    partial class v6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WEB.Models.Calisan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ExperienceYears")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SalonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SalonId");

                    b.ToTable("Calisanlar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExperienceYears = 5,
                            Name = "Zeynep Aydın",
                            Position = "Kuaför",
                            SalonId = 1
                        },
                        new
                        {
                            Id = 2,
                            ExperienceYears = 3,
                            Name = "Hülya Akın",
                            Position = "Manikürist",
                            SalonId = 2
                        },
                        new
                        {
                            Id = 3,
                            ExperienceYears = 4,
                            Name = "Burak Şen",
                            Position = "Pedikürist",
                            SalonId = 3
                        },
                        new
                        {
                            Id = 4,
                            ExperienceYears = 6,
                            Name = "Elif Güneş",
                            Position = "Cilt Bakım Uzmanı",
                            SalonId = 4
                        },
                        new
                        {
                            Id = 5,
                            ExperienceYears = 7,
                            Name = "Selim Kaya",
                            Position = "Saç Stilisti",
                            SalonId = 5
                        },
                        new
                        {
                            Id = 6,
                            ExperienceYears = 8,
                            Name = "Kemal Yılmaz",
                            Position = "Berber",
                            SalonId = 6
                        },
                        new
                        {
                            Id = 7,
                            ExperienceYears = 4,
                            Name = "Merve Şen",
                            Position = "Makyaj Uzmanı",
                            SalonId = 7
                        },
                        new
                        {
                            Id = 8,
                            ExperienceYears = 5,
                            Name = "Fatih Çelik",
                            Position = "Masaj Terapisti",
                            SalonId = 8
                        },
                        new
                        {
                            Id = 9,
                            ExperienceYears = 10,
                            Name = "Ahmet Arslan",
                            Position = "Berber",
                            SalonId = 9
                        },
                        new
                        {
                            Id = 10,
                            ExperienceYears = 2,
                            Name = "Ayşe Can",
                            Position = "Manikürist",
                            SalonId = 10
                        });
                });

            modelBuilder.Entity("WEB.Models.CalismaSaati", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CalisanId")
                        .HasColumnType("int");

                    b.Property<string>("DayOfWeek")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("CalisanId");

                    b.ToTable("CalismaSaatleri");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CalisanId = 1,
                            DayOfWeek = "Pazartesi",
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            CalisanId = 1,
                            DayOfWeek = "Salı",
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            CalisanId = 1,
                            DayOfWeek = "Çarşamba",
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            CalisanId = 1,
                            DayOfWeek = "Perşembe",
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            CalisanId = 1,
                            DayOfWeek = "Cuma",
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            CalisanId = 1,
                            DayOfWeek = "Cumartesi",
                            EndTime = new TimeSpan(0, 16, 0, 0, 0),
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 7,
                            CalisanId = 2,
                            DayOfWeek = "Pazartesi",
                            EndTime = new TimeSpan(0, 19, 0, 0, 0),
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 8,
                            CalisanId = 2,
                            DayOfWeek = "Salı",
                            EndTime = new TimeSpan(0, 19, 0, 0, 0),
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 9,
                            CalisanId = 2,
                            DayOfWeek = "Çarşamba",
                            EndTime = new TimeSpan(0, 19, 0, 0, 0),
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 10,
                            CalisanId = 2,
                            DayOfWeek = "Perşembe",
                            EndTime = new TimeSpan(0, 19, 0, 0, 0),
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 11,
                            CalisanId = 2,
                            DayOfWeek = "Cuma",
                            EndTime = new TimeSpan(0, 19, 0, 0, 0),
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 12,
                            CalisanId = 2,
                            DayOfWeek = "Cumartesi",
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            StartTime = new TimeSpan(0, 10, 30, 0, 0)
                        },
                        new
                        {
                            Id = 13,
                            CalisanId = 3,
                            DayOfWeek = "Pazartesi",
                            EndTime = new TimeSpan(0, 17, 30, 0, 0),
                            StartTime = new TimeSpan(0, 8, 30, 0, 0)
                        },
                        new
                        {
                            Id = 14,
                            CalisanId = 3,
                            DayOfWeek = "Salı",
                            EndTime = new TimeSpan(0, 17, 30, 0, 0),
                            StartTime = new TimeSpan(0, 8, 30, 0, 0)
                        },
                        new
                        {
                            Id = 15,
                            CalisanId = 3,
                            DayOfWeek = "Çarşamba",
                            EndTime = new TimeSpan(0, 17, 30, 0, 0),
                            StartTime = new TimeSpan(0, 8, 30, 0, 0)
                        },
                        new
                        {
                            Id = 16,
                            CalisanId = 3,
                            DayOfWeek = "Perşembe",
                            EndTime = new TimeSpan(0, 17, 30, 0, 0),
                            StartTime = new TimeSpan(0, 8, 30, 0, 0)
                        },
                        new
                        {
                            Id = 17,
                            CalisanId = 3,
                            DayOfWeek = "Cuma",
                            EndTime = new TimeSpan(0, 17, 30, 0, 0),
                            StartTime = new TimeSpan(0, 8, 30, 0, 0)
                        },
                        new
                        {
                            Id = 18,
                            CalisanId = 3,
                            DayOfWeek = "Cumartesi",
                            EndTime = new TimeSpan(0, 14, 0, 0, 0),
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("WEB.Models.Hizmet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DurationMinutes")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Hizmetler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DurationMinutes = 30,
                            Name = "Saç Kesimi",
                            Price = 50m
                        },
                        new
                        {
                            Id = 2,
                            DurationMinutes = 45,
                            Name = "Manikür",
                            Price = 80m
                        },
                        new
                        {
                            Id = 3,
                            DurationMinutes = 60,
                            Name = "Pedikür",
                            Price = 100m
                        },
                        new
                        {
                            Id = 4,
                            DurationMinutes = 90,
                            Name = "Saç Boyama",
                            Price = 200m
                        },
                        new
                        {
                            Id = 5,
                            DurationMinutes = 120,
                            Name = "Cilt Bakımı",
                            Price = 150m
                        },
                        new
                        {
                            Id = 6,
                            DurationMinutes = 25,
                            Name = "Sakal Kesimi",
                            Price = 40m
                        },
                        new
                        {
                            Id = 7,
                            DurationMinutes = 60,
                            Name = "Masaj",
                            Price = 250m
                        },
                        new
                        {
                            Id = 8,
                            DurationMinutes = 15,
                            Name = "Saç Yıkama",
                            Price = 20m
                        },
                        new
                        {
                            Id = 9,
                            DurationMinutes = 30,
                            Name = "Yüz Temizleme",
                            Price = 100m
                        },
                        new
                        {
                            Id = 10,
                            DurationMinutes = 20,
                            Name = "Bıyık Şekillendirme",
                            Price = 30m
                        });
                });

            modelBuilder.Entity("WEB.Models.Randevu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AppointmentTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SalonId")
                        .HasColumnType("int");

                    b.Property<string>("Service")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SalonId");

                    b.HasIndex("UserId");

                    b.ToTable("Randevular");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppointmentTime = new DateTime(2024, 12, 13, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            SalonId = 1,
                            Service = "Saç Kesimi",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            AppointmentTime = new DateTime(2024, 12, 14, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 80m,
                            SalonId = 2,
                            Service = "Manikür",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            AppointmentTime = new DateTime(2024, 12, 15, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 100m,
                            SalonId = 3,
                            Service = "Pedikür",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            AppointmentTime = new DateTime(2024, 12, 16, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 150m,
                            SalonId = 4,
                            Service = "Cilt Bakımı",
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            AppointmentTime = new DateTime(2024, 12, 17, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 200m,
                            SalonId = 5,
                            Service = "Saç Boyama",
                            UserId = 5
                        },
                        new
                        {
                            Id = 6,
                            AppointmentTime = new DateTime(2024, 12, 18, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 40m,
                            SalonId = 6,
                            Service = "Sakal Kesimi",
                            UserId = 6
                        },
                        new
                        {
                            Id = 7,
                            AppointmentTime = new DateTime(2024, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 250m,
                            SalonId = 7,
                            Service = "Masaj",
                            UserId = 7
                        },
                        new
                        {
                            Id = 8,
                            AppointmentTime = new DateTime(2024, 12, 20, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 100m,
                            SalonId = 8,
                            Service = "Yüz Temizleme",
                            UserId = 8
                        },
                        new
                        {
                            Id = 9,
                            AppointmentTime = new DateTime(2024, 12, 21, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 50m,
                            SalonId = 9,
                            Service = "Saç Kesimi",
                            UserId = 9
                        },
                        new
                        {
                            Id = 10,
                            AppointmentTime = new DateTime(2024, 12, 22, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 80m,
                            SalonId = 10,
                            Service = "Manikür",
                            UserId = 10
                        });
                });

            modelBuilder.Entity("WEB.Models.Salon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Salonlar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContactNumber = "02124567890",
                            Location = "İstanbul",
                            Name = "Elite Güzellik Salonu"
                        },
                        new
                        {
                            Id = 2,
                            ContactNumber = "03124567890",
                            Location = "Ankara",
                            Name = "Lüks Kuaför"
                        },
                        new
                        {
                            Id = 3,
                            ContactNumber = "02324567890",
                            Location = "İzmir",
                            Name = "Güzellik Merkezi"
                        },
                        new
                        {
                            Id = 4,
                            ContactNumber = "02424567890",
                            Location = "Antalya",
                            Name = "Bakım ve Spa"
                        },
                        new
                        {
                            Id = 5,
                            ContactNumber = "02224567890",
                            Location = "Bursa",
                            Name = "Zen Saç Stüdyosu"
                        },
                        new
                        {
                            Id = 6,
                            ContactNumber = "03224567890",
                            Location = "Adana",
                            Name = "Royal Saç Merkezi"
                        },
                        new
                        {
                            Id = 7,
                            ContactNumber = "03424567890",
                            Location = "Gaziantep",
                            Name = "Luxury Hair"
                        },
                        new
                        {
                            Id = 8,
                            ContactNumber = "03524567890",
                            Location = "Kayseri",
                            Name = "Dream Spa"
                        },
                        new
                        {
                            Id = 9,
                            ContactNumber = "02224567891",
                            Location = "Eskişehir",
                            Name = "Modern Güzellik"
                        },
                        new
                        {
                            Id = 10,
                            ContactNumber = "03324567890",
                            Location = "Konya",
                            Name = "Prestij Bakım Merkezi"
                        });
                });

            modelBuilder.Entity("WEB.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "ahmet.yilmaz@gmail.com",
                            Name = "Ahmet Yılmaz",
                            PasswordHash = "AQAAAAIAAYagAAAAEE+xkJbhBjWwdMfHeAsdWoOGCLoSQzmWmkzgMkTHjshNPkqWauzwxozdH7ugHtKWTw==",
                            Phone = "05331234567"
                        },
                        new
                        {
                            Id = 2,
                            Email = "ayse.demir@gmail.com",
                            Name = "Ayşe Demir",
                            PasswordHash = "AQAAAAIAAYagAAAAEJ3TYj8Hl5lK8MN0lsP9Zvqx/14nZLxtI2r8HZzRewidJ/zu8CNPjG3fbjFjkZNTcA==",
                            Phone = "05339876543"
                        },
                        new
                        {
                            Id = 3,
                            Email = "fatma.celik@gmail.com",
                            Name = "Fatma Çelik",
                            PasswordHash = "AQAAAAIAAYagAAAAECKffer5PM5l2KKjOMoNYrLQHa1bqW9G2S0FDwRTUjecxI7ayAvaXvZ3/IWGLo67Dw==",
                            Phone = "05431234567"
                        },
                        new
                        {
                            Id = 4,
                            Email = "mehmet.kara@gmail.com",
                            Name = "Mehmet Kara",
                            PasswordHash = "AQAAAAIAAYagAAAAEDo5Q0Dsl6JpcE6WJHd9wmSgAj97gygchwNRxQw7RA3rhKmheUyTOnhYjcfK9KOynw==",
                            Phone = "05439876543"
                        },
                        new
                        {
                            Id = 5,
                            Email = "ali.can@gmail.com",
                            Name = "Ali Can",
                            PasswordHash = "AQAAAAIAAYagAAAAEEKVeIn/wPJCFbgRPKKKU2QY02XBLMe0B12CivhihrvkHk6vIDG8a8nQ7t0PFQKG/A==",
                            Phone = "05551234567"
                        },
                        new
                        {
                            Id = 6,
                            Email = "merve.sen@gmail.com",
                            Name = "Merve Şen",
                            PasswordHash = "AQAAAAIAAYagAAAAEAw1R59egwEj196SW+hMYWDVSQ3iyh7227Nut1iVFaX70fmUT0v+SXwOJS8Ols7v/g==",
                            Phone = "05631234567"
                        },
                        new
                        {
                            Id = 7,
                            Email = "burak.arslan@gmail.com",
                            Name = "Burak Arslan",
                            PasswordHash = "AQAAAAIAAYagAAAAEKq7mcHpz4RALIrZf65d31CUSCXz9rc6oM7UTDIV5drMe4ZrxPw8k9ybEHRRdpXflA==",
                            Phone = "05471234567"
                        },
                        new
                        {
                            Id = 8,
                            Email = "emre.yildiz@gmail.com",
                            Name = "Emre Yıldız",
                            PasswordHash = "AQAAAAIAAYagAAAAEPe9I9SfjiHWJ6NgzuzmwV3s+EJyYsbZim7x76NXSlfo2D3FJFZA0Q9ZwY67T23gkg==",
                            Phone = "05381234567"
                        },
                        new
                        {
                            Id = 9,
                            Email = "elif.gul@gmail.com",
                            Name = "Elif Gül",
                            PasswordHash = "AQAAAAIAAYagAAAAEHRCrfeCEFmPHxTAYe3LBDm3FJ/s9M9XoDNqLaSU4zX7h2tiM03PPhUWomfmDmAyjA==",
                            Phone = "05569876543"
                        },
                        new
                        {
                            Id = 10,
                            Email = "huseyin.demir@gmail.com",
                            Name = "Hüseyin Demir",
                            PasswordHash = "AQAAAAIAAYagAAAAEC2lhHU67lB55slDAZBwCT3uWstY5K0kWDeDa4HKfinY0Q5o/DjExeULoRuz/cMNQQ==",
                            Phone = "05351239876"
                        });
                });

            modelBuilder.Entity("WEB.Models.Calisan", b =>
                {
                    b.HasOne("WEB.Models.Salon", "Salon")
                        .WithMany("Calisanlar")
                        .HasForeignKey("SalonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("WEB.Models.CalismaSaati", b =>
                {
                    b.HasOne("WEB.Models.Calisan", "Calisan")
                        .WithMany("CalismaSaatleri")
                        .HasForeignKey("CalisanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calisan");
                });

            modelBuilder.Entity("WEB.Models.Randevu", b =>
                {
                    b.HasOne("WEB.Models.Salon", "Salon")
                        .WithMany("Randevular")
                        .HasForeignKey("SalonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WEB.Models.User", "User")
                        .WithMany("Randevular")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Salon");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WEB.Models.Calisan", b =>
                {
                    b.Navigation("CalismaSaatleri");
                });

            modelBuilder.Entity("WEB.Models.Salon", b =>
                {
                    b.Navigation("Calisanlar");

                    b.Navigation("Randevular");
                });

            modelBuilder.Entity("WEB.Models.User", b =>
                {
                    b.Navigation("Randevular");
                });
#pragma warning restore 612, 618
        }
    }
}