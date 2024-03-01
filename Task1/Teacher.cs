namespace Task1;

public class Teacher:Person
{
public void Explain()
{
   System.Console.WriteLine("The teacher is explaining"); 
} 
public Teacher(string name):base(name)
{
    Name=name;
}
}
