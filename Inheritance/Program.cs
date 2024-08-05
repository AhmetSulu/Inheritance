using Inheritance;

class Program
{
    static void Main()
    {
       
        Student student = new Student("Ahmet", "Sulu", "17");
        student.DisplayStudentInformation();

        
        Teacher teacher = new Teacher("Melekşen", "Yener", 58.000m);
        teacher.DisplayTeacherInformation();
    }
}
