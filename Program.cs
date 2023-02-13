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
Console.WriteLine($"[ {String.Join(" ,", array)} ]");// Вывод в консоль исходного массива

//ПРОверка условия длина строки меньше 3 символов и определение количества элементов в новом массиве
int count=0; 

for (int i=0; i<N; i++)
{
   
 if(array[i].Length <= 3) count+=1;

}
string?[] arrayNew = FillArray(count);
string?[] FillArray(int a)
{string?[] res = new string?[a];
 Console.WriteLine(count);
int j=0; 

for (int i=0; i<N; i++)
{
   
 if(array[i].Length <= 3)  
 {res[j]=array[i];
 Console.WriteLine(res[j]);
 j+=1;}
}
return res;
}



