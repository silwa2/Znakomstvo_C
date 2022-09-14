// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string result = Convert.ToString(num);
// Console.WriteLine("количество цифр="+ KolvoCifr(result) );

// int KolvoCifr (string num)
// {
// int size=num.Length;
// return size;

// }


// Console.WriteLine("Введите число ");
//  int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Колличество цифр "+GetCount(num) );

//  int GetCount(int number)
//  {
//     int count =0;
//     while(number>0)
//     {
//         count++;
//         number/=10;

//     }
//     return count;

//  }

// string num = Console.ReadLine();
// int CountingDigits(string num)
// {
//     return num.Length;
// }
// Console.WriteLine(CountingDigits(num));

// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.WriteLine("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(num + " -> " + GetSum(num));

// int GetSum(int number)
// {
//     int pr = 1;
//     int count = 0;
//     while (number > count)
//     {
//         count++;
//         pr *= count;
//     }
//     return pr;
// }

// int num = Convert.ToInt32(Console.ReadLine());

// int GetProduct(int num)
// {
//     int prod = 1;
//     for(int i = 1; i <= num; i++)
//     {
//         prod*=num;
//     }

//     return prod;
// }

// Console.WriteLine(GetProduct(num));


// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];

// // заполняем массив
// void FillArray(int[] collection) {
// 	int length = collection.Length;
// 	int index = 0;
// 	while (index < length) {
// 		collection[index] = new Random().Next(0, 2);
// 		index++;
// 	}
// }

// // выводим массив
// void PrintArray(int[] col) {
// 	int count = col.Length;
// 	int position = 0;
// 	while (position < count) {
// 		Console.Write(col[position]);
// 		position++;
// 	}
// }

// FillArray(array);
// PrintArray(array);

int []array = GetArray(8);
Console.WriteLine(string.Join(",",array));

int [] GetArray(int size)
{
    int [] result = new int [size];
    for(int i=0; i< size;i++)
    {
        result[i] = new Random().Next(0,2);


    }
    return result;

}








