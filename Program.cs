// Лабораторная работа 1

// задание 1

//Console.WriteLine("Hello, world!");
//string? name = Console.ReadLine();
//int age = Convert.ToInt32( Console.ReadLine() );
////Console.WriteLine("Hello! {0} через год тебе будет {1}", name, age + 1);
//Console.WriteLine($"Hello! {name} через год тебе будет {age + 1}");


// задание 2

//string? name1, name2, name3;
//int x, y, z, w, extra;

//void InputData(out string? name, out int a, out int b)
//{
//    Console.WriteLine("Введите имя: ");
//    name = Console.ReadLine();
//    Console.Write("Количество выпитых чарок = ");
//    a = Convert.ToInt32(Console.ReadLine());
//    Console.Write("Количество выпитых шкаликов = ");
//    b = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine();
//}

//double VolumeConverter(int a = 0, int b = 0)
//{
//    const double charka = 0.123, shkalik = 0.06;
//    return a * charka + b * shkalik;
//}

//bool Check(double a)
//{
//    if (0.5 < a & a < 1)
//    {
//        return true;
//    }
//    return false;
//}

//double Max3(double a, double b, double c)
//{
//    return Math.Max(Math.Max(a, b), c);
//}

//InputData(out name1, out x, out extra);
//InputData(out name2, out extra, out y);
//InputData(out name3, out z, out w);

//double l1 = VolumeConverter(x);
//double l2 = VolumeConverter(b:y);
//double l3 = VolumeConverter(z, w);

//Console.WriteLine($"\n{name1} выпил(а) {l1} л");
//Console.WriteLine($"{name2} выпил(а) {l2} л");
//Console.WriteLine($"{name3} выпил(а) {l3} л");

//Console.WriteLine("\nИмена тех, кто выпил больше 0.5 л и меньше 1 л:");
//if (Check(l1)) Console.WriteLine(name1);
//if (Check(l2)) Console.WriteLine(name2);
//if (Check(l3)) Console.WriteLine(name3);
//if ((Check(l1) | Check(l2) | Check(l3)) == false) Console.WriteLine("такие отсутствуют");

//Console.WriteLine($"\nВсего выпито {l1 + l2 + l3} л");
//Console.WriteLine($"Наибольший из выпитых объемов = {Max3(l1, l2, l3)} л");


// задание 3

//DateTime birth = new DateTime();
//DateTime now = DateTime.Now;
//while (true)
//{
//    Console.Write("Введите дату рождения: ");
//    birth = Convert.ToDateTime(Console.ReadLine());
//    Console.WriteLine($"Текущая дата: {now}");
//    if (birth > now) Console.WriteLine("Вы еще не родились. Повторите ввод.\n");
//    else break;
//}
//int age = now.Year - birth.Year;
//if (birth > now.AddYears(-age)) age--;
//Console.Write($"Вам {age} ");
//if (age / 10 == 1) Console.WriteLine("лет");
//else if (age % 10 == 1) Console.WriteLine("год");
//else if (age % 10 == 2 | age % 10 == 3 | age % 10 == 4) Console.WriteLine("года");
//else Console.WriteLine("лет");


// задание 4

//int n;
//while (true)
//{
//Console.Write("Введите количество чисел: ");
//n = Convert.ToInt32(Console.ReadLine());
//if (n <= 0) Console.WriteLine("n должно быть больше нуля. Повторите ввод");
//else break;
//}
//double[] x = new double[n];
//double[] f = new double[n];

//void InputArr(ref double[] arr)
//{
//    Console.WriteLine($"Введите n чисел:");
//    for (int i = 0; i < arr.Length; i++)
//        arr[i] = Convert.ToDouble(Console.ReadLine());
//}

//void FindFx(ref double[] x, ref double[] fx)
//{
//    for (int i = 0; i < x.Length; i++)
//    {
//        if (x[i] < -3) fx[i] = (1 + Math.Pow(x[i], 2)) / (2 * x[i]);
//        else if (x[i] >= Math.PI / 4) fx[i] = 7.0 / 3;
//        else fx[i] = (Math.Pow(x[i], 2) - 3) * Math.Sin(x[i]);
//        fx[i] = Math.Round(fx[i] * 1000) / 1000;
//        if (fx[i] == -0) fx[i] = 0;
//    }
//}

