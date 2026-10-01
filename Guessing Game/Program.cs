Random random = new Random();
int randomInt = random.Next(1, 100);

bool loop = true;

while (loop = true)
{
    Console.WriteLine("Guess what the number is from 1 to 100: ");
    int guess = int.Parse(Console.ReadLine());

    if (guess == randomInt)
    {
        Console.WriteLine("You guessed correctly");
        break;
    }
    else
    {
        Console.WriteLine("Try again.");
    }
}