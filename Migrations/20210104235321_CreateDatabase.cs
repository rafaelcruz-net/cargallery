using Microsoft.EntityFrameworkCore.Migrations;

namespace CarGallery.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "/images/porsche/porsche_911_Turbo_small.jpg", "/images/porsche/porsche_911_Turbo.jpg", "Sempre que um carro apresenta um comportamento irrepreensível, é difícil não nos perguntarmos como será possível fazer algo melhor em uma futura geração. Desde a primeira edição do 911 Turbo, em 1975, porém, os engenheiros da Porsche vêm conseguindo essa insuspeita superação e desta vez não foi diferente.", "Porsche 911 Turbo", "Porsche 911 Turbo S" },
                    { 2, "/images/porsche/porsche-cayenne-coupe_small.jpg", "/images/porsche/porsche-cayenne-coupe.jpg", "Cayenne é um case de sucesso na indústria automobilística. Graças a ele, a Porsche se reinventou, passou a ganhar dinheiro como nunca e hoje é ainda mais forte do que era quando se fala em automóveis esportivos. Com mais de 800 mil unidades vendidas no mundo e 5,2 mil no Brasil, o Cayenne se dá ao luxo de cobrar a mais pelo logotipo que carrega", "Porsche Cayenne", "O equilibrio entre desempenho e conforto" },
                    { 3, "/images/ferrari/ferrari-F8_small.jpg", "/images/ferrari/ferrari-F8.jpg", "F8 Tributo é uma homenagem ao premiado motor V8 da marca italiana. Trata-se de um 3.9 biturbo, que entrega 720 cavalos e 78,5 kgfm de torque", "Ferrari F8 Tributo", "F8 Tributo - A lenda" },
                    { 4, "/images/ferrari/ferrarri_spider_small.jpg", "/images/ferrari/ferrarri_spider.jpg", "O coração do novo 458 Spider é o vencedor do Prêmio Motor Internacional do Ano de 2018, um V8 twin-turbo de 3,9 litros com 720 cavalos de potência e 78,52 kgfm de torque", "Ferrari 458 Spider", "O V8 mais poderoso já feito pela marca" },
                    { 5, "/images/ford/ford_mustang_small.jpg", "/images/ford/ford_mustang.jpg", "O Mustang GT é absolutamente a melhor forma de começar o dia, já que seu motor é uma joia. O V8 ainda mantém o nome de Coyote, mas não é quieto como o anterior. O motor esbraveja como o melhor muscle car de todos os tempos.", "Ford Mustang", "O melhor pony car" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
