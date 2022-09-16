using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LinkedList_Web.Models;
using LinkedList_Web.Pages.TextCRUD;


namespace LinkedList_Web.Pages_Text
{
    public class DeleteModel : PageModel
    {
        private readonly LinkedList_WebContext _context;

        public DeleteModel(LinkedList_WebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Text TextRemove { get; set; }
        public IList<Text> Text { get; set; } = default;
        public ListForm Lista { get; set; } = new ListForm();
        
        public async Task OnPostAsync(int? id)
        {
            var text = await _context.Text.FirstOrDefaultAsync(m => m.Elementos == id);

            if (text != null)
            {
                Text.ToList().ForEach(text => Lista.AddValue(text.Elementos));
                Lista.RemoveElement(id);
                TextRemove = text;
                _context.Text.Remove(TextRemove);
                await _context.SaveChangesAsync();
            }
        }
    }
}
