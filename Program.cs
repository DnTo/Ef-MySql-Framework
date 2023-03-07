/*
 Install-Package MySql.Data.EntityFramework -Version 8.0.22
Download connector from  https://downloads.mysql.com/archives/c-net/ same version 8.0.22
 */

using Mysql_EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_MySql_F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            Console.WriteLine("Hello MySql!");
          //  Console.WriteLine("Creating Database");
          ////  context.Database.EnsureCreated();
          //  Console.WriteLine("Database Created");
            var model = new Model() { Name = "EF" };
            context.Models.Add(model);
            context.SaveChanges();
            Console.WriteLine($"Name = {model.Name} Id = {model.Id}");

            Console.ReadLine();
        }
    }
}
