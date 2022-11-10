Console.WriteLine("Enter string with capital letter");
string  userInput = Console.ReadLine();
List<int> indices = new List<int>();
for(int i =0; i<= userInput.Length-1; i++)
{
  if(userInput[i] >='A' && userInput[i] <='Z')
  {
    indices.Add(i);
  }
}
foreach(int index in indices)
{
  Console.WriteLine($"Index:{index}\t Value:{userInput[index]}");
}