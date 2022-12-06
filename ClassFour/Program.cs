using System;

namespace ClassFour
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo a Calculadora!");

            Console.Write("\n");
            Console.WriteLine("Insira um valor: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um valor: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("\n");
            int resultado = Soma(a, b); 
            Console.WriteLine("Soma: {0}", resultado);

            resultado = Subtracao(a, b);
            Console.WriteLine("Subtracao: {0}", resultado); 

            resultado = Multiplicacao(a, b);
            Console.WriteLine("Multiplicação: {0}", resultado); 

            resultado = Divisao(a, b);
            Console.WriteLine("Divisão: {0}", resultado); 

            // Console.WriteLine(Soma(3625, 6434, 4342, 42342));
        }

        //Somente para exemplicar um retorno void
        public static void Nada(){
            Console.WriteLine("Nada");
        }

        public static int Soma(int a, int b){
            int resultado = a + b;
            return resultado;
        }

        //Exemplicações
        // private int Soma(int a, int b){
        //     return a + b;
        // }

        // private static int Soma(int a, int b, int c, int d) => a + b + c + d; 

        public static int Subtracao(int a, int b){
            return a - b;
        }

        private static int Divisao(int a, int b){
            if(b == 0){
                return 0;     //TOTALMENTE ERRADO!!! Apenas didático para a aula atual
            } else{
                return a/b;
            }
        }

        private static int Multiplicacao(int a, int b) => a*b;

    }
}
