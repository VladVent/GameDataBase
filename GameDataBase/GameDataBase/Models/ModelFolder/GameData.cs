using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace GameDataBase.Models.ModelFolder
{
    public class GameData
    {
        public static void GameDa(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if(!context.Database.Any())
            {
                context.Database.AddRange(
                    new Game
                    {
                        Name = "Silent Hill",
                        Descriprion = "Перша частина гри",
                        Developer = "Team Silent",
                        Publisher = "Konami",
                        Rating = 78,
                        Category = "Horror"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
