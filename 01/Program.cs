// int fioat bool double
//int a =0;
//float b = 5.2f;
//string c = "hello";
//bool d = false; // true
//double e = 10000000000.2f;

// Console.ReadLine - получение даных из терминала
// Convert.ToInt32 - из строки преобразовываем в число
// Console.WriteLine -выводит текст на экран


//int number1 = Convert.ToInt32(Console.ReadLine());
//int number2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(number1+number2);




int secretNumber = 7;
int popytki = 3;
while(popytki>0)
bool flagWin = false;
{
    Console.WriteLine("Ввудите число от 1 до 10");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    popytki-=1;//popytki--
    if(userNumber>secretNumber)
    {
        Console.WriteLine("Секретное число меньше");
        Console.WriteLine("Попыток осталось"+ popytki ");
    }else if(userNumber<secretNumber)
    {
        Console.WriteLine("Секретное число больше");
    }
    else
    {
        Console.WriteLine("Мы выиграли");
        flagWin = true;
        break;
    }

}if (!flagWin)
{
        Console.WriteLine("Мы проиграли. Числ было" +secretNumber);
}
