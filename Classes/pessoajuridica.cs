namespace Aula_19.Classes
{
    public class PessoaJuridica : Pessoa
    {
        public string? Cnpj {get; set;}

        public void Inserir(PessoaJuridica pj) {
            using (StreamWriter sw = new StreamWriter(pj.Nome+" .txt"))
            {
                sw.WriteLine($"{pj.Nome}, {pj.Rendimento}, {pj.Cnpj} ");
            }
        }        
    }
}