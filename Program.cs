using System;

namespace reajustodesalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;
            double salarionovo = 0;
            Console.WriteLine("efetue o reajuste salarial");
            for (int i = 0; i < 3; i++);
           {
            Console.Write ("informe o salario: ");
            salario = Convert.ToDouble(Console.ReadLine());
            if (salario <= 300)
            { //50%
            salarionovo = salario * 1.50;
            }
            else
            { //30%
            salarionovo = salario + ((salario * 30) / 100);   
            }
            Console.WriteLine("salario reajuste: " + salarionovo);
            Console.ReadKey();
                
            }
        
                
            
        }
    }
}


    

