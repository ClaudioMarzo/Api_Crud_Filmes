using System.ComponentModel.DataAnnotations;

namespace FilmeApi.Data.Dtos;

public class UpdateFilmeDto
{
   // data annotations [Required] [MaxLength]
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    [MaxLength(50, ErrorMessage = "O tamanho do título não pode exceder 50 caracteres")]
    public String? Titulo {get; set; }
    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public String? Genero { get; set; }
    [Required(ErrorMessage = "A duração do filme é obrigatória")]
    [Range(70,600 , ErrorMessage = "A duração deve ser entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}