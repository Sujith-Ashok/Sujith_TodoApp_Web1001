using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
    }
}
