using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using LCA.Data.Domain;

#nullable disable

namespace LCA.Data.Context
{
    public partial class LcaDbContext : DbContext
    {
        public LcaDbContext()
        {
        }

        public LcaDbContext(DbContextOptions<LcaDbContext> options)
            : base(options)
        {
        }

        #region DbSet declare

        public virtual DbSet<object> Dynamic { get; set; }
        public virtual DbSet<AspstateTempApplication> AspstateTempApplications { get; set; }
        public virtual DbSet<AspstateTempSession> AspstateTempSessions { get; set; }
        public virtual DbSet<Calheading> Calheadings { get; set; }
        public virtual DbSet<ClientGroup> ClientGroups { get; set; }
        public virtual DbSet<Co2materialsSima> Co2materialsSimas { get; set; }
        public virtual DbSet<ComPcrlink> ComPcrlinks { get; set; }
        public virtual DbSet<ComProcessLink> ComProcessLinks { get; set; }
        public virtual DbSet<Comlink> Comlinks { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyProductGroup> CompanyProductGroups { get; set; }
        public virtual DbSet<CompanyProductList> CompanyProductLists { get; set; }
        public virtual DbSet<Comsw> Comsws { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Dbanalyse> Dbanalyses { get; set; }
        public virtual DbSet<DbanalyseSite> DbanalyseSites { get; set; }
        public virtual DbSet<DbanalyseSiteView> DbanalyseSiteViews { get; set; }
        public virtual DbSet<Dbavfallstyper> Dbavfallstypers { get; set; }
        public virtual DbSet<Dbbehandlingsmate> Dbbehandlingsmates { get; set; }
        public virtual DbSet<Dbbehandlingssted> Dbbehandlingssteds { get; set; }
        public virtual DbSet<Dbkildesortering> Dbkildesorterings { get; set; }
        public virtual DbSet<Dboptibag> Dboptibags { get; set; }
        public virtual DbSet<DbplukkHead> DbplukkHeads { get; set; }
        public virtual DbSet<Dbplukkliste> Dbplukklistes { get; set; }
        public virtual DbSet<DbrestSite> DbrestSites { get; set; }
        public virtual DbSet<Dbrestavfall> Dbrestavfalls { get; set; }
        public virtual DbSet<Dbresultat> Dbresultats { get; set; }
        public virtual DbSet<Dbresultdetail> Dbresultdetails { get; set; }
        public virtual DbSet<Dbsupport> Dbsupports { get; set; }
        public virtual DbSet<Dbtransport> Dbtransports { get; set; }
        public virtual DbSet<Dcanswer> Dcanswers { get; set; }
        public virtual DbSet<Dcheading> Dcheadings { get; set; }
        public virtual DbSet<Dcrecipient> Dcrecipients { get; set; }
        public virtual DbSet<EPackAnalyse> EPackAnalyses { get; set; }
        public virtual DbSet<EPackAnalyseGwp> EPackAnalyseGwps { get; set; }
        public virtual DbSet<EPackAnalysePacklist> EPackAnalysePacklists { get; set; }
        public virtual DbSet<EPackAnalyser> EPackAnalysers { get; set; }
        public virtual DbSet<EPackCertificate> EPackCertificates { get; set; }
        public virtual DbSet<EPackCertificateLine> EPackCertificateLines { get; set; }
        public virtual DbSet<EPackComponent> EPackComponents { get; set; }
        public virtual DbSet<EPackComponentsFile> EPackComponentsFiles { get; set; }
        public virtual DbSet<EPackDeclarationLine> EPackDeclarationLines { get; set; }
        public virtual DbSet<EPackDeclarationType> EPackDeclarationTypes { get; set; }
        public virtual DbSet<EPackGwplevel1> EPackGwplevel1s { get; set; }
        public virtual DbSet<EPackGwplevel2> EPackGwplevel2s { get; set; }
        public virtual DbSet<EPackGwplevel3> EPackGwplevel3s { get; set; }
        public virtual DbSet<EPackHeading> EPackHeadings { get; set; }
        public virtual DbSet<EPackLevel1> EPackLevel1s { get; set; }
        public virtual DbSet<EPackLevel2> EPackLevel2s { get; set; }
        public virtual DbSet<EPackLevel3> EPackLevel3s { get; set; }
        public virtual DbSet<EPackTotalSalesLevel1> EPackTotalSalesLevel1s { get; set; }
        public virtual DbSet<EPackTotalSalesLevel2> EPackTotalSalesLevel2s { get; set; }
        public virtual DbSet<Epdanalysis> Epdanalyses { get; set; }
        public virtual DbSet<EpdanalysisFase> EpdanalysisFases { get; set; }
        public virtual DbSet<EpdanalysisList> EpdanalysisLists { get; set; }
        public virtual DbSet<EpdcalculationA1> EpdcalculationA1s { get; set; }
        public virtual DbSet<EpdcalculationA1A31> EpdcalculationA1A3s1 { get; set; }
        public virtual DbSet<EpdcalculationA1a3> EpdcalculationA1a3s { get; set; }
        public virtual DbSet<EpdcalculationA1a3forEpd> EpdcalculationA1a3forEpds { get; set; }
        public virtual DbSet<EpdcalculationA1a4forEpd> EpdcalculationA1a4forEpds { get; set; }
        public virtual DbSet<EpdcalculationA1a5forEpd> EpdcalculationA1a5forEpds { get; set; }
        public virtual DbSet<EpdcalculationA2> EpdcalculationA2s { get; set; }
        public virtual DbSet<EpdcalculationA2temp> EpdcalculationA2temps { get; set; }
        public virtual DbSet<EpdcalculationA3> EpdcalculationA3s { get; set; }
        public virtual DbSet<EpdcalculationA4> EpdcalculationA4s { get; set; }
        public virtual DbSet<EpdcalculationA42> EpdcalculationA42s { get; set; }
        public virtual DbSet<EpdcalculationA5> EpdcalculationA5s { get; set; }
        public virtual DbSet<EpdcalculationB1> EpdcalculationB1s { get; set; }
        public virtual DbSet<EpdcalculationB2> EpdcalculationB2s { get; set; }
        public virtual DbSet<EpdcalculationB3> EpdcalculationB3s { get; set; }
        public virtual DbSet<EpdcalculationB3bak> EpdcalculationB3baks { get; set; }
        public virtual DbSet<EpdcalculationB4> EpdcalculationB4s { get; set; }
        public virtual DbSet<EpdcalculationB4bak> EpdcalculationB4baks { get; set; }
        public virtual DbSet<EpdcalculationB5> EpdcalculationB5s { get; set; }
        public virtual DbSet<EpdcalculationB5bak> EpdcalculationB5baks { get; set; }
        public virtual DbSet<EpdcalculationB6> EpdcalculationB6s { get; set; }
        public virtual DbSet<EpdcalculationB6bak> EpdcalculationB6baks { get; set; }
        public virtual DbSet<EpdcalculationB7> EpdcalculationB7s { get; set; }
        public virtual DbSet<EpdcalculationB7bak> EpdcalculationB7baks { get; set; }
        public virtual DbSet<EpdcalculationC1> EpdcalculationC1s { get; set; }
        public virtual DbSet<EpdcalculationC1bak> EpdcalculationC1baks { get; set; }
        public virtual DbSet<EpdcalculationC2> EpdcalculationC2s { get; set; }
        public virtual DbSet<EpdcalculationC22> EpdcalculationC22s { get; set; }
        public virtual DbSet<EpdcalculationC3> EpdcalculationC3s { get; set; }
        public virtual DbSet<EpdcalculationC3bak> EpdcalculationC3baks { get; set; }
        public virtual DbSet<EpdcalculationC4> EpdcalculationC4s { get; set; }
        public virtual DbSet<EpdcalculationC4bak> EpdcalculationC4baks { get; set; }
        public virtual DbSet<EpdcalculationD> EpdcalculationDs { get; set; }
        public virtual DbSet<EpdcalculationDbak> EpdcalculationDbaks { get; set; }
        public virtual DbSet<EpdcalculationTotal> EpdcalculationTotals { get; set; }
        public virtual DbSet<EpdcalculationTotalForEpd> EpdcalculationTotalForEpds { get; set; }
        public virtual DbSet<EpdcalculationTotalForEpden15804a1> EpdcalculationTotalForEpden15804a1s { get; set; }
        public virtual DbSet<EpdcalculationTotalForEpden15804a2> EpdcalculationTotalForEpden15804a2s { get; set; }
        public virtual DbSet<EpdcalculationTotalForEpdtoDigi> EpdcalculationTotalForEpdtoDigis { get; set; }
        public virtual DbSet<Epdco2fase> Epdco2fases { get; set; }
        public virtual DbSet<Epdco2heading> Epdco2headings { get; set; }
        public virtual DbSet<EpdcustomerLine> EpdcustomerLines { get; set; }
        public virtual DbSet<Epddangerou> Epddangerous { get; set; }
        public virtual DbSet<EpddataEn15804a1> EpddataEn15804a1s { get; set; }
        public virtual DbSet<EpddataEn15804a1registration> EpddataEn15804a1registrations { get; set; }
        public virtual DbSet<EpddataEn15804a1registrationsProject> EpddataEn15804a1registrationsProjects { get; set; }
        public virtual DbSet<EpddataEn15804a2> EpddataEn15804a2s { get; set; }
        public virtual DbSet<EpddataEn15804a2registration> EpddataEn15804a2registrations { get; set; }
        public virtual DbSet<EpddataEn15804a2registrationsProject> EpddataEn15804a2registrationsProjects { get; set; }
        public virtual DbSet<EpddataSetDocumentation> EpddataSetDocumentations { get; set; }
        public virtual DbSet<EpddataSetDocumentationRegistration> EpddataSetDocumentationRegistrations { get; set; }
        public virtual DbSet<EpddataSetDocumentationRegistrationsProject> EpddataSetDocumentationRegistrationsProjects { get; set; }
        public virtual DbSet<EpddataSetDocumentationSubProcess> EpddataSetDocumentationSubProcesses { get; set; }
        public virtual DbSet<EpddefaultA2> EpddefaultA2s { get; set; }
        public virtual DbSet<EpddefaultA3> EpddefaultA3s { get; set; }
        public virtual DbSet<EpddefaultA4> EpddefaultA4s { get; set; }
        public virtual DbSet<EpdfunctionRegister> EpdfunctionRegisters { get; set; }
        public virtual DbSet<Epdgroup> Epdgroups { get; set; }
        public virtual DbSet<Epdheading> Epdheadings { get; set; }
        public virtual DbSet<EpdheadingDigi> EpdheadingDigis { get; set; }
        public virtual DbSet<Epdlayout> Epdlayouts { get; set; }
        public virtual DbSet<Epdlink> Epdlinks { get; set; }
        public virtual DbSet<EpdmaterialList> EpdmaterialLists { get; set; }
        public virtual DbSet<EpdmaterialsCepe> EpdmaterialsCepes { get; set; }
        public virtual DbSet<EpdmaterialsEpd> EpdmaterialsEpds { get; set; }
        public virtual DbSet<EpdmaterialsSima> EpdmaterialsSimas { get; set; }
        public virtual DbSet<EpdmaterialsSimasubProcess> EpdmaterialsSimasubProcesses { get; set; }
        public virtual DbSet<Epdpcr> Epdpcrs { get; set; }
        public virtual DbSet<Epdpcrlink> Epdpcrlinks { get; set; }
        public virtual DbSet<EpdprojectFase> EpdprojectFases { get; set; }
        public virtual DbSet<EpdprojectGroupSetup> EpdprojectGroupSetups { get; set; }
        public virtual DbSet<EpdprojectHeading> EpdprojectHeadings { get; set; }
        public virtual DbSet<EpdregisterMain> EpdregisterMains { get; set; }
        public virtual DbSet<EpdregistrationA1> EpdregistrationA1s { get; set; }
        public virtual DbSet<EpdregistrationA2> EpdregistrationA2s { get; set; }
        public virtual DbSet<EpdregistrationA3> EpdregistrationA3s { get; set; }
        public virtual DbSet<EpdregistrationA4> EpdregistrationA4s { get; set; }
        public virtual DbSet<EpdregistrationA5> EpdregistrationA5s { get; set; }
        public virtual DbSet<EpdregistrationB1> EpdregistrationB1s { get; set; }
        public virtual DbSet<EpdregistrationB2> EpdregistrationB2s { get; set; }
        public virtual DbSet<EpdregistrationB3> EpdregistrationB3s { get; set; }
        public virtual DbSet<EpdregistrationB4> EpdregistrationB4s { get; set; }
        public virtual DbSet<EpdregistrationB5> EpdregistrationB5s { get; set; }
        public virtual DbSet<EpdregistrationB6> EpdregistrationB6s { get; set; }
        public virtual DbSet<EpdregistrationB7> EpdregistrationB7s { get; set; }
        public virtual DbSet<EpdregistrationC1> EpdregistrationC1s { get; set; }
        public virtual DbSet<EpdregistrationC2> EpdregistrationC2s { get; set; }
        public virtual DbSet<EpdregistrationC3> EpdregistrationC3s { get; set; }
        public virtual DbSet<EpdregistrationC4> EpdregistrationC4s { get; set; }
        public virtual DbSet<EpdregistrationD1> EpdregistrationD1s { get; set; }
        public virtual DbSet<EpdregistrationFase> EpdregistrationFases { get; set; }
        public virtual DbSet<EpdregistrationFasesDigi> EpdregistrationFasesDigis { get; set; }
        public virtual DbSet<Epdshare> Epdshares { get; set; }
        public virtual DbSet<EpdsubType> EpdsubTypes { get; set; }
        public virtual DbSet<Fordeling> Fordelings { get; set; }
        public virtual DbSet<Impact> Impacts { get; set; }
        public virtual DbSet<ImpactCat> ImpactCats { get; set; }
        public virtual DbSet<LanguageListIso6391> LanguageListIso6391s { get; set; }
        public virtual DbSet<Layout> Layouts { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<MainGroup> MainGroups { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NsEn> NsEns { get; set; }
        public virtual DbSet<PackElementer> PackElementers { get; set; }
        public virtual DbSet<PackMaterialList> PackMaterialLists { get; set; }
        public virtual DbSet<PackMaterialListSelection> PackMaterialListSelections { get; set; }
        public virtual DbSet<Pematerial> Pematerials { get; set; }
        public virtual DbSet<Petype> Petypes { get; set; }
        public virtual DbSet<Process> Processes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductDatum> ProductData { get; set; }
        public virtual DbSet<ProductGroup> ProductGroups { get; set; }
        public virtual DbSet<ProductsLine> ProductsLines { get; set; }
        public virtual DbSet<ProgramModule> ProgramModules { get; set; }
        public virtual DbSet<StandardCategory> StandardCategories { get; set; }
        public virtual DbSet<SystemReportLayoutList> SystemReportLayoutLists { get; set; }
        public virtual DbSet<TransportDistance> TransportDistances { get; set; }
        public virtual DbSet<TransportExp> TransportExps { get; set; }
        public virtual DbSet<TransportExpHeader> TransportExpHeaders { get; set; }
        public virtual DbSet<TransportHead> TransportHeads { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<Usrlink> Usrlinks { get; set; }
        public virtual DbSet<WcmainGroup> WcmainGroups { get; set; }
        public virtual DbSet<Wcparameter> Wcparameters { get; set; }
        public virtual DbSet<Xmlunit> Xmlunits { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=MAY-21;Database=lca-tools-test;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AspstateTempApplication>(entity =>
            {
                entity.HasKey(e => e.AppId)
                    .HasName("PK__ASPState__8E2CF7F9F01B67DA");

                entity.Property(e => e.AppId).ValueGeneratedNever();

                entity.Property(e => e.AppName)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<AspstateTempSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PK__ASPState__C9F492901A394645");

                entity.Property(e => e.Created).HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<Calheading>(entity =>
            {
                entity.Property(e => e.CalBiogassTxt).IsUnicode(false);

                entity.Property(e => e.CalBiorestTxt).IsUnicode(false);

                entity.Property(e => e.CalburnrateTxt).IsUnicode(false);

                entity.Property(e => e.Calname).IsUnicode(false);

                entity.Property(e => e.CalreferenceTxt).IsUnicode(false);

                entity.Property(e => e.CalstorageTxt).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.Calheadings)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CALHeading_COMPANY");
            });

            modelBuilder.Entity<ClientGroup>(entity =>
            {
                entity.Property(e => e.GroupName).IsUnicode(false);
            });

            modelBuilder.Entity<Co2materialsSima>(entity =>
            {
                entity.Property(e => e.DataQuality).IsUnicode(false);

                entity.Property(e => e.DataSource).IsUnicode(false);

                entity.Property(e => e.EpdmaterialId).IsUnicode(false);

                entity.Property(e => e.EpdmaterialName).IsUnicode(false);

                entity.Property(e => e.FEUnit).IsUnicode(false);

                entity.Property(e => e.HelpText).IsUnicode(false);

                entity.Property(e => e.InternalComments).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);

                entity.Property(e => e.UnitCalc).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ComPcrlink>(entity =>
            {
                entity.HasOne(d => d.Com)
                    .WithMany(p => p.ComPcrlinks)
                    .HasForeignKey(d => d.ComId)
                    .HasConstraintName("FK_ComPCRLink_COMPANY");
            });

            modelBuilder.Entity<ComProcessLink>(entity =>
            {
                entity.Property(e => e.ProcessName).IsUnicode(false);

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.ComProcessLinks)
                    .HasForeignKey(d => d.ComId)
                    .HasConstraintName("FK_ComProcessLink_COMPANY");
            });

            modelBuilder.Entity<Comlink>(entity =>
            {
                entity.HasOne(d => d.Com)
                    .WithMany(p => p.Comlinks)
                    .HasForeignKey(d => d.ComId)
                    .HasConstraintName("FK_COMLinks_COMPANY");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.ComAdd).IsUnicode(false);

                entity.Property(e => e.ComBannerLogo).IsUnicode(false);

                entity.Property(e => e.ComCity).IsUnicode(false);

                entity.Property(e => e.ComCompanyname).IsUnicode(false);

                entity.Property(e => e.ComCompanyvat).IsUnicode(false);

                entity.Property(e => e.ComCreatedttm).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ComDir).IsUnicode(false);

                entity.Property(e => e.ComEmail).IsUnicode(false);

                entity.Property(e => e.ComEpdinfo1).IsUnicode(false);

                entity.Property(e => e.ComEpdinfo2).IsUnicode(false);

                entity.Property(e => e.ComEpdinfo3).IsUnicode(false);

                entity.Property(e => e.ComEpdinfo4).IsUnicode(false);

                entity.Property(e => e.ComEpdpicture1).IsUnicode(false);

                entity.Property(e => e.ComEpdpicture2).IsUnicode(false);

                entity.Property(e => e.ComGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComLogo).IsUnicode(false);

                entity.Property(e => e.ComMainContact).IsUnicode(false);

                entity.Property(e => e.ComManagmentSys).IsUnicode(false);

                entity.Property(e => e.ComModulSharing).HasDefaultValueSql("((0))");

                entity.Property(e => e.ComModulSubFase).HasDefaultValueSql("((0))");

                entity.Property(e => e.ComPageText).IsUnicode(false);

                entity.Property(e => e.ComPhone1).IsUnicode(false);

                entity.Property(e => e.ComPhone2).IsUnicode(false);

                entity.Property(e => e.ComProid).IsUnicode(false);

                entity.Property(e => e.ComStartup).IsUnicode(false);

                entity.Property(e => e.ComStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ComToken).IsUnicode(false);

                entity.Property(e => e.ComWeb).IsUnicode(false);

                entity.Property(e => e.ComZip).IsUnicode(false);
            });

            modelBuilder.Entity<CompanyProductGroup>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.ProductGroupId).IsUnicode(false);

                entity.Property(e => e.ProductGroupName).IsUnicode(false);
            });

            modelBuilder.Entity<CompanyProductList>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.ProductId).IsUnicode(false);

                entity.Property(e => e.ProductName).IsUnicode(false);
            });

