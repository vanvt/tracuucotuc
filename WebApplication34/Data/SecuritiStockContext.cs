using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication34.Data
{
    public partial class SecuritiStockContext : DbContext
    {
        public SecuritiStockContext()
        {
        }

        public SecuritiStockContext(DbContextOptions<SecuritiStockContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BankAccount> BankAccount { get; set; }
        public virtual DbSet<ChangeHistory> ChangeHistory { get; set; }
        public virtual DbSet<OriginalListing> OriginalListing { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;user=sa;password=123456;database=SecuritiStock");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<BankAccount>(entity =>
            {
                entity.ToTable("bank_account");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_bank_account")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bank)
                    .HasColumnName("bank")
                    .HasMaxLength(500);

                entity.Property(e => e.Beneficiaries)
                    .HasColumnName("beneficiaries")
                    .HasMaxLength(500);

                entity.Property(e => e.CmndNumber)
                    .IsRequired()
                    .HasColumnName("cmnd_number")
                    .HasMaxLength(50);

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50);

                entity.Property(e => e.NumberAccount)
                    .HasColumnName("number_account")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateBy)
                    .HasColumnName("update_by")
                    .HasMaxLength(50);

                entity.Property(e => e.Updated)
                    .HasColumnName("updated")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ChangeHistory>(entity =>
            {
                entity.ToTable("change_history");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CmndNumber)
                    .HasColumnName("cmnd_number")
                    .HasMaxLength(50);

                entity.Property(e => e.Content).HasMaxLength(1000);

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<OriginalListing>(entity =>
            {
                entity.ToTable("original_listing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(500);

                entity.Property(e => e.AssignmentOrganization)
                    .HasColumnName("assignment_organization")
                    .HasMaxLength(50);

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.CmndIssueDay)
                    .HasColumnName("cmnd_issue_day")
                    .HasMaxLength(100);

                entity.Property(e => e.CmndNumber)
                    .HasColumnName("cmnd_number")
                    .HasMaxLength(50);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(100);

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50);

                entity.Property(e => e.DividendDeposited)
                    .HasColumnName("dividend_deposited")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DividendNotDeposite)
                    .HasColumnName("dividend_not_deposite")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DividendReceivedDeposited)
                    .HasColumnName("dividend_received_deposited")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DividendReceivedNotDeposite)
                    .HasColumnName("dividend_received_not_deposite")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DividendReceivedTotal)
                    .HasColumnName("dividend_received_total")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DividendTotal)
                    .HasColumnName("dividend_total")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(500);

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasMaxLength(500);

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text");

                entity.Property(e => e.NumberStockDeposited)
                    .HasColumnName("number_stock_deposited")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NumberStockNotDeposite)
                    .HasColumnName("number_stock_not_deposite")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NumberStockTotal)
                    .HasColumnName("number_stock_total")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50);

                entity.Property(e => e.TaxDeposited)
                    .HasColumnName("tax_deposited")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TaxNotDeposite)
                    .HasColumnName("tax_not_deposite")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TaxTotal)
                    .HasColumnName("tax_total")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tesss)
                    .HasColumnName("tesss")
                    .HasMaxLength(10);

                entity.Property(e => e.Txnum)
                    .HasColumnName("txnum")
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateBy)
                    .HasColumnName("update_by")
                    .HasMaxLength(50);

                entity.Property(e => e.Updated)
                    .HasColumnName("updated")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("transaction");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BankAccountId).HasColumnName("bank_account_id");

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Cnmd)
                    .HasColumnName("cnmd")
                    .HasMaxLength(50);

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasMaxLength(50);

                entity.Property(e => e.IsPaid).HasColumnName("is_paid");

                entity.Property(e => e.OriginalId).HasColumnName("original_id");

                entity.Property(e => e.PaidDate)
                    .HasColumnName("paid_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RealRecevieMoney)
                    .HasColumnName("real_recevie_money")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReceiveMoney)
                    .HasColumnName("receive_money")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tax)
                    .HasColumnName("tax")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(10);

                entity.Property(e => e.Year).HasColumnName("year");

                entity.HasOne(d => d.BankAccount)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.BankAccountId)
                    .HasConstraintName("FK_transaction_bank_account");

                entity.HasOne(d => d.Original)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.OriginalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_transaction_original_listing");
            });
        }
    }
}
