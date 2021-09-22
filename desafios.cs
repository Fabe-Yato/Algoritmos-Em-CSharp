using System;

namespace aula_4_facul
{
    class Program
    {
        public static void p1001(){
            Console.Write("\n");
             int A, B, X;
             A = Convert.ToInt32(Console.ReadLine());

             B = Convert.ToInt32(Console.ReadLine());
             X = A + B;
             Console.Write("\nX = {0}", X);
             Console.Write("\nFIM");
        }
        public static void p1002(){
            Console.Write("\n");
            double pi = 3.14159;
            double raio = Convert.ToDouble(Console.ReadLine());
            double area = pi * (Math.Pow(raio,2));
            //area.ToString(0.0000) tbm funciona para 4 casas decimais
            Console.Write("\nA = {0}\n", Math.Round(area,4));
            Console.Write("\nFIM"); 
        }
        public static void p1003(){
            Console.Write("\n");
            int a, b, SOMA;
            a = Convert.ToInt32(Console.ReadLine());

            b = Convert.ToInt32(Console.ReadLine());

            SOMA = a + b;
            Console.Write("\nSOMA = {0}", SOMA);
            Console.Write("\nFIM");
        }
        public static void p1004(){
            Console.Write("\n");
            int a,b,PROD;

            a = Convert.ToInt32(Console.ReadLine());

            b = Convert.ToInt32(Console.ReadLine());

            PROD = a * b;
            Console.Write("\nPROD  = {0}", PROD);
            Console.Write("\nFIM");
        }
        public static void p1010(){
            Console.Write("1010");
        }
        static void Main(string[] args)
        {
            int prog;
            do{
            Console.Write("\n\t| 0 para sair |\nDigite o programa desejado: ");
            prog = Convert.ToInt32(Console.ReadLine());

            if(prog == 0){
                Console.Write("\nSaindo...");
                break;
            }

            switch(prog){
                case 1001:
                  Console.Write(prog);
                  Program.p1001();
                  break;

                case 1002:
                  Console.Write(prog);
                  Program.p1002();
                  break;

                case 1003:
                  Console.Write(prog);
                  Program.p1003();
                  break;
                case 1004:
                  Console.Write(prog);
                  Program.p1004();
                  break;

                case 1010:
                  Console.Write(prog);
                  Program.p1010();
                  break;

                default:
                  Console.Write("\n\tValor inválido\n");
                  break;
            }
            }while(prog != 0);
            
        }
    }
}
