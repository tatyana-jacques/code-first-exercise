using System.ComponentModel.DataAnnotations;

namespace CodeFirstExerciseApi.Models
{
    public class Curso
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string Nome { get; set; }

        [StringLength(255)]
        public string? Requisito { get; set;}

        public int? CargaHoraria { get; set; }

        [Range(0, 18)]
        public decimal Valor { get; set; }
    }
}
