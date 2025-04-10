using Microsoft.AspNetCore.Mvc;
using PetCare.API.Models;


namespace PetCare.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitasController : ControllerBase
    {
        private static List<Cita> citas = new List<Cita>();

        [HttpGet]
        public ActionResult<IEnumerable<Cita>> GetCitas()
        {
            return Ok(citas);
        }

        [HttpGet("{id}")]
        public ActionResult<Cita> GetCita(int id)
        {
            var cita = citas.FirstOrDefault(c => c.IdCita == id);
            if (cita == null) return NotFound();
            return Ok(cita);
        }

        [HttpPost]
        public ActionResult<Cita> PostCita(Cita cita)
        {
            citas.Add(cita);
            return CreatedAtAction(nameof(GetCita), new { id = cita.IdCita }, cita);
        }

        [HttpPut("{id}")]
        public IActionResult PutCita(int id, Cita cita)
        {
            var existingCita = citas.FirstOrDefault(c => c.IdCita == id);
            if (existingCita == null) return NotFound();

            existingCita.Fecha = cita.Fecha;
            existingCita.Motivo = cita.Motivo;
            existingCita.IdMascota = cita.IdMascota;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCita(int id)
        {
            var cita = citas.FirstOrDefault(c => c.IdCita == id);
            if (cita == null) return NotFound();

            citas.Remove(cita);
            return NoContent();
        }
    }
}
