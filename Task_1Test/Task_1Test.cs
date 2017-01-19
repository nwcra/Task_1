using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Task_1;

namespace Task_1Test
{
    [TestClass]
    public class Task_1Test
    {
        public bool DictonaryEquals(Dictionary<string, string> firstDictonary, Dictionary<string, string> secondDictionary)
        {

            if (firstDictonary.Count != secondDictionary.Count)
                return false;

            bool result = firstDictonary.OrderBy(pair => pair.Key)
               .SequenceEqual(secondDictionary.OrderBy(p => p.Key)) && firstDictonary.OrderBy(p => p.Value)
               .SequenceEqual(secondDictionary.OrderBy(p => p.Value));

            return result;
        }

        [TestMethod]
        public void TestSortMethod()
        {
            //arrange
            Dictionary<string, string> unsorted = new Dictionary<string, string>
            { 
                 {"Казань", "Орел"},
                 {"Хабаровск", "Киров"},
                 {"Питербург", "Хабаровск"},
                 {"Орел", "Питербург"},
                 {"Новгород", "Казань"},
                 {"Москва", "Новгород"},
            };

            Dictionary<string, string> expected = new Dictionary<string, string>
            { 
                  {"Москва", "Новгород"},
                  {"Новгород", "Казань"},
                  {"Казань", "Орел"},
                  {"Орел", "Питербург"},
                  {"Питербург", "Хабаровск"},
                  {"Хабаровск", "Киров"},
            };
            //act
            Dictionary<string, string> actual = Program.Sort(unsorted);

           
            //assert
 
            Assert.IsTrue(DictonaryEquals(expected, actual));
        }
    }
}
