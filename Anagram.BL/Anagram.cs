<<<<<<< HEAD
using System.Text;

=======
>>>>>>> 673484d (1. Створив Класси, переназвав їх згідно із вправками)
namespace Test1_Anagram;

public class Anagram
{
<<<<<<< HEAD
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
=======
        public string ReversedWord(string userinput)
    {
        if (userinput == null)
        {
            return null;
        }

        char[] charArray = userinput.ToCharArray();
        
        int start = 0;
        int end = charArray.Length - 1;
        while (start < end)
        {
            char temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;

            start++;
            end--;
        }
        return new string(charArray);
>>>>>>> 673484d (1. Створив Класси, переназвав їх згідно із вправками)
    }

    public string Reverse(string userinput)
    {
        if (userinput == null)
        {
<<<<<<< HEAD
            return string.Empty;
        }
        
        string[] natureWords = userinput.Split(' ');
        var sb = new StringBuilder();

        foreach (var word in natureWords)
        {
           sb.Append(string.Join(' ', natureWords.Select(ReversedWord)));
        }

        sb.Remove(sb.Length - 1, 1);
        return sb.ToString();
=======
            return null;
        }
        string[] natureWords = userinput.Split(' ');
        foreach (var word in natureWords)
        {
            int index = Array.IndexOf(natureWords, word);

            natureWords[index] = Reverse(word);
        }
        return string.Join(" ", natureWords);
>>>>>>> 673484d (1. Створив Класси, переназвав їх згідно із вправками)
    }
}
