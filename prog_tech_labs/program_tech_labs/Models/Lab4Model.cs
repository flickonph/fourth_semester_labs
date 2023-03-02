using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace program_tech_labs.Models;

public static class Lab4Model
{
    public static List<UrlInfo> GetTopLevelDomains()
    {
        var xmlReader = new XmlReader("Assets/Resources.xml");
        List<string> paths = xmlReader.GetPaths();
        List<UrlInfo> domains = new List<UrlInfo>();
        foreach (var path in paths)
        {
            var uri = new Uri(path);
            var domain = uri.Host.Split(".").Last();
            
            domains.Add(new UrlInfo(path, domain, 0));
        }

        return domains;
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

public struct UrlInfo
{
    public UrlInfo(string path, string topLevelDomain, int foldingLevel)
    {
        Path = path;
        TopLevelDomain = topLevelDomain;
        FoldingLevel = foldingLevel;
    }

    public string Path { get; }
    public string TopLevelDomain { get; }
    public int FoldingLevel { get; }
}