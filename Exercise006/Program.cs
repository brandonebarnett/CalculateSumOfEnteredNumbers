/* Write a program that coninuously asks the user to enter a number or "ok" to exit.
 *  Calculate the sum of all numbers previously entered and display it on the console.*/

string userInput = "";
int sum = 0;

while (!userInput.Equals("ok"))
{
    Console.WriteLine("Please enter a number or type 'ok' to quit.");
    userInput = Console.ReadLine();
    if (userInput.ToLower().Equals("ok"))
        break;
    sum += Convert.ToInt32(userInput);
}
Console.WriteLine("Your sum is: " + sum);