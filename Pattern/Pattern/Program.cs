// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Enter a number");
int x = Convert.ToInt32(Console.ReadLine());
for (int i = x; i >0; i--)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("6");
    }
    Console.WriteLine();
}
