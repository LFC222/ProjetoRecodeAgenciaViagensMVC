using Microsoft.EntityFrameworkCore.Migrations;

namespace RecodeMvc.Migrations.SqlServerMigrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Promocaos",
                columns: table => new
                {
                    Id_Promo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destino_Promo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor_promo = table.Column<float>(type: "real", nullable: false),
                    Qntd_Dias = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promocaos", x => x.Id_Promo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promocaos");
        }
    }
}
