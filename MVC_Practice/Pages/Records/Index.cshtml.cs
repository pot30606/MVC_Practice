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
    public class IndexModel : PageModel
    {
        private readonly JournalDbContext _context;

        public IndexModel(JournalDbContext context)
        {
            _context = context;
        }

        public IList<DailyRecord> DailyRecord { get;set; }

        public async Task OnGetAsync()
        {
            DailyRecord = await _context.Records.ToListAsync();
        }
    }
}
