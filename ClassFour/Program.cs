using System;

namespace ClassFour
{
    class Program
    {
        public static void Main(string[] args)
        {
        //    int resultado = Soma(2, 1); 
        //    Console.WriteLine(resultado);
                Console.WriteLine(Soma(3625, 6434));
        }

        private void Nada(){
            Console.WriteLine("Nada");
        }

        // private int Soma(int a, int b){
        //     int resultado = a + b;
        //     return resultado;
        // }

        // private int Soma(int a, int b){
        //     return a + b;
        // }

        private static int Soma(int a, int b) => a + b; //3
    }
}
