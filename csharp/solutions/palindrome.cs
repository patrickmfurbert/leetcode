// https://leetcode.com/problems/palindrome-number/description/

public class Palindrome
{
    public bool solve(int number)
    {
        //convert number to a String
        //convert string to char array
        bool isPalindrome = true;

        char[] numberArray = number.ToString().ToCharArray();

        for (int i = 0, j = numberArray.Length - 1; i <= j; i++, j--)
        {
            if (numberArray[i] != numberArray[j])
            {
                isPalindrome = false;
                break;
            }
        }

        return isPalindrome;
    }
}
