using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Important to have this characters tag to because that is the root tag of the file.
[XmlRoot("DamageTypes")]
public class DamageTypes
{
    [XmlElement("DamageType")]
    public DamageType[] DamageType { get; set; }
}

public class DamageType
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}