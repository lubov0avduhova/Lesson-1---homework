// Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле

Console.WriteLine ("Привет! Сейчас мы посчитаем твой индекс массы тела, только перед этим напиши свой вес в киллограммах: ");
double weight = double.Parse(Console.ReadLine());
Console.WriteLine ("А теперь рост в метрах: ");
double height = double.Parse(Console.ReadLine());

double result = (height * height) / weight;
Console.WriteLine ("Отлично! Твой индекс массы тела: {0:F2}", result);
