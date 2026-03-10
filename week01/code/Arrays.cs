using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

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

        //Empty array that numbers will be stored in
        double[] numbers = new double[length];
        //This is a loop that will count from zero all the way to the length, which will give us the index,
        //and based on that index, we can calculate our multiples.
        for (int i = 0 ; i < numbers.Length ; i++)
        {
            numbers[i] = (i + 1) * number; //This gets the multiples by multiplying the index + 1 with the number
            //(0+1) * 7 = 7
            //(0+2) * 7 = 14
        }

        return numbers; // return array
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

        //We will use the slice method to get the values that will be rotated to the right
        List<int> newList = data.GetRange(data.Count-amount, amount);
        //Use slice method to get values that won't be rotated
        List<int> oldList = data.GetRange(0, data.Count - amount);
        //Start over to arrange list accordingly
        data.Clear();
        //Attach the new list
        data.AddRange(newList);
        //Attach the other end
        data.AddRange(oldList);

    }
}
