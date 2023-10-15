namespace ListContact          //помещаем класс в пространство имён
{
    class Program     //создаём абстрактный класс Program
    {
        static void Main(string[] args)     //начало программы
        {
            Contact zarina = new Contact("Измайлова", "Зарина", "Генадьевна", "89265789257");       //создаём контакты
            Contact katerina = new Contact("Иванова", "Катерина", "Ивановна", "89987650283");       //создаём контакты
            Contact irina = new Contact("Панова", "Ирина", "Александровна", "89153403879");         //создаём контакты
            Contact marina = new Contact("Краймова", "Марина", "Андреевна", "89258371342");         //создаём контакты
            Contact oktyabrina = new Contact("Сокол", "Октябрина", "Никитична", "88657892481");     //создаём контакты

            Console.WriteLine("Выводим результаты работы методов для класса Contact");       //создаём заголовок
            Console.WriteLine(zarina.ToString());            //выод результата работы метода tostring
            Console.WriteLine(zarina.GetFullName());         //выод результата работы метода getfullname
            Console.WriteLine(katerina.ToString());          //выод результата работы метода tostring
            Console.WriteLine(katerina.GetFullName());       //выод результата работы метода getfullname
            Console.WriteLine(irina.ToString());             //выод результата работы метода tostring
            Console.WriteLine(irina.GetFullName());          //выод результата работы метода getfullname
            Console.WriteLine(marina.ToString());            //выод результата работы метода tostring
            Console.WriteLine(marina.GetFullName());         //выод результата работы метода getfullname
            Console.WriteLine(oktyabrina.ToString());        //выод результата работы метода tostring
            Console.WriteLine(oktyabrina.GetFullName());     //выод результата работы метода getfullname
            ContactList list = new ContactList           //создаём лист контактов и туда добляем людей
            {
                 zarina, katerina, irina, marina, oktyabrina,
            };

            Console.WriteLine("Выводим все контакты");   //создаём заголовок
            list.ContactPrint();                         //вызываем метод для вызова всех контактов
            list.SortByFIO();                            //сортируем лист по результатам работы метода getfullname 
            Console.WriteLine("Выводим лист после сортировки");        //создаём заголовок
            list.ContactPrint();                         //выводим лист после сортировки
        }
    }
}
