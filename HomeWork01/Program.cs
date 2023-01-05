


int[] Print(int[] arr)
{
    int[] myArray = { };
    foreach (var item in arr)
    {
        myArray = myArray.Append(item).ToArray();
    }
    return myArray;
}
