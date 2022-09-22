// 1) НАПИШИТЕ ПРОГРАММУ КОТРАЯ НАХОДИТ КВАДРАТ ЧИСЛА
/*
Console.Clear();
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
//Решение математическим путем
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}");
//Решение с использованием библиотеки
int sqr2 = Convert.ToInt32(Math.Pow(number,2));
Console.WriteLine($"Квадрат числа 2 {number} равен {sqr2}");
*/

//2) напишите программу которая вводит 2 числа и определяет, является ли первое квадратом второго
/*
Console.Clear();
Console.Write("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
int sqr = number1 * number1;
if (sqr == number2)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
*/

//3) Напишите программу которая по введенному числу определяет день недели
/*
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number == 1)
{
    Console.Write("Понедельник");
}
if (number == 2)
{
    Console.Write("Вторник");
}
if (number == 3)
{
    Console.Write("Среда");
}
if (number == 4)
{
    Console.Write("Четверг");
}
if (number == 5)
{
    Console.Write("Пятница");
}
if (number == 6)
{
    Console.Write("Суббота");
}
if (number == 7)
{
    Console.Write("Воскресение");
}
*/


// 4) Напишите программу которая выводит случайное трехзначное  число и удаляет вторую цифру этого числа
/*
Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int a1 = num / 100;
int a2 = num % 10;
Console.Write(a1);
Console.WriteLine(a2);
*/

// 5) Напишите программу которая выводит случайное число из отрезка [10.99] и выводит большую цифру числа
/*
Console.Clear();
int num = new Random().Next(10, 100);
int a1 = num / 10;
int a2 = num % 10;
Console.WriteLine(num);
int max = a1;
if(a2 > max) {
    max = a2;
}
Console.WriteLine(max);
*/


// 6) Напишите программу которая принимает на вход 2 числа и проверяет является ли одно квадлатом другого
/*
Console.Write("Введите  первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if( num1 *num1 == num2 || num2 * num2 == num1 )
{
    Console.WriteLine("да ");
}
else
{
    Console.WriteLine("нет ");
}
*/


// 7) Напишите программу котороая на вход будет принимать 2 числа и выводить является ли второе число кратно первому.
//Если не кратно то выводить остаток от деления
/*
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if(num1 % num2 == 0)
{
Console.WriteLine(num2);
Console.WriteLine(num1);
Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine(num2);
    Console.WriteLine(num1);
    Console.WriteLine("не кратно остаток");
    Console.WriteLine(num1 % num2);
}
*/

// 8)  Напишите программу которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23
/*
Console.Clear();
Console.Write("Введите  число: ");
int num = int.Parse(Console.ReadLine());
if( num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("да ");
}
else
{
    Console.WriteLine("нет ");
}
*/

// 9) Напишите программу, которая принимает на вход координаты точки(x  y) причем x≠0 y≠0 и выдает номер четвертиплоскости в которой находится эта точка
/*
Console.Clear();
Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine());
 
if(x > 0 && y > 0)
    Console.WriteLine("1");
else if(x < 0 && y > 0)
    Console.WriteLine("2");
else if(x < 0 && y < 0)
    Console.WriteLine("3");
else if(x > 0 && y > 0)
    Console.WriteLine("4");
    */


    //10)  Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек
/*
Console.Clear();
Console.Write("Введите номер четверти: ");
int x = int.Parse(Console.ReadLine());
 if( x==1 )
    Console.WriteLine("x > 0  y > 0");
else if(x==2)
    Console.WriteLine("x < 0  y > 0");
else if(x==3)
    Console.WriteLine("x < 0  y < 0");
else if(x==4)
    Console.WriteLine("x > 0  y > 0");
else
    Console.WriteLine("Введите номер от 1 до 4");
    */



// 11)  напишите программу которая принимает на вход координаты 2х точек, и находит расстояние между ними в 2д пространстве
/*
Console.WriteLine("введите координаты первой точки");
Console.WriteLine("введите x1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите x2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите y2");
int y2 = int.Parse(Console.ReadLine());
int d = Convert.ToInt32(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)));
Console.WriteLine("Расстояние между точками: ");
Console.WriteLine(d);
*/

// 12)  напишите программу которая принимает на вход число N и выдает таблицу квадратов чисет от 1 д N
/*
Console.WriteLine("ВВЕДИТЕ ЧИСЛО");
int num = int.Parse(Console.ReadLine());
int count = 1;
while ( count <= num )
{
    Console.Write($"{Math.Pow(count, 2)} ");
    count ++;
}
*/


// 13) поиск элемента массива по индексу
/*
int[] array = {14, 23, 32,98, 4, 59, 6, 27, 98};
int n = array.Length;
int find = 98;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index+1
    index++;
}
*/


//14)  поиск максимума в массиве
/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if( arg2 > result) result = arg2;
    if( arg3 > result) result = arg3;
    return result;
}
int[] array = {13,27,3,41,5,64,7,89,92};
//array[0] = 12;
//Console.WriteLine(array[0]);
int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);
*/

// 15)  поиск максимума из 9 чисел
/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if( arg2 > result) result = arg2;
    if( arg3 > result) result = arg3;
    return result;
}
int a1 = 15;
int b1 = 90;
int c1 = 1;
int a2 = 45;
int b2 = 65;
int c2 = 3;
int a3 = 91;
int b3 = 78;
int c3 = 19;
//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));
Console.WriteLine(max);
*/

// 16) задайте массив из 12 элементов, заполненный случайными числами из промежутка -9 до 9
//найдите сумму + и - цифр массива
/*
Console.Clear();
Console.WriteLine("введите размернсть массива");
int size = int.Parse(Console.ReadLine());
int [] array = GetArray(size, -9, 9);
Console.WriteLine(String.Join(" ", array));
int sumPositive = 0;
int sumNegative = 0;
//[3,1,-2]
foreach(int element in array){
    
    sumPositive += element > 0 ? element : 0;
    sumNegative += element < 0 ? element : 0;
}
Console.WriteLine($"sumPositive: {sumPositive} sumNegative {sumNegative}");
 int[] GetArray (int size, int min, int max){
    int []result = new int[size];
    for (int i = 0; i< size; i++){
        result[i] = new Random().Next(min, max+1);
    }
return result;
}
*/


