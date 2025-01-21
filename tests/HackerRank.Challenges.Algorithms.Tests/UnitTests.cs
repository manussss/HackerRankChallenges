namespace HackerRank.Challenges.Algorithms.Tests;

public class UnitTests
{
    [Fact]
    public void DesignerPdfViewerTest()
    {
        //Arrange & Act
        var result = DesignerPdfViewer.GetHighlightedText(
        [
            1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5
        ], "abc");

        //Assert
        Assert.Equal(9, result);
    }

    [Fact]
    public void CatsAndAMouseTest()
    {
        //Arrange & Act
        var result = CatsAndAMouse.GetCatsVersusMouse(1, 2, 3);
        var result1 = CatsAndAMouse.GetCatsVersusMouse(3, 1, 2);

        //Assert
        Assert.Equal("Cat B", result);
        Assert.Equal("Mouse C", result1);
    }

    [Fact]
    public void BillDivisionTest()
    {
        //Arrange & Act
        var result = BillDivision.GetBillDivision([2, 4, 6], 2, 3);
        var result1 = BillDivision.GetBillDivision([2, 4, 6], 2, 6);

        //Assert
        Assert.Equal("Bon Appetit", result);
        Assert.Equal("3", result1);
    }

    [Fact]
    public void MigratoryBirdsTest()
    {
        //Arrange & Act
        var result = MigratoryBirds.GetBirdsFrequency([1, 1, 2, 2, 3]);
        var result2 = MigratoryBirds.GetBirdsFrequency([1, 4, 4, 4, 5, 3]);
        var result3 = MigratoryBirds.GetBirdsFrequency([1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4, 1, 4]);
        var result4 = MigratoryBirds.GetBirdsFrequency([2, 2, 1, 1, 3]);

        //Assert
        Assert.Equal(1, result);
        Assert.Equal(4, result2);
        Assert.Equal(4, result3);
        Assert.Equal(1, result4);
    }

