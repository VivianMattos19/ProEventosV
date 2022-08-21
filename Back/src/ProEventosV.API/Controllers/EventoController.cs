﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventosV.API.Models;
using Microsoft.EntityFrameworkCore;
using ProEventosV.API.Data;

namespace ProEventosV.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;


        public EventoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _context.Eventos.Where(evento => evento.EventoId == id);

        }

        [HttpPost]
        public string Post ()
        {
            return "Exemplo de Post";
        }

        [HttpPut]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete]
        public string Delete (int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}