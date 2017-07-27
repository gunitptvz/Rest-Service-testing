using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataBase
{
    /// <summary>
    /// This class contains User entity with properties
    /// </summary>
    public class User
    {
        [Key]
        public string NickName { get; set; }
        public string FullName { get; set; }
    }
}
