// Path
string path = Path.Combine("c:", "windows", "drivers", "test.txt" );
Console.WriteLine(path);

var extention = Path.GetExtension(path);
Console.WriteLine(extention);

var fileName = Path.GetFileName(path);
Console.WriteLine(fileName);

var relativePath = Path.GetRelativePath("c:\\test\\hej", @"c:\test\hejsan");
Console.WriteLine(relativePath);

Console.WriteLine();
Console.WriteLine("Directory: ");
// Directory
var currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine(currentDirectory);

var subDirectories = Directory.GetDirectories(@"C:\");

foreach (string subDir in subDirectories)
{
    Console.WriteLine(subDir);
}

Console.WriteLine();
Console.WriteLine("Files:");

var files = Directory.GetFiles(@"C:\");

foreach (string f in files)
{
    Console.WriteLine(f);
}

// StreamWriter
//using (var writeFile = new StreamWriter("myFile.txt", append: true, System.Text.Encoding.ASCII))
//{
//    writeFile.WriteLine("Hello");
//    writeFile.WriteLine("World");
//}

//StreamReader
using (var readFile = new StreamReader("myFile.txt"))
{
    while (!readFile.EndOfStream)
    {
        var currentLine = readFile.ReadLine();
        Console.WriteLine(currentLine);
    }
}

Console.WriteLine();
Console.WriteLine("Data:");

using (var stream = new FileStream("myFile.txt", FileMode.Open))
{
    var fileSize = (int)stream.Length;
    Console.WriteLine($"File size: {fileSize} bytes.");

    byte[] data = new byte[fileSize];

    stream.Read(data, 0, fileSize);

    //var dataString = String.Join(", ", data);
    //Console.WriteLine(dataString);

    foreach (byte b in data)
    {
        Console.Write(b.ToString("X2") + " ");
    }
}


