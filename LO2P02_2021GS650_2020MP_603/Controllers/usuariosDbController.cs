using LO2P02_2021GS650_2020MP_603.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LO2P02_2021GS650_2020MP_603.Controllers
{
    public class usuariosDbController : Controller
    {
        private readonly usuariosDbContext usuariosDbContext;

        public usuariosDbController(usuariosDbContext equiposDbContexto)
        {
            usuariosDbContext = equiposDbContexto;
        }
        public IActionResult Index()
        {
            var listadoMarcas = (from m in usuariosDbContext.clientes
                                 select m).ToList();
            ViewData["listadoMarcas"] = new SelectList(listadoMarcas, "id", "nombre");

            var listadoEquipos = (from e in usuariosDbContext.clientes
                                  join m in usuariosDbContext.puestos on c.id equals p.id
            select new
                                  {
                                  
                       
                                  }
                                ).ToList();
            ViewData["listadoEquipo"] = listadoEquipos;
            return View();
        }
        public IActionResult CrearEquipos(clientes nuevoEquipos)
        {
            usuariosDbContext.Add(nuevoEquipos);
            usuariosDbContext.SaveChanges();
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Delete(int? id)
        {
            var equipos = await usuariosDbContext.clientes.FindAsync(id);
            if (equipos != null)
            {
                usuariosDbContext.clientes.Remove(equipos);
            }

            await usuariosDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
