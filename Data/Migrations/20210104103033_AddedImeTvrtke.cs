using Microsoft.EntityFrameworkCore.Migrations;

namespace AplikacijaZaPrijavuIzgradnjeKuca.Data.Migrations
{
    public partial class AddedImeTvrtke : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prijavitelj",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImeVlasnikaTvrtke = table.Column<string>(nullable: true),
                    PrezimeVlasnikaTvrtke = table.Column<string>(nullable: true),
                    ImeTvrtke = table.Column<string>(nullable: true),
                    BrojGodinaPoslovanja = table.Column<short>(nullable: false),
                    OIBTvrtke = table.Column<double>(nullable: false),
                    Adresa = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    KontaktBroj = table.Column<int>(nullable: false),
                    BrojRadnika = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prijavitelj", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prijavitelj");
        }
    }
}
