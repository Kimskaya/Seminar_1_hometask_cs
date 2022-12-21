//task_4. Program takes 3 numbers and outputs the biggest
Console.WriteLine("Input number");
int number1 = int.Parse  (Console.ReadLine()!);

Console.WriteLine("Input number");
int number2 = int.Parse (Console.ReadLine()!);

Console.WriteLine("input number");
int number3 = int.Parse(Console.ReadLine()!);
if (number1>number2)

Console.WriteLine(number1+ " is max");
else if (number2 > number3)
Console.WriteLine(number2+" is max");
else 
Console.WriteLine(number3+" is max");