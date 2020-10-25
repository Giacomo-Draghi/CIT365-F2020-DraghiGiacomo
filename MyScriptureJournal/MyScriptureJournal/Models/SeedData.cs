using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "When Harry Met Sally",
                        Chapter = "Romantic Comedy",
                        Notes = "Romantic Comedy",
                        InsertDate = DateTime.Parse("1989-2-12")
                    },

                    new Scripture
                    {
                        Book = "When Harry Met Sally",
                        Chapter = "Romantic Comedy",
                        Notes = "Romantic Comedy",
                        InsertDate = DateTime.Parse("1989-2-12")
                    },

                    new Scripture
                    {
                        Book = "When Harry Met Sally",
                        Chapter = "Romantic Comedy",
                        Notes = "Romantic Comedy",
                        InsertDate = DateTime.Parse("1989-2-12")
                    },

                    new Scripture
                    {
                        Book = "When Harry Met Sally",
                        Chapter = "Romantic Comedy",
                        Notes = "Romantic Comedy",
                        InsertDate = DateTime.Parse("1989-2-12")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
