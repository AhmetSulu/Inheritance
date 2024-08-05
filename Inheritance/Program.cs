using Inheritance;

class Program
{
    static void Main()
    {
        
        Student student = new Student("Ahmet", "Sulu", "17");
        student.DisplayInformation();

        
        Teacher teacher = new Teacher("Melekşen", "Yener", 58.000m);
        teacher.DisplayInformation();
    }
}