using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using DataBase;
using System.Data.Entity;
using Newtonsoft.Json;


namespace Rest_Service
{
    /// <summary>
    /// This class contains methods that implement IContract interface
    /// </summary>
    public class MyService : IContract
    {
        /// <summary>
        /// This method returns Json string with all users information
        /// </summary>
        /// <returns></returns>
        public string GetAll()
        {
            DBRest db = new DBRest();
            var users = db.Users.Select(p => new { p.NickName, p.FullName });
            /*from p in db.Users
                    select p.NickName + " " + p.FullName;*/
            string serialized = JsonConvert.SerializeObject(users);
            return serialized;
        }

        /// <summary>
        /// This method returns Json string with a user information
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public string GetOne(string command)
        {
            DBRest db = new DBRest();
            var users1 = db.Users.Select(p => new { p.NickName, p.FullName }).Where(p => p.NickName == command);
            string serialized1 = JsonConvert.SerializeObject(users1);
            return serialized1;
        }

        /// <summary>
        /// This method returns Json string with add procedure result
        /// </summary>
        /// <param name="command1"></param>
        /// <param name="command2"></param>
        /// <returns></returns>
        public string AddUser(string command1, string command2)
        {
            DBRest db = new DBRest();
            string serialized1, serialized2;

            try
            {
                db.Users.Add(new User { NickName = command1, FullName = command2 });
                db.SaveChanges();
                string answer1 = "Operation successful!";
                serialized1 = JsonConvert.SerializeObject(answer1);
            }
            catch (Exception ex)
            {
                string answer2 = "Operation failed!" + ex.Message;
                serialized2 = JsonConvert.SerializeObject(answer2);
                return serialized2;
            }
            return serialized1;
        }

        /// <summary>
        /// This method returns Json string with delete procedure result
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public string DelUser(string command)
        {
            DBRest db = new DBRest();
            string serialized1, serialized2;
            try
            {
                var deleted = db.Users.Where(p => p.NickName == command).FirstOrDefault();
                db.Users.Remove(deleted);
                db.SaveChanges();
                string answer1 = "Operation successful!";
                serialized1 = JsonConvert.SerializeObject(answer1);
            }
            catch (Exception ex)
            {
                string answer2 = "Operation failed!" + ex.Message;
                serialized2 = JsonConvert.SerializeObject(answer2);
                return serialized2;
            }
            return serialized1;
        }

        /// <summary>
        /// This method returns Json string with update procedure result
        /// </summary>
        /// <param name="command1"></param>
        /// <param name="command2"></param>
        /// <param name="command3"></param>
        /// <returns></returns>
        public string PutUser(string command1, string command2, string command3)
        {
            DBRest db = new DBRest();
            string serialized1, serialized2;
            try
            {
                var deleted = db.Users.Where(p => p.NickName == command1).FirstOrDefault();
                db.Users.Remove(deleted);
                db.Users.Add(new User { NickName = command2, FullName = command3 });
                db.SaveChanges();
                string answer1 = "Operation successful!";
                serialized1 = JsonConvert.SerializeObject(answer1);
            }
            catch (Exception ex)
            {
                string answer2 = "Operation failed!" + ex.Message;
                serialized2 = JsonConvert.SerializeObject(answer2);
                return serialized2;
            }
            return serialized1;
        }
    }
}
