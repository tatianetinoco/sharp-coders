# Aprofundando em  POO

## Atributos e Métodos estáticos

```cs
public class Circulo {
  public readonly double PI = 3.14159265;

  public double Raio {get; set;}

  public double Area {
    get { return PI * Raio * Raio; }
  }

  public double Perimetro {
    get { return 2 * PI * Raio; }
  }
}
```

Problemas:

- Cada circulo está tendo o seu próprio PI
- Eu deveria conseguir saber o valor de PI independente de um objeto Circulo

**Static** (estático):

```cs
public class Circulo {
  public static readonly double PI = 3.14159265;

  public double Raio {get; set;}

  public double Area {
    get { return PI * Raio * Raio; }
  }

  public double Perimetro {
    get { return 2 * PI * Raio; }
  }
}
```

- Serve para criar variável global
- Seria compartilhado entre todos (nao gastaria memória adicional)
- Não depende de um objeto para ser utilizado, passaria a funcionar:

```cs
  Console.WriteLine(Circulo.PI); // 3.1415...
```

```cs
Math.Log10();
```

```cs
public class TimeUtils {
  public static readonly double DAY_IN_HOURS = 24.0;
  public static readonly double DAY_IN_MINUTES = 24.0 * 60.0;
}
```

Se eu estivesse num programa onde não quero instanciar circulos, apenas isolar calculos dentro de uma classe

```cs
public class CircleUtils {

  private static readonly double PI = 3.14159265;

  public static double CalculateArea(double raio) {
    return PI * Raio * Raio;
  }

  public static double CalculatePerimetro(double raio) {
    return 2 * PI * Raio;
  }

}
```

Usando:

```cs
double result = CircleUtils.CalculateArea(3.0);
```

## Herança

A herança é permitir que uma classe extenda comportamentos e atributos de outra, para que sejam reaproveitados.

- tem um / tem vários = atributo ou property
- faz ou um comportamento = método
- é um, é uma = herança

```
Pessoa
- Estudante
- Professor
```

```cs
public class Pessoa {
  public string Nome {get; set;}
  public string Cpf {get; set;}
  public string Idade {get; set;}
}

public class Estudante : Pessoa { // Estudante extende Pessoa
  // public string Nome {get; set;}
  // public string Cpf {get; set;}
  // public string Idade {get; set;}
  public string RegistroDoAluno {get; set;}
}

public class Professor : Pessoa { // Professor extende Pessoa
  // public string Nome {get; set;}
  // public string Cpf {get; set;}
  // public string Idade {get; set;}
  public List<string> Habilidades {get; set;} = new();
}
```

## Keywords (palavras-chave) de heranca

### base

A palavra `base` funciona de modo similar a palavra `this`, so que ela faz referência a classe mae do método ou atributo sendo utilizado.

### `virtual`

Permite que um método seja sobreescrito por uma classe filha

### `override` - sobreescrever

Se eu quero mudar o comportamento de um método da classe mae.

exemplo: sobreescrevendo o comportamento padrão da classe `Object`

```cs
public override string ToString()
{
    return $"...";
}
```

### protected

Permite que classes filhas e a classe mae vejam um atributo.

