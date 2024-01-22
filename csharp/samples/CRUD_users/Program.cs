using System.Diagnostics;

namespace CRUD_users;

public class Program {

  static void ShowMenu() {
    Console.WriteLine("Escolha uma opção abaixo");
    Console.WriteLine("1 - para criar um usuário");
    Console.WriteLine("2 - buscar um usuário");
    Console.WriteLine("3 - listar os usuários (sem senha se houver)");
    Console.WriteLine("4 - atualizar um usuário");
    Console.WriteLine("5 - deletar um usuário");
    Console.WriteLine("0 - para sair");
    Console.Write("Digite a opção desejada: ");
  }

  static void CriarUsuario(int emptyPosition, string[] usernames, string[] emails, string[] passwords) {
    Console.Write("Digite seu username: ");
    usernames[emptyPosition] = Console.ReadLine();

    Console.Write("Digite seu email: ");
    emails[emptyPosition] = Console.ReadLine();

    Console.Write("Digite sua senha: ");
    passwords[emptyPosition] = Console.ReadLine();
  }




  // // Primeiro Teste
  // static void TestaCopiaReferencia(int numeroPrimitivo){
  //   numeroPrimitivo = 99999;
  // }

  //  // Segundo Teste
  //  static void TestaCopiaReferencia2(string[] vetorDeStrings){
  //   vetorDeStrings[0] = "hrafa";
  // }




  public static void Main () {

    int TOTAL_SIZE = 1000, size = 0;

    string[] usernames = new string[TOTAL_SIZE];
    string[] emails = new string[TOTAL_SIZE];
    string[] passwords = new string[TOTAL_SIZE];

    // CriarUsuario(emptyPosition++, usernames, emails, passwords);
    // emptyPosition++;

    // 6 = 0, 1, 2, 3, 4, 5, _ A posição vazia é a 6

    // CriarUsuario(size++, usernames, emails, passwords);

    // TODO: reutilizar isso quando for listar todos
    // for(int i = 0; i < size; i++) {
    //   Console.WriteLine("-----------------");
    //   Console.WriteLine(usernames[i]);
    //   Console.WriteLine(emails[i]);
    //   Console.WriteLine(passwords[i]);
    //   Console.WriteLine("-----------------");
    // }




    // // 1º Teste: Não mudou o valor da variável size porque foi uma cópia
    // TestaCopiaReferencia(size);
    // Console.WriteLine(size);

    // // 2º Teste: Antes não tem nada e depois foi modificada
    // Console.WriteLine($"Antes: {usernames[0]}");
    // TestaCopiaReferencia2(usernames);
    // Console.WriteLine($"Depois: {usernames[0]}");




    // Comparativo
    // while pra menu = mostrarMenu verifico&faço mostrarMenu ...
    // do...while = fazendo verifica fazendo

    // ShowMenu();
    // int option = int.Parse(Console.ReadLine());

    // while(option != 0) {

    //   switch(option) {
    //     case 1:
    //       CriarUsuario(size++, usernames, emails, passwords);
    //       break;
    //     default:
    //       Console.WriteLine("Digite uma opcao valida!");
    //       break;
    //   }

    //   ShowMenu();
    //   option = int.Parse(Console.ReadLine());
    // }
    

    int option;

    do {
      ShowMenu();
      option = int.Parse(Console.ReadLine());

      switch(option) {
        case 0:
          Console.WriteLine("valeu, ate a proxima!");
          break;
        case 1:
          CriarUsuario(size++, usernames, emails, passwords);
          break;
        default:
          Console.WriteLine("Digite uma opcao valida!");
          break;
      }
            
    } while(option != 0);

  }

}
