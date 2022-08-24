//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int number;
while (true) {
    Console.Write("Введите трёхзначное число: ");
    number = int.Parse(Console.ReadLine());

    if (number < 100) {
        Console.WriteLine("В введённом числе нет третьей цифры. Поробуйте ещё раз.");
    }
    else break;
}

string strNumber = System.Convert.ToString(number);
Console.WriteLine(strNumber[1]);