namespace HackerRank.Challenges.Algorithms.Algorithms
{
    public static class BillDivision
    {
        public static string GetBillDivision(List<int> bill, int billsIndexAnaDidntConsume, int amountAnaContributedToTheBill)
        {
            bill.RemoveAt(billsIndexAnaDidntConsume);
            var billWithoutAnasItem = bill.Sum();
            var billsDivision = billWithoutAnasItem / 2;

            if (amountAnaContributedToTheBill == billsDivision)
                return "Bon Appetit";
            else
                return $"{Math.Abs(amountAnaContributedToTheBill - billsDivision)}";
        }
    }
}
