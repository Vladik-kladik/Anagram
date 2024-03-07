using System.Text;

namespace Test1_Anagram;

public class Anagram
{
    private string ReversedWord(string userinput)
    {
        var natureWords = new StringBuilder();
        var idx = userinput.Length - 1;

        for (var i = 0; i < userinput.Length; i++)
        {
            if (char.IsLetter(userinput[i]))
            {
                while (!char.IsLetter(userinput[idx]))
                {
                    idx--;
                }
                natureWords.Append(userinput[idx]);
                idx--;
            }
            else
            {
                natureWords.Insert(i, userinput[i]);
            }
        }
        return natureWords.ToString();
    }

    public string Reverse(string userinput)
    {
        if (userinput == null)
        {
            return string.Empty;
        }
        
        string[] natureWords = userinput.Split(' ');
        var sb = new StringBuilder();

        foreach (var word in natureWords)
        {
           sb.Append(string.Join(' ', natureWords.Select(ReversedWord)));
        }

        sb.Remove(sb.Length - 1, 1);
        var result = String.Join("", natureWords);
        return result;
    }
}
