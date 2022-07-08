using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WorkingWithDB.DBContexts;
using WorkingWithDB.Configs;
using WorkingWithDB.Models;

namespace WorkingWithDB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var connConfig = new ConnectionConfig();
            string? connectionString = connConfig.Build().GetConnectionString("DefaultConnection");

            if (connectionString != null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
                var options = optionsBuilder.UseSqlServer(connectionString).Options;

                using (var dbContext = new ApplicationContext(options))
                {
                    var users = dbContext.Users.ToList();

                    foreach (var user in users)
                    {
                        Console.WriteLine(user);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}