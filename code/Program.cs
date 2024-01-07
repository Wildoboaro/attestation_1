string [] ShotStringFinder(string [] inputArray)
{
    string [] outputArray= new string[inputArray.Length]; 
    int resCount = 0;
    foreach(string elemStr in inputArray)
    {
        if (elemStr.Length <= 3)
        {
            outputArray[resCount] = elemStr;
            resCount++;
        }
    }
    Array.Resize(ref outputArray, resCount);
    return outputArray;
}

Console.Clear();
// string[] stringArray = {"Russia", "Denmark", "Kazan"};
 string[] stringArray = {"1234", "1567", "-2", "computer science"};
// string[] stringArray = {"Hello", "2", "world", ":-)"};
string[] stringResult = ShotStringFinder(stringArray);
Console.WriteLine(String.Join(", ", stringResult));
