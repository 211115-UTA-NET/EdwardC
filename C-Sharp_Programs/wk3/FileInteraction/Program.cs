using System;
using System.IO;

string? path = "./testFile.txt";

string[] text = { "hi", "hello", "How's it going" };

File.WriteAllLines(path, text);
File.AppendAllLines(path, text);


//StreamReader reader = new StreamReader(path);
// while(reader.Peek() != -1)
// {
//     Console.WriteLine(reader.ReadLine());
// }
// Console.WriteLine("End of file reached");
// reader.Close();


// StreamWriter writer = new StreamWriter(path);
// writer.WriteLine("This is a new line.");
// writer.Close();