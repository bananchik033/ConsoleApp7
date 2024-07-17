Console.Write("Введите число: ");
int b = int.Parse(Console.ReadLine());
int n = 0;
for (int i = 1; i<b; i++)
{
    if (b%i==0)
    {
        n += i;
    }   
}
if (b != n) { Console.WriteLine("число несовершенное"); }
else Console.WriteLine("Число совершенное");

