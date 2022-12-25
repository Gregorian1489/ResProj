// Написать программу, которая из имеющегося массива строк формирует маасив строк,
// длина которых меньше либо равна 3 символа

Console.WriteLine("Введите строковый массив через пробел");
string line = Console.ReadLine();
string [] array = line.Split(' ');
string [] array1 = new string[array.Length];
int j = 0;

for (int i = 0; i<array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        array1[j] = array[i];
        Console.Write(array1[j]+" ");
    }
    j++;
}

