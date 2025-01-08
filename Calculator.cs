// https://github.com/voldiriddle 
// https://github.com/nak3sh
// https://github.com/DevLARLEY

using System;


class felix
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Taschenrechner ");

        Console.WriteLine("Erste Zahl bitte: \n");
        string Zahl1 = Console.ReadLine(); ;
        int Zahl11 = Convert.ToInt32(Zahl1);    
        //Console.WriteLine(Zahl1);

        Console.WriteLine("Zweite Zahl bitte: \n");
        string Zahl2 = Console.ReadLine(); ;
        int Zahl22 = Convert.ToInt32(Zahl2);
        //Console.WriteLine(Zahl2);

        Console.WriteLine($"Erste Zahl: {Zahl1} Zweite Zahl: {Zahl2}");

        Console.WriteLine("Rechensysmbol bitte: (+/-/*//)");
        string symbol = Console.ReadLine();
        //Console.WriteLine(symbol);
        int result;
        switch (symbol)
        {
            case "+":
                result = Zahl11 + Zahl22;
                break;
            case "-":
                result = Zahl11 - Zahl22;
                break;
            case "*":
                result = Zahl11 * Zahl22;
                break;
            case "/":
                if (Zahl22 == 0) { 
                    Console.WriteLine("Man kann nicht durch 0 teilen!");
                    return; }
                else
                    result = Zahl11 / Zahl22;
                break;

            default:
                result = 0;
                break;

        }
        
        Console.WriteLine($"Das Ergebniss ist: {result}");

    }
}
