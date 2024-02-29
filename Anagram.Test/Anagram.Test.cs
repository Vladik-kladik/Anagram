using NUnit.Framework;
using Test1_Anagram;

namespace Unit_Test_Anagram;


    public class Tests
    {

        [Test]
        public void Revers_ValidWord_returnsRevers()
        {
            Anagram anagram = new Anagram();
<<<<<<< HEAD
            string reversedSentence = anagram.Reverse("Hello World!");
            Assert.That(reversedSentence, Is.EqualTo("olleH !dlroW"));
=======
            string reversedSentence = anagram.ReversedWord("Hello World!");
            Assert.That(reversedSentence, Is.EqualTo("!dlroW olleH"));
>>>>>>> origin/main
        }
        
      
        [Test]
        public void ReverseWord_WithNonAlnon_alphabetic_characters()
        {
            Anagram anagram = new Anagram();
<<<<<<< HEAD
            string reversedSentence = new Anagram().Reverse("123abc!412");
=======
            string reversedSentence = new Anagram().ReversedWord("123abc!412");
>>>>>>> origin/main
            Assert.That(reversedSentence, Is.EqualTo("214!cba321"));
        }
        
        [Test]
        public void ReverseWord_NullWord_ReturnsNull()
        {
           var anagram = new Anagram();
<<<<<<< HEAD
           string reversedSentence = anagram.Reverse(null);
=======
           string reversedSentence = anagram.ReversedWord(null);
>>>>>>> origin/main
           Assert.Null(reversedSentence);
        }
        
        [Test]
        public void Reverse_NullWord_ReturnsNull()
        {
            var anagram = new Anagram();
            string reversedSentence = anagram.Reverse(null);
            Assert.Null(reversedSentence);
        }
      
    }
