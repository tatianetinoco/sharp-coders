# Melhorias na POO

```cs
public class Pessoa {
  public string nome;
  public int idade;
  public double altura;
  public string telefone;

  public void DizerOi() {
    Console.WriteLine("Oi!");
  }
}
```

Problemas dessa abordagem:

- Não está cuidado da criação da classe, isto é, de atributos que deveriam obrigatórios.

- Eu não me preocupo com a maneira com que meus atributos são utilizados

## Construtores

Construtores são métodos que são chamados durante a inicialização do objeto.

```cs
Pessoa joao = new Pessoa();
```

Implicitamente está chamando:

```cs
public class Pessoa {
  // atributos...

  // construtor padrao
  public Pessoa() {
  }

  // metodos...
}
```

### Construtores Personalizados

```cs
public class Pessoa {
  public string nome;
  public int idade;
  public double altura;
  public string telefone;

  // all args constructor = construtor com todos os atributos
  // Construtor não lê a variável, lê o tipo
  public Pessoa(string nome, int idade, double altura) {
    this.nome = nome;
    this.idade = idade;
    this.altura = altura;
  }

  public void DarBoasVindas() {
    Console.WriteLine($"Bem vindo, me chamo {nome}!");
  }
}
```

```cs
Pessoa joao = new Pessoa("Joao da Silva", 22, 1.8);
// joao.nome = "Joao da Silva";
// joao.idade = 22;
// joao.altura = 1.8;

joao.DarBoasVindas();
// imprimir: Bem vindo, me chamo joao da silva
```

### palavra-chave `this`

O `this` permite que acesse o objeto responsável por chamar o método.

- palavra diferenciadora
- palavra this faz a gente pensar no objeto

### Construtor que pensa

```cs
public class Pessoa {
  public string nome;
  public string sobrenome
  public int idade;
  public double altura;
  public string telefone;

  public Pessoa(string nomeCompleto, int idade, double altura) {
    // nomeCompleto = Pedro Silva
    string[] nomes = nomeCompleto.Split(' ');
    // nomes = ['Pedro', 'Silva']
    this.nome = nomes[0]; // nome = Pedro
    this.sobrenome = nomes[1]; // nome = Silva
    this.idade = idade;
    this.altura = altura;
  }

  public void DarBoasVindas() {
    Console.WriteLine($"Bem vindo, me chamo {nome}!");
  }
}
```

### Sobrecarga (Overload)

- Consequência: Múltiplos construtores

Quando eu tenho o mesmo nome(função) porém com uma assinatura(parâmetros e retorno) diferentes.

```cs
public void DizerOi() {
  Console.WriteLine("oi!");
}

public void DizerOi(string nome) {
  Console.WriteLine($"oi, {nome}!");
}

public double Somar(double a, double b) {
  return a + b;
}

public double Somar(double a, double b, double c) {
  return a + b + c;
}
```

Sobrecarga de construtores:

```cs
public class Pessoa {
  public string nome;
  public int idade;
  public double altura;
  public string telefone;

  // all args constructor = construtor com todos os atributos
  public Pessoa(string nome, int idade, double altura, string telefone) {
    this.nome = nome;
    this.idade = idade;
    this.altura = altura;
    this.telefone = telefone;
  }

  public Pessoa(string nome, int idade, double altura) {
    this.nome = nome;
    this.idade = idade;
    this.altura = altura;
  }

  public Pessoa() {
  }

  public void DarBoasVindas() {
    Console.WriteLine($"Bem vindo, me chamo {nome}!");
  }
}
```

reaproveitando os construtores

```cs
public class Pessoa {
  public string nome;
  public int idade;
  public double altura;
  public string telefone;

  // all args constructor = construtor com todos os atributos
  public Pessoa(string nome, int idade, double altura) {
    if(idade <=0){
      throw new Exception("Idade inválida");
    }
    this.nome = nome;
    this.idade = idade;
    this.altura = altura;
  }

  public Pessoa(string nome, int idade, double altura, string telefone) : 
    this() {
    this.telefone = telefone;
  }


  public void DarBoasVindas() {
    Console.WriteLine($"Bem vindo, me chamo {nome}!");
  }
}
```

## Modificadores de acesso

- visibilidade

|Modificador| Objetivo|
|:-:| :-: |
|`public`|pode ser acessado em qualquer pasta, ou arquivo da solução|
|`private`|não pode ser acessado em nenhum lugar fora da classe declarada|
|`protected`|só pode ser acessado na própria classe e nas classes filhas|
|`(default)`|pode ser acessado em qualquer lugar da mesma pasta/nível|

exemplo do `(default)`:

`Projeto.Model.Pessoa.cs:`

```cs
class Pessoa {
  // ...
}
```

qualquer outra classe dentro do pacote `Model` poderia ver a classe `Pessoa`.

## Como estamos utilizando a nossa classe

```cs
public class Pessoa {

  // outros atributos
  public int idade;

  // construtor

}
```

Não quero que aconteça:

```cs
Pessoa joao = new Pessoa("Joao da Silva", 22, 1.8);

joao.idade = -1000;
```

evitando isso:

```cs
public class Pessoa {

  // outros atributos
  private int idade;

  // construtor

}
```

## Properties (Property)

- não armazena valor
- pode fornecer acesso a valores de com uma sintaxe melhor

```cs
public double Altura {
  get {
    //será chamado quando for acessar
  }
  set {
    // será chamado quando for mudar
  }
}
```