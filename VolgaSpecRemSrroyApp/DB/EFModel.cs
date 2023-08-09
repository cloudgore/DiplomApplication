using MySql.Data.EntityFramework;
using System;
using System.Data.Entity;
using System.Linq;
using VolgaSpecRemSrroyApp.DB.Entity;

namespace VolgaSpecRemSrroyApp.DB
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class EFModel : DbContext
    {
        private static EFModel Instains;
        public static EFModel Init()
        {
            if (Instains == null)
                Instains = new EFModel();
            return Instains;
        }
        public EFModel()
            : base($"server={Properties.Settings.Default.Host};port={Properties.Settings.Default.port}" +
                  $";user id={Properties.Settings.Default.UserName}" +
                  $";password={Properties.Settings.Default.pass};database={Properties.Settings.Default.DB}")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserPrioirity> UserPrioirities { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}