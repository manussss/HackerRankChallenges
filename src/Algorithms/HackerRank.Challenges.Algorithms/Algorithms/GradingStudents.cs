namespace HackerRank.Challenges.Algorithms.Algorithms
{
    public static class GradingStudents
    {
        /*
        Any grade less than 38 is a failing grade. 
        If the difference between the grade and the next multiple of 5 is less than 3, round up to the next multiple of 5.
        If the value of  is less than , no rounding occurs as the result will still be a failing grade.
         */
        public static List<int> GetStudentsGrades(List<int> grades)
        {
            Func<int, int> roundNextMultipleFive = grade => 5 * ((grade - 1) / 5 + 1);

            return grades
                .Select(grade =>
                    grade < 38 ? grade :
                    roundNextMultipleFive(grade) - grade < 3 ? roundNextMultipleFive(grade) : grade
                )
                .ToList();
        }
    }
}   
