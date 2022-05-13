// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] strArr = {"asdr", "qw", "-31"};

string[] ShredStringArray (string[] inputStrArray)
{
    int counter = 0;
    for (int i = 0; i < inputStrArray.Length; i++)
    {
        if (inputStrArray[i].Length <= 3)
            counter++;
    }

    if (counter != 0)
    {
        string[] resStrArr = new string[counter];
        int j = 0;
        for (int i = 0; i < inputStrArray.Length; i++)
        {            
            if (inputStrArray[i].Length <= 3)
            {
                resStrArr[j] = inputStrArray[i];
                j++;
            }
        }

        return resStrArr;
    }
    else
    {
        return new string[] { };
    }
}

Console.WriteLine(String.Join(" ", ShredStringArray(strArr)));