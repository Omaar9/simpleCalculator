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
            // TestCases
            [TestCase(8, 2, 10)]
            [TestCase(16, 4, 20)]
            [TestCase(20, 5, 25)]
            [TestCase(30, 40, 70)]
            [TestCase(50, 50, 100)]

        public void Add_AddAandB_Result(double a, double b, double forventet)
            {
                //Act
                var result = uut.Add(a, b);

                //Assert
                Assert.That(result, Is.EqualTo(forventet));
            }


            // TestCases
            [TestCase(-3, 9, 6)]
            [TestCase(-4, 10, 6)]
            [TestCase(12, -6, 6)]
            [TestCase(20, -10, 10)]
            [TestCase(30, -15, 15)]

        public void Add_AddPosAndNeg_Result(double a, double b, double forventet)
            {
                //Act
                var result = uut.Add(a, b);

                //Assert 
                Assert.That(result, Is.EqualTo(forventet));
            }

            //Subtraktion
            [TestCase(8, 4, 4)]
            [TestCase(10, 5, 5)]
            [TestCase(20, 10, 10)]
            [TestCase(30, 15, 15)]
            [TestCase(25, 10, 15)]

        public void Subtract_SubtractAandB_Result(double a, double b, double forventet)
            {
                //Act
                var result = uut.Subtract(a, b);

                //Assert
                Assert.That(result, Is.EqualTo(forventet));
            }

            // TestCases
            //Subtraktion og negativ nummer
            
            [TestCase(-3, 9, -12)]
            [TestCase(-4, 10, -14)]
            [TestCase(12, -6, 18)]
            [TestCase(10, -5, 15)]
            [TestCase(15, -6, 21)]

        public void Subtract_SubtractPosAndNeg_Result(double a, double b, double forventet)
            {
                //Act
                var result = uut.Subtract(a, b);

                //Assert 
                Assert.That(result, Is.EqualTo(forventet));
            }

        // TestCases
            //Multiplikation
            [TestCase(7, 7, 49)]
            [TestCase(6, 4, 24)]
            [TestCase(8, 2, 16)]
            [TestCase(5, 4, 20)]
            [TestCase(3, 9, 27)]

        public void Multiply_MultiplyAandB_Result(double a, double b, double forventet)
            {
                //Act
                var result = uut.Multiply(a, b);

                //Assert
                Assert.That(result, Is.EqualTo(forventet));
            }

            //TestCases
            //Power
            [TestCase(8, 2, 64)]
            [TestCase(2, 3, 8)]
            [TestCase(1, 4, 1)]
            [TestCase(6, 2, 36)]
            [TestCase(7, 2, 49)]

        public void Power_NumberAandB_Result(double a, double b, double forventet)
            {
                //Act
                var result = uut.Power(a, b);

                //Asert
                Assert.That(result, Is.EqualTo(forventet));

                
            }

        }
}
