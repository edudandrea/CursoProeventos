using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PROEVENTOS.API.Data;
using PROEVENTOS.API.Models;

namespace PROEVENTOS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        
        private readonly DataContext _context;
            
            
        public EventosController(DataContext context)
        {
            _context = context;
           
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
                        
        }
        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoID == id );
                        
        }
        
        [HttpPost]
        public string Post()
        {
            return "Exempo de POST";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exempo de PUT com id = {id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exempo de PUT com id = {id}";
        }




       
    }
}
