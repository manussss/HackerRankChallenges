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
            var gradesRounded = new List<int>();

            foreach (var grade in grades)
            {
                if (grade < 38)
                    gradesRounded.Add(grade);
                else
                {
                    var roundedGrade = 5 * ((grade - 1) / 5 + 1);

                    if (roundedGrade - grade < 3)
                        gradesRounded.Add(roundedGrade);
                    else
                        gradesRounded.Add(grade);
                }
            }

            return gradesRounded;
        }
    }
}
