Console.Clear();

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