using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LinkedList_Web.Models;

namespace LinkedList_Web.Pages_Text
{
    public class EditModel : PageModel
    {
        private readonly LinkedList_WebContext _context;

        public EditModel(LinkedList_WebContext context)
        {
            _context = context;
        }

        public IList<Text> Text { get; set; } = default!;
        public ListForm Lista { get; set; } = new ListForm();

        public async Task OnGetAsync()
        {
            if (_context.Text != null)
            {
                Text = await _context.Text.ToListAsync();
                Text.ToList().ForEach(text => Lista.AddValue(text.Elementos));
                Lista.InvertList();
            }
        }
    }
}
