string drinkType = Console.ReadLine();
string extra = Console.ReadLine();
double price = 0;
if (drinkType == "coffee")
{
     price = 1.00;
}
else if (drinkType == "tea")
{ 
     price = 0.60;
}
if (extra == "sugar")
{ 
    price = price + 0.40;
}
Console.WriteLine($"Final price: ${price:F2}");