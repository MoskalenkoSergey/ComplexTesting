using Microsoft.VisualStudio.TestTools.UnitTesting;
using test;
using System;
using System.Windows.Controls;
using System.Reflection;
using System.Text.RegularExpressions;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        // Тест, который проверяет, что подсчитанное колличество баллов верное в 1 варианте
        [TestMethod]
        public void calcBonusesVarOne_Correctly()
        {
            int expected = 14;
            string[] otvet = new string[17];
            otvet[0] = "Pizza";
            otvet[1] = "could read in English";
            otvet[2] = "every week";
            otvet[3] = "write a book";
            otvet[4] = "True";
            otvet[5] = "False";
            otvet[6] = "True";
            otvet[7] = "weather";
            otvet[8] = "Pizza";
            otvet[9] = "book";
            otvet[10] = "interesting";
            otvet[11] = "happy";
            otvet[12] = "better";
            otvet[13] = "-";
            otvet[14] = "wrote";
            otvet[15] = "was";
            otvet[16] = "Does";
            int actual = RezultVar1.calcBonusesVarOne(otvet);
            Assert.AreEqual(expected, actual);
        }

        // Тест, который проверяет, что неправильный результат не является верным в 1 варианте
        [TestMethod]
        public void calcBonusesVarOne_DontCorrectly()
        {
            int expected = 10;
            string[] otvet = new string[17];
            otvet[0] = "-";
            otvet[1] = "-";
            otvet[2] = "-";
            otvet[3] = "write a book";
            otvet[4] = "-";
            otvet[5] = "-";
            otvet[6] = "True";
            otvet[7] = "-";
            otvet[8] = "-";
            otvet[9] = "book";
            otvet[10] = "-";
            otvet[11] = "happy";
            otvet[12] = "-";
            otvet[13] = "-";
            otvet[14] = "wrote";
            otvet[15] = "was";
            otvet[16] = "Does";
            int actual = RezultVar1.calcBonusesVarOne(otvet);
            Assert.AreNotEqual(expected, actual);
        }

        // Тест, который проверяет функционал, если все ответы не верны
        [TestMethod]
        public void calcBonusesVarOne_CorrectlyZero()
        {
            int expected = 0;
            string[] otvet = new string[17];
            otvet[0] = "";
            otvet[1] = "";
            otvet[2] = "";
            otvet[3] = "";
            otvet[4] = "";
            otvet[5] = "";
            otvet[6] = "";
            otvet[7] = "";
            otvet[8] = "";
            otvet[9] = "";
            otvet[10] = "";
            otvet[11] = "";
            otvet[12] = "";
            otvet[13] = "";
            otvet[14] = "";
            otvet[15] = "";
            otvet[16] = "";
            int actual = RezultVar1.calcBonusesVarOne(otvet);
            Assert.IsTrue(expected == actual);
        }

        // Тест, который проверяет, что подсчитанное колличество баллов верное во 2 варианте
        [TestMethod]
        public void calcBonusesVarTwo_Correctly()
        {
            int expected = 17;
            string[] otvet = new string[22];
            otvet[0] = "A";
            otvet[1] = "D";
            otvet[2] = "B";
            otvet[3] = "C";
            otvet[4] = "ten";
            otvet[5] = "on Sunday";
            otvet[6] = "at 2 o'clock";
            otvet[7] = "a bicycle";
            otvet[8] = "books";
            otvet[9] = "Post offier";
            otvet[10] = "Second";
            otvet[11] = "Angry";
            otvet[12] = "Funnier";
            otvet[13] = "Skate";
            otvet[14] = "danse";
            otvet[15] = "goes";
            otvet[16] = "much";
            otvet[17] = "a lot of";
            otvet[18] = "fifteenth";
            otvet[19] = "She lives in a lake.";
            otvet[20] = "But most of all she likes travelling.";
            otvet[21] = "Every day she travels to another lake to visit her friends Pat and Pit.";
            int actual = RezultVar2.calcBonusesVarTwo(otvet);
            Assert.AreEqual(expected, actual);
        }
        
        // Тест, который проверяет, что неправильный результат не является верным во 2 варианте
        [TestMethod]
        public void calcBonusesVarTwo_DontCorrectly()
        {
            int expected = 14;
            string[] otvet = new string[22];
            otvet[0] = "A";
            otvet[1] = "D";
            otvet[2] = "B";
            otvet[3] = "C";
            otvet[4] = "ten";
            otvet[5] = "on Sunday";
            otvet[6] = "at 2 o'clock";
            otvet[7] = "a bicycle";
            otvet[8] = "books";
            otvet[9] = "Post offier";
            otvet[10] = "Second";
            otvet[11] = "-";
            otvet[12] = "-";
            otvet[13] = "-";
            otvet[14] = "-";
            otvet[15] = "-";
            otvet[16] = "-";
            otvet[17] = "a lot of";
            otvet[18] = "fifteenth";
            otvet[19] = "-";
            otvet[20] = "But most of all she likes travelling.";
            otvet[21] = "Every day she travels to another lake to visit her friends Pat and Pit.";
            int actual = RezultVar2.calcBonusesVarTwo(otvet);
            Assert.IsFalse(expected == actual);
        }

        // Тест, который проверяет, что метод выводит результат с корректным типом данных
        [TestMethod]
        public void calcBonusesVarTwo_CorrectlyType()
        {
            string[] otvet = new string[22];
            otvet[0] = "A";
            otvet[1] = "D";
            otvet[2] = "B";
            otvet[3] = "C";
            otvet[4] = "ten";
            otvet[5] = "on Sunday";
            otvet[6] = "at 2 o'clock";
            otvet[7] = "a bicycle";
            otvet[8] = "books";
            otvet[9] = "Post offier";
            otvet[10] = "Second";
            otvet[11] = "Angry";
            otvet[12] = "Funnier";
            otvet[13] = "Skate";
            otvet[14] = "danse";
            otvet[15] = "goes";
            otvet[16] = "much";
            otvet[17] = "a lot of";
            otvet[18] = "fifteenth";
            otvet[19] = "She lives in a lake.";
            otvet[20] = "But most of all she likes travelling.";
            otvet[21] = "Every day she travels to another lake to visit her friends Pat and Pit.";
            int actual = RezultVar2.calcBonusesVarTwo(otvet);
            Assert.IsInstanceOfType(actual, typeof(int));
        }
    }
}
