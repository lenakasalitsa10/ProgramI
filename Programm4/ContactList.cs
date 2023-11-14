
namespace Program4; // помещаем класс в пространство имён
public class ContactList: List<Contact>    //создание листа
{
    public IEnumerable<Contact> SortingByA()   //метод SortingByA возвращает перечисление элементов типа Contact
    {
        var print = from p in this   //передаем каждый элемент из данного листа в переменную p
            where p.FullName.StartsWith("А")   //фильтрация ФИО по первой букве А
            orderby p.Number  //упорядочиваем по возрастанию
            select p;   //выбираем объект в данный лист
        return print;   // возвращаем значение
    }
}