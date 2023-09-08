// See https://aka.ms/new-console-template for more information
int[,] array = new int[4,4];
int vin = 0;
int first, second, one, two;
array[0,0] = 1;
array[0, 1] = 4;
array[0, 2] = 7;
array[0, 3] = 5;
array[1, 0] = 2;
array[1, 1] = 16;
array[1, 2] = 10;
array[1, 3] = 11;
array[2, 0] = 15;
array[2, 1] = 6;
array[2, 2] = 8;
array[2, 3] = 12;
array[3, 0] = 3;
array[3, 1] = 13;
array[3, 2] = 14;
array[3, 3] = 9;

for (; vin < 1;)
{
    Console.WriteLine($"{array[0, 0]} {array[0, 1]} {array[0, 2]} {array[0, 3]}");
    Console.WriteLine($"{array[1, 0]} {array[1, 1]} {array[1, 2]} {array[1, 3]}");
    Console.WriteLine($"{array[2, 0]} {array[2, 1]} {array[2, 2]} {array[2, 3]}");
    Console.WriteLine($"{array[3, 0]} {array[3, 1]} {array[3, 2]} {array[3, 3]}");
    if ((array[0, 0] == 1) && (array[0, 1] == 2) && (array[0, 2] == 3) && (array[0, 3] == 4) && (array[1, 0] == 5) && (array[1, 1] == 6) && (array[1, 2] == 7) && (array[1, 3] == 8) && (array[2, 0] == 9) && (array[2, 1] == 10) && (array[2, 2] == 11) && (array[2, 3] == 12) && (array[3, 0] == 13) && (array[3, 1] == 14) && (array[3, 2] == 15) && (array[3, 3] == 16))
    {
        vin = 1;
        break;
    }
    Console.WriteLine("Введите номер числа, которое хотите передвинуть: ");
    first = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число на местого которого поставите другое число: ");
    second = int.Parse(Console.ReadLine());
    if ((first - second == 1) || (first - second == -1) || (first - second == -10) || (first - second == 10))
    {
        one = array[first / 10 - 1, first % 10 - 1];
        two = array[second / 10 - 1, second % 10 - 1];
        array[first / 10 - 1, first % 10 - 1] = two;
        array[second / 10 - 1, second % 10 - 1] = one;
    }
    else
    {
        Console.WriteLine("Нельзя поменять местами эти числа");
    }
}
Console.WriteLine("Вы победили");
    


