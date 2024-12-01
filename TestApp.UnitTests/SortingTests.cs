using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.UnitTests;

public class SortingTests
{
    [Test]
    public void Test_ShallowAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        //Arrange
        double[] array = Array.Empty<double>();

        //Act
        double[] actual = Sorting.ShallowAscendingSort(array);

        //Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_DeepAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        // Arrange
        double[] array = Array.Empty<double>();

        //Act
        double[] actual = Sorting.DeepAscendingSort(array);

        //Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_ShallowAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesNotChangeTheOriginalArray()
    {
        // Arrange
        double[] unsortedArray = new double[] { 4.2, 3.5, 1.8 };

        double[] expectedSortedArray = new double[] { 1.8, 3.5, 4.2 };
        double[] expectedUnsortedArray = new double[] { 4.2, 3.5, 1.8 };

        //Act
        double[] actual = Sorting.ShallowAscendingSort(unsortedArray);

        //Assert
        CollectionAssert.AreEqual(expectedSortedArray, actual);
        CollectionAssert.AreEqual(expectedUnsortedArray, unsortedArray);
    }

    [Test]
    public void Test_DeepAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesChangeTheOriginalArray()
    {
        // Arrange
        double[] unsortedArray = new double[] { 4.2, 3.5, 1.8 };

        double[] expectedSortedArray = new double[] { 1.8, 3.5, 4.2 };
        double[] unsortedArrayAfterDeepSort = new double[] { 1.8, 3.5, 4.2 };

        //Act
        double[] actual = Sorting.DeepAscendingSort(unsortedArray);

        //Assert
        CollectionAssert.AreEqual(expectedSortedArray, actual);
        CollectionAssert.AreEqual(unsortedArrayAfterDeepSort, unsortedArray);
    }
}
