namespace ProgrammingChallenges.HackerRank
{
    public static class DesignerPdfViewer
    {
        public static int GetHighlightedText(List<int> h, string word)
        {
            var maxHeight = 0;

            foreach (var letter in word)
            {
                var index = letter - 'a';
                maxHeight = Math.Max(maxHeight, h[index]);
            }
            
            return maxHeight * word.Length;
        }
    }
}
