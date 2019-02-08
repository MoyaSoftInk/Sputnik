using Microsoft.EntityFrameworkCore;

namespace Agence.Domain.Entities
{
    public partial class AgenceDBContext : DbContext
    {
        public AgenceDBContext()
        {
        }

        public AgenceDBContext(DbContextOptions<AgenceDBContext> options)
            : base(options)
        {
        }

        #region DbSet

        public virtual DbSet<CaoAcompanhamentoSistema> CaoAcompanhamentoSistema { get; set; }
        public virtual DbSet<CaoAgendamento> CaoAgendamento { get; set; }
        public virtual DbSet<CaoArquiteturaOs> CaoArquiteturaOs { get; set; }
        public virtual DbSet<CaoAtividade> CaoAtividade { get; set; }
        public virtual DbSet<CaoAtividadeConsultor> CaoAtividadeConsultor { get; set; }
        public virtual DbSet<CaoAtividadeReport> CaoAtividadeReport { get; set; }
        public virtual DbSet<CaoAtividadeTeste> CaoAtividadeTeste { get; set; }
        public virtual DbSet<CaoAviso> CaoAviso { get; set; }
        public virtual DbSet<CaoBancoDeHoras> CaoBancoDeHoras { get; set; }
        public virtual DbSet<CaoBancoHoras> CaoBancoHoras { get; set; }
        public virtual DbSet<CaoBoleto> CaoBoleto { get; set; }
        public virtual DbSet<CaoBonus> CaoBonus { get; set; }
        public virtual DbSet<CaoBonusStatus> CaoBonusStatus { get; set; }
        public virtual DbSet<CaoCategoriasOmbudsman> CaoCategoriasOmbudsman { get; set; }
        public virtual DbSet<CaoCidade> CaoCidade { get; set; }
        public virtual DbSet<CaoCliente> CaoCliente { get; set; }
        public virtual DbSet<CaoClienteContato> CaoClienteContato { get; set; }
        public virtual DbSet<CaoComissao> CaoComissao { get; set; }
        public virtual DbSet<CaoComplemento> CaoComplemento { get; set; }
        public virtual DbSet<CaoConhecimentos> CaoConhecimentos { get; set; }
        public virtual DbSet<CaoConhecimentosFontes> CaoConhecimentosFontes { get; set; }
        public virtual DbSet<CaoConhecimentoUsuario> CaoConhecimentoUsuario { get; set; }
        public virtual DbSet<CaoCusto> CaoCusto { get; set; }
        public virtual DbSet<CaoDiaryReport> CaoDiaryReport { get; set; }
        public virtual DbSet<CaoDiaryReportConsultor> CaoDiaryReportConsultor { get; set; }
        public virtual DbSet<CaoDocumentacaoCasosUso> CaoDocumentacaoCasosUso { get; set; }
        public virtual DbSet<CaoDocumentacaoOutros> CaoDocumentacaoOutros { get; set; }
        public virtual DbSet<CaoDocumentacaoSistema> CaoDocumentacaoSistema { get; set; }
        public virtual DbSet<CaoDrAtivComp> CaoDrAtivComp { get; set; }
        public virtual DbSet<CaoEscalaRanking> CaoEscalaRanking { get; set; }
        public virtual DbSet<CaoEscritorio> CaoEscritorio { get; set; }
        public virtual DbSet<CaoFatura> CaoFatura { get; set; }
        public virtual DbSet<CaoFaturaPag> CaoFaturaPag { get; set; }
        public virtual DbSet<CaoFormacaoIdiomaUsuario> CaoFormacaoIdiomaUsuario { get; set; }
        public virtual DbSet<CaoFormacaoUsuario> CaoFormacaoUsuario { get; set; }
        public virtual DbSet<CaoHelpAutor> CaoHelpAutor { get; set; }
        public virtual DbSet<CaoHelpChamado> CaoHelpChamado { get; set; }
        public virtual DbSet<CaoHelpFilial> CaoHelpFilial { get; set; }
        public virtual DbSet<CaoHelpMotivoChamado> CaoHelpMotivoChamado { get; set; }
        public virtual DbSet<CaoHelpStatusChamado> CaoHelpStatusChamado { get; set; }
        public virtual DbSet<CaoHelpTelaChamado> CaoHelpTelaChamado { get; set; }
        public virtual DbSet<CaoHistOcorrenciasOs> CaoHistOcorrenciasOs { get; set; }
        public virtual DbSet<CaoLogChamado> CaoLogChamado { get; set; }
        public virtual DbSet<CaoMenu> CaoMenu { get; set; }
        public virtual DbSet<CaoMenuContador> CaoMenuContador { get; set; }
        public virtual DbSet<CaoMovimento> CaoMovimento { get; set; }
        public virtual DbSet<CaoMovimentoJustificativa> CaoMovimentoJustificativa { get; set; }
        public virtual DbSet<CaoMovimentoOs> CaoMovimentoOs { get; set; }
        public virtual DbSet<CaoNoticia> CaoNoticia { get; set; }
        public virtual DbSet<CaoObsCliente> CaoObsCliente { get; set; }
        public virtual DbSet<CaoObsSistema> CaoObsSistema { get; set; }
        public virtual DbSet<CaoOmbudsman> CaoOmbudsman { get; set; }
        public virtual DbSet<CaoOs> CaoOs { get; set; }
        public virtual DbSet<CaoOsAnalista> CaoOsAnalista { get; set; }
        public virtual DbSet<CaoOsChamado> CaoOsChamado { get; set; }
        public virtual DbSet<CaoOsDailyReport> CaoOsDailyReport { get; set; }
        public virtual DbSet<CaoOsEmail> CaoOsEmail { get; set; }
        public virtual DbSet<CaoOsFase> CaoOsFase { get; set; }
        public virtual DbSet<CaoOsItemMenu> CaoOsItemMenu { get; set; }
        public virtual DbSet<CaoOsObs> CaoOsObs { get; set; }
        public virtual DbSet<CaoOsObsChamado> CaoOsObsChamado { get; set; }
        public virtual DbSet<CaoOsPrazo> CaoOsPrazo { get; set; }
        public virtual DbSet<CaoOsStatus> CaoOsStatus { get; set; }
        public virtual DbSet<CaoPagamento> CaoPagamento { get; set; }
        public virtual DbSet<CaoParticipacaoFuncionario> CaoParticipacaoFuncionario { get; set; }
        public virtual DbSet<CaoPermissaoHoraExtra> CaoPermissaoHoraExtra { get; set; }
        public virtual DbSet<CaoPontosConhecimento> CaoPontosConhecimento { get; set; }
        public virtual DbSet<CaoRamo> CaoRamo { get; set; }
        public virtual DbSet<CaoRelEmailOs> CaoRelEmailOs { get; set; }
        public virtual DbSet<CaoSalario> CaoSalario { get; set; }
        public virtual DbSet<CaoServico> CaoServico { get; set; }
        public virtual DbSet<CaoSistema> CaoSistema { get; set; }
        public virtual DbSet<CaoSistemaObs> CaoSistemaObs { get; set; }
        public virtual DbSet<CaoStatusAgendamento> CaoStatusAgendamento { get; set; }
        public virtual DbSet<CaoStatusCliente> CaoStatusCliente { get; set; }
        public virtual DbSet<CaoStatusClienteComplemento> CaoStatusClienteComplemento { get; set; }
        public virtual DbSet<CaoStatusOs> CaoStatusOs { get; set; }
        public virtual DbSet<CaoTempImport> CaoTempImport { get; set; }
        public virtual DbSet<CaoTipoConhecimentoUsuario> CaoTipoConhecimentoUsuario { get; set; }
        public virtual DbSet<CaoTipoCusto> CaoTipoCusto { get; set; }
        public virtual DbSet<CaoTipoIdiomaUsuario> CaoTipoIdiomaUsuario { get; set; }
        public virtual DbSet<CaoTipoOmbudsman> CaoTipoOmbudsman { get; set; }
        public virtual DbSet<CaoTipoSistemaUsuario> CaoTipoSistemaUsuario { get; set; }
        public virtual DbSet<CaoUf> CaoUf { get; set; }
        public virtual DbSet<CaoUsuario> CaoUsuario { get; set; }
        public virtual DbSet<CaoUsuarioDtDisp> CaoUsuarioDtDisp { get; set; }
        public virtual DbSet<CaoValorDescanso> CaoValorDescanso { get; set; }
        public virtual DbSet<PermissaoSistema> PermissaoSistema { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }

