using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Important to have this attributes tag to because that is the root tag of the file.
[XmlRoot("Classes")]
public class Classes
{
    [XmlElement("Class")]
    public Class[] Class { get; set; }
}

public class Class
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string IsPlayable { get; set; }
    public string Description { get; set; }
    public string Group { get; set; }

    [XmlElement("Requirements")]
    public ClassRequirements Requirements { get; set; }

    [XmlElement("StartingFeats")]
    public ClassFeats Feats { get; set; }

    [XmlElement("Advancement")]
    public ClassAdvancement Advancement { get; set; }

    [XmlElement("Levels")]
    public ClassLevels[] Levels { get; set; }
}

public class ClassRequirements
{
    [XmlElement("Attributes")]
    public ClassRequirementsAttributes Attributes { get; set; }
}

public class ClassRequirementsAttributes
{
    [XmlElement("Attribute")]
    public ClassRequirementsAttributesAttribute[] Attribute { get; set; }
}

public class ClassRequirementsAttributesAttribute
{
    public string Id { get; set; }
    public string Value { get; set; }
}

public class ClassFeats
{
    [XmlElement("Feat")]
    public ClassFeat[] Feat { get; set; }
}

public class ClassFeat
{
    public string Id { get; set; }
}

public class ClassAdvancement
{
    [XmlElement("Effects")]
    public ClassAdvancementEffects Effects { get; set; }
}

public class ClassAdvancementEffects
{
    [XmlElement("Effect")]
    public ClassAdvancementEffectsEffect[] Effect { get; set; }
}

public class ClassAdvancementEffectsEffect
{
    public string Id { get; set; }
    public string MinValue { get; set; }
    public string MaxValue { get; set; }
    public string Duration { get; set; }
}

public class ClassLevels
{
    [XmlElement("Level")]
    public ClassLevelsLevel[] Level { get; set; }
}

public class ClassLevelsLevel
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string ExperienceNeeded { get; set; }
    public string IsEpic { get; set; }

    [XmlElement("Effects")]
    public ClassLevelsLevelEffects[] Effects { get; set; }
}

public class ClassLevelsLevelEffects
{
    [XmlElement("Effect")]
    public ClassLevelsLevelEffectsEffect[] Effect { get; set; }
}

public class ClassLevelsLevelEffectsEffect
{
    public string Id { get; set; }
    public string Value { get; set; }
    public string Duration { get; set; }
}
