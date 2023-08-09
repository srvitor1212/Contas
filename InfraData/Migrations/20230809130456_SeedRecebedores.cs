using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfraData.Migrations
{
    /// <inheritdoc />
    public partial class SeedRecebedores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            DateTime agora = DateTime.Now;
            string mes, dia, hora, minuto, segundo;
            mes = NormalizeDateTime(agora.Month);
            dia = NormalizeDateTime(agora.Day);
            hora = NormalizeDateTime(agora.Hour);
            minuto = NormalizeDateTime(agora.Minute);
            segundo = NormalizeDateTime(agora.Second);

            string strAgora = (
                agora.Year + "-" +
                mes + "-" +
                dia + "T" +
                hora + ":" +
                minuto + ":" +
                segundo).ToString();

            //// Para permitir setar manualmente a coluna de identificação (PK ou IDENTITY_INSERT)
            //migrationBuilder.Sql(
            //    "SET IDENTITY_INSERT Recebedores ON");

            migrationBuilder.Sql(
                "INSERT INTO Recebedores(Id, DataCriacao, DataAtualizacao, Nome)" +
                "VALUES (1, '" + strAgora + "', '" + strAgora + "', 'Não informado')");

            //// Voltar para OFF por padrão
            //migrationBuilder.Sql(
            //    "SET IDENTITY_INSERT Recebedores OFF");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Recebedores");
        }

        private string NormalizeDateTime(int valor)
        {
            string ret = "";
            if (valor < 10)
                ret = "0" + valor.ToString();
            else
                ret = valor.ToString();

            return ret;
        }
    }
}
