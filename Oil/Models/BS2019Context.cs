using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Oil.Models
{
    public partial class BS2019Context : DbContext
    {
        public BS2019Context()
        {
        }

        public BS2019Context(DbContextOptions<BS2019Context> options)
            : base(options)
        {
        }

        public virtual DbSet<CarStatus> CarStatus { get; set; }
        public virtual DbSet<CollectionStation> CollectionStation { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<ContractPrice> ContractPrice { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<DeliveryCar> DeliveryCar { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<InspectionDetail> InspectionDetail { get; set; }
        public virtual DbSet<JobTitle> JobTitle { get; set; }
        public virtual DbSet<MileageDetail> MileageDetail { get; set; }
        public virtual DbSet<OilDetail> OilDetail { get; set; }
        public virtual DbSet<OilManger> OilManger { get; set; }
        public virtual DbSet<Penalty> Penalty { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Station> Station { get; set; }
        public virtual DbSet<Stronghold> Stronghold { get; set; }
        public virtual DbSet<Supplies> Supplies { get; set; }
        public virtual DbSet<SuppliesDetail> SuppliesDetail { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<TransferDetail> TransferDetail { get; set; }
        public virtual DbSet<UnifiedPenalty> UnifiedPenalty { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:bssid.database.windows.net,1433;Initial Catalog=BS2019;Persist Security Info=False;User ID=daniel88520;Password=Xcv88520;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarStatus>(entity =>
            {
                entity.Property(e => e.CarStatusId)
                    .HasColumnName("CarStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DeliveryCarId).HasColumnName("DeliveryCarID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.DeliveryCar)
                    .WithMany(p => p.CarStatus)
                    .HasForeignKey(d => d.DeliveryCarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarStatus_DeliveryCar");
            });

            modelBuilder.Entity<CollectionStation>(entity =>
            {
                entity.Property(e => e.CollectionStationId)
                    .HasColumnName("CollectionStationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.CollectionStationName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OriginCompany).HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.HasOne(d => d.ContractNavigation)
                    .WithMany(p => p.CollectionStation)
                    .HasForeignKey(d => d.Contract)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollectionStation_Contract");

                entity.HasOne(d => d.RegionNavigation)
                    .WithMany(p => p.CollectionStation)
                    .HasForeignKey(d => d.Region)
                    .HasConstraintName("FK_CollectionStation_Region");
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.Property(e => e.ContractId)
                    .HasColumnName("ContractID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConfirmDate).HasColumnType("date");

                entity.Property(e => e.ContractContent).IsRequired();

                entity.Property(e => e.ContractDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ContractName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.ContractPriceNavigation)
                    .WithMany(p => p.Contract)
                    .HasForeignKey(d => d.ContractPrice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_ContractPrice");
            });

            modelBuilder.Entity<ContractPrice>(entity =>
            {
                entity.Property(e => e.ContractPriceId)
                    .HasColumnName("ContractPriceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherCharge).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PickUpCharge).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ShippingCharge).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SpecialService).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TerminalCharge).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalFreight).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransitCharge).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnifromNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<DeliveryCar>(entity =>
            {
                entity.Property(e => e.DeliveryCarId)
                    .HasColumnName("DeliveryCarID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BuyDate).HasColumnType("date");

                entity.Property(e => e.CarNumber).HasMaxLength(50);

                entity.Property(e => e.Company).HasMaxLength(50);

                entity.Property(e => e.ExhaustVolume)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.License)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StartUseDate).HasColumnType("date");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Year).HasColumnType("date");

                entity.HasOne(d => d.CarOwnerNavigation)
                    .WithMany(p => p.DeliveryCar)
                    .HasForeignKey(d => d.CarOwner)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeliveryCar_Employee");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdentityCard)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.JobTitleNavigation)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.JobTitle)
                    .HasConstraintName("FK_Employee_JobTitle");

                entity.HasOne(d => d.StationNavigation)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.Station)
                    .HasConstraintName("FK_Employee_Station");
            });

            modelBuilder.Entity<InspectionDetail>(entity =>
            {
                entity.HasKey(e => e.InspectionId);

                entity.Property(e => e.InspectionId)
                    .HasColumnName("InspectionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeliveryCarId).HasColumnName("DeliveryCarID");

                entity.Property(e => e.InspectionDate).HasColumnType("date");

                entity.HasOne(d => d.DeliveryCar)
                    .WithMany(p => p.InspectionDetail)
                    .HasForeignKey(d => d.DeliveryCarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InspectionDetail_DeliveryCar");
            });

            modelBuilder.Entity<JobTitle>(entity =>
            {
                entity.Property(e => e.JobTitleId)
                    .HasColumnName("JobTitleID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobId)
                    .HasColumnName("JobID")
                    .HasMaxLength(50);

                entity.Property(e => e.JobLevel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobName).HasMaxLength(50);
            });

            modelBuilder.Entity<MileageDetail>(entity =>
            {
                entity.HasKey(e => e.MileageId);

                entity.Property(e => e.MileageId)
                    .HasColumnName("MileageID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DeliveryCarId).HasColumnName("DeliveryCarID");

                entity.Property(e => e.Mileage).HasColumnType("money");

                entity.HasOne(d => d.DeliveryCar)
                    .WithMany(p => p.MileageDetail)
                    .HasForeignKey(d => d.DeliveryCarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MileageDtail_DeliveryCar");
            });

            modelBuilder.Entity<OilDetail>(entity =>
            {
                entity.HasKey(e => e.OilId);

                entity.ToTable("Oil_Detail");

                entity.Property(e => e.OilId)
                    .HasColumnName("oilID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BusinessTax).HasMaxLength(50);

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeOffset).HasColumnType("datetime");

                entity.Property(e => e.GoodTax).HasMaxLength(50);

                entity.Property(e => e.Oilname)
                    .HasColumnName("oilname")
                    .HasMaxLength(50);

                entity.Property(e => e.Oilnumber)
                    .HasColumnName("oilnumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Package)
                    .HasColumnName("package")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(1000);

                entity.Property(e => e.Salesunit)
                    .HasColumnName("salesunit")
                    .HasMaxLength(50);

                entity.Property(e => e.Sellto)
                    .HasColumnName("sellto")
                    .HasMaxLength(50);

                entity.Property(e => e.Tradelocate)
                    .HasColumnName("tradelocate")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdataTime)
                    .HasColumnName("updataTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<OilManger>(entity =>
            {
                entity.ToTable("oil_manger");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarId).HasColumnName("carID");

                entity.Property(e => e.CarNumber)
                    .HasColumnName("Car_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.Card).HasMaxLength(10);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Mileage).HasMaxLength(50);

                entity.Property(e => e.OilId).HasColumnName("oilID");

                entity.Property(e => e.OilQuantity).HasMaxLength(50);

                entity.Property(e => e.Oilname)
                    .HasColumnName("oilname")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.OilManger)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK_oil_manger_DeliveryCar");

                entity.HasOne(d => d.Oil)
                    .WithMany(p => p.OilManger)
                    .HasForeignKey(d => d.OilId)
                    .HasConstraintName("FK_oil_manger_Oil_Detail");
            });

            modelBuilder.Entity<Penalty>(entity =>
            {
                entity.Property(e => e.PenaltyId)
                    .HasColumnName("PenaltyID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LegalBasis).HasMaxLength(50);
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RegionName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Station>(entity =>
            {
                entity.Property(e => e.StationId)
                    .HasColumnName("StationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Company).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.StationName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.HasOne(d => d.RegionNavigation)
                    .WithMany(p => p.Station)
                    .HasForeignKey(d => d.Region)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Station_Region");
            });

            modelBuilder.Entity<Stronghold>(entity =>
            {
                entity.Property(e => e.StrongholdId)
                    .HasColumnName("StrongholdID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShippingRegion).HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.UniformNumber).HasMaxLength(50);

                entity.HasOne(d => d.ContractNavigation)
                    .WithMany(p => p.Stronghold)
                    .HasForeignKey(d => d.Contract)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stronghold_Contract");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Stronghold)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stronghold_Customer");
            });

            modelBuilder.Entity<Supplies>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.Property(e => e.SupplierId)
                    .HasColumnName("SupplierID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.HasOne(d => d.RegionNavigation)
                    .WithMany(p => p.Supplies)
                    .HasForeignKey(d => d.Region)
                    .HasConstraintName("FK_Supplies_Region");
            });

            modelBuilder.Entity<SuppliesDetail>(entity =>
            {
                entity.Property(e => e.SuppliesDetailId)
                    .HasColumnName("SuppliesDetailID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactName).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.HasOne(d => d.ContractNavigation)
                    .WithMany(p => p.SuppliesDetail)
                    .HasForeignKey(d => d.Contract)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SuppliesDetail_Contract");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SuppliesDetail)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SuppliesDetail_Supplies");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.Property(e => e.TicketId)
                    .HasColumnName("TicketID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CasePlace).HasMaxLength(20);

                entity.Property(e => e.DeliveryCarId).HasColumnName("DeliveryCarID");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Filler).HasMaxLength(20);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PenaltyAmount).HasColumnType("money");

                entity.Property(e => e.RaiseUnit).HasMaxLength(20);

                entity.Property(e => e.UnifiedPenaltyId).HasColumnName("UnifiedPenaltyID");

                entity.Property(e => e.ViolationEmployeeId).HasColumnName("ViolationEmployeeID");

                entity.Property(e => e.ViolationFact).HasMaxLength(50);

                entity.Property(e => e.ViolationPlace).HasMaxLength(50);

                entity.Property(e => e.ViolationTime).HasColumnType("datetime");

                entity.HasOne(d => d.DeliveryCar)
                    .WithMany(p => p.Ticket)
                    .HasForeignKey(d => d.DeliveryCarId)
                    .HasConstraintName("FK_Ticket_DeliveryCar");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TicketEmployee)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Ticket_Employee1");

                entity.HasOne(d => d.UnifiedPenalty)
                    .WithMany(p => p.Ticket)
                    .HasForeignKey(d => d.UnifiedPenaltyId)
                    .HasConstraintName("FK_Ticket_UnifiedPenalty");

                entity.HasOne(d => d.ViolationEmployee)
                    .WithMany(p => p.TicketViolationEmployee)
                    .HasForeignKey(d => d.ViolationEmployeeId)
                    .HasConstraintName("FK_Ticket_Employee");
            });

            modelBuilder.Entity<TransferDetail>(entity =>
            {
                entity.HasKey(e => e.TransferId);

                entity.Property(e => e.TransferId)
                    .HasColumnName("TransferID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DeliveryCarId).HasColumnName("DeliveryCarID");

                entity.Property(e => e.StationId).HasColumnName("StationID");

                entity.HasOne(d => d.DeliveryCar)
                    .WithMany(p => p.TransferDetail)
                    .HasForeignKey(d => d.DeliveryCarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransferDetail_DeliveryCar");

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.TransferDetail)
                    .HasForeignKey(d => d.StationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransferDetail_Station");
            });

            modelBuilder.Entity<UnifiedPenalty>(entity =>
            {
                entity.Property(e => e.UnifiedPenaltyId)
                    .HasColumnName("UnifiedPenaltyID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PenaltyId).HasColumnName("PenaltyID");

                entity.Property(e => e.RangeOntime).HasColumnType("money");

                entity.Property(e => e.RangeOverSixtyday).HasColumnType("money");

                entity.Property(e => e.RangeSixtyday).HasColumnType("money");

                entity.Property(e => e.RangeThirtyday).HasColumnType("money");

                entity.Property(e => e.VehicleCategory).HasMaxLength(10);

                entity.Property(e => e.Violation).HasMaxLength(100);

                entity.HasOne(d => d.Penalty)
                    .WithMany(p => p.UnifiedPenalty)
                    .HasForeignKey(d => d.PenaltyId)
                    .HasConstraintName("FK_UnifiedPenalty_Penalty");
            });
        }
    }
}
