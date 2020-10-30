using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJurnal_1.Data;
using MyScriptureJurnal_1.Models;

namespace MyScriptureJurnal_1.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJurnal_1.Data.MyScriptureJurnal_1Context _context;

        public IndexModel(MyScriptureJurnal_1.Data.MyScriptureJurnal_1Context context)
        {
            _context = context;
        }

        public IList<Scripture> Scriptures { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Book { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ScriptureBook { get; set; }

        public string BookSort { get; set; }
        public string DateSort { get; set; }

        public IList<Scripture> Scripture { get;set; }

        public async Task OnGetAsync(string sortOrder)
        {
            
            IQueryable<string> bookQuery = from m in _context.Scripture
                                            orderby m.Book
                                            select m.Book;

            //Scripture = await _context.Scripture.ToListAsync();
            var scripture = from m in _context.Scripture
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                scripture = scripture.Where(s => s.Notes.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(ScriptureBook))
            {
                scripture = scripture.Where(x => x.Book == ScriptureBook);
            }
            Book = new SelectList(await bookQuery.Distinct().ToListAsync());
            Scripture = await scripture.AsNoTracking().ToListAsync();

            BookSort = String.IsNullOrEmpty(sortOrder) ? "Book" : "";
            DateSort = sortOrder == "Date" ? "InsertDate" : "Date";
            IQueryable<Scripture> scripturesIQ = from s in _context.Scripture
                                                 select s;
            switch (sortOrder)
            {
                case "Book":
                    scripturesIQ = scripturesIQ.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    scripturesIQ = scripturesIQ.OrderBy(s => s.InsertDate);
                    break;
                case "InsertDate":
                    scripturesIQ = scripturesIQ.OrderByDescending(s => s.InsertDate);
                    break;
                default:
                    scripturesIQ = scripturesIQ.OrderBy(s => s.InsertDate);
                    break;
            }

            Scripture = await scripturesIQ.AsNoTracking().ToListAsync();

        }
    }
}
