using Domain.Model.Dados;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Context.Migrations
{
    /// <inheritdoc />
    public partial class InsertsIniciais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(DitMedico.GetQueryInsertBase());
            migrationBuilder.Sql(TaxaPrevcom.GetQueryInsertBase());
            migrationBuilder.Sql(VidaInteira.GetQueryInsertBase());
            migrationBuilder.Sql(VidaInteiraConjuge.GetQueryInsertBase());
            migrationBuilder.Sql(PrazoCerto.GetQueryInsertBase());
            migrationBuilder.Sql(MortePorAcidente.GetQueryInsertBase());
            migrationBuilder.Sql(PensaoPorMorte.GetQueryInsertBase());
            migrationBuilder.Sql(InvalidezAcidenteMajorada.GetQueryInsertBase());
            migrationBuilder.Sql(InvalidezAcidenteMajoradaDoenca.GetQueryInsertBase());
            migrationBuilder.Sql(InvalidezTotalAcidente.GetQueryInsertBase());
            migrationBuilder.Sql(RendaInvalidez.GetQueryInsertBase());
            migrationBuilder.Sql(DoencasGraves.GetQueryInsertBase());
            migrationBuilder.Sql(DoencasGravesMaster.GetQueryInsertBase());
            migrationBuilder.Sql(DiariaIncapacidadeTemporariaAcidente.GetQueryInsertBase());
            migrationBuilder.Sql(DiariaInternacaoHospitalar.GetQueryInsertBase());
            migrationBuilder.Sql(AdicionalDiariaInternacaoHospitalar.GetQueryInsertBase());
            migrationBuilder.Sql(SafLuxo.GetQueryInsertBase());
            migrationBuilder.Sql(SafSuperLuxo.GetQueryInsertBase());
            migrationBuilder.Sql(TermLife.GetQueryInsertBase());
            migrationBuilder.Sql(SafSuperLuxoPorIdade.GetQueryInsertBase());
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
