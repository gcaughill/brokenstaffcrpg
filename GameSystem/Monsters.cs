using System;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections;
using System.ComponentModel;
using System.Collections.Generic;

[XmlRoot("Monsters")]
public class Monsters
{
    [XmlElement("Monster")]
    public Monster[] Monster { get; set; }
}

public class Monster
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Race { get; set; }
    public string Description { get; set; }

    [XmlElement("Attributes")]
    public MonsterAttributes Attributes { get; set; }

    [XmlElement("Classes")]
    public MonsterClasses Classes { get; set; }

    [XmlElement("Feats")]
    public MonsterFeats Feats { get; set; }

    [XmlElement("Skills")]
    public MonsterSkills Skills { get; set; }

    [XmlElement("Items")]
    public MonsterItems Items { get; set; }

    [XmlElement("Effects")]
    public MonsterEffects Effects { get; set; }
}

public class MonsterAttributes
{
    [XmlElement("Attribute")]
    public MonsterAttributesAttribute[] Attribute { get; set; }
}

public class MonsterAttributesAttribute
{
    public string Id { get; set; }
    public string Value { get; set; }
}

public class MonsterClasses
{
    [XmlElement("Class")]
    public MonsterClassesClass[] Class { get; set; }
}

public class MonsterClassesClass
{
    public string Id { get; set; }
    public string Level { get; set; }
    public string IsCurrent { get; set; }
}

public class MonsterFeats
{
    [XmlElement("Feat")]
    public MonsterFeatsFeat[] Feat { get; set; }
}

public class MonsterFeatsFeat
{
    public string Id { get; set; }
}

public class MonsterSkills
{
    [XmlElement("Skill")]
    public MonsterSkillsSkill[] Skill { get; set; }
}

public class MonsterSkillsSkill
{
    public string Id { get; set; }
    public string Value { get; set; }
}

public class MonsterItems
{
    [XmlElement("Item")]
    public MonsterItemsItem[] Item { get; set; }
}

public class MonsterItemsItem
{
    public string Id { get; set; }
    public string Quantity { get; set; }
}

public class MonsterEffects
{
    [XmlElement("Effect")]
    public MonsterEffectsEffect[] Effect { get; set; }
}

public class MonsterEffectsEffect
{
    public string Id { get; set; }
    public string TimeLeft { get; set; }
    public string Value { get; set; }
}
