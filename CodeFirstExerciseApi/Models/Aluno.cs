using System.ComponentModel.DataAnnotations;

namespace CodeFirstExerciseApi.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [StringLength(15)]
        public string CPF { get; set; }

        [StringLength(150)]
        public string Nome { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(14)]
        public string Telefone { get; set; }

        public DateTime? DataNascimento { get; set; }
    }
}
