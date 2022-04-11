using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privcheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Permission = "Admin|Manager";
            int priv_level = 53;

            if (Permission.Contains("Admin"))
            {
                if (priv_level >55)
                {
                    Console.WriteLine("Welcome, superadmin");
                }
                else
                {
                    Console.WriteLine("Welcome, admin");
                }    
            }
            else if (Permission.Contains("Manager"))
            {
            if (priv_level >=20)
                {
                    Console.WriteLine("Contact any administrator for access");
                }
            else
                {
                    Console.WriteLine("You haven't any access");  
                }
            }
            Console.ReadKey();
        }
    }
}


