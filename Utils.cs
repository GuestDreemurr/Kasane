using System.Dynamic;
using System.Xml.Linq;
using Newtonsoft.Json;

public static class Utils
{
    public static XDocument LoadXmlFromFile(string path)
    {
        try
        {
            XDocument xmlDoc = XDocument.Load(path);
            return xmlDoc;
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"XML File Provided not found, err: {ex.Message}");
            return null;
        }
        catch (System.Xml.XmlException ex)
        {
            Console.WriteLine($"XML Exception: {ex.Message}");
            return null;
        }
    }
    public static string ReadJsonFromFile(string path)
    {
        try
        {
            string contents = File.ReadAllText(path);
            return contents ?? "";
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"[ReadJsonFromFile] File Not Found! Error: {ex}");
            return "";
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[ReadJsonFromFile] Error whilst trying to read file: {ex}");
            return "";
        }
    }
}