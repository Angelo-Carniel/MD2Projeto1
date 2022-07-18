namespace pjmd2
{
    public class CadastrarPf
    {
        private List<PessoaFisica> cadPf;

        public CadastrarPf()
        {
            cadPf = new List<PessoaFisica>();
        }

        public void addPf(string nome, string telefone, string cpf)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.nome = nome;
            pf.telefone = telefone;
            pf.cpf = cpf;
            cadPf.Add(pf);
        }

        public static void listarPf()
        {
            foreach (var pf in cadPf)
            {
                Console.WriteLine(pf.ToString());
            }
        }
    }

    public class CadastrarPj
    {
        private List<PessoaJuridica> cadPj;

        public CadastrarPj()
        {
            cadPj = new List<PessoaJuridica>();
        }

        public void addPj(string nome, string telefone, string cnpj)
        {
            PessoaJuridica pj = new PessoaJuridica();
            pj.nome = nome;
            pj.telefone = telefone;
            pj.cnpj = cnpj;
            cadPj.Add(pj);
        }

        public static void listarPj()
        {
            foreach (var item in cadPj)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}