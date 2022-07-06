//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int ShowSecondDigit( ) {
    int number = Convert.ToInt32(Console.ReadLine());
    int num1 = number/10;
    int num2 = num1%10;
    int result =num2;
return  result;

}
Console.WriteLine("Input three digit number"  );
 int res = ShowSecondDigit();
   Console.WriteLine(res);