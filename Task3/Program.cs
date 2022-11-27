// Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).


void CheckFindKoord(int x)
{
    if (x == 1) Console.WriteLine("Диапазон равен x > 0 y > 0");
    else if (x == 4) Console.WriteLine("Диапазон равен x > 0 y < 0");
    else if (x == 2) Console.WriteLine("Диапазон равен x < 0 y > 0");
    else if (x == 3) Console.WriteLine("Диапазон равен x < 0 y < 0");
}

string CheckFindKoord2(int x)  //это функция возвращаемая
{
    string res;
    if (x == 1) res = "Диапазон равен x > 0 y > 0";
    else if (x == 4) res = "Диапазон равен x > 0 y < 0";
    else if (x == 2) res = "Диапазон равен x < 0 y > 0";
    else if (x == 3) res = "Диапазон равен x < 0 y < 0";
    else res = "Введите число от 1 до 4";
    return res; //обязательная строка
}
try
{
    Console.WriteLine("Введите номер четверти");
    int x = Convert.ToInt32(Console.ReadLine());
    CheckFindKoord(x);
    Console.WriteLine(CheckFindKoord2(x));
}
catch
{
    Console.WriteLine("Введите число от 1 до 4");
}