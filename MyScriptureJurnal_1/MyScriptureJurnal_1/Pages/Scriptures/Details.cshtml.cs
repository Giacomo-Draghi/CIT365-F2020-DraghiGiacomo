using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJurnal_1.Data;
using MyScriptureJurnal_1.Models;

namespace MyScriptureJurnal_1.Pages.Scriptures
{
    public class DetailsModel : PageModel
    {
        private readonly MyScriptureJurnal_1.Data.MyScriptureJurnal_1Context _context;

        public DetailsModel(MyScriptureJurnal_1.Data.MyScriptureJurnal_1Context context)
        {
            _context = context;
        }

        public Scripture Scripture { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Scripture = await _context.Scripture.FirstOrDefaultAsync(m => m.ID == id);

            if (Scripture == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
