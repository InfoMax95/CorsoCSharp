// See https://aka.ms/new-console-template for more information
// Con .NET6 possiamo anche solo scrivere il corpo del metodo Main
// senza inserire tutto il codice della classe e il namespace

using CorsoCSharp;

//Console.WriteLine("Hello, World!");
//Console.Read();

// TRY & CATCH & FINALLY
Console.WriteLine("Inserisci un numero: ");
string? numero = Console.ReadLine();
int num = 0;
try
{
   num = int.Parse(numero);
} 
catch (FormatException)
{
    // throw serve per lanciare l'errore
    //throw;
    Console.WriteLine("Inserisci un numero valido");
} 
catch (OverflowException)
{
    Console.WriteLine("Il numero non deve essere long");
}
finally
{
    Console.WriteLine("Io lo scrivo a prescindere");
}
Console.WriteLine(num + 2);

Operation operation = new Operation();
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, -20, -90 };
Console.WriteLine($"La somma dei numeri è: {operation.Sum(array)}");
for(int i = 0; i < operation.negNumbers.Count; i++)
{
    Console.WriteLine($"Ecco i numeri negativi raccolti:  {operation.negNumbers[i]}");
}

Studente studente1 = new Studente("Matteo", "Rossi", 25, "matematica");
studente1.Saluta();
