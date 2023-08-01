/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
  либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

// задаём переменные 
string vvod = Console.ReadLine();
string[] all_mas = new string []{"idsrew","-23","546345",vvod};
string[] new_mas = new string []{};
int zamen = 0 ;
for (int z = 0; z < all_mas.Length; z++)
{
    if(all_mas[z].Length <= 3)
    {
        Console.WriteLine(all_mas[z]);
        new_mas[zamen] = all_mas[z];
        zamen++;
        Console.WriteLine(new_mas[zamen]);
    } 
    //else;



}



Console.Write("[" ); 
for (int i = 0; i < all_mas.Length; i++)
{


   Console.Write("'"+ all_mas[i]+"'"+", "); 
}
Console.Write("]" ); 