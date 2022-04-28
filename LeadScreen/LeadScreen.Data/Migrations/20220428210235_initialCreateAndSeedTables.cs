using Microsoft.EntityFrameworkCore.Migrations;

namespace LeadScreen.Data.Migrations
{
    public partial class initialCreateAndSeedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subarea",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Pincode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subarea", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lead",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Pincode = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SubAreaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lead", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lead_Subarea_SubAreaId",
                        column: x => x.SubAreaId,
                        principalTable: "Subarea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Subarea",
                columns: new[] { "Id", "Name", "Pincode" },
                values: new object[,]
                {
                    { 1, "Mladost 1", "1784" },
                    { 2, "Lyulin", "1336" },
                    { 3, "Musagenitsa", "1797" },
                    { 4, "Nadejda", "1220" },
                    { 5, "Obelya", "1387" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lead_SubAreaId",
                table: "Lead",
                column: "SubAreaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lead");

            migrationBuilder.DropTable(
                name: "Subarea");
        }
    }
}
