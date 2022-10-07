Console.WriteLine("Для вычисления точки пересечения y=k1*x+b1 и y=k2*x=b2");
Console.WriteLine("введите значения b1 b2 k1 k2");
double b1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());
double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;
Console.WriteLine("Точка пересечения с координатами Х=" + x + "   Y=" + y);