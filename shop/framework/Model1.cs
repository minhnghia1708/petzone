using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace shop.framework
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
