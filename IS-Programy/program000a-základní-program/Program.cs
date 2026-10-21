string again = "a";

// Řídící ciklus programu
// ToLower() převede vstup na malá písmena, takže program nerozlišuje a nebo A spustí se při obojím 
// jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a")
{
    Console.Clear();
        Console.WriteLine("**********************************");
        Console.WriteLine("*********Název programu***********");
        Console.WriteLine("**********************************");
        Console.WriteLine("***********Petr Pivoňka***********");
        Console.WriteLine("**********************************");
    
    // načtení hodnot
        Console.Write("Zadejte číslo (celé číslo): ");
        int XXX;
        while(!int.TryParse(Console.ReadLine(), out XXX))   {
            Console.Write("Nezadali jsme celé číslo. Zadejte číslo znovu: ");
            
    }
        Console.Write("Zadejte druhé číslo (celé číslo): ");
        int YYY;
        while(!int.TryParse(Console.ReadLine(), out YYY))   {
            Console.Write("Nezadali jsme celé číslo. Zadejte druhé číslo znovu: ");
            
    }
Console.WriteLine();
        Console.WriteLine("=======================");
        Console.WriteLine($"První číslo: {XXX}");
        Console.WriteLine($"První číslo: {YYY}");
        Console.WriteLine("=======================");
        Console.WriteLine(); 
    // zde bude konkréntní algoritmus
       
        //Dotaz směrem k uživateli na opakovaní
        Console.WriteLine();
        Console.Write("Pro opakovaní programu stiskněte klavesu A. Poté potvrďte klavesou Enter: ");
        again = Console.ReadLine() ?? "";

      
        
}