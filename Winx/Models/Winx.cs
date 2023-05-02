namespace Winx.Models;

public class Winx
{
     //Atributos
    public int Numero { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public List<string> Tipo { get; set; }
    public string Poder { get; set; }
    public string Habilidade  {get; set; }
    public string Imagem { get; set; }

    //Método Construtor
    public Winx()
    {
        Tipo = new List<string>();
    }
}

