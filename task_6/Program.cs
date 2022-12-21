// task_6 program takes a number and outputs 
//if the number is ordinary

Console.WriteLine("Input number");
int numberA = int.Parse  (Console.ReadLine()!);
if (numberA%2==0)
Console.WriteLine(numberA+" is an ordinary number");
else 
Console.WriteLine(numberA+ " is an odd number");