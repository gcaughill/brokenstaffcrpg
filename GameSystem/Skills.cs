using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Important to have this attributes tag to because that is the root tag of the file.
[XmlRoot("Skills")]
public class Skills
{
    [XmlElement("Skill")]
    public Skill[] Skill { get; set; }
}

public class Skill
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string IsUsable { get; set; }
    public string Description { get; set; }
    public string SkillGroup { get; set; }

    [XmlElement("Requirements")]
    public SkillRequirements[] Requirements { get; set; }

    [XmlElement("Values")]
    public SkillValues Values { get; set; }
}

public class SkillRequirements
{
    [XmlElement("Classes")]
    public SkillClasses[] Classes { get; set; }
}

public class SkillClasses
{
    [XmlElement("Class")]
    public SkillClass[] Class { get; set; }
}

public class SkillClass
{
    public string Id { get; set; }
}

public class SkillValues
{
    [XmlElement("Value")]
    public SkillValue[] Value { get; set; }
}

public class SkillValue
{
    public string Id { get; set; }

    [XmlElement("Effects")]
    public SkillEffects[] AttributeEffects { get; set; }
}

public class SkillEffects
{
    [XmlElement("Effect")]
    public SkillEffect[] AttributeEffect { get; set; }
}

public class SkillEffect
{
    public string Id { get; set; }
    public string Value { get; set; }
    public string Duration { get; set; }
}
