# Funções



Conjunto de passos bem definidos.

podem ter...

- retorno
- parametros, entradas, argumento

- cálculos matematicos

```cs
//f(x) = x + 2
static double SomarDois(double x) {
  return x + 2;
}

// void = vazio
static void SayHello() {
  Console.WriteLine("Hello!");
  return;
}

static void SayHelloToSomeone(string name) {
  Console.WriteLine($"Hello, {name}");
}

// boolean = prefixo Is e Has
// even = Par
static boolean IsEven(int num) {
  return num%2 == 0;
}

static boolean HasInvalidCharacters(string username) {
  // logica para validar se o username esta com caracteres invalidos
}

public static void Main() {

  string username = Console.ReadLine();

  if(HasInvalidCharacters(username)) {
    // faz algo com o username
  }

  Console.WriteLine(SomarDois(5));
}
```

Menção Honrosa:

- Valor em detrimento de outro
- Execução de processos
- Reaproveitamento (reuso, e se código fosse muito grande)
- Instrução isolada/divisão de tarefas
- Utilidade
- Modularizaçãoo/bloco de codigo
- Objetivo/Resolve Problemas
- Legibilidade

## Práticas interessantes

### early return (retorno "adiantado")

- Tento retornar antes, e mantenho um caso padrão

Jeito Antigo:

```cs
static boolean EhPar(int number) {
  if(number%2 == 0)
    return true;
  else
    return false;
}
```

Boa prática do early return:

```cs
static boolean EhPar(int number) {
  if(number%2 == 0)
    return true;

  return false;
}
```

```cs
static void Sacar(double quantia) {
  if(ativa == true && saldo >= quantia) {
    saldo -= quantia;
  }
}
```

Refatorando...

```cs
static void Sacar(double quantia) {
  if(!ativa)
    throw new Exception("Conta inativa");

  if(saldo < quantia)
    throw new Exception("Saldo insuficiente");

  if(!cpfValido)
    throw new Exception("Cpf Inválido");

  saldo -= quantia;
}
```

se for multiplo de 3 = foo
se for multiplo de 5 = boo
se for multiplo de ambos = fooboo

```cs
public boolean IsMultipleOf(int number, int divisor) {
  if(number%divisor != 0)
    return false;

  return true;
}

public static string TestFooBoo(int number) {
  string aux = "";

  if(IsMultipleOf(number, 3))
    aux += "foo";

  if(IsMultipleOf(number, 5))
    aux += "boo";

  return aux;
}

Console.WriteLine(TestFooBoo(int.Parse(Console.ReadLine())));
```

Código Ruim = dificil de extender, entender e mudar

### switch-case

```cs
string sinal = "vermelho";

switch(sinal) {
  case "vermelho":
    Console.WriteLine("Parar");
    break;
  case "amarelo":
    Console.WriteLine("Atenção");
  case "verde":
    Console.WriteLine("Passar");
    break;
  default: // padrao
    Console.WriteLine("Dirija Com Cuidado");
    break;
}
```

```cs
static void IsConsonant(char c) {
  swith(c) {
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
      return true;
  }

  return false;
}
```

## Predencia do ++/--

variavel++ = primeiro entrega o valor e depois aumenta
++variavel = primeiro aumenta e depois entrega o valor

```cs
int x = 10;

Console.WriteLine(++x); // 11
Console.WriteLine(x); // 11

int y = 10;
Console.WriteLine(y++); // 10
Console.WriteLine(y); // 11
```

## Fibonacci

Cada próximo termo é a soma dos 2 anteriores a ele
valores = 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89
indices = 0, 1, 2, 3, 4, 5, 6,  7,  8,  9, 10, 11

