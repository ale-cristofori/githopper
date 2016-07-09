using System;
using System.IO;
using System.Xml.Serialization;

public class GHXReader
{
	public GHXReader(String filePath)
	{
        this.filePath = filePath;
    }

    public void readFile()
    {
        String filePath = filePath;
        System.IO.Stream objReader;
        objReader = File.Open(filePath, FileMode.Open); 
    }
}

[XmlRoot("Archive")]
public class Archive
{
    public Archive() { }
    [XmlAttribute]
    public string name { get; set; }
    public int items { get; set; }
    public int chunks { get; set; }
}

public class Items
{
    [XmlAttribute]
    public int count { get; set; }
}

public class Item
{
    [XmlAttribute]
    public string name { get; set; }
    [XmlAttribute]
    public string type_name { get; set; }
    [XmlAttribute]
    public string type_code { get; set; }
    [XmlElement("Major")]
    public string Major { get; set; }
    [XmlElement("Minor")]
    public string Minor { get; set; }
    [XmlElement("Revision")]
    public string Revision { get; set; }
}

public class Chunks
{
    [XmlAttribute]
    public int count { get; set; }

}

public class Chunk
{
    [XmlAttribute]
    public string name { get; set; }
}
