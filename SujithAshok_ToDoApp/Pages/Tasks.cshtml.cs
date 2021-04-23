using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SujithAshok_ToDoApp.Models;

namespace SujithAshok_ToDoApp.Pages
{
    public class TasksModel : PageModel
    {
        private readonly SujithAshok_ToDoApp.Data.DataContext _context;

        public TasksModel(SujithAshok_ToDoApp.Data.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Item TaskItem { get; set; }


        public ICollection<Models.Item> TaskView;

        public void OnGet()
        {
            TaskView = _context.Items.ToList();
        }

        public void OnPost(int? ItemID)
        {
            Models.Item toDoComplete = _context.Items.FirstOrDefault(prod => prod.itemID == ItemID);
            toDoComplete.Done = true;
            _context.Update(toDoComplete);
            _context.SaveChanges();

            TaskView = _context.Items.ToList();

        }

        //public async Task<IActionResult> OnGetAsync(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    TaskItem = await _context.Items.FirstOrDefaultAsync(m => m.itemID == id);

        //    if (TaskItem == null)
        //    {
        //        return NotFound();
        //    }
        //    return Page();
        //}


        //public async Task<IActionResult> OnPostAsync(int? id)
        //{
        //    _context.Attach(Item).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ItemExists(Item.itemID))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }
        //}
    }
}
