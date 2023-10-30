public class Student
{
    public string Name;
    public string Surname;
    public string Group;
    public int Point;
    public bool isGraduated;

    public Student(string name, string surname, string group, int point, bool isgraduated)
    {
        this.Name = name;
        this.Surname = surname;
        this.Group = group;
        this.Point = point;
        this.isGraduated = isgraduated;
    }

    public void FullName()
    {
        
        Console.WriteLine($"Name : {Name} , Surname : {Surname}");
    }

    public void FullInfo()
    {
        Console.WriteLine($"Name : {Name} , Surname : {Surname} , Group : {Group} , Point : {Point} , isGraduated : {isGraduated}");
        if (this.isGraduated==true)
        {
            Console.WriteLine("Mezun olub");
        }
        else
        {
            Console.WriteLine("Mezun olmayib");
            if (this.Point > 80)
            {
                Console.WriteLine("Bal yeterlidir Imtahana gire biler");
            }
            else
            {
                Console.WriteLine("Bal yetersizdir Kesildi");
            }
        }        
    }
}
