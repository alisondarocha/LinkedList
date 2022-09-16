using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LinkedList_Web.Models;

namespace LinkedList_Web.Pages_Text
{
    public class CreateModel : PageModel
    {
        private readonly LinkedList_WebContext _context;

        public CreateModel(LinkedList_WebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Text Text { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }
            
            _context.Text.Add(Text);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