        // Unable to generate entity type for table 'agence_db.cao_feriados'. Please see the warning messages.
        // Unable to generate entity type for table 'agence_db.cao_horario_almoco'. Please see the warning messages.
        // Unable to generate entity type for table 'agence_db.cao_permissao'. Please see the warning messages.
        // Unable to generate entity type for table 'agence_db.cao_salario_pag'. Please see the warning messages.

        #endregion
            

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CaoAcompanhamentoSistema>(entity =>
            {
                entity.HasKey(e => e.CoAcompanhamento);

                entity.ToTable("cao_acompanhamento_sistema", "agence_db");

                entity.Property(e => e.CoAcompanhamento).HasColumnName("co_acompanhamento");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .HasColumnName("senha")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaoAgendamento>(entity =>
            {
                entity.HasKey(e => e.CoAgendamento);

                entity.ToTable("cao_agendamento", "agence_db");

                entity.Property(e => e.CoAgendamento).HasColumnName("co_agendamento");

                entity.Property(e => e.CoComplemento).HasColumnName("co_complemento");

                entity.Property(e => e.CoDiaryReportConsultor).HasColumnName("co_diary_report_consultor");

                entity.Property(e => e.CoStatusAgendamento).HasColumnName("co_status_agendamento");

                entity.Property(e => e.DtHrFim)
                    .HasColumnName("dt_hr_fim")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DtHrInicio)
                    .HasColumnName("dt_hr_inicio")
                    .HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<CaoArquiteturaOs>(entity =>
            {
                entity.HasKey(e => e.CoArquitetura);

                entity.ToTable("cao_arquitetura_os", "agence_db");

                entity.Property(e => e.CoArquitetura)
                    .HasColumnName("co_arquitetura")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsArquitetura)
                    .IsRequired()
                    .HasColumnName("ds_arquitetura")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoAtividade>(entity =>
            {
                entity.HasKey(e => e.CoAtividade);

                entity.ToTable("cao_atividade", "agence_db");

                entity.Property(e => e.CoAtividade).HasColumnName("co_atividade");

                entity.Property(e => e.CoTipoUsuario).HasColumnName("co_tipo_usuario");

                entity.Property(e => e.DsAtividade)
                    .IsRequired()
                    .HasColumnName("ds_atividade")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoAtividadeConsultor>(entity =>
            {
                entity.HasKey(e => e.CoAtividade);

                entity.ToTable("cao_atividade_consultor", "agence_db");

                entity.Property(e => e.CoAtividade).HasColumnName("co_atividade");

                entity.Property(e => e.Ativo)
                    .HasColumnName("ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DsAtividade)
                    .IsRequired()
                    .HasColumnName("ds_atividade")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoAtividadeReport>(entity =>
            {
                entity.ToTable("cao_atividade_report", "agence_db");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Assunto)
                    .HasColumnName("assunto")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CoAtividade).HasColumnName("co_atividade");

                entity.Property(e => e.CoCliente).HasColumnName("co_cliente");

                entity.Property(e => e.CoFase)
                    .HasColumnName("co_fase")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoOs).HasColumnName("co_os");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Conteudo)
                    .HasColumnName("conteudo")
                    .IsUnicode(false);

                entity.Property(e => e.DataAtiv)
                    .HasColumnName("data_ativ")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Fim)
                    .HasColumnName("fim")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Inicio)
                    .HasColumnName("inicio")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Lembrete)
                    .HasColumnName("lembrete")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Retorno)
                    .IsRequired()
                    .HasColumnName("retorno")
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Tempo)
                    .HasColumnName("tempo")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaoAtividadeTeste>(entity =>
            {
                entity.HasKey(e => e.CoAtividade);

                entity.ToTable("cao_atividade_teste", "agence_db");

                entity.Property(e => e.CoAtividade).HasColumnName("co_atividade");

                entity.Property(e => e.CoTipoUsuario).HasColumnName("co_tipo_usuario");

                entity.Property(e => e.DsAtividade)
                    .IsRequired()
                    .HasColumnName("ds_atividade")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoAviso>(entity =>
            {
                entity.HasKey(e => e.CoAviso);

                entity.ToTable("cao_aviso", "agence_db");

                entity.Property(e => e.CoAviso).HasColumnName("co_aviso");

                entity.Property(e => e.DsAviso)
                    .IsRequired()
                    .HasColumnName("ds_aviso")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaoBancoDeHoras>(entity =>
            {
                entity.ToTable("cao_banco_de_horas", "agence_db");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DataCadastro)
                    .HasColumnName("data_cadastro")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Segundos).HasColumnName("segundos");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoBancoHoras>(entity =>
            {
                entity.HasKey(e => e.CoBancHoras);

                entity.ToTable("cao_banco_horas", "agence_db");

                entity.Property(e => e.CoBancHoras).HasColumnName("co_banc_horas");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.MinFerias).HasColumnName("min_ferias");

                entity.Property(e => e.MinMes).HasColumnName("min_mes");

                entity.Property(e => e.MinPago).HasColumnName("min_pago");

                entity.Property(e => e.MinTotal).HasColumnName("min_total");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("periodo")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoBoleto>(entity =>
            {
                entity.HasKey(e => e.CoBoleto);

                entity.ToTable("cao_boleto", "agence_db");

                entity.Property(e => e.CoBoleto).HasColumnName("co_boleto");

                entity.Property(e => e.Boleto)
                    .HasColumnName("boleto")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CoCliente).HasColumnName("co_cliente");

                entity.Property(e => e.CoOs).HasColumnName("co_os");

                entity.Property(e => e.CoSistema).HasColumnName("co_sistema");

                entity.Property(e => e.LinhaDig)
                    .HasColumnName("linha_dig")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Parcela)
                    .HasColumnName("parcela")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasColumnName("valor")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Vencimento)
                    .IsRequired()
                    .HasColumnName("vencimento")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoBonus>(entity =>
            {
                entity.HasKey(e => new { e.BonCategoria, e.BonInicio, e.BonFim });

                entity.ToTable("cao_bonus", "agence_db");

                entity.Property(e => e.BonCategoria).HasColumnName("bon_categoria");

                entity.Property(e => e.BonInicio).HasColumnName("bon_inicio");

                entity.Property(e => e.BonFim).HasColumnName("bon_fim");

                entity.Property(e => e.BonValorFimsem).HasColumnName("bon_valor_fimsem");

                entity.Property(e => e.BonValorSem).HasColumnName("bon_valor_sem");
            });

            modelBuilder.Entity<CaoBonusStatus>(entity =>
            {
                entity.ToTable("cao_bonus_status", "agence_db");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DataSolic)
                    .HasColumnName("data_solic")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsHoras)
                    .HasColumnName("is_horas")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsPg)
                    .HasColumnName("is_pg")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsSolic)
                    .HasColumnName("is_solic")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mes)
                    .IsRequired()
                    .HasColumnName("mes")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasColumnName("valor")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoCategoriasOmbudsman>(entity =>
            {
                entity.HasKey(e => e.Idcategoria);

                entity.ToTable("cao_categorias_ombudsman", "agence_db");

                entity.Property(e => e.Idcategoria).HasColumnName("idcategoria");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoCidade>(entity =>
            {
                entity.HasKey(e => e.CoCidade);

                entity.ToTable("cao_cidade", "agence_db");

                entity.Property(e => e.CoCidade).HasColumnName("co_cidade");

                entity.Property(e => e.CoUf).HasColumnName("co_uf");

                entity.Property(e => e.NoCidade)
                    .IsRequired()
                    .HasColumnName("no_cidade")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoCliente>(entity =>
            {
                entity.HasKey(e => e.CoCliente);

                entity.ToTable("cao_cliente", "agence_db");

                entity.Property(e => e.CoCliente).HasColumnName("co_cliente");

                entity.Property(e => e.CoCidade).HasColumnName("co_cidade");

                entity.Property(e => e.CoComplementoStatus).HasColumnName("co_complemento_status");

                entity.Property(e => e.CoRamo).HasColumnName("co_ramo");

                entity.Property(e => e.CoStatus).HasColumnName("co_status");

                entity.Property(e => e.Ddd2)
                    .HasColumnName("ddd2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DsCargoContato)
                    .HasColumnName("ds_cargo_contato")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsComplemento)
                    .HasColumnName("ds_complemento")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsEmail)
                    .HasColumnName("ds_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsEndereco)
                    .HasColumnName("ds_endereco")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsReferencia)
                    .HasColumnName("ds_referencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsSite)
                    .HasColumnName("ds_site")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoBairro)
                    .IsRequired()
                    .HasColumnName("no_bairro")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NoContato)
                    .HasColumnName("no_contato")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NoFantasia)
                    .HasColumnName("no_fantasia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoPais)
                    .HasColumnName("no_pais")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoRazao)
                    .HasColumnName("no_razao")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NuCep)
                    .HasColumnName("nu_cep")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NuCnpj)
                    .HasColumnName("nu_cnpj")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.NuFax)
                    .HasColumnName("nu_fax")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NuNumero).HasColumnName("nu_numero");

                entity.Property(e => e.NuRamal)
                    .HasColumnName("nu_ramal")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NuTelefone)
                    .HasColumnName("nu_telefone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone2)
                    .HasColumnName("telefone2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TpCliente)
                    .HasColumnName("tp_cliente")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaoClienteContato>(entity =>
            {
                entity.HasKey(e => e.CoCliente);

                entity.ToTable("cao_cliente_contato", "agence_db");

                entity.Property(e => e.CoCliente)
                    .HasColumnName("co_cliente")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtContato)
                    .HasColumnName("dt_contato")
                    .HasColumnType("date");

                entity.Property(e => e.FgAgendado)
                    .HasColumnName("fg_agendado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HrEnd)
                    .HasColumnName("hr_end")
                    .HasDefaultValueSql("('00:00:00')");

                entity.Property(e => e.HrIni)
                    .HasColumnName("hr_ini")
                    .HasDefaultValueSql("('00:00:00')");
            });

            modelBuilder.Entity<CaoComissao>(entity =>
            {
                entity.HasKey(e => e.CoComissao);

                entity.ToTable("cao_comissao", "agence_db");

                entity.HasIndex(e => e.CoFatura)
                    .HasName("cao_comissao$co_fatura")
                    .IsUnique();

                entity.Property(e => e.CoComissao).HasColumnName("co_comissao");

                entity.Property(e => e.CoFatura).HasColumnName("co_fatura");

                entity.Property(e => e.DtEfetuado)
                    .HasColumnName("dt_efetuado")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CaoComplemento>(entity =>
            {
                entity.HasKey(e => e.CoComplemento);

                entity.ToTable("cao_complemento", "agence_db");

                entity.Property(e => e.CoComplemento).HasColumnName("co_complemento");

                entity.Property(e => e.DsComplemento)
                    .HasColumnName("ds_complemento")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaoConhecimentos>(entity =>
            {
                entity.HasKey(e => e.Idconhecimento);

                entity.ToTable("cao_conhecimentos", "agence_db");

                entity.HasIndex(e => e.Usuario)
                    .HasName("usuario");

                entity.Property(e => e.Idconhecimento).HasColumnName("idconhecimento");

                entity.Property(e => e.Assunto)
                    .IsRequired()
                    .HasColumnName("assunto")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Conhecimento)
                    .IsRequired()
                    .HasColumnName("conhecimento")
                    .IsUnicode(false);

                entity.Property(e => e.Datahora)
                    .HasColumnName("datahora")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Tags)
                    .IsRequired()
                    .HasColumnName("tags")
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.UsuarioNavigation)
                    .WithMany(p => p.CaoConhecimentos)
                    .HasForeignKey(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_conhecimentos$cao_conhecimentos_ibfk_1");
            });

            modelBuilder.Entity<CaoConhecimentosFontes>(entity =>
            {
                entity.HasKey(e => e.Idfonte);

                entity.ToTable("cao_conhecimentos_fontes", "agence_db");

                entity.HasIndex(e => e.Idconhecimento)
                    .HasName("idconhecimento");

                entity.Property(e => e.Idfonte).HasColumnName("idfonte");

                entity.Property(e => e.Arquivo)
                    .IsRequired()
                    .HasColumnName("arquivo")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Caminho)
                    .IsRequired()
                    .HasColumnName("caminho")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Datahora)
                    .HasColumnName("datahora")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Idconhecimento).HasColumnName("idconhecimento");

                entity.HasOne(d => d.IdconhecimentoNavigation)
                    .WithMany(p => p.CaoConhecimentosFontes)
                    .HasForeignKey(d => d.Idconhecimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_conhecimentos_fontes$cao_conhecimentos_fontes_ibfk_1");
            });

            modelBuilder.Entity<CaoConhecimentoUsuario>(entity =>
            {
                entity.HasKey(e => new { e.CoUsuario, e.CoConhecimento });

                entity.ToTable("cao_conhecimento_usuario", "agence_db");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CoConhecimento).HasColumnName("co_conhecimento");

                entity.Property(e => e.IsCertificado).HasColumnName("is_certificado");

                entity.Property(e => e.NvConhecimento).HasColumnName("nv_conhecimento");
            });

            modelBuilder.Entity<CaoCusto>(entity =>
            {
                entity.HasKey(e => e.CoCusto);

                entity.ToTable("cao_custo", "agence_db");

                entity.Property(e => e.CoCusto)
                    .HasColumnName("co_custo")
                    .HasColumnType("numeric(20, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CoBoleto)
                    .HasColumnName("co_boleto")
                    .IsUnicode(false);

                entity.Property(e => e.CoCustoHigh)
                    .HasColumnName("co_custo_high")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.CoEscritorio).HasColumnName("co_escritorio");

                entity.Property(e => e.CoTipoCusto).HasColumnName("co_tipo_custo");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.DtCompra)
                    .HasColumnName("dt_compra")
                    .HasColumnType("date");

                entity.Property(e => e.DtPagamento)
                    .HasColumnName("dt_pagamento")
                    .HasColumnType("date");

                entity.Property(e => e.Pag).HasColumnName("pag");

                entity.Property(e => e.Parcela)
                    .HasColumnName("parcela")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnName("valor");
            });

            modelBuilder.Entity<CaoDiaryReport>(entity =>
            {
                entity.HasKey(e => e.CoDiaryReport);

                entity.ToTable("cao_diary_report", "agence_db");

                entity.Property(e => e.CoDiaryReport).HasColumnName("co_diary_report");

                entity.Property(e => e.CoAtividade).HasColumnName("co_atividade");

                entity.Property(e => e.CoMovimento).HasColumnName("co_movimento");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.DsAssunto)
                    .IsRequired()
                    .HasColumnName("ds_assunto")
                    .IsUnicode(false);

                entity.Property(e => e.HrGasta)
                    .HasColumnName("hr_gasta")
                    .HasDefaultValueSql("('00:00:00')");

                entity.Property(e => e.NuOs)
                    .HasColumnName("nu_os")
                    .HasColumnType("numeric(20, 0)");
            });

