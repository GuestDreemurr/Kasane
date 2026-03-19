using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;

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
}