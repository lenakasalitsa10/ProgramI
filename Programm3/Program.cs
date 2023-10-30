namespace Program3;    //помещаем класс в пространство имён

class Program        //главный класс
{
    static void Main(string[] args)      //начало программы
    {
        var testSt = new Student("Каренина Анна Аркадьевна");     //создаём фио
        var testSubj = new Subject("Мировая культура");           //создаём предмет
        var exam = new Exam<Student,Subject>(testSt,testSubj);    //создаём экземпляр объекта класса exam
        exam.ExamS();     //вызываем функцию для класса экзамен
    }
}
