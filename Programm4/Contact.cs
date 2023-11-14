namespace Program4; // помещаем класс в пространство имён
public class Contact   //создаём класс Contact
{
    public string FullName { get; set;} //задаём свойство класса ФИО
    public string Number {get; set;}  //задаём свойство класса номер

    public Contact(string fullName, string number)   //конструктор класса
    {
        if (string.IsNullOrEmpty(fullName))     //проверка переменной fullName на пустое значение или null с помощь метода string.IsNullOrEmpty()
        {
            throw new ArgumentException(null, nameof(fullName));   //создаём исключение типа ArgumentException с пустым сообщением и именем параметра, которые передаём в конструктор
        }

        FullName = fullName;     //присваеваем значение свойству

        if (string.IsNullOrEmpty(number))      //проверка переменной number на пустое значение или null с помощь метода string.IsNullOrEmpty()
        {
            throw new ArgumentException(null,nameof(number));      //создаём исключение типа ArgumentException с пустым сообщением и именем параметра, которые передаём в конструктор
        }

        Number = number;   //присваеваем значение свойству
    }
}