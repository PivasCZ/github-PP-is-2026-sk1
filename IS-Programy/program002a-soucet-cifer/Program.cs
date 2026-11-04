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
        int number;
        while(!int.TryParse(Console.ReadLine(), out number))   {
            Console.Write("Nezadali jsme celé číslo. Zadejte číslo znovu: ");
            
    }
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
    int numberbc = number;
    int sum = 0;    //neutrální hodnota pro sčítání je 0, ale pro součet je to 1
    int digit;      // Proměnná pro ukládání právě zjistěné číslice
       
    // ošetřšní záporných čísel (znaménko nemá vliv na číslici)
    if(number < 0)  {
        number = -number;
    }

    //zvláštní případ pro 0
    if (number == 0)    {
        sum = 0;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Průběh rozkladu čísla na číslice (zprava)");

        // Matematický rozklad
        // využití oprerace Modulo - určení zbytku po celočíselném dělení
        while (number >0)
        {
            digit = number %10;     // Operace Modulo 10 - získáme poslední číslici
            sum = sum + digit;      // získánou číslici přičteme k sum

            Console.WriteLine($"Získaná číslice: {digit}");

            number = number/10; // celočíselné dělení deseti odstanění poslední číslice
        }
    }

    //výpis výsledku
        Console.WriteLine();
        Console.WriteLine("=======================");
        Console.WriteLine($"Součet číslic čísla {numberbc} je: {sum}");
        Console.WriteLine("=======================");
        Console.WriteLine(); 

        //Dotaz směrem k uživateli na opakovaní
        Console.WriteLine();
        Console.Write("Pro opakovaní programu stiskněte klavesu A. Poté potvrďte klavesou Enter: ");
        again = Console.ReadLine() ?? "";

      
        
}