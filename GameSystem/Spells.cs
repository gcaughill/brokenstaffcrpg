using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Important to have this attributes tag to because that is the root tag of the file.
[XmlRoot("Spells")]
public class Spells
{
    [XmlElement("Spell")]
    public Spell[] Spell { get; set; }
}

public class Spell
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string SpellBook { get; set; }
    public string SpellSkill { get; set; }
    public string SpellLevel { get; set; }
    public string Castable { get; set; }

    [XmlElement("Cost")]
    public SpellCost Cost { get; set; }

    [XmlElement("Effects")]
    public SpellEffects Effects { get; set; }

}

public class SpellCost
{
    [XmlElement("Attribute")]
    public SpellCostAttribute[] Attribute { get; set; }
}

public class SpellCostAttribute
{
    public string Id { get; set; }
    public string Value { get; set; }
}

public class SpellEffects
{
    [XmlElement("Effect")]
    public SpellEffectsEffect[] Effect { get; set; }
}

public class SpellEffectsEffect
{
    public string Id { get; set; }
    public string Group { get; set; }
    public string Range { get; set; }
    public string Target { get; set; }
    public string Duration { get; set; }
    public string MinValue { get; set; }
    public string MaxValue { get; set; }
}
