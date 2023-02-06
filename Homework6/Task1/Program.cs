/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */


System.Console.WriteLine("Введите количество чисел: ");
int amount = Convert.ToInt32 (Console.ReadLine());
int[] arr = GetArray(amount);
//PrintArray(arr);
int result = GetSumOfPositiveNum (arr);
System.Console.WriteLine( $"В массиве {result} чисел больше 0");



int [] GetArray(int length)
{
int[] array = new int[length];

   for (int i=0; i<length; i++)
    {

        System.Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    
    }
    return array; 
}

//void PrintArray (int[]arr)
// {
//     foreach (int item in arr)
//     {
//         System.Console.Write(item + ", ");
//     }
//     System.Console.WriteLine();
// }

int GetSumOfPositiveNum(int[]array)
{
    int count=0;
    for(int i=0; i<array.Length; i++)
    {
       
        if (array[i] >0) count++;
    }
    return count;
}

    
    

    




