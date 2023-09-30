
namespace DataStructures.RecursiveBinaryTree;

public class FindIndex
{

    public FindIndex()
    {
        int[] numbers = { 45, 54, 86, 85, 32, 69, 96, 35, 73, 18 };

        var indexIteration = FindIndex_IT(numbers, 96, 0);
        var indexRecursive = FindIndex_Recursive(numbers, 54, 0);

    }
    int FindIndex_Recursive(int[] numbers, int val, int startIndex)
    {
        // Exit Condition
        if (startIndex >= numbers.Length)
            return -1;

        // Actual Process
        if (numbers[startIndex] == val)
            return startIndex;

        // Re-Calling
        return FindIndex_Recursive(numbers, val, startIndex + 1);
    }


    int FindIndex_IT(int[] numbers, int val, int startIndex)
    {
        for (int i = startIndex; i < numbers.Length - startIndex; i++)
        {
            if (numbers[i] == val)
                return i;
        }
        return -1;
    }
}
