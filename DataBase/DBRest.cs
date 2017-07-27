namespace DataBase
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    /// <summary>
    /// This class contains static and customer database costructors for initialize database
    /// </summary>
    public class DBRest : DbContext
    {
        static DBRest()
        {
            Database.SetInitializer(new DBRestInitializer());
        }

        public DBRest()
            : base("name=DBRest")
        {
        }

        public virtual DbSet<User> Users { get; set; }
    }
}