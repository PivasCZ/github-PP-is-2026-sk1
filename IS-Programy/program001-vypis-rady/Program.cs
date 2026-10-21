string again = "a";

// Řídící ciklus programu
// ToLower() převede vstup na malá písmena, takže program nerozlišuje a nebo A spustí se při obojím 
// jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a")
{
    Console.Clear();
        Console.WriteLine("**********************************");
        Console.WriteLine("************Výpis řady************");
        Console.WriteLine("**********************************");
        Console.WriteLine("***********Petr Pivoňka***********");
        Console.WriteLine("**********************************");

    //vstup počáteční hodnoty - špatné řešení
    // Console.Write("Zadej první číslo řady: ");
    //    int firts = int.Parse(Console.ReadLine());
    
        Console.Write("Zadejte první číslo řady (celé číslo): ");
        int firts;
        while(!int.TryParse(Console.ReadLine(), out firts))   {
            Console.Write("Nezadali jsme celé číslo. Zadejte první číslo řady znovu: ");
            
    }
 Console.Write("Zadejte konečné číslo řady (celé číslo): ");
        int last;
        while(!int.TryParse(Console.ReadLine(), out last))   {
            Console.Write("Nezadali jsme celé číslo. Zadejte konečné číslo řady znovu: ");
            
    }



    Console.Write("Zadejte diferenci (kladné celé číslo): ");
        int step;
        while(!int.TryParse(Console.ReadLine(), out step)|| step <=0)
    {
        Console.Write("Nezadali jsme Kladné celé číslo. Zadejte diferenci znovu: ");
    }
         //rekapitulace zadaných hodnot
        Console.WriteLine();
        Console.WriteLine("=======================");
      //  Console.WriteLine($"První číslo: {firts}; První číslo: {last}; První číslo: {step}");
        Console.WriteLine($"První číslo: {firts}");
        Console.WriteLine($"První číslo: {last}");
        Console.WriteLine($"První číslo: {step}"); 
        Console.WriteLine("=======================");
        Console.WriteLine(); 
       
       //výpsi řady
       Console.WriteLine("Výpis číselné řady");
       if(firts <= last)
    {
        
        int current = firts;
        while(current <= last)
        {
            Console.WriteLine(current);
            // Console.Write($"{current}; ");
            // current = current + step;
            // stučnější zápis předchozího řádku
            current += step;
        }
    }
        else
    {

            Console.WriteLine("První číslo je větší než poslední");
            Console.WriteLine("Tento program umí pouze vypsat vzestupnou řadu (od nejmenšího k největšímu)!");
    }

       
        //Dotaz směrem k uživateli na opakovaní
        Console.WriteLine();
        Console.Write("Pro opakovaní programu stiskněte klavesu A. Poté potvrďte klavesou Enter: ");
        again = Console.ReadLine() ?? "";

      
        
}