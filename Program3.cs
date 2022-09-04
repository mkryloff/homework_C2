System.Console.Write("Введите порядковый номер дня недели: ");
string a = Console.ReadLine();
int daynumber = Convert.ToInt32(a);
if(daynumber == 6 || daynumber == 7)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}