using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Important to have this attributes tag to because that is the root tag of the file.
[XmlRoot("Items")]
public class GameItems
{
    [XmlElement("Item")]
    public GameItem[] Item { get; set; }
}

public class GameItem
{
    public string Id { get; set; }
    public string Cost { get; set; }

    [XmlElement("ItemType")]
    public ItemType ItemType { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public string UnidentifiedName { get; set; }
    public string UnidentifiedDescription { get; set; }
    public string AssayingValue { get; set; }

    [XmlElement("Requirements")]
    public ItemRequirements Requirements { get; set; }

    [XmlElement("SkillsUsed")]
    public ItemSkillsUsed SkillsUsed { get; set; }

    [XmlElement("Attributes")]
    public ItemAttributes Attributes { get; set; }

    [XmlElement("OnUse")]
    public ItemOnUse OnUse { get; set; }

    [XmlElement("OnAttack")]
    public ItemOnAttack OnAttack { get; set; }

    [XmlElement("Crafting")]
    public ItemCrafting Crafting { get; set; }
}

public class ItemType
{
    public string Id { get; set; }
    public string IsEquipable { get; set; }
    public string IsUsable { get; set; }
}

public class ItemRequirements
{
    [XmlElement("Attributes")]
    public ItemRequirementsAttributes[] Attributes { get; set; }

    [XmlElement("Feats")]
    public ItemRequirementsFeats[] Feats { get; set; }
}

public class ItemRequirementsAttributes
{
    [XmlElement("Attribute")]
    public ItemRequirementsAttributesAttribute[] Attribute { get; set; }
}

public class ItemRequirementsFeats
{
    [XmlElement("Feat")]
    public ItemRequirementsFeatsFeat[] Feat { get; set; }
}

public class ItemRequirementsAttributesAttribute
{
    public string Id { get; set; }
    public string Value { get; set; }
}

public class ItemRequirementsFeatsFeat
{
    public string Id { get; set; }
}

public class ItemSkillsUsed
{
    [XmlElement("Skill")]
    public ItemSkillsUsedSkill[] Skill { get; set; }
}

public class ItemSkillsUsedSkill
{
    public string Id { get; set; }
}

public class ItemAttributes
{
    [XmlElement("Attribute")]
    public ItemAttributesAttribute[] Attribute { get; set; }
}

public class ItemAttributesAttribute
{
    public string Id { get; set; }
    public string Value { get; set; }
}

/*
 * 	<OnUse>
		<UseWhen>Both</UseWhen> <!-- Both, Combat, Non-combat -->
		<Uses>10</Uses> <!-- Single -->
		<Effects>
			<Effect>
				<Id>healhp</Id>			
				<Group>allies</Group> <!-- any, allies, enemies -->
				<Range>touch</Range> <!-- self, touch, short, medium, long, extralong -->
				<Target>single</Target> <!-- single, some, all -->
				<MinValue>8</MinValue>
				<MaxValue>18</MaxValue>
				<SavingThrows>
					<Allowed>No</Allowed>
				</SavingThrows>
			</Effect>		
		</Effects>
	</OnUse>
*/
public class ItemOnUse
{
    public string UseWhen { get; set; }
    public string Uses { get; set; }

    [XmlElement("Effects")]
    public ItemOnUseEffects Effects { get; set; }
}

public class ItemOnUseEffects
{
    [XmlElement("Effect")]
    public AttributeEffect[] ItemOnUseEffectsEffect { get; set; }
}

public class ItemOnUseEffectsEffect
{
    public string Id { get; set; }
    public string Group { get; set; }
    public string Range { get; set; }
    public string Target { get; set; }
    public string MinValue { get; set; }
    public string MaxValue { get; set; }

    [XmlElement("SavingThrows")]
    public ItemOnUseEffectsEffectSavingThrows SavingThrows { get; set; }
}

public class ItemOnUseEffectsEffectSavingThrows
{
    public string Allowed { get; set; }
}

public class ItemOnAttack
{
    [XmlElement("Effect")]
    public ItemOnAttackEffect[] Effect { get; set; }
}

/*
 * 		<Effect>
			<Percent>80</Percent>
			<Id>piercingdamage</Id>
			<Range>short</Range>
			<MinValue>1</MinValue>
			<MaxValue>2</MaxValue>
			<ToHit> 
				<Attribute>
					<Id>attackbonus</Id>
					<Value>0</Value>
				</Attribute>
				<Attribute>
					<Id>initiative</Id>
					<Value>2</Value>
				</Attribute>
			</ToHit>
		</Effect>  
 **/
public class ItemOnAttackEffect
{
    public string Id { get; set; }
    public string Percent { get; set; }
    public string Range { get; set; }
    public string MinValue { get; set; }
    public string MaxValue { get; set; }

    [XmlElement("ToHit")]
    public ItemOnAttackEffectToHit ToHit { get; set; }
}

public class ItemOnAttackEffectToHit
{
    [XmlElement("Attribute")]
    public ItemOnAttackEffectToHitAttribute[] Attribute { get; set; }
}

public class ItemOnAttackEffectToHitAttribute
{
    public string Id { get; set; }
    public string Value { get; set; }
}

/*
 * 	<Crafting>
		<IsCraftable>Yes</IsCraftable>
		<Skill>
			<Id>smithing</Id>
			<Value>5</Value> <!-- Minimum skill value needed to craft this item. -->
		</Skill>
		<ItemsRequired>
			<Item>
				<Id>ironore</Id>
				<Quantity>1</Quantity>
				<UsedUp>Yes</UsedUp>
			</Item>
			<Item>
				<Id>smithhammer</Id>
				<Quantity>1</Quantity>
				<UsedUp>No</UsedUp>
			</Item>
		</ItemsRequired>
	</Crafting>
 */

public class ItemCrafting
{
    public string IsCraftable { get; set; }

    [XmlElement("Skill")]
    public ItemCraftingSkill Skill { get; set; }

    [XmlElement("ItemsRequired")]
    public ItemCraftingItemsRequired ItemsRequired { get; set; }
}

public class ItemCraftingSkill
{
    public string Id { get; set; }
    public string Value { get; set; }
}

public class ItemCraftingItemsRequired
{
    [XmlElement("Item")]
    public ItemCraftingItemsRequiredItem[] Item { get; set; }
}

public class ItemCraftingItemsRequiredItem
{
    public string Id { get; set; }
    public string Quantity { get; set; }
    public string UsedUp { get; set; }
}
