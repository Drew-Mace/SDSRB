using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SDSRB.Data;
using SDSRB.Pages;

namespace SDSRB
{
    public class IndexModel : PageModel
    {
        private readonly SDSRB.Data.ApplicationDbContext _context;

        public IndexModel(SDSRB.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Character> Character { get;set; }

        public async Task OnGetAsync()
        {
            Character = await _context.Character.ToListAsync();
        }
    }
}
