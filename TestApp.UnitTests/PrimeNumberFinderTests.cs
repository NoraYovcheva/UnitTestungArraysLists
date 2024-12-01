using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeNumberFinderTests
{
    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithLessThanOrEqualToOneElementsOnly_ReturnsEmptyArray()
    {
        //Arrange
        int[] array = new int[] { -1, 0, 1 };

        //Act
        int[] actual= PrimeNumberFinder.GetAllPrimeNumbers(array);

        //Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOneNonPrimeNumber_ReturnsEmptyArray()
    {
        //Arrange
        int[] array = new int[] { 4 };

        //Act
        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(array);

        //Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithNoPrimeNumbersOnly_ReturnsEmptyArray()
    {
        //Arrange
        int[] array = new int[] { 4, 6, 8, 9 };

        //Act
        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(array);

        //Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOnePrimeNumber_ReturnsArrayWithTheSameNumber()
    {
        //Arrange
        int[] array = new int[] { 4, 6, 7, 8 };
        int[] expected = new int[] { 7 };

        //Act
        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(array);

        //Assert
        //Assert.That(actual, Is.EqualTo(expected));
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithMixedNumbers_ReturnsArrayOnlyWithPrimeNumbers()
    {
        //Arrange
        int[] array = new int[] { 2, 4, 6, 7, 8, 5 };
        int[] expected = new int[] { 2, 7, 5 };

        //Act
        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(array);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
