int x = 7;
int count = 0;
for (int i =1;i<=x; i++)
{
    if (x %i == 0)
    {
        count++;
    }
}
if (x == 1)
{
    Console.WriteLine("1 ne sadedir ne murekkeb");
}
else if (count > 2) 
{
    Console.WriteLine("say murekkebdir");
}
else
{
    Console.WriteLine("say sadedir");
}