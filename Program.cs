/*
 * Read From File
 * Pawelski
 * 2/13/2022
 * We will discuss this program as part of the notes.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is the path to the file.
            const string FILE_PATH = @"BabyNames.txt";
            // This is a FileStream. It represents the file itself. The FileMode determines
            // how the file is accessed. The FileAccess determines what can be done with the file.
            FileStream file = new FileStream(FILE_PATH, FileMode.Open, FileAccess.Read);
            // This is a StreamReader. It is actually used to read the file. 
            StreamReader reader = new StreamReader(file);

            // Repeats while we have not reached the end of the file.
            while(!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }

            // Closes both the StreamReader and FileStream after finishing the reading process.
            reader.Close();
            file.Close();
        }
    }
}
