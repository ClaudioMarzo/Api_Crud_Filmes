using System.ComponentModel.DataAnnotations;

namespace FilmeApi.Data.Dtos;

public class ReadFilmeDto
{
   // data annotations [Required] [MaxLength]
    public String? Titulo {get; set; }
    public String? Genero { get; set; }
    public int Duracao { get; set; }
    public DateTime HoraDaConsult {get; set;} = DateTime.Now;

}