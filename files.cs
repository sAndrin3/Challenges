using System;
using System.IO;

// Reading content in a file
// public class Files{
//     public void Read(){
//         string filePath = "/home/petrolhead/c#";
//         string content = File.ReadAllText(filePath);
//         System.Console.WriteLine(content);

//         string[] lines = File.ReadAllLines(filePath);
//         foreach (string line in lines)
//         {
//             System.Console.WriteLine(line);
//         }
//     }
// }

// Writing a file

public class Files{
    public void Read(){
        string filePath = "/home/petrolhead/c#";
        string content = "Allez";
        File.AppendAllText(filePath, content + Environment.NewLine);

        // File.AppendAllText(filePath, content);
        string[]fileContent = File.ReadAllLines(filePath);
        // System.Console.WriteLine(fileContent);
        foreach (string line in fileContent)
        {
            System.Console.WriteLine(line);
        }
        System.Console.WriteLine("End of sentence");
    }
}