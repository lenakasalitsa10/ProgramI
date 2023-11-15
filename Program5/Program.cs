namespace Zadanie5;
class Program 
static void Main(string[] args)
{
    string fullnamesportsman;
    int time;
    
    try
    {
        Console.Wrate($"Требуется ввести ФИО спортсмена");
        string fullnamesportsman = Console.ReadLine();
        Console.Wrate($"Требуется ввести время спортсмена");
        int time = (int)Console.ReadLine();

        if (time == 0)
        {
            throw new InvalidTimeExpection("Время должно быть больше нуля");
        }
        else
        {
            
        }
    }
}