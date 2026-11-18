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

    // Deklarce a alokace pole v paměri
    int[] myRanNumbs = new int[n];   

    // inicializace generátoru náhodných čísel
    Random myRanNumb = new Random();
    //Random myRanNumb = new Random(50);

    int positive = 0;
    int negativ = 0;
    int zeros = 0;
    int even = 0;
    int odd = 0;
    // Generování náhorných čísel a uložení do pole
    Console.WriteLine("Vygenerovaná pseudonáhorná čísla:");
    for (int i = 0; i < myRanNumbs.Length; i++)
    {
        myRanNumbs[i] = myRanNumb.Next(lowerbound, upperbound + 1);
        Console.Write($"{myRanNumbs[i]}; ");
        /*if (myRanNumbs[i] < 0)
            negativ++;
        if (myRanNumbs[i] > 0)
            positive++;
        if (myRanNumbs[i] == 0)
            zeros++; */
        //efektivnější způsob
        if (myRanNumbs[i] < 0)
            negativ++;
        else if (myRanNumbs[i] > 0)
            positive++;
        else 
            zeros++;
        if (myRanNumbs[i]% 2 == 0)
            even++;
        else
            odd++;

    }
    Console.WriteLine();
    Console.WriteLine("=======================");
    Console.WriteLine($"Počet záporných čísel z generátoru: {negativ}");
    Console.WriteLine($"Počet kladných čísel z generátoru: {positive}");
    Console.WriteLine($"Počet nul z generátoru: {zeros}");
    Console.WriteLine($"Počet sudých čísel z generátoru: {even}");
    Console.WriteLine($"Počet lichých čísel z generátoru: {odd}");
    Console.WriteLine("=======================");
    Console.WriteLine();
    


        //Dotaz směrem k uživateli na opakovaní
        Console.WriteLine();
        Console.Write("Pro opakovaní programu stiskněte klavesu A. Poté potvrďte klavesou Enter: ");
        again = Console.ReadLine() ?? "";

      
        
}