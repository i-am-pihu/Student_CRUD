using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudCRUD.Model;

namespace StudCRUD.Data
{
    public class StudCRUDContext : DbContext
    {
        public StudCRUDContext (DbContextOptions<StudCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<StudCRUD.Model.Students>? Students { get; set; }
    }
}
