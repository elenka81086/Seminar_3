/*Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.*/


Console.WriteLine("Введите число: "); 
int NewNumber = Convert.ToInt32(Console.ReadLine());
int NamberTheCube = 1;
while (NamberTheCube <= NewNumber)
{
    Console.WriteLine($"Для числа {NamberTheCube} куб составляет {NamberTheCube * NamberTheCube * NamberTheCube + ""}");
    NamberTheCube++;
   
}
