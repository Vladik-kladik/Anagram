namespace Test1_Anagram;

public class Anagram
{
<<<<<<< HEAD
        protected string ReversedWord(string userinput)
=======
        public string ReversedWord(string userinput)
>>>>>>> origin/main
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
    }

    public string Reverse(string userinput)
    {
        if (userinput == null)
        {
            return null;
        }
<<<<<<< HEAD
        
        string[] natureWords = userinput.Split(' ');
        
        for (int i = 0; i < natureWords.Length; i++)
        {
            natureWords[i] = ReversedWord(natureWords[i]);
        }
        return string.Join(" ", natureWords);
        
=======
        string[] natureWords = userinput.Split(' ');
        foreach (var word in natureWords)
        {
            int index = Array.IndexOf(natureWords, word);

            natureWords[index] = Reverse(word);
        }
        return string.Join(" ", natureWords);
>>>>>>> origin/main
    }
}
