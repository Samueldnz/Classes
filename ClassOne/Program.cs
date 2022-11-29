using System;

namespace classOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[16];
            
            for(int i = 0; i < v.Length;i++)
            {
                bool test = true;
                do
                 {
                    Console.WriteLine("Informe um valor referente a posição {0}", i);
                    try
                    {   
                        v[i] = int.Parse(Console.ReadLine());
                        test = false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Valor incorreto, por gentileza insira um número inteiro");
                    }

                 }while(test);
            }

            for(int i = 0; i < 16; i++)
            {
                Console.Write(string.Format("  {0}", v[i]));
            }

        }
    }
}