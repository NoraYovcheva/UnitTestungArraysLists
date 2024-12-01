using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class EvenLengthWordsFilterTests
{
    [Test]
    public void Test_GetEvenWords_InputArrayWithEmptyStrings_ShouldReturnEmptyString()
    {
        //Arrange
        string[] words = new string[] { "", "" };
        string expected = string.Empty;

        //Act
        string actual = EvenLengthWordsFilter.GetEvenWords(words);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneOddLengthWord_ShouldReturnEmptyString()
    {
        //Arrange
        string[] words = new string[] { "abc" };
        string expected = string.Empty;

        //Act
        string actual = EvenLengthWordsFilter.GetEvenWords(words);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayOnlyWithOddLengthWords_ShouldReturnEmptyString()
    {
        //Arrange
        string[] words = new string[] { "abc", "hello", "abcabca" };
        string expected = string.Empty;

        //Act
        string actual = EvenLengthWordsFilter.GetEvenWords(words);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneEvenLengthWord_ShouldReturnSameWord()
    {
        //Arrange
        string[] words = new string[] { "nora" };
        string expected = "nora";

        //Act
        string actual = EvenLengthWordsFilter.GetEvenWords(words);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithEvenAndOddLengthWords_ShouldReturnOnlyEvenLengthWords()
    {
        //Arrange
        string[] words = new string[] { "nora", "abc", "hello", "kuku" };
        string expected = "nora kuku";

        //Act
        string actual = EvenLengthWordsFilter.GetEvenWords(words);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

