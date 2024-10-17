namespace HackerRank.Challenges.Algorithms.Tests;

//TODO fix old tests with assert
//TODO create separate files to each group of test
public class UnitTests
{
    [Fact]
    public void DesignerPdfViewerTest()
    {
        var resultDesignerPdfViewer = DesignerPdfViewer.GetHighlightedText(
        [
            1,
            3,
            1,
            3,
            1,
            4,
            1,
            3,
            2,
            5,
            5,
            5,
            5,
            5,
            5,
            5,
            5,
            5,
            5,
            5,
            5,
            5,
            5,
            5,
            5,
            5
        ], "abc");
    }

    [Fact]
    public void CatsAndAMouseTest()
    {
        var resultGetCatsVersusMouse = CatsAndAMouse.GetCatsVersusMouse(1, 2, 3);
        var resultGetCatsVersusMouse2 = CatsAndAMouse.GetCatsVersusMouse(3, 1, 2);
    }

    [Fact]
    public void BillDivisionTest()
    {
        BillDivision.PrintBillDivision([2, 4, 6], 2, 3);
        BillDivision.PrintBillDivision([2, 4, 6], 2, 6);
    }

    [Fact]
    public void MigratoryBirdsTest()
    {
        var migratoryBirdsResult = MigratoryBirds.GetBirdsFrequency([1, 1, 2, 2, 3]);
        var migratoryBirdsResult2 = MigratoryBirds.GetBirdsFrequency([1, 4, 4, 4, 5, 3]);
        var migratoryBirdsResult3 = MigratoryBirds.GetBirdsFrequency([1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4, 1, 4]);
        var migratoryBirdsResult4 = MigratoryBirds.GetBirdsFrequency([2, 2, 1, 1, 3]);
    }

    [Fact]
    public void DivisibleSumPairTest()
    {
        var divisibleSumPairs = DivisibleSumPairs.GetNumberOfPairs(6, 3, [1, 3, 2, 6, 1, 2]);
    }

    [Fact]
    public void SubArrayDivisionTest()
    {
        var subarrayDivision = SubArrayDivision.GetChocolateSquare([2, 2, 1, 3, 2], 4, 2);
        var subarrayDivision1 = SubArrayDivision.GetChocolateSquare([4], 4, 1);
    }

    [Fact]
    public void BreakingTheRecordsTest()
    {
        var breakingTheRecordsResult = BreakingTheRecords.GetRecords([10, 5, 20, 20, 4, 5, 2, 25, 1]);
    }

    [Fact]
    public void NumberLineJumpsTest()
    {
        var numberLineJumpsResult = NumberLineJumps.WillKangoroosMeet(0, 3, 4, 2);
    }

    [Fact]
    public void AppleAndOrangeTest()
    {
        var appleAndOrangeResult = AppleAndOrange.CountApplesAndOranges(7, 10, 4, 12, [2, 3, -4], [3, -2, -4]);
    }

    [Fact]
    public void GradingStudentsTest()
    {
        var gradingStudentsResult = GradingStudents.GetStudentsGrades([73, 67, 3, 33]);
    }

    [Fact]
    public void TimeConversionTest()
    {
        var timeConversionResult = TimeConversion.GetMilitaryTime("12:01:00PM");
        var timeConversionResult1 = TimeConversion.GetMilitaryTime("12:01:00AM");
        var timeConversionResult2 = TimeConversion.GetMilitaryTime("01:01:00PM");
        var timeConversionResult3 = TimeConversion.GetMilitaryTime("11:01:00PM");
        var timeConversionResult4 = TimeConversion.GetMilitaryTime("01:01:00AM");
        var timeConversionResult5 = TimeConversion.GetMilitaryTime("01:01:00AM");
    }

    [Fact]
    public void MinMaxSumTest()
    {
        var result = MinMaxSum.GetMinMaxSum([1, 3, 5, 7, 9]);
        var result2 = MinMaxSum.GetMinMaxSum([256741038, 623958417, 467905213, 714532089, 938071625]);

        Assert.Equal(16, result[0]);
        Assert.Equal(24, result[1]);
        Assert.Equal(2063136757, result2[0]);
        Assert.Equal(2744467344, result2[1]);
    }
}