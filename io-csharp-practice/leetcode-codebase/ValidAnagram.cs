using System;

class ValidAnagram
{
    public bool IsAnagram(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;

        char[] str1 = s1.ToCharArray();
        char[] str2 = s2.ToCharArray();

        Array.Sort(str1);
        Array.Sort(str2);

        return new string(str1) == new string(str2);
    }
}
