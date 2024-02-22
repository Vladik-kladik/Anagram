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
            string reversedSentence = anagram.Reverse("a1bcd efg!h");
            Assert.That(reversedSentence, Is.EqualTo("d1cba hgf!e"));
        }
        
=======
            string reversedSentence = anagram.ReversedWord("Hello World!");
            Assert.That(reversedSentence, Is.EqualTo("!dlroW olleH"));
        }
        
      
>>>>>>> 5b70903 (переназва тест за назвою класу)
        [Test]
        public void ReverseWord_WithNonAlnon_alphabetic_characters()
        {
            Anagram anagram = new Anagram();
<<<<<<< HEAD
            string reversedSentence = new Anagram().Reverse("  a1bcd    efg!h");
            Assert.That(reversedSentence, Is.EqualTo("  d1cba    hgf!e"));
        }
        
        [Test]
        public void Reverse_WithNullOrEmptyInput()
        {
            var anagram = new Anagram();
            
            var resultNull = anagram.Reverse(null);
            var resultEmpty = anagram.Reverse(string.Empty);
            
            Assert.AreEqual(string.Empty, resultNull);
            Assert.AreEqual(string.Empty, resultEmpty);
           
=======
            string reversedSentence = new Anagram().ReversedWord("123abc!412");
            Assert.That(reversedSentence, Is.EqualTo("214!cba321"));
        }
        
        [Test]
        public void ReverseWord_NullWord_ReturnsNull()
        {
           var anagram = new Anagram();
           string reversedSentence = anagram.Reverse(null);
           Assert.Null(reversedSentence);
        }
        
        [Test]
        public void Reverse_NullWord_ReturnsNull()
        {
            var anagram = new Anagram();
            string reversedSentence = anagram.Reverse(null);
            Assert.Null(reversedSentence);
>>>>>>> 5b70903 (переназва тест за назвою класу)
        }
      
    }