// 17) Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.Clear();
 
int num = new Random().Next(100, 1000);
Console.WriteLine(num);
 
int a1 = num / 10;
int a2 = a1 % 10;
 
Console.Write(a2);
*/



// 18) Напишите программу, которая принимает на вход цифру, обозначающую день недели, 

/*
 
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
 
if (number == 1)
{
    Console.Write("Понедельник");
}
else if (number == 2)
{
    Console.Write("Вторник");
}
else if (number == 3)
{
    Console.Write("Среда");
}
else if (number == 4)
{
    Console.Write("Четверг");
}
else if (number == 5)
{
    Console.Write("Пятница");
}
else if (number == 6)
{
    Console.Write("Суббота");
}
else if (number == 7)
{
    Console.Write("Воскресение");
}
else
{
    Console.Write("введите число от 1 до 7");
}
*/


// 19) программа которая на вход принимает число N А НА ВЫХОДЕ ПОКАЗЫВАЕТ ЦЕЛЫЕ ЧИСЛА В ПРОМЕЖУТКЕ ОТ -n до n
/*
Console.Clear();
System.Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
 
int i = number;
 
if(number < 0)
{
    number = number * -1;
}
else if (number > 0)
{
    i = i * -1;
}
else
{
    System.Console.WriteLine("0");
}
while (i < number)
{
    System.Console.WriteLine(i);
    i++;
}
System.Console.WriteLine(number);
*/

// 20) Напишите программу, которая принимает на вход координаты точки(x  y) причем x≠0 y≠0 и выдает номер четвертиплоскости в которой находится эта точка
/*
Console.Clear();
Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine());
 
if(x > 0 && y > 0)
    Console.WriteLine("1");
else if(x < 0 && y > 0)
    Console.WriteLine("2");
else if(x < 0 && y < 0)
    Console.WriteLine("3");
else if(x > 0 && y > 0)
    Console.WriteLine("4");
*/

//21) Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек
/*
Console.Clear();
Console.Write("Введите номер четверти: ");
int x = int.Parse(Console.ReadLine());
 if( x==1 )
    Console.WriteLine("x > 0  y > 0");
else if(x==2)
    Console.WriteLine("x < 0  y > 0");
else if(x==3)
    Console.WriteLine("x < 0  y < 0");
else if(x==4)
    Console.WriteLine("x > 0  y > 0");
else
    Console.WriteLine("Введите номер от 1 до 4"); 
    */


// 22) Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
 
if (num < 10000 || num > 99999 )
{
    Console.WriteLine("введите пятизначное число");
}
else
{
    int a = num / 10000;
    int b = num % 10;
    int c = num / 1000;
    int d = c % 10;
    int e = num % 100;
    int f = e / 10;
 
    Console.WriteLine(a == b || d == f ? "палиндром" : "не палиндром");
}
*/


// 23)Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
 
if (num < 10000 || num > 99999 )
{
    Console.WriteLine("введите пятизапчное число");
}
else
{
    string str = num.ToString();
    Console.WriteLine(str[0] == str[4] || str[1] == str[3] ? "палиндром" : "не палиндром");
}
*/


// 24) генератор псевдослучайных чисел, массив
/*
void FillArray(int[] collection)
{
    int length =  collection.Length;
    int index = 0;
    while ( index< length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index +1
        index++;
    }
}
 
void PrintArray(int[] col)
 
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
 
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while ( index< count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int [10]; // создай  новый массив из 10 элементов
 
FillArray(array);  // метод заполнил массив
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();
 
int pos = IndexOf(array, 4);
Console.WriteLine(pos);
*/

//25) напишите программу которая принимает на вход число А и выдает сумму чисел от 1 доА
/*
Console.Clear();
Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine());
 
Console.WriteLine(GetSum(A));
int GetSum(int a) {
    int sum = 0;
    for( int i = 0 ; i <= a; i++) {
        sum +=i;
    }
    return sum;
}
*/


//26) цикл for и цикл внутри цикла- таблица умножения
/*
for (int i = 2; i<= 10; i++)
{
    for (int j = 2 ; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}
*/

//27) Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к» заменить большими «К», а большие «С» заменить на маленькие «с»
/*
string text = "— Я думаю, - сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
 
// string s = “qwerty”
//             012345
//s[3]  //r
 
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
 
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else resulte = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, " ", "|");
Console.WriteLine(newText);
*/

//27) упорядочиванние данных внутри массива методом выбора
/*
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
 
void PrintArray(int[] array)
{
    int count= array.Length;
    for (int i =0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
 
void SelectionSort(int[] array)
{
    for (int i =0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
 
PrintArray(arr);
SelectionSort(arr);
 
PrintArray(arr);
*/

//28) напишите программу которая принимает на вход число А
//и выдает сумму мисел от 1 до а
 /*
Console.Clear();
Console.WriteLine("введите число А");
int A = int.Parse(Console.ReadLine());
 
int GetSum(int a){
    int sum = 0;
    for( int i = 0; i <= a; i++){
        sum +=i; //sum = sum+i
    }
    return sum;
}
Console.WriteLine(GetSum(A));
*/


//29) напишите программу которая принимает на вход число 
//и выдает количество цифр в числе
/* 
Console.Clear();
Console.WriteLine("введите число ");
int A = int.Parse(Console.ReadLine());
 
string a = Convert.ToString(A); // конвертируем в строку
Console.WriteLine(a.Length); //выводим длинну строки а
*/


//30)напишите программу которая принимает на вход число 
//и выдает количество цифр в числе
/* 
Console.Clear();
Console.WriteLine("введите число ");
int A = int.Parse(Console.ReadLine());
 
int count = 1;
while(A > 10){
    count++;
    A = A/10;
}
Console.WriteLine(count);
*/


