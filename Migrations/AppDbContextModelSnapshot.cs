﻿// <auto-generated />
using CarGallery.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarGallery.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("CarGallery.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            CarId = 1,
                            ImageThumbnailUrl = "/images/porsche/porsche_911_Turbo_small.jpg",
                            ImageUrl = "/images/porsche/porsche_911_Turbo.jpg",
                            LongDescription = "Sempre que um carro apresenta um comportamento irrepreensível, é difícil não nos perguntarmos como será possível fazer algo melhor em uma futura geração. Desde a primeira edição do 911 Turbo, em 1975, porém, os engenheiros da Porsche vêm conseguindo essa insuspeita superação e desta vez não foi diferente.",
                            Name = "Porsche 911 Turbo",
                            ShortDescription = "Porsche 911 Turbo S"
                        },
                        new
                        {
                            CarId = 2,
                            ImageThumbnailUrl = "/images/porsche/porsche-cayenne-coupe_small.jpg",
                            ImageUrl = "/images/porsche/porsche-cayenne-coupe.jpg",
                            LongDescription = "Cayenne é um case de sucesso na indústria automobilística. Graças a ele, a Porsche se reinventou, passou a ganhar dinheiro como nunca e hoje é ainda mais forte do que era quando se fala em automóveis esportivos. Com mais de 800 mil unidades vendidas no mundo e 5,2 mil no Brasil, o Cayenne se dá ao luxo de cobrar a mais pelo logotipo que carrega",
                            Name = "Porsche Cayenne",
                            ShortDescription = "O equilibrio entre desempenho e conforto"
                        },
                        new
                        {
                            CarId = 3,
                            ImageThumbnailUrl = "/images/ferrari/ferrari-F8_small.jpg",
                            ImageUrl = "/images/ferrari/ferrari-F8.jpg",
                            LongDescription = "F8 Tributo é uma homenagem ao premiado motor V8 da marca italiana. Trata-se de um 3.9 biturbo, que entrega 720 cavalos e 78,5 kgfm de torque",
                            Name = "Ferrari F8 Tributo",
                            ShortDescription = "F8 Tributo - A lenda"
                        },
                        new
                        {
                            CarId = 4,
                            ImageThumbnailUrl = "/images/ferrari/ferrarri_spider_small.jpg",
                            ImageUrl = "/images/ferrari/ferrarri_spider.jpg",
                            LongDescription = "O coração do novo 458 Spider é o vencedor do Prêmio Motor Internacional do Ano de 2018, um V8 twin-turbo de 3,9 litros com 720 cavalos de potência e 78,52 kgfm de torque",
                            Name = "Ferrari 458 Spider",
                            ShortDescription = "O V8 mais poderoso já feito pela marca"
                        },
                        new
                        {
                            CarId = 5,
                            ImageThumbnailUrl = "/images/ford/ford_mustang_small.jpg",
                            ImageUrl = "/images/ford/ford_mustang.jpg",
                            LongDescription = "O Mustang GT é absolutamente a melhor forma de começar o dia, já que seu motor é uma joia. O V8 ainda mantém o nome de Coyote, mas não é quieto como o anterior. O motor esbraveja como o melhor muscle car de todos os tempos.",
                            Name = "Ford Mustang",
                            ShortDescription = "O melhor pony car"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
