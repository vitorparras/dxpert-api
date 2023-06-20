using Domain.Model;
using Domain.Model.Dados;
using Microsoft.EntityFrameworkCore;

namespace Context
{

    public class DxContext : DbContext
    {
        public DxContext(DbContextOptions<DxContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var conexao = "Server=localhost;User Id=root;Password=;Database=apiDxpert";
                optionsBuilder
                  .UseMySql(conexao, ServerVersion.AutoDetect(conexao))
                  .EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<AuthToken> AuthToken { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Cadastro> Cadastros { get; set; }
        public DbSet<Beneficiarios> Beneficiarios { get; set; }
        public DbSet<VidaInteiraConjuge> VidaInteiraConjuge { get; set; }
        public DbSet<VidaInteira> VidaInteira { get; set; }
        public DbSet<TermLife> TermLife { get; set; }
        public DbSet<TaxaPrevcom> TaxaPrevcom { get; set; }
        public DbSet<SafSuperLuxo> SafSuperLuxo { get; set; }
        public DbSet<SafLuxo> SafLuxo { get; set; }
        public DbSet<RendaInvalidez> RendaInvalidez { get; set; }
        public DbSet<PrazoCerto> PrazoCerto { get; set; }
        public DbSet<PensaoPorMorte> PensaoPorMorte { get; set; }
        public DbSet<MortePorAcidente> MortePorAcidente { get; set; }
        public DbSet<InvalidezTotalAcidente> InvalidezTotalAcidente { get; set; }
        public DbSet<InvalidezAcidenteMajoradaDoenca> InvalidezAcidenteMajoradaDoenca { get; set; }
        public DbSet<InvalidezAcidenteMajorada> InvalidezAcidenteMajorada { get; set; }
        public DbSet<DoencasGravesMaster> DoencasGravesMaster { get; set; }
        public DbSet<DoencasGraves> DoencasGraves { get; set; }
        public DbSet<DitMedicos> DitMedicos { get; set; }
        public DbSet<DiariaInternacaoHospitalar> DiariaInternacaoHospitalar { get; set; }
        public DbSet<DiariaIncapacidadeTemporariaAcidente> DiariaIncapacidadeTemporariaAcidente { get; set; }
        public DbSet<AdicionalDiariaInternacaoHospitalar> AdicionalDiariaInternacaoHospitalar { get; set; }
        public DbSet<Configuracoes> Configuracoes { get; set; }
    }
}
