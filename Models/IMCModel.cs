using System;
using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
    public class IMCModel
    {
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Sexo")]
        public string Sexo { get; set; }

        [Display(Name = "Edad")]
        public int Edad { get; set; }

        [Display(Name = "Peso (kg)")]
        public double Peso { get; set; }

        [Display(Name = "Altura (m)")]
        public double Altura { get; set; }

        public double ResultadoIMC { get; set; }
    }
}
