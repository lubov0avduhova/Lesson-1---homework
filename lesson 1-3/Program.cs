// Написать программу, которая подсчитает расстояние между точками с координатами

Console.WriteLine ("Подсчитаем расстояние между точками с координатами.\nВведи х1:");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine ("А теперь y1");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine ("А теперь x2");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine ("А теперь y2");
double y2 = double.Parse(Console.ReadLine());



double result = Math.Sqrt(Math.Pow (x2-x1, 2)+Math.Pow(y2-y1, 2));
Console.WriteLine ("Отлично! Результат: {0:F2}", result);
