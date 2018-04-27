namespace Billing.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MainContext : DbContext
    {
        public MainContext() : base("name=MainContext") { }
        public virtual DbSet<FILE_MANAGER> FILE_MANAGER { get; set; }
        public virtual DbSet<BGCUOC> BGCUOC { get; set; }
        //public virtual DbSet<DISCOUNT> DISCOUNT { get; set; }
        //public virtual DbSet<BKN_GOICUOC_THANG> BKN_GOICUOC_THANG { get; set; }
        //public virtual DbSet<MYTV> MYTV { get; set; }
        //public virtual DbSet<NET> NET { get; set; }
        //public virtual DbSet<HD_MYTV> HD_MYTV { get; set; }
        //public virtual DbSet<HD_NET> HD_NET { get; set; }
        //public virtual DbSet<DANHBA_GOICUOC_TICHHOP> DANHBA_GOICUOC_TICHHOP { get; set; }
        //public virtual DbSet<DATCOC> DATCOC { get; set; }
        //public virtual DbSet<DICHVU_VT_BKN> DICHVU_VT_BKN { get; set; }
        //public virtual DbSet<EXPORT_TABLE> EXPORT_TABLE { get; set; }
        //public virtual DbSet<GDSIMPORT> GDSIMPORT { get; set; }
        //public virtual DbSet<HD_MERGIN> HD_MERGIN { get; set; }
        //public virtual DbSet<MEGA> MEGA { get; set; }
        //public virtual DbSet<THANHTOANTRUOC> THANHTOANTRUOC { get; set; }
        //public virtual DbSet<DICHVU_VT_BKN> DICHVU_VT_BKN { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder) { }
    }
    public abstract class RepositoryBase<T> where T : class
    {
        DbSet _dbSet;
        DbContext _context;
        public void Update(T entity, params System.Linq.Expressions.Expression<Func<T, object>>[] properties)
        {
            _dbSet.Attach(entity);
            System.Data.Entity.Infrastructure.DbEntityEntry<T> entry = _context.Entry(entity);
            foreach (var selector in properties)
                entry.Property(selector).IsModified = true;
        }
    }
}
