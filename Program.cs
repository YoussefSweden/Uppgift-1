using System;

namespace _1._Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAlive = true;           
            while (isAlive)
            {
                Console.WriteLine("Välj hur du vill räkna: " +
                    "\n 1: Addition " +
                    "\n 2: Subtraktion " +
                    "\n 3: Mulitplikation " +
                    "\n 4: Division " +
                    "\n99: Vill inte räkna");
                
                int.TryParse(Console.ReadLine(), out int inMatatVal);
                switch (inMatatVal)
                {
                    case 1:
                        addition();
                        break;
                    case 2:
                        subtraktion();
                        break;
                    case 3:
                        multiplikation();
                        break;
                    case 4:
                        division();
                        break;
                    case 99:
                        isAlive = false;
                        break;

                    default:
                        Console.WriteLine("Fel val, försök igen");
                        break;
                }                
            }            
        }
        static void addition()
        {
            Console.WriteLine("mata in första talet!");
            double tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("mata in andra talet!");        
            double tal2 = double.Parse(Console.ReadLine());
            Console.WriteLine("summan av talen är: "+(tal1+tal2));
        }
        static void subtraktion()
        {
            Console.WriteLine("mata in ett första talet!");
            double tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("mata in ett andra talet!");
            double tal2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Differensen mellan talen är: " + (tal1 - tal2));
        }
        static void multiplikation()
        {
            Console.WriteLine("mata in första talet");
            double tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("mata in andra talet!");
            double tal2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Talens produkt är: " + (tal1*tal2));
        }
        static void division()
        {
            Console.WriteLine("mata in täljaren");
            double tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("mata in  nämnaren!");
            double tal2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Kvoten mellan talen är: " + Math.Round((tal1/tal2),2));
        }
    }
}
