using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication_Core_mvc.Migrations
{
    public partial class tasktables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskCreate",
                columns: table => new
                {
                    SeverityId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    SiteID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TaskTickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    SiteID = table.Column<int>(nullable: false),
                    Body = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    SeverityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTickets", x => x.TicketId);
                });

            migrationBuilder.CreateTable(
                name: "TaskProjectList",
                columns: table => new
                {
                    TaskProjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketId = table.Column<int>(nullable: false),
                    TaskTicketsTicketId = table.Column<int>(nullable: true),
                    ItemDescription = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Pass = table.Column<bool>(nullable: false),
                    Fail = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskProjectList", x => x.TaskProjectId);
                    table.ForeignKey(
                        name: "FK_TaskProjectList_TaskTickets_TaskTicketsTicketId",
                        column: x => x.TaskTicketsTicketId,
                        principalTable: "TaskTickets",
                        principalColumn: "TicketId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskProjectList_TaskTicketsTicketId",
                table: "TaskProjectList",
                column: "TaskTicketsTicketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskCreate");

            migrationBuilder.DropTable(
                name: "TaskProjectList");

            migrationBuilder.DropTable(
                name: "TaskTickets");
        }
    }
}
