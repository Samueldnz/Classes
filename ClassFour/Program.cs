using System;

namespace ClassFour
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool looping = false;

            Console.WriteLine("Bem Vindo a Calculadora!");

            Console.Write("\n");
            Console.WriteLine("Insira um valor: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira um valor: ");
            double b = double.Parse(Console.ReadLine());

            if(b == 0){
                Console.Write("\n");
                double resultado = Soma(a, b); 
                Console.WriteLine("Soma: {0}", resultado);

                resultado = Subtracao(a, b);
                Console.WriteLine("Subtracao: {0}", resultado); 

                resultado = Multiplicacao(a, b);
                Console.WriteLine("Multiplicação: {0}", resultado); 
                
            }else{

                Console.Write("\n");
                double resultado = Soma(a, b); 
                Console.WriteLine("Soma: {0}", resultado);

                resultado = Subtracao(a, b);
                Console.WriteLine("Subtracao: {0}", resultado); 

                resultado = Multiplicacao(a, b);
                Console.WriteLine("Multiplicação: {0}", resultado); 

                resultado = Divisao(a, b);
                Console.WriteLine("Divisão: {0}", resultado);
            }
            // Console.WriteLine(Soma(3625, 6434, 4342, 42342));
        }

        public static double Soma(double a, double b){
            double resultado = a + b;
            return resultado;
        }

        //Exemplicações
        // private int Soma(int a, int b){
        //     return a + b;
        // }

        // private static int Soma(int a, int b, int c, int d) => a + b + c + d; 

        public static double Subtracao(double a, double b){
            return a - b;
        }

        private static double Divisao(double a, double b){
            return a/b;
        }

        private static double Multiplicacao(double a, double b) => a*b;

    }
}
