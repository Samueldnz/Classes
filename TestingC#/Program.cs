using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Word");

            //Variables
            byte number = 255;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Samuel";
            bool isWorking = true;
            const float PI = 3.14f;

            //Output das variáveis
            Console.WriteLine(number);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(PI);

            //Soma de dois double
            double number4 = 4.014789; 
            double number5 = 5.832983;
            Console.WriteLine(number4 + number5);

            //Converter uma string para int
            string IDK = "1234";
            int i = Convert.ToInt32(IDK); //32 bits

            //Casting
            byte b = (byte)i;   // 0 ou 1 // 00000000 -> 11111111
            Console.WriteLine(i);

            //Incremento e decremento 
            int count = 10; 
            int count2 = count++;  //count2 = 10, count = 11

            Console.WriteLine(count2);
            Console.WriteLine(count);
            
            int count3 = ++count; //count = 12, count3 = 12

            Console.WriteLine(count);
            Console.WriteLine(count3);

            //Exception
            try
            {
                string str = "9876";
                byte a = Convert.ToByte(str);
                Console.WriteLine(a);
            }
            catch (Exception)
            {
                //Fake Exception
                Console.WriteLine("Não foi possível converter");
            }

            Console.WriteLine("{0} até {1}", byte.MinValue, byte.MaxValue);
        }
    }
}
