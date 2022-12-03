// See https://aka.ms/new-console-template for more information

//declearing variables
int num1, num2, exchangeNum;

Console.Write("Enter First Number: ");
num1= Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Second Number: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("First number is {0}, Second number is {1}", num1, num2);

//swapping values
exchangeNum = num1;
Console.WriteLine("exchange num is : {0}", exchangeNum);
num1 = num2;
num2 = exchangeNum;
Console.WriteLine("First number is {0}, Second number is {1}", num1, num2);
