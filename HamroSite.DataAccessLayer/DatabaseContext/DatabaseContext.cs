using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamroSite.DataAccessLayer
{
    public partial class DB : DbContext
    {
        public DB()
            : base("WebsiteConnection")
        {
            var objAdapter = (IObjectContextAdapter)this;
            var objContext = objAdapter.ObjectContext;
            objContext.CommandTimeout = 16 * 60; //Values in seconds

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            InitializeType(modelBuilder);
            base.OnModelCreating(modelBuilder);
            SqlProviderServices.TruncateDecimalsToScale = false;

            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));

        }

        private void InitializeType(DbModelBuilder modelBuilder)
        {
        }
        public DbSet<StudentReg> StudentReg { get; set; }
    }
}
