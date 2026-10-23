using System.ComponentModel.DataAnnotations;

namespace LHPets.Models;

public class Pet
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome do pet é obrigatório.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome do pet deve ter entre 2 e 100 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "A espécie do pet é obrigatória.")]
    public string Especie { get; set; } = string.Empty;

    [Required(ErrorMessage = "A raça do pet é obrigatória.")]
    public string Raca { get; set; } = string.Empty;

    [Required(ErrorMessage = "O cliente associado ao pet é obrigatório.")]
    [Range(1, int.MaxValue, ErrorMessage = "O cliente associado ao pet deve ser um ID válido.")]
    public int ClienteId { get; set; }
}