//Problem 3. Read file contents

//    Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//    Find in MSDN how to use System.IO.File.ReadAllText(…).
//    Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;
class readContentsOfFiles
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a file name: ");
            string fileName = Console.ReadLine();
            Console.Write("Enter full file path: ");
            string filePath = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(File.ReadAllText(filePath + "\\" + fileName));
            
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file you requested cannot be found.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory can't be found or incorrect input.");
        }
        catch (DriveNotFoundException dnfe)
        {
            Console.WriteLine(dnfe.Message);
        }
        catch (FileLoadException fle)
        {
            Console.WriteLine(fle.Message);
        }
        catch (PathTooLongException ptle)
        {
            Console.WriteLine(ptle.Message);
        }
        catch (UnauthorizedAccessException ua)
        {
            Console.WriteLine(ua.Message);
        }
        catch (EndOfStreamException eose)
        {
            Console.WriteLine(eose.Message);
        }
        catch (ArgumentException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (IOException exception)
        {
            Console.WriteLine(exception.Message);
        }

    }
}

