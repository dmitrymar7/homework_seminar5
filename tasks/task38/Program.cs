// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int count = 10;
double[] array = new double[count];
double max = 0;
double min = 0;
for (int i = 0; i < array.Length; i++ ){
    array[i] = new Random().Next(100);
    if (i == 0){
        max = array[i];
        min = array[i];
    }
    else if (array[i] > max){
        max = array[i];
    }
    else if (array[i] < min){
        min = array[i];
    }   
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Разность максимального {max} и минимального {min} равна: {max - min}");