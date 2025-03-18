using ProgrammingChallenges.HackerRank;
using ProgrammingChallenges.LeetCode;

namespace ProgrammingChallenges.Tests;

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

    [Fact]
    public void MergeSortedArrayTest()
    {
        MergeSortedArray.Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
    }

    [Fact]
    public void RemoveElementTest()
    {
        var result = RemoveElement.GetElementsExcept([3, 2, 2, 3], 3);

        Assert.Equal(2, result);
    }

    [Fact]
    public void RemoveDuplicatesFromSortedArrayTest()
    {
        var result = RemoveDuplicatesFromSortedArray.RemoveDuplicates([1, 1, 2, 3, 3, 4, 5]);

        Assert.Equal(5, result);
    }

    [Fact]
    public void RemoveDuplicatesFromSortedArrayIITest()
    {
        var result = RemoveDuplicatesFromSortedArrayII.RemoveDuplicates([1, 1, 2, 2, 2, 3, 3, 4, 5]);

        Assert.Equal(8, result);
    }

    [Fact]
    public void SaveThePrisionerTest()
    {
        var result = SaveThePrisioner.GetChairNumber(7, 19, 2);

        Assert.Equal(6, result);
    }

    [Fact]
    public void MajorityElementTest()
    {
        var result = MajorityElement.GetMajorityElement([2, 2, 1, 1, 1, 2, 2]);

        Assert.Equal(2, result);
    }

    [Fact]
    public void BestTimetoBuyandSellStockTest()
    {
        var result = BestTimetoBuyandSellStock.GetMaxProfit([7, 1, 5, 3, 6, 4]);

        Assert.Equal(5, result);
    }

    [Fact]
    public void TranslateRomanToIntTest()
    {
        var result = RomanToInteger.TranslateRomanToInt("III");
        var result1 = RomanToInteger.TranslateRomanToInt("MCMXCIV");

        Assert.Equal(3, result);
        Assert.Equal(1994, result1);
    }

    [Fact]
    public void LengthOfLastWordTest()
    {
        var result = LengthOfLastWord.GetLengthOfLastWord("   fly me   to   the moon  ");

        Assert.Equal(4, result);
    }

    [Fact]
    public void FindtheIndexOfTheFirstOccurrenceInAStringTest()
    {
        var result = FindtheIndexOfTheFirstOccurrenceInAString.GetIndexOfTheFirstOccurrence("sadbutsad", "sad");
        var result1 = FindtheIndexOfTheFirstOccurrenceInAString.GetIndexOfTheFirstOccurrence("leetcode", "leeto");

        Assert.Equal(0, result);
        Assert.Equal(-1, result1);
    }

    [Fact]
    public void ValidPalindromeTest()
    {
        var result = ValidPalindrome.IsPalindrome("A man, a plan, a canal: Panama");
        var result1 = ValidPalindrome.IsPalindrome("race a car");

        Assert.True(result);
        Assert.False(result1);
    }

    [Fact]
    public void IsSubsequenceTest()
    {
        var result = IsSubsequence.IsSub("abc", "ahbgdc");
        var result1 = IsSubsequence.IsSub("acb", "ahbgdc");
        var result2 = IsSubsequence.IsSub("b", "abc");

        Assert.True(result);
        Assert.False(result1);
        Assert.False(result1);
    }

    [Fact]
    public void RansomNoteTest()
    {
        var result = RansomNote.CanConstruct("a", "b");
        var result1 = RansomNote.CanConstruct("bg", "efjbdfbdgfjhhaiigfhbaejahgfbbgbjagbddfgdiaigdadhcfcj");
        var result2 = RansomNote.CanConstruct("aa", "aab");
        var result3 = RansomNote.CanConstruct("aa", "baab");

        Assert.False(result);
        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Theory]
    [InlineData("add", "egg")]
    [InlineData("paper", "title")]
    public void IsomorphicStringsTest(string s, string t)
    {
        var result = IsomorphicStrings.IsIsomorphic(s, t);

        Assert.True(result);
    }

    [Fact]
    public void WordPatternTest()
    {
        var result = WordPattern.IsWordPattern("abba", "dog cat cat dog");
        var result1 = WordPattern.IsWordPattern("ddefr", "dog dog cat fish frog");
        var result2 = WordPattern.IsWordPattern("abba", "dog cat cat fish");

        Assert.True(result);
        Assert.True(result1);
        Assert.False(result2);
    }

    [Fact]
    public void IsAnagramTest()
    {
        var result = ValidAnagram.IsAnagram("anagram", "nagaram");
        var result1 = ValidAnagram.IsAnagram("aacc", "ccac");

        Assert.True(result);
        Assert.False(result1);
    }

    [Fact]
    public void TwoSumTest()
    {
        var result = TwoSum.GetTwoSum([2, 7, 11, 15], 9);
        var result1 = TwoSum.GetTwoSum([2, 5, 5, 11], 10);

        Assert.Equal([0, 1], result);
        Assert.Equal([1, 2], result1);
    }

    [Fact]
    public void HappyNumberTest()
    {
        var result = HappyNumber.IsHappy(19);
        var result1 = HappyNumber.IsHappy(2);

        Assert.True(result);
        Assert.False(result1);
    }

    [Fact]
    public void ContainsDuplicateIITest()
    {
        var result = ContainsDuplicateII.ContainsNearbyDuplicate([1, 2, 3, 1], 3);
        var result1 = ContainsDuplicateII.ContainsNearbyDuplicate([1, 0, 1, 1], 1);
        var result2 = ContainsDuplicateII.ContainsNearbyDuplicate([1, 2, 3, 1, 2, 3], 2);

        Assert.True(result);
        Assert.True(result1);
        Assert.False(result2);
    }

    [Fact]
    public void GetSummaryRangesTest()
    {
        var result = SummaryRanges.GetSummaryRanges([0, 1, 2, 4, 5, 7]);

        Assert.Equal(["0->2", "4->5", "7"], result);
    }

    [Fact]
    public void LongestCommonPrefixTest()
    {
        var result = LongestCommonPrefix.GetLongestCommonPrefix(["flower", "flow", "flight"]);

        Assert.Equal("fl", result);
    }

    [Fact]
    public void ValidParenthesesTest()
    {
        var result = ValidParentheses.IsValid("()[]{}");
        var result1 = ValidParentheses.IsValid("(]");
        var result2 = ValidParentheses.IsValid("([)]");

        Assert.True(result);
        Assert.False(result1);
        Assert.False(result2);
    }
}