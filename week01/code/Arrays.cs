public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // PLAN:
        // Step 1: Create a new array of size 'length' to store the result.
        // Step 2: Use a for loop to fill in each position of the array.
        //         - At index i, store number * (i + 1)
        //         - This gives us multiples: number * 1, number * 2, ..., number * length
        // Step 3: After filling the array, return it.

        // Step 1: Create the result array
        double[] result = new double[length];

        // Step 2: Loop through the array and fill it with multiples
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1); // each value is the (i+1)th multiple of 'number'
        }

        // Step 3: Return the filled array
        return result;
    }


    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>

    public static void RotateListRight(List<int> data, int amount)

    {

        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // PLAN:
        // Step 1: Understand that rotating right by 'amount' means taking the last 'amount' elements
        //         and moving them to the front of the list.
        // Step 2: Use GetRange() to get the last 'amount' elements of the list.
        // Step 3: Remove those elements from the end using RemoveRange().
        // Step 4: Insert the extracted elements at the beginning using InsertRange().

        // Step 1: Calculate the starting index for the elements to move to the front
        int startIndex = data.Count - amount;

        // Step 2: Use GetRange to get the last 'amount' elements
        List<int> slice = data.GetRange(startIndex, amount);

        // Step 3: Remove the last 'amount' elements from the original list
        data.RemoveRange(startIndex, amount);

        // Step 4: Insert the slice at the beginning of the list
        data.InsertRange(0, slice);
    }

}
