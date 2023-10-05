using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Simple_CRUD.Model;

namespace Simple_CRUD.Data
{
    public class Simple_CRUDContext : DbContext
    {
        public Simple_CRUDContext (DbContextOptions<Simple_CRUDContext> options)
            : base(options)
        {
        }

        public DbSet<Simple_CRUD.Model.User> User { get; set; } = default!;
    }
}
