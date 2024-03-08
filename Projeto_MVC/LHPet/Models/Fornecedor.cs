namespace LHPet.Models;
public class Fornecedor(int id, string nome, string cnpj, string email)
{
    public int Id { get; set; } = id;
    public string Nome { get; set; } = nome;
    public string Cnpj { get; set; } = cnpj;
    public string Email { get; set; } = email;
}