    [Fact]
    public void DivisibleSumPairTest()
    {
        //Arrange & Act
        var result = DivisibleSumPairs.GetNumberOfPairs(6, 3, [1, 3, 2, 6, 1, 2]);

        //Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void SubArrayDivisionTest()
    {
        //Arrange & Act
        var result = SubArrayDivision.GetChocolateSquare([2, 2, 1, 3, 2], 4, 2);
        var result1 = SubArrayDivision.GetChocolateSquare([4], 4, 1);

        //Assert
        Assert.Equal(2, result);
        Assert.Equal(1, result1);
    }

    [Fact]
    public void BreakingTheRecordsTest()
    {
        //Arrange & Act
        var result = BreakingTheRecords.GetRecords([10, 5, 20, 20, 4, 5, 2, 25, 1]);

        //Assert
        Assert.Equal(2, result[0]);
        Assert.Equal(4, result[1]);
    }

    [Fact]
    public void NumberLineJumpsTest()
    {
        //Arrange & Act
        var result = NumberLineJumps.WillKangoroosMeet(0, 3, 4, 2);

        //Assert
        Assert.Equal("YES", result);
    }

    [Fact]
    public void AppleAndOrangeTest()
    {
        //Arrange & Act
        var result = AppleAndOrange.CountApplesAndOranges(7, 10, 4, 12, [2, 3, -4], [3, -2, -4]);

        //Assert
        Assert.Equal(1, result[0]);
        Assert.Equal(2, result[1]);
    }

    [Fact]
    public void GradingStudentsTest()
    {
        //Arrange & Act
        var result = GradingStudents.GetStudentsGrades([73, 67, 3, 33]);

        //Assert
        Assert.Equal(75, result[0]);
        Assert.Equal(67, result[1]);
        Assert.Equal(3, result[2]);
        Assert.Equal(33, result[3]);
    }

    [Fact]
    public void TimeConversionTest()
    {
        //Arrange & Act
        var result = TimeConversion.GetMilitaryTime("12:01:00PM");
        var result1 = TimeConversion.GetMilitaryTime("12:01:00AM");
        var result2 = TimeConversion.GetMilitaryTime("01:01:00PM");
        var result3 = TimeConversion.GetMilitaryTime("11:01:00PM");
        var result4 = TimeConversion.GetMilitaryTime("01:01:00AM");
        var result5 = TimeConversion.GetMilitaryTime("01:01:00AM");

        //Assert
        Assert.Equal("12:01:00", result);
        Assert.Equal("00:01:00", result1);
        Assert.Equal("13:01:00", result2);
        Assert.Equal("23:01:00", result3);
        Assert.Equal("01:01:00", result4);
        Assert.Equal("01:01:00", result5);
    }

    [Fact]
    public void MinMaxSumTest()
    {
        //Arrange & Act
        var result = MinMaxSum.GetMinMaxSum([1, 3, 5, 7, 9]);
        var result2 = MinMaxSum.GetMinMaxSum([256741038, 623958417, 467905213, 714532089, 938071625]);

        //Assert
        Assert.Equal(16, result[0]);
        Assert.Equal(24, result[1]);
        Assert.Equal(2063136757, result2[0]);
        Assert.Equal(2744467344, result2[1]);
    }

    [Fact]
    public void StaircaseTest()
    {
        //Arrange & Act
        var result = Staircase.GetStaircase(6);

        //Assert
        Assert.Equal(
    @"     #
    ##
   ###
  ####
 #####
######
", result);
    }

    [Fact]
    public void PlusMinusTest()
    {
        //Arrange & Act
        var result = PlusMinus.GetPlusMinus([1, 1, 0, -1, -1]);

        Assert.Equal("0,400000", result[0]);
        Assert.Equal("0,200000", result[1]);
        Assert.Equal("0,400000", result[2]);
    }

    [Fact]
    public void DiagonalDifferenceTest()
    {
        //Arrange & Act
        var result = DiagonalDifference.GetDiagonalDifference(
        [
            [1, 2, 3],
            [4, 5, 6],
            [9, 8, 9]
        ]);

        Assert.Equal(2, result);
    }

    [Fact]
    public void AVeryBigSumTest()
    {
        //Arrange & Act
        var result = AVeryBigSum.GetAVeryBigSum([1000000001, 1000000002, 1000000003, 1000000004, 1000000005]);

        Assert.Equal(5000000015, result);
    }

    [Fact]
    public void CountingValleysTest()
    {
        var result = CountingValleys.GetCountingValleys(8, "UDDDUDUU");

        Assert.Equal(1, result);
    }

    [Fact]
    public void AngryProfessorTest()
    {
        var result = AngryProfessor.IsClassCancelled(3, [-2, -1, 0, 1, 2]);

        Assert.Equal("NO", result);
    }

    [Fact]
    public void BeautifulDaysAtTheMoviesTest()
    {
        var result = BeautifulDaysAtTheMovies.GetBeautifulDays(20, 23, 6);

        Assert.Equal(2, result);
    }

    [Fact]
    public void SalesByMathTest()
    {
        var result = SalesByMath.GetSockMerchantPairs(9, [10, 20, 20, 10, 10, 30, 50, 10, 20]);

        Assert.Equal(3, result);
    }

    [Fact]
    public void DrawingBookTest()
    {
        var result = DrawingBook.GetPagesTo(5, 3);

        Assert.Equal(1, result);
    }

    [Fact]
    public void TheHurdleRaceTest()
    {
        var result = TheHurdleRace.GetPoisonsAmount(4, [1, 6, 3, 5, 2]);

        Assert.Equal(2, result);
    }

    [Fact]
    public void ViralAdvertisingTest()
    {
        var result = ViralAdvertising.GetCumulativeLikesAt(5);

        Assert.Equal(24, result);
    }

    [Fact]
    public void FindDigitsTest()
    {
        var result = FindDigits.GetDivisors(124);

        Assert.Equal(3, result);
    }
}