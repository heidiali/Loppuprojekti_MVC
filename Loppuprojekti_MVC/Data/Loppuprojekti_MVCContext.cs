using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Loppuprojekti_MVC.Models
{
    public class Loppuprojekti_MVCContext : DbContext
    {
        public Loppuprojekti_MVCContext (DbContextOptions<Loppuprojekti_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Loppuprojekti_MVC.Models.Species> Species { get; set; }
    }
}
