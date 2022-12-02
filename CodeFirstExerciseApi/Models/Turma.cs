using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstExerciseApi.Models
{
    public class Turma
    {
        public int Id { get; set; }

        [ForeignKey("Instrutor")]

        public int IdInstrutor { get; set; }

        [ForeignKey ("Curso")]
        public int IdCurso { get; set; }

        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public int? CargaHoraria { get; set; }
        public Instrutor Instrutor { get; set; }
        public Curso Curso { get; set; }
    }
}
