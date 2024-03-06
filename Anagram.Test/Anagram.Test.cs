using NUnit.Framework;
using Test1_Anagram;

namespace Unit_Test_Anagram;


    public class Tests
    {
        private Anagram _anagram;
        
        [SetUp]
        public void SetUp()
        {
            _anagram = new Anagram();
        }

        [TearDown]
        public void TearDown()
        {
            _anagram = null;
        }

        [Test]
        public void Revers_ValidWord_returnsRevers()
        {
            
            // act
            string reversedSentence = _anagram.Reverse("a1bcd efg!h");
            // assert
            Assert.That(reversedSentence, Is.EqualTo("d1cba hgf!e"));
        }
        
      
        [Test]
        public void ReverseWord_WithNonAlnon_alphabetic_characters()
        {
            
            // act
            string reversedSentence = _anagram.Reverse("  a1bcd    efg!h");
            //assert
            Assert.That(reversedSentence, Is.EqualTo("  d1cba    hgf!e"));
        }
        
               
        [Test]
        public void Reverse_WithNullOrEmptyInput()
        {
            
            // act
            var resultNull = _anagram.Reverse(null);
            var resultEmpty = _anagram.Reverse(string.Empty);
            // assert
            Assert.AreEqual(string.Empty, resultNull);
            Assert.AreEqual(string.Empty, resultEmpty);
           
        }
      
    }
