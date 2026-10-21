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
    Console.Write("Zadej první číslo řady: ");
        int firts = int.Parse(Console.ReadLine());
    
        /*Console.Write("Zadejte první číslo řady (celé číslo): ");
        int firts;
        while(!int.TryParse(Console.ReadLine(), out firts))   {
            Console.Write("Nezadali jsme celé číslo. Zadejte první číslo řady znovu: ");
            
    }*/
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
        //Dotaz směrem k uživateli na opakovaní
        Console.WriteLine();
        Console.Write("Pro opakovaní programu stiskněte klavesu A. Poté potvrďte klavesou Enter: ");
        again = Console.ReadLine() ?? "";
}