using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Required(ErrorMessage = "O titulo do filme é Obrigatório")]
    [StringLength(100)]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O Genero do filme é Obrigatório")]
    [MaxLength(50, ErrorMessage = "O tamanho do Genero não pode passar de 50")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A Duração do filme é Obrigatório")]
    [Range(70, 600, ErrorMessage = "A duração só pode ser entre 70 - 600 min")]
    public int Duracao { get; set; }
}
