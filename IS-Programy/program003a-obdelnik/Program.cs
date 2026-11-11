using System.Threading.Tasks.Dataflow;
using System.Xml;

string again = "a";

// Řídící ciklus programu
// ToLower() převede vstup na malá písmena, takže program nerozlišuje a nebo A spustí se při obojím 
// jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a")
{
    Console.Clear();
        Console.WriteLine("**********************************");
        Console.WriteLine("******Vykreslení obdelníku********");
        Console.WriteLine("**********************************");
        Console.WriteLine("***********Petr Pivoňka***********");
        Console.WriteLine("**********************************");
    
    // načtení hodnot
        Console.Write("Zadejte šířku obdelníku (celé kladné číslo): ");
        int width;
        while(!int.TryParse(Console.ReadLine(), out width) || width <= 0)   {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Šířka musí být celé kladné číslo, které je větší jak 0. Zadejte číslo znovu: ");
            Console.ResetColor();
    }
        Console.Write("Zadejte výšku obdelníku (celé kladné číslo): ");
        int height;
        while(!int.TryParse(Console.ReadLine(), out height) || height <= 0)   {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Výška musí být celé kladné číslo, které je větší jak 0. Zadejte číslo znovu:");
            Console.ResetColor();
    }
        Console.WriteLine();
        Console.WriteLine("=======================");
        Console.WriteLine($"Obdelník o rozměrech šířka: {width} a výšky: {height}");
        Console.WriteLine("=======================");
        Console.WriteLine(); 
    // zde bude konkréntní algoritmus
       
    //vnější cyklus počítá řadky
    for (int i = 1; i <= height; i++)
    {
        if(i % 2 == 0){
            Console.ForegroundColor = ConsoleColor.Blue;
        }
            else{
            Console.ForegroundColor = ConsoleColor.Green;
        }
        //vnitřní cyklus, který se postará aby se na každém řádku byl správný pořet *
        for (int j = 1; j <= width; j++)
        {

        Console.Write("* ");   
        // Efekt animace vykreslování
        System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); 
        
        }
        // writeline který se stará o výšku obdelníku
        Console.WriteLine();
        Console.ResetColor();
    }


        //Dotaz směrem k uživateli na opakovaní
        Console.WriteLine();
        Console.Write("Pro opakovaní programu stiskněte klavesu A. Poté potvrďte klavesou Enter: ");
        again = Console.ReadLine() ?? "";

      
        
}