using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WinFormsApp1.classes
{
    public class context : DbContext
    {
        public DbSet<application> application { get; set; }
        public DbSet<client> clients { get; set; }
        public DbSet<equipment> equipment { get; set; }
        public DbSet<kart> karts { get; set; }
        public DbSet<worker> workers { get; set; }
        public DbSet<kartingcenter> kartingcenters { get; set; }
        public context() : base()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=kartingcenter;User Id=postgres;Password=123;");
        }

        internal object FromSqlRaw(string v, string w)
        {
            throw new NotImplementedException();
        }
    }
}
