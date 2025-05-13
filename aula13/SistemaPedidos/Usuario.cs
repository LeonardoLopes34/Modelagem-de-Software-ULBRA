public class Usuario {

    private int _numUsuario;
    public int NumUsuario { 
        get {return _numUsuario;} 
        set {_numUsuario = value;}
         }

    public int Senha { get; set; }

    public String? EstadoLogin { get; set; }

    public DateTime DataCadastro { get; set; }


}