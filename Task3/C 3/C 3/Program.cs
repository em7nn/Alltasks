int y = 13355;
int count = 0;
for (int i = 0; i < y; i++)
{
    y /= 10;
    if (y > 0)
    {
        count++;
    }
}
Console.WriteLine(count + 1);