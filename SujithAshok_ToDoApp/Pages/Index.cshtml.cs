using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SujithAshok_ToDoApp.Data;

namespace SujithAshok_ToDoApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly DataContext _context;

        public IndexModel(ILogger<IndexModel> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        public DateTime example { get; set; }


        [BindProperty]
        public Models.Item IndexItem { get; set; }

      

        public ICollection<Models.Item> Completed;
        public ICollection<Models.Item> Pending;

        public void OnGet()
        {
            DateTime getDate = DateTime.Now;
            DateTime TodayDate = getDate.Date;
            DateTime TomorrowDate = TodayDate.AddDays(1);

            Completed = _context.Items.Where(prod => prod.DoneDate == TodayDate).ToList();

            Pending = _context.Items.Where(prod => prod.DueDate == TomorrowDate).ToList();
        }
    }
}
