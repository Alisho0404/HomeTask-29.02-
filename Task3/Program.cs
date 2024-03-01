using System.Runtime.InteropServices;
using Task3;
System.Console.Write("Enter dog name: ");  
string dogName=Console.ReadLine(); 
var dog=new Dog(dogName);  
dog.SetName(dogName);   
dog.Eat();
