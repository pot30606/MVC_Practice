using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;

namespace MVC_Practice
{
    public class DetailsModel : PageModel
    {
        private readonly JournalDbContext _context;

        public DetailsModel(JournalDbContext context)
        {
            _context = context;
        }

        public DailyRecord DailyRecord { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DailyRecord = await _context.Records.FirstOrDefaultAsync(m => m.Id == id);

            if (DailyRecord == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
