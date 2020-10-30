using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyScriptureJurnal_1.Models;

namespace MyScriptureJurnal_1.Data
{
    public class MyScriptureJurnal_1Context : DbContext
    {
        public MyScriptureJurnal_1Context (DbContextOptions<MyScriptureJurnal_1Context> options)
            : base(options)
        {
        }

        public DbSet<MyScriptureJurnal_1.Models.Scripture> Scripture { get; set; }
    }
}
