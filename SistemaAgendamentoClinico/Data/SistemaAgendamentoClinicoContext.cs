using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaAgendamentoClinico.Models.ViewModels;

namespace SistemaAgendamentoClinico.Data
{
    public class SistemaAgendamentoClinicoContext : DbContext
    {
        public SistemaAgendamentoClinicoContext (DbContextOptions<SistemaAgendamentoClinicoContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaAgendamentoClinico.Models.ViewModels.Department> Department { get; set; }
    }
}
