using System;

class ArrayResizer
{
	private void ResizeArray(ref string[,] original, int rows, int cols)
    {
        string[,] newArray = new string[rows, cols];
        Array.Copy(newArray, original, newArray.Length);
    }
}
