using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula4Ex6 {
    class Program {
        static void Main(string[] args) {

            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            
           
            Console.WriteLine("NOTA FINAL = " +aluno.NotaFinal().ToString("F2"),CultureInfo.InvariantCulture);

            if (aluno.Aprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "+aluno.NotaRestante().ToString("F2",CultureInfo.InvariantCulture)+" PONTOS");
            }



        }
    }
}
