namespace pjmd2
{
    public class Menu
    {
        public static void show()
        {
            Console.Clear();
            DrawCanvas();
            ShowOptions();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                {
                    FormPessoaFisica.MainPf();
                } break;
                case 2: 
                {
                    FormPessoaJuridica.MainPj();
                }break;
                case 0:
                {
                    CadastrarPf.listarPf();
                    CadastrarPj.listarPj();
                } break;
            }
           Console.ReadLine();
        }
        
        static void PrintHorizontalLine()
  {
    Console.Write("+");
    for (int i = 0; i <= 30; i++)
      System.Console.Write("-");
    Console.Write("+");
    Console.WriteLine();
  }
        static void DrawCanvas()
        {
             

            PrintHorizontalLine();
            for (int i = 0; i < 12; i++)
            {
                Console.Write("|");
                for (int line = 0; line <= 30; line++)
                {
                Console.Write(" ");
                }
                Console.Write("|");
                Console.Write(Environment.NewLine);
            }
            PrintHorizontalLine();
        }

        static void ShowOptions()
        {
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("DevCAR v0.1");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("=================");

            Console.SetCursorPosition(2, 5);
            Console.WriteLine("1 - Cadastrar pessoa física.");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("2 - Cadastrar pessoa jurídica.");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("3 - Mostrar cadastros.");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("0 - Sair.");

            Console.SetCursorPosition(2, 10);
            Console.Write("Opção selecionada");
            Console.SetCursorPosition(2, 10);
            Console.Write("Opção selecionada: ");
        }                                           
    }

}