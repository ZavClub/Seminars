//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int sumNum(int num) {
    for(int i = 1; i <= num; i++){
        Console.Write($"{i} ");
    }
    return 0;
}



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
sumNum(number);
