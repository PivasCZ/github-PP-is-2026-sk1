string again = "a";

// Řídící ciklus programu
// ToLower() převede vstup na malá písmena, takže program nerozlišuje a nebo A spustí se při obojím 
// jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a")
{
    Console.Clear();
        Console.WriteLine("***********************************");
        Console.WriteLine("**Generátor pseudonáhorných čísel**");
        Console.WriteLine("***********************************");
        Console.WriteLine("************Petr Pivoňka***********");
        Console.WriteLine("***********************************");
    
    // načtení počet náhorných čísel (větší než nula)
        Console.Write("Zadejte počet generevaných čísel (přirozené číslo): ");
        int n;
        while(!int.TryParse(Console.ReadLine(), out n) || n <= 0)   {
            Console.Write("Nezadali jste přirozené číslo. Zadejte číslo znovu: ");
        
    }
    // načtení dolní meze
        Console.Write("Zadejte dolní mez generátoru (celé číslo): ");
        int lowerbound;
        while(!int.TryParse(Console.ReadLine(), out lowerbound))   {
            Console.Write("Nezadali jsme celé číslo. Zadejte druhé číslo znovu: ");
            
    }
     // načtení horní meze
        Console.Write("Zadejte horní mez generátoru (celé číslo větší nebo rovno hodnotě dolní meze): ");
        int upperbound;
        while(!int.TryParse(Console.ReadLine(), out upperbound)|| upperbound < lowerbound)   {
            Console.Write("Nezadali jsme celé číslo. Zadejte druhé číslo znovu: ");
    }
        Console.WriteLine();
        Console.WriteLine("=======================");
        Console.WriteLine($"počet generovaných čísel: {n}");
        Console.WriteLine($"Dolní mez: {lowerbound}");
        Console.WriteLine($"Horní mez: {upperbound}");
        Console.WriteLine("=======================");
        Console.WriteLine(); 
    // zde bude konkréntní algoritmus
       
        //Dotaz směrem k uživateli na opakovaní
        Console.WriteLine();
        Console.Write("Pro opakovaní programu stiskněte klavesu A. Poté potvrďte klavesou Enter: ");
        again = Console.ReadLine() ?? "";

      
        
}