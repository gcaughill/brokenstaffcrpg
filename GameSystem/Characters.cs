using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Important to have this characters tag to because that is the root tag of the file.
[XmlRoot("Characters")]
public class Characters
{
    [XmlElement("Character")]
    public Character[] theCharacter { get; set; }

    public Characters()
    {
        //Character = new Character();
        //int[] n1 = new int[4] {2, 4, 6, 8};
        Character[] theCharacter = new Character[1];
    }

    public void AddCharacter(Character newCharacter) {
        //ResizeArray(theCharacter, theCharacter.Count);
    }

    private void ResizeArray(Character[] arrChars, int oldSize)
    {
        Array.Resize(ref arrChars, oldSize+1);

    }

    /// <summary>
    /// Copies the character specified in the characterIndex to the passed Character.
    /// Opposite of CopyCharacterIntoList method.
    /// </summary>
    /// <param name="theCharacter"></param>
    /// <param name="characterIndex"></param>
    public void CopyCharacterFromList(Character theCharacter, Characters characterList, string characterId)
    {
        bool notFound = true;

        for (int i = 0; i < characterList.theCharacter.Length; i++ )
        {
            if (characterId == characterList.theCharacter[i].Id)
            {
                theCharacter.Age = characterList.theCharacter[i].Age;
                theCharacter.Attributes = characterList.theCharacter[i].Attributes;
                theCharacter.Background = characterList.theCharacter[i].Background;
                theCharacter.Classes = characterList.theCharacter[i].Classes;
                theCharacter.Description = characterList.theCharacter[i].Description;
                theCharacter.Effects = characterList.theCharacter[i].Effects;
                theCharacter.Equipment = characterList.theCharacter[i].Equipment;
                theCharacter.Feats = characterList.theCharacter[i].Feats;
                theCharacter.Id = characterList.theCharacter[i].Id;
                theCharacter.Inventory = characterList.theCharacter[i].Inventory;
                theCharacter.Name = characterList.theCharacter[i].Name;
                theCharacter.Race = characterList.theCharacter[i].Race;
                theCharacter.Skills = characterList.theCharacter[i].Skills;
                theCharacter.Spells = characterList.theCharacter[i].Spells;
                
                notFound = false;
                break;
            }
        }
        
        if(notFound)
        {
            // Some sort of error.
        }
    }
}

public class Character
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Age { get; set; }
    public string Race { get; set; }
    public string Description { get; set; }
    public string Background { get; set; }

    [XmlElement("Attributes")]
    public CharacterAttributes Attributes { get; set; }

    [XmlElement("Classes")]
    public CharacterClasses Classes { get; set; }

    [XmlElement("Feats")]
    public CharacterFeats Feats { get; set; }

    [XmlElement("Skills")]
    public CharacterSkills Skills { get; set; }

    [XmlElement("Spells")]
    public CharacterSpells Spells { get; set; }

    [XmlElement("Equipment")]
    public CharacterEquipment Equipment { get; set; }

    [XmlElement("Inventory")]
    public CharacterInventory Inventory { get; set; }

    [XmlElement("Effects")]
    public CharacterEffects Effects { get; set; }

    public string GetCharacterAttributeValue(string attributeId)
    {
        string value="0";

        for (int i = 0; i < this.Attributes.Attribute.Length; i++)
        {
            if (attributeId == this.Attributes.Attribute[i].Id)
            {
                value = this.Attributes.Attribute[i].Value;
                break;
            }
        }

        return value;
    }

    public string GetCharacterSkillValue(string skillId)
    {
        string value = "0";

        for (int i = 0; i < this.Skills.Skill.Length; i++)
        {
            if (skillId == this.Skills.Skill[i].Id)
            {
                value = this.Skills.Skill[i].Value;
                break;
            }
        }

        return value;
    }

    public string GetCharacterFirstClass()
    {
        string value = "";

        value = this.Classes.Class[0].Id;

        return value;
    }

    public string GetCharacterClassString()
    {
        string value = "";

        for (int i = 0; i < this.Classes.Class.Length; i++ )
        {
            value = value + char.ToUpper(this.Classes.Class[i].Id[0]) + this.Classes.Class[i].Id.Substring(1);
            value = value + " ";

            if (this.Classes.Class.Length < 1 && i != this.Classes.Class.Length)
            {
                value = value + "/ ";
            }
        }

        return value;
    }

    public string GetCharacterCharacterLevel()
    {
        string value = "0";

        int levels = 0;
        for (int i = 0; i < this.Classes.Class.Length; i++)
        {
            levels += Convert.ToInt32(this.Classes.Class[i].Level.ToString());
        }

        value = levels.ToString();
        return value;
    }
}

public class CharacterAttributes
{
    [XmlElement("Attribute")]
    public CharacterAttributesAttribute[] Attribute { get; set; }
}

public class CharacterAttributesAttribute
{
    public string Id { get; set; }
    public string Value { get; set; }
}

public class CharacterClasses
{
    [XmlElement("Class")]
    public CharacterClassesClass[] Class { get; set; }
}

public class CharacterClassesClass
{
    public string Id { get; set; }
    public string Level { get; set; }
    public string IsCurrent { get; set; }
}

public class CharacterFeats
{
    [XmlElement("Feat")]
    public CharacterFeatsFeat[] Feat { get; set; }
}

public class CharacterFeatsFeat
{
    public string Id { get; set; }
}

public class CharacterSkills
{
    [XmlElement("Skill")]
    public CharacterSkillsSkill[] Skill { get; set; }
}

public class CharacterSkillsSkill
{
    public string Id { get; set; }
    public string Value { get; set; }
}

public class CharacterSpells
{
    [XmlElement("Spell")]
    public CharacterSpellsSpell[] Spell { get; set; }
}

public class CharacterSpellsSpell
{
    public string Id { get; set; }
}

public class CharacterEquipment
{
    [XmlElement("Item")]
    public CharacterEquipmentItem[] Item { get; set; }
}

public class CharacterEquipmentItem
{
    public string Id { get; set; }
    public string Slot { get; set; }
    public string Quantity { get; set; }
}

public class CharacterInventory
{
    [XmlElement("Item")]
    public CharacterInventoryItem[] Item { get; set; }
}

public class CharacterInventoryItem
{
    public string Id { get; set; }
    public string Quantity { get; set; }
}

public class CharacterEffects
{
    [XmlElement("Effect")]
    public CharacterEffectsEffect[] Effect { get; set; }
}

public class CharacterEffectsEffect
{
    public string Id { get; set; }
    public string TimeLeft { get; set; }
    public string Value { get; set; }
}
