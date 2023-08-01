/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
  либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

// 1 задаём переменные 
Console.WriteLine("Впишите любое количество символов");
string vvod = Console.ReadLine();
string[] all_mas = new string []{"idsrew","-23","546345",vvod};
string[] new_mas = new string [all_mas.Length];
int zamen = 0 ;
// 2 Проверка и перенос данных масисва 
for (int z = 0; z < all_mas.Length; z++)
{
    if(all_mas[z].Length <= 3)
    {
        new_mas[zamen] = all_mas[z];
        zamen++;
    } 
    
}
// 3 Вывод первоначальных данных в консоль
Console.Write("[" ); 
for (int i = 0; i < all_mas.Length; i++)
{
   Console.Write("'"+ all_mas[i]+"'"+", "); 
}
Console.Write("] -> [  " ); 
 
// 4 Вывод проверенных данных в консоль
for (int gg = 0; gg < new_mas.Length; gg++)
{   
    Console.Write(new_mas[gg]+" "); 
}
Console.Write("]" );