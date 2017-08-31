using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Aluno
    {

        public int RA;
        public string nome;
        public string sexo;
        public Disciplina [] d = new Disciplina [5];


        public Aluno (int RA, string nome, string sexo)
        {
            this.RA = RA;
            this.nome = nome;
            this.sexo = sexo;
        }


    }
}
