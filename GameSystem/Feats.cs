using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Important to have this attributes tag to because that is the root tag of the file.
[XmlRoot("Feats")]
public class Feats
{
    [XmlElement("Feat")]
    public Feat[] Feat { get; set; }
}

public class Feat
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string FeatGroup { get; set; }
    public string Description { get; set; }

    [XmlElement("Requirements")]
    public FeatRequirements Requirements { get; set; }

    [XmlElement("Effects")]
    public FeatEffects Effects { get; set; }
}

public class FeatRequirements
{
    public string Locked { get; set; }

    [XmlElement("Classes")]
    public FeatClasses Classes { get; set; }

    [XmlElement("Attributes")]
    public FeatAttributes Attribute { get; set; }
}

public class FeatClasses
{
    [XmlElement("Class")]
    public FeatClass[] Class { get; set; }
}

public class FeatClass
{
    public string Id { get; set; }
    public string Level { get; set; }
    public string OneOf { get; set; }
}

public class FeatAttributes
{
    [XmlElement("Attribute")]
    public FeatAttribute[] Attribute { get; set; }
}

public class FeatAttribute
{
    public string Id { get; set; }
    public string Value { get; set; }
}

public class FeatEffects
{
    [XmlElement("Effect")]
    public FeatEffect[] Effect { get; set; }
}

public class FeatEffect
{
    public string Id { get; set; }
    public string Value { get; set; }
    public string MinValue { get; set; }
    public string MaxValue { get; set; }
    public string Group { get; set; }
    public string Range { get; set; }
    public string Target { get; set; }
    public string Duration { get; set; }
}
