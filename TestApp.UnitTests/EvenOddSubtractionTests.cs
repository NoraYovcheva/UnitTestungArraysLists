using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

   
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] array = new int[] { 2, 4, 6, 8};

        // Act
        int actual = EvenOddSubtraction.FindDifference(array);

        // Assert
        Assert.That(actual, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] array = new int[] { 1, 3, 5 };

        // Act
        int actual = EvenOddSubtraction.FindDifference(array);

        // Assert
        Assert.That(actual, Is.EqualTo(-9));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

        // Act
        int actual = EvenOddSubtraction.FindDifference(array);

        // Assert
        Assert.That(actual, Is.EqualTo(3));
    }
}
