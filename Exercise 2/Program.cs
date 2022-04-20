int x1 = Cordinate("x", "1");
int y1 = Cordinate("y", "1");
int c1 = Cordinate("c", "1");
int x2 = Cordinate("x", "2");
int y2 = Cordinate("y", "2");
int c2 = Cordinate("c", "2");

double numberX = Convert.ToDouble(Kvadrat(x1, x2));
double numberY = Convert.ToDouble(Kvadrat(y1, y2));
double numberC = Convert.ToDouble(Kvadrat(c1, c2));
double r = Math.Round(Math.Sqrt(numberX + numberY + numberC), 2);
Console.WriteLine(r);


int Cordinate(string coorName, string pointName)
{
    Console.WriteLine($"Введинте {coorName} точки {pointName}");
    return Convert.ToInt32(Console.ReadLine());
}

double Kvadrat(double k1, double k2)
{
    double result = Math.Pow((k1 - k2), 2);
    return result;
}