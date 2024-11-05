string [] frutas = {"Melancia", "Caranbola", "Naracujá", "Morango", "Limão", "Jabuticaba", "Abacate", "Kiwi", "Acerola", "Pinha", "Lichia", "Pitaya", "Pêssego", "Banana"};
Console.Write($"Sua sacola contém {frutas.Length} frutas:");

foreach (string f in frutas){
    Console.Write($"{f}, ");
    
}

Console.WriteLine();
