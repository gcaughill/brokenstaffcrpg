using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Important to have this attributes tag to because that is the root tag of the file.
[XmlRoot("Races")]
public class Races
{
    [XmlElement("Race")]
    public Race[] Race { get; set; }
}

public class Race
{
    public string Id { get; set; }
    public string Name { get; set; }

    public string IsPlayable { get; set; }
    public string Description { get; set; }
    public string Group { get; set; }

    [XmlElement("Names")]
    public RaceNames Names { get; set; }

    [XmlElement("Attributes")]
    public RaceAttributes Attributes { get; set; }

    [XmlElement("Feats")]
    public RaceFeats Feats { get; set; }
}

public class RaceNames
{
    [XmlElement("MalesNames")]
    public RaceNamesMale[] MaleNames { get; set; }

    [XmlElement("FemaleNames")]
    public RaceNamesFemale[] FemaleNames { get; set; }

    [XmlElement("Surnames")]
    public RaceNamesSurnames[] Surnames { get; set; }
}

public class RaceNamesMale
{
    [XmlElement("Group")]
    public RaceNamesMaleFirstNamesGroup[] MaleFirstNamesGroup { get; set; }
}

public class RaceNamesMaleFirstNamesGroup
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Percent { get; set; }

    [XmlElement("Names")]
    public RaceNamesGroupMaleNames[] MaleNamesGroup { get; set; }
}

public class RaceNamesGroupMaleNames
{
    [XmlElement("FirstName")]
    public RaceNamesMaleFirstName[] MaleFirstNames { get; set; }
}

public class RaceNamesMaleFirstName
{
    public string Id { get; set; }
    public string Value { get; set; }
}

public class RaceNamesFemale
{
    [XmlElement("Group")]
    public RaceNamesFemaleFirstNamesGroup[] FemaleFirstNamesGroup { get; set; }
}

public class RaceNamesFemaleFirstNamesGroup
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Percent { get; set; }

    [XmlElement("Names")]
    public RaceNamesGroupFemaleNames[] FemaleNamesGroup { get; set; }
}

public class RaceNamesGroupFemaleNames
{
    [XmlElement("FirstName")]
    public RaceNamesFemaleFirstNames[] FemaleFirstNames { get; set; }
}

public class RaceNamesFemaleFirstNames
{
    public string Id { get; set; }
    public string Value { get; set; }
}

public class RaceNamesSurnames
{
    [XmlElement("Group")]
    public RaceNamesSurnamesGroup[] SurnamesGroup { get; set; }
}

public class RaceNamesSurnamesGroup
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Percent { get; set; }

    [XmlElement("Names")]
    public RaceNamesGroupSurnames[] SurnamesGroup { get; set; }
}

public class RaceNamesGroupSurnames
{
    [XmlElement("Surname")]
    public RaceNamesGroupSurnamesSurname[] Surnames { get; set; }
}

public class RaceNamesGroupSurnamesSurname
{
    public string Id { get; set; }
    public string Value { get; set; }
}

public class RaceAttributes
{
    [XmlElement("Attribute")]
    public RaceAttribute[] Attribute { get; set; }
}

public class RaceAttribute
{
    public string Id { get; set; }
    public string Value { get; set; }
}

public class RaceFeats
{
    [XmlElement("Feat")]
    public RaceFeat[] Feat { get; set; }
}

public class RaceFeat
{
    public string Id { get; set; }
}


