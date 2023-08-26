using System;

class TYPEFUEL { 

    class PROGRAM
    {

        static void Main(String[] args)
        {
            int sum,sum1,sum2;
            int value = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;
            sum = 0;
 
            while (value != 4)
            {
                if (value == 1)
                {
                    sum = sum + 1;
                }
                else if (value == 2)
                {
                    
                    sum1 = sum1 + 1;
                }
                else if (value == 3)
                {
                   
                    sum2 = sum2 + 1;
                }
                else { }
                value = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + sum);
            Console.WriteLine("Gasolina: " + sum1);
            Console.WriteLine("Diesel: " + sum2);
        }
    }
}
