Console.WriteLine("Enter a number of the array");
int numbers = int.Parse(Console.ReadLine());

int GetArray(int size, int minValue, int maxValue)
  {
    int[] res = new int[size];
    int sum = 0;
    Console.Write("Array:");


    for (int i=0; i<res.Length;i++)
    {
    res[i] = new Random().Next(minValue, maxValue+1);

    Console.Write(res[i] + " ");

    if( i % 2 != 0)
    {
        sum = sum + res[i];
    }
   }
  return sum;
  }
  int res = GetArray(numbers, -10, 10);

  Console.WriteLine($"\nSum of the odd places {res} ");