int waterTemperature = int.Parse(Console.ReadLine());

if  (waterTemperature > 100)
{
    Console.WriteLine("The water is boiling");
}
else if (waterTemperature <= 100)
{
    Console.WriteLine("The water is not hot enough");
}