//31) напишите программу которая принимает на вход число N
//и выдает произведение чисел от 1 до N
/* 
Console.Clear();
Console.WriteLine("введите число А");
int n = int.Parse(Console.ReadLine());
int result = 1;
for( int i = 1; i <= n; i++)
{
     result *=i;   
}
Console.WriteLine(result);
*/

//32) напишите программу которая выводит массив эементов из 8 цивр,
 //заполненный 0 и 1 в случайном порядке
 /*
Console.Clear();
int[] array = new int[8]; //создали массив из 8 элементов
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
    Console.Write(array[i] + " ");
    //Console.Write($"{array[i]} ");  то же самое
}
*/

//33) напишите программу которая выводит массив эементов из 8 цивр,
 //заполненный 0 и 1 в случайном порядке
 /*
Console.Clear();
int[] array = new int[8]; //создали массив из 8 элементов
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 2);
    Console.Write(array[i]);
    //Console.Write($"{array[i]} ");  то же самое
}
*/


//34) напишите программу, замена элементов массива, положительные на отрицательные и наоборот
/*
Console.Clear();
Console.WriteLine("введите длинну массива ");
int size = int.Parse(Console.ReadLine());
int[] rand = new int[size];
int[] rand2 = new int[size];
 
for(int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(-99, 100);
    Console.Write(rand[i]+" ");
}
Console.WriteLine(); //вывели массив произвольный на 10символов, от -99 до 99
for(int i = 0; i < rand.Length; i++){
    rand2[i] = rand[i] * -1;
    Console.Write(rand2[i]+" ");
}
Console.WriteLine();
*/

//35) задайте масив. напишите программу которая определяет присутствуйт ли заданное число в массиве
/*
Console.Clear();
Console.WriteLine("введите длинну массива: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("введите искомое число");
int num = int.Parse(Console.ReadLine());
int [] rand = new int[size];
bool A = false;
 
for (int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(0, 11);
    Console.Write(rand[i]+" ");
    if (rand[i] == num)
        A = true;
}   
Console.WriteLine();
if (A == true)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");
    */

//36) задайте одномерный массив из 123 чисел
//найдите количество элементов массива, значения которых лежат в отрезке [10,99]
/*
Console.Clear();
 
int [] array = GetArray(12, -99, 199);
int j = 0;
int [] GetArray(int size, int min, int max){
    int[] result = new int [size];
 
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(min, max +1);
    }
return result;
}
int FindNumber(int [] array){
    for (int i = 0; i < array.Length; i++){
        if (array [i] >= 10 && array[i] <= 99)
            j++;
            
    }
return j;
}
Console.WriteLine (String.Join(" ", array));
Console.WriteLine (FindNumber(array));
*/

//37) найдите произведение пар чисел в одномерном массиве,парой считам перый и последний элемент, второй и предпоследний и тд.
//результат запишите в новом массиве
/*
int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
 
        result[i] = new Random().Next(min, max +1);
    }
    return result;
}
int ReadNumber()
{
    int number = 0;
    while (true)
    {
        Comsole.WriteLine("введите размерность");
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            ConsoleWriteLine("некорректный ввод");
        }
        else break;
    }
    return number;
}
*/

//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.[345, 897, 568, 234] -> 2
/*
Console.WriteLine("введите длинну массива ");
int size = int.Parse(Console.ReadLine());
int[] rand = new int[size];
 
for(int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(100, 1000);
    Console.Write(rand[i]+" ");
}
int count = 0;
for (int i = 0; i < rand.Length; i++)
if (rand[i] % 2 == 0)
count++;
Console.WriteLine($"всего {rand.Length} чисел, {count} из них чётные");
*/



// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*Console.WriteLine("введите длинну массива ");
int size = int.Parse(Console.ReadLine());
int[] rand = new int[size];
 
for(int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(0, 10);
    Console.Write(rand[i]+" ");
}
int sum = 0;
for (int i = 0; i < rand.Length; i+=2)
sum += rand[i];
Console.WriteLine("сумма= " + sum);
*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*Console.Clear();
Console.WriteLine("введите длинну массива ");
int size = int.Parse(Console.ReadLine());
int[] rand = new int[size];
 
