using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace program_tech_labs.Models;

public static class Lab4Model
{
    public static List<UrlInfo> GetDomainsInfo()
    {
        var xmlReader = new XmlReader("Assets/Resources.xml");
        List<string> paths = xmlReader.GetPaths();
        List<UrlInfo> urls = new List<UrlInfo>();
        for (var index = 0; index < paths.Count; index++)
        {
            var path = paths[index];
            var uri = new Uri(path);
            var domain = uri.Host.Split(".").Last();
            var t = uri.LocalPath;
            int start = t.LastIndexOf("/", StringComparison.Ordinal);
            int length = t.Length - start;
            t = t.Remove(start, length);
            if (t.Length > 0)
            {
                path = paths[index].Replace(t, $"/NEW_ROOT_PATH_{index + 1}");
            }

            urls.Add(new UrlInfo(path, domain, 0));
        }

        int urlsCount = urls.Count;

        List<string> tempPaths = new List<string>();
        List<int> foldingLevels = new List<int>();
        foreach (var urlInfo in urls)
        {
            string temp = urlInfo.Path.Remove(0, 8);
            int start = temp.IndexOf('/');
            int length = temp.Length - start;
            tempPaths.Add(temp.Remove(start, length));
            foldingLevels.Add(temp.Count(f => f == '.'));
        }

        for (int i = 0; i < urlsCount; i++)
        {
            urls[i].Domain = tempPaths[i];
            urls[i].FoldingLevel = foldingLevels[i];
        }

        return urls;
    }
}

public class XmlReader
{
    private readonly XmlDocument _document;

    internal XmlReader(string path)
    {
        _document = new XmlDocument();
        _document.Load(path);
    }

    internal List<string> GetPaths()
    {
        var xmlElements = _document.DocumentElement!.ChildNodes.OfType<XmlElement>();
        return xmlElements.Select(xmlElement => xmlElement.GetAttribute("path")).ToList();
    }
}

public class UrlInfo
{
    public UrlInfo(string path, string topLevelDomain, int foldingLevel)
    {
        Path = path;
        Domain = string.Empty;
        TopLevelDomain = topLevelDomain;
        FoldingLevel = foldingLevel;
    }

    public string Path { get; }
    public string Domain { get; set; }
    public string TopLevelDomain { get; }
    public int FoldingLevel { get; set; }

    public override string ToString()
    {
        return $"Absolute path (renamed) : {Path}\n" +
               $"Domain: {Domain}\n" +
               $"Top level domain: {TopLevelDomain}\n" +
               $"Folding level: {FoldingLevel}";
    }
}