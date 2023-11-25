using System.Collections;
using System.Collections.Generic;

namespace SmartShcool.API.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public ICollection<AlunoDisciplina> AlunoDisciplinas;

        public Aluno()
        {
        }
        public Aluno(int id, string nome, string sobrenome, string telefone) 
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Telefone = telefone;
               
        }
    }
}