int N=10;
Console.WriteLine($"Введите {N} значений массива ");
string?[] array= GetArrayConsole(N);
//Заполняем массив значениями строк
Console.WriteLine($"Введите значения массива ");
string?[] GetArrayConsole(int n)

{string?[] res = new string?[n];
for (int i=0; i<10; i++)
{
       res[i] = Console.ReadLine();
}
return res;

}


