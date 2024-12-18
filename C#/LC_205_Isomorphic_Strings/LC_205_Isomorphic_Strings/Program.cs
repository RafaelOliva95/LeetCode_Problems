using System.IO.IsolatedStorage;

public class Program
{
    public static void Main(string[] args)
    {
        bool result = IsIsomorphic("foo", "bar");
        Console.WriteLine(result);
    }
    public static bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> values = new Dictionary<char, char>();
        if (s.Length != t.Length)
            return false;
        for (int i = 0; i < s.Length; i++)
        {
            if (values.ContainsKey(s[i]))
            {
                if (values[s[i]] != t[i])
                {
                    return false;
                }
            }
            else
            {
                if (values.ContainsValue(t[i]))
                {
                    return false;
                }
                values.Add(s[i], t[i]);
            }
        }

        return true;
    }
}