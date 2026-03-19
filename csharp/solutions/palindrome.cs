// https://leetcode.com/problems/palindrome-number/description/

public class Palindrome
{
    public bool solve(int number)
    {
        //convert number to a String
        string numberArray = number.ToString();

        //loop through string numberArray
        //loop contains two index pointers, i and j starting at opposite ends of the numberArray
        //check if element at i and element at j equal, if not retunn false
        for (int i = 0, j = numberArray.Length - 1; i <= j; i++, j--)
        {
            if (numberArray[i] != numberArray[j])
            {
                return false;
            }
        }

        return true;
    }
}
