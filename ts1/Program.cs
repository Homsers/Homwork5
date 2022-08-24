Console.WriteLine("Enter a number of the array");
int numbers = int.Parse(Console.ReadLine());

int[] GetArray(int size, int minValue,int maxValue)
{   
    int[] res = new int[size];
    Console.Write("Array: ");

    for (int i=0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int[] array = GetArray(numbers, 100, 999);


int even = 0;
int odd = 0;
foreach(int g in array)
{
    if 
    (g % 2 == 0)
    even++;
    
    else 
    odd++;
}

Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"{even} numbers is even");
Console.WriteLine($"{odd} numbers is odd");
