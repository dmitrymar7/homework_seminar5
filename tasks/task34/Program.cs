//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int count = 10;
int[] array = new int[count];
int countEvent = 0;
for (int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + "\t");
    if (array[i] % 2 == 0){
        countEvent += 1;
    }   
}
Console.WriteLine();
Console.WriteLine($"количество чётных чисел в массиве: {countEvent}");