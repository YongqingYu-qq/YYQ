using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication_Core_mvc.Migrations
{
    public partial class vdfs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consignment",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    Deleted = table.Column<bool>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Services = table.Column<string>(nullable: true),
                    CustomerReference = table.Column<string>(nullable: true),
                    ConsignmentNote = table.Column<string>(nullable: true),
                    TotalPieces = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consignment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsignmentLine",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Length = table.Column<decimal>(nullable: true),
                    Width = table.Column<decimal>(nullable: true),
                    Height = table.Column<decimal>(nullable: true),
                    Volume = table.Column<decimal>(nullable: true),
                    Pieces = table.Column<int>(nullable: true),
                    Weigth = table.Column<decimal>(nullable: true),
                    DangerousGoods = table.Column<bool>(nullable: true),
                    DgClass = table.Column<string>(nullable: true),
                    UnNumber = table.Column<string>(nullable: true),
                    ConsignmentId = table.Column<Guid>(nullable: true),
                    ItemId = table.Column<Guid>(nullable: true),
                    CommodityId = table.Column<Guid>(nullable: true),
                    Deleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsignmentLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsignmentLine_Consignment_ConsignmentId",
                        column: x => x.ConsignmentId,
                        principalTable: "Consignment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConsignmentLine_ConsignmentId",
                table: "ConsignmentLine",
                column: "ConsignmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsignmentLine");

            migrationBuilder.DropTable(
                name: "Consignment");
        }
    }
}
