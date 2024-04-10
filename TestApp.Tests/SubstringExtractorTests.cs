using NUnit.Framework;
using System.Data.SqlTypes;
using System;

namespace TestApp.Tests;

[TestFixture]
public class SubstringExtractorTests
{
    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        // Arrange
        string input = "aaa bbb zzz";
        string startMarker = "aaa";
        string endMarker = "zzz";

        string expectedResult = " bbb ";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "aaa bbb zzz";
        string startMarker = "ccc";
        string endMarker = "zzz";

        string expectedResult = "Substring not found";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "aaa bbb ccc";
        string startMarker = "aaa";
        string endMarker = "zzz";

        string expectedResult = "Substring not found";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "aaa bbb ccc";
        string startMarker = "kkk";
        string endMarker = "zzz";

        string expectedResult = "Substring not found";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "";
        string startMarker = "aaa";
        string endMarker = "zzz";

        string expectedResult = "Substring not found";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "aabbb";
        string startMarker = "aa";
        string endMarker = "ab";

        string expectedResult = "Substring not found";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
