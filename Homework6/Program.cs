/**       
 *--------------------------------------------------------------------
 * 	   File name: Homework6
 * 	Project name: Homework6
 *--------------------------------------------------------------------
 * Author’s name and email:	Christian Rock / rockcm@etsu.edu		
 *          Course-Section: Intro to Computer Science 1250
 *           Creation Date: 03/21/22		
 * -------------------------------------------------------------------
 */



// method 1 call
ShowCharacter("chris", 1); 

//method 2 call
double wholesale;
System.Console.WriteLine("What is the wholesale Price?");
wholesale = Convert.ToDouble(Console.ReadLine());

double markup; 
System.Console.WriteLine("What is the Markup percent?");
markup = Convert.ToDouble(Console.ReadLine());

System.Console.Write($"The wholesale price is {wholesale}$ and the markup is {markup}%, so the retail price is "); CalculateRetail(wholesale, markup);

// method 3 call
for (int i = 80; i < 101; i++) 
{
   System.Console.WriteLine($"{i}F"); 
   System.Console.WriteLine("is equal to");
   System.Console.Write(Celsius(i));Console.WriteLine("C");
   Console.WriteLine();
}

//Method 4 call

System.Console.WriteLine(IsPrime(23));






static void ShowCharacter(string something, int x)
{
    Console.WriteLine(something[x - 1]); 
}



static void CalculateRetail(double price, double markup)
{
    System.Console.WriteLine($"{price * (markup/100) + price}$");

} 

static int Celsius(int temp)
{
   return (temp - 32) * 5/9;
}

static bool IsPrime(int number)
{
    for(int i = 2; i < number; i++)

    if(number % i == 0)
        {
          return false;
        }
        
    return true;
}


