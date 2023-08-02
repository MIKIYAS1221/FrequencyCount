using System;
using System.Collections.Generic;

namespace FrequencyCount;

public class Palindrome
{

    static Boolean CheckPalidrome(string input)
    {
        int i = 0;
        int j = input.Length - 1;
        while (i < j)
        {
            if (input[i] != input[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
    
    
}