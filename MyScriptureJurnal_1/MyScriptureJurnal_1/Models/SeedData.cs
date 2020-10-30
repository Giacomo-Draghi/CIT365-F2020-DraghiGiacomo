using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJurnal_1.Data;
using MyScriptureJurnal_1.Models;

namespace MyScriptureJournal_1.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJurnal_1Context (
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJurnal_1Context>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "The Book of Mormon",
                        Chapter = "Alma 32:21",
                        Notes = "Verses that talk about faith.",
                        InsertDate = DateTime.Parse("2018-2-12")
                    },

                    new Scripture
                    {
                        Book = "Old Testament",
                        Chapter = "Johsua 1:6",
                        Notes = "The Lord wants us to be strong and to not feear.",
                        InsertDate = DateTime.Parse("2020-6-02")
                    },

                    new Scripture
                    {
                        Book = "New Testament",
                        Chapter = "Romans 13:8",
                        Notes = "We must love one another.",
                        InsertDate = DateTime.Parse("2019-12-25")
                    },

                    new Scripture
                    {
                        Book = "The Book of Mormon",
                        Chapter = "Omni 1:8",
                        Notes = "The importance of the plates and carting on the Word of God.",
                        InsertDate = DateTime.Parse("2020-10-17")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