for(int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(0, 100);
    Console.Write(rand[i]+" ");
}
Console.WriteLine();
int maxValue = rand.Max<int>();
int minValue = rand.Min<int>();
Console.WriteLine($"Разница между максимальным и минимальным элементом: {maxValue-minValue}");
*/
/*
//напишите программу которая принимает на вход число А и выдает сумму чисел от 1 доА
Console.Clear();
Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine());
 
Console.WriteLine(GetSum(A));
int GetSum(int a) {
    int sum = 0;
    for( int i = 0 ; i <= a; i++) {
        sum +=i;
    }
    return sum;
}


//виды методов
//1- методы которые ничего не возвращают и ничего не принимают
void Method1()
{
    Console.WriteLine("автор Юра ");
}
Method1();
 
//2-методы, которые ничего не возвращают, но в то же время могут принимать какие-то аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");
 
 
//именованные аргументы
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);
 
 
//указывать к какому аргументу, какое значение мы хотим присвоить, через такую конструкцию.
 
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", 4);
Method21(count: 4, msg: " новый Текст");
 
//3-методы, которые что-то возвращают, но ничего не принимают
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
 
 
// 4- методы, которые что-то принимают и что-то возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;



    //цикл for и цикл внутри цикла- таблица умножения
for (int i = 2; i<= 10; i++)
{
    for (int j = 2 ; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}




//Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к» заменить большими «К», а большие «С» заменить на маленькие «с»
string text = "— Я думаю, - сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
 
// string s = “qwerty”
//             012345
//s[3]  //r
 
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
 
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else resulte = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, " ", "|");
Console.WriteLine(newText);


//упорядочиванние данных внутри массива методом выбора
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
 
void PrintArray(int[] array)
{
    int count= array.Length;
    for (int i =0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
 
void SelectionSort(int[] array)
{
    for (int i =0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
 
PrintArray(arr);
SelectionSort(arr);
 
PrintArray(arr);




//напишите программу которая принимает на вход число А
//и выдает сумму мисел от 1 до а
 
Console.Clear();
Console.WriteLine("введите число А");
int A = int.Parse(Console.ReadLine());
 
int GetSum(int a){
    int sum = 0;
    for( int i = 0; i <= a; i++){
        sum +=i; //sum = sum+i
    }
    return sum;
}
Console.WriteLine(GetSum(A));


//напишите программу которая принимает на вход число 
//и выдает количество цифр в числе
 
Console.Clear();
Console.WriteLine("введите число ");
int A = int.Parse(Console.ReadLine());
 
string a = Convert.ToString(A); // конвертируем в строку
Console.WriteLine(a.Length); //выводим длинну строки а


//напишите программу которая принимает на вход число 
//и выдает количество цифр в числе
 
Console.Clear();
Console.WriteLine("введите число ");
int A = int.Parse(Console.ReadLine());
 
int count = 1;
while(A > 10){
    count++;
    A = A/10;
}
Console.WriteLine(count);

//напишите программу которая принимает на вход число N
//и выдает произведение чисел от 1 до N
 
Console.Clear();
Console.WriteLine("введите число А");
int n = int.Parse(Console.ReadLine());
int result = 1;
for( int i = 1; i <= n; i++)
{
     result *=i;   
}
Console.WriteLine(result);


//напишите программу которая выводит массив эементов из 8 цивр,
 //заполненный 0 и 1 в случайном порядке
Console.Clear();
int[] array = new int[8]; //создали массив из 8 элементов
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
    Console.Write(array[i] + " ");
    //Console.Write($"{array[i]} ");  то же самое
}


//напишите программу которая выводит массив эементов из 8 цивр,
 //заполненный 0 и 1 в случайном порядке
Console.Clear();
int[] array = new int[8]; //создали массив из 8 элементов
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 2);
    Console.Write(array[i]);
    //Console.Write($"{array[i]} ");  то же самое
}

//напишите программу, замена элементов массива, положительные на отрицательные и наоборот
Console.Clear();
Console.WriteLine("введите длинну массива ");
int size = int.Parse(Console.ReadLine());
int[] rand = new int[size];
int[] rand2 = new int[size];
 
for(int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(-99, 100);
    Console.Write(rand[i]+" ");
}
Console.WriteLine(); //вывели массив произвольный на 10символов, от -99 до 99
for(int i = 0; i < rand.Length; i++){
    rand2[i] = rand[i] * -1;
    Console.Write(rand2[i]+" ");
}
Console.WriteLine();



//задайте масив. напишите программу которая определяет присутствуйт ли заданное число в массиве
Console.Clear();
Console.WriteLine("введите длинну массива: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("введите искомое число");
int num = int.Parse(Console.ReadLine());
int [] rand = new int[size];
bool A = false;
 
for (int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(0, 11);
    Console.Write(rand[i]+" ");
    if (rand[i] == num)
        A = true;
}   
Console.WriteLine();
if (A == true)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");


    //задайте одномерный массив из 123 чисел
//найдите количество элементов массива, значения которых лежат в отрезке [10,99]
Console.Clear();
 
int [] array = GetArray(12, -99, 199);
int j = 0;
int [] GetArray(int size, int min, int max){
    int[] result = new int [size];
 
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(min, max +1);
    }
return result;
}
int FindNumber(int [] array){
    for (int i = 0; i < array.Length; i++){
        if (array [i] >= 10 && array[i] <= 99)
            j++;
            
    }
return j;
}
Console.WriteLine (String.Join(" ", array));
Console.WriteLine (FindNumber(array));


//найдите произведение пар чисел в одномерном массиве,парой считам перый и последний элемент, второй и предпоследний и тд.
//результат запишите в новом массиве
int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
 
        result[i] = new Random().Next(min, max +1);
    }
    return result;
}
int ReadNumber()
{
    int number = 0;
    while (true)
    {
        Comsole.WriteLine("введите размерность");
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            ConsoleWriteLine("некорректный ввод");
        }
        else break;
    }
    return number;
}



 
Console.Clear();
int size = ReadNumber();
int[] array =GetArray(size, 0, 10);
int[] newArray = new int[size % 2 == 0 & (size / 2) : (size / 2 +1)];
 
for(int i = 0; i < newArray.Length; i++)
{
    newArray[i] = array[i] * array[array.Length -1 - i];
    
}
if (newArray.Length % 2 ! = 0)
{
   newArray[newArray.Length - 1] = array[array.Length / 2];
}
Console.WriteLine(String.Join("*", array));
Console.WriteLine(String.Join("*", newArray));


//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.[345, 897, 568, 234] -> 2
Console.WriteLine("введите длинну массива ");
int size = int.Parse(Console.ReadLine());
int[] rand = new int[size];
 
 
for(int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(100, 1000);
    Console.Write(rand[i]+" ");
}
 
int count = 0;
for (int i = 0; i < rand.Length; i++)
if (rand[i] % 2 == 0)
count++;
 
Console.WriteLine($"всего {rand.Length} чисел, {count} из них чётные");



// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("введите длинну массива ");
int size = int.Parse(Console.ReadLine());
int[] rand = new int[size];
 
 
for(int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(0, 10);
    Console.Write(rand[i]+" ");
}
int sum = 0;
for (int i = 0; i < rand.Length; i+=2)
sum += rand[i];
Console.WriteLine("сумма= " + sum);



//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
Console.WriteLine("введите длинну массива ");
int size = int.Parse(Console.ReadLine());
int[] rand = new int[size];
 
 
for(int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(0, 100);
    Console.Write(rand[i]+" ");
}
Console.WriteLine();
int maxValue = rand.Max<int>();
 
int minValue = rand.Min<int>();
 
Console.WriteLine($"Разница между максимальным и минимальным элементом: {maxValue-minValue}");



// двумерные массивы
/*
string[,] table = new string[2, 5];
//table[0,0] //table[0,1] //table[0,2] ...
//table[1,0] //table[1,1] //table[1,2] ...
 
table[1, 2] = "слово";
for (int rows = 0 ; rows < 2; rows++)
{
    for (int columns = 0 ; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/
 
// двумерный массив с числами
/*
int[,] matrix = new int[3, 4];
for (int i = 0 ; i < matrix.GetLength(0); i++)
{
    for (int j = 0 ; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
*/
//опишем метод который будет выводить двумерную матрицу и заполнять числами
/*
void PrintArray(int[,] matr)
{
    for (int i = 0 ; i < matr.GetLength(0); i++)
    {
        for (int j = 0 ; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
 
void FillArray(int[,] matr)
{
    for (int i = 0 ; i < matr.GetLength(0); i++)
    {
        for (int j = 0 ; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);
        }
        Console.WriteLine();
    }
}
 
int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/
 
//рекурсия и факториал
/*double Factorial(int n)
{
    //1! =1
    if(n ==1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
Console.WriteLine($"{i}! = {Factorial(i)}");
*/
 /*
//фибоначчи
//f(1) = 1
//f(2) = 1
////f(n) = f(n-1) + f(n-2) 
double Fibonacci(int n)
{
    if( n== 1 || n ==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1 ; i < 50; i++)
{
    Console.WriteLine(Fibonacci(i));    
}

// напишите программу которая перевернет одномерный массив
 
Console.WriteLine("введите длинну массива ");
int size = int.Parse(Console.ReadLine());
 
int [] array = FillArray(size, 1, 10);
//FillArray(int size, int min, int max);
Console.WriteLine("входной массив ");
Console.WriteLine (String.Join(" ", array));
Console.WriteLine("полученный массив ");
Console.WriteLine (String.Join(" ", array.Reverse())); //1 способ
 
int [] FillArray(int size, int min, int max){
    int [] result = new int [size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(min, max +1);
    }
    return result;
}


// напишите программу которая перевернет одномерный массив - 2способ
 
Console.WriteLine("введите длинну массива ");
int size = int.Parse(Console.ReadLine());
 
int [] array = FillArray(size, 1, 10);
 
/*Console.WriteLine("входной массив ");
Console.WriteLine (String.Join(" ", array));
Console.WriteLine("полученный массив ");
Console.WriteLine (String.Join(" ", array.Reverse())); //1 способ*/
/* 
int [] FillArray(int size, int min, int max){
    int [] result = new int [size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(min, max +1);
    }
    return result;
}
Console.WriteLine("входной массив ");
Console.WriteLine (String.Join(" ", array));
Console.WriteLine("полученный массив ");
Console.WriteLine (String.Join(" ", array.Reverse()));
 
Console.WriteLine("полученный массив 2 способ ");
Console.WriteLine (String.Join(" ", ReverseArray(array)));
 
int [] ReverseArray(int []array){
    int [] result = new int [array.Length];
    for(int i = 0; i < array.Length; i++){
        result[i] = array [array.Length -1 -i];
    }
    return result;
}

// напишите программу которая принимает на вход 3 числа и 
//проверяет может ли сущетвовать треугольник с сторонами такой длинны
//теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы 2х других сторон
/*
Console.Clear();
int A, B, C;
Console.Write("введите длины сторон треугольника");
while (!int.TryParse(Console.ReadLine(), out A) || A < 0){
Console.Write("ошибка. введите положительное число: ");    
}
Console.Write("введите длины сторон треугольника");
while (!int.TryParse(Console.ReadLine(), out B) || B < 0){
Console.Write("ошибка. введите положительное число: ");
}  
Console.Write("введите длины сторон треугольника");
while (!int.TryParse(Console.ReadLine(), out C) || C < 0){
Console.Write("ошибка. введите положительное число: ");
}
if (A < B +C & B < A + C & C < A + B) {
    Console.Write("МОЖЕТ");
} else {
    Console.Write("не МОЖЕТ");
}
*/
 
