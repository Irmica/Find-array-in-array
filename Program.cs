string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i += 1)
    {
        Console.Write($"Введите {i + 1}-ю строку: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

Console.WriteLine("Введите количество анализируемых строк:");
int sizeText = Convert.ToInt32(Console.ReadLine());

string[] TextArray = CreateArray(sizeText);

Console.WriteLine("Введите количество строк для поиска:");
int sizeFound = Convert.ToInt32(Console.ReadLine());

string[] FindArray = CreateArray(sizeFound);
string reserv = "";

for (int f = 0; f < sizeFound; f+=1)
{
   for (int t = 0; t < TextArray.Length; t+=1)
   {
     while( t < TextArray.Length && reserv != TextArray[t])
     {reserv = TextArray[t];
     if (FindArray[f] ToLower  )
     }
   }
}
