using System;

namespace ClassFour
{
    class Program
    {
        public static void Main(string[] args)
        {
            //variável controladora do looping
            bool sair = false;

            //looping da calculadora
            while(!sair){

            Console.WriteLine("Bem Vindo a Calculadora!");

             //menu com opções soma/subtração/ divisão e multiplicação
            int opcao = menu();

            //Pega os números da teclado
            Console.Write("\n");
            Console.WriteLine("Insira um valor: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira um valor: ");
            double b = double.Parse(Console.ReadLine());

           

            switch(opcao){
                case 1: //soma
                    Console.Write("\n");
                    Console.WriteLine("Resultado: {0}", Soma(a, b));
                    break;
            
                case 2: //subtração
                    Console.Write("\n");
                    Console.WriteLine("Resultado: {0}", Subtracao(a, b));
                    break;

                case 3: //multiplicação
                    Console.Write("\n");
                    Console.WriteLine("Resultado: {0}", Multiplicacao(a, b));
                    break;

                case 4: //divisão
                    if(b == 0){
                        Console.Write("\n");
                        Console.WriteLine("Divisão por 0");

                    }else{
                        Console.Write("\n");
                        Console.WriteLine("Resultado: {0}", Divisao(a, b));      
                    }
                    break;

                case 5: //sair
                    sair = true;
                    break;
            }
            }

           

        }


        public static int menu(){
            Console.WriteLine("Menu de Operação:");
            Console.Write("\n");
            Console.WriteLine("  1) Soma");
            Console.WriteLine("  2) Subtração");
            Console.WriteLine("  3) Multiplicação");
            Console.WriteLine("  4) Divisão");
            Console.WriteLine("  5) Sair");
            Console.Write("\n");

            Console.Write("Opção:");
            int opcao = int.Parse(Console.ReadLine());

            return opcao;
        }

        public static double Soma(double a, double b){
            double resultado = a + b;
            return resultado;
        }

        public static double Subtracao(double a, double b){
            return a - b;
        }

        private static double Divisao(double a, double b){
            return a/b;
        }

        private static double Multiplicacao(double a, double b) => a*b;

    }
}
