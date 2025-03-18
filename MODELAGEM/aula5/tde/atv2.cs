public class Praia{
    public string nome;
    public string localizao;
    public double tempMedia;
    public bool temQuiosque;

    public Praia(string nome, string localizao, double tempMedia, bool temQuiosque) {
        this.nome = nome;
        this.localizao = localizao;
        this.tempMedia = tempMedia;
        this.temQuiosque = temQuiosque;
    }

    public void exibirDetalhes() {
        Console.WriteLine($"Nome da Praia: {nome}, Localização: {localizao}, Temperatura Média: {tempMedia}, Tem Quiosque {temQuiosque}");
    }
}