//напишите программу которая будет преобразовывать десятичное число в двоичное
/*Console.Clear();
Console.WriteLine("введите число");
int value = int.Parse(Console.ReadLine());
string BinaryCode = Convert.ToString(value, 2);
Console.WriteLine(BinaryCode);
*/
 
//напишите программу которая будет преобразовывать десятичное число в двоичное 2 способ
/*Console.Clear();
Console.WriteLine("введите число");
int value = int.Parse(Console.ReadLine());
string i = " ";
while (value > 0)
{
    if (value % 2 != 0){
        i += "1";
    }
    else{
        i += 0;
    }
    value = value / 2;
}
Console.WriteLine($"в двоичной системе: ");
 
Console.WriteLine (String.Join(" ", i.Reverse()));
*/
 
//yне используя рекурсию выведите первые N чисел фибоначчи. первые 2 числа 0 и 1.
//n=5 -> 01123
//n=3 -> 011
//n=7 -> 0112358
/*Console.Clear();
Console.WriteLine("введите число");
int N = int.Parse(Console.ReadLine());
int i = 0;
int Fib1 = 0;
int Fib2 = 1;
while (i < N)
{
    Console.Write(Fib1);
    Fib2 = Fib1 + Fib2;
    Fib1 = Fib2 - Fib1;
    i++;
}
*/
 
//напишите программу которая будет создавать копию заданного массива с помощью поэлементного копирования
/*
Console.Clear();
Console.WriteLine("введите размерность массива");
int size = int.Parse(Console.ReadLine());
int [] array1 = FillArray(size, 1, 10);
int [] FillArray(int size, int min, int max)
{
    int [] result = new int [size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}
Console.WriteLine(String.Join(" ", array1));
int [] array2 = new int[size];
for (int i = 0; i < size; i++)
{
    array2[i] = array1[i];
}
Console.WriteLine(String.Join(" ", array2));
*/

