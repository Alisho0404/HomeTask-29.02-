using Task1;

System.Console.WriteLine("Enter 3 name: ");
string name=Console.ReadLine();
string name2=Console.ReadLine(); 
string name3=Console.ReadLine();  



var person1=new Student(name);
var person2=new Student(name2); 
var person3=new Teacher(name3);    

Person [] people=new Person[3]; 
people[0]=new Person(name);
people[1]=new Person(name);
people[2]=new Person(name);  

 person3.Explain();
 person1.Study(); 
 person2.Study(); 


 