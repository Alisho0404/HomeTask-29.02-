namespace Task2;

public class Photobook:PhotoBookTest
{
private int numPages; 
public int GetNumberPages(int numPages)
{
     this.numPages=numPages; 
     return numPages;
} 
 
public Photobook(int numPages):base()
{
    numPages=16;
}
}
