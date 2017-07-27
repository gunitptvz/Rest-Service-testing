using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataBase
{
    /// <summary>
    /// This class contains databse initialize method with initial data
    /// </summary>
    public class DBRestInitializer : CreateDatabaseIfNotExists<DBRest>
    {
        /// <summary>
        /// This method override virtual method Seed() for initital data adding
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(DBRest context)
        {
            User user1 = new User {NickName = "Sergio", FullName = "Sergey"};
            User user2 = new User {NickName = "Andrew", FullName = "Andrey"};
            User user3 = new User {NickName = "Val", FullName = "Valeriy"};

            context.Users.Add(user1);
            context.Users.Add(user2);
            context.Users.Add(user3);

            context.SaveChanges();
        }
    }
}
