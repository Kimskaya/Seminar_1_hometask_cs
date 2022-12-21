//task_8 program takes a number 
//and shows all the ordinary numbers from 1 to number

Console.WriteLine("Input number");
int number = int.Parse (Console.ReadLine()!);
int  NumberOrd= 2;

while (NumberOrd <= number)
    {
        NumberOrd++; 
    }
    if (NumberOrd%2==0)
 
 Console.WriteLine(NumberOrd+"");