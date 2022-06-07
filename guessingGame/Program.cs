
var randonum = new Random().Next(1, 10);
//Console.WriteLine("Secret Number is:" + randonum);  //Tells the user the secret number
for (var i = 0; i < 5; i++)
{
    Console.WriteLine("Please Enter in a Number from 1 - 10");
    var guess = Convert.ToInt32(Console.ReadLine());

    if (guess == randonum)
    {
        Console.WriteLine("You Correct! The secret number was: " + randonum + "!!!");
        return;
    }
}
Console.WriteLine("You failed to correctly guess the secret number. :(");
Console.WriteLine("The secret Number was: " + randonum);
