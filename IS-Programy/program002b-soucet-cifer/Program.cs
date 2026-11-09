string again = "a";

// Řídící ciklus programu
// ToLower() převede vstup na malá písmena, takže program nerozlišuje a nebo A spustí se při obojím 
// jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a")
{
    Console.Clear();

        Console.WriteLine("**********************************");
        Console.WriteLine("***********Součet cifer***********");
        Console.WriteLine("**********************************");
        Console.WriteLine("***********Petr Pivoňka***********");
        Console.WriteLine("**********************************");
    
    // načtení hodnot
        Console.Write("Zadejte číslo (celé číslo): ");
        string number = Console.ReadLine();
            
    
    /*    Console.Write("Zadejte druhé číslo (celé číslo): ");
        int YYY;
        while(!int.TryParse(Console.ReadLine(), out YYY))   {
            Console.Write("Nezadali jsme celé číslo. Zadejte druhé číslo znovu: ");
            
    }*/
        Console.WriteLine();
        Console.WriteLine("=======================");
        Console.WriteLine($"Zadané číslo: {number}");
        Console.WriteLine("=======================");
        Console.WriteLine(); 
        
    // zde bude konkréntní algoritmus

    //příprava pomocných proměnných pro výpočet
    string numberbc = number;
    int sumsoucet = 0;    //neutrální hodnota pro sčítání je 0, ale pro součet je to 1
    int sumsoucin = 1;  //neutrální hornota pro součet
    //int digit;      // Proměnná pro ukládání právě zjistěné číslice
       
    // ošetřšní záporných čísel (znaménko nemá vliv na číslici)
    if (number.StartsWith("-"))
{
    number = number.Substring(1);
}

    //zvláštní případ pro 0
    if (number == "0")    {
        sumsoucet = 0;
        sumsoucin = 0;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Průběh rozkladu čísla na číslice (Zleva)");

        // textový rozklad
        foreach (char znak in number)
{
    int digit = znak - '0';
    Console.WriteLine($"získaná číslice {digit}");
    sumsoucet+= digit;
    sumsoucin*= digit;
}
    }    

    //výpis výsledku
        Console.WriteLine();
        Console.WriteLine("=======================");
        Console.WriteLine($"Součet číslic čísla {numberbc} je: {sumsoucet}");
        Console.WriteLine($"Součin číslic čísla {numberbc} je: {sumsoucin}");
        Console.WriteLine("=======================");
        Console.WriteLine(); 

        //Dotaz směrem k uživateli na opakovaní
        Console.WriteLine();
        Console.Write("Pro opakovaní programu stiskněte klavesu A. Poté potvrďte klavesou Enter: ");
        again = Console.ReadLine() ?? "";

}     