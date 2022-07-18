namespace pjmd2
{
    public class FormPessoaFisica
    {
        public static void MainPf()
        {
            string nome;
            string telefone;
            string cpf;
            char continua ='s';

            CadastrarPf pf0 = new CadastrarPf();

            do{
                Console.Clear();
                Console.WriteLine("Cad. Pessoa física");

                Console.WriteLine("Insira nome completo:");
                nome = Console.ReadLine();

                Console.WriteLine("Insira seu telefone");
                telefone = Console.ReadLine();

                Console.WriteLine("Insira seu CPF:");
                cpf = Console.ReadLine();

                Console.WriteLine("Deseja continuar? (s/n)");
                continua = Convert.ToChar(Console.ReadLine());

                pf0.addPf(nome, telefone, cpf);

            }while (continua == 's');

            Menu.show();
        }
    }
}