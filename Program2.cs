System.Console.Write("Введите трехзначное число: ");
string a = Console.ReadLine();
if(a.Length==3)
{
    int number = Convert.ToInt32(a);
    number = number%10;
    System.Console.Write(number); 
}
else
{
   System.Console.Write("Третьей цифры нет"); 
}