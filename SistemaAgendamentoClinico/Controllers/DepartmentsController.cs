using Microsoft.AspNetCore.Mvc;
using SistemaAgendamentoClinico.Models;
using System.Collections.Generic;

namespace SistemaAgendamentoClinico.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Odontologia" });
            list.Add(new Department { Id = 2, Name = "Oftalmologia" });
            list.Add(new Department { Id = 3, Name = "Acupuntura Sistémica" });
            list.Add(new Department { Id = 4, Name = "Cardiologista" });
            list.Add(new Department { Id = 5, Name = "Vascular" });
            list.Add(new Department { Id = 6, Name = "Urologista" });
            list.Add(new Department { Id = 7, Name = "Ortopedista" });
            list.Add(new Department { Id = 8, Name = "Clinico  Geral" });
            list.Add(new Department { Id = 9, Name = "Deermatologista" });
            list.Add(new Department { Id = 10, Name = "Endocrinologia" });
            list.Add(new Department { Id = 11, Name = "Fisioterapia" });
            list.Add(new Department { Id = 12, Name = "Ginecologista" });
            list.Add(new Department { Id = 13, Name = "Neorologista" });
            list.Add(new Department { Id = 14, Name = "Psiquiatria" });
            list.Add(new Department { Id = 15, Name = "Psicologo" });

            return View(list);
        }
    }
}
