using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SujithAshok_ToDoApp.Data;
using SujithAshok_ToDoApp.Models;

namespace SujithAshok_ToDoApp.Pages.Todo
{
    public class DetailsModel : PageModel
    {
        private readonly SujithAshok_ToDoApp.Data.DataContext _context;

        public DetailsModel(SujithAshok_ToDoApp.Data.DataContext context)
        {
            _context = context;
        }

        public Item Item { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Item = await _context.Items.FirstOrDefaultAsync(m => m.itemID == id);

            if (Item == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
