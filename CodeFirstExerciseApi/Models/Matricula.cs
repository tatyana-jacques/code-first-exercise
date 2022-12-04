using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstExerciseApi.Models
{
    public class Matricula
    {
        public int Id { get; set; }

        [ForeignKey("Turma")]
        public int IdTurma { get; set; }

        [ForeignKey("Aluno")]

        public int IdAluno { get; set; }

        public DateTime? DataMatricula { get; set; }

        public Turma Turma { get; set; }

        public Aluno Aluno { get; set; }
    }
}
