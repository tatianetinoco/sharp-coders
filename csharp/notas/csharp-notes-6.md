# POO de um jeito pratico

## null assertion

O operador `null!` ou usar `!` para evitar warnings(avisos) de nulo, não garante que o conteudo não vira nulo, apenas indica que você está se responsabilizando que o conteúdo não será nulo.

```cs
public class User
{
   public int Id { get; set; }
   public string Email { get; set; } = null!;
   public string Username { get; set; }
   public string? Nickname {get; set;} = null;
   public string Password { get; set; }
}
```


