using System.Collections;
using System.Collections.Generic;

namespace SmartShcool.API.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Disciplina> Disciplinas { get; set; }

        public Professor(int id, string nome) 
        {
            this.Id = id;
            this.Nome = nome;              
        }
    }
}