namespace Task3;

public abstract class Animal
{
public string Name { get; set; } 

public void SetName(string name)
{
Name=name;
System.Console.WriteLine(Name);
} 
public string GetName()
{
return Name;
} 
public virtual void Eat()
{
    System.Console.WriteLine("Dog is eating");
}
}
