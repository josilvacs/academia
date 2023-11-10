using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AcademiaCintia.Models;

[Table("Comentario")]
public class Comentario
{    
    [Required]
    [StringLength(60)]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Informe o Texto do Comentario")]
    [StringLength(300, ErrorMessage = "O Texto deve possuir no máximo 300 caracteres")]
    public string ComentarioTexto { get; set; }
    
    [Display(Name = "Data do Comentario")]
    public DateTime ComentarioData { get; set; } = DateTime.Now;

    [Display(Name = "Nota")]

    public byte? Nota { get; set; }
        [StringLength(300)]
    public string Foto { get; set; }
}