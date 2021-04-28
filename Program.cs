using System;

namespace Uebung_Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            string strZahl1;
            string strZahl2;
            int intZahl1;
            int intZahl2;
            int intSumme;
            Console.WriteLine("Mein erster Taschenrechner!");
            Console.Write(" erste Zahl -> ");
            strZahl1 = Console.ReadLine();
            Console.Write("zweite Zahl -> ");
            strZahl2 = Console.ReadLine();
            intZahl1 = Convert.ToInt32(strZahl1);
            intZahl2 = Convert.ToInt32(strZahl2);
            intSumme = intZahl1 + intZahl2;
            Console.WriteLine("Nach Adam und Eva ergibt das {0}",intSumme);
            Console.ReadLine();
        }

    }
}