/*

//задайте двумерный массив m*n и заполните случайными целыми числами
Console.Clear();
Console.WriteLine("количествл строк массива ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("количествл столбцов массива ");
int columns = int.Parse(Console.ReadLine());
 
int [,] array = FillArray(rows, columns, 1, 10);
PrintArray(array);
int [,] FillArray (int rows, int columns, int min, int max){
    int [,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void PrintArray(int [,] filledArray){
    for (int i = 0; i < filledArray.GetLength(0); i++){
        for (int j = 0; j < filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
 
//задайте двумерный массив m*n и заполните случайными целыми числами
 
/*Console.Clear();
Console.WriteLine("количествл строк массива ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("количествл столбцов массива ");
int columns = int.Parse(Console.ReadLine());
 
int [,] array = FillArray(rows, columns, 1, 10);
PrintArray(array);
int [,] FillArray (int rows, int columns, int min, int max){
    int [,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void PrintArray(int [,] filledArray){
    for (int i = 0; i < filledArray.GetLength(0); i++){
        for (int j = 0; j < filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/
 
//задайте двумерный массив m*n ,каждый элемент массива  находится по формуле a= m+n. выведите на экран
 
/*Console.Clear();
Console.WriteLine("количествл строк массива ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("количествл столбцов массива ");
int columns = int.Parse(Console.ReadLine());
 
int [,] array = FillArray(rows, columns);
PrintArray(array);
int [,] FillArray (int rows, int columns){
    int [,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i,j] = i + j;
        }
    }
    return array;
}
void PrintArray(int [,] filledArray){
    for (int i = 0; i < filledArray.GetLength(0); i++){
        for (int j = 0; j < filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/
 
//задайте двумерный массив. найдите элементы у которых индексы четные и возведите их в квадрат
/*
Console.Clear();
Console.WriteLine("количествл строк массива ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("количествл столбцов массива ");
int columns = int.Parse(Console.ReadLine());
 
int [,] array = FillArray(rows, columns, 1, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(FillArrayCheck(array));
 
int [,] FillArrayCheck (int [,] array){
        for (int i = 1; i < rows; i++){
        for (int j = 1; j < columns; j++){
            if (i % 2 == 1 && j % 2 == 1){
                array[i,j] *= array[i,j];
            }
        }
    }
    return array;
}
int [,] FillArray (int rows, int columns, int min, int max){
    int [,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void PrintArray(int [,] filledArray){
    for (int i = 0; i < filledArray.GetLength(0); i++){
        for (int j = 0; j < filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
} 
*/
//задайте двумерный массив. найдите сумму по главной диагонали
/*
Console.Clear();
Console.WriteLine("количествл строк массива ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("количествл столбцов массива ");
int columns = int.Parse(Console.ReadLine());
 
int [,] array = FillArray(rows, columns, 1, 10);
 
PrintArray(array);
Console.WriteLine();
DiagonalArray(array);
 
void DiagonalArray (int [,] array){
    int sum = 0;
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            if (i == j ){
                sum += array[i,j];
        }
    }
}
Console.WriteLine(sum);
}
int [,] FillArray (int rows, int columns, int min, int max){
    int [,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void PrintArray(int [,] filledArray){
    for (int i = 0; i < filledArray.GetLength(0); i++){
        for (int j = 0; j < filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
} 


//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
Console.Clear();
Console.WriteLine("количествл строк массива ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("количествл столбцов массива ");
int columns = int.Parse(Console.ReadLine());
 
double [,] array = FillArray(rows, columns, 0, 10);
PrintArray(array);
double [,] FillArray (int rows, int columns, int min, int max){
    double [,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i, j] = Convert.ToDouble(new Random().Next(0, 10)) / 10;
        }
    }
    return array;
}
void PrintArray(double [,] filledArray){
    for (int i = 0; i < filledArray.GetLength(0); i++){
        for (int j = 0; j < filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
}


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
 
Console.Clear();
Console.WriteLine("количествл строк массива ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("количествл столбцов массива ");
int columns = int.Parse(Console.ReadLine());
 
int [,] array = FillArray(rows, columns, 1, 10);
 
PrintArray(array);
Console.WriteLine();
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{ sum / array.GetLength(0)} ");
 
}
int [,] FillArray (int rows, int columns, int min, int max){
    int [,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void PrintArray(int [,] filledArray){
    for (int i = 0; i < filledArray.GetLength(0); i++){
        for (int j = 0; j < filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
} 


// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();
Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
 
int [,] numbers = new int [10,10];
 
FillArrayRandomNumbers(numbers);
if(n > numbers.GetLength(0) || m > numbers.GetLength(1))
    Console.WriteLine("такого элемента нет");
else
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1, m-1]}");
PrintArray(numbers);
void FillArrayRandomNumbers(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i,j] = new Random().Next(-100.100)/10;
        }
        Console.WriteLine();
    }
} 
void PrintArray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++){
           if (array [i,j] >= 0)
           Console.WriteLine($"{array[i,j]}  ");
           else
           Console.WriteLine($"{array[i,j]}  ");
        }
        Console.WriteLine("]");
        Console.WriteLine("");
    }
} 


// напишите программу которая принимает на вход 3 числа и 
//проверяет может ли сущетвовать треугольник с сторонами такой длинны
//теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы 2х других сторон
/*
Console.Clear();
int A, B, C;
Console.Write("введите длины сторон треугольника");
while (!int.TryParse(Console.ReadLine(), out A) || A < 0){
Console.Write("ошибка. введите положительное число: ");    
}
Console.Write("введите длины сторон треугольника");
while (!int.TryParse(Console.ReadLine(), out B) || B < 0){
Console.Write("ошибка. введите положительное число: ");
}  
Console.Write("введите длины сторон треугольника");
while (!int.TryParse(Console.ReadLine(), out C) || C < 0){
Console.Write("ошибка. введите положительное число: ");
}
if (A < B +C & B < A + C & C < A + B) {
    Console.Write("МОЖЕТ");
} else {
    Console.Write("не МОЖЕТ");
}
*/
 
//напишите программу которая будет преобразовывать десятичное число в двоичное
/*Console.Clear();
Console.WriteLine("введите число");
int value = int.Parse(Console.ReadLine());
string BinaryCode = Convert.ToString(value, 2);
Console.WriteLine(BinaryCode);
*/
 
//напишите программу которая будет преобразовывать десятичное число в двоичное 2 способ
/*Console.Clear();
Console.WriteLine("введите число");
int value = int.Parse(Console.ReadLine());
string i = " ";
while (value > 0)
{
    if (value % 2 != 0){
        i += "1";
    }
    else{
        i += 0;
    }
    value = value / 2;
}
Console.WriteLine($"в двоичной системе: ");
 
Console.WriteLine (String.Join(" ", i.Reverse()));
*/
 
