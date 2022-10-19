Console.Clear();
string? check = "";
while (check.ToLower() != "да" && check.ToLower() != "нет")
{
  Console.Write("Вводить строки вручную? (да/нет): ");
  check = Console.ReadLine();
}

string[] array = new string[]  {};

if (check.ToLower() == "да") {
Console.Write("Введите количество элементов массива ");
int arrayLen = int.Parse(Console.ReadLine());

  array = new string[arrayLen];
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write("Введите " + i + "-ю строку: ");
    array[i] = Console.ReadLine();
  }
}
else 
{
  array = new string[]  {"hello", "2", "world", ":-)"};
}

int limit = 3;

int numbersItems = CheckArray(array, limit);

string[] newArray = new string[numbersItems];

FillNewArray(array, newArray, limit);

Console.WriteLine(PrintArray(newArray));


void FillNewArray(string[] previousArray, string[] newArray, int limit)
{
  int temp = 0;
  for (int i = 0; i < previousArray.Length; i++)
  {
    if (previousArray[i].Length <= limit)
    {
      newArray[temp] = previousArray[i];
      temp++;
    }
  }
}

int CheckArray(string[] array, int limit)
{
  int result = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= limit) result++;
  }
  return result;
}

string PrintArray(string[] array)
{ 
  string result = string.Empty;
  result = "[ ";
  for (int i = 0; i < array.Length; i++)
  {
    result += array[i];
    if (i < array.Length - 1) result += ", ";
  }
  result += " ]";
  return result;
}