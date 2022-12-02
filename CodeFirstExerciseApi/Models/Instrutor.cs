using System.ComponentModel.DataAnnotations;

namespace CodeFirstExerciseApi.Models
{
    public class Instrutor
    {
        public int Id { get; set; }
        [StringLength (150)]
        public string Nome { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Telefone { get; set; }

        [Range(0,18)]
        public decimal? ValorHora { get; set; }
        [StringLength(255)]
        public string? Certificados { get; set; }
    }
}
