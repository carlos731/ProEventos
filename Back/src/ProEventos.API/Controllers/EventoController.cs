using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    private readonly DataContext context;
    public EventoController(DataContext context)
    {
        this.context = context;
    }

    // [HttpGet(Name = "GetWeatherForecast")]
    [HttpGet]
    public IEnumerable<Evento>? Get()
    {
        return context.Eventos;
    }

    // [HttpGet("{id}")]
    // public IEnumerable<Evento> GetById(int id) 
    // {
    //     return context.Eventos.Where(evento => evento.EventoId == id);
    // }

    [HttpGet("{id}")]
    public Evento? GetById(int id) 
    {
        return context.Eventos?.FirstOrDefault(evento => evento.EventoId == id);
    }

    [HttpPost]
    public string Post()
    {
        return "Exemplo de Post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo de Put com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Exemplo de Delete com id = {id}";
    }
}
