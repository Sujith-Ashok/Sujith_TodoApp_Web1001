using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SujithAshok_ToDoApp.Data;
using SujithAshok_ToDoApp.Models;

namespace SujithAshok_ToDoApp.Pages.Items
{
    public class IndexModel : PageModel
    {
        private readonly SujithAshok_ToDoApp.Data.DataContext _context;

        public IndexModel(SujithAshok_ToDoApp.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }

        public async Task OnGetAsync()
        {
            Item = await _context.Items.ToListAsync();
        }
    }
}
