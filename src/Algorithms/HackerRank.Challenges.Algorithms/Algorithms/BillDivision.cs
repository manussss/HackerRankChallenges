namespace HackerRank.Challenges.Algorithms.Algorithms
{
    public static class BillDivision
    {
        public static void PrintBillDivision(List<int> bill, int billsIndexAnaDidntConsume, int amountAnaContributedToTheBill)
        {
            bill.RemoveAt(billsIndexAnaDidntConsume);
            var billWithoutAnasItem = bill.Sum();
            var billsDivision = billWithoutAnasItem / 2;

            if (amountAnaContributedToTheBill == billsDivision)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(Math.Abs(amountAnaContributedToTheBill - billsDivision));
        }
    }
}
