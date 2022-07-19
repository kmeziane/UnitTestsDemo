using System.Collections.Generic;
using UnitTestsDemo;
using UnitTestsDemo.Tests;
using Xunit;

namespace UnitTestDemo.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [ClassData(typeof(TestData))]
        public void CalculateAverage_PositiveNumbersAsParam_ReturnAverage(double a, double b, double expectedResult)
        {
            // Modèle AAA

            // Arrange
            var calculator = new Calculator();

            // Act
            var actualAverage = calculator.CalculateAverage(a, b);

            // Assert
            Assert.Equal(expectedResult, actualAverage);
        }

        [Theory]
        [InlineData(-10, -20)]
        [InlineData(-10, 20)]
        [InlineData(1, -1)]
        [InlineData(-1, double.MinValue)]
        public void CalculateAverage_AtLeastOneNegativeNumberAsParam_ThrownException(double a, double b)
        {
            // Arrange
            var calculator = new Calculator();

            // Act & Assert
            Assert.Throws<System.ArgumentException>(() => calculator.CalculateAverage(a, b));
        }

        [Theory]
        [InlineData(1, 2, 3)]
        public void CalculateSum_PositiveNumbersAsParam_ReturnSum(double a, double b, double expectedSum)
        {
            var calculator = new Calculator();

            var actualSum = calculator.CalculateSum(a, b);

            Assert.Equal(expectedSum, actualSum);
        }

        [Theory]
        [MemberData(nameof(GetStudents))]
        public void CalculateStudentsAverageMark_Students_ReturnAverage(Student student, double expectedAverage)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actualAverage = calculator.CalculateMarksAverage(student);

            // Assert
            Assert.Equal(expectedAverage, actualAverage);
        }

        public static IEnumerable<object[]> GetStudents()
        {
            yield return new object[] {
                new Student
                {
                    Name = "Toto1",
                    Marks = new List<int> { 10, 20 }
                }
                , 15
            };

            yield return new object[] {
                new Student
                {
                    Name = "Toto2",
                    Marks = new List<int> { 10, 16 }
                }
                , 13
            };
        }
    }
}