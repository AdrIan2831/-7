using System;
using System.IO;

public class ProcessFile
{
    public static void Main()
    {
        FileStream fs;
        try
        {
            // Opens a text tile.
            fs = new FileStream(@"C:\Users\STUDENT-4310\source\repos\Горбуля Адраин 7 практическая работа н3\Горбуля Адраин 7 практическая работа н3\bin\Debug\net5.0\ref\data.txt", FileMode.Open);
            var sr = new StreamReader(fs);

            // A value is read from the file and output to the console.
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"[Data File Missing] {e}");
            throw new FileNotFoundException(@"[data.txt not in c:\temp directory]", e);
        }
        finally
        {
            fs = new FileStream(@"C:\Users\STUDENT-4310\source\repos\Горбуля Адраин 7 практическая работа н3\Горбуля Адраин 7 практическая работа н3\bin\Debug\net5.0\ref\data.txt", FileMode.Open);
            if (fs != null)
                fs.Close();
        }
    }
}