//yне используя рекурсию выведите первые N чисел фибоначчи. первые 2 числа 0 и 1.
//n=5 -> 01123
//n=3 -> 011
//n=7 -> 0112358
/*Console.Clear();
Console.WriteLine("введите число");
int N = int.Parse(Console.ReadLine());
int i = 0;
int Fib1 = 0;
int Fib2 = 1;
while (i < N)
{
    Console.Write(Fib1);
    Fib2 = Fib1 + Fib2;
    Fib1 = Fib2 - Fib1;
    i++;
}
*/
 
//напишите программу которая будет создавать копию заданного массива с помощью поэлементного копирования
/*
Console.Clear();
Console.WriteLine("введите размерность массива");
int size = int.Parse(Console.ReadLine());
int [] array1 = FillArray(size, 1, 10);
int [] FillArray(int size, int min, int max)
{
    int [] result = new int [size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}
Console.WriteLine(String.Join(" ", array1));
int [] array2 = new int[size];
for (int i = 0; i < size; i++)
{
    array2[i] = array1[i];
}
Console.WriteLine(String.Join(" ", array2));
*/
 
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Clear();
Console.WriteLine("введите количество чисел ");
int M = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < M; i++)
{
    Console.WriteLine($"Введите число {i + 1}: ");
    int x = int.Parse(Console.ReadLine());
    if (x>0){
        count++;
    }
}
Console.WriteLine($"Положительных чисел: {count}");
*/
 
//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*Console.WriteLine("введите значение b1");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = int.Parse(Console.ReadLine());
 
double x = (b2 - b1)/(k1 - k2);
double y = k1 * ((b2-b1) / (k1-k2)) +b1;
 
Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
*/
 
//задайте двумерный массив m*n и заполните случайными целыми числами
 
