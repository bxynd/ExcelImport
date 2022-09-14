
using System.Xml.Serialization;
using Ganss.Excel;

namespace iTechArtTT.Models;
[Serializable]
public class Person
{
    [XmlIgnore]
    public int Id { get; set; }
    [XmlAttribute]
    public string PersonName { get; set; }
    [XmlAttribute]
    public int Age { get; set; }
    [Column("Pet 1")]
    public string Pet1 { get; set; }
    [Column("Pet 1 Type")]
    public string Pet1Type { get; set; }
    [Column("Pet 2")]
    public string Pet2 { get; set; }
    [Column("Pet 2 Type")]
    public string Pet2Type { get; set; }
    [Column("Pet 3")]
    public string Pet3 { get; set; }
    [Column("Pet 3 Type")]
    public string Pet3Type { get; set; }
}