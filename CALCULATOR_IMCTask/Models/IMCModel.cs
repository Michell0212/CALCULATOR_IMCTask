using System.ComponentModel.DataAnnotations;

namespace CALCULATOR_IMCTask.Models
{
    public class IMCModel
    {
        [Required(ErrorMessage = "Debe ingresar un nombre.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar el peso.")]
        [Range(1, 500, ErrorMessage = "El peso debe ser mayor que 0.")]
        public double Peso { get; set; }

        [Required(ErrorMessage = "Debe ingresar la altura.")]
        [Range(0.1, 3.0, ErrorMessage = "La altura debe ser mayor que 0.")]
        public double Altura { get; set; }

        public double ResultadoIMC { get; set; }
    }
}
