//task_8 program takes a number 
//and shows all the ordinary numbers from 1 to number

Console.WriteLine("Input number");
int number = int.Parse(Console.ReadLine()!);
int  NumberOrd= 2;

while (NumberOrd <= number)
    {
        Console.WriteLine(NumberOrd+"");
        NumberOrd=NumberOrd+2; 
    }