namespace Program3;    //помещаем класс в пространство имён

public class Exam<Subj,Obj> where Subj : Student   //обобщённый класс exam с параметрами студент и предмет
                            where Obj: Subject{
    public Exam(Subj student, Obj subject)     //конструктор
    {
        Student = student;
        Subject = subject;
    }

    public Subj Student { get; set; }     //свойство студент
    public Obj Subject { get; set; }     //свойство предмет
    public void ExamS()   //метод выводящий результат
    {
      Console.WriteLine($"Студентка {this.Student.FullName} сдала экзамен по дисциплине {this.Subject.SubjectName}" );
    }
}