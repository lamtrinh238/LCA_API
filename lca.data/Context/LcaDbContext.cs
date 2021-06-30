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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AspstateTempApplication>(entity =>
            {
                entity.HasKey(e => e.AppId)
                    .HasName("PK__ASPState__8E2CF7F9C3D83A5A");

                entity.ToTable("ASPStateTempApplications");

                entity.HasIndex(e => e.AppName, "Index_AppName");

                entity.Property(e => e.AppId).ValueGeneratedNever();

                entity.Property(e => e.AppName)
                    .IsRequired()
                    .HasMaxLength(280)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<AspstateTempSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PK__ASPState__C9F492908BE6A30C");

                entity.ToTable("ASPStateTempSessions");

                entity.HasIndex(e => e.Expires, "Index_Expires");

                entity.Property(e => e.SessionId).HasMaxLength(88);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Expires).HasColumnType("datetime");

                entity.Property(e => e.LockDate).HasColumnType("datetime");

                entity.Property(e => e.LockDateLocal).HasColumnType("datetime");

                entity.Property(e => e.SessionItemLong).HasColumnType("image");

                entity.Property(e => e.SessionItemShort).HasMaxLength(7000);
            });

            modelBuilder.Entity<Calheading>(entity =>
            {
                entity.ToTable("CALHeading");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CalBiogassTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CalBiorestTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Calbiogass).HasColumnName("CALbiogass");

                entity.Property(e => e.Calbiomeet)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CALbiomeet");

                entity.Property(e => e.Calbiopig)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CALbiopig");

                entity.Property(e => e.Calbiorest).HasColumnName("CALbiorest");

                entity.Property(e => e.Calburnrate).HasColumnName("CALburnrate");

                entity.Property(e => e.CalburnrateTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Caldate)
                    .HasColumnType("date")
                    .HasColumnName("CALDate");

                entity.Property(e => e.Caldistance)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CALdistance");

                entity.Property(e => e.Caldistance2)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CALdistance2");

                entity.Property(e => e.Caldistance3).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Caldistance4).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Calname)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("CALName");

                entity.Property(e => e.Calquantity)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CALquantity");

                entity.Property(e => e.Calreference).HasColumnName("CALreference");

                entity.Property(e => e.CalreferenceTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Calstatus).HasColumnName("CALStatus");

                entity.Property(e => e.Calstorage).HasColumnName("CALstorage");

                entity.Property(e => e.CalstorageTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.Calheadings)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CALHeading_COMPANY");
            });

            modelBuilder.Entity<ClientGroup>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Co2materialsSima>(entity =>
            {
                entity.ToTable("CO2MaterialsSIMA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(22, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DataQuality)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.EpdmaterialId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDMaterialID");

                entity.Property(e => e.EpdmaterialName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("EPDMaterialName");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(22, 12)");

                entity.Property(e => e.FEConsumption)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("F_E_consumption");

                entity.Property(e => e.FEUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("F_E_Unit");

                entity.Property(e => e.FuelEnergy)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Fuel_Energy");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.Gwpbc)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPBC");

                entity.Property(e => e.Gwpiobc)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPIOBC");

                entity.Property(e => e.HelpText)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.InternalComments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Internal_Comments");

                entity.Property(e => e.LoadCap)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Load_Cap");

                entity.Property(e => e.MaterialGroupId).HasColumnName("MaterialGroupID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.ReCycleId).HasColumnName("ReCycleID");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.Scope31).HasColumnName("Scope3_1");

                entity.Property(e => e.Scope310).HasColumnName("Scope3_10");

                entity.Property(e => e.Scope311).HasColumnName("Scope3_11");

                entity.Property(e => e.Scope312).HasColumnName("Scope3_12");

                entity.Property(e => e.Scope313).HasColumnName("Scope3_13");

                entity.Property(e => e.Scope314).HasColumnName("Scope3_14");

                entity.Property(e => e.Scope315).HasColumnName("Scope3_15");

                entity.Property(e => e.Scope32).HasColumnName("Scope3_2");

                entity.Property(e => e.Scope33).HasColumnName("Scope3_3");

                entity.Property(e => e.Scope34).HasColumnName("Scope3_4");

                entity.Property(e => e.Scope35).HasColumnName("Scope3_5");

                entity.Property(e => e.Scope36).HasColumnName("Scope3_6");

                entity.Property(e => e.Scope37).HasColumnName("Scope3_7");

                entity.Property(e => e.Scope38).HasColumnName("Scope3_8");

                entity.Property(e => e.Scope39).HasColumnName("Scope3_9");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("unit");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Unit_calc")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsedCap)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Used_cap");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.YearStudy).HasColumnName("Year_study");
            });

            modelBuilder.Entity<ComPcrlink>(entity =>
            {
                entity.ToTable("ComPCRLink");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.PcrId).HasColumnName("PCR_ID");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.ComPcrlinks)
                    .HasForeignKey(d => d.ComId)
                    .HasConstraintName("FK_ComPCRLink_COMPANY");
            });

            modelBuilder.Entity<ComProcessLink>(entity =>
            {
                entity.ToTable("ComProcessLink");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ProcessId).HasColumnName("Process_ID");

                entity.Property(e => e.ProcessName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Process_Name");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.ComProcessLinks)
                    .HasForeignKey(d => d.ComId)
                    .HasConstraintName("FK_ComProcessLink_COMPANY");
            });

            modelBuilder.Entity<Comlink>(entity =>
            {
                entity.ToTable("COMLinks");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.LinkId).HasColumnName("LINK_ID");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.Comlinks)
                    .HasForeignKey(d => d.ComId)
                    .HasConstraintName("FK_COMLinks_COMPANY");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.ComId);

                entity.ToTable("COMPANY");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComAdd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COM_ADD");

                entity.Property(e => e.ComBannerLogo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("COM_BannerLogo");

                entity.Property(e => e.ComCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COM_CITY");

                entity.Property(e => e.ComCompanyname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COM_COMPANYNAME");

                entity.Property(e => e.ComCompanyvat)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COM_COMPANYVAT");

                entity.Property(e => e.ComCountry).HasColumnName("COM_Country");

                entity.Property(e => e.ComCreatedby).HasColumnName("COM_CREATEDBY");

                entity.Property(e => e.ComCreatedttm)
                    .HasColumnType("datetime")
                    .HasColumnName("COM_CREATEDTTM")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ComDir)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("COM_Dir");

                entity.Property(e => e.ComEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COM_EMAIL");

                entity.Property(e => e.ComEpdinfo1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("COM_EPDInfo1");

                entity.Property(e => e.ComEpdinfo2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("COM_EPDInfo2");

                entity.Property(e => e.ComEpdinfo3)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("COM_EPDInfo3");

                entity.Property(e => e.ComEpdinfo4)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("COM_EPDInfo4");

                entity.Property(e => e.ComEpdpicture1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COM_EPDPicture1");

                entity.Property(e => e.ComEpdpicture2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COM_EPDPicture2");

                entity.Property(e => e.ComGuid)
                    .HasColumnName("COM_GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComLogo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COM_Logo");

                entity.Property(e => e.ComMainContact)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("COM_MainContact");

                entity.Property(e => e.ComManagmentSys)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("COM_ManagmentSys");

                entity.Property(e => e.ComModulSharing)
                    .HasColumnName("COM_Modul_Sharing")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComModulSubFase)
                    .HasColumnName("COM_Modul_SubFase")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComPageText)
                    .HasMaxLength(3500)
                    .IsUnicode(false)
                    .HasColumnName("COM_PageText");

                entity.Property(e => e.ComPaidTo)
                    .HasColumnType("date")
                    .HasColumnName("COM_PaidTO");

                entity.Property(e => e.ComPhone1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COM_PHONE1");

                entity.Property(e => e.ComPhone2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COM_PHONE2");

                entity.Property(e => e.ComProgramOperator).HasColumnName("COM_ProgramOperator");

                entity.Property(e => e.ComProid)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("COM_PROID");

                entity.Property(e => e.ComStartup)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("COM_Startup");

                entity.Property(e => e.ComStatus)
                    .HasColumnName("COM_STATUS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ComSystem).HasColumnName("COM_System");

                entity.Property(e => e.ComToken)
                    .IsUnicode(false)
                    .HasColumnName("COM_Token");

                entity.Property(e => e.ComType).HasColumnName("COM_TYPE");

                entity.Property(e => e.ComWeb)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("COM_WEB");

                entity.Property(e => e.ComZip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COM_ZIP");
            });

            modelBuilder.Entity<CompanyProductGroup>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductGroupId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProductGroupID");

                entity.Property(e => e.ProductGroupName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompanyProductList>(entity =>
            {
                entity.ToTable("CompanyProductList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Comsw>(entity =>
            {
                entity.ToTable("COMSW");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.SwId).HasColumnName("SW_ID");

                entity.Property(e => e.SwType).HasColumnName("SW_type");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.Comsws)
                    .HasForeignKey(d => d.ComId)
                    .HasConstraintName("FK_COMSW_COMPANY");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.Int);

                entity.ToTable("COUNTRY");

                entity.Property(e => e.Int).HasColumnName("int");

                entity.Property(e => e.Alpha2Code)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Alpha3Code)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Language)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dbanalyse>(entity =>
            {
                entity.HasKey(e => e.AnalyseId);

                entity.ToTable("DBAnalyse");

                entity.Property(e => e.AnalyseId).HasColumnName("AnalyseID");

                entity.Property(e => e.Ansvarlig)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Beskrivelse)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.Dato)
                    .HasColumnType("datetime")
                    .HasColumnName("dato");

                entity.Property(e => e.Innlogget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Navn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<DbanalyseSite>(entity =>
            {
                entity.ToTable("DBAnalyseSite");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnalyseId).HasColumnName("AnalyseID");

                entity.Property(e => e.AvId).HasColumnName("AV_ID");

                entity.Property(e => e.AvNavn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AV_Navn");

                entity.Property(e => e.AvfallbehandlingRes)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Avfallbehandling_res");

                entity.Property(e => e.BehandlingId).HasColumnName("BehandlingID");

                entity.Property(e => e.Frekvens).HasColumnName("frekvens");

                entity.Property(e => e.Gjennomsnitt).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.IRute).HasColumnName("i_rute");

                entity.Property(e => e.MaterialEnergiRes)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Material_Energi_res");

                entity.Property(e => e.Mengde)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("mengde");

                entity.Property(e => e.OptibagRes)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Optibag_res");

                entity.Property(e => e.Sted)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TilTomming).HasColumnName("til_tomming");

                entity.Property(e => e.Transport)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transport2)
                    .HasColumnType("numeric(20, 1)")
                    .HasColumnName("Transport_2");

                entity.Property(e => e.Transport2Res)
                    .HasColumnType("numeric(20, 1)")
                    .HasColumnName("Transport_2_res");

                entity.Property(e => e.Transport3)
                    .HasColumnType("numeric(20, 1)")
                    .HasColumnName("Transport_3");

                entity.Property(e => e.Transport3Res)
                    .HasColumnType("numeric(20, 1)")
                    .HasColumnName("Transport_3_res");

                entity.Property(e => e.UtenLast).HasColumnName("uten_last");

                entity.HasOne(d => d.Analyse)
                    .WithMany(p => p.DbanalyseSites)
                    .HasForeignKey(d => d.AnalyseId)
                    .HasConstraintName("FK_DBAnalyseSite_DBAnalyse");
            });

            modelBuilder.Entity<DbanalyseSiteView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DBanalyseSiteView");

                entity.Property(e => e.AnalyseId).HasColumnName("AnalyseID");

                entity.Property(e => e.AvId).HasColumnName("AV_ID");

                entity.Property(e => e.AvNavn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AV_Navn");

                entity.Property(e => e.AvfallbehandlingRes)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("Avfallbehandling_res");

                entity.Property(e => e.BehandlingId).HasColumnName("BehandlingID");

                entity.Property(e => e.Frekvens).HasColumnName("frekvens");

                entity.Property(e => e.IRute).HasColumnName("i_rute");

                entity.Property(e => e.MaterialEnergiRes)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("Material_Energi_res");

                entity.Property(e => e.Mengde)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("mengde");

                entity.Property(e => e.OptibagRes)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("Optibag_res");

                entity.Property(e => e.Sted)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TilTomming).HasColumnName("til_tomming");

                entity.Property(e => e.Transport)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transport2)
                    .HasColumnType("numeric(38, 1)")
                    .HasColumnName("Transport_2");

                entity.Property(e => e.Transport2Res)
                    .HasColumnType("numeric(38, 1)")
                    .HasColumnName("Transport_2_res");

                entity.Property(e => e.Transport3)
                    .HasColumnType("numeric(38, 1)")
                    .HasColumnName("Transport_3");

                entity.Property(e => e.Transport3Res)
                    .HasColumnType("numeric(38, 1)")
                    .HasColumnName("Transport_3_res");

                entity.Property(e => e.UtenLast).HasColumnName("uten_last");
            });

            modelBuilder.Entity<Dbavfallstyper>(entity =>
            {
                entity.HasKey(e => e.AvId);

                entity.ToTable("DBAvfallstyper");

                entity.Property(e => e.AvId)
                    .ValueGeneratedNever()
                    .HasColumnName("AV_ID");

                entity.Property(e => e.AvName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AV_NAME");

                entity.Property(e => e.Co2)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("CO2");
            });

            modelBuilder.Entity<Dbbehandlingsmate>(entity =>
            {
                entity.HasKey(e => e.BehandId);

                entity.ToTable("DBBehandlingsmate");

                entity.Property(e => e.BehandId)
                    .ValueGeneratedNever()
                    .HasColumnName("BehandID");

                entity.Property(e => e.Behandling)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Co2)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("CO2");
            });

            modelBuilder.Entity<Dbbehandlingssted>(entity =>
            {
                entity.HasKey(e => e.BehandlingId);

                entity.ToTable("DBBehandlingssted");

                entity.Property(e => e.BehandlingId)
                    .ValueGeneratedNever()
                    .HasColumnName("BehandlingID");

                entity.Property(e => e.Behandlingssted)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Co2)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("CO2");
            });

            modelBuilder.Entity<Dbkildesortering>(entity =>
            {
                entity.ToTable("DBKildesortering");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Avfallbehandling).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.AvfallsId).HasColumnName("AvfallsID");

                entity.Property(e => e.Avfallsnavn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Behandlingsmate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BehandlingsmateId).HasColumnName("BehandlingsmateID");

                entity.Property(e => e.Behandlingssted)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BehandlingsstedId).HasColumnName("BehandlingsstedID");

                entity.Property(e => e.DatoSistEndret)
                    .HasColumnType("date")
                    .HasColumnName("dato_sist_endret");

                entity.Property(e => e.ErstattetEnergi)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("Erstattet_energi");

                entity.Property(e => e.TransRute)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("Trans_rute");

                entity.Property(e => e.TransSted)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("Trans_sted");

                entity.Property(e => e.TransUtenLast)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("Trans_uten_last");

                entity.Property(e => e.Transport2).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Transport3).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userID");
            });

            modelBuilder.Entity<Dboptibag>(entity =>
            {
                entity.HasKey(e => e.Optiid);

                entity.ToTable("DBOptibag");

                entity.Property(e => e.Optiid)
                    .ValueGeneratedNever()
                    .HasColumnName("OPTIID");

                entity.Property(e => e.Optico2)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("OPTICO2");

                entity.Property(e => e.Optinavn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OPTINavn");
            });

            modelBuilder.Entity<DbplukkHead>(entity =>
            {
                entity.HasKey(e => e.PlukkId);

                entity.ToTable("DBPlukkHead");

                entity.Property(e => e.PlukkId).HasColumnName("PlukkID");

                entity.Property(e => e.Ansvarlig)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Beskrivelse)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Dato)
                    .HasColumnType("date")
                    .HasColumnName("dato");

                entity.Property(e => e.Innlogget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Navn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Dbplukkliste>(entity =>
            {
                entity.ToTable("DBPlukkliste");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AvId).HasColumnName("AV_ID");

                entity.Property(e => e.AvNavn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AV_NAVN");

                entity.Property(e => e.PlukkId).HasColumnName("PlukkID");

                entity.Property(e => e.Prosent)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("prosent");

                entity.HasOne(d => d.Plukk)
                    .WithMany(p => p.Dbplukklistes)
                    .HasForeignKey(d => d.PlukkId)
                    .HasConstraintName("FK_DBPlukkliste_DBPlukkHead");
            });

            modelBuilder.Entity<DbrestSite>(entity =>
            {
                entity.ToTable("DBRestSite");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnalyseId).HasColumnName("AnalyseID");

                entity.Property(e => e.AvId).HasColumnName("AV_ID");

                entity.Property(e => e.AvNavn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AV_NAVN");

                entity.Property(e => e.Avfallsbehandling).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BehandlingId).HasColumnName("BehandlingID");

                entity.Property(e => e.DbanalyseSiteId).HasColumnName("DBAnalyseSiteID");

                entity.Property(e => e.MaterialEnergi)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Material_energi");

                entity.Property(e => e.PlukkId).HasColumnName("PlukkID");

                entity.Property(e => e.Prosent)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("prosent");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sted)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.DbanalyseSite)
                    .WithMany(p => p.DbrestSites)
                    .HasForeignKey(d => d.DbanalyseSiteId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DBRestSite_DBAnalyseSite");
            });

            modelBuilder.Entity<Dbrestavfall>(entity =>
            {
                entity.ToTable("DBRestavfall");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Avfallsbehandling).HasColumnType("numeric(10, 4)");

                entity.Property(e => e.Behandlingsmate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BehandlingsmateId).HasColumnName("BehandlingsmateID");

                entity.Property(e => e.Behandlingssted)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BehandlingsstedId).HasColumnName("BehandlingsstedID");

                entity.Property(e => e.DatoSistEndret)
                    .HasColumnType("date")
                    .HasColumnName("dato_sist_endret");

                entity.Property(e => e.ErstattetEnergi)
                    .HasColumnType("numeric(10, 4)")
                    .HasColumnName("Erstattet_energi");

                entity.Property(e => e.RestavfallsId).HasColumnName("RestavfallsID");

                entity.Property(e => e.Restavfallsnavn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userID");
            });

            modelBuilder.Entity<Dbresultat>(entity =>
            {
                entity.ToTable("DBResultat");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnalyseId).HasColumnName("AnalyseID");

                entity.Property(e => e.AvId).HasColumnName("AV_ID");

                entity.Property(e => e.AvNavn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AV_NAVN");

                entity.Property(e => e.Avfallbehandling).HasColumnType("decimal(20, 1)");

                entity.Property(e => e.BehandlingId).HasColumnName("BehandlingID");

                entity.Property(e => e.EnergiMaterial)
                    .HasColumnType("decimal(20, 1)")
                    .HasColumnName("Energi_material");

                entity.Property(e => e.Sted)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.T1Fra)
                    .HasColumnType("decimal(20, 1)")
                    .HasColumnName("T1_Fra");

                entity.Property(e => e.T1I)
                    .HasColumnType("decimal(20, 1)")
                    .HasColumnName("T1_I");

                entity.Property(e => e.T1Til)
                    .HasColumnType("decimal(20, 1)")
                    .HasColumnName("T1_Til");

                entity.Property(e => e.T2).HasColumnType("decimal(20, 1)");

                entity.Property(e => e.T3).HasColumnType("decimal(20, 1)");
            });

            modelBuilder.Entity<Dbresultdetail>(entity =>
            {
                entity.ToTable("DBResultdetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnalyseId).HasColumnName("AnalyseID");

                entity.Property(e => e.AvId).HasColumnName("AV_ID");

                entity.Property(e => e.AvNavn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AV_NAVN");

                entity.Property(e => e.Avfallbehandling).HasColumnType("numeric(20, 2)");

                entity.Property(e => e.BehandlingId).HasColumnName("BehandlingID");

                entity.Property(e => e.Optibag).HasColumnType("numeric(20, 2)");

                entity.Property(e => e.ReplacedMaterial)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Replaced_material");

                entity.Property(e => e.Sted)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.T1Fra)
                    .HasColumnType("decimal(20, 1)")
                    .HasColumnName("T1_Fra");

                entity.Property(e => e.T1I)
                    .HasColumnType("decimal(20, 1)")
                    .HasColumnName("T1_I");

                entity.Property(e => e.T1Til)
                    .HasColumnType("decimal(20, 1)")
                    .HasColumnName("T1_Til");

                entity.Property(e => e.T2).HasColumnType("numeric(20, 2)");

                entity.Property(e => e.T3).HasColumnType("numeric(20, 2)");
            });

            modelBuilder.Entity<Dbsupport>(entity =>
            {
                entity.HasKey(e => e.SupportId);

                entity.ToTable("DBSupport");

                entity.Property(e => e.SupportId).HasColumnName("Support_ID");

                entity.Property(e => e.SupportBody)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Support_Body");

                entity.Property(e => e.SupportDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Support_Date");

                entity.Property(e => e.SupportFrom)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Support_From");

                entity.Property(e => e.SupportHead)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Support_Head");

                entity.Property(e => e.SupportStatus).HasColumnName("Support_Status");

                entity.Property(e => e.SupportType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Support_Type");
            });

            modelBuilder.Entity<Dbtransport>(entity =>
            {
                entity.ToTable("DBTransport");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnalyseId).HasColumnName("AnalyseID");

                entity.Property(e => e.AvId).HasColumnName("AV_ID");

                entity.Property(e => e.AvNavn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AV_NAVN");

                entity.Property(e => e.BehandlingId).HasColumnName("BehandlingID");

                entity.Property(e => e.Frekvens).HasColumnName("frekvens");

                entity.Property(e => e.Gjennomsnitt).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.IRute).HasColumnName("i_rute");

                entity.Property(e => e.Sted)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TilTomming).HasColumnName("til_tomming");

                entity.Property(e => e.Transport)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenLast).HasColumnName("uten_last");
            });

            modelBuilder.Entity<Dcanswer>(entity =>
            {
                entity.ToTable("DCAnswer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Dcanswer1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DCAnswer1");

                entity.Property(e => e.Dcanswer2)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DCAnswer2");

                entity.Property(e => e.Dcanswer3)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DCAnswer3");

                entity.Property(e => e.Dcanswer4)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("DCAnswer4");

                entity.Property(e => e.Dcanswer5)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DCAnswer5");

                entity.Property(e => e.DcanswerLine).HasColumnName("DCAnswerLine");

                entity.Property(e => e.DcrecipId).HasColumnName("DCRecipID");

                entity.HasOne(d => d.Dcrecip)
                    .WithMany(p => p.Dcanswers)
                    .HasForeignKey(d => d.DcrecipId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DCAnswer_DCRecipients");
            });

            modelBuilder.Entity<Dcheading>(entity =>
            {
                entity.ToTable("DCHeading");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Dcdate)
                    .HasColumnType("date")
                    .HasColumnName("DCDate");

                entity.Property(e => e.Dcdescription)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("DCDescription");

                entity.Property(e => e.Dcname)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("DCName");

                entity.Property(e => e.Dcpicture1)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DCPicture1");

                entity.Property(e => e.Dcpicture2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DCPicture2");

                entity.Property(e => e.Dcquestions).HasColumnName("DCQuestions");

                entity.Property(e => e.DcrefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DCRefNo");

                entity.Property(e => e.Dcspesification)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("DCSpesification");

                entity.Property(e => e.DcstartDate)
                    .HasColumnType("date")
                    .HasColumnName("DCStartDate");

                entity.Property(e => e.Dcstatus).HasColumnName("DCStatus");

                entity.Property(e => e.DcstopDate)
                    .HasColumnType("date")
                    .HasColumnName("DCStopDate");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.Dcheadings)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DCHeading_COMPANY");
            });

            modelBuilder.Entity<Dcrecipient>(entity =>
            {
                entity.ToTable("DCRecipients");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DcheadingId).HasColumnName("DCHeadingID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FinishedDate).HasColumnType("datetime");

                entity.Property(e => e.LastChange).HasColumnType("datetime");

                entity.Property(e => e.LastMailDate).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Recipients)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UsrId).HasColumnName("USR_ID");

                entity.HasOne(d => d.Dcheading)
                    .WithMany(p => p.Dcrecipients)
                    .HasForeignKey(d => d.DcheadingId)
                    .HasConstraintName("FK_DCRecipients_DCHeading");
            });

            modelBuilder.Entity<EPackAnalyse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ePackAnalyse");

                entity.Property(e => e.Anaid).HasColumnName("ANAID");

                entity.Property(e => e.FEUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("F_E_Unit");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 4)")
                    .HasColumnName("GWP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KgprT)
                    .HasColumnType("decimal(38, 4)")
                    .HasColumnName("kgprT");

                entity.Property(e => e.MainGroupId).HasColumnName("MainGroupID");

                entity.Property(e => e.MaterialGroupId).HasColumnName("MaterialGroupID");

                entity.Property(e => e.ProductGroupName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RefId).HasColumnName("RefID");
            });

            modelBuilder.Entity<EPackAnalyseGwp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ePackAnalyseGWP");

                entity.Property(e => e.Anaid).HasColumnName("ANAID");

                entity.Property(e => e.FEUnit)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("F_E_Unit");

                entity.Property(e => e.Gwp).HasColumnName("GWP");

                entity.Property(e => e.Gwpname)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("GWPName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductGroupName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EPackAnalysePacklist>(entity =>
            {
                entity.ToTable("ePack_AnalysePacklist");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("GWP");

                entity.Property(e => e.KgprT).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PackMaterialId).HasColumnName("PackMaterialID");

                entity.Property(e => e.PackTypeId).HasColumnName("PackTypeID");

                entity.Property(e => e.PrecentResirk)
                    .HasColumnType("decimal(5, 1)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.EPackAnalysePacklists)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ePack_AnalysePacklist_ePack_Analyser");
            });

            modelBuilder.Entity<EPackAnalyser>(entity =>
            {
                entity.ToTable("ePack_Analyser");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Anaid).HasColumnName("ANAID");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NoDpakT).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NoFpakT).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NoPallT).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NsEn).HasColumnName("NS_EN");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EPackCertificate>(entity =>
            {
                entity.ToTable("ePackCertificate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("Time_Created");

                entity.Property(e => e.TimeLastChange)
                    .HasColumnType("datetime")
                    .HasColumnName("Time_LastChange");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.EPackCertificates)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ePackDeclatation_COMPANY");
            });

            modelBuilder.Entity<EPackCertificateLine>(entity =>
            {
                entity.ToTable("ePackCertificateLine");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CertificateId).HasColumnName("CertificateID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DeclarationId).HasColumnName("DeclarationID");

                entity.Property(e => e.HelpTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("HelpTXT");

                entity.Property(e => e.PackTypeId).HasColumnName("PackTypeID");

                entity.HasOne(d => d.Certificate)
                    .WithMany(p => p.EPackCertificateLines)
                    .HasForeignKey(d => d.CertificateId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ePackCertificateLine_ePackCertificate");
            });

            modelBuilder.Entity<EPackComponent>(entity =>
            {
                entity.ToTable("ePackComponents");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DecComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EPackComponentsFile>(entity =>
            {
                entity.ToTable("ePackComponentsFiles");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompId).HasColumnName("CompID");

                entity.Property(e => e.FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ShareName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ValidTo).HasColumnType("date");
            });

            modelBuilder.Entity<EPackDeclarationLine>(entity =>
            {
                entity.ToTable("ePackDeclarationLine");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ComponentsId).HasColumnName("ComponentsID");

                entity.Property(e => e.DeclarationId).HasColumnName("DeclarationID");

                entity.Property(e => e.FilDoc)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("filDoc");

                entity.Property(e => e.HelpTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("HelpTXT");

                entity.Property(e => e.PackTypeId).HasColumnName("PackTypeID");
            });

            modelBuilder.Entity<EPackDeclarationType>(entity =>
            {
                entity.ToTable("ePackDeclarationType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DecComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DeclarationId).HasColumnName("DeclarationID");

                entity.Property(e => e.FilDoc)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("filDoc");

                entity.Property(e => e.HelpTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("HelpTXT");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PackTypeId).HasColumnName("PackTypeID");
            });

            modelBuilder.Entity<EPackGwplevel1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ePackGWPLevel1");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.FEUnit)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("F_E_Unit");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("GWP");

                entity.Property(e => e.Gwpname)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("GWPName");

                entity.Property(e => e.HeadId).HasColumnName("HeadID");

                entity.Property(e => e.MainGroupName)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EPackGwplevel2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ePackGWPLevel2");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.EpdmaterialName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("EPDMaterialName");

                entity.Property(e => e.FEUnit)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("F_E_Unit");

                entity.Property(e => e.Gwp).HasColumnName("GWP");

                entity.Property(e => e.Gwpname)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("GWPName");

                entity.Property(e => e.HeadId).HasColumnName("HeadID");

                entity.Property(e => e.MainGroupName)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EPackGwplevel3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ePackGWPLevel3");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.FEUnit)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("F_E_Unit");

                entity.Property(e => e.Gwp).HasColumnName("GWP");

                entity.Property(e => e.Gwpname)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("GWPName");

                entity.Property(e => e.HeadId).HasColumnName("HeadID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductGroupName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EPackHeading>(entity =>
            {
                entity.ToTable("ePackHeading");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.EPackHeadings)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ePackHeading_COMPANY");
            });

            modelBuilder.Entity<EPackLevel1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ePackLevel1");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.FEUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("F_E_Unit");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Gwp).HasColumnName("GWP");

                entity.Property(e => e.HeadId).HasColumnName("HeadID");

                entity.Property(e => e.KgprT).HasColumnName("kgprT");

                entity.Property(e => e.MainGroupId).HasColumnName("MainGroupID");

                entity.Property(e => e.MaterialGroupId).HasColumnName("MaterialGroupID");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PackTypeId).HasColumnName("PackTypeID");

                entity.Property(e => e.ProductGroup)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EPackLevel2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ePackLevel2");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.EpdmaterialName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("EPDMaterialName");

                entity.Property(e => e.FEUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("F_E_Unit");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Gwp).HasColumnName("GWP");

                entity.Property(e => e.HeadId).HasColumnName("HeadID");

                entity.Property(e => e.KgprT).HasColumnName("kgprT");

                entity.Property(e => e.MainGroupId).HasColumnName("MainGroupID");

                entity.Property(e => e.MainGroupName)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialGroupId).HasColumnName("MaterialGroupID");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PackTypeId).HasColumnName("PackTypeID");
            });

            modelBuilder.Entity<EPackLevel3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ePackLevel3");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.FEUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("F_E_Unit");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 4)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HeadId).HasColumnName("HeadID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KgprT)
                    .HasColumnType("decimal(38, 4)")
                    .HasColumnName("kgprT");

                entity.Property(e => e.MainGroupId).HasColumnName("MainGroupID");

                entity.Property(e => e.MainGroupName)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialGroupId).HasColumnName("MaterialGroupID");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PackTypeId).HasColumnName("PackTypeID");

                entity.Property(e => e.ProductGroupName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EPackTotalSalesLevel1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ePackTotalSalesLevel1");

                entity.Property(e => e.HeadId).HasColumnName("HeadID");

                entity.Property(e => e.MaterialGroupId).HasColumnName("MaterialGroupID");

                entity.Property(e => e.Sum3).HasColumnName("SUM3");
            });

            modelBuilder.Entity<EPackTotalSalesLevel2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ePackTotalSalesLevel2");

                entity.Property(e => e.HeadId).HasColumnName("HeadID");

                entity.Property(e => e.Sum2).HasColumnName("SUM2");

                entity.Property(e => e.Sum3).HasColumnName("SUM3");
            });

            modelBuilder.Entity<Epdanalysis>(entity =>
            {
                entity.ToTable("EPDAnalysis");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnaId).HasColumnName("AnaID");

                entity.Property(e => e.Anadescription1)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("ANADescription1");

                entity.Property(e => e.Anamarket)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("ANAMarket");

                entity.Property(e => e.Ananame)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("ANAName");

                entity.Property(e => e.Ananumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ANANumber");

                entity.Property(e => e.Anaspesification)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("ANASpesification");

                entity.Property(e => e.Anatech)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("ANATech");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Epddate)
                    .HasColumnType("date")
                    .HasColumnName("EPDDate");

                entity.Property(e => e.RefId).HasColumnName("RefID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.Epdanalyses)
                    .HasForeignKey(d => d.ComId)
                    .HasConstraintName("FK_EPDAnalysis_COMPANY");
            });

            modelBuilder.Entity<EpdanalysisFase>(entity =>
            {
                entity.ToTable("EPDAnalysisFases");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.Epdbit).HasColumnName("EPDBit");

                entity.Property(e => e.Epdfilling)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDFilling");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.Epdname)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDName");

                entity.Property(e => e.Epdquantity)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("EPDQuantity")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EpdrecId).HasColumnName("EPDRecID");

                entity.Property(e => e.EpdrefId).HasColumnName("EPDRefID");

                entity.Property(e => e.EpdrefName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDRefName");

                entity.Property(e => e.Epdreturn)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDReturn");

                entity.Property(e => e.Epdreuse)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDReuse");

                entity.Property(e => e.Epdunit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDUnit");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(38, 12)");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.Gwpbc)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWPBC");

                entity.Property(e => e.Gwpiobc)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWPIOBC");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.OldId).HasColumnName("OldID");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.ReCyclePer).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Unit_calc")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Unit_calcT")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdanalysisFases)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDAnalysisFases_EPDAnalysisList");
            });

            modelBuilder.Entity<EpdanalysisList>(entity =>
            {
                entity.ToTable("EPDAnalysisList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnaId).HasColumnName("AnaID");

                entity.Property(e => e.EpdanalysisId).HasColumnName("EPDAnalysisID");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Unit_calc");

                entity.HasOne(d => d.Epdanalysis)
                    .WithMany(p => p.EpdanalysisLists)
                    .HasForeignKey(d => d.EpdanalysisId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDAnalysisList_EPDAnalysis");
            });

            modelBuilder.Entity<EpdcalculationA1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationA1");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationA1A31>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationA1-A3");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM2");
            });

            modelBuilder.Entity<EpdcalculationA1a3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationA1A3");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM2");
            });

            modelBuilder.Entity<EpdcalculationA1a3forEpd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationA1A3ForEPD");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.Gwpbc)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWPBC");

                entity.Property(e => e.Gwpiobc)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWPIOBC");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM2");
            });

            modelBuilder.Entity<EpdcalculationA1a4forEpd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationA1A4ForEPD");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.Gwpbc)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWPBC");

                entity.Property(e => e.Gwpiobc)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWPIOBC");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM2");
            });

            modelBuilder.Entity<EpdcalculationA1a5forEpd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationA1A5ForEPD");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.Gwpbc)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWPBC");

                entity.Property(e => e.Gwpiobc)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWPIOBC");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM2");
            });

            modelBuilder.Entity<EpdcalculationA2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationA2");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM2");
            });

            modelBuilder.Entity<EpdcalculationA2temp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationA2Temp");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationA3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationA3");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationA4>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationA4");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.FECons)
                    .HasColumnType("decimal(38, 9)")
                    .HasColumnName("f_e_cons");

                entity.Property(e => e.Fecons1)
                    .HasColumnType("decimal(38, 9)")
                    .HasColumnName("FECons");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenA4).HasColumnName("Sen_A4");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UsedCap)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Used_cap");
            });

            modelBuilder.Entity<EpdcalculationA42>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationA4_2");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.FECons)
                    .HasColumnType("decimal(38, 8)")
                    .HasColumnName("f_e_cons");

                entity.Property(e => e.Fecons1)
                    .HasColumnType("decimal(38, 9)")
                    .HasColumnName("FECons");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(29, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenA4).HasColumnName("Sen_A4");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UsedCap)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Used_cap");
            });

            modelBuilder.Entity<EpdcalculationA5>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationA5");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenA5).HasColumnName("Sen_A5");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationB1");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenB1).HasColumnName("Sen_B1");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationB2");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenB2b3).HasColumnName("Sen_B2B3");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationB3");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenB2b3).HasColumnName("Sen_B2B3");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB3bak>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationB3bak");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenB2b3).HasColumnName("Sen_B2B3");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB4>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationB4");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenB4b5).HasColumnName("Sen_B4B5");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB4bak>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationB4bak");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenB4b5).HasColumnName("Sen_B4B5");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB5>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationB5");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenB4b5).HasColumnName("Sen_B4B5");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB5bak>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationB5bak");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenB4b5).HasColumnName("Sen_B4B5");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB6>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationB6");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenB6b7).HasColumnName("Sen_B6B7");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB6bak>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationB6bak");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenB6b7).HasColumnName("Sen_B6B7");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB7>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationB7");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenB6b7).HasColumnName("Sen_B6B7");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationB7bak>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationB7bak");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenB6b7).HasColumnName("Sen_B6B7");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationC1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationC1");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenC1c3c4).HasColumnName("Sen_C1C3C4");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationC1bak>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationC1bak");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenC1c3c4).HasColumnName("Sen_C1C3C4");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationC2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationC2");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.FECons)
                    .HasColumnType("decimal(38, 9)")
                    .HasColumnName("f_e_cons");

                entity.Property(e => e.Fecons1)
                    .HasColumnType("decimal(38, 9)")
                    .HasColumnName("FECons");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenC2).HasColumnName("Sen_C2");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UsedCap)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Used_cap");
            });

            modelBuilder.Entity<EpdcalculationC22>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationC2_2");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.FECons)
                    .HasColumnType("decimal(38, 8)")
                    .HasColumnName("f_e_cons");

                entity.Property(e => e.Fecons1)
                    .HasColumnType("decimal(38, 9)")
                    .HasColumnName("FECons");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(29, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenC2).HasColumnName("Sen_C2");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UsedCap)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Used_cap");
            });

            modelBuilder.Entity<EpdcalculationC3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationC3");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenC1c3c4).HasColumnName("Sen_C1C3C4");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationC3bak>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationC3bak");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenC1c3c4).HasColumnName("Sen_C1C3C4");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationC4>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationC4");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenC1c3c4).HasColumnName("Sen_C1C3C4");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationC4bak>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationC4bak");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenC1c3c4).HasColumnName("Sen_C1C3C4");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationD>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationD");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenD1).HasColumnName("Sen_D1");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationDbak>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationDbak");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenD).HasColumnName("Sen_D");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationTotal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationTotal");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Fase)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Quantity).HasColumnType("decimal(22, 12)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdcalculationTotalForEpd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationTotalForEPD");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Fase)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.Gwpbc)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWPBC");

                entity.Property(e => e.Gwpiobc)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWPIOBC");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM2");
            });

            modelBuilder.Entity<EpdcalculationTotalForEpden15804a1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationTotalForEPDEN15804A1");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Fase)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.Gwpbc)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWPBC");

                entity.Property(e => e.Gwpiobc)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWPIOBC");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM2");
            });

            modelBuilder.Entity<EpdcalculationTotalForEpden15804a2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationTotalForEPDEN15804A2");

                entity.Property(e => e.Adpfossil)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ADPfossil");

                entity.Property(e => e.Adpminerals)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ADPminerals");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.Bccpackaging)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("BCCpackaging");

                entity.Property(e => e.Bccproduct)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("BCCproduct");

                entity.Property(e => e.Cr)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("CR");

                entity.Property(e => e.Eee)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("EEE");

                entity.Property(e => e.Epfreshwater)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("EPfreshwater");

                entity.Property(e => e.Epmarine)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("EPmarine");

                entity.Property(e => e.Epterrestrial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("EPterrestrial");

                entity.Property(e => e.Ete)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ETE");

                entity.Property(e => e.Etpfw)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ETPfw");

                entity.Property(e => e.Fase)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Gwpbiogenic)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWPbiogenic");

                entity.Property(e => e.Gwpfossil)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWPfossil");

                entity.Property(e => e.Gwpluluc)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWPluluc");

                entity.Property(e => e.Gwptotal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWPtotal");

                entity.Property(e => e.Htpc)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("HTPc");

                entity.Property(e => e.Htpnc)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("HTPnc");

                entity.Property(e => e.Hw)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("HW");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Irp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("IRP");

                entity.Property(e => e.Mer)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("MER");

                entity.Property(e => e.Mr)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("MR");

                entity.Property(e => e.Nhw)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NHW");

                entity.Property(e => e.Nrpe)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRPE");

                entity.Property(e => e.Nrpm)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRPM");

                entity.Property(e => e.Nrsf)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRSF");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pm)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("PM");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Rpee)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RPEE");

                entity.Property(e => e.Rpem)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RPEM");

                entity.Property(e => e.Rsf)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RSF");

                entity.Property(e => e.Rw)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RW");

                entity.Property(e => e.Sm)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SM");

                entity.Property(e => e.Sqp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SQP");

                entity.Property(e => e.Tpe)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("TPE");

                entity.Property(e => e.Trpe)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("TRPE");

                entity.Property(e => e.W).HasColumnType("decimal(38, 12)");

                entity.Property(e => e.Wdp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("WDP");
            });

            modelBuilder.Entity<EpdcalculationTotalForEpdtoDigi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EPDCalculationTotalForEPDtoDigi");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Fase)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 12)")
                    .HasColumnName("SUM2");
            });

            modelBuilder.Entity<Epdco2fase>(entity =>
            {
                entity.ToTable("EPDCO2Fases");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdbit).HasColumnName("EPDBit");

                entity.Property(e => e.Epdfilling)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDFilling");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.Epdname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDName");

                entity.Property(e => e.Epdquantity)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDQuantity")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EpdrecId).HasColumnName("EPDRecID");

                entity.Property(e => e.EpdrefId).HasColumnName("EPDRefID");

                entity.Property(e => e.EpdrefName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDRefName");

                entity.Property(e => e.Epdreturn)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDReturn");

                entity.Property(e => e.Epdreuse)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDReuse");

                entity.Property(e => e.Epdunit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDUnit");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Extra)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Gwpbc)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWPBC");

                entity.Property(e => e.Gwpiobc)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWPIOBC");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Level).HasDefaultValueSql("((1))");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OldId).HasColumnName("OldID");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReCyclePer).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Unit_calc")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Unit_calcT")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.Epdco2fases)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDCO2Fases_EPDHeading");
            });

            modelBuilder.Entity<Epdco2heading>(entity =>
            {
                entity.ToTable("EPDCO2Heading");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.A1)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.A2)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.A3)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.A4)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.A5)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.B1)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.B2)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.B3)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.B4)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.B5)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.B6)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.B7)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.C1)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.C2)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.C3)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.C4)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.D1)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EpdaddTech)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDAddTech");

                entity.Property(e => e.Epdallocation)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDAllocation");

                entity.Property(e => e.EpdapprovedDate)
                    .HasColumnType("date")
                    .HasColumnName("EPDApprovedDate");

                entity.Property(e => e.Epdbibllio)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDBibllio");

                entity.Property(e => e.EpdbuildingLife)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDBuildingLife");

                entity.Property(e => e.EpdcutOff)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDCutOff");

                entity.Property(e => e.Epddangerous)
                    .HasColumnName("EPDDangerous")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EpddataQuality)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDDataQuality");

                entity.Property(e => e.Epddate)
                    .HasColumnType("date")
                    .HasColumnName("EPDDate");

                entity.Property(e => e.EpddefaultEpdid)
                    .HasColumnName("EPDDefaultEPDID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Epddescription)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDDescription");

                entity.Property(e => e.Epdeditor)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDEditor");

                entity.Property(e => e.EpdexpirationDate)
                    .HasColumnType("date")
                    .HasColumnName("EPDexpirationDate");

                entity.Property(e => e.EpdindoorEnv)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDIndoorEnv");

                entity.Property(e => e.EpdintNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDIntNum");

                entity.Property(e => e.Epdlanguage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EPDLanguage");

                entity.Property(e => e.Epdlayout)
                    .HasColumnName("EPDLayout")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdmarket)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDMarket");

                entity.Property(e => e.Epdname)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("EPDName");

                entity.Property(e => e.Epdnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDNumber");

                entity.Property(e => e.Epdpcr)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("EPDPCR");

                entity.Property(e => e.Epdpicture2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDPicture2");

                entity.Property(e => e.EpdpicturePath)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDPicturePath");

                entity.Property(e => e.EpdproductLife)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductLife");

                entity.Property(e => e.EpdproductionSite)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductionSite");

                entity.Property(e => e.Epdresponsible)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDResponsible");

                entity.Property(e => e.Epdscenarios)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDScenarios");

                entity.Property(e => e.Epdspesification)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDSpesification");

                entity.Property(e => e.Epdstatus).HasColumnName("EPDStatus");

                entity.Property(e => e.EpdsysBound)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDSysBound");

                entity.Property(e => e.Epdtech)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDTech");

                entity.Property(e => e.Epdunit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDUnit");

                entity.Property(e => e.EpdunitCalc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("EPDUnit_Calc");

                entity.Property(e => e.Epdyear).HasColumnName("EPDYear");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProductionSiteId)
                    .HasColumnName("ProductionSiteID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.Epdco2headings)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDCO2 Heading_COMPANY");
            });

            modelBuilder.Entity<EpdcustomerLine>(entity =>
            {
                entity.ToTable("EPDCustomerLine");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HelpTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("HelpTXT");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.EpdcustomerLines)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDCustomerLine_COMPANY");
            });

            modelBuilder.Entity<Epddangerou>(entity =>
            {
                entity.ToTable("EPDDangerous");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Among)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Casno)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CASNo");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpddangerousNavigation)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDDangerous_EPDHeading");
            });

            modelBuilder.Entity<EpddataEn15804a1>(entity =>
            {
                entity.ToTable("EPDDataEN15804A1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(22, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.EpdprocessName)
                    .HasMaxLength(100)
                    .HasColumnName("EPDProcessName")
                    .IsFixedLength(true);

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(22, 12)");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.Gwpbc)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPBC");

                entity.Property(e => e.Gwpiobc)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPIOBC");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.InternalComments)
                    .HasMaxLength(1000)
                    .IsFixedLength(true);

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.OldSimaId).HasColumnName("oldSIMA_ID");

                entity.Property(e => e.ParentDataSetId).HasColumnName("ParentDataSetID");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Version)
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.HasOne(d => d.ParentDataSet)
                    .WithMany(p => p.EpddataEn15804a1s)
                    .HasForeignKey(d => d.ParentDataSetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDDataEN15804A1_EPDDataSetDocumentation");
            });

            modelBuilder.Entity<EpddataEn15804a1registration>(entity =>
            {
                entity.ToTable("EPDDataEN15804A1Registrations");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(22, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.EpdprocessName)
                    .HasMaxLength(100)
                    .HasColumnName("EPDProcessName")
                    .IsFixedLength(true);

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(22, 12)");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.Gwpbc)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPBC");

                entity.Property(e => e.Gwpiobc)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPIOBC");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.InternalComments)
                    .HasMaxLength(1000)
                    .IsFixedLength(true);

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.OldSimaId).HasColumnName("oldSIMA_ID");

                entity.Property(e => e.ParentDataSetId).HasColumnName("ParentDataSetID");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Version)
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.HasOne(d => d.ParentDataSet)
                    .WithMany(p => p.EpddataEn15804a1registrations)
                    .HasForeignKey(d => d.ParentDataSetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDDataEN15804A1Registrations_EPDDataSetDocumentationRegistrations");
            });

            modelBuilder.Entity<EpddataEn15804a1registrationsProject>(entity =>
            {
                entity.ToTable("EPDDataEN15804A1RegistrationsProjects");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(22, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.EpdprocessName)
                    .HasMaxLength(100)
                    .HasColumnName("EPDProcessName")
                    .IsFixedLength(true);

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(22, 12)");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.Gwpbc)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPBC");

                entity.Property(e => e.Gwpiobc)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPIOBC");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.InternalComments)
                    .HasMaxLength(1000)
                    .IsFixedLength(true);

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.OldSimaId).HasColumnName("oldSIMA_ID");

                entity.Property(e => e.ParentDataSetId).HasColumnName("ParentDataSetID");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Version)
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.HasOne(d => d.ParentDataSet)
                    .WithMany(p => p.EpddataEn15804a1registrationsProjects)
                    .HasForeignKey(d => d.ParentDataSetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDDataEN15804A1RegistrationsProjects_EPDDataSetDocumentationRegistrationsProjects");
            });

            modelBuilder.Entity<EpddataEn15804a2>(entity =>
            {
                entity.ToTable("EPDDataEN15804A2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adpfossil)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ADPfossil");

                entity.Property(e => e.Adpminerals)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ADPminerals");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.Bccpackaging)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("BCCpackaging");

                entity.Property(e => e.Bccproduct)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("BCCproduct");

                entity.Property(e => e.Cr)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("CR");

                entity.Property(e => e.Eee)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("EEE");

                entity.Property(e => e.EpdprocessName)
                    .HasMaxLength(100)
                    .HasColumnName("EPDProcessName")
                    .IsFixedLength(true);

                entity.Property(e => e.Epfreshwater)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("EPfreshwater");

                entity.Property(e => e.Epmarine)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("EPmarine");

                entity.Property(e => e.Epterrestrial)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("EPterrestrial");

                entity.Property(e => e.Ete)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ETE");

                entity.Property(e => e.Etpfw)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ETPfw");

                entity.Property(e => e.Gwpbiogenic)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPbiogenic");

                entity.Property(e => e.Gwpfossil)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPfossil");

                entity.Property(e => e.Gwpluluc)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPluluc");

                entity.Property(e => e.Gwptotal)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPtotal");

                entity.Property(e => e.Htpc)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("HTPc");

                entity.Property(e => e.Htpnc)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("HTPnc");

                entity.Property(e => e.Hw)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("HW");

                entity.Property(e => e.InternalComments)
                    .HasMaxLength(1000)
                    .IsFixedLength(true);

                entity.Property(e => e.Irp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("IRP");

                entity.Property(e => e.Mer)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("MER");

                entity.Property(e => e.Mr)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("MR");

                entity.Property(e => e.Nhw)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NHW");

                entity.Property(e => e.Nrpe)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRPE");

                entity.Property(e => e.Nrpm)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRPM");

                entity.Property(e => e.Nrsf)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRSF");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.OldSimaId).HasColumnName("oldSIMA_ID");

                entity.Property(e => e.ParentDataSetId).HasColumnName("ParentDataSetID");

                entity.Property(e => e.Pm)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("PM");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Rpee)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RPEE");

                entity.Property(e => e.Rpem)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RPEM");

                entity.Property(e => e.Rsf)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RSF");

                entity.Property(e => e.Rw)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RW");

                entity.Property(e => e.Sm)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("SM");

                entity.Property(e => e.Sqp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("SQP");

                entity.Property(e => e.Tpe)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("TPE");

                entity.Property(e => e.Trpe)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("TRPE");

                entity.Property(e => e.Version)
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.W).HasColumnType("decimal(22, 12)");

                entity.Property(e => e.Wdp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("WDP");

                entity.HasOne(d => d.ParentDataSet)
                    .WithMany(p => p.EpddataEn15804a2s)
                    .HasForeignKey(d => d.ParentDataSetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDDataEN15804A2_EPDDataSetDocumentation");
            });

            modelBuilder.Entity<EpddataEn15804a2registration>(entity =>
            {
                entity.ToTable("EPDDataEN15804A2Registrations");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adpfossil)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ADPfossil");

                entity.Property(e => e.Adpminerals)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ADPminerals");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.Bccpackaging)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("BCCpackaging");

                entity.Property(e => e.Bccproduct)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("BCCproduct");

                entity.Property(e => e.Cr)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("CR");

                entity.Property(e => e.Eee)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("EEE");

                entity.Property(e => e.EpdprocessName)
                    .HasMaxLength(100)
                    .HasColumnName("EPDProcessName")
                    .IsFixedLength(true);

                entity.Property(e => e.Epfreshwater)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("EPfreshwater");

                entity.Property(e => e.Epmarine)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("EPmarine");

                entity.Property(e => e.Epterrestrial)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("EPterrestrial");

                entity.Property(e => e.Ete)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ETE");

                entity.Property(e => e.Etpfw)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ETPfw");

                entity.Property(e => e.Gwpbiogenic)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPbiogenic");

                entity.Property(e => e.Gwpfossil)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPfossil");

                entity.Property(e => e.Gwpluluc)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPluluc");

                entity.Property(e => e.Gwptotal)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPtotal");

                entity.Property(e => e.Htpc)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("HTPc");

                entity.Property(e => e.Htpnc)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("HTPnc");

                entity.Property(e => e.Hw)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("HW");

                entity.Property(e => e.InternalComments)
                    .HasMaxLength(1000)
                    .IsFixedLength(true);

                entity.Property(e => e.Irp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("IRP");

                entity.Property(e => e.Mer)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("MER");

                entity.Property(e => e.Mr)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("MR");

                entity.Property(e => e.Nhw)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NHW");

                entity.Property(e => e.Nrpe)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRPE");

                entity.Property(e => e.Nrpm)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRPM");

                entity.Property(e => e.Nrsf)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRSF");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.OldSimaId).HasColumnName("oldSIMA_ID");

                entity.Property(e => e.ParentDataSetId).HasColumnName("ParentDataSetID");

                entity.Property(e => e.Pm)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("PM");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Rpee)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RPEE");

                entity.Property(e => e.Rpem)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RPEM");

                entity.Property(e => e.Rsf)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RSF");

                entity.Property(e => e.Rw)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RW");

                entity.Property(e => e.Sm)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("SM");

                entity.Property(e => e.Sqp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("SQP");

                entity.Property(e => e.Tpe)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("TPE");

                entity.Property(e => e.Trpe)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("TRPE");

                entity.Property(e => e.Version)
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.W).HasColumnType("decimal(22, 12)");

                entity.Property(e => e.Wdp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("WDP");

                entity.HasOne(d => d.ParentDataSet)
                    .WithMany(p => p.EpddataEn15804a2registrations)
                    .HasForeignKey(d => d.ParentDataSetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDDataEN15804A2Registrations_EPDDataSetDocumentationRegistrations");
            });

            modelBuilder.Entity<EpddataEn15804a2registrationsProject>(entity =>
            {
                entity.ToTable("EPDDataEN15804A2RegistrationsProjects");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adpfossil)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ADPfossil");

                entity.Property(e => e.Adpminerals)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ADPminerals");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.Bccpackaging)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("BCCpackaging");

                entity.Property(e => e.Bccproduct)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("BCCproduct");

                entity.Property(e => e.Cr)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("CR");

                entity.Property(e => e.Eee)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("EEE");

                entity.Property(e => e.EpdprocessName)
                    .HasMaxLength(100)
                    .HasColumnName("EPDProcessName")
                    .IsFixedLength(true);

                entity.Property(e => e.Epfreshwater)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("EPfreshwater");

                entity.Property(e => e.Epmarine)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("EPmarine");

                entity.Property(e => e.Epterrestrial)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("EPterrestrial");

                entity.Property(e => e.Ete)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ETE");

                entity.Property(e => e.Etpfw)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ETPfw");

                entity.Property(e => e.Gwpbiogenic)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPbiogenic");

                entity.Property(e => e.Gwpfossil)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPfossil");

                entity.Property(e => e.Gwpluluc)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPluluc");

                entity.Property(e => e.Gwptotal)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPtotal");

                entity.Property(e => e.Htpc)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("HTPc");

                entity.Property(e => e.Htpnc)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("HTPnc");

                entity.Property(e => e.Hw)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("HW");

                entity.Property(e => e.InternalComments)
                    .HasMaxLength(1000)
                    .IsFixedLength(true);

                entity.Property(e => e.Irp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("IRP");

                entity.Property(e => e.Mer)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("MER");

                entity.Property(e => e.Mr)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("MR");

                entity.Property(e => e.Nhw)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NHW");

                entity.Property(e => e.Nrpe)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRPE");

                entity.Property(e => e.Nrpm)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRPM");

                entity.Property(e => e.Nrsf)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRSF");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.OldSimaId).HasColumnName("oldSIMA_ID");

                entity.Property(e => e.ParentDataSetId).HasColumnName("ParentDataSetID");

                entity.Property(e => e.Pm)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("PM");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.Rpee)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RPEE");

                entity.Property(e => e.Rpem)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RPEM");

                entity.Property(e => e.Rsf)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RSF");

                entity.Property(e => e.Rw)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RW");

                entity.Property(e => e.Sm)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("SM");

                entity.Property(e => e.Sqp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("SQP");

                entity.Property(e => e.Tpe)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("TPE");

                entity.Property(e => e.Trpe)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("TRPE");

                entity.Property(e => e.Version)
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.W).HasColumnType("decimal(22, 12)");

                entity.Property(e => e.Wdp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("WDP");

                entity.HasOne(d => d.ParentDataSet)
                    .WithMany(p => p.EpddataEn15804a2registrationsProjects)
                    .HasForeignKey(d => d.ParentDataSetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDDataEN15804A2RegistrationsProjects_EPDDataSetDocumentationRegistrationsProjects");
            });

            modelBuilder.Entity<EpddataSetDocumentation>(entity =>
            {
                entity.ToTable("EPDDataSetDocumentation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BackgroundLcadataSet)
                    .HasMaxLength(200)
                    .HasColumnName("BackgroundLCADataSet")
                    .IsFixedLength(true);

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DataQualityAssessment)
                    .HasMaxLength(200)
                    .IsFixedLength(true);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.DataSourceQuality)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.DatasetMainName)
                    .HasMaxLength(200)
                    .IsFixedLength(true);

                entity.Property(e => e.DescriptionLcareport)
                    .HasMaxLength(200)
                    .HasColumnName("DescriptionLCAReport")
                    .IsFixedLength(true);

                entity.Property(e => e.Geographical)
                    .HasMaxLength(200)
                    .IsFixedLength(true);

                entity.Property(e => e.InternalComments)
                    .HasMaxLength(200)
                    .IsFixedLength(true);

                entity.Property(e => e.InternalDescription)
                    .HasMaxLength(200)
                    .IsFixedLength(true);

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MaterialMainGroupId).HasColumnName("MaterialMainGroupID");

                entity.Property(e => e.ScenarioFactor).HasColumnType("decimal(29, 9)");

                entity.Property(e => e.ScenarioPercent).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ScenarioUnit)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.Technological)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Temporal)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Unit)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(29, 9)")
                    .HasColumnName("Unit_calc");

                entity.Property(e => e.Version)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.YearOfStudy)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<EpddataSetDocumentationRegistration>(entity =>
            {
                entity.ToTable("EPDDataSetDocumentationRegistrations");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DatasetType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Epdbit).HasColumnName("EPDBit");

                entity.Property(e => e.Epdfilling)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDFilling");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.Epdname)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDName");

                entity.Property(e => e.Epdquantity)
                    .HasColumnType("decimal(29, 9)")
                    .HasColumnName("EPDQuantity")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EpdrecId).HasColumnName("EPDRecID");

                entity.Property(e => e.EpdrefId).HasColumnName("EPDRefID");

                entity.Property(e => e.EpdrefName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDRefName");

                entity.Property(e => e.Epdreturn)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDReturn");

                entity.Property(e => e.Epdreuse)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDReuse");

                entity.Property(e => e.Epdunit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDUnit");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OldId)
                    .HasColumnName("OldID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReCyclePer)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(29, 9)")
                    .HasColumnName("Unit_calc")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(26, 12)")
                    .HasColumnName("Unit_calcT")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WastagePer)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpddataSetDocumentationRegistrations)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDDataSetDocumentationRegistrations_EPDHeading");
            });

            modelBuilder.Entity<EpddataSetDocumentationRegistrationsProject>(entity =>
            {
                entity.ToTable("EPDDataSetDocumentationRegistrationsProjects");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DatasetType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Epdbit).HasColumnName("EPDBit");

                entity.Property(e => e.Epdfilling)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDFilling");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.Epdname)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDName");

                entity.Property(e => e.Epdquantity)
                    .HasColumnType("decimal(29, 9)")
                    .HasColumnName("EPDQuantity")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EpdrecId).HasColumnName("EPDRecID");

                entity.Property(e => e.EpdrefId).HasColumnName("EPDRefID");

                entity.Property(e => e.EpdrefName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDRefName");

                entity.Property(e => e.Epdreturn)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDReturn");

                entity.Property(e => e.Epdreuse)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDReuse");

                entity.Property(e => e.Epdunit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDUnit");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OldId)
                    .HasColumnName("OldID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReCyclePer)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(29, 9)")
                    .HasColumnName("Unit_calc")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(26, 12)")
                    .HasColumnName("Unit_calcT")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WastagePer)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpddataSetDocumentationRegistrationsProjects)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDDataSetDocumentationRegistrationsProjects_EPDProjectHeading");
            });

            modelBuilder.Entity<EpddataSetDocumentationSubProcess>(entity =>
            {
                entity.ToTable("EPDDataSetDocumentationSubProcess");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Fase)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MainId).HasColumnName("MainID");

                entity.Property(e => e.SubId).HasColumnName("SubID");

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(18, 9)")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EpddefaultA2>(entity =>
            {
                entity.ToTable("EPDDefaultA2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Epda2filling).HasColumnName("EPDA2Filling");

                entity.Property(e => e.Epda2id).HasColumnName("EPDA2ID");

                entity.Property(e => e.Epda2km).HasColumnName("EPDA2km");

                entity.Property(e => e.Epda2name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDA2Name");

                entity.Property(e => e.Epda2return).HasColumnName("EPDA2Return");

                entity.Property(e => e.Epda2reuse).HasColumnName("EPDA2Reuse");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");
            });

            modelBuilder.Entity<EpddefaultA3>(entity =>
            {
                entity.ToTable("EPDDefaultA3");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Epda3id).HasColumnName("EPDA3ID");

                entity.Property(e => e.Epda3name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDA3Name");

                entity.Property(e => e.Epda3quantity)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDA3Quantity");

                entity.Property(e => e.Epda3unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDA3Unit");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Unit_calc");
            });

            modelBuilder.Entity<EpddefaultA4>(entity =>
            {
                entity.ToTable("EPDDefaultA4");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Epda4filling).HasColumnName("EPDA4Filling");

                entity.Property(e => e.Epda4id).HasColumnName("EPDA4ID");

                entity.Property(e => e.Epda4km).HasColumnName("EPDA4km");

                entity.Property(e => e.Epda4name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDA4Name");

                entity.Property(e => e.Epda4return).HasColumnName("EPDA4Return");

                entity.Property(e => e.Epda4reuse).HasColumnName("EPDA4Reuse");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");
            });

            modelBuilder.Entity<EpdfunctionRegister>(entity =>
            {
                entity.ToTable("EPDFunctionRegister");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Epdgroup>(entity =>
            {
                entity.ToTable("EPDGroups");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comid).HasColumnName("COMID");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<Epdheading>(entity =>
            {
                entity.ToTable("EPDHeading");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.A1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.A2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.A3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.A4)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.A5)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B4)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B5)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B6)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B7)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C4)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.D1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.EpdaddTech)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDAddTech");

                entity.Property(e => e.Epdallocation)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDAllocation");

                entity.Property(e => e.EpdapprovedDate)
                    .HasColumnType("date")
                    .HasColumnName("EPDApprovedDate");

                entity.Property(e => e.Epdbibllio)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDBibllio");

                entity.Property(e => e.EpdbuildingLife)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDBuildingLife");

                entity.Property(e => e.EpdcomOnEnvImp)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDComOnEnvImp");

                entity.Property(e => e.EpdcutOff)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDCutOff");

                entity.Property(e => e.Epddangerous)
                    .HasColumnName("EPDDangerous")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EpddataQuality)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDDataQuality");

                entity.Property(e => e.Epddate)
                    .HasColumnType("date")
                    .HasColumnName("EPDDate");

                entity.Property(e => e.EpddefaultEpdid)
                    .HasColumnName("EPDDefaultEPDID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Epddescription)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDDescription");

                entity.Property(e => e.Epdeditor)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDEditor");

                entity.Property(e => e.EpdexpirationDate)
                    .HasColumnType("date")
                    .HasColumnName("EPDexpirationDate");

                entity.Property(e => e.EpdfuncUnitDesc)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDFuncUnitDesc");

                entity.Property(e => e.EpdindoorEnv)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDIndoorEnv");

                entity.Property(e => e.EpdintNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDIntNum");

                entity.Property(e => e.Epdlanguage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EPDLanguage");

                entity.Property(e => e.Epdlayout)
                    .HasColumnName("EPDLayout")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdmarket)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDMarket");

                entity.Property(e => e.Epdname)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("EPDName");

                entity.Property(e => e.Epdnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDNumber");

                entity.Property(e => e.Epdpcr)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("EPDPCR");

                entity.Property(e => e.EpdpcrId)
                    .HasColumnName("EPDPCR_ID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdpicture2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDPicture2");

                entity.Property(e => e.EpdpicturePath)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDPicturePath");

                entity.Property(e => e.EpdproductLife)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductLife");

                entity.Property(e => e.EpdproductionSite)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductionSite");

                entity.Property(e => e.Epdresponsible)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDResponsible");

                entity.Property(e => e.Epdscenarios)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDScenarios");

                entity.Property(e => e.Epdspesification)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDSpesification");

                entity.Property(e => e.Epdstatus).HasColumnName("EPDStatus");

                entity.Property(e => e.EpdsubType)
                    .HasColumnName("EPDSubType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EpdsysBound)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDSysBound");

                entity.Property(e => e.Epdtech)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDTech");

                entity.Property(e => e.Epdunit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDUnit");

                entity.Property(e => e.EpdunitCalc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("EPDUnit_Calc");

                entity.Property(e => e.Epdyear).HasColumnName("EPDYear");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");

                entity.Property(e => e.NoEdit).HasColumnName("NO_Edit");

                entity.Property(e => e.PdfsourceDatasetId)
                    .HasColumnName("PDFSourceDatasetID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProductFlowDatasetId)
                    .HasColumnName("ProductFlowDatasetID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProductionSiteId)
                    .HasColumnName("ProductionSiteID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.Epdheadings)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDHeading_COMPANY");
            });

            modelBuilder.Entity<EpdheadingDigi>(entity =>
            {
                entity.ToTable("EPDHeadingDigi");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.A1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.A2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.A3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.A4)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.A5)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B4)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B5)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B6)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B7)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C4)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.D1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.Epd2digiPluss).HasColumnName("EPD2DigiPLUSS");

                entity.Property(e => e.EpdUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("EPD_URL");

                entity.Property(e => e.EpdaddTech)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDAddTech");

                entity.Property(e => e.Epdallocation)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDAllocation");

                entity.Property(e => e.EpdapprovedDate)
                    .HasColumnType("date")
                    .HasColumnName("EPDApprovedDate");

                entity.Property(e => e.Epdbibllio)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDBibllio");

                entity.Property(e => e.EpdbuildingLife)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDBuildingLife");

                entity.Property(e => e.EpdcomOnEnvImp)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDComOnEnvImp");

                entity.Property(e => e.EpdcutOff)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDCutOff");

                entity.Property(e => e.Epddangerous)
                    .HasColumnName("EPDDangerous")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EpddataQuality)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDDataQuality");

                entity.Property(e => e.Epddate)
                    .HasColumnType("date")
                    .HasColumnName("EPDDate");

                entity.Property(e => e.EpddefaultEpdid)
                    .HasColumnName("EPDDefaultEPDID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Epddescription)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDDescription");

                entity.Property(e => e.Epdeditor)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDEditor");

                entity.Property(e => e.EpdexpirationDate)
                    .HasColumnType("date")
                    .HasColumnName("EPDexpirationDate");

                entity.Property(e => e.EpdfuncUnitDesc)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDFuncUnitDesc");

                entity.Property(e => e.EpdindoorEnv)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDIndoorEnv");

                entity.Property(e => e.EpdintNum)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDIntNum");

                entity.Property(e => e.Epdlanguage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EPDLanguage");

                entity.Property(e => e.Epdlayout)
                    .HasColumnName("EPDLayout")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdmarket)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDMarket");

                entity.Property(e => e.Epdname)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("EPDName");

                entity.Property(e => e.Epdnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDNumber");

                entity.Property(e => e.Epdpcr)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("EPDPCR");

                entity.Property(e => e.EpdpcrId)
                    .HasColumnName("EPDPCR_ID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdpicture2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDPicture2");

                entity.Property(e => e.EpdpicturePath)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDPicturePath");

                entity.Property(e => e.EpdproductLife)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductLife");

                entity.Property(e => e.EpdproductionSite)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductionSite");

                entity.Property(e => e.Epdresponsible)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDResponsible");

                entity.Property(e => e.Epdscenarios)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDScenarios");

                entity.Property(e => e.Epdspesification)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDSpesification");

                entity.Property(e => e.Epdstatus).HasColumnName("EPDStatus");

                entity.Property(e => e.EpdsubType)
                    .HasColumnName("EPDSubType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EpdsysBound)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDSysBound");

                entity.Property(e => e.Epdtech)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDTech");

                entity.Property(e => e.Epdunit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDUnit");

                entity.Property(e => e.EpdunitCalc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("EPDUnit_Calc");

                entity.Property(e => e.Epdyear).HasColumnName("EPDYear");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");

                entity.Property(e => e.NoEdit).HasColumnName("NO_Edit");

                entity.Property(e => e.PdfsourceDatasetId)
                    .HasColumnName("PDFSourceDatasetID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProductFlowDatasetId)
                    .HasColumnName("ProductFlowDatasetID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProductionSiteId)
                    .HasColumnName("ProductionSiteID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ThirdPartyVerifier).HasColumnName("Third_party_verifier");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.EpdheadingDigis)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDHeadingDigi_COMPANY");
            });

            modelBuilder.Entity<Epdlayout>(entity =>
            {
                entity.ToTable("EPDLayout");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.A1txt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("A1Txt");

                entity.Property(e => e.A2txt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("A2Txt");

                entity.Property(e => e.A3txt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("A3Txt");

                entity.Property(e => e.A4txt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("A4Txt");

                entity.Property(e => e.A5txt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("A5Txt");

                entity.Property(e => e.B1txt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("B1Txt");

                entity.Property(e => e.B2txt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("B2Txt");

                entity.Property(e => e.B3txt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("B3Txt");

                entity.Property(e => e.B4txt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("B4Txt");

                entity.Property(e => e.B5txt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("B5Txt");

                entity.Property(e => e.B6txt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("B6Txt");

                entity.Property(e => e.B7txt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("B7Txt");

                entity.Property(e => e.C1txt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("C1Txt");

                entity.Property(e => e.C2txt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("C2Txt");

                entity.Property(e => e.C3txt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("C3Txt");

                entity.Property(e => e.C4txt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("C4Txt");

                entity.Property(e => e.ClientGroupsId).HasColumnName("ClientGroupsID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.D1txt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("D1Txt");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Epd3party)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPD3Party");

                entity.Property(e => e.Epd3partyName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPD3PartyName");

                entity.Property(e => e.Epd3partyNameId).HasColumnName("EPD3PartyNameID");

                entity.Property(e => e.Epd3partySubTxt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPD3PartySubTxt");

                entity.Property(e => e.Epda4heading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDA4Heading");

                entity.Property(e => e.Epda5heading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDA5Heading");

                entity.Property(e => e.Epdaddtech)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDADDTech");

                entity.Property(e => e.EpdaddtechTxt)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDADDTechTxt");

                entity.Property(e => e.Epdallocation)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDAllocation");

                entity.Property(e => e.EpdallocationTxt)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("EPDAllocationTxt");

                entity.Property(e => e.Epdapproved)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDApproved");

                entity.Property(e => e.EpdapprovedBy)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDApprovedBy");

                entity.Property(e => e.EpdapprovedByTxt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDApprovedByTxt");

                entity.Property(e => e.EpdapprovedName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDApprovedName");

                entity.Property(e => e.Epdauthor).HasColumnName("EPDAuthor");

                entity.Property(e => e.EpdauthorHeading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDAuthorHeading");

                entity.Property(e => e.Epdb1heading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDB1Heading");

                entity.Property(e => e.Epdb2b3heading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDB2B3Heading");

                entity.Property(e => e.Epdb4b5heading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDB4B5Heading");

                entity.Property(e => e.Epdb6b7heading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDB6B7Heading");

                entity.Property(e => e.EpdbiblHead)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDBiblHead");

                entity.Property(e => e.EpdbiblTxt)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("EPDBiblTxt");

                entity.Property(e => e.Epdbuildinglife)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("EPDBuildinglife");

                entity.Property(e => e.Epdc1c3c4heading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDC1C3C4Heading");

                entity.Property(e => e.Epdc2heading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDC2Heading");

                entity.Property(e => e.Epdc2headingTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDC2HeadingTxt");

                entity.Property(e => e.EpdcompanyNo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDCompanyNo");

                entity.Property(e => e.Epdcompare)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDCompare");

                entity.Property(e => e.EpdcompareTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDCompareTxt");

                entity.Property(e => e.Epdcutoff)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDCutoff");

                entity.Property(e => e.EpdcutoffTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDCutoffTxt");

                entity.Property(e => e.Epdd1heading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDD1Heading");

                entity.Property(e => e.EpddataQuality)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDDataQuality");

                entity.Property(e => e.EpddataQualityTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDDataQualityTxt");

                entity.Property(e => e.Epddeclaration)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDDeclaration");

                entity.Property(e => e.EpddeclarationNo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDDeclarationNo");

                entity.Property(e => e.EpddeclarationTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDDeclarationTxt");

                entity.Property(e => e.EpddeclarationTxt2)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDDeclarationTxt2");

                entity.Property(e => e.Epddecono)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDDECONo");

                entity.Property(e => e.Epddescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDDescription");

                entity.Property(e => e.Epddoneby)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDDoneby");

                entity.Property(e => e.EpddonebyCon)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDDonebyCon");

                entity.Property(e => e.EpddonebyReg)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDDonebyReg");

                entity.Property(e => e.EpddonebyTxt)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("EPDDonebyTxt");

                entity.Property(e => e.Epdemail)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDEmail");

                entity.Property(e => e.EpdendOfLifeFactorHeading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDEndOfLifeFactorHeading");

                entity.Property(e => e.EpdendOfLifeFactorSubTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDEndOfLifeFactorSubTxt");

                entity.Property(e => e.EpdendOfLifeWasteHeading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDEndOfLifeWasteHeading");

                entity.Property(e => e.EpdendOfLifeWasteSubTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDEndOfLifeWasteSubTxt");

                entity.Property(e => e.EpdenviromentHeading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDEnviromentHeading");

                entity.Property(e => e.EpdenviromentSubTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDEnviromentSubTxt");

                entity.Property(e => e.Epdextern)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDExtern");

                entity.Property(e => e.EpdfuncUnit)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDFuncUnit");

                entity.Property(e => e.EpdgeneralHeading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDGeneralHeading");

                entity.Property(e => e.Epdheading)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("EPDHeading");

                entity.Property(e => e.EpdheadingSub)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("EPDHeadingSub");

                entity.Property(e => e.Epdintern)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDIntern");

                entity.Property(e => e.Epdlanguage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDLanguage");

                entity.Property(e => e.Epdlcaheading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDLCAHeading");

                entity.Property(e => e.EpdlcaresultHeading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDLCAResultHeading");

                entity.Property(e => e.EpdlcaresultSubTxt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDLCAResultSubTxt");

                entity.Property(e => e.EpdlcaresultSubTxt2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDLCAResultSubTxt2");

                entity.Property(e => e.EpdlcaresultTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDLCAResultTxt");

                entity.Property(e => e.EpdlcasenariosHeading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDLCASenariosHeading");

                entity.Property(e => e.EpdlcasenariosHeadingTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDLCASenariosHeadingTxt");

                entity.Property(e => e.EpdlistName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("EPDListName");

                entity.Property(e => e.Epdlogo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDLogo");

                entity.Property(e => e.Epdlogo2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDLogo2");

                entity.Property(e => e.EpdmainContact)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDMainContact");

                entity.Property(e => e.EpdmainPicture)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDMainPicture");

                entity.Property(e => e.Epdname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDName");

                entity.Property(e => e.EpdnoaddDanger1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddDanger1");

                entity.Property(e => e.EpdnoaddDanger2)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddDanger2");

                entity.Property(e => e.EpdnoaddDanger3)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddDanger3");

                entity.Property(e => e.EpdnoaddDanger4)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddDanger4");

                entity.Property(e => e.EpdnoaddDanger5)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddDanger5");

                entity.Property(e => e.EpdnoaddHeading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddHeading");

                entity.Property(e => e.EpdnoaddTxt)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddTXT");

                entity.Property(e => e.Epdnoaddsubhead1)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddsubhead1");

                entity.Property(e => e.Epdnoaddsubhead1Txt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddsubhead1Txt");

                entity.Property(e => e.Epdnoaddsubhead2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddsubhead2");

                entity.Property(e => e.Epdnoaddsubhead2Txt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddsubhead2Txt");

                entity.Property(e => e.Epdnoaddsubhead3)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddsubhead3");

                entity.Property(e => e.Epdnoaddsubhead3Txt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddsubhead3Txt");

                entity.Property(e => e.Epdnoaddsubhead4)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddsubhead4");

                entity.Property(e => e.Epdnoaddsubhead4Txt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddsubhead4Txt");

                entity.Property(e => e.Epdoperator)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDOperator");

                entity.Property(e => e.EpdoperatorPublisher)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDOperatorPublisher");

                entity.Property(e => e.EpdoperatorTxt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDOperatorTxt");

                entity.Property(e => e.Epdowner)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDOwner");

                entity.Property(e => e.EpdownerTxt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDOwnerTxt");

                entity.Property(e => e.Epdpcr)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDPCR");

                entity.Property(e => e.Epdpcrtxt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDPCRTxt");

                entity.Property(e => e.Epdphone)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDPhone");

                entity.Property(e => e.Epdpicture1)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDPicture1");

                entity.Property(e => e.Epdpicture2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDPicture2");

                entity.Property(e => e.Epdproducer)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDProducer");

                entity.Property(e => e.EpdproductDescrition)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductDescrition");

                entity.Property(e => e.EpdproductDescritionTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductDescritionTxt");

                entity.Property(e => e.EpdproductHeading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductHeading");

                entity.Property(e => e.EpdproductLife)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductLife");

                entity.Property(e => e.EpdproductLifeTxt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductLifeTxt");

                entity.Property(e => e.EpdproductMarket)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductMarket");

                entity.Property(e => e.EpdproductMarketTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductMarketTxt");

                entity.Property(e => e.EpdproductSpesification)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductSpesification");

                entity.Property(e => e.EpdproductSpesificationTable)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductSpesificationTable");

                entity.Property(e => e.EpdproductSpesificationTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductSpesificationTxt");

                entity.Property(e => e.EpdproductTechical)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductTechical");

                entity.Property(e => e.EpdproductTechicalTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductTechicalTxt");

                entity.Property(e => e.EpdproductionSite)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductionSite");

                entity.Property(e => e.Epdpublisher)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDPublisher");

                entity.Property(e => e.EpdpublisherTxt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDPublisherTxt");

                entity.Property(e => e.EpdpublishingNo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDPublishingNo");

                entity.Property(e => e.EpdqualitySystem)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDQualitySystem");

                entity.Property(e => e.EpdresressourcesHeading)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("EPDResressourcesHeading");

                entity.Property(e => e.EpdressourcesSubTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDressourcesSubTxt");

                entity.Property(e => e.Epdsign)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDSign");

                entity.Property(e => e.Epdstudy)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDStudy");

                entity.Property(e => e.EpdsubTxt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDSubTxt");

                entity.Property(e => e.Epdsystem)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDSystem");

                entity.Property(e => e.EpdsystemHeading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDSystemHeading");

                entity.Property(e => e.EpdsystemSubTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDSystemSubTxt");

                entity.Property(e => e.EpdsystemTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDSystemTxt");

                entity.Property(e => e.EpdsystemTxt2)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDSystemTxt2");

                entity.Property(e => e.EpdtoolDeveloperHeading)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDToolDeveloperHeading");

                entity.Property(e => e.EpdtoolInfo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EPDToolInfo");

                entity.Property(e => e.EpdtoolInfoTxt)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("EPDToolInfoTxt");

                entity.Property(e => e.Epdunit)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDUnit");

                entity.Property(e => e.EpdunitOption)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDUnitOption");

                entity.Property(e => e.EpdunitOptionTxt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDUnitOptionTxt");

                entity.Property(e => e.Epdvalid)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDValid");

                entity.Property(e => e.Epdverificatior)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDVerificatior");

                entity.Property(e => e.EpdverificatiorTxt)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EPDVerificatiorTxt");

                entity.Property(e => e.Epdversion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDVersion");

                entity.Property(e => e.Epdweb)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDWeb");

                entity.Property(e => e.Epdyear)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDYear");

                entity.Property(e => e.Suma1a3).HasColumnName("SUMA1A3");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Epdlink>(entity =>
            {
                entity.ToTable("EPDLinks");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EpdId).HasColumnName("EPD_ID");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.Epdlinks)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDLinks_EPDHeading");
            });

            modelBuilder.Entity<EpdmaterialList>(entity =>
            {
                entity.ToTable("EPDMaterialList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.Fase).HasColumnName("fase");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Range)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdmaterialsCepe>(entity =>
            {
                entity.ToTable("EPDMaterialsCEPE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DataQuality)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EP");

                entity.Property(e => e.EpdmaterialId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDMaterialID");

                entity.Property(e => e.EpdmaterialName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("EPDMaterialName");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.FEConsumption)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("F_E_consumption");

                entity.Property(e => e.FEUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("F_E_Unit");

                entity.Property(e => e.FuelEnergy)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Fuel_Energy");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HelpText)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.InternalComments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Internal_Comments");

                entity.Property(e => e.LoadCap)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Load_Cap");

                entity.Property(e => e.MaterialGroupId).HasColumnName("MaterialGroupID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("ODP");

                entity.Property(e => e.PefAp)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_AP");

                entity.Property(e => e.PefEcotox)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_ECOTOX");

                entity.Property(e => e.PefFep)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_FEP");

                entity.Property(e => e.PefFosdep)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_FOSDEP");

                entity.Property(e => e.PefGwp)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_GWP");

                entity.Property(e => e.PefHtc)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_HTC");

                entity.Property(e => e.PefHtnc)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_HTNC");

                entity.Property(e => e.PefIre)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_IRE");

                entity.Property(e => e.PefIrhh)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_IRHH");

                entity.Property(e => e.PefLanduse)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_LANDUSE");

                entity.Property(e => e.PefMep)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_MEP");

                entity.Property(e => e.PefOdp)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_ODP");

                entity.Property(e => e.PefPm)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_PM");

                entity.Property(e => e.PefPocp)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_POCP");

                entity.Property(e => e.PefTep)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_TEP");

                entity.Property(e => e.PefWater)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_WATER");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenA4).HasColumnName("Sen_A4");

                entity.Property(e => e.SenA5).HasColumnName("Sen_A5");

                entity.Property(e => e.SenB1).HasColumnName("Sen_B1");

                entity.Property(e => e.SenB2).HasColumnName("Sen_B2");

                entity.Property(e => e.SenB2b3).HasColumnName("Sen_B2B3");

                entity.Property(e => e.SenC1c3c4).HasColumnName("Sen_C1C3C4");

                entity.Property(e => e.SenC2).HasColumnName("Sen_C2");

                entity.Property(e => e.SenD).HasColumnName("Sen_D");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("unit");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Unit_calc")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.YearStudy).HasColumnName("Year_study");
            });

            modelBuilder.Entity<EpdmaterialsEpd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EPDMaterialsEPD");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("EP");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("SUM2");
            });

            modelBuilder.Entity<EpdmaterialsSima>(entity =>
            {
                entity.ToTable("EPDMaterialsSIMA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(22, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DataQuality)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.EpdmaterialId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDMaterialID");

                entity.Property(e => e.EpdmaterialName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("EPDMaterialName");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(22, 12)");

                entity.Property(e => e.FEConsumption)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("F_E_consumption");

                entity.Property(e => e.FEUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("F_E_Unit");

                entity.Property(e => e.FuelEnergy)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Fuel_Energy");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.Gwpbc)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPBC");

                entity.Property(e => e.Gwpiobc)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("GWPIOBC");

                entity.Property(e => e.HelpText)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.InternalComments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Internal_Comments");

                entity.Property(e => e.LoadCap)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Load_Cap");

                entity.Property(e => e.MaterialGroupId).HasColumnName("MaterialGroupID");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.PefAp)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_AP");

                entity.Property(e => e.PefEcotox)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_ECOTOX");

                entity.Property(e => e.PefFep)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_FEP");

                entity.Property(e => e.PefFosdep)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_FOSDEP");

                entity.Property(e => e.PefGwp)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_GWP");

                entity.Property(e => e.PefHtc)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_HTC");

                entity.Property(e => e.PefHtnc)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_HTNC");

                entity.Property(e => e.PefIre)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_IRE");

                entity.Property(e => e.PefIrhh)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_IRHH");

                entity.Property(e => e.PefLanduse)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PEF_LANDUSE");

                entity.Property(e => e.PefMep)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_MEP");

                entity.Property(e => e.PefOdp)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_ODP");

                entity.Property(e => e.PefPm)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_PM");

                entity.Property(e => e.PefPocp)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_POCP");

                entity.Property(e => e.PefTep)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_TEP");

                entity.Property(e => e.PefWater)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("PEF_WATER");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.ReCycleId).HasColumnName("ReCycleID");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenA4).HasColumnName("Sen_A4");

                entity.Property(e => e.SenA5).HasColumnName("Sen_A5");

                entity.Property(e => e.SenB1).HasColumnName("Sen_B1");

                entity.Property(e => e.SenB2).HasColumnName("Sen_B2");

                entity.Property(e => e.SenB2b3).HasColumnName("Sen_B2B3");

                entity.Property(e => e.SenB4b5).HasColumnName("Sen_B4B5");

                entity.Property(e => e.SenB6b7).HasColumnName("Sen_B6B7");

                entity.Property(e => e.SenC1c3c4).HasColumnName("Sen_C1C3C4");

                entity.Property(e => e.SenC2).HasColumnName("Sen_C2");

                entity.Property(e => e.SenD).HasColumnName("Sen_D");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(22, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("unit");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Unit_calc")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsedCap)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Used_cap");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.YearStudy).HasColumnName("Year_study");
            });

            modelBuilder.Entity<EpdmaterialsSimasubProcess>(entity =>
            {
                entity.ToTable("EPDMaterialsSIMASubProcess");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Fase)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MainId).HasColumnName("MainID");

                entity.Property(e => e.SubId).HasColumnName("SubID");

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(18, 9)")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Epdpcr>(entity =>
            {
                entity.ToTable("EPDPCR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Fase)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.Property(e => e.Pcrname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PCRName");

                entity.Property(e => e.Pcrnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PCRNumber");

                entity.Property(e => e.Pcrurl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PCRURL");

                entity.Property(e => e.ProgramOperator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uuid).HasColumnName("UUID");

                entity.Property(e => e.ValidToDate).HasColumnType("date");

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Epdpcrlink>(entity =>
            {
                entity.ToTable("EPDPCRLink");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Epdquantity)
                    .HasColumnType("decimal(29, 9)")
                    .HasColumnName("EPDQuantity");

                entity.Property(e => e.Fase)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Pcrid).HasColumnName("PCRID");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");
            });

            modelBuilder.Entity<EpdprojectFase>(entity =>
            {
                entity.ToTable("EPDProjectFases");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdbit).HasColumnName("EPDBit");

                entity.Property(e => e.Epdfilling)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDFilling");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.Epdname)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDName");

                entity.Property(e => e.Epdquantity)
                    .HasColumnType("decimal(29, 9)")
                    .HasColumnName("EPDQuantity")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EpdrecId).HasColumnName("EPDRecID");

                entity.Property(e => e.EpdrefId).HasColumnName("EPDRefID");

                entity.Property(e => e.EpdrefName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDRefName");

                entity.Property(e => e.Epdreturn)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDReturn");

                entity.Property(e => e.Epdreuse)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDReuse");

                entity.Property(e => e.Epdunit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDUnit");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Extra)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Gwpbc)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWPBC");

                entity.Property(e => e.Gwpiobc)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWPIOBC");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Level).HasDefaultValueSql("((1))");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OldId).HasColumnName("OldID");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReCyclePer).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(29, 9)")
                    .HasColumnName("Unit_calc")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(27, 12)")
                    .HasColumnName("Unit_calcT")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdprojectFases)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDProjectFases_EPDHeading");
            });

            modelBuilder.Entity<EpdprojectGroupSetup>(entity =>
            {
                entity.ToTable("EPDProjectGroupSetup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comid).HasColumnName("COMID");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(100)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<EpdprojectHeading>(entity =>
            {
                entity.ToTable("EPDProjectHeading");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.A1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.A2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.A3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.A4)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.A5)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B4)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B5)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B6)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.B7)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.C4)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.D1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MND')");

                entity.Property(e => e.EpdaddTech)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDAddTech");

                entity.Property(e => e.Epdallocation)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDAllocation");

                entity.Property(e => e.EpdapprovedDate)
                    .HasColumnType("date")
                    .HasColumnName("EPDApprovedDate");

                entity.Property(e => e.Epdbibllio)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDBibllio");

                entity.Property(e => e.EpdbuildingLife)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDBuildingLife");

                entity.Property(e => e.EpdcutOff)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDCutOff");

                entity.Property(e => e.Epddangerous)
                    .HasColumnName("EPDDangerous")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EpddataQuality)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDDataQuality");

                entity.Property(e => e.Epddate)
                    .HasColumnType("date")
                    .HasColumnName("EPDDate");

                entity.Property(e => e.EpddefaultEpdid)
                    .HasColumnName("EPDDefaultEPDID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Epddescription)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDDescription");

                entity.Property(e => e.Epdeditor)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDEditor");

                entity.Property(e => e.EpdexpirationDate)
                    .HasColumnType("date")
                    .HasColumnName("EPDexpirationDate");

                entity.Property(e => e.EpdindoorEnv)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDIndoorEnv");

                entity.Property(e => e.EpdintNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDIntNum");

                entity.Property(e => e.Epdlanguage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EPDLanguage");

                entity.Property(e => e.Epdlayout)
                    .HasColumnName("EPDLayout")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdmarket)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDMarket");

                entity.Property(e => e.Epdname)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("EPDName");

                entity.Property(e => e.Epdnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDNumber");

                entity.Property(e => e.Epdpcr)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("EPDPCR");

                entity.Property(e => e.Epdpicture2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDPicture2");

                entity.Property(e => e.EpdpicturePath)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDPicturePath");

                entity.Property(e => e.EpdproductLife)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductLife");

                entity.Property(e => e.EpdproductionSite)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductionSite");

                entity.Property(e => e.Epdresponsible)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDResponsible");

                entity.Property(e => e.Epdscenarios)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDScenarios");

                entity.Property(e => e.Epdspesification)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDSpesification");

                entity.Property(e => e.Epdstatus).HasColumnName("EPDStatus");

                entity.Property(e => e.EpdsysBound)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDSysBound");

                entity.Property(e => e.Epdtech)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("EPDTech");

                entity.Property(e => e.Epdunit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDUnit");

                entity.Property(e => e.EpdunitCalc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("EPDUnit_Calc");

                entity.Property(e => e.Epdyear).HasColumnName("EPDYear");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProductionSiteId)
                    .HasColumnName("ProductionSiteID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.EpdprojectHeadings)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EPDProjectHeading_COMPANY");
            });

            modelBuilder.Entity<EpdregisterMain>(entity =>
            {
                entity.ToTable("EPDRegisterMain");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Fase)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Fase2).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpdregistrationA1>(entity =>
            {
                entity.ToTable("EPDRegistrationA1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.Epda1id).HasColumnName("EPDA1ID");

                entity.Property(e => e.Epda1name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDA1Name");

                entity.Property(e => e.Epda1quantity)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDA1Quantity");

                entity.Property(e => e.Epda1unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDA1Unit");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.OldA1id).HasColumnName("OldA1ID");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Unit_calc");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Unit_calcT");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationA1s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationA1_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationA2>(entity =>
            {
                entity.ToTable("EPDRegistrationA2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.Epda2filling).HasColumnName("EPDA2Filling");

                entity.Property(e => e.Epda2id).HasColumnName("EPDA2ID");

                entity.Property(e => e.Epda2km).HasColumnName("EPDA2km");

                entity.Property(e => e.Epda2name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDA2Name");

                entity.Property(e => e.Epda2return).HasColumnName("EPDA2Return");

                entity.Property(e => e.Epda2returnBit).HasColumnName("EPDA2ReturnBit");

                entity.Property(e => e.Epda2reuse).HasColumnName("EPDA2Reuse");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.EpdregistrationA1id).HasColumnName("EPDRegistrationA1ID");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(24, 12)")
                    .HasColumnName("Unit_calcT");

                entity.HasOne(d => d.EpdregistrationA1)
                    .WithMany(p => p.EpdregistrationA2s)
                    .HasForeignKey(d => d.EpdregistrationA1id)
                    .HasConstraintName("FK_EPDRegistrationA2_EPDRegistrationA1");
            });

            modelBuilder.Entity<EpdregistrationA3>(entity =>
            {
                entity.ToTable("EPDRegistrationA3");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.Epda3id).HasColumnName("EPDA3ID");

                entity.Property(e => e.Epda3name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDA3Name");

                entity.Property(e => e.Epda3quantity)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EPDA3Quantity");

                entity.Property(e => e.Epda3unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDA3Unit");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Unit_calc");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Unit_calcT");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationA3s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationA3_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationA4>(entity =>
            {
                entity.ToTable("EPDRegistrationA4");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.Epda4filling).HasColumnName("EPDA4Filling");

                entity.Property(e => e.Epda4id).HasColumnName("EPDA4ID");

                entity.Property(e => e.Epda4km).HasColumnName("EPDA4km");

                entity.Property(e => e.Epda4name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDA4Name");

                entity.Property(e => e.Epda4return).HasColumnName("EPDA4Return");

                entity.Property(e => e.Epda4reuse).HasColumnName("EPDA4Reuse");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenA4).HasColumnName("Sen_A4");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Unit_calcT");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationA4s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationA4_EPDHeading1");
            });

            modelBuilder.Entity<EpdregistrationA5>(entity =>
            {
                entity.ToTable("EPDRegistrationA5");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.Epda5id).HasColumnName("EPDA5ID");

                entity.Property(e => e.Epda5name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDA5Name");

                entity.Property(e => e.Epda5quantity)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDA5Quantity");

                entity.Property(e => e.Epda5unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDA5Unit");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenA5).HasColumnName("Sen_A5");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Unit_calc");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Unit_calcT");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationA5s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationA5_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationB1>(entity =>
            {
                entity.ToTable("EPDRegistrationB1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.Epdb1id).HasColumnName("EPDB1ID");

                entity.Property(e => e.Epdb1name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDB1Name");

                entity.Property(e => e.Epdb1quantity)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDB1Quantity");

                entity.Property(e => e.Epdb1unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDB1Unit");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenB1).HasColumnName("Sen_B1");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Unit_calc");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Unit_calcT");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationB1s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationB1_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationB2>(entity =>
            {
                entity.ToTable("EPDRegistrationB2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.Epdb2id).HasColumnName("EPDB2ID");

                entity.Property(e => e.Epdb2name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDB2Name");

                entity.Property(e => e.Epdb2quantity)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDB2Quantity");

                entity.Property(e => e.Epdb2unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDB2Unit");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenB2).HasColumnName("Sen_B2");

                entity.Property(e => e.SenB2b3).HasColumnName("Sen_B2B3");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Unit_calc");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Unit_calcT");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationB2s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationB2_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationB3>(entity =>
            {
                entity.ToTable("EPDRegistrationB3");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.Epdb3id).HasColumnName("EPDB3ID");

                entity.Property(e => e.Epdb3name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDB3Name");

                entity.Property(e => e.Epdb3quantity)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDB3Quantity");

                entity.Property(e => e.Epdb3unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDB3Unit");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenB2b3).HasColumnName("Sen_B2B3");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Unit_calc");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Unit_calcT");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationB3s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationB3_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationB4>(entity =>
            {
                entity.ToTable("EPDRegistrationB4");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.Epdb4id).HasColumnName("EPDB4ID");

                entity.Property(e => e.Epdb4name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDB4Name");

                entity.Property(e => e.Epdb4quantity)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDB4Quantity");

                entity.Property(e => e.Epdb4unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDB4Unit");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenB4b5).HasColumnName("Sen_B4B5");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Unit_calc");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Unit_calcT");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationB4s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationB4_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationB5>(entity =>
            {
                entity.ToTable("EPDRegistrationB5");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.Epdb5id).HasColumnName("EPDB5ID");

                entity.Property(e => e.Epdb5name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDB5Name");

                entity.Property(e => e.Epdb5quantity)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDB5Quantity");

                entity.Property(e => e.Epdb5unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDB5Unit");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenB4b5).HasColumnName("Sen_B4B5");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Unit_calc");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Unit_calcT");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationB5s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationB5_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationB6>(entity =>
            {
                entity.ToTable("EPDRegistrationB6");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.Epdb6id).HasColumnName("EPDB6ID");

                entity.Property(e => e.Epdb6name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDB6Name");

                entity.Property(e => e.Epdb6quantity)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDB6Quantity");

                entity.Property(e => e.Epdb6unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDB6Unit");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenB6b7).HasColumnName("Sen_B6B7");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Unit_calc");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Unit_calcT");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationB6s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationB6_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationB7>(entity =>
            {
                entity.ToTable("EPDRegistrationB7");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.Epdb7id).HasColumnName("EPDB7ID");

                entity.Property(e => e.Epdb7name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDB7Name");

                entity.Property(e => e.Epdb7quantity)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDB7Quantity");

                entity.Property(e => e.Epdb7unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDB7Unit");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenB6b7).HasColumnName("Sen_B6B7");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Unit_calc");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Unit_calcT");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationB7s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationB7_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationC1>(entity =>
            {
                entity.ToTable("EPDRegistrationC1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.Epdc1id).HasColumnName("EPDC1ID");

                entity.Property(e => e.Epdc1name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDC1Name");

                entity.Property(e => e.Epdc1quantity)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDC1Quantity");

                entity.Property(e => e.Epdc1unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDC1Unit");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenC1c3c4).HasColumnName("Sen_C1C3C4");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Unit_calc");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Unit_calcT");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationC1s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationC1_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationC2>(entity =>
            {
                entity.ToTable("EPDRegistrationC2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.Epdc2filling).HasColumnName("EPDC2Filling");

                entity.Property(e => e.Epdc2id).HasColumnName("EPDC2ID");

                entity.Property(e => e.Epdc2km).HasColumnName("EPDC2km");

                entity.Property(e => e.Epdc2name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDC2Name");

                entity.Property(e => e.Epdc2return).HasColumnName("EPDC2Return");

                entity.Property(e => e.Epdc2reuse).HasColumnName("EPDC2Reuse");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenC2).HasColumnName("Sen_C2");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Unit_calcT");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationC2s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationC2_EPDHeading1");
            });

            modelBuilder.Entity<EpdregistrationC3>(entity =>
            {
                entity.ToTable("EPDRegistrationC3");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.Epdc3id).HasColumnName("EPDC3ID");

                entity.Property(e => e.Epdc3name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDC3Name");

                entity.Property(e => e.Epdc3quantity)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDC3Quantity");

                entity.Property(e => e.Epdc3unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDC3Unit");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenC1c3c4).HasColumnName("Sen_C1C3C4");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Unit_calc");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Unit_calcT");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationC3s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationC3_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationC4>(entity =>
            {
                entity.ToTable("EPDRegistrationC4");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.Epdc4id).HasColumnName("EPDC4ID");

                entity.Property(e => e.Epdc4name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDC4Name");

                entity.Property(e => e.Epdc4quantity)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDC4Quantity");

                entity.Property(e => e.Epdc4unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDC4Unit");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenC1c3c4).HasColumnName("Sen_C1C3C4");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Unit_calc");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Unit_calcT");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationC4s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationC4_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationD1>(entity =>
            {
                entity.ToTable("EPDRegistrationD1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP");

                entity.Property(e => e.Epdd1id).HasColumnName("EPDD1ID");

                entity.Property(e => e.Epdd1name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDD1Name");

                entity.Property(e => e.Epdd1quantity)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDD1Quantity");

                entity.Property(e => e.Epdd1unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDD1Unit");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat");

                entity.Property(e => e.Extra).HasColumnType("decimal(21, 12)");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials");

                entity.Property(e => e.SenD1).HasColumnName("Sen_D1");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("Unit_calc");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Unit_calcT");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationD1s)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationD1_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationFase>(entity =>
            {
                entity.ToTable("EPDRegistrationFases");

                entity.HasIndex(e => new { e.EpdheadingId, e.Fase }, "NonClusteredIndex-20181114-204848");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abiotic)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AbioticFossil)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Abiotic_Fossil")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ap)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("AP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComReuse)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Com_Reuse")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ep)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("EP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Epdbit).HasColumnName("EPDBit");

                entity.Property(e => e.Epdfilling)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDFilling");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.Epdname)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDName");

                entity.Property(e => e.Epdquantity)
                    .HasColumnType("decimal(29, 9)")
                    .HasColumnName("EPDQuantity")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EpdrecId).HasColumnName("EPDRecID");

                entity.Property(e => e.EpdrefId).HasColumnName("EPDRefID");

                entity.Property(e => e.EpdrefName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDRefName");

                entity.Property(e => e.Epdreturn)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDReturn");

                entity.Property(e => e.Epdreuse)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDReuse");

                entity.Property(e => e.Epdunit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDUnit");

                entity.Property(e => e.ExportedEnergyEl)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_EL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportedEnergyHeat)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Exported_Energy_Heat")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Extra)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Gwpbc)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWPBC");

                entity.Property(e => e.Gwpiobc)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("GWPIOBC");

                entity.Property(e => e.HwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("HW_Disposal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Level).HasDefaultValueSql("((1))");

                entity.Property(e => e.MaterialsRecycling)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Materials_Recycling")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MeRecovery)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ME_Recovery")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetFreshWater)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Net_Fresh_Water")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NhwDisposal)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NHW_Disposal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NrpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_EnergyCarrier")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NrpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRP_Material")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NrsFuels)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("NRS_Fuels")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Odp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("ODP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OldId)
                    .HasColumnName("OldID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Pocp)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("POCP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReCyclePer)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RpEnergyCarrier)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_EnergyCarrier")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RpMaterial)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RP_Material")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RsFuelsEnergy)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RS_Fuels_Energy")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RwDisposed)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("RW_Disposed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SecondaryMaterials)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("Secondary_Materials")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sum1)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sum2)
                    .HasColumnType("decimal(21, 12)")
                    .HasColumnName("SUM2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(29, 9)")
                    .HasColumnName("Unit_calc")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitCalcT)
                    .HasColumnType("decimal(26, 12)")
                    .HasColumnName("Unit_calcT")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WastagePer)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationFases)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationFases_EPDHeading");
            });

            modelBuilder.Entity<EpdregistrationFasesDigi>(entity =>
            {
                entity.ToTable("EPDRegistrationFasesDigi");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.A1)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.A2)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.A3)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.A4)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.A5)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.B1)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.B2)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.B3)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.B4)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.B5)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.B6)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.B7)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.C1)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.C2)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.C3)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.C4)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.D1)
                    .HasColumnType("decimal(21, 12)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.Epdname)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EPDName");

                entity.Property(e => e.Epdquantity)
                    .HasColumnType("decimal(29, 9)")
                    .HasColumnName("EPDQuantity")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EpdrecId).HasColumnName("EPDRecID");

                entity.Property(e => e.Epdunit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDUnit");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitCalc)
                    .HasColumnType("decimal(29, 9)")
                    .HasColumnName("Unit_calc")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.EpdregistrationFasesDigis)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDRegistrationFasesDigi_EPDHeading");
            });

            modelBuilder.Entity<Epdshare>(entity =>
            {
                entity.ToTable("EPDShare");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comid).HasColumnName("COMID");

                entity.Property(e => e.Contact)
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EpdheadingId).HasColumnName("EPDHeadingID");

                entity.Property(e => e.FullSingleShare).HasColumnName("Full_Single_Share");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Type).HasColumnName("type");

                entity.HasOne(d => d.Epdheading)
                    .WithMany(p => p.Epdshares)
                    .HasForeignKey(d => d.EpdheadingId)
                    .HasConstraintName("FK_EPDShare_EPDHeading");
            });

            modelBuilder.Entity<EpdsubType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EPDSubType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fordeling>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Fordeling");

                entity.Property(e => e.Fordeling1)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("Fordeling");

                entity.Property(e => e.Sortering)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Impact>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Impact");

                entity.Property(e => e.ImpactCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImpactId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ImpactID");

                entity.Property(e => e.ImpactScalar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProcessID");
            });

            modelBuilder.Entity<ImpactCat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ImpactCat");

                entity.Property(e => e.Column0)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column1)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LanguageListIso6391>(entity =>
            {
                entity.ToTable("LanguageListISO6391");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iso6391code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ISO6391Code");

                entity.Property(e => e.LanguageName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Layout>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("layout");

                entity.Property(e => e.A1txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("A1Txt");

                entity.Property(e => e.A2txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("A2Txt");

                entity.Property(e => e.A3txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("A3Txt");

                entity.Property(e => e.A4txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("A4Txt");

                entity.Property(e => e.A5txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("A5Txt");

                entity.Property(e => e.B1txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("B1Txt");

                entity.Property(e => e.B2txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("B2Txt");

                entity.Property(e => e.B3txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("B3Txt");

                entity.Property(e => e.B4txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("B4Txt");

                entity.Property(e => e.B5txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("B5Txt");

                entity.Property(e => e.B6txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("B6Txt");

                entity.Property(e => e.B7txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("B7Txt");

                entity.Property(e => e.C1txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C1Txt");

                entity.Property(e => e.C2txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C2Txt");

                entity.Property(e => e.C3txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C3Txt");

                entity.Property(e => e.C4txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C4Txt");

                entity.Property(e => e.Comments)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.D1txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("D1Txt");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Epd3party)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPD3Party");

                entity.Property(e => e.Epd3partyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPD3PartyName");

                entity.Property(e => e.Epd3partySubTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPD3PartySubTxt");

                entity.Property(e => e.Epda4heading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDA4Heading");

                entity.Property(e => e.Epda5heading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDA5Heading");

                entity.Property(e => e.Epdallocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDAllocation");

                entity.Property(e => e.EpdallocationTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDAllocationTxt");

                entity.Property(e => e.Epdapproved)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDApproved");

                entity.Property(e => e.EpdapprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDApprovedBy");

                entity.Property(e => e.EpdapprovedByTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDApprovedByTxt");

                entity.Property(e => e.EpdapprovedName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDApprovedName");

                entity.Property(e => e.Epdb1heading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDB1Heading");

                entity.Property(e => e.Epdb2b3heading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDB2B3Heading");

                entity.Property(e => e.Epdb4b5heading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDB4B5Heading");

                entity.Property(e => e.Epdb6b7heading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDB6B7Heading");

                entity.Property(e => e.EpdbiblHead)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDBiblHead");

                entity.Property(e => e.EpdbiblTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDBiblTxt");

                entity.Property(e => e.Epdc1c3c4heading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDC1C3C4Heading");

                entity.Property(e => e.Epdc2heading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDC2Heading");

                entity.Property(e => e.Epdc2headingTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDC2HeadingTxt");

                entity.Property(e => e.EpdcompanyNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDCompanyNo");

                entity.Property(e => e.Epdcompare)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDCompare");

                entity.Property(e => e.EpdcompareTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDCompareTxt");

                entity.Property(e => e.Epdcutoff)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDCutoff");

                entity.Property(e => e.EpdcutoffTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDCutoffTxt");

                entity.Property(e => e.Epdd1heading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDD1Heading");

                entity.Property(e => e.EpddataQuality)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDDataQuality");

                entity.Property(e => e.EpddataQualityTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDDataQualityTxt");

                entity.Property(e => e.Epddeclaration)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDDeclaration");

                entity.Property(e => e.EpddeclarationNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDDeclarationNo");

                entity.Property(e => e.EpddeclarationTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDDeclarationTxt");

                entity.Property(e => e.EpddeclarationTxt2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDDeclarationTxt2");

                entity.Property(e => e.Epddecono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDDECONo");

                entity.Property(e => e.Epddescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDDescription");

                entity.Property(e => e.Epddoneby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDDoneby");

                entity.Property(e => e.EpddonebyCon)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDDonebyCon");

                entity.Property(e => e.EpddonebyReg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDDonebyReg");

                entity.Property(e => e.EpddonebyTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDDonebyTxt");

                entity.Property(e => e.EpdendOfLifeFactorHeading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDEndOfLifeFactorHeading");

                entity.Property(e => e.EpdendOfLifeFactorSubTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDEndOfLifeFactorSubTxt");

                entity.Property(e => e.EpdendOfLifeWasteHeading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDEndOfLifeWasteHeading");

                entity.Property(e => e.EpdendOfLifeWasteSubTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDEndOfLifeWasteSubTxt");

                entity.Property(e => e.EpdenviromentHeading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDEnviromentHeading");

                entity.Property(e => e.EpdenviromentSubTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDEnviromentSubTxt");

                entity.Property(e => e.Epdextern)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDExtern");

                entity.Property(e => e.EpdgeneralHeading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDGeneralHeading");

                entity.Property(e => e.Epdheading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDHeading");

                entity.Property(e => e.EpdheadingSub)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDHeadingSub");

                entity.Property(e => e.Epdintern)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDIntern");

                entity.Property(e => e.Epdlanguage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDLanguage");

                entity.Property(e => e.Epdlcaheading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDLCAHeading");

                entity.Property(e => e.EpdlcaresultHeading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDLCAResultHeading");

                entity.Property(e => e.EpdlcaresultTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDLCAResultTxt");

                entity.Property(e => e.EpdlcasenariosHeading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDLCASenariosHeading");

                entity.Property(e => e.EpdlcasenariosHeadingTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDLCASenariosHeadingTxt");

                entity.Property(e => e.EpdlistName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDListName");

                entity.Property(e => e.Epdlogo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDLogo");

                entity.Property(e => e.EpdmainPicture)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDMainPicture");

                entity.Property(e => e.Epdname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDName");

                entity.Property(e => e.EpdnoaddDanger1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddDanger1");

                entity.Property(e => e.EpdnoaddDanger2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddDanger2");

                entity.Property(e => e.EpdnoaddDanger3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddDanger3");

                entity.Property(e => e.EpdnoaddDanger4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddDanger4");

                entity.Property(e => e.EpdnoaddHeading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddHeading");

                entity.Property(e => e.EpdnoaddTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddTXT");

                entity.Property(e => e.Epdnoaddsubhead1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddsubhead1");

                entity.Property(e => e.Epdnoaddsubhead1Txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddsubhead1Txt");

                entity.Property(e => e.Epdnoaddsubhead2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddsubhead2");

                entity.Property(e => e.Epdnoaddsubhead2Txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddsubhead2Txt");

                entity.Property(e => e.Epdnoaddsubhead3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddsubhead3");

                entity.Property(e => e.Epdnoaddsubhead3Txt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDNOAddsubhead3Txt");

                entity.Property(e => e.Epdoperator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDOperator");

                entity.Property(e => e.EpdoperatorTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDOperatorTxt");

                entity.Property(e => e.Epdowner)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDOwner");

                entity.Property(e => e.EpdownerTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDOwnerTxt");

                entity.Property(e => e.Epdpcr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDPCR");

                entity.Property(e => e.Epdpcrtxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDPCRTxt");

                entity.Property(e => e.Epdpicture1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDPicture1");

                entity.Property(e => e.Epdpicture2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDPicture2");

                entity.Property(e => e.Epdproducer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDProducer");

                entity.Property(e => e.EpdproductDescrition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductDescrition");

                entity.Property(e => e.EpdproductDescritionTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductDescritionTxt");

                entity.Property(e => e.EpdproductHeading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductHeading");

                entity.Property(e => e.EpdproductLife)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductLife");

                entity.Property(e => e.EpdproductLifeTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductLifeTxt");

                entity.Property(e => e.EpdproductMarket)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductMarket");

                entity.Property(e => e.EpdproductMarketTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductMarketTxt");

                entity.Property(e => e.EpdproductSpesification)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductSpesification");

                entity.Property(e => e.EpdproductSpesificationTable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductSpesificationTable");

                entity.Property(e => e.EpdproductSpesificationTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductSpesificationTxt");

                entity.Property(e => e.EpdproductTechical)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductTechical");

                entity.Property(e => e.EpdproductTechicalTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductTechicalTxt");

                entity.Property(e => e.EpdproductionSite)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDProductionSite");

                entity.Property(e => e.Epdpublisher)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDPublisher");

                entity.Property(e => e.EpdpublisherTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDPublisherTxt");

                entity.Property(e => e.EpdpublishingNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDPublishingNo");

                entity.Property(e => e.EpdqualitySystem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDQualitySystem");

                entity.Property(e => e.EpdresressourcesHeading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDResressourcesHeading");

                entity.Property(e => e.EpdressourcesSubTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDressourcesSubTxt");

                entity.Property(e => e.Epdstudy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDStudy");

                entity.Property(e => e.EpdsubTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDSubTxt");

                entity.Property(e => e.Epdsystem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDSystem");

                entity.Property(e => e.EpdsystemHeading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDSystemHeading");

                entity.Property(e => e.EpdsystemSubTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDSystemSubTxt");

                entity.Property(e => e.EpdsystemTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDSystemTxt");

                entity.Property(e => e.EpdsystemTxt2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDSystemTxt2");

                entity.Property(e => e.Epdunit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDUnit");

                entity.Property(e => e.EpdunitOption)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDUnitOption");

                entity.Property(e => e.EpdunitOptionTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDUnitOptionTxt");

                entity.Property(e => e.Epdvalid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDValid");

                entity.Property(e => e.Epdverificatior)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDVerificatior");

                entity.Property(e => e.EpdverificatiorTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDVerificatiorTxt");

                entity.Property(e => e.Epdversion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDVersion");

                entity.Property(e => e.Epdyear)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPDYear");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<MainGroup>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.HgruppeId).HasColumnName("HgruppeID");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NEWS");

                entity.Property(e => e.NwsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("NWS_Date");

                entity.Property(e => e.NwsDetail)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("NWS_Detail");

                entity.Property(e => e.NwsExpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("NWS_ExpDate");

                entity.Property(e => e.NwsHead)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NWS_Head");

                entity.Property(e => e.NwsId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NWS_ID");

                entity.Property(e => e.NwsPicture)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NWS_Picture");
            });

            modelBuilder.Entity<NsEn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS-EN");

                entity.Property(e => e.Evidence).HasMaxLength(255);

                entity.Property(e => e.NsEnid).HasColumnName("NS-ENID");

                entity.Property(e => e.PetypeId).HasColumnName("PETypeID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");
            });

            modelBuilder.Entity<PackElementer>(entity =>
            {
                entity.ToTable("PackElementer");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.PematId).HasColumnName("PEMatID");

                entity.Property(e => e.Penettovekt).HasColumnName("PENettovekt");

                entity.Property(e => e.PetypeId).HasColumnName("PETypeID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
            });

            modelBuilder.Entity<PackMaterialList>(entity =>
            {
                entity.ToTable("PackMaterialList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("GWP");

                entity.Property(e => e.KgprT).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PackMaterialId).HasColumnName("PackMaterialID");

                entity.Property(e => e.PackTypeId).HasColumnName("PackTypeID");

                entity.Property(e => e.PrecentResirk)
                    .HasColumnType("decimal(5, 1)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
            });

            modelBuilder.Entity<PackMaterialListSelection>(entity =>
            {
                entity.ToTable("PackMaterialListSelection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Gwp)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("GWP");

                entity.Property(e => e.KgprT).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PackMaterialId).HasColumnName("PackMaterialID");

                entity.Property(e => e.PackTypeId).HasColumnName("PackTypeID");

                entity.Property(e => e.PrecentResirk)
                    .HasColumnType("decimal(5, 1)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductLineId).HasColumnName("ProductLineID");

                entity.HasOne(d => d.ProductLine)
                    .WithMany(p => p.PackMaterialListSelections)
                    .HasForeignKey(d => d.ProductLineId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PackMaterialListSelection_ProductsLine");
            });

            modelBuilder.Entity<Pematerial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PEMaterials");

                entity.Property(e => e.PematId).HasColumnName("PEMatID");

                entity.Property(e => e.PematName).HasColumnName("PEMatName");
            });

            modelBuilder.Entity<Petype>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PETypes");

                entity.Property(e => e.PetypeId).HasColumnName("PETypeID");

                entity.Property(e => e.PetypeName).HasColumnName("PETypeName");
            });

            modelBuilder.Entity<Process>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Column0)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DpakId).HasColumnName("DpakID");

                entity.Property(e => e.FpakId).HasColumnName("FpakID");

                entity.Property(e => e.NoDpakT).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NoFpakT).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NoPallT).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NsEn).HasColumnName("NS_EN");

                entity.Property(e => e.PallId).HasColumnName("PallID");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DataCollectionId).HasColumnName("DataCollectionID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
            });

            modelBuilder.Entity<ProductGroup>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.HgruppeId).HasColumnName("HgruppeID");

                entity.Property(e => e.VgruppeId).HasColumnName("VgruppeID");

                entity.Property(e => e.VgruppeName).HasMaxLength(255);
            });

            modelBuilder.Entity<ProductsLine>(entity =>
            {
                entity.ToTable("ProductsLine");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HeadId).HasColumnName("HeadID");

                entity.Property(e => e.NoDpakT).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NoFpakT).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NoPallT).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NsEn).HasColumnName("NS_EN");

                entity.Property(e => e.PartOfSelection).HasDefaultValueSql("((1))");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UsrId).HasColumnName("USR_ID");

                entity.HasOne(d => d.Head)
                    .WithMany(p => p.ProductsLines)
                    .HasForeignKey(d => d.HeadId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductsLine_ePackHeading");
            });

            modelBuilder.Entity<ProgramModule>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramFile)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StandardCategory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(255);

                entity.Property(e => e.F3).HasMaxLength(255);
            });

            modelBuilder.Entity<TransportDistance>(entity =>
            {
                entity.HasKey(e => e.TransportDistId);

                entity.ToTable("TransportDistance");

                entity.Property(e => e.TransportDistId).HasColumnName("TransportDistID");

                entity.Property(e => e.EpdmaterialsSimaid).HasColumnName("EPDMaterialsSIMAID");

                entity.Property(e => e.TransportDistComment)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.TransportDistKm)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("TransportDistKM");

                entity.Property(e => e.TransportDistName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TransportId).HasColumnName("TransportID");
            });

            modelBuilder.Entity<TransportExp>(entity =>
            {
                entity.ToTable("TransportExp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Co2)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("CO2");

                entity.Property(e => e.Comments)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Epda1id).HasColumnName("EPDA1ID");

                entity.Property(e => e.Epda1kg)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDA1kg");

                entity.Property(e => e.Epda1name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDA1NAME");

                entity.Property(e => e.Epda2id).HasColumnName("EPDA2ID");

                entity.Property(e => e.Epda2km)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("EPDA2km");

                entity.Property(e => e.Epda2name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EPDA2NAME");

                entity.Property(e => e.HeadId).HasColumnName("Head_ID");

                entity.Property(e => e.LineId).HasColumnName("line_ID");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<TransportExpHeader>(entity =>
            {
                entity.ToTable("TransportExpHeader");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("Com_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.Transportname)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.TransportExpHeaders)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TransportExpHeader_COMPANY");
            });

            modelBuilder.Entity<TransportHead>(entity =>
            {
                entity.HasKey(e => e.TransportId);

                entity.ToTable("TransportHead");

                entity.Property(e => e.TransportId).HasColumnName("TransportID");

                entity.Property(e => e.TransportComments)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.TransportName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UsrId);

                entity.ToTable("USERS");

                entity.Property(e => e.UsrId).HasColumnName("USR_ID");

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.UsrActive).HasColumnName("USR_Active");

                entity.Property(e => e.UsrAdd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USR_ADD");

                entity.Property(e => e.UsrApproved).HasColumnName("USR_Approved");

                entity.Property(e => e.UsrCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USR_CITY");

                entity.Property(e => e.UsrComments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("USR_Comments");

                entity.Property(e => e.UsrCompid)
                    .HasColumnName("USR_COMPID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsrCreatedby).HasColumnName("USR_CREATEDBY");

                entity.Property(e => e.UsrCreatedttm)
                    .HasColumnType("datetime")
                    .HasColumnName("USR_CREATEDTTM")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsrEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USR_EMAIL");

                entity.Property(e => e.UsrFullname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USR_FULLNAME");

                entity.Property(e => e.UsrGdpr)
                    .HasColumnType("datetime")
                    .HasColumnName("USR_GDPR");

                entity.Property(e => e.UsrGuid)
                    .HasColumnName("USR_GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UsrLoginname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USR_LOGINNAME");

                entity.Property(e => e.UsrOrganization)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USR_ORGANIZATION");

                entity.Property(e => e.UsrPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USR_PASSWORD");

                entity.Property(e => e.UsrPhone1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USR_PHONE1");

                entity.Property(e => e.UsrPhone2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USR_PHONE2");

                entity.Property(e => e.UsrProid)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("USR_PROID");

                entity.Property(e => e.UsrResetpwd)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("USR_RESETPWD");

                entity.Property(e => e.UsrStatus)
                    .HasColumnName("USR_STATUS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsrTraining)
                    .HasColumnType("date")
                    .HasColumnName("USR_Training");

                entity.Property(e => e.UsrTrainingValid)
                    .HasColumnType("date")
                    .HasColumnName("USR_Training_Valid");

                entity.Property(e => e.UsrType).HasColumnName("USR_TYPE");

                entity.Property(e => e.UsrZip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USR_ZIP");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserType");

                entity.Property(e => e.UtpName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UTP_Name");

                entity.Property(e => e.Utpid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("UTPID");
            });

            modelBuilder.Entity<Usrlink>(entity =>
            {
                entity.ToTable("USRLinks");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.UsrId).HasColumnName("USR_ID");

                entity.Property(e => e.UsrType).HasColumnName("USR_TYPE");

                entity.HasOne(d => d.Usr)
                    .WithMany(p => p.Usrlinks)
                    .HasForeignKey(d => d.UsrId)
                    .HasConstraintName("FK_USRLinks_USERS");
            });

            modelBuilder.Entity<WcmainGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WCMainGroups");

                entity.Property(e => e.Co2)
                    .HasColumnType("decimal(28, 16)")
                    .HasColumnName("CO2");

                entity.Property(e => e.MainGroup)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PriceNet)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Price_NET");
            });

            modelBuilder.Entity<Wcparameter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WCParameter");

                entity.Property(e => e.CalcKeyNum)
                    .HasColumnType("decimal(28, 16)")
                    .HasColumnName("Calc_Key_num");

                entity.Property(e => e.Co2)
                    .HasColumnType("decimal(28, 16)")
                    .HasColumnName("CO2");

                entity.Property(e => e.Cost).HasColumnType("decimal(28, 16)");

                entity.Property(e => e.Revenue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Sector)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WastePrecent)
                    .HasColumnType("decimal(18, 8)")
                    .HasColumnName("Waste_precent");

                entity.Property(e => e.WasteTonne)
                    .HasColumnType("decimal(28, 16)")
                    .HasColumnName("Waste_Tonne");
            });

            modelBuilder.Entity<Xmlunit>(entity =>
            {
                entity.ToTable("XMLUnit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FactorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FactorUnit).HasColumnType("decimal(12, 6)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
