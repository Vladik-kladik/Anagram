using NUnit.Framework;
using Test1_Anagram;

namespace Unit_Test_Anagram;


    public class Tests
    {

        [Test]
        public void Revers_ValidWord_returnsRevers()
        {
            Anagram anagram = new Anagram();
            string reversedSentence = anagram.Reverse("a1bcd efg!h");
            Assert.That(reversedSentence, Is.EqualTo("d1cba hgf!e"));
        }
        
        [Test]
        public void ReverseWord_WithNonAlnon_alphabetic_characters()
        {
            Anagram anagram = new Anagram();
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
           
        }
      
    }