            modelBuilder.Entity<Comsw>(entity =>
            {
                entity.HasOne(d => d.Com)
                    .WithMany(p => p.Comsws)
                    .HasForeignKey(d => d.ComId)
                    .HasConstraintName("FK_COMSW_COMPANY");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Alpha2Code).IsUnicode(false);

                entity.Property(e => e.Alpha3Code).IsUnicode(false);

                entity.Property(e => e.CountryName).IsUnicode(false);

                entity.Property(e => e.Language).IsUnicode(false);
            });

            modelBuilder.Entity<Dbanalyse>(entity =>
            {
                entity.Property(e => e.Ansvarlig).IsUnicode(false);

                entity.Property(e => e.Beskrivelse).IsUnicode(false);

                entity.Property(e => e.Innlogget).IsUnicode(false);

                entity.Property(e => e.Navn).IsUnicode(false);
            });

            modelBuilder.Entity<DbanalyseSite>(entity =>
            {
                entity.Property(e => e.AvNavn).IsUnicode(false);

                entity.Property(e => e.Sted).IsUnicode(false);

                entity.Property(e => e.Transport).IsUnicode(false);

                entity.HasOne(d => d.Analyse)
                    .WithMany(p => p.DbanalyseSites)
                    .HasForeignKey(d => d.AnalyseId)
                    .HasConstraintName("FK_DBAnalyseSite_DBAnalyse");
            });

            modelBuilder.Entity<DbanalyseSiteView>(entity =>
            {
                entity.ToView("DBanalyseSiteView");

                entity.Property(e => e.AvNavn).IsUnicode(false);

                entity.Property(e => e.Sted).IsUnicode(false);

                entity.Property(e => e.Transport).IsUnicode(false);
            });

            modelBuilder.Entity<Dbavfallstyper>(entity =>
            {
                entity.Property(e => e.AvId).ValueGeneratedNever();

                entity.Property(e => e.AvName).IsUnicode(false);
            });

            modelBuilder.Entity<Dbbehandlingsmate>(entity =>
            {
                entity.Property(e => e.BehandId).ValueGeneratedNever();

                entity.Property(e => e.Behandling).IsUnicode(false);
            });

            modelBuilder.Entity<Dbbehandlingssted>(entity =>
            {
                entity.Property(e => e.BehandlingId).ValueGeneratedNever();

                entity.Property(e => e.Behandlingssted).IsUnicode(false);
            });

            modelBuilder.Entity<Dbkildesortering>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Avfallsnavn).IsUnicode(false);

                entity.Property(e => e.Behandlingsmate).IsUnicode(false);

                entity.Property(e => e.Behandlingssted).IsUnicode(false);

                entity.Property(e => e.UserId).IsUnicode(false);
            });

            modelBuilder.Entity<Dboptibag>(entity =>
            {
                entity.Property(e => e.Optiid).ValueGeneratedNever();

                entity.Property(e => e.Optinavn).IsUnicode(false);
            });

            modelBuilder.Entity<DbplukkHead>(entity =>
            {
                entity.Property(e => e.Ansvarlig).IsUnicode(false);

                entity.Property(e => e.Beskrivelse).IsUnicode(false);

                entity.Property(e => e.Innlogget).IsUnicode(false);

                entity.Property(e => e.Navn).IsUnicode(false);
            });

            modelBuilder.Entity<Dbplukkliste>(entity =>
            {
                entity.Property(e => e.AvNavn).IsUnicode(false);

                entity.HasOne(d => d.Plukk)
                    .WithMany(p => p.Dbplukklistes)
                    .HasForeignKey(d => d.PlukkId)
                    .HasConstraintName("FK_DBPlukkliste_DBPlukkHead");
            });

            modelBuilder.Entity<DbrestSite>(entity =>
            {
                entity.Property(e => e.AvNavn).IsUnicode(false);

                entity.Property(e => e.Sted).IsUnicode(false);

                entity.HasOne(d => d.DbanalyseSite)
                    .WithMany(p => p.DbrestSites)
                    .HasForeignKey(d => d.DbanalyseSiteId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DBRestSite_DBAnalyseSite");
            });

            modelBuilder.Entity<Dbrestavfall>(entity =>
            {
                entity.Property(e => e.Behandlingsmate).IsUnicode(false);

                entity.Property(e => e.Behandlingssted).IsUnicode(false);

                entity.Property(e => e.Restavfallsnavn).IsUnicode(false);

                entity.Property(e => e.UserId).IsUnicode(false);
            });

            modelBuilder.Entity<Dbresultat>(entity =>
            {
                entity.Property(e => e.AvNavn).IsUnicode(false);

                entity.Property(e => e.Sted).IsUnicode(false);
            });

            modelBuilder.Entity<Dbresultdetail>(entity =>
            {
                entity.Property(e => e.AvNavn).IsUnicode(false);

                entity.Property(e => e.Sted).IsUnicode(false);
            });

            modelBuilder.Entity<Dbsupport>(entity =>
            {
                entity.Property(e => e.SupportBody).IsUnicode(false);

                entity.Property(e => e.SupportFrom).IsUnicode(false);

                entity.Property(e => e.SupportHead).IsUnicode(false);

                entity.Property(e => e.SupportType).IsUnicode(false);
            });

            modelBuilder.Entity<Dbtransport>(entity =>
            {
                entity.Property(e => e.AvNavn).IsUnicode(false);

                entity.Property(e => e.Sted).IsUnicode(false);

                entity.Property(e => e.Transport).IsUnicode(false);
            });

            modelBuilder.Entity<Dcanswer>(entity =>
            {
                entity.Property(e => e.Dcanswer1).IsUnicode(false);

                entity.Property(e => e.Dcanswer2).IsUnicode(false);

                entity.Property(e => e.Dcanswer3).IsUnicode(false);

                entity.Property(e => e.Dcanswer4).IsUnicode(false);

                entity.Property(e => e.Dcanswer5).IsUnicode(false);

                entity.HasOne(d => d.Dcrecip)
                    .WithMany(p => p.Dcanswers)
                    .HasForeignKey(d => d.DcrecipId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DCAnswer_DCRecipients");
            });

            modelBuilder.Entity<Dcheading>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Dcdescription).IsUnicode(false);

                entity.Property(e => e.Dcname).IsUnicode(false);

                entity.Property(e => e.Dcpicture1).IsUnicode(false);

                entity.Property(e => e.Dcpicture2).IsUnicode(false);

                entity.Property(e => e.DcrefNo).IsUnicode(false);

                entity.Property(e => e.Dcspesification).IsUnicode(false);

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.Dcheadings)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DCHeading_COMPANY");
            });

            modelBuilder.Entity<Dcrecipient>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Recipients).IsUnicode(false);

                entity.HasOne(d => d.Dcheading)
                    .WithMany(p => p.Dcrecipients)
                    .HasForeignKey(d => d.DcheadingId)
                    .HasConstraintName("FK_DCRecipients_DCHeading");
            });

            modelBuilder.Entity<EPackAnalyse>(entity =>
            {
                entity.ToView("ePackAnalyse");

                entity.Property(e => e.FEUnit).IsUnicode(false);

                entity.Property(e => e.GroupName).IsUnicode(false);

                entity.Property(e => e.ProductGroupName).IsUnicode(false);

                entity.Property(e => e.ProductName).IsUnicode(false);
            });

            modelBuilder.Entity<EPackAnalyseGwp>(entity =>
            {
                entity.ToView("ePackAnalyseGWP");

                entity.Property(e => e.FEUnit).IsUnicode(false);

                entity.Property(e => e.Gwpname).IsUnicode(false);

                entity.Property(e => e.ProductGroupName).IsUnicode(false);

                entity.Property(e => e.ProductName).IsUnicode(false);
            });

            modelBuilder.Entity<EPackAnalysePacklist>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.PrecentResirk).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.EPackAnalysePacklists)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ePack_AnalysePacklist_ePack_Analyser");
            });

            modelBuilder.Entity<EPackAnalyser>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.ProductId).IsUnicode(false);

                entity.Property(e => e.ProductName).IsUnicode(false);
            });

            modelBuilder.Entity<EPackCertificate>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.EPackCertificates)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ePackDeclatation_COMPANY");
            });

            modelBuilder.Entity<EPackCertificateLine>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.HelpTxt).IsUnicode(false);

                entity.HasOne(d => d.Certificate)
                    .WithMany(p => p.EPackCertificateLines)
                    .HasForeignKey(d => d.CertificateId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ePackCertificateLine_ePackCertificate");
            });

            modelBuilder.Entity<EPackComponent>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.DecComments).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<EPackComponentsFile>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.ShareName).IsUnicode(false);
            });

            modelBuilder.Entity<EPackDeclarationLine>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.FilDoc).IsUnicode(false);

                entity.Property(e => e.HelpTxt).IsUnicode(false);
            });

            modelBuilder.Entity<EPackDeclarationType>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.DecComments).IsUnicode(false);

                entity.Property(e => e.FilDoc).IsUnicode(false);

                entity.Property(e => e.HelpTxt).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<EPackGwplevel1>(entity =>
            {
                entity.ToView("ePackGWPLevel1");

                entity.Property(e => e.FEUnit).IsUnicode(false);

                entity.Property(e => e.Gwpname).IsUnicode(false);

                entity.Property(e => e.MainGroupName).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<EPackGwplevel2>(entity =>
            {
                entity.ToView("ePackGWPLevel2");

                entity.Property(e => e.EpdmaterialName).IsUnicode(false);

                entity.Property(e => e.FEUnit).IsUnicode(false);

                entity.Property(e => e.Gwpname).IsUnicode(false);

                entity.Property(e => e.MainGroupName).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<EPackGwplevel3>(entity =>
            {
                entity.ToView("ePackGWPLevel3");

                entity.Property(e => e.FEUnit).IsUnicode(false);

                entity.Property(e => e.Gwpname).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.ProductGroupName).IsUnicode(false);

                entity.Property(e => e.ProductName).IsUnicode(false);
            });

            modelBuilder.Entity<EPackHeading>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.EPackHeadings)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ePackHeading_COMPANY");
            });

            modelBuilder.Entity<EPackLevel1>(entity =>
            {
                entity.ToView("ePackLevel1");

                entity.Property(e => e.FEUnit).IsUnicode(false);

                entity.Property(e => e.GroupName).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.ProductGroup).IsUnicode(false);
            });

            modelBuilder.Entity<EPackLevel2>(entity =>
            {
                entity.ToView("ePackLevel2");

                entity.Property(e => e.EpdmaterialName).IsUnicode(false);

                entity.Property(e => e.FEUnit).IsUnicode(false);

                entity.Property(e => e.GroupName).IsUnicode(false);

                entity.Property(e => e.MainGroupName).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<EPackLevel3>(entity =>
            {
                entity.ToView("ePackLevel3");

                entity.Property(e => e.FEUnit).IsUnicode(false);

                entity.Property(e => e.GroupName).IsUnicode(false);

                entity.Property(e => e.MainGroupName).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.ProductGroupName).IsUnicode(false);

                entity.Property(e => e.ProductId).IsUnicode(false);

                entity.Property(e => e.ProductName).IsUnicode(false);
            });

            modelBuilder.Entity<EPackTotalSalesLevel1>(entity =>
            {
                entity.ToView("ePackTotalSalesLevel1");
            });

            modelBuilder.Entity<EPackTotalSalesLevel2>(entity =>
            {
                entity.ToView("ePackTotalSalesLevel2");
            });

            modelBuilder.Entity<Epdanalysis>(entity =>
            {
                entity.Property(e => e.Anadescription1).IsUnicode(false);

                entity.Property(e => e.Anamarket).IsUnicode(false);

                entity.Property(e => e.Ananame).IsUnicode(false);

                entity.Property(e => e.Ananumber).IsUnicode(false);

                entity.Property(e => e.Anaspesification).IsUnicode(false);

                entity.Property(e => e.Anatech).IsUnicode(false);

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.Epdanalyses)
                    .HasForeignKey(d => d.ComId)
                    .HasConstraintName("FK_EPDAnalysis_COMPANY");
            });

            modelBuilder.Entity<EpdanalysisFase>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epdname).IsUnicode(false);

                entity.Property(e => e.Epdquantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.EpdrefName).IsUnicode(false);

                entity.Property(e => e.Epdunit).IsUnicode(false);

                entity.Property(e => e.UnitCalc).HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitCalcT).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdanalysisFases)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDAnalysisFases_EPDAnalysisList");
            });

            modelBuilder.Entity<EpdanalysisList>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);

                entity.HasOne(d => d.Epdanalysis)
                    .WithMany(p => p.EpdanalysisLists)
                    .HasForeignKey(d => d.EpdanalysisId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDAnalysisList_EPDAnalysis");
            });

            modelBuilder.Entity<EpdcalculationA1>(entity =>
            {
                entity.ToView("EPDCalculationA1");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationA1A31>(entity =>
            {
                entity.ToView("EPDCalculationA1-A3");
            });

            modelBuilder.Entity<EpdcalculationA1a3>(entity =>
            {
                entity.ToView("EPDCalculationA1A3");
            });

            modelBuilder.Entity<EpdcalculationA1a3forEpd>(entity =>
            {
                entity.ToView("EPDCalculationA1A3ForEPD");
            });

            modelBuilder.Entity<EpdcalculationA1a4forEpd>(entity =>
            {
                entity.ToView("EPDCalculationA1A4ForEPD");
            });

            modelBuilder.Entity<EpdcalculationA1a5forEpd>(entity =>
            {
                entity.ToView("EPDCalculationA1A5ForEPD");
            });

            modelBuilder.Entity<EpdcalculationA2>(entity =>
            {
                entity.ToView("EPDCalculationA2");
            });

            modelBuilder.Entity<EpdcalculationA2temp>(entity =>
            {
                entity.ToView("EPDCalculationA2Temp");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationA3>(entity =>
            {
                entity.ToView("EPDCalculationA3");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationA4>(entity =>
            {
                entity.ToView("EPDCalculationA4");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationA42>(entity =>
            {
                entity.ToView("EPDCalculationA4_2");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationA5>(entity =>
            {
                entity.ToView("EPDCalculationA5");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB1>(entity =>
            {
                entity.ToView("EPDCalculationB1");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB2>(entity =>
            {
                entity.ToView("EPDCalculationB2");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB3>(entity =>
            {
                entity.ToView("EPDCalculationB3");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB3bak>(entity =>
            {
                entity.ToView("EPDCalculationB3bak");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB4>(entity =>
            {
                entity.ToView("EPDCalculationB4");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB4bak>(entity =>
            {
                entity.ToView("EPDCalculationB4bak");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB5>(entity =>
            {
                entity.ToView("EPDCalculationB5");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB5bak>(entity =>
            {
                entity.ToView("EPDCalculationB5bak");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB6>(entity =>
            {
                entity.ToView("EPDCalculationB6");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB6bak>(entity =>
            {
                entity.ToView("EPDCalculationB6bak");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB7>(entity =>
            {
                entity.ToView("EPDCalculationB7");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB7bak>(entity =>
            {
                entity.ToView("EPDCalculationB7bak");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationC1>(entity =>
            {
                entity.ToView("EPDCalculationC1");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationC1bak>(entity =>
            {
                entity.ToView("EPDCalculationC1bak");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationC2>(entity =>
            {
                entity.ToView("EPDCalculationC2");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationC22>(entity =>
            {
                entity.ToView("EPDCalculationC2_2");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationC3>(entity =>
            {
                entity.ToView("EPDCalculationC3");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationC3bak>(entity =>
            {
                entity.ToView("EPDCalculationC3bak");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationC4>(entity =>
            {
                entity.ToView("EPDCalculationC4");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationC4bak>(entity =>
            {
                entity.ToView("EPDCalculationC4bak");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationD>(entity =>
            {
                entity.ToView("EPDCalculationD");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationDbak>(entity =>
            {
                entity.ToView("EPDCalculationDbak");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationTotal>(entity =>
            {
                entity.ToView("EPDCalculationTotal");

                entity.Property(e => e.Fase).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationTotalForEpd>(entity =>
            {
                entity.ToView("EPDCalculationTotalForEPD");

                entity.Property(e => e.Fase).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationTotalForEpden15804a1>(entity =>
            {
                entity.ToView("EPDCalculationTotalForEPDEN15804A1");

                entity.Property(e => e.Fase).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationTotalForEpden15804a2>(entity =>
            {
                entity.ToView("EPDCalculationTotalForEPDEN15804A2");

                entity.Property(e => e.Fase).IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationTotalForEpdtoDigi>(entity =>
            {
                entity.ToView("EPDCalculationTotalForEPDtoDigi");

                entity.Property(e => e.Fase).IsUnicode(false);
            });

            modelBuilder.Entity<Epdco2fase>(entity =>
            {
                entity.Property(e => e.Abiotic).HasDefaultValueSql("((0))");

                entity.Property(e => e.AbioticFossil).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ap).HasDefaultValueSql("((0))");

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.ComReuse).HasDefaultValueSql("((0))");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Ep).HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdname).IsUnicode(false);

                entity.Property(e => e.Epdquantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.EpdrefName).IsUnicode(false);

                entity.Property(e => e.Epdunit).IsUnicode(false);

                entity.Property(e => e.ExportedEnergyEl).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportedEnergyHeat).HasDefaultValueSql("((0))");

                entity.Property(e => e.Extra).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gwp).HasDefaultValueSql("((0))");

                entity.Property(e => e.HwDisposal).HasDefaultValueSql("((0))");

                entity.Property(e => e.Level).HasDefaultValueSql("((1))");

                entity.Property(e => e.MaterialsRecycling).HasDefaultValueSql("((0))");

                entity.Property(e => e.MeRecovery).HasDefaultValueSql("((0))");

                entity.Property(e => e.NetFreshWater).HasDefaultValueSql("((0))");

                entity.Property(e => e.NhwDisposal).HasDefaultValueSql("((0))");

                entity.Property(e => e.NrpEnergyCarrier).HasDefaultValueSql("((0))");

                entity.Property(e => e.NrpMaterial).HasDefaultValueSql("((0))");

                entity.Property(e => e.NrsFuels).HasDefaultValueSql("((0))");

                entity.Property(e => e.Odp).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pocp).HasDefaultValueSql("((0))");

                entity.Property(e => e.RpEnergyCarrier).HasDefaultValueSql("((0))");

                entity.Property(e => e.RpMaterial).HasDefaultValueSql("((0))");

                entity.Property(e => e.RsFuelsEnergy).HasDefaultValueSql("((0))");

                entity.Property(e => e.RwDisposed).HasDefaultValueSql("((0))");

                entity.Property(e => e.SecondaryMaterials).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sum1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sum2).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitCalc).HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitCalcT).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.Epdco2fases)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDCO2Fases_EPDHeading");
            });

            modelBuilder.Entity<Epdco2heading>(entity =>
            {
                entity.Property(e => e.A1).IsUnicode(false);

                entity.Property(e => e.A2).IsUnicode(false);

                entity.Property(e => e.A3).IsUnicode(false);

                entity.Property(e => e.A4).IsUnicode(false);

                entity.Property(e => e.A5).IsUnicode(false);

                entity.Property(e => e.B1).IsUnicode(false);

                entity.Property(e => e.B2).IsUnicode(false);

                entity.Property(e => e.B3).IsUnicode(false);

                entity.Property(e => e.B4).IsUnicode(false);

                entity.Property(e => e.B5).IsUnicode(false);

                entity.Property(e => e.B6).IsUnicode(false);

                entity.Property(e => e.B7).IsUnicode(false);

                entity.Property(e => e.C1).IsUnicode(false);

                entity.Property(e => e.C2).IsUnicode(false);

                entity.Property(e => e.C3).IsUnicode(false);

                entity.Property(e => e.C4).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.D1).IsUnicode(false);

                entity.Property(e => e.EpdaddTech).IsUnicode(false);

                entity.Property(e => e.Epdallocation).IsUnicode(false);

                entity.Property(e => e.Epdbibllio).IsUnicode(false);

                entity.Property(e => e.EpdbuildingLife).IsUnicode(false);

                entity.Property(e => e.EpdcutOff).IsUnicode(false);

                entity.Property(e => e.Epddangerous).HasDefaultValueSql("((0))");

                entity.Property(e => e.EpddataQuality).IsUnicode(false);

                entity.Property(e => e.EpddefaultEpdid).HasDefaultValueSql("((0))");

                entity.Property(e => e.Epddescription).IsUnicode(false);

                entity.Property(e => e.Epdeditor).IsUnicode(false);

                entity.Property(e => e.EpdindoorEnv).IsUnicode(false);

                entity.Property(e => e.EpdintNum).IsUnicode(false);

                entity.Property(e => e.Epdlanguage).IsUnicode(false);

                entity.Property(e => e.Epdlayout).HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdmarket).IsUnicode(false);

                entity.Property(e => e.Epdname).IsUnicode(false);

                entity.Property(e => e.Epdnumber).IsUnicode(false);

                entity.Property(e => e.Epdpcr).IsUnicode(false);

                entity.Property(e => e.Epdpicture2).IsUnicode(false);

                entity.Property(e => e.EpdpicturePath).IsUnicode(false);

                entity.Property(e => e.EpdproductLife).IsUnicode(false);

                entity.Property(e => e.EpdproductionSite).IsUnicode(false);

                entity.Property(e => e.Epdresponsible).IsUnicode(false);

                entity.Property(e => e.Epdscenarios).IsUnicode(false);

                entity.Property(e => e.Epdspesification).IsUnicode(false);

                entity.Property(e => e.EpdsysBound).IsUnicode(false);

                entity.Property(e => e.Epdtech).IsUnicode(false);

                entity.Property(e => e.Epdunit).IsUnicode(false);

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProductionSiteId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.Epdco2headings)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDCO2 Heading_COMPANY");
            });

            modelBuilder.Entity<EpdcustomerLine>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.HelpTxt).IsUnicode(false);

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.EpdcustomerLines)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDCustomerLine_COMPANY");
            });

            modelBuilder.Entity<Epddangerou>(entity =>
            {
                entity.Property(e => e.Among).IsUnicode(false);

                entity.Property(e => e.Casno).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpddangerousNavigation)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDDangerous_EPDHeading");
            });

            modelBuilder.Entity<EpddataEn15804a1>(entity =>
            {
                entity.Property(e => e.EpdprocessName).IsFixedLength(true);

                entity.Property(e => e.InternalComments).IsFixedLength(true);

                entity.Property(e => e.Version).IsFixedLength(true);

                entity.HasOne(d => d.ParentDataSet)
                    .WithMany(p => p.EpddataEn15804a1s)
                    .HasForeignKey(d => d.ParentDataSetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDDataEN15804A1_EPDDataSetDocumentation");
            });

            modelBuilder.Entity<EpddataEn15804a1registration>(entity =>
            {
                entity.Property(e => e.EpdprocessName).IsFixedLength(true);

                entity.Property(e => e.InternalComments).IsFixedLength(true);

                entity.Property(e => e.Version).IsFixedLength(true);

                entity.HasOne(d => d.ParentDataSet)
                    .WithMany(p => p.EpddataEn15804a1registrations)
                    .HasForeignKey(d => d.ParentDataSetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDDataEN15804A1Registrations_EPDDataSetDocumentationRegistrations");
            });

            modelBuilder.Entity<EpddataEn15804a1registrationsProject>(entity =>
            {
                entity.Property(e => e.EpdprocessName).IsFixedLength(true);

                entity.Property(e => e.InternalComments).IsFixedLength(true);

                entity.Property(e => e.Version).IsFixedLength(true);

                entity.HasOne(d => d.ParentDataSet)
                    .WithMany(p => p.EpddataEn15804a1registrationsProjects)
                    .HasForeignKey(d => d.ParentDataSetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDDataEN15804A1RegistrationsProjects_EPDDataSetDocumentationRegistrationsProjects");
            });

            modelBuilder.Entity<EpddataEn15804a2>(entity =>
            {
                entity.Property(e => e.EpdprocessName).IsFixedLength(true);

                entity.Property(e => e.InternalComments).IsFixedLength(true);

                entity.Property(e => e.Version).IsFixedLength(true);

                entity.HasOne(d => d.ParentDataSet)
                    .WithMany(p => p.EpddataEn15804a2s)
                    .HasForeignKey(d => d.ParentDataSetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDDataEN15804A2_EPDDataSetDocumentation");
            });

            modelBuilder.Entity<EpddataEn15804a2registration>(entity =>
            {
                entity.Property(e => e.EpdprocessName).IsFixedLength(true);

                entity.Property(e => e.InternalComments).IsFixedLength(true);

                entity.Property(e => e.Version).IsFixedLength(true);

                entity.HasOne(d => d.ParentDataSet)
                    .WithMany(p => p.EpddataEn15804a2registrations)
                    .HasForeignKey(d => d.ParentDataSetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDDataEN15804A2Registrations_EPDDataSetDocumentationRegistrations");
            });

            modelBuilder.Entity<EpddataEn15804a2registrationsProject>(entity =>
            {
                entity.Property(e => e.EpdprocessName).IsFixedLength(true);

                entity.Property(e => e.InternalComments).IsFixedLength(true);

                entity.Property(e => e.Version).IsFixedLength(true);

                entity.HasOne(d => d.ParentDataSet)
                    .WithMany(p => p.EpddataEn15804a2registrationsProjects)
                    .HasForeignKey(d => d.ParentDataSetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDDataEN15804A2RegistrationsProjects_EPDDataSetDocumentationRegistrationsProjects");
            });

            modelBuilder.Entity<EpddataSetDocumentation>(entity =>
            {
                entity.Property(e => e.BackgroundLcadataSet).IsFixedLength(true);

                entity.Property(e => e.Code).IsFixedLength(true);

                entity.Property(e => e.DataQualityAssessment).IsFixedLength(true);

                entity.Property(e => e.DataSource).IsFixedLength(true);

                entity.Property(e => e.DataSourceQuality).IsFixedLength(true);

                entity.Property(e => e.DatasetMainName).IsFixedLength(true);

                entity.Property(e => e.DescriptionLcareport).IsFixedLength(true);

                entity.Property(e => e.Geographical).IsFixedLength(true);

                entity.Property(e => e.InternalComments).IsFixedLength(true);

                entity.Property(e => e.InternalDescription).IsFixedLength(true);

                entity.Property(e => e.Location).IsFixedLength(true);

                entity.Property(e => e.ScenarioUnit).IsFixedLength(true);

                entity.Property(e => e.Technological).IsFixedLength(true);

                entity.Property(e => e.Temporal).IsFixedLength(true);

                entity.Property(e => e.Unit).IsFixedLength(true);

                entity.Property(e => e.Version).IsFixedLength(true);

                entity.Property(e => e.YearOfStudy).IsFixedLength(true);
            });

            modelBuilder.Entity<EpddataSetDocumentationRegistration>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.DatasetType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Epdname).IsUnicode(false);

                entity.Property(e => e.Epdquantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.EpdrefName).IsUnicode(false);

                entity.Property(e => e.Epdunit).IsUnicode(false);

                entity.Property(e => e.OldId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReCyclePer).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitCalc).HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitCalcT).HasDefaultValueSql("((1))");

                entity.Property(e => e.WastagePer).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpddataSetDocumentationRegistrations)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDDataSetDocumentationRegistrations_EPDHeading");
            });

            modelBuilder.Entity<EpddataSetDocumentationRegistrationsProject>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.DatasetType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Epdname).IsUnicode(false);

                entity.Property(e => e.Epdquantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.EpdrefName).IsUnicode(false);

                entity.Property(e => e.Epdunit).IsUnicode(false);

                entity.Property(e => e.OldId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductName).IsUnicode(false);

                entity.Property(e => e.ReCyclePer).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitCalc).HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitCalcT).HasDefaultValueSql("((1))");

                entity.Property(e => e.WastagePer).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpddataSetDocumentationRegistrationsProjects)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDDataSetDocumentationRegistrationsProjects_EPDProjectHeading");
            });

            modelBuilder.Entity<EpddataSetDocumentationSubProcess>(entity =>
            {
                entity.Property(e => e.Fase).IsFixedLength(true);

                entity.Property(e => e.Value).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EpddefaultA2>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epda2name).IsUnicode(false);
            });

            modelBuilder.Entity<EpddefaultA3>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epda3name).IsUnicode(false);

                entity.Property(e => e.Epda3unit).IsUnicode(false);
            });

            modelBuilder.Entity<EpddefaultA4>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epda4name).IsUnicode(false);
            });

            modelBuilder.Entity<EpdfunctionRegister>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Epdgroup>(entity =>
            {
                entity.Property(e => e.GroupName).IsUnicode(false);
            });

            modelBuilder.Entity<Epdheading>(entity =>
            {
                entity.Property(e => e.A1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.A2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.A3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.A4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.A5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.D1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.EpdaddTech).IsUnicode(false);

                entity.Property(e => e.Epdallocation).IsUnicode(false);

                entity.Property(e => e.Epdbibllio).IsUnicode(false);

                entity.Property(e => e.EpdbuildingLife).IsUnicode(false);

                entity.Property(e => e.EpdcomOnEnvImp).IsUnicode(false);

                entity.Property(e => e.EpdcutOff).IsUnicode(false);

                entity.Property(e => e.Epddangerous).HasDefaultValueSql("((0))");

                entity.Property(e => e.EpddataQuality).IsUnicode(false);

                entity.Property(e => e.EpddefaultEpdid).HasDefaultValueSql("((0))");

                entity.Property(e => e.Epddescription).IsUnicode(false);

                entity.Property(e => e.Epdeditor).IsUnicode(false);

                entity.Property(e => e.EpdfuncUnitDesc).IsUnicode(false);

                entity.Property(e => e.EpdindoorEnv).IsUnicode(false);

                entity.Property(e => e.EpdintNum).IsUnicode(false);

                entity.Property(e => e.Epdlanguage).IsUnicode(false);

                entity.Property(e => e.Epdlayout).HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdmarket).IsUnicode(false);

                entity.Property(e => e.Epdname).IsUnicode(false);

                entity.Property(e => e.Epdnumber).IsUnicode(false);

                entity.Property(e => e.Epdpcr).IsUnicode(false);

                entity.Property(e => e.EpdpcrId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdpicture2).IsUnicode(false);

                entity.Property(e => e.EpdpicturePath).IsUnicode(false);

                entity.Property(e => e.EpdproductLife).IsUnicode(false);

                entity.Property(e => e.EpdproductionSite).IsUnicode(false);

                entity.Property(e => e.Epdresponsible).IsUnicode(false);

                entity.Property(e => e.Epdscenarios).IsUnicode(false);

                entity.Property(e => e.Epdspesification).IsUnicode(false);

                entity.Property(e => e.EpdsubType).HasDefaultValueSql("((0))");

                entity.Property(e => e.EpdsysBound).IsUnicode(false);

                entity.Property(e => e.Epdtech).IsUnicode(false);

                entity.Property(e => e.Epdunit).IsUnicode(false);

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.PdfsourceDatasetId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProductFlowDatasetId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProductionSiteId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.Epdheadings)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDHeading_COMPANY");
            });

            modelBuilder.Entity<EpdheadingDigi>(entity =>
            {
                entity.Property(e => e.A1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.A2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.A3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.A4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.A5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.D1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.EpdUrl).IsUnicode(false);

                entity.Property(e => e.EpdaddTech).IsUnicode(false);

                entity.Property(e => e.Epdallocation).IsUnicode(false);

                entity.Property(e => e.Epdbibllio).IsUnicode(false);

                entity.Property(e => e.EpdbuildingLife).IsUnicode(false);

                entity.Property(e => e.EpdcomOnEnvImp).IsUnicode(false);

                entity.Property(e => e.EpdcutOff).IsUnicode(false);

                entity.Property(e => e.Epddangerous).HasDefaultValueSql("((0))");

                entity.Property(e => e.EpddataQuality).IsUnicode(false);

                entity.Property(e => e.EpddefaultEpdid).HasDefaultValueSql("((0))");

                entity.Property(e => e.Epddescription).IsUnicode(false);

                entity.Property(e => e.Epdeditor).IsUnicode(false);

                entity.Property(e => e.EpdfuncUnitDesc).IsUnicode(false);

                entity.Property(e => e.EpdindoorEnv).IsUnicode(false);

                entity.Property(e => e.EpdintNum).IsUnicode(false);

                entity.Property(e => e.Epdlanguage).IsUnicode(false);

                entity.Property(e => e.Epdlayout).HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdmarket).IsUnicode(false);

                entity.Property(e => e.Epdname).IsUnicode(false);

                entity.Property(e => e.Epdnumber).IsUnicode(false);

                entity.Property(e => e.Epdpcr).IsUnicode(false);

                entity.Property(e => e.EpdpcrId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdpicture2).IsUnicode(false);

                entity.Property(e => e.EpdpicturePath).IsUnicode(false);

                entity.Property(e => e.EpdproductLife).IsUnicode(false);

                entity.Property(e => e.EpdproductionSite).IsUnicode(false);

                entity.Property(e => e.Epdresponsible).IsUnicode(false);

                entity.Property(e => e.Epdscenarios).IsUnicode(false);

                entity.Property(e => e.Epdspesification).IsUnicode(false);

                entity.Property(e => e.EpdsubType).HasDefaultValueSql("((0))");

                entity.Property(e => e.EpdsysBound).IsUnicode(false);

                entity.Property(e => e.Epdtech).IsUnicode(false);

                entity.Property(e => e.Epdunit).IsUnicode(false);

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.PdfsourceDatasetId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProductFlowDatasetId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProductionSiteId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.EpdheadingDigis)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDHeadingDigi_COMPANY");
            });

            modelBuilder.Entity<Epdlayout>(entity =>
            {
                entity.Property(e => e.A1txt).IsUnicode(false);

                entity.Property(e => e.A2txt).IsUnicode(false);

                entity.Property(e => e.A3txt).IsUnicode(false);

                entity.Property(e => e.A4txt).IsUnicode(false);

                entity.Property(e => e.A5txt).IsUnicode(false);

                entity.Property(e => e.B1txt).IsUnicode(false);

                entity.Property(e => e.B2txt).IsUnicode(false);

                entity.Property(e => e.B3txt).IsUnicode(false);

                entity.Property(e => e.B4txt).IsUnicode(false);

                entity.Property(e => e.B5txt).IsUnicode(false);

                entity.Property(e => e.B6txt).IsUnicode(false);

                entity.Property(e => e.B7txt).IsUnicode(false);

                entity.Property(e => e.C1txt).IsUnicode(false);

                entity.Property(e => e.C2txt).IsUnicode(false);

                entity.Property(e => e.C3txt).IsUnicode(false);

                entity.Property(e => e.C4txt).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.D1txt).IsUnicode(false);

                entity.Property(e => e.Epd3party).IsUnicode(false);

                entity.Property(e => e.Epd3partyName).IsUnicode(false);

                entity.Property(e => e.Epd3partySubTxt).IsUnicode(false);

                entity.Property(e => e.Epda4heading).IsUnicode(false);

                entity.Property(e => e.Epda5heading).IsUnicode(false);

                entity.Property(e => e.Epdaddtech).IsUnicode(false);

                entity.Property(e => e.EpdaddtechTxt).IsUnicode(false);

                entity.Property(e => e.Epdallocation).IsUnicode(false);

                entity.Property(e => e.EpdallocationTxt).IsUnicode(false);

                entity.Property(e => e.Epdapproved).IsUnicode(false);

                entity.Property(e => e.EpdapprovedBy).IsUnicode(false);

                entity.Property(e => e.EpdapprovedByTxt).IsUnicode(false);

                entity.Property(e => e.EpdapprovedName).IsUnicode(false);

                entity.Property(e => e.EpdauthorHeading).IsUnicode(false);

                entity.Property(e => e.Epdb1heading).IsUnicode(false);

                entity.Property(e => e.Epdb2b3heading).IsUnicode(false);

                entity.Property(e => e.Epdb4b5heading).IsUnicode(false);

                entity.Property(e => e.Epdb6b7heading).IsUnicode(false);

                entity.Property(e => e.EpdbiblHead).IsUnicode(false);

                entity.Property(e => e.EpdbiblTxt).IsUnicode(false);

                entity.Property(e => e.Epdbuildinglife).IsUnicode(false);

                entity.Property(e => e.Epdc1c3c4heading).IsUnicode(false);

                entity.Property(e => e.Epdc2heading).IsUnicode(false);

                entity.Property(e => e.Epdc2headingTxt).IsUnicode(false);

                entity.Property(e => e.EpdcompanyNo).IsUnicode(false);

                entity.Property(e => e.Epdcompare).IsUnicode(false);

                entity.Property(e => e.EpdcompareTxt).IsUnicode(false);

                entity.Property(e => e.Epdcutoff).IsUnicode(false);

                entity.Property(e => e.EpdcutoffTxt).IsUnicode(false);

                entity.Property(e => e.Epdd1heading).IsUnicode(false);

                entity.Property(e => e.EpddataQuality).IsUnicode(false);

                entity.Property(e => e.EpddataQualityTxt).IsUnicode(false);

                entity.Property(e => e.Epddeclaration).IsUnicode(false);

                entity.Property(e => e.EpddeclarationNo).IsUnicode(false);

                entity.Property(e => e.EpddeclarationTxt).IsUnicode(false);

                entity.Property(e => e.EpddeclarationTxt2).IsUnicode(false);

                entity.Property(e => e.Epddecono).IsUnicode(false);

                entity.Property(e => e.Epddescription).IsUnicode(false);

                entity.Property(e => e.Epddoneby).IsUnicode(false);

                entity.Property(e => e.EpddonebyCon).IsUnicode(false);

                entity.Property(e => e.EpddonebyReg).IsUnicode(false);

                entity.Property(e => e.EpddonebyTxt).IsUnicode(false);

                entity.Property(e => e.Epdemail).IsUnicode(false);

                entity.Property(e => e.EpdendOfLifeFactorHeading).IsUnicode(false);

                entity.Property(e => e.EpdendOfLifeFactorSubTxt).IsUnicode(false);

                entity.Property(e => e.EpdendOfLifeWasteHeading).IsUnicode(false);

                entity.Property(e => e.EpdendOfLifeWasteSubTxt).IsUnicode(false);

                entity.Property(e => e.EpdenviromentHeading).IsUnicode(false);

                entity.Property(e => e.EpdenviromentSubTxt).IsUnicode(false);

                entity.Property(e => e.Epdextern).IsUnicode(false);

                entity.Property(e => e.EpdfuncUnit).IsUnicode(false);

                entity.Property(e => e.EpdgeneralHeading).IsUnicode(false);

                entity.Property(e => e.Epdheading).IsUnicode(false);

                entity.Property(e => e.EpdheadingSub).IsUnicode(false);

                entity.Property(e => e.Epdintern).IsUnicode(false);

                entity.Property(e => e.Epdlanguage).IsUnicode(false);

                entity.Property(e => e.Epdlcaheading).IsUnicode(false);

                entity.Property(e => e.EpdlcaresultHeading).IsUnicode(false);

                entity.Property(e => e.EpdlcaresultSubTxt).IsUnicode(false);

                entity.Property(e => e.EpdlcaresultSubTxt2).IsUnicode(false);

                entity.Property(e => e.EpdlcaresultTxt).IsUnicode(false);

                entity.Property(e => e.EpdlcasenariosHeading).IsUnicode(false);

                entity.Property(e => e.EpdlcasenariosHeadingTxt).IsUnicode(false);

                entity.Property(e => e.EpdlistName).IsUnicode(false);

                entity.Property(e => e.Epdlogo).IsUnicode(false);

                entity.Property(e => e.Epdlogo2).IsUnicode(false);

                entity.Property(e => e.EpdmainContact).IsUnicode(false);

                entity.Property(e => e.EpdmainPicture).IsUnicode(false);

                entity.Property(e => e.Epdname).IsUnicode(false);

                entity.Property(e => e.EpdnoaddDanger1).IsUnicode(false);

                entity.Property(e => e.EpdnoaddDanger2).IsUnicode(false);

                entity.Property(e => e.EpdnoaddDanger3).IsUnicode(false);

                entity.Property(e => e.EpdnoaddDanger4).IsUnicode(false);

                entity.Property(e => e.EpdnoaddDanger5).IsUnicode(false);

                entity.Property(e => e.EpdnoaddHeading).IsUnicode(false);

                entity.Property(e => e.EpdnoaddTxt).IsUnicode(false);

                entity.Property(e => e.Epdnoaddsubhead1).IsUnicode(false);

                entity.Property(e => e.Epdnoaddsubhead1Txt).IsUnicode(false);

                entity.Property(e => e.Epdnoaddsubhead2).IsUnicode(false);

                entity.Property(e => e.Epdnoaddsubhead2Txt).IsUnicode(false);

                entity.Property(e => e.Epdnoaddsubhead3).IsUnicode(false);

                entity.Property(e => e.Epdnoaddsubhead3Txt).IsUnicode(false);

                entity.Property(e => e.Epdnoaddsubhead4).IsUnicode(false);

                entity.Property(e => e.Epdnoaddsubhead4Txt).IsUnicode(false);

                entity.Property(e => e.Epdoperator).IsUnicode(false);

                entity.Property(e => e.EpdoperatorPublisher).IsUnicode(false);

                entity.Property(e => e.EpdoperatorTxt).IsUnicode(false);

                entity.Property(e => e.Epdowner).IsUnicode(false);

                entity.Property(e => e.EpdownerTxt).IsUnicode(false);

                entity.Property(e => e.Epdpcr).IsUnicode(false);

                entity.Property(e => e.Epdpcrtxt).IsUnicode(false);

                entity.Property(e => e.Epdphone).IsUnicode(false);

                entity.Property(e => e.Epdpicture1).IsUnicode(false);

                entity.Property(e => e.Epdpicture2).IsUnicode(false);

                entity.Property(e => e.Epdproducer).IsUnicode(false);

                entity.Property(e => e.EpdproductDescrition).IsUnicode(false);

                entity.Property(e => e.EpdproductDescritionTxt).IsUnicode(false);

                entity.Property(e => e.EpdproductHeading).IsUnicode(false);

                entity.Property(e => e.EpdproductLife).IsUnicode(false);

                entity.Property(e => e.EpdproductLifeTxt).IsUnicode(false);

                entity.Property(e => e.EpdproductMarket).IsUnicode(false);

                entity.Property(e => e.EpdproductMarketTxt).IsUnicode(false);

                entity.Property(e => e.EpdproductSpesification).IsUnicode(false);

                entity.Property(e => e.EpdproductSpesificationTable).IsUnicode(false);

                entity.Property(e => e.EpdproductSpesificationTxt).IsUnicode(false);

                entity.Property(e => e.EpdproductTechical).IsUnicode(false);

                entity.Property(e => e.EpdproductTechicalTxt).IsUnicode(false);

                entity.Property(e => e.EpdproductionSite).IsUnicode(false);

                entity.Property(e => e.Epdpublisher).IsUnicode(false);

                entity.Property(e => e.EpdpublisherTxt).IsUnicode(false);

                entity.Property(e => e.EpdpublishingNo).IsUnicode(false);

                entity.Property(e => e.EpdqualitySystem).IsUnicode(false);

                entity.Property(e => e.EpdresressourcesHeading).IsUnicode(false);

                entity.Property(e => e.EpdressourcesSubTxt).IsUnicode(false);

                entity.Property(e => e.Epdsign).IsUnicode(false);

                entity.Property(e => e.Epdstudy).IsUnicode(false);

                entity.Property(e => e.EpdsubTxt).IsUnicode(false);

                entity.Property(e => e.Epdsystem).IsUnicode(false);

                entity.Property(e => e.EpdsystemHeading).IsUnicode(false);

                entity.Property(e => e.EpdsystemSubTxt).IsUnicode(false);

                entity.Property(e => e.EpdsystemTxt).IsUnicode(false);

                entity.Property(e => e.EpdsystemTxt2).IsUnicode(false);

                entity.Property(e => e.EpdtoolDeveloperHeading).IsUnicode(false);

                entity.Property(e => e.EpdtoolInfo).IsUnicode(false);

                entity.Property(e => e.EpdtoolInfoTxt).IsUnicode(false);

                entity.Property(e => e.Epdunit).IsUnicode(false);

                entity.Property(e => e.EpdunitOption).IsUnicode(false);

                entity.Property(e => e.EpdunitOptionTxt).IsUnicode(false);

                entity.Property(e => e.Epdvalid).IsUnicode(false);

                entity.Property(e => e.Epdverificatior).IsUnicode(false);

                entity.Property(e => e.EpdverificatiorTxt).IsUnicode(false);

                entity.Property(e => e.Epdversion).IsUnicode(false);

                entity.Property(e => e.Epdweb).IsUnicode(false);

                entity.Property(e => e.Epdyear).IsUnicode(false);
            });

            modelBuilder.Entity<Epdlink>(entity =>
            {
                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.Epdlinks)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDLinks_EPDHeading");
            });

            modelBuilder.Entity<EpdmaterialList>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Range).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<EpdmaterialsCepe>(entity =>
            {
                entity.Property(e => e.DataQuality).IsUnicode(false);

                entity.Property(e => e.DataSource).IsUnicode(false);

                entity.Property(e => e.EpdmaterialId).IsUnicode(false);

                entity.Property(e => e.EpdmaterialName).IsUnicode(false);

                entity.Property(e => e.FEUnit).IsUnicode(false);

                entity.Property(e => e.HelpText).IsUnicode(false);

                entity.Property(e => e.InternalComments).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);

                entity.Property(e => e.UnitCalc).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EpdmaterialsSima>(entity =>
            {
                entity.Property(e => e.DataQuality).IsUnicode(false);

                entity.Property(e => e.DataSource).IsUnicode(false);

                entity.Property(e => e.EpdmaterialId).IsUnicode(false);

                entity.Property(e => e.EpdmaterialName).IsUnicode(false);

                entity.Property(e => e.FEUnit).IsUnicode(false);

                entity.Property(e => e.HelpText).IsUnicode(false);

                entity.Property(e => e.InternalComments).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);

                entity.Property(e => e.UnitCalc).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EpdmaterialsSimasubProcess>(entity =>
            {
                entity.Property(e => e.Fase).IsFixedLength(true);

                entity.Property(e => e.Value).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Epdpcr>(entity =>
            {
                entity.Property(e => e.Fase).IsUnicode(false);

                entity.Property(e => e.Pcrname).IsUnicode(false);

                entity.Property(e => e.Pcrnumber).IsUnicode(false);

                entity.Property(e => e.Pcrurl).IsUnicode(false);

                entity.Property(e => e.ProgramOperator).IsUnicode(false);

                entity.Property(e => e.Version).IsUnicode(false);
            });

            modelBuilder.Entity<Epdpcrlink>(entity =>
            {
                entity.Property(e => e.Fase).IsFixedLength(true);
            });

            modelBuilder.Entity<EpdprojectFase>(entity =>
            {
                entity.Property(e => e.Abiotic).HasDefaultValueSql("((0))");

                entity.Property(e => e.AbioticFossil).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ap).HasDefaultValueSql("((0))");

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.ComReuse).HasDefaultValueSql("((0))");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Ep).HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdname).IsUnicode(false);

                entity.Property(e => e.Epdquantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.EpdrefName).IsUnicode(false);

                entity.Property(e => e.Epdunit).IsUnicode(false);

                entity.Property(e => e.ExportedEnergyEl).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportedEnergyHeat).HasDefaultValueSql("((0))");

                entity.Property(e => e.Extra).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gwp).HasDefaultValueSql("((0))");

                entity.Property(e => e.HwDisposal).HasDefaultValueSql("((0))");

                entity.Property(e => e.Level).HasDefaultValueSql("((1))");

                entity.Property(e => e.MaterialsRecycling).HasDefaultValueSql("((0))");

                entity.Property(e => e.MeRecovery).HasDefaultValueSql("((0))");

                entity.Property(e => e.NetFreshWater).HasDefaultValueSql("((0))");

                entity.Property(e => e.NhwDisposal).HasDefaultValueSql("((0))");

                entity.Property(e => e.NrpEnergyCarrier).HasDefaultValueSql("((0))");

                entity.Property(e => e.NrpMaterial).HasDefaultValueSql("((0))");

                entity.Property(e => e.NrsFuels).HasDefaultValueSql("((0))");

                entity.Property(e => e.Odp).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pocp).HasDefaultValueSql("((0))");

                entity.Property(e => e.RpEnergyCarrier).HasDefaultValueSql("((0))");

                entity.Property(e => e.RpMaterial).HasDefaultValueSql("((0))");

                entity.Property(e => e.RsFuelsEnergy).HasDefaultValueSql("((0))");

                entity.Property(e => e.RwDisposed).HasDefaultValueSql("((0))");

                entity.Property(e => e.SecondaryMaterials).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sum1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sum2).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitCalc).HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitCalcT).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdprojectFases)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDProjectFases_EPDHeading");
            });

            modelBuilder.Entity<EpdprojectGroupSetup>(entity =>
            {
                entity.Property(e => e.GroupName).IsFixedLength(true);
            });

            modelBuilder.Entity<EpdprojectHeading>(entity =>
            {
                entity.Property(e => e.A1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.A2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.A3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.A4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.A5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.D1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.EpdaddTech).IsUnicode(false);

                entity.Property(e => e.Epdallocation).IsUnicode(false);

                entity.Property(e => e.Epdbibllio).IsUnicode(false);

                entity.Property(e => e.EpdbuildingLife).IsUnicode(false);

                entity.Property(e => e.EpdcutOff).IsUnicode(false);

                entity.Property(e => e.Epddangerous).HasDefaultValueSql("((0))");

                entity.Property(e => e.EpddataQuality).IsUnicode(false);

                entity.Property(e => e.EpddefaultEpdid).HasDefaultValueSql("((0))");

                entity.Property(e => e.Epddescription).IsUnicode(false);

                entity.Property(e => e.Epdeditor).IsUnicode(false);

                entity.Property(e => e.EpdindoorEnv).IsUnicode(false);

                entity.Property(e => e.EpdintNum).IsUnicode(false);

                entity.Property(e => e.Epdlanguage).IsUnicode(false);

                entity.Property(e => e.Epdlayout).HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdmarket).IsUnicode(false);

                entity.Property(e => e.Epdname).IsUnicode(false);

                entity.Property(e => e.Epdnumber).IsUnicode(false);

                entity.Property(e => e.Epdpcr).IsUnicode(false);

                entity.Property(e => e.Epdpicture2).IsUnicode(false);

                entity.Property(e => e.EpdpicturePath).IsUnicode(false);

                entity.Property(e => e.EpdproductLife).IsUnicode(false);

                entity.Property(e => e.EpdproductionSite).IsUnicode(false);

                entity.Property(e => e.Epdresponsible).IsUnicode(false);

                entity.Property(e => e.Epdscenarios).IsUnicode(false);

                entity.Property(e => e.Epdspesification).IsUnicode(false);

                entity.Property(e => e.EpdsysBound).IsUnicode(false);

                entity.Property(e => e.Epdtech).IsUnicode(false);

                entity.Property(e => e.Epdunit).IsUnicode(false);

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProductionSiteId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.EpdprojectHeadings)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDProjectHeading_COMPANY");
            });

            modelBuilder.Entity<EpdregisterMain>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Fase)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<EpdregistrationA1>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epda1name).IsUnicode(false);

                entity.Property(e => e.Epda1unit).IsUnicode(false);

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationA1s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationA1_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationA2>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epda2name).IsUnicode(false);

                entity.HasOne(d => d.EpdregistrationA1)
                    .WithMany(p => p.EpdregistrationA2s)
                    .HasForeignKey(d => d.EpdregistrationA1id)
                    .HasConstraintName("FK_EPDRegistrationA2_EPDRegistrationA1");
            });

            modelBuilder.Entity<EpdregistrationA3>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epda3name).IsUnicode(false);

                entity.Property(e => e.Epda3unit).IsUnicode(false);

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationA3s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationA3_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationA4>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epda4name).IsUnicode(false);

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationA4s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationA4_EPDHeading1");
            });

            modelBuilder.Entity<EpdregistrationA5>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epda5name).IsUnicode(false);

                entity.Property(e => e.Epda5unit).IsUnicode(false);

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationA5s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationA5_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationB1>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epdb1name).IsUnicode(false);

                entity.Property(e => e.Epdb1unit).IsUnicode(false);

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationB1s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationB1_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationB2>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epdb2name).IsUnicode(false);

                entity.Property(e => e.Epdb2unit).IsUnicode(false);

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationB2s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationB2_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationB3>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epdb3name).IsUnicode(false);

                entity.Property(e => e.Epdb3unit).IsUnicode(false);

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationB3s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationB3_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationB4>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epdb4name).IsUnicode(false);

                entity.Property(e => e.Epdb4unit).IsUnicode(false);

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationB4s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationB4_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationB5>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epdb5name).IsUnicode(false);

                entity.Property(e => e.Epdb5unit).IsUnicode(false);

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationB5s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationB5_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationB6>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epdb6name).IsUnicode(false);

                entity.Property(e => e.Epdb6unit).IsUnicode(false);

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationB6s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationB6_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationB7>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epdb7name).IsUnicode(false);

                entity.Property(e => e.Epdb7unit).IsUnicode(false);

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationB7s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationB7_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationC1>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epdc1name).IsUnicode(false);

                entity.Property(e => e.Epdc1unit).IsUnicode(false);

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationC1s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationC1_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationC2>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epdc2name).IsUnicode(false);

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationC2s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationC2_EPDHeading1");
            });

            modelBuilder.Entity<EpdregistrationC3>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epdc3name).IsUnicode(false);

                entity.Property(e => e.Epdc3unit).IsUnicode(false);

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationC3s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationC3_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationC4>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epdc4name).IsUnicode(false);

                entity.Property(e => e.Epdc4unit).IsUnicode(false);

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationC4s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationC4_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationD1>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epdd1name).IsUnicode(false);

                entity.Property(e => e.Epdd1unit).IsUnicode(false);

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationD1s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationD1_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationFase>(entity =>
            {
                entity.Property(e => e.Abiotic).HasDefaultValueSql("((0))");

                entity.Property(e => e.AbioticFossil).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ap).HasDefaultValueSql("((0))");

                entity.Property(e => e.ComReuse).HasDefaultValueSql("((0))");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Ep).HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdname).IsUnicode(false);

                entity.Property(e => e.Epdquantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.EpdrefName).IsUnicode(false);

                entity.Property(e => e.Epdunit).IsUnicode(false);

                entity.Property(e => e.ExportedEnergyEl).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportedEnergyHeat).HasDefaultValueSql("((0))");

                entity.Property(e => e.Extra).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gwp).HasDefaultValueSql("((0))");

                entity.Property(e => e.HwDisposal).HasDefaultValueSql("((0))");

                entity.Property(e => e.Level).HasDefaultValueSql("((1))");

                entity.Property(e => e.MaterialsRecycling).HasDefaultValueSql("((0))");

                entity.Property(e => e.MeRecovery).HasDefaultValueSql("((0))");

                entity.Property(e => e.NetFreshWater).HasDefaultValueSql("((0))");

                entity.Property(e => e.NhwDisposal).HasDefaultValueSql("((0))");

                entity.Property(e => e.NrpEnergyCarrier).HasDefaultValueSql("((0))");

                entity.Property(e => e.NrpMaterial).HasDefaultValueSql("((0))");

                entity.Property(e => e.NrsFuels).HasDefaultValueSql("((0))");

                entity.Property(e => e.Odp).HasDefaultValueSql("((0))");

                entity.Property(e => e.OldId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pocp).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReCyclePer).HasDefaultValueSql("((0))");

                entity.Property(e => e.RpEnergyCarrier).HasDefaultValueSql("((0))");

                entity.Property(e => e.RpMaterial).HasDefaultValueSql("((0))");

                entity.Property(e => e.RsFuelsEnergy).HasDefaultValueSql("((0))");

                entity.Property(e => e.RwDisposed).HasDefaultValueSql("((0))");

                entity.Property(e => e.SecondaryMaterials).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sum1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sum2).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitCalc).HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitCalcT).HasDefaultValueSql("((1))");

                entity.Property(e => e.WastagePer).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationFases)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationFases_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationFasesDigi>(entity =>
            {
                entity.Property(e => e.A1).HasDefaultValueSql("((0))");

                entity.Property(e => e.A2).HasDefaultValueSql("((0))");

                entity.Property(e => e.A3).HasDefaultValueSql("((0))");

                entity.Property(e => e.A4).HasDefaultValueSql("((0))");

                entity.Property(e => e.A5).HasDefaultValueSql("((0))");

                entity.Property(e => e.B1).HasDefaultValueSql("((0))");

                entity.Property(e => e.B2).HasDefaultValueSql("((0))");

                entity.Property(e => e.B3).HasDefaultValueSql("((0))");

                entity.Property(e => e.B4).HasDefaultValueSql("((0))");

                entity.Property(e => e.B5).HasDefaultValueSql("((0))");

                entity.Property(e => e.B6).HasDefaultValueSql("((0))");

                entity.Property(e => e.B7).HasDefaultValueSql("((0))");

                entity.Property(e => e.C1).HasDefaultValueSql("((0))");

                entity.Property(e => e.C2).HasDefaultValueSql("((0))");

                entity.Property(e => e.C3).HasDefaultValueSql("((0))");

                entity.Property(e => e.C4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.D1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdname).IsUnicode(false);

                entity.Property(e => e.Epdquantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdunit).IsUnicode(false);

                entity.Property(e => e.UnitCalc).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationFasesDigis)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationFasesDigi_EPDHeading");
            });

            modelBuilder.Entity<Epdshare>(entity =>
            {
                entity.Property(e => e.Contact).IsFixedLength(true);

                entity.Property(e => e.Status).IsFixedLength(true);

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.Epdshares)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDShare_EPDHeading");
            });

            modelBuilder.Entity<EpdsubType>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Fordeling>(entity =>
            {
                entity.Property(e => e.Sortering).IsFixedLength(true);
            });

            modelBuilder.Entity<Impact>(entity =>
            {
                entity.Property(e => e.ImpactCategory).IsUnicode(false);

                entity.Property(e => e.ImpactId).IsUnicode(false);

                entity.Property(e => e.ImpactScalar).IsUnicode(false);

                entity.Property(e => e.ProcessId).IsUnicode(false);
            });

            modelBuilder.Entity<ImpactCat>(entity =>
            {
                entity.Property(e => e.Column0).IsUnicode(false);

                entity.Property(e => e.Column1).IsUnicode(false);
            });

            modelBuilder.Entity<LanguageListIso6391>(entity =>
            {
                entity.Property(e => e.Iso6391code).IsUnicode(false);

                entity.Property(e => e.LanguageName).IsUnicode(false);
            });

            modelBuilder.Entity<Layout>(entity =>
            {
                entity.Property(e => e.A1txt).IsUnicode(false);

                entity.Property(e => e.A2txt).IsUnicode(false);

                entity.Property(e => e.A3txt).IsUnicode(false);

                entity.Property(e => e.A4txt).IsUnicode(false);

                entity.Property(e => e.A5txt).IsUnicode(false);

                entity.Property(e => e.B1txt).IsUnicode(false);

                entity.Property(e => e.B2txt).IsUnicode(false);

                entity.Property(e => e.B3txt).IsUnicode(false);

                entity.Property(e => e.B4txt).IsUnicode(false);

                entity.Property(e => e.B5txt).IsUnicode(false);

                entity.Property(e => e.B6txt).IsUnicode(false);

                entity.Property(e => e.B7txt).IsUnicode(false);

                entity.Property(e => e.C1txt).IsUnicode(false);

                entity.Property(e => e.C2txt).IsUnicode(false);

                entity.Property(e => e.C3txt).IsUnicode(false);

                entity.Property(e => e.C4txt).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.D1txt).IsUnicode(false);

                entity.Property(e => e.Date).IsUnicode(false);

                entity.Property(e => e.Epd3party).IsUnicode(false);

                entity.Property(e => e.Epd3partyName).IsUnicode(false);

                entity.Property(e => e.Epd3partySubTxt).IsUnicode(false);

                entity.Property(e => e.Epda4heading).IsUnicode(false);

                entity.Property(e => e.Epda5heading).IsUnicode(false);

                entity.Property(e => e.Epdallocation).IsUnicode(false);

                entity.Property(e => e.EpdallocationTxt).IsUnicode(false);

                entity.Property(e => e.Epdapproved).IsUnicode(false);

                entity.Property(e => e.EpdapprovedBy).IsUnicode(false);

                entity.Property(e => e.EpdapprovedByTxt).IsUnicode(false);

                entity.Property(e => e.EpdapprovedName).IsUnicode(false);

                entity.Property(e => e.Epdb1heading).IsUnicode(false);

                entity.Property(e => e.Epdb2b3heading).IsUnicode(false);

                entity.Property(e => e.Epdb4b5heading).IsUnicode(false);

                entity.Property(e => e.Epdb6b7heading).IsUnicode(false);

                entity.Property(e => e.EpdbiblHead).IsUnicode(false);

                entity.Property(e => e.EpdbiblTxt).IsUnicode(false);

                entity.Property(e => e.Epdc1c3c4heading).IsUnicode(false);

                entity.Property(e => e.Epdc2heading).IsUnicode(false);

                entity.Property(e => e.Epdc2headingTxt).IsUnicode(false);

                entity.Property(e => e.EpdcompanyNo).IsUnicode(false);

                entity.Property(e => e.Epdcompare).IsUnicode(false);

                entity.Property(e => e.EpdcompareTxt).IsUnicode(false);

                entity.Property(e => e.Epdcutoff).IsUnicode(false);

                entity.Property(e => e.EpdcutoffTxt).IsUnicode(false);

                entity.Property(e => e.Epdd1heading).IsUnicode(false);

                entity.Property(e => e.EpddataQuality).IsUnicode(false);

                entity.Property(e => e.EpddataQualityTxt).IsUnicode(false);

                entity.Property(e => e.Epddeclaration).IsUnicode(false);

                entity.Property(e => e.EpddeclarationNo).IsUnicode(false);

                entity.Property(e => e.EpddeclarationTxt).IsUnicode(false);

                entity.Property(e => e.EpddeclarationTxt2).IsUnicode(false);

                entity.Property(e => e.Epddecono).IsUnicode(false);

                entity.Property(e => e.Epddescription).IsUnicode(false);

                entity.Property(e => e.Epddoneby).IsUnicode(false);

                entity.Property(e => e.EpddonebyCon).IsUnicode(false);

                entity.Property(e => e.EpddonebyReg).IsUnicode(false);

                entity.Property(e => e.EpddonebyTxt).IsUnicode(false);

                entity.Property(e => e.EpdendOfLifeFactorHeading).IsUnicode(false);

                entity.Property(e => e.EpdendOfLifeFactorSubTxt).IsUnicode(false);

                entity.Property(e => e.EpdendOfLifeWasteHeading).IsUnicode(false);

                entity.Property(e => e.EpdendOfLifeWasteSubTxt).IsUnicode(false);

                entity.Property(e => e.EpdenviromentHeading).IsUnicode(false);

                entity.Property(e => e.EpdenviromentSubTxt).IsUnicode(false);

                entity.Property(e => e.Epdextern).IsUnicode(false);

                entity.Property(e => e.EpdgeneralHeading).IsUnicode(false);

                entity.Property(e => e.Epdheading).IsUnicode(false);

                entity.Property(e => e.EpdheadingSub).IsUnicode(false);

                entity.Property(e => e.Epdintern).IsUnicode(false);

                entity.Property(e => e.Epdlanguage).IsUnicode(false);

                entity.Property(e => e.Epdlcaheading).IsUnicode(false);

                entity.Property(e => e.EpdlcaresultHeading).IsUnicode(false);

                entity.Property(e => e.EpdlcaresultTxt).IsUnicode(false);

                entity.Property(e => e.EpdlcasenariosHeading).IsUnicode(false);

                entity.Property(e => e.EpdlcasenariosHeadingTxt).IsUnicode(false);

                entity.Property(e => e.EpdlistName).IsUnicode(false);

                entity.Property(e => e.Epdlogo).IsUnicode(false);

                entity.Property(e => e.EpdmainPicture).IsUnicode(false);

                entity.Property(e => e.Epdname).IsUnicode(false);

                entity.Property(e => e.EpdnoaddDanger1).IsUnicode(false);

                entity.Property(e => e.EpdnoaddDanger2).IsUnicode(false);

                entity.Property(e => e.EpdnoaddDanger3).IsUnicode(false);

                entity.Property(e => e.EpdnoaddDanger4).IsUnicode(false);

                entity.Property(e => e.EpdnoaddHeading).IsUnicode(false);

                entity.Property(e => e.EpdnoaddTxt).IsUnicode(false);

                entity.Property(e => e.Epdnoaddsubhead1).IsUnicode(false);

                entity.Property(e => e.Epdnoaddsubhead1Txt).IsUnicode(false);

                entity.Property(e => e.Epdnoaddsubhead2).IsUnicode(false);

                entity.Property(e => e.Epdnoaddsubhead2Txt).IsUnicode(false);

                entity.Property(e => e.Epdnoaddsubhead3).IsUnicode(false);

                entity.Property(e => e.Epdnoaddsubhead3Txt).IsUnicode(false);

                entity.Property(e => e.Epdoperator).IsUnicode(false);

                entity.Property(e => e.EpdoperatorTxt).IsUnicode(false);

                entity.Property(e => e.Epdowner).IsUnicode(false);

                entity.Property(e => e.EpdownerTxt).IsUnicode(false);

                entity.Property(e => e.Epdpcr).IsUnicode(false);

                entity.Property(e => e.Epdpcrtxt).IsUnicode(false);

                entity.Property(e => e.Epdpicture1).IsUnicode(false);

                entity.Property(e => e.Epdpicture2).IsUnicode(false);

                entity.Property(e => e.Epdproducer).IsUnicode(false);

                entity.Property(e => e.EpdproductDescrition).IsUnicode(false);

                entity.Property(e => e.EpdproductDescritionTxt).IsUnicode(false);

                entity.Property(e => e.EpdproductHeading).IsUnicode(false);

                entity.Property(e => e.EpdproductLife).IsUnicode(false);

                entity.Property(e => e.EpdproductLifeTxt).IsUnicode(false);

                entity.Property(e => e.EpdproductMarket).IsUnicode(false);

                entity.Property(e => e.EpdproductMarketTxt).IsUnicode(false);

                entity.Property(e => e.EpdproductSpesification).IsUnicode(false);

                entity.Property(e => e.EpdproductSpesificationTable).IsUnicode(false);

                entity.Property(e => e.EpdproductSpesificationTxt).IsUnicode(false);

                entity.Property(e => e.EpdproductTechical).IsUnicode(false);

                entity.Property(e => e.EpdproductTechicalTxt).IsUnicode(false);

                entity.Property(e => e.EpdproductionSite).IsUnicode(false);

                entity.Property(e => e.Epdpublisher).IsUnicode(false);

                entity.Property(e => e.EpdpublisherTxt).IsUnicode(false);

                entity.Property(e => e.EpdpublishingNo).IsUnicode(false);

                entity.Property(e => e.EpdqualitySystem).IsUnicode(false);

                entity.Property(e => e.EpdresressourcesHeading).IsUnicode(false);

                entity.Property(e => e.EpdressourcesSubTxt).IsUnicode(false);

                entity.Property(e => e.Epdstudy).IsUnicode(false);

                entity.Property(e => e.EpdsubTxt).IsUnicode(false);

                entity.Property(e => e.Epdsystem).IsUnicode(false);

                entity.Property(e => e.EpdsystemHeading).IsUnicode(false);

                entity.Property(e => e.EpdsystemSubTxt).IsUnicode(false);

                entity.Property(e => e.EpdsystemTxt).IsUnicode(false);

                entity.Property(e => e.EpdsystemTxt2).IsUnicode(false);

                entity.Property(e => e.Epdunit).IsUnicode(false);

                entity.Property(e => e.EpdunitOption).IsUnicode(false);

                entity.Property(e => e.EpdunitOptionTxt).IsUnicode(false);

                entity.Property(e => e.Epdvalid).IsUnicode(false);

                entity.Property(e => e.Epdverificatior).IsUnicode(false);

                entity.Property(e => e.EpdverificatiorTxt).IsUnicode(false);

                entity.Property(e => e.Epdversion).IsUnicode(false);

                entity.Property(e => e.Epdyear).IsUnicode(false);

                entity.Property(e => e.Id).IsUnicode(false);

                entity.Property(e => e.UserId).IsUnicode(false);
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.NwsDetail).IsUnicode(false);

                entity.Property(e => e.NwsHead).IsUnicode(false);

                entity.Property(e => e.NwsId).ValueGeneratedOnAdd();

                entity.Property(e => e.NwsPicture).IsUnicode(false);
            });

            modelBuilder.Entity<PackElementer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<PackMaterialList>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.PrecentResirk).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PackMaterialListSelection>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.PrecentResirk).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.ProductLine)
                    .WithMany(p => p.PackMaterialListSelections)
                    .HasForeignKey(d => d.ProductLineId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PackMaterialListSelection_ProductsLine");
            });

            modelBuilder.Entity<Process>(entity =>
            {
                entity.Property(e => e.Column0).IsUnicode(false);

                entity.Property(e => e.Column1).IsUnicode(false);

                entity.Property(e => e.Column2).IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.ProductId).IsUnicode(false);

                entity.Property(e => e.ProductName).IsUnicode(false);
            });

            modelBuilder.Entity<ProductsLine>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.PartOfSelection).HasDefaultValueSql("((1))");

                entity.Property(e => e.ProductId).IsUnicode(false);

                entity.Property(e => e.ProductName).IsUnicode(false);

                entity.HasOne(d => d.Head)
                    .WithMany(p => p.ProductsLines)
                    .HasForeignKey(d => d.HeadId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductsLine_ePackHeading");
            });

            modelBuilder.Entity<ProgramModule>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.ProgramFile).IsUnicode(false);
            });

            modelBuilder.Entity<SystemReportLayoutList>(entity =>
            {
                entity.Property(e => e.Description).IsFixedLength(true);

                entity.Property(e => e.LayoutFile).IsFixedLength(true);

                entity.Property(e => e.LayoutName).IsFixedLength(true);
            });

            modelBuilder.Entity<TransportDistance>(entity =>
            {
                entity.Property(e => e.TransportDistComment).IsUnicode(false);

                entity.Property(e => e.TransportDistName).IsUnicode(false);
            });

            modelBuilder.Entity<TransportExp>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Epda1name).IsUnicode(false);

                entity.Property(e => e.Epda2name).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<TransportExpHeader>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Transportname).IsUnicode(false);

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.TransportExpHeaders)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TransportExpHeader_COMPANY");
            });

            modelBuilder.Entity<TransportHead>(entity =>
            {
                entity.Property(e => e.TransportComments).IsUnicode(false);

                entity.Property(e => e.TransportName).IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UsrAdd).IsUnicode(false);

                entity.Property(e => e.UsrCity).IsUnicode(false);

                entity.Property(e => e.UsrComments).IsUnicode(false);

                entity.Property(e => e.UsrCompid).HasDefaultValueSql("((0))");

                entity.Property(e => e.UsrCreatedttm).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsrEmail).IsUnicode(false);

                entity.Property(e => e.UsrFullname).IsUnicode(false);

                entity.Property(e => e.UsrGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.UsrLoginname).IsUnicode(false);

                entity.Property(e => e.UsrOrganization).IsUnicode(false);

                entity.Property(e => e.UsrPassword).IsUnicode(false);

                entity.Property(e => e.UsrPhone1).IsUnicode(false);

                entity.Property(e => e.UsrPhone2).IsUnicode(false);

                entity.Property(e => e.UsrProid).IsUnicode(false);

                entity.Property(e => e.UsrResetpwd).IsUnicode(false);

                entity.Property(e => e.UsrStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsrZip).IsUnicode(false);
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.UtpName).IsUnicode(false);

                entity.Property(e => e.Utpid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Usrlink>(entity =>
            {
                entity.HasOne(d => d.Usr)
                    .WithMany(p => p.Usrlinks)
                    .HasForeignKey(d => d.UsrId)
                    .HasConstraintName("FK_USRLinks_USERS");
            });

            modelBuilder.Entity<WcmainGroup>(entity =>
            {
                entity.Property(e => e.MainGroup).IsUnicode(false);
            });

            modelBuilder.Entity<Wcparameter>(entity =>
            {
                entity.Property(e => e.Sector).IsUnicode(false);
            });

            modelBuilder.Entity<Xmlunit>(entity =>
            {
                entity.Property(e => e.FactorName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
