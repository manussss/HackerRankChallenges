namespace ProgrammingChallenges.HackerRank;

/*
 Given a time in -hour AM/PM format, convert it to military (24-hour) time.
 
 input: 07:05:45PM
 output: 19:05:45
 */
public static class TimeConversion
{
    public static string GetMilitaryTime(string time)
    {
        var timeSplit = time.Split(':');
        var hourFormat = timeSplit[2][2..].ToUpper();
        var hourParsed = int.Parse(timeSplit[0]);
        string minutesAndSeconds = time.Substring(2, 6);

        if (hourFormat == "AM" && hourParsed == 12)
            return $"00{minutesAndSeconds}";

        if (hourFormat == "PM" && hourParsed != 12)
            return $"{hourParsed + 12}{minutesAndSeconds}";

        return time[..8];
    }

    /*
    01am -> 01   |  01pm -> 13
    02am -> 02   |  02pm -> 14
    03am -> 03   |  03pm -> 15
    04am -> 04   |  04pm -> 16
    06am -> 05   |  05pm -> 17
    06am -> 06   |  06pm -> 18
    07am -> 07   |  07pm -> 19
    08am -> 08   |  08pm -> 20
    09am -> 09   |  09pm -> 21
    10am -> 10   |  10pm -> 22
    11am -> 11   |  11pm -> 23
    12am -> 00   |  12pm -> 12

    if am && 12 == 00
    if pm && 12 == as is
    if pm != 12 == hour + 12
    if am != 12 == as is

    we have 2 cases with the same conditions
     */
}
