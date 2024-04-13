using System.ComponentModel.DataAnnotations;

namespace IMC.Models;

public class ImcModel
{
    [Required(ErrorMessage = "Informe a altura")]
    [Range(1.0, 3.0, ErrorMessage = "Altura inválida")]
    public double? Height { get; set; }
    
    [Required(ErrorMessage = "Informe o peso")]
    [Range(15.0, 180.0, ErrorMessage = "Peso inválido")]
    public double? Weight { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public double Imc => (Weight ?? 1) / ((Height ?? 1) * (Height ?? 1));
}