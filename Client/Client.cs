using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Contract;
using DataBase;

namespace Client
{
    /// <summary>
    /// This class contains Client execution methods
    /// </summary>
    class Client
    {
        static void Main(string[] args)
        {
            /*Console.Title = "Client";
            RestClientMethods call = new RestClientMethods();

            Label:
            Console.WriteLine("Enter a command:");
            string x = Console.ReadLine();

            // Return list of users GET/Services/TestService/Users
            if (x.Contains("GET/Services/TestService/Users") && x.Length == 30)
            {
                call.GETALLUSERS();
                Console.WriteLine();
                goto Label;
            }
            // Get information about a user GET/Services/TestService/Users/{NickName}
            else if (x.Contains("GET/Services/TestService/Users/") && x.Length > 31)
            {
                string result = x.Substring(31);
                call.GETONEUSER(result);
                Console.WriteLine();
                goto Label;
            }
            // Add user POST/Services/TestService/Users/{NickName}/{FullName}
            else if (x.Contains("POST/Services/TestService/Users/") && x.Length > 31)
            {
                string result = x.Substring(31);
                string[] array = result.Split('/');
                string result1 = array[1];
                string result2 = array[2];
                call.ADDUSER(result1, result2);
                Console.WriteLine();
                goto Label;
            }
            // Delete user DELETE/Services/TestService/Users/{NickName}
            else if (x.Contains("DELETE/Services/TestService/Users/") && x.Length > 34)
            {
                string result = x.Substring(34);
                call.DELETEUSER(result);
                Console.WriteLine();
                goto Label;
            }
            // Update user PUT/Services/TestService/Users/{NickName(updated)}/{NickName(new)}/{FullName{new}}
            else if (x.Contains("PUT/Services/TestService/Users/") && x.Length > 31)
            {
                string result = x.Substring(31);
                string[] array = result.Split('/');
                string result1 = array[0];
                string result2 = array[1];
                string result3 = array[2];
                call.UPDATEUSER(result1, result2, result3);
                Console.WriteLine();
                goto Label;
            }
            else
            {
                Console.WriteLine("Invalid command! Try again.");
                Console.WriteLine();
                goto Label;
            } */
        }
    }
}
