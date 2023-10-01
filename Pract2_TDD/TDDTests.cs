using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDD;

namespace Pract2_TDD
{
    [TestClass]
    public class TDDTests
    {
        [TestMethod]
        public void Shortest_word_Wereturned()//1
        {
            string line = "вы что-то хотели"; //что есть
            string expected = "вы"; //хотим получить

            WorkWithString sw = new WorkWithString();
            string actual = sw.Shortest_word(line);

            StringAssert.Contains(expected, actual);
        }
        [TestMethod]
        public void Numb_of_words_2returned()//2
        {
            string line = "Что случилось?"; //что есть
            int expected = 2; //хотим получить

            WorkWithString sw = new WorkWithString();
            int actual = sw.Numb_of_words(line);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Numb_of_char_3returned()//3
        {
            string line = "XO_OX"; //что есть
            int expected = 5; //хотим получить

            WorkWithString sw = new WorkWithString();
            int actual = sw.Numb_of_char(line);

            Assert.IsFalse(actual != expected);
        }
        [TestMethod]
        public void Ninth_char_иreturned()//4
        {
            string line = "Девятыйсимвол"; //что есть
            char expected = 'и'; //хотим получить

            WorkWithString sw = new WorkWithString();
            char actual = sw.Ninth_char(line);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Num_of_digits_4returned()//5
        {
            string line = "1234tt";
            int expected = 4;

            WorkWithDigits sw = new WorkWithDigits();
            int actual = sw.Num_of_digits(line);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Finding_the_largest_number_of_consecutive_digits_3returned()//6
        {
            string line = "jk3454545j5667 4lkh34 hethe656 56d56"; //что есть
            int expected = 7; //хотим получить

            WorkWithDigits sw = new WorkWithDigits();
            int actual = sw.Finding_the_largest_number(line);

            Assert.AreEqual(expected, actual);  

        }
        [TestMethod]
        public void Finding_am()//7
        {
            string line = "амаед или Адамас?"; //что есть
            int expected = 2; //хотим получить

            WorkWithString sw = new WorkWithString();
            int actual = sw.Finding_am(line);

            Assert.IsTrue(actual == expected, $"Ожидалось {expected}, получено {actual}");
        }

    }
}
