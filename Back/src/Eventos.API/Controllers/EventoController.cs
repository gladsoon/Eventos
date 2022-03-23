﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventos.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Eventos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController(){

        }
        [HttpGet]
        public IEnumerable<Evento> Get(){
            return _evento;
        }
        
        public IEnumerable<Evento>  _evento = new Evento[]{
            new Evento(){
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "BH",
                QtdePessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImageURL = "foto.png"
            },
            new Evento(){
                EventoId = 2,
                Tema = "Angular 11 e Java",
                Local = "BH",
                QtdePessoas = 350,
                DataEvento = DateTime.Now.AddDays(12).ToString(),
                ImageURL = "foto.png"
            }
        } ;                
    }
}
