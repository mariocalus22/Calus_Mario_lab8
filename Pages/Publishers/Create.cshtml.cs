﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Calus_Mario_lab8.Data;
using Calus_Mario_lab8.Models;

namespace Calus_Mario_lab8.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Calus_Mario_lab8.Data.Calus_Mario_lab8Context _context;

        public CreateModel(Calus_Mario_lab8.Data.Calus_Mario_lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
