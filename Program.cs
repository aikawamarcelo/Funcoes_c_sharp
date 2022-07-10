
namespace Funcoes
{

    //PascalCase
    //camelCase
    //under_line

    class Funcoes2{
        /*
        static void Main(String[]args)
        {
            Funcoes.Tabuada(5);
            var fn = new Funcoes();
            fn.CalcularSoma();
        }
        */
        }
    class Funcoes{

        internal int CalcularSoma()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
          
            return c;
       
        }

        private static void MostrarMensagemNaTela()
        {
           
            Console.WriteLine("Olá pessoal!");
        }

        public static void Tabuada(int numero)
        {
             for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + numero * i);
            }
            Console.WriteLine("-------------------------------------------------");

        }

        static void Main(String[] args)
        {
            MostrarMensagemNaTela();
            Tabuada(9);
            Tabuada(10);
          //  Console.WriteLine(CalcularSoma());
            Console.Read();

        }

    }

}