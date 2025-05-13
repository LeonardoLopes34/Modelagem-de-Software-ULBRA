public class Cliente: Usuario {
    public String? NomeCliente { get; set; }

    public String? Endereco { get; set; }

    public String? InfoCartaoCredito { get; set; }

    public String? InfoEnvio { get; set; }

    public decimal SaldoConta { get; set; }

    public void Cadastro() {
        Console.WriteLine("Cadastrando");
    }
    public void Login() {
        Console.WriteLine("Logando");
    }
}