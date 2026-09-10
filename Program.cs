Console.Clear();
//Zackary Santos
//Last Saved: 9/10/2026 8:05 AM
//Mini Challenge #4 - Greater Than or Less Than
//I asked the user to input 2 numbers and then the console will compare them both
//Peer Review name:
//Review:

Console.WriteLine("Enter your first number: ");

string firstNumber = Console.ReadLine();

Console.WriteLine("Enter your second number: ");

string secondNumber = Console.ReadLine();

int newFirstNumber = Convert.ToInt32(firstNumber);
int newSecondNumber = Convert.ToInt32(secondNumber);

//First Number
if (newFirstNumber > newSecondNumber)
{
    Console.WriteLine(newFirstNumber + " is way bigger than " + newSecondNumber);
}
else if (newFirstNumber < newSecondNumber)
{
    Console.WriteLine(newFirstNumber + " is way smaller than " + newSecondNumber);
}
else
{
    Console.WriteLine(newFirstNumber + " is also equal to " + newSecondNumber);
}

//Second Number
if (newSecondNumber > newFirstNumber)
{
    Console.WriteLine(newSecondNumber + " is way bigger than " + newFirstNumber);
}
else if (newSecondNumber < newFirstNumber)
{
    Console.WriteLine(newSecondNumber + " is way smaller than " + newFirstNumber);
}
else
{
    Console.WriteLine(newSecondNumber + " is also equal to " + newFirstNumber);
}