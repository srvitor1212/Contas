using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfraData.Migrations
{
    /// <inheritdoc />
    public partial class SeedPagamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            DateTime agora = DateTime.Now;
            string strAgora = agora.ToString();
            //todo: seed

            migrationBuilder.Sql(
                "INSERT INTO Pagamentos(Id, DataCriacao, DataAtualizacao, Nome)" +
                "VALUES (1, '" + strAgora + "', '" + strAgora + "', 'Dinheiro')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
