using Microsoft.EntityFrameworkCore;
using CodeFirstExerciseApi.Models;

namespace CodeFirstExerciseApi.Context
{
    public class CursoSenaiContext: DbContext
    {
        public CursoSenaiContext(DbContextOptions<CursoSenaiContext> options) : base(options) 
        { 

        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Instrutor> Instrutores { get; set; }
        public DbSet <Matricula> Matriculas { get; set;}
        public DbSet<Turma> Turmas { get; set; }




    }
}
