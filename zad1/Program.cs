int num_increasing = 1;
Console.Write("Rosnące: ");
while (num_increasing <= 10)
{
    Console.Write($"{num_increasing++} ");
}
Console.WriteLine();

int num_decreasing = 10;
Console.Write("Malejące: ");
do
{
    Console.Write($"{num_decreasing--} ");
}
while (num_decreasing >= 0);
Console.WriteLine();

Console.Write("Parzyste: ");
for (int num_even = 0; num_even <= 20; num_even++)
{
    Console.Write($"{num_even++} ");
} 
Console.WriteLine();