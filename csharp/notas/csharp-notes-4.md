# POO

## Motivação

Quero criar 1 pessoa:

```cs
string nome;
int idade;
double altura;
```

Quero criar 3 pessoas:

```cs
string nome1, nome2, nome3;
int idade1, idade2, idade3;
double altura1, altura2, altura3;
```

Quero criar 1000 pessoas:

```cs
int quantidade = 1000;
string[] nomes = new string[1000];
int[] idades = new int[1000];
double[] alturas = new double[1000];
```

Relembrando... como trocar duas variáveis?

Solução: criar variável auxiliar

```cs
int a = 2, b = 3;
int antigo_a = a;
a = b;
b = antigo_a;
```

Solução exótica:

```cs
int a = 2, b = 3;
(a, b) = (b, a);
```

Relembrando... ordenação

- estratégia de troca
- estratégia de comparação

Tentando trocar a primeira e a quinta pessoa:

```cs
int quantidade = 1000;
string[] nomes = new string[1000];
int[] idades = new int[1000];
double[] alturas = new double[1000];

string aux1 = nomes[0];
nomes[0] = nomes[4];
nomes[4] = aux1;

int aux2 = idades[0];
// ...
```

🔴 Problemas

- baixa legibilidade
- dificil manutenção

## Classe

- O que faz uma classe?
  molde, tipo de variável personalizado, classificação

- O que é um objeto?
  fruto do molde

molde(classe): Carro, exemplo(objeto): Ferrari
molde(classe): Ferrari, exemplo(objeto): Ferrari do Bruno
molde(classe): Pessoa, exemplo(objeto): joao

- o que compõe uma classe?
  - o que ela tem: atributos
  - o que ela faz: método

Declarando...

```cs
public class Pessoa {
  // tem - atributos
  public string nome;
  public int idade; 
  public double altura; 

  // faz - métodos
  public void FazerAniversario() {
    idade++;
  }

  public double Somar(double a, double b) {
    return a + b;
  }
}
```

Instancia sinônimo de exemplo.

usando ...

```cs
public class Program {
 
  public static void Main() {

    // short sintax
    // Pessoa joao = new();

    Pessoa joao = new Pessoa();

  }

}
```
