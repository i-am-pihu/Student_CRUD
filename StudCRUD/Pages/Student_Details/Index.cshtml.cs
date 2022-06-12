using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudCRUD.Data;
using StudCRUD.Model;

namespace StudCRUD.Pages.Student_Details
{
    public class IndexModel : PageModel
    {
        private readonly StudCRUD.Data.StudCRUDContext _context;

        public IndexModel(StudCRUD.Data.StudCRUDContext context)
        {
            _context = context;
        }

        public IList<Students> Students { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Students != null)
            {
                Students = await _context.Students.ToListAsync();
            }
        }
    }
}
