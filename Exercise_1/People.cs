namespace CSharp_Test.Exercise_1;

public class People
{
    public string Name { get; set; }
    
    public bool Gender { get; set; }
    
    public int Age { get; set; }

    public People(string name, bool gender, int age)
    {
        Name = name;
        Gender = gender;
        Age = age;
    }
    
    public void DisplayOutput()
    {
        Console.WriteLine("Simple Properties Demo");
        Console.WriteLine($"Person details: Name = {Name}, Gender = {(Gender ? "Male" : "Female")}, Age = {Age}");
        Age += 10;
        Console.WriteLine($"Person details (apter incrementing age): Name = {Name}, Gender = {(Gender ? "Male" : "Female")}, Age = {Age}");
    }
}