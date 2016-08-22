namespace WebForEver.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity;

    internal sealed class Configuration : DbMigrationsConfiguration<WebForEver.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "WebForEver.Models.ApplicationDbContext";
        }

      
          protected override void Seed(WebForEver.Models.ApplicationDbContext context)
        {
            if (!context.Users.Any(u => u.UserName == "eyas"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manger = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "eyas" };

                manger.Create(user, "eyashomsi");
            }
        }
    }
  }

