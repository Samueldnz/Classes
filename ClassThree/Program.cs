using System;
using System.Collections;

namespace classThree
{
    class Program
    {
        public static void Main(String[] args) {

            while (true) {

                Console.WriteLine("\n\nQuantos armários? ");
                int contArmarios = int.Parse(Console.ReadLine());
                if (contArmarios < 1) {
                    return;
                }

                int abertos;
            
                abertos = obterArmariosAbertosN2(contArmarios);
                Console.WriteLine("\nO(n^2)");
                Console.WriteLine("Número de armários abertos: " + abertos);
                
                
                abertos = obterArmariosAbertosNLogN(contArmarios);
                Console.WriteLine("\nO(n log n)");
                Console.WriteLine("Número de armários abertos: " + abertos);
                
                
                abertos = obterArmariosAbertosN(contArmarios);
                Console.WriteLine("\nO(n)");
                Console.WriteLine("Número de armários abertos: " + abertos);
                
                
                abertos = obterArmariosAbertosSqrtN(contArmarios);
                Console.WriteLine("\nO(n^0.5)");
                Console.WriteLine("Número de armários abertos: " + abertos);
                
                
                abertos = obterArmariosAbertosConstante(contArmarios);
                Console.WriteLine("\nO(1)");
                Console.WriteLine("Número de armários abertos: " + abertos);
            }
        }

        //O(n²)
        public static int obterArmariosAbertosN2(int n) {

        /* false: armário fechado;
           true: armário aberto */
        bool[] armarios ;  // é null neste momento
        armarios = new bool[n + 1];  // descartaremos a posição 0;
        // O array contém apenas false neste momento (armários todos fechados)

        for (int crianca = 1; crianca <= n; crianca++) {
            for (int armario = 1; armario <= n; armario++) {
                if (armario % crianca == 0) {
                    armarios[armario] = !armarios[armario];
                }
            }
        }

        ArrayList armariosAbertos = new ArrayList();

        for (int armario = 1; armario <= n; armario++) {
            if (armarios[armario]) {
                armariosAbertos.Add(armario);
            }
        }

            return armariosAbertos.Count;
        }

        // O(n log n)
        public static int obterArmariosAbertosNLogN(int n) {
            /* false: armário fechado;
            true: armário aberto */
            bool[] armarios ;  // é null neste momento

            armarios = new bool[n + 1];  // descartaremos a posição 0;
            // O array contém apenas false neste momento (armários todos fechados)

            for (int crianca = 1; crianca <= n; crianca++) {
                for (int armario = crianca; armario <= n; armario += crianca) {
                    armarios[armario] = !armarios[armario];
                }
            }

            ArrayList armariosAbertos = new ArrayList();

            for (int armario = 1; armario <= n; armario++) {
                if (armarios[armario]) {
                    armariosAbertos.Add(armario);
                }
            }

            return armariosAbertos.Count;
        }

        // O(n)
        public static int obterArmariosAbertosN(int n) {

            ArrayList armariosAbertos = new ArrayList();

            for (int armario = 1; armario <= n; armario++) {
                int raiz = (int) Math.Sqrt(armario);
                if (raiz * raiz == armario) {
                    armariosAbertos.Add(armario);
                }
            }

            return armariosAbertos.Count;
        }

        // O(n^0.5)
        public static int obterArmariosAbertosSqrtN(int n) {

            ArrayList armariosAbertos = new ArrayList();

            int i = 1; //base
            int armario = 1;
            while (armario <= n) {
                armariosAbertos.Add(armario);  // armario é quadrado perfeito!
                i++;
                armario = i * i;
            }

            return armariosAbertos.Count;
        }

        //O(1)  -- tempo constante
        public static int obterArmariosAbertosConstante(int n) {
            return (int) Math.Sqrt(n);
        }

    }
}


