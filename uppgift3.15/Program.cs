using System;
namespace Uppgift_3_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur länge vill du hyra strögkärran? Det får inte vara i mer än 24h eller mindre än 2h"); 
            Console.WriteLine("Du kan max betala 950 kr / dag, Svara i hela antal timmar");

            int timmar = int.Parse(Console.ReadLine());

            int Summa = (timmar * 80);

            if (Summa > 950)
            {
                Console.WriteLine("Tvärr du får inte hyra bilen så länge");
            }
            else
            {
                Console.WriteLine("Du får hyran kärran och det kommer att kosta dig "  + Summa + "kr");
            }
        }
    }
}