/*Console.Clear();
Console.WriteLine("количествл строк массива ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("количествл столбцов массива ");
int columns = int.Parse(Console.ReadLine());
 
int [,] array = FillArray(rows, columns, 1, 10);
PrintArray(array);
int [,] FillArray (int rows, int columns, int min, int max){
    int [,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void PrintArray(int [,] filledArray){
    for (int i = 0; i < filledArray.GetLength(0); i++){
        for (int j = 0; j < filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/
 
//задайте двумерный массив m*n ,каждый элемент массива  находится по формуле a= m+n. выведите на экран
 
/*Console.Clear();
Console.WriteLine("количествл строк массива ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("количествл столбцов массива ");
int columns = int.Parse(Console.ReadLine());
 
int [,] array = FillArray(rows, columns);
PrintArray(array);
int [,] FillArray (int rows, int columns){
    int [,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i,j] = i + j;
        }
    }
    return array;
}
void PrintArray(int [,] filledArray){
    for (int i = 0; i < filledArray.GetLength(0); i++){
        for (int j = 0; j < filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/
 
//задайте двумерный массив. найдите элементы у которых индексы четные и возведите их в квадрат
/*
Console.Clear();
Console.WriteLine("количествл строк массива ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("количествл столбцов массива ");
int columns = int.Parse(Console.ReadLine());
 
int [,] array = FillArray(rows, columns, 1, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(FillArrayCheck(array));
 
int [,] FillArrayCheck (int [,] array){
        for (int i = 1; i < rows; i++){
        for (int j = 1; j < columns; j++){
            if (i % 2 == 1 && j % 2 == 1){
                array[i,j] *= array[i,j];
            }
        }
    }
    return array;
}
int [,] FillArray (int rows, int columns, int min, int max){
    int [,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void PrintArray(int [,] filledArray){
    for (int i = 0; i < filledArray.GetLength(0); i++){
        for (int j = 0; j < filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
} 
*/
//задайте двумерный массив. найдите сумму по главной диагонали
/*
Console.Clear();
Console.WriteLine("количествл строк массива ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("количествл столбцов массива ");
int columns = int.Parse(Console.ReadLine());
 
int [,] array = FillArray(rows, columns, 1, 10);
 
PrintArray(array);
Console.WriteLine();
DiagonalArray(array);
 
void DiagonalArray (int [,] array){
    int sum = 0;
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            if (i == j ){
                sum += array[i,j];
        }
    }
}
Console.WriteLine(sum);
}
int [,] FillArray (int rows, int columns, int min, int max){
    int [,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void PrintArray(int [,] filledArray){
    for (int i = 0; i < filledArray.GetLength(0); i++){
        for (int j = 0; j < filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
} 
*/
 
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
Console.Clear();
Console.WriteLine("количествл строк массива ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("количествл столбцов массива ");
int columns = int.Parse(Console.ReadLine());
 
double [,] array = FillArray(rows, columns, 0, 10);
PrintArray(array);
double [,] FillArray (int rows, int columns, int min, int max){
    double [,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i, j] = Convert.ToDouble(new Random().Next(0, 10)) / 10;
        }
    }
    return array;
}
void PrintArray(double [,] filledArray){
    for (int i = 0; i < filledArray.GetLength(0); i++){
        for (int j = 0; j < filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Console.Clear();
Console.WriteLine("количествл строк массива ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("количествл столбцов массива ");
int columns = int.Parse(Console.ReadLine());
 
int [,] array = FillArray(rows, columns, 1, 10);
PrintArray(array);
int [,] FillArray (int rows, int columns, int min, int max){
    int [,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void PrintArray(int [,] filledArray){
    for (int i = 0; i < filledArray.GetLength(0); i++){
        for (int j = 0; j < filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/
 
//задайте двумерный массив. напишите программу котрая поменяет местами первую и последнюю строку массива
 
/*
Console.Clear();
Console.WriteLine("количествл строк массива ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("количествл столбцов массива ");
int columns = int.Parse(Console.ReadLine());
 
int [,] array = FillArray(rows, columns, 1, 10);
 
PrintArray(array);
Console.WriteLine("новый массив");
 
PrintArray(TransformationArray(array));
 
int [,] TransformationArray (int [,] filledArray){
    int [,] TransformationArray = new int[rows, columns];
    for (int i = 0; i < 1; i++){
        for (int j = 0; j < columns; j++){
            TransformationArray[i,j] = filledArray[rows -1,j];
        }
    }
    for (int i = 1; i < rows -1; i++){
        for (int j = 0; j < columns; j++){
            TransformationArray[i,j] = filledArray[i,j];
        }
    }
    for (int i = rows - 1; i < rows; i++){
        for (int j = 0; j < columns; j++){
            TransformationArray[i,j] = filledArray[0,j];
        }
    }
    return TransformationArray;
}
int [,] FillArray(int rows, int columns, int min, int max){
    int [,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i,j] = new Random().Next(min, max );
        }
    }
    return array;
}
void PrintArray(int [,] filledArray){
    for (int i = 0; i < filledArray.GetLength(0); i++){
        for (int j = 0; j < filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/
 
//задайте двумерный массив. напишите программу котрая заменяет строки на столбцы.если это невозможно, программа должна вывести сообщение
/*
Console.Clear();
Console.WriteLine("количествл строк массива ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("количествл столбцов массива ");
int columns = int.Parse(Console.ReadLine());
 
int [,] array = FillArray(rows, columns, 1, 10);
 
PrintArray(array);
Console.WriteLine("новый массив");
 
PrintArray(TransformationArray(array));
 
int [,] TransformationArray (int [,] filledArray){
    int [,] TransformationArray = new int[rows, columns];
    if(rows == columns){
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < columns; j++){
                TransformationArray[i,j] = filledArray[i,j];
            }
        }   
    }
    else
    {
       Console.WriteLine("это не возможно'");
       return new int[0, 0];
    }
    return TransformationArray;
}
 
int [,] FillArray(int rows, int columns, int min, int max){
    int [,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i,j] = new Random().Next(min, max );
        }
    }
    return array;
}
void PrintArray(int [,] filledArray){
    for (int i = 0; i < filledArray.GetLength(0); i++){
        for (int j = 0; j < filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/
/* 
//составить частотный словарь элементов двумерного масива. 
//частотный словарь содержит информацию о том сколько раз встречается элемент входных данных
Console.Clear();
Console.WriteLine("количествл строк массива ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("количествл столбцов массива ");
int columns = int.Parse(Console.ReadLine());
 
int [,] array = FillArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine(String.Join(" ", FrequencyDictionary(array)));
 
int [] SortArray =FrequencyDictionary(array);
Array.Sort(SortArray);
PrintData(SortArray);
 
void PrintData(int [] inArray){
    int el = inArray[0];
    int count=1;
    for (int i = 1; i < inArray.Length; i++){
        if(inArray[i]!=el){
            Console.WriteLine($"{el} встречается {count}");
            el=inArray[i];
            count=1;
        }
        else
            count++;
    }
    Console.WriteLine($"{el} встречается {count}");
}
int [] FrequencyDictionary(int [,] filledArray){
    int [] frequencyDictionary = new int[filledArray.GetLength(0)*filledArray.GetLength(1)];
    int count= 0;
    for (int i = 0; i < filledArray.GetLength(0); i++){
        for (int j = 0; j < filledArray.GetLength(1); j++){
            frequencyDictionary[count] = filledArray[i, j];
            count++;
        }
    }
    return frequencyDictionary;
}
int [,] FillArray(int rows, int columns, int min, int max){
    int [,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i,j] = new Random().Next(min, max);
        }
    }
    return array;
}
 
void PrintArray(int [,] filledArray){
    for (int i = 0; i < filledArray.GetLength(0); i++){
        for (int j = 0; j < filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
 
// задайте двумерный массив из целых чисел. 
//напишите программу которая удалит сторку и столбецб напересечении которых расположен наименьший элемент массива
 
//вывести первые N строк треугольника паскаля. сделать вывод в виде равнобедренного треугольника


//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(numbers);
 
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < numbers.GetLength(1) - 1; z++)
        {
            if (numbers[i, z] < numbers[i, z + 1]) 
            {
                int temp = 0;
                temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(numbers);
 
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
 
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
*/
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] table = new int[4, 4];
FillArrayRandom(table);
PrintArray(table);
Console.WriteLine();
NumberRowMinSumElements(table);


 
void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < table.GetLength(1); i++)
    {
        minRow += table[0, i];
    }
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка с наименьшей суммой элементов");
}
 
// Функция вывода двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
 
// Функция заполнения массива рандомно числами от 1 до 9
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
*/
//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
Console.Clear();
 
Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");
 
int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMartrix);
 
int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secomdMartrix);
 
int[,] resultMatrix = new int[m,p];
 
MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);
 
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
 
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
 
void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}
 
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
*/
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
Console.Clear();
Console.WriteLine($"Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
Console.WriteLine($"\nВведите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");
 
int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);
 
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
 
void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
 
void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
*/
 
//Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int n = 4;
int[,] sqareMatrix = new int[n, n];
 
int temp = 1;
int i = 0;
int j = 0;
 
while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}
 
WriteArray(sqareMatrix);
 
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");
 
      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}


//Задайте значение N Напишите программу котроая выведет все натуральные числа от 1 до N
/*
using static System.Console;
Clear();
Write("введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int m =1;
NaturalNumbers (m, n);
 
int NaturalNumbers (int m,  int n){
    if(m==n){
        Write($"{n} ");
        return n;
    }
    else{
       Write($"{m} ");
        m++; 
    }
    return NaturalNumbers(m,n);
}
WriteLine();
*/
 
//Напишите программу которая будет принимать на вход число и возвращать сумму его цифр при помощи рекурсии
/*
using static System.Console;
Clear();
Write("введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int sum =0;
WriteLine(SumNumbers(n, ref sum));
int SumNumbers(int n, ref int sum){
    sum += n% 10;
    if( n/10 !=0){
        SumNumbers(n/10, ref sum);
    }
    return sum;
}
WriteLine();
*/
