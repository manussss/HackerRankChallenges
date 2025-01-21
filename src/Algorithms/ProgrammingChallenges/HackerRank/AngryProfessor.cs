namespace ProgrammingChallenges.HackerRank;

public static class AngryProfessor
{
    /*
    Complete the angryProfessor function in the editor below. It must return YES if class is cancelled, or NO otherwise.
    angryProfessor has the following parameter(s):

    int k: the threshold number of students
    int a[n]: the arrival times of the  students

    Note: Non-positive arrival times indicate the student arrived early or on time; 
    positive arrival times indicate the student arrived  minutes late.
     */
    public static string IsClassCancelled(int threshold, List<int> arrivalTimes)
    {
        var onTime = 0;

        foreach (var time in arrivalTimes)
        {
            if (time <= 0)
                onTime++;
        }

        return onTime >= threshold ? "NO" : "YES";
    }
}
