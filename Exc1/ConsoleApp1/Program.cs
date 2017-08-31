using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Crie 5 objetos Aluno
            Aluno a1 = new Aluno(92738, "Joao", "M");
            Aluno a2 = new Aluno(94155, "Matheus", "M");
            Aluno a3 = new Aluno(76126, "Larissa", "F");
            Aluno a4 = new Aluno(88147, "Marcela", "F");
            Aluno a5 = new Aluno(44444, "Rubens", "M");

            // Crie 5 objetos Disciplina
            Disciplina d1 = new Disciplina("#4125", "IOO");
            Disciplina d2 = new Disciplina("#7415", "LP2");
            Disciplina d3 = new Disciplina("#6666", "PW1");
            Disciplina d4 = new Disciplina("#0457", "MAT1");
            Disciplina d5 = new Disciplina("#3200", "ENG3");

            // Coloque dentro do primeiro aluno as duas primeiras disciplinas
            a1.d[0] = d1;
            a1.d[1] = d2;

            // Coloque dentro do segundo aluno todas as disciplinas

            a2.d[0] = d1;
            a2.d[1] = d2;
            a2.d[2] = d3;
            a2.d[3] = d4;
            a2.d[4] = d5;

            // Coloque dentro do terceiro aluno as três ultimas disciplinas
            a3.d[0] = d3;
            a3.d[1] = d4;
            a3.d[2] = d5;

            // Crie mais uma referência para o segundo aluno
            Aluno b = a2;

            // Crie mais duas referências para a primeira disciplina;
            Disciplina c1 = d1;
            Disciplina c2 = d1;

            // Troque os dados da primeira disciplina a partir da última referência para ela criada
            c2.nome = "Changed";
            c2.ID = "#0000";

            // Troque os dados da terceira disciplina a partir do segundo objeto aluno criado
            a2.d[2].nome = "Changed2";
            a2.d[2].ID = "#0001";

            Console.WriteLine("Successful");
            Console.ReadKey();




        }
    }
}
