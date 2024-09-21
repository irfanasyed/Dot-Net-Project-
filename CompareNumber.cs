

Console.WriteLine("enter the value1");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the value2");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"[{(num1< num2 ? num1 : num2)}, {(num1 > num2 ? num1: num2)}]");

