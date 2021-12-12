using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Calus_Mario_lab8.Data;
using Calus_Mario_lab8.Models;

namespace Calus_Mario_lab8.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Calus_Mario_lab8.Data.Calus_Mario_lab8Context _context;

        public IndexModel(Calus_Mario_lab8.Data.Calus_Mario_lab8Context context)
        {
            _context = context;
        }

        public IList<BookCategory> BookCategory { get;set; }

        public async Task OnGetAsync()
        {
            BookCategory = await _context.BookCategory
                .Include(b => b.Book)
                .Include(b => b.Category).ToListAsync();
        }
    }
}
