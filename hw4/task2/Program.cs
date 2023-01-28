// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

System.Console.Write("Введите число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
int Sumnumber(int numberN)
{
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;
    for (int i = 0; i < counter; i++) 
    {
        advance = numberN - numberN % 10;
        result = result + (numberN - advance);
        numberN = numberN / 10;
    }
    return result;
}
int sumnumber = Sumnumber(numberN);
System.Console.WriteLine("Сумма цифер в числе" + sumnumber);