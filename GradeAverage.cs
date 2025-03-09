
Console.Write("Enter your grade in Math: ");
int math = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your grade in Science: ");
int science = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your grade in English: ");
int english = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your grade in Hekasi: ");
int hekasi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int average = (math + science + english + hekasi) / 4;
Console.WriteLine("Your average is: " + average);

if(average >= 100)
{
    Console.WriteLine("Invalid");
}
else if (average >= 99)
{
    Console.WriteLine("With highest honor.");
}
else if (average >= 97.99)
{
    Console.WriteLine("With high honor.");
}
else if (average >= 95)
{
    Console.WriteLine("With honors.");
}
else if (average >= 75)
{
    Console.WriteLine("Passed.");
}
else
{
    Console.WriteLine("Sorry, you failed.");
}
