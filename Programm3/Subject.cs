namespace Program3;       //помещаем класс в пространство имён

public class Subject   //создаём класс предмет
{
    public Subject(string subjectName)   //конструктор
    {
        if (!string.IsNullOrEmpty(subjectName))
        {
            SubjectName = subjectName;
        }
        else
        {
            throw new ArgumentException(null, nameof(subjectName));
        }
    }

    public string SubjectName { get; set; }   //свойство класса
}