using System;
using System.Collections.Generic;
using System.Linq;
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

            //Asert
            Assert.That(result, Is.EqualTo(6));

            //Eller
            Assert.That(uut.Add(8, 2), Is.EqualTo(10));
            Assert.That(uut.Add(16, 4), Is.EqualTo(20));

        }

        [Test]
        //Subtraktion
        public void Subtract_SubtractAandB_Result()
        {
            //Act
            var result = uut.Subtract(8, 4);

            //Asert
            Assert.That(result, Is.EqualTo(4));

            //Eller
            Assert.That(uut.Subtract(8, 4), Is.EqualTo(4));
            Assert.That(uut.Subtract(10,5),Is.EqualTo(5));
            Assert.That(uut.Subtract(20, 10), Is.EqualTo(10));

        }

        [Test]
        //Multiplikation
        public void Multiply_MultiplyAandB_Return64()
        {
            //Act
            var result = uut.Multiply(7, 7);

            //Asert
            Assert.That(result, Is.EqualTo(49));

            //Eller
            Assert.That(uut.Multiply(7, 7), Is.EqualTo(49));
            Assert.That(uut.Multiply(6, 4), Is.EqualTo(24));
            Assert.That(uut.Multiply(8, 2), Is.EqualTo(16));

        }

        [Test]
        public void Power_NumberAandB_Result()
        {
            //Act
            var result = uut.Power(8, 8);

            //Asert
            Assert.That(result, Is.EqualTo(16777216));

            //Eller
            Assert.That(uut.Power(8, 8), Is.EqualTo(16777216));
        }

    }
}
