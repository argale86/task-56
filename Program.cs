//Найти номер строки с наибольшей суммой элементов
Console.WriteLine("Введите кол-во элементов по горизонтали в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во элементов по вертикали в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
int [ , ] mas = new int [m,n];
Random rnd = new Random();
for (int count1 = 0; count1 < m; count1++)
{
    for (int count2 = 0; count2 < n; count2++)
    {
        mas[count1,count2] = rnd.Next(-15, 15);
        Console.Write(" " + mas[count1,count2] + " ");
    }
    Console.WriteLine();
}

int m1 = mas.GetUpperBound(0) + 1;
int n1 = mas.Length / m1;
int max = 0;
int sum = 0;
int buf = 0;
for (int count3 = 0; count3 < m1; count3++)
{
   // Console.WriteLine("count3 = " + count3);
    for (int count4 = 0; count4 < n1; count4++)
    {
        //Console.WriteLine("count4 = " + count4);
        sum = sum + mas [count3,count4];
    }
    if (sum > max)
    {
        max = sum;
        buf = count3;
    }
    sum = 0;
}
Console.WriteLine("Наибольшая сумма = " + max);
Console.WriteLine("Номер строки с наибольшей суммой = " + buf);
