using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Simple_CRUD.Data;
using Simple_CRUD.Model;

namespace Simple_CRUD.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly Simple_CRUD.Data.Simple_CRUDContext _context;

        public IndexModel(Simple_CRUD.Data.Simple_CRUDContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}
