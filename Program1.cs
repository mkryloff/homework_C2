System.Console.Write("Введите трехзначное число: ");
string a = Console.ReadLine();
int number = Convert.ToInt32(a);
number = number/10;
number = number%10;
System.Console.Write(number);

