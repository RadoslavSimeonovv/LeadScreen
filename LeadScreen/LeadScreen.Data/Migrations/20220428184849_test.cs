using Microsoft.EntityFrameworkCore.Migrations;

namespace LeadScreen.Data.Migrations
{
    public partial class test : Migration
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
