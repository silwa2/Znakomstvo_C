void fillarrey (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection [index] = new Random().Next(1, 10);
        index++;
    }
}
void printarrey (int[] col)
{
int count = col.Length;
int position = 0;
while (position < count)
{
    Console.WriteLine(col [position]);
    position++;
}
}
int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
          position = index;
          break;
        }
        index++;
    }
    return position;
}

int[] arrey = new int[10];

fillarrey(arrey);
printarrey(arrey);

Console.WriteLine();
int pos = indexOf(arrey, 4);
Console.WriteLine (pos);