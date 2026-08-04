using DownloadFile.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace DownloadFile.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context=new DownloadFileContext(
                serviceProvider.GetRequiredService<DbContextOptions<DownloadFileContext>>()))
            {
                if(context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "horry potter",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Gnere="Horrer",
                        price=7.99M,
                    },
                    new Movie
                    {
                        Title = "Bahubali the begining",
                        ReleaseDate = DateTime.Parse("2017-06-16"),
                        Gnere = "Action",
                        price = 10M,
                    },
                    new Movie
                    {
                        Title = "pizza",
                        ReleaseDate = DateTime.Parse("2022-2-12"),
                        Gnere = "Horrer",
                        price = 5M,
                    },
                    new Movie
                    {
                        Title = "Legend",
                        ReleaseDate = DateTime.Parse("2015-05-01"),
                        Gnere = "Action",
                        price = 7.99M,
                    }
                    );
                context.SaveChanges();
                
            }
        }
    }
}
