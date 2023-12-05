namespace Zadanie5;

public class Problem : Exception    //объявление класса Problem, который наследуется от класса Exception
{
    public Problem() : base("Время не может равняться 0")   //конструктор
    {
    }
}
