int[] ResizeArray(int[] arr, int a)
    {
        int[] newArr = new int[a];
        int elementsToCopy = Math.Min(arr.Length, a);
        for (int i = 0; i < elementsToCopy; i++)
        {
            newArr[i] = arr[i];
        }
        return newArr;
    }
int[] myArray = { 1, 2, 3, 4, 5 };
myArray = ResizeArray(myArray, 3);
Console.WriteLine(string.Join(", ", myArray));