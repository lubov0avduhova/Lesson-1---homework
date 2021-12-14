
Console.WriteLine("Привет! Давай заполним анкету.\nКак тебя зовут?");
string name = Console.ReadLine ();
Console.WriteLine($"Привет, {name}. Приятно познакомится!\nА какая у тебя фамилия?");
string lastName = Console.ReadLine ();
Console.WriteLine ($"Получается, тебя зовут {name} {lastName}");

Console.WriteLine ("А какой у тебя возраст?");
int age = int.Parse(Console.ReadLine());


Console.WriteLine ("А какой у тебя рост?");
double height = double.Parse(Console.ReadLine());

Console.WriteLine ("А какой вес?");
double weight = double.Parse(Console.ReadLine());

// а) используя склеивание
Console.WriteLine ("Хочешь покажу результат в виде склеивания?");
string final = "Имя и фамилия: " + name + " " + lastName + "." + " Возраст: " + age + ". Рост: " + height + " Вес: " + weight;
Console.WriteLine (final);

// б) используя форматированный вывод
// Console.WriteLine ("А сейчас в форматированном выводе");
// Console.WriteLine("Имя и фамилия: " + name + " " + lastName + ". Возраст {0}, рост {1:F2}, вес {2:F2}", age, height, weight);

// в) используя вывод со знаком $
//Console.WriteLine ($"Хочешь покажу результат? Тебя зовут: {name}{lastName}.\nРост у тебя: {height}. А вес: {weight}");
