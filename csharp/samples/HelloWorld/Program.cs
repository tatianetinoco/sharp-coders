// file-scoped namespace
namespace HelloWorld; 

    public class Program
    {
        // Função Principal - Ponto de Entrada - entrypoint
        public static void Main()
        {
            Console.WriteLine("Hello, World!");

            // Variáveis
            int a = 2;
            long l = 43;
            long x = 43L;

            float f = 2.3f;
            double d = 2.3;

            long inteiroLongo = 3L;
            int longo = (int)inteiroLongo;

            string nome = "Hugo";

            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            Console.Write("Digite alguma coisa para ser lida: ");
            var leitura = Console.ReadLine();

            Console.WriteLine(leitura);

            var primeiroNumero = int.Parse(Console.ReadLine());
            var segundoNumero = Console.ReadLine();

            Console.WriteLine(primeiroNumero + segundoNumero);


            // Seleção / Condicionais

            // Repetição

            // Funções
           
        }

    }

