// See https://aka.ms/new-console-template for more information
using лаба_2;

int n;
Console.WriteLine("Введите кол-во людей:");
n=Convert.ToInt16(Console.ReadLine());
Person[] Vadic = new Person[n];
for (int i=0; i<n; i++)
{
    Vadic[i] = new Person();
}
for (int i = 0; i < n; i++)
{
    Vadic[i].vvod();
}
for (int i = 0; i < n; i++)
{
    Console.WriteLine(Vadic[i]);
}
