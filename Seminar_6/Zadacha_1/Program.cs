// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// int [] array = GetArray (10,0,10);
// Console.WriteLine(String.Join(",",array));

// ReversArray(array);
// Console.WriteLine(String.Join(",",array));

// int [] GetArray(int size, int minValue, int  maxValue)
// {
//     int[] res = new int [size];
//     for(int i=0; i<size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue+1);

//     }
//     return res;

// }

// void ReversArray(int [] inArray)
// {
//     for(int i=0; i<inArray.Length/2; i++)
//     {
//         int k = inArray[i];
//         inArray[i] = inArray[inArray.Length-1-i];
//         inArray[inArray.Length-1-i] = k;

//     }

// }





// Напишите программу, которая принимает 
// на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.


// Console.WriteLine("Введите стороны треугольника(a,b,c): ");
// double number1 = Convert.ToDouble(Console.ReadLine());
// double number2 = Convert.ToDouble(Console.ReadLine());
// double number3 = Convert.ToDouble(Console.ReadLine());


// void CheckTriangle(double a,double b,double c)
// {
//     if( a < b + c && b < c + a && c < a + b)
//     {
//         Console.WriteLine("треугольник со сторонами такой длины может существовать.");
//     }
//     else
//     {
//         Console.WriteLine("такой треугольник не существует");
//     }
// }
// CheckTriangle(number1,number2,number3);



// Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10



// 1-й способ
// int value = 8;
// string binary = Convert.ToString(value, 2);


// 2-й способ
// void ConvertNum(int number)
// {
//     string resalt = "";
//     while(number>0)
//     {
//         resalt = number%2+resalt;
//         number/=2;

//     }
//     Console.WriteLine(resalt);

// }
// int intput= Convert.ToInt32(Console.ReadLine());
// ConvertNum(intput);




// Не используя рекурсию, 
// выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.WriteLine("Введите число n ");
int num = Convert.ToInt32(Console.ReadLine());

int firstNum = 0;
int secondNum = 1;
Console.Write(firstNum + ", ");
Console.Write(secondNum );

for(int i = 3; i <= num; i++)
{
    int newNum = firstNum + secondNum;
    Console.Write(" ," + newNum );
    firstNum = secondNum;
    secondNum = newNum;
}
Console.ReadKey();








