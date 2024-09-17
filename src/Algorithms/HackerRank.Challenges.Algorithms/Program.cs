using HackerRank.Challenges.Algorithms.Algorithms;

Console.WriteLine("################ DESIGNER PDF VIEWER ##################### \n");

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

Console.WriteLine("################ CATS AND A MOUSE ##################### \n");

var resultGetCatsVersusMouse = CatsAndAMouse.GetCatsVersusMouse(1, 2, 3);
var resultGetCatsVersusMouse2 = CatsAndAMouse.GetCatsVersusMouse(3, 1, 2);

Console.WriteLine("################ BILL DIVISION ##################### \n");

BillDivision.PrintBillDivision([2, 4, 6], 2, 3);
BillDivision.PrintBillDivision([2, 4, 6], 2, 6);

Console.WriteLine("################ MIGRATORY BIRDS ##################### \n");

var migratoryBirdsResult = MigratoryBirds.GetBirdsFrequency([1, 1, 2, 2, 3]);
var migratoryBirdsResult2 = MigratoryBirds.GetBirdsFrequency([1, 4, 4, 4, 5, 3]);
var migratoryBirdsResult3 = MigratoryBirds.GetBirdsFrequency([1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4, 1, 4]);
var migratoryBirdsResult4 = MigratoryBirds.GetBirdsFrequency([2, 2, 1, 1, 3]);

Console.WriteLine("################ DIVISIBLE SUM PAIRS ##################### \n");

var divisibleSumPairs = DivisibleSumPairs.GetNumberOfPairs(6, 3, [1, 3, 2, 6, 1, 2]);

Console.WriteLine("################ SUBARRAY DIVISION ##################### \n");

var subarrayDivision = SubArrayDivision.GetChocolateSquare([2, 2, 1, 3, 2], 4, 2);
var subarrayDivision1 = SubArrayDivision.GetChocolateSquare([4], 4, 1);

Console.WriteLine("################ BREAKING THE RECORDS ##################### \n");

var breakingTheRecordsResult = BreakingTheRecords.GetRecords([10, 5, 20, 20, 4, 5, 2, 25, 1]);

Console.WriteLine("################ NUMBER LINE JUMPS ##################### \n");

var numberLineJumpsResult = NumberLineJumps.WillKangoroosMeet(0, 3, 4, 2);

Console.WriteLine("################ APPLE AND ORANGE ##################### \n");

var appleAndOrangeResult = AppleAndOrange.CountApplesAndOranges(7, 10, 4, 12, [2, 3, -4], [3, -2, -4]);

Console.WriteLine("################ GRADING STUDENTS ##################### \n");

var gradingStudentsResult = GradingStudents.GetStudentsGrades([73, 67, 3, 33]);

Console.WriteLine();