            modelBuilder.Entity<CaoDiaryReportConsultor>(entity =>
            {
                entity.HasKey(e => e.CoDiaryReportConsultor);

                entity.ToTable("cao_diary_report_consultor", "agence_db");

                entity.Property(e => e.CoDiaryReportConsultor).HasColumnName("co_diary_report_consultor");

                entity.Property(e => e.CoAtividade).HasColumnName("co_atividade");

                entity.Property(e => e.CoCliente).HasColumnName("co_cliente");

                entity.Property(e => e.CoMovimento).HasColumnName("co_movimento");

                entity.Property(e => e.DsAssunto)
                    .IsRequired()
                    .HasColumnName("ds_assunto")
                    .IsUnicode(false);

                entity.Property(e => e.DsEmpresa)
                    .IsRequired()
                    .HasColumnName("ds_empresa")
                    .IsUnicode(false);

                entity.Property(e => e.DtAgendamento)
                    .HasColumnName("dt_agendamento")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DtAgendamentoFim)
                    .HasColumnName("dt_agendamento_fim")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.VlFechamento).HasColumnName("vl_fechamento");
            });

            modelBuilder.Entity<CaoDocumentacaoCasosUso>(entity =>
            {
                entity.ToTable("cao_documentacao_casos_uso", "agence_db");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CoSistema).HasColumnName("co_sistema");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoDocumentacaoOutros>(entity =>
            {
                entity.ToTable("cao_documentacao_outros", "agence_db");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CoSistema).HasColumnName("co_sistema");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoDocumentacaoSistema>(entity =>
            {
                entity.ToTable("cao_documentacao_sistema", "agence_db");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Arquivo)
                    .IsRequired()
                    .HasColumnName("arquivo")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CoSistema).HasColumnName("co_sistema");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .IsUnicode(false);

                entity.Property(e => e.DtDoc)
                    .HasColumnName("dt_doc")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Pasta)
                    .IsRequired()
                    .HasColumnName("pasta")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SubGrupo).HasColumnName("sub_grupo");
            });

            modelBuilder.Entity<CaoDrAtivComp>(entity =>
            {
                entity.HasKey(e => e.IdAtivComp);

                entity.ToTable("cao_dr_ativ_comp", "agence_db");

                entity.HasIndex(e => e.CoUsuario)
                    .HasName("co_usuario");

                entity.Property(e => e.IdAtivComp).HasColumnName("id_ativ_comp");

                entity.Property(e => e.Assunto)
                    .IsRequired()
                    .HasColumnName("assunto")
                    .IsUnicode(false);

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TempoGasto)
                    .HasColumnName("tempo_gasto")
                    .HasDefaultValueSql("('00:00:00')");
            });

            modelBuilder.Entity<CaoEscalaRanking>(entity =>
            {
                entity.HasKey(e => e.Idescala);

                entity.ToTable("cao_escala_ranking", "agence_db");

                entity.Property(e => e.Idescala).HasColumnName("idescala");

                entity.Property(e => e.Pontuacao).HasColumnName("pontuacao");

                entity.Property(e => e.QtdVisual).HasColumnName("qtd_visual");
            });

            modelBuilder.Entity<CaoEscritorio>(entity =>
            {
                entity.HasKey(e => e.CoEscritorio);

                entity.ToTable("cao_escritorio", "agence_db");

                entity.Property(e => e.CoEscritorio)
                    .HasColumnName("co_escritorio")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Local)
                    .IsRequired()
                    .HasColumnName("local")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoFatura>(entity =>
            {
                entity.HasKey(e => e.CoFatura);

                entity.ToTable("cao_fatura", "agence_db");

                entity.Property(e => e.CoFatura).HasColumnName("co_fatura");

                entity.Property(e => e.CoCliente).HasColumnName("co_cliente");

                entity.Property(e => e.CoOs).HasColumnName("co_os");

                entity.Property(e => e.CoSistema).HasColumnName("co_sistema");

                entity.Property(e => e.ComissaoCn).HasColumnName("comissao_cn");

                entity.Property(e => e.CorpoNf)
                    .IsRequired()
                    .HasColumnName("corpo_nf")
                    .IsUnicode(false);

                entity.Property(e => e.DataEmissao)
                    .HasColumnName("data_emissao")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NumNf).HasColumnName("num_nf");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.TotalImpInc).HasColumnName("total_imp_inc");

                entity.Property(e => e.Valor).HasColumnName("valor");
            });

            modelBuilder.Entity<CaoFaturaPag>(entity =>
            {
                entity.HasKey(e => e.IdFaturaPag);

                entity.ToTable("cao_fatura_pag", "agence_db");

                entity.HasIndex(e => e.CoFatura)
                    .HasName("cao_fatura_pag$co_fatura")
                    .IsUnique();

                entity.Property(e => e.IdFaturaPag).HasColumnName("id_fatura_pag");

                entity.Property(e => e.CoFatura).HasColumnName("co_fatura");

                entity.Property(e => e.DtEfetuado)
                    .HasColumnName("dt_efetuado")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ValorPago).HasColumnName("valor_pago");
            });

            modelBuilder.Entity<CaoFormacaoIdiomaUsuario>(entity =>
            {
                entity.HasKey(e => new { e.CoUsuario, e.CoIdioma });

                entity.ToTable("cao_formacao_idioma_usuario", "agence_db");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CoIdioma).HasColumnName("co_idioma");

                entity.Property(e => e.NvEscrita).HasColumnName("nv_escrita");

                entity.Property(e => e.NvFala).HasColumnName("nv_fala");

                entity.Property(e => e.NvLeitura).HasColumnName("nv_leitura");
            });

            modelBuilder.Entity<CaoFormacaoUsuario>(entity =>
            {
                entity.HasKey(e => new { e.CoUsuario, e.TpCurso });

                entity.ToTable("cao_formacao_usuario", "agence_db");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TpCurso)
                    .HasColumnName("tp_curso")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DsCurso)
                    .HasColumnName("ds_curso")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsInstituicao)
                    .HasColumnName("ds_instituicao")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DtConclusao)
                    .HasColumnName("dt_conclusao")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<CaoHelpAutor>(entity =>
            {
                entity.HasKey(e => e.CoAutor);

                entity.ToTable("cao_help_autor", "agence_db");

                entity.HasIndex(e => e.CoAutor)
                    .HasName("co_autor");

                entity.Property(e => e.CoAutor).HasColumnName("co_autor");

                entity.Property(e => e.CoFilial).HasColumnName("co_filial");

                entity.Property(e => e.DsEmail)
                    .HasColumnName("ds_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsFuncao)
                    .IsRequired()
                    .HasColumnName("ds_funcao")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NoAutor)
                    .IsRequired()
                    .HasColumnName("no_autor")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.NuDdd1)
                    .HasColumnName("nu_ddd1")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NuDdd2)
                    .HasColumnName("nu_ddd2")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NuRamal1)
                    .HasColumnName("nu_ramal1")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NuRamal2)
                    .HasColumnName("nu_ramal2")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NuTel1)
                    .HasColumnName("nu_tel1")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NuTel2)
                    .HasColumnName("nu_tel2")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaoHelpChamado>(entity =>
            {
                entity.HasKey(e => e.CoChamado);

                entity.ToTable("cao_help_chamado", "agence_db");

                entity.HasIndex(e => e.CoChamado)
                    .HasName("co_chamado");

                entity.Property(e => e.CoChamado).HasColumnName("co_chamado");

                entity.Property(e => e.CoAutor).HasColumnName("co_autor");

                entity.Property(e => e.CoFilial).HasColumnName("co_filial");

                entity.Property(e => e.CoMotivo).HasColumnName("co_motivo");

                entity.Property(e => e.CoSistema).HasColumnName("co_sistema");

                entity.Property(e => e.CoStatus).HasColumnName("co_status");

                entity.Property(e => e.CoTela).HasColumnName("co_tela");

                entity.Property(e => e.DsChamado)
                    .IsRequired()
                    .HasColumnName("ds_chamado")
                    .IsUnicode(false);

                entity.Property(e => e.DsSolucao)
                    .HasColumnName("ds_solucao")
                    .IsUnicode(false);

                entity.Property(e => e.DtChamado)
                    .HasColumnName("dt_chamado")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtSolucao)
                    .HasColumnName("dt_solucao")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<CaoHelpFilial>(entity =>
            {
                entity.HasKey(e => e.CoFilial);

                entity.ToTable("cao_help_filial", "agence_db");

                entity.HasIndex(e => e.CoFilial)
                    .HasName("filialId");

                entity.Property(e => e.CoFilial).HasColumnName("co_filial");

                entity.Property(e => e.CoCliente).HasColumnName("co_cliente");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NoFilial)
                    .IsRequired()
                    .HasColumnName("no_filial")
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoHelpMotivoChamado>(entity =>
            {
                entity.HasKey(e => e.CoMotivo);

                entity.ToTable("cao_help_motivo_chamado", "agence_db");

                entity.HasIndex(e => e.CoMotivo)
                    .HasName("co_motivo_2");

                entity.Property(e => e.CoMotivo).HasColumnName("co_motivo");

                entity.Property(e => e.DsMotivo)
                    .IsRequired()
                    .HasColumnName("ds_motivo")
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'0')");
            });

            modelBuilder.Entity<CaoHelpStatusChamado>(entity =>
            {
                entity.HasKey(e => e.CoStatus);

                entity.ToTable("cao_help_status_chamado", "agence_db");

                entity.HasIndex(e => e.CoStatus)
                    .HasName("co_status_2");

                entity.Property(e => e.CoStatus).HasColumnName("co_status");

                entity.Property(e => e.DsStatus)
                    .IsRequired()
                    .HasColumnName("ds_status")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'0')");
            });

            modelBuilder.Entity<CaoHelpTelaChamado>(entity =>
            {
                entity.HasKey(e => e.CoTela);

                entity.ToTable("cao_help_tela_chamado", "agence_db");

                entity.Property(e => e.CoTela).HasColumnName("co_tela");

                entity.Property(e => e.CoCliente).HasColumnName("co_cliente");

                entity.Property(e => e.CoSistema).HasColumnName("co_sistema");

                entity.Property(e => e.DsTela)
                    .IsRequired()
                    .HasColumnName("ds_tela")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoHistOcorrenciasOs>(entity =>
            {
                entity.HasKey(e => e.Idocorrencia);

                entity.ToTable("cao_hist_ocorrencias_os", "agence_db");

                entity.HasIndex(e => e.CoOs)
                    .HasName("co_os");

                entity.HasIndex(e => e.CoUsuario)
                    .HasName("co_usuario");

                entity.Property(e => e.Idocorrencia).HasColumnName("idocorrencia");

                entity.Property(e => e.CoOs).HasColumnName("co_os");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DataFechamento)
                    .HasColumnName("data_fechamento")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .IsUnicode(false);

                entity.Property(e => e.Responsavel)
                    .IsRequired()
                    .HasColumnName("responsavel")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'Interna')");

                entity.HasOne(d => d.CoOsNavigation)
                    .WithMany(p => p.CaoHistOcorrenciasOs)
                    .HasForeignKey(d => d.CoOs)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("cao_hist_ocorrencias_os$cao_hist_ocorrencias_os_ibfk_2");

                entity.HasOne(d => d.CoUsuarioNavigation)
                    .WithMany(p => p.CaoHistOcorrenciasOs)
                    .HasForeignKey(d => d.CoUsuario)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("cao_hist_ocorrencias_os$cao_hist_ocorrencias_os_ibfk_1");
            });

            modelBuilder.Entity<CaoLogChamado>(entity =>
            {
                entity.ToTable("cao_log_chamado", "agence_db");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CoChamado).HasColumnName("co_chamado");

                entity.Property(e => e.CoDaily).HasColumnName("co_daily");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DtChamado)
                    .HasColumnName("dt_chamado")
                    .HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<CaoMenu>(entity =>
            {
                entity.HasKey(e => e.CoMenu);

                entity.ToTable("cao_menu", "agence_db");

                entity.Property(e => e.CoMenu)
                    .HasColumnName("co_menu")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DsImagem)
                    .HasColumnName("ds_imagem")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsMenu)
                    .IsRequired()
                    .HasColumnName("ds_menu")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DsPagina)
                    .IsRequired()
                    .HasColumnName("ds_pagina")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoMenuContador>(entity =>
            {
                entity.HasKey(e => new { e.CoUsuario, e.CoMenu });

                entity.ToTable("cao_menu_contador", "agence_db");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CoMenu).HasColumnName("co_menu");

                entity.Property(e => e.InProcessado).HasColumnName("in_processado");

                entity.Property(e => e.NuPontos).HasColumnName("nu_pontos");
            });

            modelBuilder.Entity<CaoMovimento>(entity =>
            {
                entity.HasKey(e => e.CoMovimento);

                entity.ToTable("cao_movimento", "agence_db");

                entity.HasIndex(e => e.CoMovimento)
                    .HasName("co_movimento");

                entity.Property(e => e.CoMovimento)
                    .HasColumnName("co_movimento")
                    .HasColumnType("numeric(20, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DtEntrada)
                    .HasColumnName("dt_entrada")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DtSaida)
                    .HasColumnName("dt_saida")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DtSaidaAlmoco)
                    .HasColumnName("dt_saida_almoco")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DtVoltaAlmoco)
                    .HasColumnName("dt_volta_almoco")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.IsEncerrado).HasColumnName("is_encerrado");
            });

            modelBuilder.Entity<CaoMovimentoJustificativa>(entity =>
            {
                entity.HasKey(e => e.CoMovimentoJustificativa);

                entity.ToTable("cao_movimento_justificativa", "agence_db");

                entity.HasIndex(e => e.CoMovimentoJustificativa)
                    .HasName("co_movimento_justificativa");

                entity.Property(e => e.CoMovimentoJustificativa)
                    .HasColumnName("co_movimento_justificativa")
                    .HasColumnType("numeric(20, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CoMovimento)
                    .HasColumnName("co_movimento")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.DsJustificativa)
                    .IsRequired()
                    .HasColumnName("ds_justificativa")
                    .IsUnicode(false);

                entity.Property(e => e.NuOs)
                    .HasColumnName("nu_os")
                    .HasColumnType("numeric(20, 0)");
            });

            modelBuilder.Entity<CaoMovimentoOs>(entity =>
            {
                entity.HasKey(e => e.CoMovimentoOs);

                entity.ToTable("cao_movimento_os", "agence_db");

                entity.Property(e => e.CoMovimentoOs).HasColumnName("co_movimento_os");

                entity.Property(e => e.CoSistema).HasColumnName("co_sistema");

                entity.Property(e => e.CoTipoMovimento).HasColumnName("co_tipo_movimento");

                entity.Property(e => e.DsValor)
                    .HasColumnName("ds_valor")
                    .IsUnicode(false);

                entity.Property(e => e.DtFim)
                    .HasColumnName("dt_fim")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DtIni)
                    .HasColumnName("dt_ini")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.NuOs).HasColumnName("nu_os");

                entity.Property(e => e.NuValor).HasColumnName("nu_valor");

                entity.Property(e => e.UsuarioObs)
                    .HasColumnName("usuario_obs")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaoNoticia>(entity =>
            {
                entity.HasKey(e => e.CoNoticia);

                entity.ToTable("cao_noticia", "agence_db");

                entity.Property(e => e.CoNoticia).HasColumnName("co_noticia");

                entity.Property(e => e.Assunto)
                    .IsRequired()
                    .HasColumnName("assunto")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .IsUnicode(false);

                entity.Property(e => e.DtNoticia)
                    .HasColumnName("dt_noticia")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasColumnName("foto")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoObsCliente>(entity =>
            {
                entity.HasKey(e => e.CoObs);

                entity.ToTable("cao_obs_cliente", "agence_db");

                entity.Property(e => e.CoObs).HasColumnName("co_obs");

                entity.Property(e => e.CoCliente).HasColumnName("co_cliente");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DtObs)
                    .HasColumnName("dt_obs")
                    .HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<CaoObsSistema>(entity =>
            {
                entity.HasKey(e => e.CoObs);

                entity.ToTable("cao_obs_sistema", "agence_db");

                entity.Property(e => e.CoObs).HasColumnName("co_obs");

                entity.Property(e => e.CoSistema).HasColumnName("co_sistema");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .IsUnicode(false);

                entity.Property(e => e.DtObs)
                    .HasColumnName("dt_obs")
                    .HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<CaoOmbudsman>(entity =>
            {
                entity.ToTable("cao_ombudsman", "agence_db");

                entity.HasIndex(e => e.CoEscritorio)
                    .HasName("co_escritorio");

                entity.HasIndex(e => e.Idcategoria)
                    .HasName("idcategoria");

                entity.HasIndex(e => e.Idtipo)
                    .HasName("idtipo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CoEscritorio).HasColumnName("co_escritorio");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasColumnName("comentario")
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Idcategoria).HasColumnName("idcategoria");

                entity.Property(e => e.Idtipo).HasColumnName("idtipo");

                entity.HasOne(d => d.IdcategoriaNavigation)
                    .WithMany(p => p.CaoOmbudsman)
                    .HasForeignKey(d => d.Idcategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_ombudsman$cao_ombudsman_ibfk_2");

                entity.HasOne(d => d.IdtipoNavigation)
                    .WithMany(p => p.CaoOmbudsman)
                    .HasForeignKey(d => d.Idtipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_ombudsman$cao_ombudsman_ibfk_1");
            });

            modelBuilder.Entity<CaoOs>(entity =>
            {
                entity.HasKey(e => e.CoOs);

                entity.ToTable("cao_os", "agence_db");

                entity.Property(e => e.CoOs).HasColumnName("co_os");

                entity.Property(e => e.CoArquitetura)
                    .HasColumnName("co_arquitetura")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoEmail).HasColumnName("co_email");

                entity.Property(e => e.CoOsProspectRel).HasColumnName("co_os_prospect_rel");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoStatus)
                    .HasColumnName("co_status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.DddTelSol)
                    .HasColumnName("ddd_tel_sol")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DddTelSol2)
                    .HasColumnName("ddd_tel_sol2")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiretoriaSol)
                    .HasColumnName("diretoria_sol")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.DsCaracteristica)
                    .HasColumnName("ds_caracteristica")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.DsOs)
                    .HasColumnName("ds_os")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.DsRequisito)
                    .HasColumnName("ds_requisito")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DtFim)
                    .HasColumnName("dt_fim")
                    .HasColumnType("date");

                entity.Property(e => e.DtGarantia)
                    .HasColumnName("dt_garantia")
                    .HasColumnType("date");

                entity.Property(e => e.DtImp)
                    .HasColumnName("dt_imp")
                    .HasColumnType("date");

                entity.Property(e => e.DtInicio)
                    .HasColumnName("dt_inicio")
                    .HasColumnType("date");

                entity.Property(e => e.DtSol)
                    .HasColumnName("dt_sol")
                    .HasColumnType("date");

                entity.Property(e => e.NuOs).HasColumnName("nu_os");

                entity.Property(e => e.NuTelSol)
                    .HasColumnName("nu_tel_sol")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.NuTelSol2)
                    .HasColumnName("nu_tel_sol2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioSol)
                    .HasColumnName("usuario_sol")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'0')");
            });

            modelBuilder.Entity<CaoOsAnalista>(entity =>
            {
                entity.HasKey(e => e.CoAnalista);

                entity.ToTable("cao_os_analista", "agence_db");

                entity.Property(e => e.CoAnalista).HasColumnName("co_analista");

                entity.Property(e => e.CoOs)
                    .HasColumnName("co_os")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'0')");
            });

            modelBuilder.Entity<CaoOsChamado>(entity =>
            {
                entity.HasKey(e => e.CoChamado);

                entity.ToTable("cao_os_chamado", "agence_db");

                entity.Property(e => e.CoChamado).HasColumnName("co_chamado");

                entity.Property(e => e.CoAnalista)
                    .IsRequired()
                    .HasColumnName("co_analista")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CoItem).HasColumnName("co_item");

                entity.Property(e => e.CoOs).HasColumnName("co_os");

                entity.Property(e => e.CoPrioridade).HasColumnName("co_prioridade");

                entity.Property(e => e.CoSistema).HasColumnName("co_sistema");

                entity.Property(e => e.CoTipo).HasColumnName("co_tipo");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .IsUnicode(false);

                entity.Property(e => e.DsChamado)
                    .IsRequired()
                    .HasColumnName("ds_chamado")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DsSolucao)
                    .IsRequired()
                    .HasColumnName("ds_solucao")
                    .IsUnicode(false);

                entity.Property(e => e.DtChamado)
                    .HasColumnName("dt_chamado")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Tempo)
                    .IsRequired()
                    .HasColumnName("tempo")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoOsDailyReport>(entity =>
            {
                entity.HasKey(e => e.CoDaily);

                entity.ToTable("cao_os_daily_report", "agence_db");

                entity.Property(e => e.CoDaily).HasColumnName("co_daily");

                entity.Property(e => e.CoAtividade).HasColumnName("co_atividade");

                entity.Property(e => e.CoChamado).HasColumnName("co_chamado");

                entity.Property(e => e.CoFase)
                    .HasColumnName("co_fase")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoOs)
                    .HasColumnName("co_os")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoStatusAtual).HasColumnName("co_status_atual");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DsAssunto).HasColumnName("ds_assunto");

                entity.Property(e => e.TempoGasto).HasColumnName("tempo_gasto");
            });

            modelBuilder.Entity<CaoOsEmail>(entity =>
            {
                entity.HasKey(e => e.CoEmail);

                entity.ToTable("cao_os_email", "agence_db");

                entity.Property(e => e.CoEmail).HasColumnName("co_email");

                entity.Property(e => e.Ativo).HasColumnName("ativo");

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CoCliente).HasColumnName("co_cliente");

                entity.Property(e => e.CoOs)
                    .HasColumnName("co_os")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ddd)
                    .HasColumnName("ddd")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Senha)
                    .HasColumnName("senha")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaoOsFase>(entity =>
            {
                entity.HasKey(e => e.CoFase);

                entity.ToTable("cao_os_fase", "agence_db");

                entity.Property(e => e.CoFase).HasColumnName("co_fase");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.DescricaoIngl)
                    .IsRequired()
                    .HasColumnName("descricao_ingl")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Ordem).HasColumnName("ordem");
            });

            modelBuilder.Entity<CaoOsItemMenu>(entity =>
            {
                entity.HasKey(e => e.CoItem);

                entity.ToTable("cao_os_item_menu", "agence_db");

                entity.Property(e => e.CoItem).HasColumnName("co_item");

                entity.Property(e => e.CoSistema).HasColumnName("co_sistema");

                entity.Property(e => e.DsItem)
                    .IsRequired()
                    .HasColumnName("ds_item")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoOsObs>(entity =>
            {
                entity.HasKey(e => e.CoObs);

                entity.ToTable("cao_os_obs", "agence_db");

                entity.Property(e => e.CoObs).HasColumnName("co_obs");

                entity.Property(e => e.CoOs)
                    .HasColumnName("co_os")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .IsUnicode(false);

                entity.Property(e => e.DtObs)
                    .HasColumnName("dt_obs")
                    .HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<CaoOsObsChamado>(entity =>
            {
                entity.HasKey(e => e.CoObs);

                entity.ToTable("cao_os_obs_chamado", "agence_db");

                entity.Property(e => e.CoObs).HasColumnName("co_obs");

                entity.Property(e => e.ArquivoObs)
                    .HasColumnName("arquivo_obs")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CoChamado)
                    .HasColumnName("co_chamado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .IsUnicode(false);

                entity.Property(e => e.DtObs)
                    .HasColumnName("dt_obs")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaoOsPrazo>(entity =>
            {
                entity.HasKey(e => e.CoPrazo);

                entity.ToTable("cao_os_prazo", "agence_db");

                entity.Property(e => e.CoPrazo).HasColumnName("co_prazo");

                entity.Property(e => e.CoFase)
                    .HasColumnName("co_fase")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoOs)
                    .HasColumnName("co_os")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAnalista)
                    .HasColumnName("total_analista")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalHora)
                    .HasColumnName("total_hora")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CaoOsStatus>(entity =>
            {
                entity.HasKey(e => e.CoStatusAtual);

                entity.ToTable("cao_os_status", "agence_db");

                entity.Property(e => e.CoStatusAtual).HasColumnName("co_status_atual");

                entity.Property(e => e.DsStatus)
                    .IsRequired()
                    .HasColumnName("ds_status")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoPagamento>(entity =>
            {
                entity.HasKey(e => e.CoPagamento);

                entity.ToTable("cao_pagamento", "agence_db");

                entity.HasIndex(e => e.CoPagamento)
                    .HasName("nu_os");

                entity.Property(e => e.CoPagamento)
                    .HasColumnName("co_pagamento")
                    .HasColumnType("numeric(20, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DtPagamento)
                    .HasColumnName("dt_pagamento")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtReferenciaPagamento)
                    .HasColumnName("dt_referencia_pagamento")
                    .HasColumnType("date");

                entity.Property(e => e.TpPagamento)
                    .IsRequired()
                    .HasColumnName("tp_pagamento")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.VlPagamento).HasColumnName("vl_pagamento");
            });

            modelBuilder.Entity<CaoParticipacaoFuncionario>(entity =>
            {
                entity.HasKey(e => e.CoPartFuncionario);

                entity.ToTable("cao_participacao_funcionario", "agence_db");

                entity.Property(e => e.CoPartFuncionario).HasColumnName("co_part_funcionario");

                entity.Property(e => e.CoEscritorio).HasColumnName("co_escritorio");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DtReferencia)
                    .HasColumnName("dt_referencia")
                    .HasColumnType("date");

                entity.Property(e => e.PcParticipacao).HasColumnName("pc_participacao");
            });

            modelBuilder.Entity<CaoPermissaoHoraExtra>(entity =>
            {
                entity.HasKey(e => e.IdPermissao);

                entity.ToTable("cao_permissao_hora_extra", "agence_db");

                entity.Property(e => e.IdPermissao).HasColumnName("id_permissao");

                entity.Property(e => e.CoMovimento).HasColumnName("co_movimento");
            });

            modelBuilder.Entity<CaoPontosConhecimento>(entity =>
            {
                entity.HasKey(e => e.Idpontos);

                entity.ToTable("cao_pontos_conhecimento", "agence_db");

                entity.HasIndex(e => e.CoCoordenador)
                    .HasName("co_coordenador");

                entity.HasIndex(e => e.Idconhecimento)
                    .HasName("idconhecimento");

                entity.HasIndex(e => new { e.Pontuacao, e.CoCoordenador, e.Idconhecimento })
                    .HasName("pontuacao");

                entity.Property(e => e.Idpontos).HasColumnName("idpontos");

                entity.Property(e => e.CoCoordenador)
                    .IsRequired()
                    .HasColumnName("co_coordenador")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Idconhecimento).HasColumnName("idconhecimento");

                entity.Property(e => e.Pontuacao).HasColumnName("pontuacao");

                entity.HasOne(d => d.CoCoordenadorNavigation)
                    .WithMany(p => p.CaoPontosConhecimento)
                    .HasForeignKey(d => d.CoCoordenador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_pontos_conhecimento$cao_pontos_conhecimento_ibfk_2");

                entity.HasOne(d => d.IdconhecimentoNavigation)
                    .WithMany(p => p.CaoPontosConhecimento)
                    .HasForeignKey(d => d.Idconhecimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_pontos_conhecimento$cao_pontos_conhecimento_ibfk_3");

                entity.HasOne(d => d.PontuacaoNavigation)
                    .WithMany(p => p.CaoPontosConhecimento)
                    .HasForeignKey(d => d.Pontuacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_pontos_conhecimento$cao_pontos_conhecimento_ibfk_1");
            });

            modelBuilder.Entity<CaoRamo>(entity =>
            {
                entity.HasKey(e => e.CoRamo);

                entity.ToTable("cao_ramo", "agence_db");

                entity.Property(e => e.CoRamo).HasColumnName("co_ramo");

                entity.Property(e => e.DsRamo)
                    .IsRequired()
                    .HasColumnName("ds_ramo")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoRelEmailOs>(entity =>
            {
                entity.ToTable("cao_rel_email_os", "agence_db");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CoEmail).HasColumnName("co_email");

                entity.Property(e => e.CoOs).HasColumnName("co_os");
            });

            modelBuilder.Entity<CaoSalario>(entity =>
            {
                entity.HasKey(e => new { e.CoUsuario, e.DtAlteracao });

                entity.ToTable("cao_salario", "agence_db");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DtAlteracao)
                    .HasColumnName("dt_alteracao")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BrutSalario).HasColumnName("brut_salario");

                entity.Property(e => e.LiqSalario).HasColumnName("liq_salario");
            });

            modelBuilder.Entity<CaoServico>(entity =>
            {
                entity.HasKey(e => e.CoServico);

                entity.ToTable("cao_servico", "agence_db");

                entity.Property(e => e.CoServico).HasColumnName("co_servico");

                entity.Property(e => e.DsServico)
                    .IsRequired()
                    .HasColumnName("ds_servico")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoSistema>(entity =>
            {
                entity.HasKey(e => e.CoSistema);

                entity.ToTable("cao_sistema", "agence_db");

                entity.HasIndex(e => e.CoSistema)
                    .HasName("co_sistema");

                entity.Property(e => e.CoSistema).HasColumnName("co_sistema");

                entity.Property(e => e.CoArquitetura)
                    .HasColumnName("co_arquitetura")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoCliente)
                    .HasColumnName("co_cliente")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoEmail).HasColumnName("co_email");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.DddTelefoneSolic)
                    .HasColumnName("ddd_telefone_solic")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DsCaracteristica)
                    .HasColumnName("ds_caracteristica")
                    .IsUnicode(false);

                entity.Property(e => e.DsRequisito)
                    .HasColumnName("ds_requisito")
                    .IsUnicode(false);

                entity.Property(e => e.DsSistemaResumo)
                    .HasColumnName("ds_sistema_resumo")
                    .IsUnicode(false);

                entity.Property(e => e.DtEntrega)
                    .HasColumnName("dt_entrega")
                    .HasColumnType("date");

                entity.Property(e => e.DtSolicitacao)
                    .HasColumnName("dt_solicitacao")
                    .HasColumnType("date");

                entity.Property(e => e.NoDiretoriaSolic)
                    .HasColumnName("no_diretoria_solic")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoSistema)
                    .HasColumnName("no_sistema")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NoUsuarioSolic)
                    .HasColumnName("no_usuario_solic")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NuTelefoneSolic)
                    .HasColumnName("nu_telefone_solic")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaoSistemaObs>(entity =>
            {
                entity.HasKey(e => e.CoObs);

                entity.ToTable("cao_sistema_obs", "agence_db");

                entity.Property(e => e.CoObs).HasColumnName("co_obs");

                entity.Property(e => e.CoSistema).HasColumnName("co_sistema");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .IsUnicode(false);

                entity.Property(e => e.DtObs)
                    .HasColumnName("dt_obs")
                    .HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<CaoStatusAgendamento>(entity =>
            {
                entity.HasKey(e => e.CoStatusAgendamento);

                entity.ToTable("cao_status_agendamento", "agence_db");

                entity.Property(e => e.CoStatusAgendamento).HasColumnName("co_status_agendamento");

                entity.Property(e => e.DsStatusAgendamento)
                    .IsRequired()
                    .HasColumnName("ds_status_agendamento")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoStatusCliente>(entity =>
            {
                entity.HasKey(e => e.CoStatus);

                entity.ToTable("cao_status_cliente", "agence_db");

                entity.Property(e => e.CoStatus).HasColumnName("co_status");

                entity.Property(e => e.DsStatus)
                    .IsRequired()
                    .HasColumnName("ds_status")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoStatusClienteComplemento>(entity =>
            {
                entity.HasKey(e => e.CoComplementoStatus);

                entity.ToTable("cao_status_cliente_complemento", "agence_db");

                entity.Property(e => e.CoComplementoStatus).HasColumnName("co_complemento_status");

                entity.Property(e => e.CoStatus).HasColumnName("co_status");

                entity.Property(e => e.DsStatus)
                    .HasColumnName("ds_status")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoStatusOs>(entity =>
            {
                entity.HasKey(e => e.CoStatusAtual);

                entity.ToTable("cao_status_os", "agence_db");

                entity.Property(e => e.CoStatusAtual).HasColumnName("co_status_atual");

                entity.Property(e => e.DsStatus)
                    .IsRequired()
                    .HasColumnName("ds_status")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoTempImport>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("cao_temp_import", "agence_db");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoTipoConhecimentoUsuario>(entity =>
            {
                entity.HasKey(e => e.CoConhecimento);

                entity.ToTable("cao_tipo_conhecimento_usuario", "agence_db");

                entity.HasIndex(e => e.CoConhecimento)
                    .HasName("co_conhecimento");

                entity.Property(e => e.CoConhecimento).HasColumnName("co_conhecimento");

                entity.Property(e => e.CoSistema).HasColumnName("co_sistema");

                entity.Property(e => e.DsConhecimento)
                    .HasColumnName("ds_conhecimento")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaoTipoCusto>(entity =>
            {
                entity.HasKey(e => e.CoTipoCusto);

                entity.ToTable("cao_tipo_custo", "agence_db");

                entity.Property(e => e.CoTipoCusto)
                    .HasColumnName("co_tipo_custo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoTipoIdiomaUsuario>(entity =>
            {
                entity.HasKey(e => e.CoIdioma);

                entity.ToTable("cao_tipo_idioma_usuario", "agence_db");

                entity.Property(e => e.CoIdioma).HasColumnName("co_idioma");

                entity.Property(e => e.DsIdioma)
                    .HasColumnName("ds_idioma")
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaoTipoOmbudsman>(entity =>
            {
                entity.HasKey(e => e.Idtipo);

                entity.ToTable("cao_tipo_ombudsman", "agence_db");

                entity.Property(e => e.Idtipo).HasColumnName("idtipo");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoTipoSistemaUsuario>(entity =>
            {
                entity.HasKey(e => e.CoSistema);

                entity.ToTable("cao_tipo_sistema_usuario", "agence_db");

                entity.HasIndex(e => e.CoSistema)
                    .HasName("co_sistema");

                entity.Property(e => e.CoSistema).HasColumnName("co_sistema");

                entity.Property(e => e.DsSistema)
                    .HasColumnName("ds_sistema")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaoUf>(entity =>
            {
                entity.HasKey(e => e.CoUf);

                entity.ToTable("cao_uf", "agence_db");

                entity.Property(e => e.CoUf).HasColumnName("co_uf");

                entity.Property(e => e.DsUf)
                    .IsRequired()
                    .HasColumnName("ds_uf")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CaoUsuario>(entity =>
            {
                entity.HasKey(e => e.CoUsuario);

                entity.ToTable("cao_usuario", "agence_db");

                entity.HasIndex(e => e.CoUsuario)
                    .HasName("cao_usuario$co_usuario")
                    .IsUnique();

                entity.HasIndex(e => new { e.CoUsuario, e.NoUsuario, e.DtAlteracao })
                    .HasName("co_usuario_2");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CoUsuarioAutorizacao)
                    .HasColumnName("co_usuario_autorizacao")
                    .HasMaxLength(20);

                entity.Property(e => e.DsBairro)
                    .HasColumnName("ds_bairro")
                    .HasMaxLength(30);

                entity.Property(e => e.DsCompEnd)
                    .HasColumnName("ds_comp_end")
                    .HasMaxLength(50);

                entity.Property(e => e.DsEndereco)
                    .HasColumnName("ds_endereco")
                    .HasMaxLength(150);

                entity.Property(e => e.DsSenha)
                    .IsRequired()
                    .HasColumnName("ds_senha")
                    .HasMaxLength(14)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DtAdmissaoEmpresa)
                    .HasColumnName("dt_admissao_empresa")
                    .HasColumnType("date");

                entity.Property(e => e.DtAlteracao)
                    .HasColumnName("dt_alteracao")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DtDesligamento)
                    .HasColumnName("dt_desligamento")
                    .HasColumnType("date");

                entity.Property(e => e.DtExpedicao)
                    .HasColumnName("dt_expedicao")
                    .HasColumnType("date");

                entity.Property(e => e.DtExpiracao)
                    .HasColumnName("dt_expiracao")
                    .HasColumnType("date");

                entity.Property(e => e.DtInclusao)
                    .HasColumnName("dt_inclusao")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dt_nascimento")
                    .HasColumnType("date");

                entity.Property(e => e.Icq).HasColumnName("icq");

                entity.Property(e => e.InstantMessenger)
                    .HasColumnName("instant_messenger")
                    .HasMaxLength(80);

                entity.Property(e => e.Msn)
                    .HasColumnName("msn")
                    .HasMaxLength(50);

                entity.Property(e => e.NoCidade)
                    .HasColumnName("no_cidade")
                    .HasMaxLength(50);

                entity.Property(e => e.NoEmail)
                    .HasColumnName("no_email")
                    .HasMaxLength(100);

                entity.Property(e => e.NoEmailPessoal)
                    .HasColumnName("no_email_pessoal")
                    .HasMaxLength(100);

                entity.Property(e => e.NoOrgaoEmissor)
                    .HasColumnName("no_orgao_emissor")
                    .HasMaxLength(10);

                entity.Property(e => e.NoUsuario)
                    .IsRequired()
                    .HasColumnName("no_usuario")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NuCep)
                    .HasColumnName("nu_cep")
                    .HasMaxLength(10);

                entity.Property(e => e.NuCpf)
                    .HasColumnName("nu_cpf")
                    .HasMaxLength(14);

                entity.Property(e => e.NuMatricula)
                    .HasColumnName("nu_matricula")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.NuRg)
                    .HasColumnName("nu_rg")
                    .HasMaxLength(20);

                entity.Property(e => e.NuTelefone)
                    .HasColumnName("nu_telefone")
                    .HasMaxLength(64);

                entity.Property(e => e.UfCidade)
                    .HasColumnName("uf_cidade")
                    .HasMaxLength(2);

                entity.Property(e => e.UfOrgaoEmissor)
                    .HasColumnName("uf_orgao_emissor")
                    .HasMaxLength(2);

                entity.Property(e => e.UrlFoto)
                    .HasColumnName("url_foto")
                    .HasMaxLength(255);

                entity.Property(e => e.Yms)
                    .HasColumnName("yms")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CaoUsuarioDtDisp>(entity =>
            {
                entity.HasKey(e => e.CoDtDisp);

                entity.ToTable("cao_usuario_dt_disp", "agence_db");

                entity.Property(e => e.CoDtDisp).HasColumnName("co_dt_disp");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DtAlt)
                    .HasColumnName("dt_alt")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtDisp)
                    .HasColumnName("dt_disp")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CaoValorDescanso>(entity =>
            {
                entity.ToTable("cao_valor_descanso", "agence_db");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CoUsuario)
                    .IsRequired()
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.MesReferencia)
                    .IsRequired()
                    .HasColumnName("mes_referencia")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Segundos)
                    .IsRequired()
                    .HasColumnName("segundos")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<PermissaoSistema>(entity =>
            {
                entity.HasKey(e => new { e.CoUsuario, e.CoTipoUsuario, e.CoSistema });

                entity.ToTable("permissao_sistema", "agence_db");

                entity.HasIndex(e => new { e.CoUsuario, e.CoTipoUsuario, e.CoSistema, e.DtAtualizacao })
                    .HasName("co_usuario");

                entity.Property(e => e.CoUsuario)
                    .HasColumnName("co_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CoTipoUsuario)
                    .HasColumnName("co_tipo_usuario")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.CoUsuarioAtualizacao)
                    .HasColumnName("co_usuario_atualizacao")
                    .HasMaxLength(20);

                entity.Property(e => e.DtAtualizacao)
                    .HasColumnName("dt_atualizacao")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.InAtivo)
                    .IsRequired()
                    .HasColumnName("in_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'S')");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => new { e.CoTipoUsuario, e.CoSistema });

                entity.ToTable("tipo_usuario", "agence_db");

                entity.HasIndex(e => new { e.CoTipoUsuario, e.CoSistema })
                    .HasName("co_tipo_usuario");

                entity.Property(e => e.CoTipoUsuario)
                    .HasColumnName("co_tipo_usuario")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.CoSistema)
                    .HasColumnName("co_sistema")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.DsTipoUsuario)
                    .IsRequired()
                    .HasColumnName("ds_tipo_usuario")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("(N'')");
            });
        }
    }
}
