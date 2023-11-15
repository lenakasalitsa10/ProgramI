namespace Zadanie5;
class Program
{
    static void Main(string[] args)
    {
        int sportsmanTime = 0;
        Console.Write($"Требуется ввести ФИО спортсмена  ");
            string namesportsman = Console.ReadLine();
            Console.Write($"Требуется ввести время спортсмена  ");
        try
        {
            var inputTime = Console.ReadLine();
            if(string.Compare(inputTime,"0")== 0){
                throw new Problem();
            }
            else{
                 sportsmanTime = Convert.ToInt32(inputTime);
            }
            // int times = Convert.ToInt32(Console.ReadLine());

            // if (times == 0)
            // {
            //     throw new Problem("Время должно быть больше нуля");
            // }
            // else
            // {
            
            // }
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            Console.WriteLine($"Программа завершила работу {namesportsman}, {sportsmanTime}");
        }
    }
}