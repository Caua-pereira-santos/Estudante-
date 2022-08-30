namespace MvcRazorViews.ViewModels;

public class EstudanteViewModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public bool Ativo { get; set; }


//Criação do objeto estudante
    public EstudanteViewModel(int id, string nome, string endereco, bool ativo)
    {
        Id = id;
        Nome = nome;
        Endereco = endereco;
        Ativo = ativo;
    }
}