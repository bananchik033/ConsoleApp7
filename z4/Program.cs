Console.Write("Напишите число, что бы проверить является ли четное или не четное оно:");
int h = int.Parse(Console.ReadLine()!);
if(h % 2 == 0)
{
    Console.Write("Четное");
}
else 
{
    Console.Write("Не четное");
}