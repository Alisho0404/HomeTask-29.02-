namespace Task3;

public class Dog:Animal
{ 
    public Dog(string name)
    {
       Name=name;  
    }
    public override void Eat()
    {
         System.Console.WriteLine($"{Name} is eating");
    }
}
