public class longestCommonPrefix
{
    public string LongestCommonPrefix(string[] str)
    {
        if (str == null || str.Length == 0)
            return "";

        string prefix = strs[0];

        for (int i = 1; i < str.Length; i++)
        {
            while (!str[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);

                if (prefix == "")
                    return "";
            }
        }

        return prefix;
    }
}
