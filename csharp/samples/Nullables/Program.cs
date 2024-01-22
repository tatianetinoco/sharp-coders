namespace Nullables;

public class Program
{
  public static void Main(string[] args)
  {
      double valor = double.Parse(Console.ReadLine()!);

      int? nota = null;

      Console.WriteLine(nota);

      double? salarioTrabalhoVoluntario = null;
      double? salarioSemTrabalho = 0.0;

      // trabalho voluntário = recebe 0 reais
      Console.WriteLine(salarioTrabalhoVoluntario ?? 0.0);

      // salário sem trabalho = recebe 0 reais
      Console.WriteLine(salarioSemTrabalho ?? 0.0);
  }

}

