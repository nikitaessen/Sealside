using Sealside.Models;
using Sealside.Models.Database;
using System.Linq;

namespace Sealside.Crosscutting
{
    public static class SampleData
    {
        public static void Initialize(UserDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            context.Users.Add(new User { Name = "Nikita", Email = "nikitaessen@gmail.com" });
            context.Users.Add(new User { Name = "Sonya", Email = "lis.sofika@mail.ru" });

            context.SaveChanges();
        }
    }
}
