namespace pjmd2
{
    public class FormPessoaJuridica
    {
        public static void MainPj()
        {
            string nome;
            string telefone;
            string cnpj;
            char continua ='s';

            CadastrarPj pj0 = new CadastrarPj();

            do{
                Console.Clear();
                Console.WriteLine("Cad. Pessoa física");

                Console.WriteLine("Insira nome completo:");
                nome = Console.ReadLine();

                Console.WriteLine("Insira seu telefone");
                telefone = Console.ReadLine();

                Console.WriteLine("Insira seu CNPJ:");
                cnpj = Console.ReadLine();

                Console.WriteLine("Deseja continuar? (s/n)");
                continua = Convert.ToChar(Console.ReadLine());

                pj0.addPj(nome, telefone, cnpj);

            }while (continua == 's');

            Menu.show();
        }
    }
}