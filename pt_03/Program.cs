// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void getNumber(string massage){
    System.Console.WriteLine(massage);
    Random rnd = new Random();
    int count = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите минимальный порог случайных значений");

    int minVal = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine("Введите максимальный порог случайных значений");

    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[] result = new int[count];

    for (int i = 0;i < result.Length;i++){
        System.Console.WriteLine(result[i] = rnd.Next(minVal, maxVal));
        
    }
    
} 

getNumber("введите количество элементов массива");

