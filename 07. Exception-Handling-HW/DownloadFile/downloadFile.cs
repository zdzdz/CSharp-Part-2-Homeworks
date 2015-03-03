//Problem 4. Download file

//    Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//    Find in Google how to download files in C#.
//    Be sure to catch all exceptions and to free any used resources in the finally block.


using System;
using System.Net;
using System.IO;

class downloadFile
{
    static void Main()
    {
        using (WebClient myWebClient = new WebClient())
        {
            try
            {
                Console.WriteLine("Enter the web adress from where you want to download: ");
                string address = Console.ReadLine();
                Uri uri = new Uri(address);

                string fileName = uri.Segments[uri.Segments.Length - 1];

                myWebClient.DownloadFile(uri, fileName);
                Console.WriteLine("\nDownloaded file saved in the following file system folder:\n\t" + Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]));

            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (WebException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (NotSupportedException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (UriFormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