//bool Check(double x, double fx)
//{
//    if (x * x + fx * fx <= 4 * 4 & fx <= -2 * x + 4 & fx >= -x - 4 & x <= 2 & fx >= -4)
//        return true;
//    return false;
//}

//InputArr(ref x);
//FindFx(ref x, ref f);
//Console.WriteLine("\nСоответсвующие значения f(x):");
//for (int i = 0; i < n; i++) Console.WriteLine(f[i]);

//Console.WriteLine("\nТочки, попавшие в заштрихованную область:");
//bool flag = true;
//for (int i = 0; i < n; i++)
//{
//    if (Check(x[i], f[i])) {
//        flag = false;
//        Console.Write("{0,-10}", $"x = {x[i]}"); 
//        Console.WriteLine($"f(x) = {f[i]}");
//    }
//}
//if (flag) Console.WriteLine("отсутствуют");


// задание 5

//int n;
//while (true)
//{
//    Console.Write("Введите целое неотрицательное число: ");
//    n = Convert.ToInt32(Console.ReadLine());
//    if (n >= 2) break;
//    else { Console.WriteLine("Число должно быть больше или равно 2. Повторите ввод."); }
//}

//Console.WriteLine($"\nПростые числа в промежутке [2, {n}]:");
//bool check = true;
//for (int i = 2; i <= n; i++) {
//    bool flag = true;
//    for (int j = 2; j < i; j++) {
//        if (i % j == 0)
//        {
//            flag = false;
//            break;
//        }
//    }
//    if (flag) {
//        Console.Write($"{i} ");
//        check = false;
//    }
//}
//if (check) Console.WriteLine("отсутствуют");


// задание 6

//const double e = 0.001;
//double a = 0, b = 0.9, x;

//double f(double x) { return Math.Log10(x * x - 3 * x + 2); }

//while (Math.Abs(b - a) > 2 * e)
//{
//    x = (a + b) / 2;
//    if (f(a) * f(x) < 0)
//        b = x;
//    else if (f(x) * f(b) < 0)
//        a = x;
//}
//x = Math.Round((a + b) / 2, 3);

//Console.WriteLine($"x = {x} в интервале от 0 до 0,9");


// задание 7

//int n;
//while (true)
//{
//    Console.Write("Введите длину массива: ");
//    n = Convert.ToInt32(Console.ReadLine());
//    if (n <= 0) Console.WriteLine("n должно быть больше нуля. Повторите ввод");
//    else break;
//}

//int[] arr = new int[n];
//Console.WriteLine($"Введите n чисел:");
//for (int i = 0; i < n; i++)
//    arr[i] = Convert.ToInt32(Console.ReadLine());

//Console.Write("\nВведите целое число: ");
//int x = Convert.ToInt32(Console.ReadLine());

//int RemoveX(ref int[] a, int x, int size)
//{
//    for (int i = 0; i < a.Length; i++)
//    {
//        if (a[i] == x)
//        {
//            for (int j = i; j < a.Length - 1; j++)
//                a[j] = a[j + 1];
//            size -= 1;
//            i--;
//        }
//    }
//    return size;
//}

//int m = RemoveX(ref arr, x, n);
//int[] arr_new = new int[m];

//Console.Write("\nПолученный массив: ");
//for (int i = 0; i < m; i++)
//{
//    arr_new[i] = arr[i];
//    Console.Write($"{arr_new[i]} ");
//}


// задание 8

int n = 70;
int[] arr = new int[n];

void ArrayFillingRandom(ref int[] a)
{
    Random rnd = new Random();
    int n = a.Length;
    Console.WriteLine($"Массив размерности {n}:");
    for (int i = 0; i < n; i++)
    {
        a[i] = rnd.Next(-100, 100);
        Console.Write("{0, -5}", $"{a[i]} ");
    }
}

void ArraySort(ref int[] a)
{
    int n = a.Length, min_ind, extra;
    for (int i = 1; i < n - 2; i += 2) {
        min_ind = i;
        for (int j = i + 2; j < n; j += 2) {
            if (a[j] < a[min_ind])
                min_ind = j;
        }
        extra = a[i];
        a[i] = a[min_ind];
        a[min_ind] = extra;
    }
}

void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length; i++) Console.Write("{0, -5}", $"{a[i]} ");
}

ArrayFillingRandom(ref arr);
ArraySort(ref arr);
Console.WriteLine("\n\nОтсортированный по возрастанию по четным позициям массив:");
PrintArray(arr);
