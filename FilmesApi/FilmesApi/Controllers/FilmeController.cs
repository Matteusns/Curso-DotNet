﻿using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController
{
    private static List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public void AdicionarFilme([FromBody]Filme filme)
    {
        
        filmes.Add(filme);
        Console.WriteLine(filme.Titulo);
        Console.WriteLine(filme.Genero);
        Console.WriteLine(filme.Duracao);  
    }

}
