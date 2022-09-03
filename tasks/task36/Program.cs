// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int count = 4;
int[] array = new int[count];
int sum = 0;
for (int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(100);
    Console.Write(array[i] + "\t");
    if (i % 2 != 0){
        sum += array[i];
    }   
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетной позиции: {sum}");