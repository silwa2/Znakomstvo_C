// конвентирование с помощью char

// int num = 6529;
// string resalt=Convert.ToString(num);

// int sum =(int) char.GetNumericValue(resalt[0]);
// Console.WriteLine(sum)



// сложение числа
// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(GetSum(num));

// int GetSum(int number)
// {
//     int sum=0;
//     while(number>0)
//     {
//         sum+=number%10;
//         number/=10;

//     }
//     return sum;

// }


// Задайте массив из 12 элементов, заполненный случайными числами 
//из промежутка [-9, 9]. Найдите сумму отрицательных и 
//положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
//сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int [] array= new int [12];
// int size= array.Length;

// int positiveSum=0;
// int negativeSum=0;

// for(int i=0;i<size; i++)
// {
//     array[i]=new Random().Next(-9,10);

//     if(array[i]>0)
//     {
//         positiveSum+=array[i];

//     }
//     else
//     {
//         negativeSum+=array[i];

//     }

// }
// Console.WriteLine("Сумма положительных чисел = "+ positiveSum+" | Сумма отрицательных чисел"+negativeSum);
// Console.WriteLine(String.Join(";",array)); // в массиве ставятся ;


// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int [] inputArray= {1,2,3,4,5};


// int [] resultArray=new int[inputArray.Length/2 + inputArray.Length%2];

// for(int i=0;i<resultArray.Length;i++)
// {
//     resultArray[i]= inputArray[i]*inputArray[inputArray.Length-1-i];

//     if(i==(inputArray.Length-1-i))
//     {
//         resultArray[i]=inputArray[i];

//     }


// }
// Console.WriteLine(String.Join(",",resultArray));


// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int [] array= {-4, -8, 8, 2};
// for(int i=0; i < array.Length; i++)
// {
// 	array[i]*=-1;
// }

// Console.WriteLine("[{0}]", String.Join(",", array));


// Задайте массив. Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

for (int i = 0; i < size; i++)
	{
	array[i] = new Random().Next(-9,10);
	}

Console.WriteLine("[{0}]",String.Join(";",array));

Console.WriteLine("Введите искомое число ");
int necessaryNumber = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < size; i++)
	{
		if(array[i] == necessaryNumber)
		{
			count++;
		}
	}
if (count > 0) 
	{
	Console.WriteLine($"Это число найдено в количестве: {count}");
	}
else
{
	Console.WriteLine("Чисел нет");
}

// второй вариант

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// string result = "нет";
// int [] array= {6, 7, 19, 345, 3};
// for(int i=0; i < array.Length; i++)
// {
// 	if(array[i]== num)
// 	{
// 		result = "да";
// 	}
	
// }
// Console.WriteLine(result);



