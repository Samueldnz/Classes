using System;

namespace classTwo
{
    class Program
    {
        private static int contador = 0;

        //Algortimo quadrático O(n²)
        static void Main(string[] args)
        {
            int[ , , ] v1 = new int[5, 5, 5];
        
            for(int i = 0; i < 5; i++){
                for(int j = 0; j < 5; j++){  
                    for(int k = 0; k < 5; k++){
                        v1[i, j, k] =  contador;
                        contador++;
                    }
                }
            }

            for(int l = 0; l < 5; l++){
                for(int j = 0; j < 5; j++){
                    for(int k = 0; k < 5; k++){
                        Console.WriteLine(v1[l,j,k]);
                    }
                }
            }
        }
    }
}

