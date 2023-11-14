namespace Program4;    //помещаем в пространство имён

class Program    //создаём  класс
{
    static void Main(string[] args)   //начало программы
    {
        Contact anna = new Contact("Анна", "89265419257");               //создаём контакты
        Contact katerina = new Contact("Катерина", "82044676083");       //создаём контакты
        Contact arina = new Contact("Арина", "89326543879");             //создаём контакты
        Contact marina = new Contact("Марина", "89016231342");           //создаём контакты
        Contact oktyabrina = new Contact("Октябрина", "89352627481");    //создаём контакты
        
        var сontactList = new ContactList   //создаём лист контактов и туда добляем людей
        {
            anna,katerina,arina,marina,oktyabrina    //перебор контактов
        };
        
        foreach (var contact in сontactList.SortingByA()) //вызываем метод для всех элементов листа 
        {
            Console.WriteLine($"Контакт: {contact.FullName} {contact.Number}");   //вывод в консоль результата
        }
    }
}