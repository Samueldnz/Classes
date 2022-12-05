using System;

namespace ClassFour
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 20;
            int b = 10;

            Console.WriteLine("Testando somente positivos");
            int resultado = Soma(a, b); //30
            Console.WriteLine(resultado);

            resultado = Subtracao(a, b);
            Console.WriteLine(resultado); //10

            resultado = Multiplicacao(a, b);
            Console.WriteLine(resultado); //200

            resultado = Divisao(a, b);
            Console.WriteLine(resultado); //2


            Console.WriteLine("Testando negativos");
            resultado = Soma(20, -10);
            Console.WriteLine(resultado); //10

            resultado = Subtracao(20, -10);
            Console.WriteLine(resultado); //30

            resultado = Multiplicacao(20, -10);
            Console.WriteLine(resultado); //-200

            resultado = Divisao(20, -10);
            Console.WriteLine(resultado); //-2


            Console.WriteLine("Testando somente negativos");
            resultado = Soma(-20, -10); 
            Console.WriteLine(resultado); //-30

            resultado = Subtracao(-20, -10);
            Console.WriteLine(resultado); //-10

            resultado = Multiplicacao(-20, -10);
            Console.WriteLine(resultado); //200

            resultado = Divisao(-20, -10);
            Console.WriteLine(resultado); //2


            Console.WriteLine("Testando com 0");
            resultado = Soma(20, 0); 
            Console.WriteLine(resultado); //20

            resultado = Subtracao(20, 0);
            Console.WriteLine(resultado); //20

            resultado = Multiplicacao(20, 0);
            Console.WriteLine(resultado); //0

            resultado = Divisao(20, 0);
            Console.WriteLine(resultado); //ERRO

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
                Console.WriteLine("O valor do Denominador é 0");
                return 0;     //TOTALMENTE ERRADO!!! É só pra rodar mesmo
            } else{
                return a/b;
            }
        }

        private static int Multiplicacao(int a, int b) => a*b;

    }
}
