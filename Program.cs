using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___Classe___Exercicio_1
{
 internal class Program

 {
  static void Main(string[] args)
  {
   Pessoa p1 = new Pessoa();
   Pessoa p2 = new Pessoa();
   DadosPessoa1(p1);
   DadosPessoa2(p2);
   PessoaMaisVelha(p1, p2);
  }

  public static void DadosPessoa1(Pessoa p1)
  {
   Console.WriteLine("Dados primeira pessoa");
   Console.Write("Nome: ");
   p1.Nome = Console.ReadLine();
   Console.Write("Idade: ");
   p1.Idade = int.Parse(Console.ReadLine());
   Console.WriteLine("----------------------------");
  }


  public static void DadosPessoa2(Pessoa p2)
{
   Console.WriteLine("Dados Segunda pessoa");
   Console.Write("Nome: ");
   p2.Nome = Console.ReadLine();
   Console.Write("Idade: ");
   p2.Idade = int.Parse(Console.ReadLine());
   Console.WriteLine("----------------------------");

  }

  public static void PessoaMaisVelha(Pessoa p1, Pessoa p2)
  {
   if (p1.Idade > p2.Idade)
   {
    Console.WriteLine($"{p1.Nome} é mais velho(a)");
   }
   else
   {
    Console.WriteLine($"{p2.Nome} é mais velho(a)");
   }
  }


  }
 }
