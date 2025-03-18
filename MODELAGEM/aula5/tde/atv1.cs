public class Livro{
    public string titulo;
    public string autor;
    public int anoPub;

    public Livro(string titulo, string autor, int anoPub) {
        this.titulo = titulo;
        this.autor = autor;
        this.anoPub = anoPub;
    }
    public void exibirDetalhes() {
        Console.WriteLine($"Titulo do livro: {titulo}, Autor: {autor} e ano de publicação: {anoPub}");
        
    }

}