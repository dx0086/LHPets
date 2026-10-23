using System.ComponentModel.DataAnnotations;

namespace LHPets.Models;

public class Cliente
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome do cliente deve ter entre 2 e 100 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O email do cliente é obrigatório.")]
    [EmailAddress(ErrorMessage = "O email informado não é válido.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "O CPF do cliente é obrigatório.")]
    [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve ter 11 caracteres.")]
    public string Cpf { get; set; } = string.Empty;
}
