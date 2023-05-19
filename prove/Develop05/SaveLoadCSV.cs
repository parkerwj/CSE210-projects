using System.IO;
public class SaveLoadCSV
{
    public static void SaveToCSV(List<string> _saveGoals, string _filesToSave)
    {
        List<string> saveGoals = _saveGoals;
        string fileToSave = _filesToSave;
        using (StreamWriter outputFile = new StreamWriter(fileToSave))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
            
            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }


    }
    public static void LoadFromCSV(string _fileName)
    {
        string filename = _fileName;
        string[] lines = System.IO.File.ReadAllLines(filename);
    }
}
