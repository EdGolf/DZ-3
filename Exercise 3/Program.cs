Console.WriteLine("Введите число N: ");
double n = Convert.ToDouble(Console.ReadLine());
double index = 1;

while (index <= n)
{
    Console.WriteLine(Kub(index));
    index++;
}
if (n < 0)
    Console.WriteLine("Число N должно быть > 0!!!");
    
double Kub(double x)
{
   return  Math.Pow(x, 3);
}