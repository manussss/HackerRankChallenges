namespace ProgrammingChallenges.ManningAlgorithms.Recursion;

public static class BoxRecursion
{
    /*
    Get the box with the key
    
    <box 1, false>
    <box 2, false>
    <box 3, true>

    return box 3

    otherwise, return not found
    */
    public static string GetBoxWithKey(List<Box> boxes)
    {
        foreach (var box in boxes)
        {
            if (box.HasKey)
                return box.Name;
            else if (box.Boxes != null && box.Boxes.Count != 0)
                return GetBoxWithKey(box.Boxes);
        }

        return "not found";
    }
}

public class Box
{
    public string Name { get; set; }
    public List<Box> Boxes { get; set; }
    public bool HasKey { get; set; }

    public Box(string name, List<Box> boxes, bool hasKey)
    {
        Name = name;
        Boxes = boxes;
        HasKey = hasKey;
    }
}