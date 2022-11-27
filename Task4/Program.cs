//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

//Расстояние между координатами равно квадратному корню из суммы квадратов разностей координат по каждой оси

//корень из (х2-x1)*(x2-x1)+(y2-y1)*(y2-y1)

//int array = [];
//Console.WriteLine
//array.Length

//int Max(int arg1, int arg2, int arg3)
//{
   // int result = arg1;
   // if(arg2>result) result = arg2;
   // if(arg3>result) result = arg3;
   // return result;
//}


Console.WriteLine($"Введите координату X первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координату Y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите координату X второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координату Y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

double distans = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
Console.WriteLine($"Расстояние между точками равно {distans}");

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// l = √ (x 2 - x 1) 2+ (y 2 - y 1) 2

double Rast(double  x1, double  x2, double y1, double y2)
{
    double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
    return distance;
}

try
{
    Console.Write("Введите координаты x1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координаты x2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координаты y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координаты y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());

    
    Console.WriteLine(Rast(x1, x2, y1, y2));
}

catch
{
    Console.WriteLine("Проверьте правильность ввода данных");
}

