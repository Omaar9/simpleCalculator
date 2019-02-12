using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture] // Collects test cases, gives us setup/teardown
    public class CalcultorUnitTest
    {
        private simpleCalculator.Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new simpleCalculator.Calculator();
        }

        [Test]
        //Addition
        public void Add_AddAandB_Result()
        {
            //Act
            var result = uut.Add(2, 4);

            //Assert
            Assert.That(result, Is.EqualTo(6));
        }

        // TestCases
        [TestCase(8, 2, 10)]
        [TestCase(16, 4, 20)]
        [TestCase(20, 5, 25)]

        public void Add_AddPosAndNeg_Result()
        {
            //Act
            var result = uut.Add(-2, 4);

            //Assert 
            Assert.That(result, Is.EqualTo(2));
        }

        // TestCases
        [TestCase(-3, 9, 6)]
        [TestCase(-4, 10, 6)]
        [TestCase(12, -6, 6)]

        //Subtraktion
        public void Subtract_SubtractAandB_Result()
        {
            //Act
            var result = uut.Subtract(8, 4);

            //Assert
            Assert.That(result, Is.EqualTo(4));
        }

        // TestCases
        [TestCase(8, 4, 4)]
        [TestCase(10, 5, 5)]
        [TestCase(20, 10, 10)]

        public void Subtract_SubtractPosAndNeg_Result()
        {
            //Act
            var result = uut.Subtract(-2, 4);

            //Assert 
            Assert.That(result, Is.EqualTo(-6));
        }

        // TestCases
        [TestCase(-3, 9, -12)]
        [TestCase(-4, 10, -14)]
        [TestCase(12, -6, 18)]

        //Multiplikation
        public void Multiply_MultiplyAandB_Return49()
        {
            //Act
            var result = uut.Multiply(7, 7);

            //Assert
            Assert.That(result, Is.EqualTo(49));
        }

        [TestCase(7, 7, 49)]
        [TestCase(6, 4, 24)]
        [TestCase(8, 2, 16)]

        public void Power_NumberAandB_Result()
        {
            //Act
            var result = uut.Power(8, 2);

            //Asert
            Assert.That(result, Is.EqualTo(64));

            //Eller
            Assert.That(uut.Power(8, 2), Is.EqualTo(64));
        }
        //[TestCase(8, 2, 64)]
        //[TestCase(2, 3, 8)]
        //[TestCase(1, 4, 1)]
    
    }
}
