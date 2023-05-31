var path = args[0];
var fileName = args[1];
var searchText = args[2];

var files = Directory.GetFiles(path, "*.txt");
bool IsTextInFile = true;
int counter = 0;
int numberOfFiles = 0;
int numberOfLines = 0;
//int numberOfOccurences = 0;

foreach (var file in files)
{
    var lines = File.ReadAllLines(file);
    numberOfFiles++;
    foreach (var line in lines)
    {
        counter++;
        if (line.Contains(searchText))
        {
            numberOfLines++;
            if (IsTextInFile)
            {
                System.Console.WriteLine($"{file}");
                IsTextInFile = false;
            }
            System.Console.WriteLine($"{counter}: {line.Replace(searchText, ">>>HELLO<<<")}");
        }
    }
    IsTextInFile = true;
    counter = 0;
}
System.Console.WriteLine();
System.Console.WriteLine("SUMMARY");
System.Console.WriteLine($"Number of found files: {numberOfFiles}");
System.Console.WriteLine($"Number of found lines: {numberOfLines}");
//System.Console.WriteLine($"Number of occurences: {numberOfOccurences}");