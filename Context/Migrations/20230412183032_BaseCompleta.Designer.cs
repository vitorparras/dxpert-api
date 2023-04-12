﻿// <auto-generated />
using System;
using Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Context.Migrations
{
    [DbContext(typeof(DxContext))]
    [Migration("20230412183032_BaseCompleta")]
    partial class BaseCompleta
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Model.Beneficiarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CadastroId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DataNasc")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Beneficiarios");
                });

            modelBuilder.Entity("Domain.Model.Cadastro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AnosContribuicao")
                        .HasColumnType("longtext");

                    b.Property<string>("Categoria")
                        .HasColumnType("longtext");

                    b.Property<string>("Celular")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataCasamento")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataNasc")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataNascConjuge")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DataPosse")
                        .HasColumnType("longtext");

                    b.Property<string>("DespesaMensal")
                        .HasColumnType("longtext");

                    b.Property<string>("EmpresaTrabalho")
                        .HasColumnType("longtext");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("longtext");

                    b.Property<string>("FilhosMaiores")
                        .HasColumnType("longtext");

                    b.Property<string>("Fuma")
                        .HasColumnType("longtext");

                    b.Property<string>("Fumante")
                        .HasColumnType("longtext");

                    b.Property<string>("HistoricoSeguradora")
                        .HasColumnType("longtext");

                    b.Property<string>("ImpostoDeRenda")
                        .HasColumnType("longtext");

                    b.Property<string>("MaiorPrioridade")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeConjuge")
                        .HasColumnType("longtext");

                    b.Property<string>("ObrigacoesFiscaisExterior")
                        .HasColumnType("longtext");

                    b.Property<string>("Ocupacao")
                        .HasColumnType("longtext");

                    b.Property<string>("PoliticamenteExposto")
                        .HasColumnType("longtext");

                    b.Property<string>("PossuiAlgumaAtividade")
                        .HasColumnType("longtext");

                    b.Property<string>("PossuiDeficiencia")
                        .HasColumnType("longtext");

                    b.Property<bool?>("PossuiFilhos")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("PresidenteNoBrasil")
                        .HasColumnType("longtext");

                    b.Property<string>("ProblemaSaude")
                        .HasColumnType("longtext");

                    b.Property<string>("ProblemasSaude")
                        .HasColumnType("longtext");

                    b.Property<string>("Profissao")
                        .HasColumnType("longtext");

                    b.Property<string>("QuantidadeFilhos")
                        .HasColumnType("longtext");

                    b.Property<string>("QuantidadeFilhosMaiores")
                        .HasColumnType("longtext");

                    b.Property<string>("QuantidadeSubstancia")
                        .HasColumnType("longtext");

                    b.Property<string>("RealizouCirurgia")
                        .HasColumnType("longtext");

                    b.Property<string>("RegimeContratacao")
                        .HasColumnType("longtext");

                    b.Property<string>("RendaBruta")
                        .HasColumnType("longtext");

                    b.Property<string>("ReservaEmergencia")
                        .HasColumnType("longtext");

                    b.Property<string>("Sexo")
                        .HasColumnType("longtext");

                    b.Property<string>("SofreDoencas")
                        .HasColumnType("longtext");

                    b.Property<string>("TempoReserva")
                        .HasColumnType("longtext");

                    b.Property<string>("TipoSubstancia")
                        .HasColumnType("longtext");

                    b.Property<string>("TomaRemedio")
                        .HasColumnType("longtext");

                    b.Property<string>("TotalAplicacoesFinanceiros")
                        .HasColumnType("longtext");

                    b.Property<string>("TotalImoveis")
                        .HasColumnType("longtext");

                    b.Property<string>("TotalVeiculos")
                        .HasColumnType("longtext");

                    b.Property<string>("UsoMedicamento")
                        .HasColumnType("longtext");

                    b.Property<string>("ViagemInternacional")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cadastros");
                });

            modelBuilder.Entity("Domain.Model.Dados.AdicionalDiariaInternacaoHospitalar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Valor")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("AdicionalDiariaInternacaoHospitalar");
                });

            modelBuilder.Entity("Domain.Model.Dados.DiariaIncapacidadeTemporariaAcidente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("I13a30")
                        .HasColumnType("longtext");

                    b.Property<string>("I31a35")
                        .HasColumnType("longtext");

                    b.Property<string>("I36a40")
                        .HasColumnType("longtext");

                    b.Property<string>("I41a45")
                        .HasColumnType("longtext");

                    b.Property<string>("I46a50")
                        .HasColumnType("longtext");

                    b.Property<string>("I51a55")
                        .HasColumnType("longtext");

                    b.Property<string>("I56a60")
                        .HasColumnType("longtext");

                    b.Property<string>("I61a65")
                        .HasColumnType("longtext");

                    b.Property<string>("InvalidezAcidentalMajorada")
                        .HasColumnType("longtext");

                    b.Property<string>("MorteAcidental")
                        .HasColumnType("longtext");

                    b.Property<string>("RendaMensal")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DiariaIncapacidadeTemporariaAcidente");
                });

            modelBuilder.Entity("Domain.Model.Dados.DiariaInternacaoHospitalar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("T150")
                        .HasColumnType("longtext");

                    b.Property<string>("T200")
                        .HasColumnType("longtext");

                    b.Property<string>("T250")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DiariaInternacaoHospitalar");
                });

            modelBuilder.Entity("Domain.Model.Dados.DitMedicos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("V1")
                        .HasColumnType("longtext");

                    b.Property<string>("V10")
                        .HasColumnType("longtext");

                    b.Property<string>("V11")
                        .HasColumnType("longtext");

                    b.Property<string>("V12")
                        .HasColumnType("longtext");

                    b.Property<string>("V13")
                        .HasColumnType("longtext");

                    b.Property<string>("V14")
                        .HasColumnType("longtext");

                    b.Property<string>("V15")
                        .HasColumnType("longtext");

                    b.Property<string>("V16")
                        .HasColumnType("longtext");

                    b.Property<string>("V17")
                        .HasColumnType("longtext");

                    b.Property<string>("V18")
                        .HasColumnType("longtext");

                    b.Property<string>("V19")
                        .HasColumnType("longtext");

                    b.Property<string>("V2")
                        .HasColumnType("longtext");

                    b.Property<string>("V20")
                        .HasColumnType("longtext");

                    b.Property<string>("V21")
                        .HasColumnType("longtext");

                    b.Property<string>("V22")
                        .HasColumnType("longtext");

                    b.Property<string>("V23")
                        .HasColumnType("longtext");

                    b.Property<string>("V24")
                        .HasColumnType("longtext");

                    b.Property<string>("V25")
                        .HasColumnType("longtext");

                    b.Property<string>("V26")
                        .HasColumnType("longtext");

                    b.Property<string>("V27")
                        .HasColumnType("longtext");

                    b.Property<string>("V28")
                        .HasColumnType("longtext");

                    b.Property<string>("V29")
                        .HasColumnType("longtext");

                    b.Property<string>("V3")
                        .HasColumnType("longtext");

                    b.Property<string>("V30")
                        .HasColumnType("longtext");

                    b.Property<string>("V4")
                        .HasColumnType("longtext");

                    b.Property<string>("V5")
                        .HasColumnType("longtext");

                    b.Property<string>("V6")
                        .HasColumnType("longtext");

                    b.Property<string>("V7")
                        .HasColumnType("longtext");

                    b.Property<string>("V8")
                        .HasColumnType("longtext");

                    b.Property<string>("V9")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DitMedicos");
                });

            modelBuilder.Entity("Domain.Model.Dados.DoencasGraves", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Essencial")
                        .HasColumnType("longtext");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Plus")
                        .HasColumnType("longtext");

                    b.Property<string>("Premium")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DoencasGraves");
                });

            modelBuilder.Entity("Domain.Model.Dados.DoencasGravesMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Valor")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DoencasGravesMaster");
                });

            modelBuilder.Entity("Domain.Model.Dados.InvalidezAcidenteMajorada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Valor")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("InvalidezAcidenteMajorada");
                });

            modelBuilder.Entity("Domain.Model.Dados.InvalidezAcidenteMajoradaDoenca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Valor")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("InvalidezAcidenteMajoradaDoenca");
                });

            modelBuilder.Entity("Domain.Model.Dados.InvalidezTotalAcidente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Valor")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("InvalidezTotalAcidente");
                });

            modelBuilder.Entity("Domain.Model.Dados.MortePorAcidente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Valor")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("MortePorAcidente");
                });

            modelBuilder.Entity("Domain.Model.Dados.PensaoPorMorte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("I10")
                        .HasColumnType("longtext");

                    b.Property<string>("I15")
                        .HasColumnType("longtext");

                    b.Property<string>("I20")
                        .HasColumnType("longtext");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PensaoPorMorte");
                });

            modelBuilder.Entity("Domain.Model.Dados.PrazoCerto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("I10")
                        .HasColumnType("longtext");

                    b.Property<string>("I15")
                        .HasColumnType("longtext");

                    b.Property<string>("I20")
                        .HasColumnType("longtext");

                    b.Property<string>("I5")
                        .HasColumnType("longtext");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PrazoCerto");
                });

            modelBuilder.Entity("Domain.Model.Dados.RendaInvalidez", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("I20")
                        .HasColumnType("longtext");

                    b.Property<string>("I30")
                        .HasColumnType("longtext");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RendaInvalidez");
                });

            modelBuilder.Entity("Domain.Model.Dados.SafLuxo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Familiar")
                        .HasColumnType("longtext");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Individual")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("SafLuxo");
                });

            modelBuilder.Entity("Domain.Model.Dados.SafSuperLuxo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Familiar")
                        .HasColumnType("longtext");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Individual")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("SafSuperLuxo");
                });

            modelBuilder.Entity("Domain.Model.Dados.TaxaPrevcom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Invalidez")
                        .HasColumnType("longtext");

                    b.Property<string>("Morte")
                        .HasColumnType("longtext");

                    b.Property<string>("PercentualReajusteInvalidez")
                        .HasColumnType("longtext");

                    b.Property<string>("PercentualReajusteMorte")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TaxaPrevcom");
                });

            modelBuilder.Entity("Domain.Model.Dados.TermLife", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Feminino10")
                        .HasColumnType("longtext");

                    b.Property<string>("Feminino15")
                        .HasColumnType("longtext");

                    b.Property<string>("Feminino20")
                        .HasColumnType("longtext");

                    b.Property<string>("Feminino25")
                        .HasColumnType("longtext");

                    b.Property<string>("Feminino30")
                        .HasColumnType("longtext");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Masculino10")
                        .HasColumnType("longtext");

                    b.Property<string>("Masculino15")
                        .HasColumnType("longtext");

                    b.Property<string>("Masculino20")
                        .HasColumnType("longtext");

                    b.Property<string>("Masculino25")
                        .HasColumnType("longtext");

                    b.Property<string>("Masculino30")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TermLife");
                });

            modelBuilder.Entity("Domain.Model.Dados.VidaInteira", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Homem")
                        .HasColumnType("longtext");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Mulher")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("VidaInteira");
                });

            modelBuilder.Entity("Domain.Model.Dados.VidaInteiraConjuge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Homem")
                        .HasColumnType("longtext");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Mulher")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("VidaInteiraConjuge");
                });

            modelBuilder.Entity("Domain.Model.Documento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CadastroId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataExpedicao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext");

                    b.Property<string>("OrgaoExpedidor")
                        .HasColumnType("longtext");

                    b.Property<string>("Tipo")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Documentos");
                });

            modelBuilder.Entity("Domain.Model.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .HasColumnType("longtext");

                    b.Property<int>("CadastroId")
                        .HasColumnType("int");

                    b.Property<string>("Cep")
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext");

                    b.Property<string>("Complemento")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Logadouro")
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Domain.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DataAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<int>("Permissao")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
