using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Important to have this attributes tag to because that is the root tag of the file.
[XmlRoot("Attributes")]
public class Attributes
{
    [XmlElement("Attribute")]
    public Attribute[] Attribute { get; set; }
}

public class Attribute
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Group { get; set; }
    public string Description { get; set; }

    [XmlElement("Values")]
    public AttributeValues Values { get; set; }
}

public class AttributeValues
{
    [XmlElement("Value")]
    public AttributeValue[] Value { get; set; }
}

public class AttributeValue
{
    public string Id { get; set; }

    [XmlElement("Effects")]
    public AttributeEffects[] AttributeEffects { get; set; }
}

public class AttributeEffects
{
    [XmlElement("Effect")]
    public AttributeEffect AttributeEffect { get; set; }
}

public class AttributeEffect
{
    public string Id { get; set; }
    public string Value { get; set; }
    public string Duration { get; set; }
}

