if (args.Length < 3)
{
    Console.WriteLine("Invalid Arguments!");
}
else
{
    string path = args[0];
    string file = args[1];
    string text = args[2];
    bool tmp = true;
    int numberOfFiles = 0;
    int numberOfLines = 0;
    int numberOfOccurences = 0;

    if (!Directory.Exists(path))
    {
        Console.WriteLine("Invalid path: " + path);
        return;
    }

    var files = Directory.GetFiles(path, "*.txt");

    int counter = 0;

    foreach (var filePath in files)
    {
        string[] lines = File.ReadAllLines(filePath);
        numberOfFiles++;
        foreach (var line in lines)
        {
            counter++;
            {
                if (line.Contains(text))
                {
                    if (tmp) { Console.WriteLine($"{filePath}"); tmp = false; }
                    Console.WriteLine($"{counter}: {line}");
                    numberOfLines++;
                }
            }
        }
        counter = 0;
        tmp = true;
    }
    System.Console.WriteLine("SUMMARY:");
    System.Console.WriteLine($"Number of found files: {numberOfFiles} ");
    System.Console.WriteLine($"Number of found lines: {numberOfLines} ");
    System.Console.WriteLine($"Number of occurences: {numberOfOccurences}");
}