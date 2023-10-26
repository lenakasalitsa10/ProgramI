namespace Program3;     //помещаем класс в пространство имён

public class Student    //создаём класс студент
{
    public Student(string fullName)  //конструктор
    {
        if (!string.IsNullOrEmpty(fullName))
        {
            FullName = fullName;
        }
        else
        {
            throw new ArgumentException(null, nameof(fullName));
        }
       
    }

    public string FullName  { get; set; }   //свойство ФИО
}