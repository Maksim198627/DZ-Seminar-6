// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// Значения b1, k1, b2 и k2 задаются пользователем.

System.Console.Write("Введите точку прямой k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку прямой b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите точку прямой k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку прямой b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine();

var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
System.Console.WriteLine($"Пересечение произойдет в точке: ({x};{y})");

System.Console.WriteLine("Для продолжения нажмите любую кнопку: ");
Console.ReadKey();