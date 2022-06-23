int[] array = { 11, 21, 38, 74, 57, 86, 47, 11, 8 };

int n = array.Length;
int find = 11;

int index = 0;

while (index<n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
   index++;
}