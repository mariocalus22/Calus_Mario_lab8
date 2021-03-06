using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Calus_Mario_lab8.Data;
using Calus_Mario_lab8.Models;

namespace Calus_Mario_lab8.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Calus_Mario_lab8.Data.Calus_Mario_lab8Context _context;

        public DetailsModel(Calus_Mario_lab8.Data.Calus_Mario_lab8Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);

            if (Publisher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
