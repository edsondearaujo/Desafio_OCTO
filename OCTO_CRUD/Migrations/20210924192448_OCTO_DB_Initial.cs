using Microsoft.EntityFrameworkCore.Migrations;

namespace OCTO_CRUD.Migrations
{
    public partial class OCTO_DB_Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    IdClient = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    ZipCode = table.Column<string>(type: "varchar(50)", nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(50)", nullable: false),
                    CellPhone = table.Column<string>(type: "varchar(50)", nullable: true),
                    HomePhone = table.Column<string>(type: "varchar(50)", nullable: true),
                    CommercialPhone = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.IdClient);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
