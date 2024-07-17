using System;

class FKObject
{
    public string Key { get; set; }
}

class Program
{
    static void Main()
    {
        // Create an instance of FKObject and set its Key property
        var fk = new FKObject { Key = "part1,part2,part3" };

        // Split the Key property by comma
        var fk_minus_i = fk.Key.Split(',');

        // Print each part
        foreach (var part in fk_minus_i)
        {
            Console.WriteLine(part);
        }
    }
}
