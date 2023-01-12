int[] CreateRandomArrey(int size, int minValue, int maxValue){

    int[] array = new int[size];

    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write(array [i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArrey(length, min, max);

ShowArray(newArray);