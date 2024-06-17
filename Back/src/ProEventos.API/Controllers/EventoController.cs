using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;


namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){          
                    EventoId= 1,
                    Tema = "Angular",
                    Local = "São Paulo",
                    Lote = "1° Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
                    ImageUrl = "Foto.png"
                    },
                     new Evento(){          
                    EventoId= 2,
                    Tema = "Angular Novidades",
                    Local = "Rio de janeiro",
                    Lote = "2° Lote",
                    QtdPessoas = 150,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/mm/yyyy"),
                    ImageUrl = "Foto2.png"
                    }
            };
        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo post";
        }

        [HttpPut("{id}")]
            public string Put(int id)
            {
                return $"exemplo put com id = {id}";
            }

        [HttpDelete("{id}")]
            public string Delete(int id)
            {
                return $"exemplo Delete = {id}";
            }
    }
}
