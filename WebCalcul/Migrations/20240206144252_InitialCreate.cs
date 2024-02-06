using FirebirdSql.EntityFrameworkCore.Firebird.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebCalcul.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalculStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Fb:ValueGenerationStrategy", FbValueGenerationStrategy.IdentityColumn),
                    NumberA = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    NumberB = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    Operator = table.Column<string>(type: "VARCHAR(1)", nullable: false),
                    Result = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    OperatorActiveSign = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    ResultIterationSign = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    PercentageIterationSign = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    MemoryActiveSign = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    RewriteInputSign = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    SquareRootSign = table.Column<bool>(type: "BOOLEAN", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculStates", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalculStates");
        }
    }
}
