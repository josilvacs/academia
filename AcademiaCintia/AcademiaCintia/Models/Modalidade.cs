using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademiaCintia.Models;

[Table("Modalidade")]
public class Modalidade
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [StringLength(60)]
    public string Nome { get; set; }

    [Required]
    [StringLength(600)]
    public string Descricao { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }

    [Required]
    public int CategoriaId { get; set; }
    [ForeignKey("CategoriaId")]
    public Categoria Categoria { get; set; }
}
