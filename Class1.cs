using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void GetAddition_Input13point4and51point6_Returns65point0()
        {//Arrange 
            double number1 = 13.4;
            double number2 = 51.6;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetAddition_Input10point4and15point6_Returns26point0()
        {//Arrange 
            double number1 = 10.4;
            double number2 = 15.6;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input33point4and35point6_Returns69point0()
        {//Arrange 
            double number1 = 33.4;
            double number2 = 35.6;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }




        [Test]
        public void GetSubtraction_Input13point4and1point4_Returns12point0()
        {//Arrange 
            double number1 = 13.4;
            double number2 = 1.4;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetSubtraction_Input10point6and5point6_Returns5point0()
        {//Arrange 
            double number1 = 10.6;
            double number2 = 5.6;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input33point6and30point6_Returns3point0()
        {//Arrange 
            double number1 = 33.6;
            double number2 = 30.6;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetMultiplication_Input3point0and3point0_Returns9point0()
        {//Arrange 
            double number1 = 3.0;
            double number2 = 3.0;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input13point0and12point0_Returns156point0()
        {//Arrange 
            double number1 = 13.0;
            double number2 = 12.0;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input10point0and15point5_Returns155point0()
        {//Arrange 
            double number1 = 10.0;
            double number2 = 15.5;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetDivision_Input10point0and2point0_Returns5point0()
        {//Arrange 
            double number1 = 10.0;
            double number2 = 2.0;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input9point0and2point0_Returns4point5()
        {//Arrange 
            double number1 = 9.0;
            double number2 = 2.0;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input9point0and3point0_Returns3point0()
        {//Arrange 
            double number1 = 9.0;
            double number2 = 3.0;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
