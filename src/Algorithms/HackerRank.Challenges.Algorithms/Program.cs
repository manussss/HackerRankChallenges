using HackerRank.Challenges.Algorithms.Algorithms;

Console.WriteLine("################ DESIGNER PDF VIEWER ##################### \n");

var resultDesignerPdfViewer = DesignerPdfViewer.GetHighlightedText(
[
    1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5
], "abc");

Console.WriteLine("################ CATS AND A MOUSE ##################### \n");

var resultGetCatsVersusMouse = CatsAndAMouse.GetCatsVersusMouse(1, 2, 3);
var resultGetCatsVersusMouse2 = CatsAndAMouse.GetCatsVersusMouse(3, 1, 2);

Console.WriteLine("################ BILL DIVISION ##################### \n");

BillDivision.PrintBillDivision([2, 4, 6], 2, 3);
BillDivision.PrintBillDivision([2, 4, 6], 2, 6);

Console.WriteLine();
