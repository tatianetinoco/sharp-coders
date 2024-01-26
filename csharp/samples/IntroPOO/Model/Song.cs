namespace IntroPOO.Model;

public class Song
{
  // Atributos
   public string? nome;
   public int duracaoEmMinutos;
   public string? artista;
   private int _anoDeLancamento;
   public string DataDeCriacao { get; private set; } // autoproperty

  // construtor this (pronome pocessivo) = desse
  // this = referência ao objeto que chamou ou a própria classe
  // this = resolver ambiguidade
  public Song(string nome, int duracaoEmMinutos, string artista, int anoDeLancamento, string dataDeCriacao) {
    this.nome = nome;
    this.duracaoEmMinutos = duracaoEmMinutos;
    this.artista = artista;
    _anoDeLancamento = anoDeLancamento;
    DataDeCriacao = dataDeCriacao;
  }

  // Métodos

  // setter => isola a lógica de alterar a variável
  public void SetAnoDeLancamento(int anoDeLancamento) {
    if(anoDeLancamento <= 0)
      return;

    _anoDeLancamento = anoDeLancamento;
  }

  // getter => isola a lógica de acessar a variável
  // public string GetDataDeCriacao() {
  //   return _dataDeCriacao;
  // }

  public int GetAnoDeLancamento() {
    return _anoDeLancamento;
  }
}

