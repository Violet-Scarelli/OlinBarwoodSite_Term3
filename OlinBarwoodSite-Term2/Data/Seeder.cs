using Microsoft.AspNetCore.Identity;
using OlinBarwoodSite_Term3.Models;

namespace OlinBarwoodSite_Term3.Data
{
    public class Seeder
    {
        public static void Seed(AppDbContext context, IServiceProvider provider)
        {
            if (!context.Messages.Any())  // this is to prevent adding duplicate data
            {
                var userManager = provider.GetRequiredService<UserManager<User>>();
                var roleManager = provider.GetRequiredService<RoleManager<IdentityRole>>();

                const string ROLE = "Admin";
                const string SECRET_PASSWORD = "1234";
                bool isSuccess = true;
                if (roleManager.FindByNameAsync(ROLE).Result == null)
                {
                    isSuccess = roleManager.CreateAsync(new IdentityRole(ROLE)).Result.Succeeded;
                }

                var user1 = new User { Name = "John Doe", UserName = "John" };
                var user2 = new User { Name = "Jane Doe", UserName = "Jane" };

                isSuccess &= userManager.CreateAsync(user1, SECRET_PASSWORD).Result.Succeeded;
                if (isSuccess)
                {
                    isSuccess &= userManager.AddToRoleAsync(user1, ROLE).Result.Succeeded;
                }

                isSuccess &= userManager.CreateAsync(user2, SECRET_PASSWORD).Result.Succeeded;

                if (isSuccess)
                {
                    var message1 = new Message
                    {
                        Sender = user1,
                        Recipient = user2,
                        Subject = "Test message",
                        MsgBody = "This is a test message",
                        SendDate = DateTime.Now
                    };
                    context.Messages.Add(message1);

                    var message2 = new Message
                    {
                        Sender = user2,
                        Recipient = user1,
                        Subject = "Re: test message",
                        MsgBody = "Thanks for the test message",
                        SendDate = DateTime.Now
                    };
                    context.Messages.Add(message2);

                    context.SaveChanges();
                }
            }
        }
    }
}