namespace Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyDaoTaoDbContext : DbContext
    {
        public QuanLyDaoTaoDbContext()
            : base("name=QuanLyDaoTaoDbContext")
        {
        }

        public virtual DbSet<CHUONG_TRINH_DAO_TAO> CHUONG_TRINH_DAO_TAO { get; set; }
        public virtual DbSet<CHUONG_TRINH_DAO_TAO_CHI_TIET> CHUONG_TRINH_DAO_TAO_CHI_TIET { get; set; }
        public virtual DbSet<DM_CHUC_DANH> DM_CHUC_DANH { get; set; }
        public virtual DbSet<DM_CHUC_VU> DM_CHUC_VU { get; set; }
        public virtual DbSet<DM_DON_VI> DM_DON_VI { get; set; }
        public virtual DbSet<DM_GIO_CHUAN_CHUC_DANH> DM_GIO_CHUAN_CHUC_DANH { get; set; }
        public virtual DbSet<DM_GIO_CHUAN_CHUC_VU> DM_GIO_CHUAN_CHUC_VU { get; set; }
        public virtual DbSet<DM_HE_DAO_TAO> DM_HE_DAO_TAO { get; set; }
        public virtual DbSet<DM_MON_HOC> DM_MON_HOC { get; set; }
        public virtual DbSet<DM_NGANH> DM_NGANH { get; set; }
        public virtual DbSet<GIANG_VIEN> GIANG_VIEN { get; set; }
        public virtual DbSet<GV_CHUC_DANH> GV_CHUC_DANH { get; set; }
        public virtual DbSet<GV_CHUC_VU> GV_CHUC_VU { get; set; }
        public virtual DbSet<GV_DON_VI> GV_DON_VI { get; set; }
        public virtual DbSet<GV_GIANG_DAY> GV_GIANG_DAY { get; set; }
        public virtual DbSet<HOC_KY> HOC_KY { get; set; }
        public virtual DbSet<KHOA_HOC> KHOA_HOC { get; set; }
        public virtual DbSet<LOP_CHUYEN_NGANH> LOP_CHUYEN_NGANH { get; set; }
        public virtual DbSet<LOP_HOC_PHAN> LOP_HOC_PHAN { get; set; }
        public virtual DbSet<LOP_HOC_PHAN_CHI_TIET> LOP_HOC_PHAN_CHI_TIET { get; set; }
        public virtual DbSet<MH_TIEN_QUYET> MH_TIEN_QUYET { get; set; }
        public virtual DbSet<NIEN_KHOA> NIEN_KHOA { get; set; }
        public virtual DbSet<PHAN_CONG_GIANG_DAY> PHAN_CONG_GIANG_DAY { get; set; }
        public virtual DbSet<PHAN_CONG_GIANG_DAY_CHI_TIET> PHAN_CONG_GIANG_DAY_CHI_TIET { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<webpages_Membership> webpages_Membership { get; set; }
        public virtual DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public virtual DbSet<webpages_Roles> webpages_Roles { get; set; }
        public virtual DbSet<KHOA_HOC_NIEN_KHOA> KHOA_HOC_NIEN_KHOA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DM_DON_VI>()
                .HasMany(e => e.DM_DON_VI1)
                .WithOptional(e => e.DM_DON_VI2)
                .HasForeignKey(e => e.DV_CHA_ID);

            modelBuilder.Entity<DM_GIO_CHUAN_CHUC_DANH>()
                .Property(e => e.GCCD_SO_GIO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DM_GIO_CHUAN_CHUC_VU>()
                .Property(e => e.GCCV_PHAN_TRAM)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DM_MON_HOC>()
                .HasMany(e => e.MH_TIEN_QUYET)
                .WithOptional(e => e.DM_MON_HOC)
                .HasForeignKey(e => e.MH_ID);

            modelBuilder.Entity<DM_MON_HOC>()
                .HasMany(e => e.MH_TIEN_QUYET1)
                .WithOptional(e => e.DM_MON_HOC1)
                .HasForeignKey(e => e.MHTQ_ID);

            modelBuilder.Entity<GIANG_VIEN>()
                .Property(e => e.GV_SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NIEN_KHOA>()
                .HasMany(e => e.CHUONG_TRINH_DAO_TAO)
                .WithOptional(e => e.NIEN_KHOA)
                .HasForeignKey(e => e.DT_NIEN_KHOA_BAT_DAU);

            modelBuilder.Entity<NIEN_KHOA>()
                .HasMany(e => e.CHUONG_TRINH_DAO_TAO1)
                .WithOptional(e => e.NIEN_KHOA1)
                .HasForeignKey(e => e.DT_NIEN_KHOA_KET_THUC);

            modelBuilder.Entity<webpages_Roles>()
                .HasMany(e => e.UserProfiles)
                .WithMany(e => e.webpages_Roles)
                .Map(m => m.ToTable("webpages_UsersInRoles").MapLeftKey("RoleId").MapRightKey("UserId"));
        }
    }
}
