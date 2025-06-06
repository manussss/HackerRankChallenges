using System.Globalization;
using ProgrammingChallenges.HackerRank;
using ProgrammingChallenges.LeetCode;
using ProgrammingChallenges.ManningAlgorithms;
using ProgrammingChallenges.ManningAlgorithms.Recursion;

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
        var expected = 
    @"     #
    ##
   ###
  ####
 #####
######
";
        expected = expected.Replace("\r\n", "\n");
        result = result.Replace("\r\n", "\n");
        
        bool areEqual = string.Compare(expected, result, StringComparison.InvariantCulture) == 0;
        Assert.True(areEqual);
    }

    [Fact]
    public void PlusMinusTest()
    {
        //Arrange & Act
        var result = PlusMinus.GetPlusMinus([1, 1, 0, -1, -1]);

        Assert.Equal("0.400000", result[0]);
        Assert.Equal("0.200000", result[1]);
        Assert.Equal("0.400000", result[2]);
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
        var result = MergeSortedArray.Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);

        Assert.Equal([1, 2, 2, 3, 5, 6], result);
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

    [Fact]
    public void LinkedListCycleTest()
    {
        ListNode head = new(1)
        {
            Next = new ListNode(2)
        };
        head.Next.Next = head;
        var result = LinkedListCycle.HasCycle(head);

        ListNode head1 = new(1)
        {
            Next = new ListNode(2)
        };
        head1.Next.Next = new ListNode(3)
        {
            Next = new ListNode(4)
        };
        var result1 = LinkedListCycle.HasCycle(head1);

        Assert.True(result);
        Assert.False(result1);
    }

    [Fact]
    public void MergeTwoSortedListsTest()
    {
        ListNode list1 = new(1)
        {
            Next = new ListNode(2)
            {
                Next = new ListNode(4)
            }
        };

        ListNode list2 = new(1)
        {
            Next = new ListNode(3)
            {
                Next = new ListNode(4)
            }
        };

        ListNode mergedList = MergeTwoSortedLists.MergeTwoLists(list1, list2);

        var result = new List<int>();
        while (mergedList != null)
        {
            result.Add(mergedList.Val);
            mergedList = mergedList.Next;
        }

        var expected = new List<int> { 1, 1, 2, 3, 4, 4 };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void MaximumDepthofBinaryTreeTest()
    {
        //        1
        //      /   \
        //     2     3
        //    / \
        //   4   5

        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.left = new TreeNode(4);
        root.left.right = new TreeNode(5);

        var result = MaximumDepthofBinaryTree.MaxDepth(root);

        Assert.Equal(3, result);
    }

    [Fact]
    public void SameTreeTest()
    {
        //        1              1
        //      /   \          /   \
        //     2     3        2     3

        TreeNode firstRoot = new(1);
        firstRoot.left = new(2);
        firstRoot.right = new(3);

        TreeNode secondRoot = new(1);
        secondRoot.left = new(2);
        secondRoot.right = new(3);

        var result = SameTree.IsSameTree(firstRoot, secondRoot);

        Assert.True(result);
    }

    [Fact]
    public void InvertBinaryTreeTest()
    {
        //         4                     4 
        //      /     \               /     \    
        //     2       7    ====>    7       2
        //    / \     /  \          / \     /  \
        //   1   3   6    9        9   6   3    1

        TreeNode root = new(4);

        root.left = new(2);
        root.right = new(7);

        root.left.left = new(1);
        root.left.right = new(3);

        root.right.left = new(6);
        root.right.right = new(9);

        var result = InvertBinaryTree.InvertTree(root);

        Assert.Equal(4, result.val);
        Assert.Equal(7, result.left.val);
        Assert.Equal(2, result.right.val);
        Assert.Equal(9, result.left.left.val);
        Assert.Equal(6, result.left.right.val);
        Assert.Equal(3, result.right.left.val);
        Assert.Equal(1, result.right.right.val);
    }

    [Fact]
    public void SymmetricTreeTest()
    {
        //         1  
        //      /     \    
        //     2       2
        //    / \     / \
        //   3   4   4   3

        TreeNode root = new(1);

        root.left = new(2);
        root.right = new(2);

        root.left.left = new(3);
        root.left.right = new(4);

        root.right.left = new(4);
        root.right.right = new(3);

        var result = SymmetricTree.IsSymmetric(root);

        Assert.True(result);
    }

    [Fact]
    public void PathSumTest()
    {
        //         5  
        //      /     \    
        //     4       8
        //    /       / \
        //   11     13   4
        //  /  \          \
        // 7    2          1

        TreeNode root = new(5);

        root.left = new(4);
        root.right = new(8);

        root.left.left = new(11);
        root.left.left.left = new(7);
        root.left.left.right = new(2);

        root.right.left = new(13);
        root.right.right = new(4);
        root.right.right.right = new(1);

        var result = PathSum.HasPathSum(root, 22);

        Assert.True(result);
    }

    [Fact]
    public void CountCompleteTreeNodesTest()
    {
        //         1  
        //      /     \    
        //     2       3
        //    /      
        //   4     
        //  /  \       
        // 5    6      

        TreeNode root = new(1);

        root.left = new(2);
        root.right = new(3);

        root.left.left = new(4);
        root.left.left.left = new(5);
        root.left.left.right = new(6);

        var result = CountCompleteTreeNodes.CountNodes(root);

        Assert.Equal(6, result);
    }

    [Fact]
    public void AverageofLevelsinBinaryTreeTest()
    {
        //         3  
        //      /     \    
        //     9       20
        //            /  \
        //           15   7

        TreeNode root = new(3);

        root.left = new(9);
        root.right = new(20);

        root.right.left = new(15);
        root.right.right = new(7);

        var result = AverageofLevelsinBinaryTree.AverageOfLevels(root);

        Assert.Equal([3, 14.5, 11], result);
    }

    [Fact]
    public void MinimumAbsoluteDifferenceinBSTTest()
    {
        //         4  
        //      /     \    
        //     2       6
        //   /   \
        //  1     3

        TreeNode root = new(4);

        root.left = new(2);
        root.right = new(6);

        root.left.left = new(1);
        root.left.right = new(3);

        var result = MinimumAbsoluteDifferenceinBST.GetMinimumDifference(root);

        Assert.Equal(1, result);
    }

    [Fact]
    public void BinarySearchTest()
    {
        var result = BinarySearch.Search([1, 2, 3, 4, 5], 6);
        var result1 = BinarySearch.Search([1, 2, 3, 4, 5], 3);

        Assert.Null(result);
        Assert.Equal(2, result1);
    }

    [Fact]
    public void SelectionSortTest()
    {
        var result = SelectionSort.GetSelectionSort([5, 4, 1, 2, 3]);

        Assert.Equal([1, 2, 3, 4, 5], result);
    }

    [Fact]
    public void BoxRecursionTest()
    {
        var boxes = new List<Box>
        {
            new("box 1", [], false),
            new("box 2", [ new("box 3", [], true) ], false)
        };

        var result = BoxRecursion.GetBoxWithKey(boxes);

        Assert.Equal("box 3", result);
    }

    [Fact]
    public void BoxRecursionNotFoundTest()
    {
        var boxes = new List<Box>
        {
            new("box 1", [], false),
            new("box 2", [ new("box 3", [], false) ], false)
        };

        var result = BoxRecursion.GetBoxWithKey(boxes);

        Assert.Equal("not found", result);
    }

    [Fact]
    public void FactorialTest()
    {
        var result = Factorial.GetFactorial(5);

        Assert.Equal(120, result);
    }

    [Fact]
    public void SumArrayTest()
    {
        var result = SumArray.Sum([1, 2, 3, 4]);

        Assert.Equal(10, result);
    }

    [Fact]
    public void QuickSortTest()
    {
        int[] array = [4, 3, 2, 1];
        QuickSort.Sort(array, 0, array.Length - 1);

        Assert.Equal([1, 2, 3, 4], array);
    }

    [Fact]
    public void BFSSearchTest()
    {
        //           1
        //       /   \   \ 
        //      2     3   4
        //     /     / \
        //    5     6   7
        Graph graph = new();
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(1, 4);
        graph.AddEdge(2, 5);
        graph.AddEdge(3, 6);
        graph.AddEdge(3, 7);

        List<int> visited = graph.BreadthFirstSearch(1);

        Assert.Equal([1, 2, 3, 4, 5, 6, 7], visited);
    }

    [Fact]
    public void DijkstraTest()
    {
        var a = new Node("A");
        var b = new Node("B");
        var c = new Node("C");
        var d = new Node("D");
        var e = new Node("E");
        var f = new Node("F");

        a.ConnectTo(b, 4);
        a.ConnectTo(c, 2);
        b.ConnectTo(c, 1);
        b.ConnectTo(d, 5);
        c.ConnectTo(d, 8);
        c.ConnectTo(e, 10);
        d.ConnectTo(f, 6);
        d.ConnectTo(e, 2);
        e.ConnectTo(f, 2);

        var result = Dijkstra.FindShortestPath(a, e);

        Assert.Equal("A", result[0].Label);
        Assert.Equal("C", result[1].Label);
        Assert.Equal("B", result[2].Label);
        Assert.Equal("D", result[3].Label);
        Assert.Equal("E", result[4].Label);
    }
}