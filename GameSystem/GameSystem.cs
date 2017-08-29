using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace BrokenStaffBattler
{
    // Game or Editor (some application)
    // |____ Game System
    // |____ Graphics (UI) System
    // --------------------------

    /// <summary>
    /// This is the main wrapper class for the Broken Staff CRPG system.
    /// </summary>
    public class BrokenStaffCRPGSystem
    {
        // ========================================================================================
        // GAME SYSTEM DATA - Comprised of a number of sub-classes
        // ========================================================================================

        // Damage Types
        private Configuration configuration;

        // Game World
        // ========================================================================================

        // Damage Types
        private DamageTypes damageTypesList;

        // Effects
        private EffectTypes effectTypesList;
        private Effects effectsList;

        // Spells
        private SpellBooks spellBooksList;
        private SpellLevels spellLevelsList;
        private Spells spellsList;

        // Items
        private ItemTypes itemTypesList;
        private GameItems itemsList;

        // Races
        private RacialGroups racialGroupsList;
        private Races racesList;

        // Classes
        private ClassGroups classGroupsList;
        private Classes classList;

        // Attributes
        private AttributeTypes attributeGroupsList;
        private Attributes attributesList;

        // Skills
        private SkillGroups skillGroupsList;
        private Skills skillsList;

        // Feats
        private FeatGroups featGroupsList;
        private Feats featsList;

        // Party
        // ========================================================================================

        private Party theParty;

        // Character
        // ========================================================================================

        private Characters characterList;

        // Monsters
        // Monster Groups
        private Monsters monstersList;

        // NPC Groups (joinable, selling, main, etc)
        // NPCs

        // The following would be system/game dependent.
        // Map Groups (random?)
        // Maps
        // Quest Groups
        // Quests
        // Object Groups (chests, traps, etc)
        // Objects
        // Dialog Groups
        // Dialog

        // J 9, 2014
        // Work on monsters, characters, configuration and party next.
        // update to not just load files, but load files in \Data subdirectory.

        // ========================================================================================
        // LOAD GAME SYSTEM DATA FROM XML
        // ========================================================================================

        /// <summary>
        /// This function loads the data types XML file and then converts the XML to array format to be used by the damageTypesList variable.
        /// </summary>
        public Configuration GetConfigurationFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new Configuration();
            var reader = XmlReader.Create("Data\\Configuration.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Configuration));
                obj = (Configuration)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the data types XML file and then converts the XML to array format to be used by the damageTypesList variable.
        /// </summary>
        public DamageTypes GetDamageTypesFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new DamageTypes();
            var reader = XmlReader.Create("Data\\DamageTypes.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(DamageTypes));
                obj = (DamageTypes)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the effect types XML file and then converts the XML to array format to be used by the effectTypesList variable.
        /// </summary>
        public EffectTypes GetEffectTypesFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new EffectTypes();
            var reader = XmlReader.Create("Data\\EffectTypes.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(EffectTypes));
                obj = (EffectTypes)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the effects XML file and then converts the XML to array format to be used by the effectsList variable.
        /// </summary>
        public Effects GetEffectsFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new Effects();
            var reader = XmlReader.Create("Data\\Effects.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Effects));
                obj = (Effects)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the spell books XML file and then converts the XML to array format to be used by the spellBooksList variable.
        /// </summary>
        public SpellBooks GetSpellBooksFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new SpellBooks();
            var reader = XmlReader.Create("Data\\SpellBooks.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(SpellBooks));
                obj = (SpellBooks)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the spell levels XML file and then converts the XML to array format to be used by the spellLevelsList variable.
        /// </summary>
        public SpellLevels GetSpellLevelsFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new SpellLevels();
            var reader = XmlReader.Create("Data\\SpellLevels.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(SpellLevels));
                obj = (SpellLevels)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the spells XML file and then converts the XML to array format to be used by the spellsList variable.
        /// </summary>
        public Spells GetSpellsFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new Spells();
            var reader = XmlReader.Create("Data\\Spells.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Spells));
                obj = (Spells)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the item types XML file and then converts the XML to array format to be used by the itemTypesList variable.
        /// </summary>
        public ItemTypes GetItemTypesFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new ItemTypes();
            var reader = XmlReader.Create("Data\\ItemTypes.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemTypes));
                obj = (ItemTypes)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the items XML file and then converts the XML to array format to be used by the itemsList variable.
        /// </summary>
        public GameItems GetItemsFromXML()
        {
            var settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreWhitespace = true;
            var obj = new GameItems();
            var reader = XmlReader.Create("Data\\Items.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(GameItems));
                obj = (GameItems)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the racial groups XML file and then converts the XML to array format to be used by the racialGroupsList variable.
        /// </summary>
        public RacialGroups GetRacialGroupsFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new RacialGroups();
            var reader = XmlReader.Create("Data\\RacialGroups.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(RacialGroups));
                obj = (RacialGroups)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the races XML file and then converts the XML to array format to be used by the racesList variable.
        /// </summary>
        public Races GetRacesFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new Races();
            var reader = XmlReader.Create("Data\\Races.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Races));
                obj = (Races)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the class groups XML file and then converts the XML to array format to be used by the classGroupsList variable.
        /// </summary>
        public ClassGroups GetClassGroupsFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new ClassGroups();
            var reader = XmlReader.Create("Data\\ClassGroups.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(ClassGroups));
                obj = (ClassGroups)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the classes XML file and then converts the XML to array format to be used by the classesList variable.
        /// </summary>
        public Classes GetClassesFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new Classes();
            var reader = XmlReader.Create("Data\\Classes.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Classes));
                obj = (Classes)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the attribute groups XML file and then converts the XML to array format to be used by the attributeGroupsList variable.
        /// </summary>
        public AttributeTypes GetAttributeGroupsFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new AttributeTypes();
            var reader = XmlReader.Create("Data\\AttributeTypes.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(AttributeTypes));
                obj = (AttributeTypes)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the attributes XML file and then converts the XML to array format to be used by the attributesList variable.
        /// </summary>
        public Attributes GetAttributesFromXML()
        {
            var settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreWhitespace = true;

            var obj = new Attributes();

            var reader = XmlReader.Create("Data\\Attributes.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Attributes));
                obj = (Attributes)serializer.Deserialize(reader);
 
            }
            catch(Exception e) {
                MessageBox.Show(e.ToString());
            }

            return (Attributes)obj;
        }

        /// <summary>
        /// This function loads the skill groups XML file and then converts the XML to array format to be used by the skillGroupsList variable.
        /// </summary>
        public SkillGroups GetSkillGroupsFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new SkillGroups();
            var reader = XmlReader.Create("Data\\SkillGroups.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(SkillGroups));
                obj = (SkillGroups)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the skills XML file and then converts the XML to array format to be used by the skillsList variable.
        /// </summary>
        public Skills GetSkillsFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new Skills();
            var reader = XmlReader.Create("Data\\Skills.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Skills));
                obj = (Skills)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the feat groups XML file and then converts the XML to array format to be used by the featGroupsList variable.
        /// </summary>
        public FeatGroups GetFeatGroupsFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new FeatGroups();
            var reader = XmlReader.Create("Data\\FeatGroups.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(FeatGroups));
                obj = (FeatGroups)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the feats XML file and then converts the XML to array format to be used by the featsList variable.
        /// </summary>
        public Feats GetFeatsFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new Feats();
            var reader = XmlReader.Create("Data\\Feats.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Feats));
                obj = (Feats)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the characters XML file and then converts the XML to array format to be used by the charactersList variable.
        /// </summary>
        public Characters GetCharactersFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new Characters();
            var reader = XmlReader.Create("Data\\Characters.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Characters));
                obj = (Characters)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the party XML file and then converts the XML to array format to be used by the partyList variable.
        /// </summary>
        public Party GetPartyFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new Party();
            var reader = XmlReader.Create("Data\\Party.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Party));
                obj = (Party)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        /// <summary>
        /// This function loads the monsters XML file and then converts the XML to array format to be used by the monstersList variable.
        /// </summary>
        public Monsters GetMonstersFromXML()
        {
            var settings = new XmlReaderSettings();
            var obj = new Monsters();
            var reader = XmlReader.Create("Data\\Monsters.xml", settings);

            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Monsters));
                obj = (Monsters)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            reader.Close();
            return obj;
        }

        // ========================================================================================
        // GAME SYSTEM
        // ========================================================================================

        /// <summary>
        /// This function initializes the Broken Staff CRPG system. It calls a number of other functions that load XML files.
        /// </summary>
        public BrokenStaffCRPGSystem()
        {
            // Initialize / load the data

            // Game World
            configuration = GetConfigurationFromXML();            
            damageTypesList = GetDamageTypesFromXML();
            effectTypesList = GetEffectTypesFromXML();
            attributeGroupsList = GetAttributeGroupsFromXML();
            skillGroupsList = GetSkillGroupsFromXML();
            featGroupsList = GetFeatGroupsFromXML();
            racialGroupsList = GetRacialGroupsFromXML();
            classGroupsList = GetClassGroupsFromXML();
            spellBooksList = GetSpellBooksFromXML();
            spellLevelsList = GetSpellLevelsFromXML();
            itemTypesList = GetItemTypesFromXML();

            effectsList = GetEffectsFromXML();
            attributesList = GetAttributesFromXML();
            skillsList = GetSkillsFromXML();
            featsList = GetFeatsFromXML();
            racesList = GetRacesFromXML();
            classList = GetClassesFromXML();
            itemsList = GetItemsFromXML();
            spellsList = GetSpellsFromXML();            

            theParty = GetPartyFromXML();
            characterList = GetCharactersFromXML();

            monstersList = GetMonstersFromXML();
        }

        /// <summary>
        /// This function returns a copy of the configuration variable.
        /// </summary>
        public Configuration getConfiguration()
        {
            return configuration;
        }

        /// <summary>
        /// This function returns a configuration variable.
        /// </summary>
        public string getConfigurationVariable(string Id)
        {
            string Value = "";

            // Using for loop. Find a faster way to do this in the future.
            for (int i = 0; i < configuration.Setting.Length; i++) // configuration.Feat.Length
            {
                if (configuration.Setting[i].Id == Id)
                {
                    Value = configuration.Setting[i].Value;
                    break;
                }
                //lvFeats.Items.Add(featsList.Feat[i].Id, featsList.Feat[i].Name, 0);
            }

            return Value;
        }        

        /// <summary>
        /// This function returns a copy of the damage types variable.
        /// </summary>
        public DamageTypes getDamageTypesList()
        {
            return damageTypesList;
        }

        /// <summary>
        /// This function takes the passed id and checks if there is a damage type associated with it. If so it returns a copy of that damage type.
        /// </summary>
        /// <param name="damageTypeId">
        /// A string with the id of the damage type that needs to be looked up.
        /// </param>
        public DamageType getDamageTypesById(String damageTypeId)
        {
            bool found = false;
            DamageType damageType = new DamageType();
            DamageTypes damageTypes = getDamageTypesList();

            for (int i = 0; i < damageTypes.DamageType.Length; i++)
            {
                if (damageTypes.DamageType[i].Id == damageTypeId)
                {
                    damageType = damageTypes.DamageType[i];
                    found = true;
                    break;
                }
            }

            if(found)
                return damageType;
            else          
                return null;            
        }

        /// <summary>
        /// This function returns a copy of the effect types variable.
        /// </summary>
        public EffectTypes getEffectTypesList()
        {
            return effectTypesList;
        }

        /// <summary>
        /// This function takes the effect type id and checks if there is an effect type associated with it. If so it returns a copy of that effect type.
        /// </summary>
        /// <param name="effectTypeId">
        /// A string with the id of the effect that needs to be looked up.
        /// </param>
        public EffectType getEffectTypeById(String effectTypeId)
        {
            bool found = false;
            EffectType effectType = new EffectType();
            EffectTypes effectTypes = getEffectTypesList();

            for (int i = 0; i < effectTypes.EffectType.Length; i++)
            {
                if (effectTypes.EffectType[i].Id == effectTypeId)
                {
                    effectType = effectTypes.EffectType[i];
                    found = true;
                    break;
                }
            }

            if (found)
                return effectType;
            else
                return null;
        }

        /// <summary>
        /// This function returns a copy of the effects variable.
        /// </summary>
        public Effects getEffectsList()
        {
            return effectsList;
        }

        /// <summary>
        /// This function takes the effect id and checks if there is an effect associated with it. If so it returns a copy of that effect.
        /// </summary>
        /// <param name="effectId">
        /// A string with the id of the effect that needs to be looked up.
        /// </param>
        public Effect getEffectById(String effectId)
        {
            bool found = false;
            Effect effect = new Effect();
            Effects effects = getEffectsList();

            for (int i = 0; i < effects.Effect.Length; i++)
            {
                if (effects.Effect[i].Id == effectId)
                {
                    effect = effects.Effect[i];
                    found = true;
                    break;
                }
            }

            if (found)
                return effect;
            else
                return null;
        }

        /// <summary>
        /// This function returns a copy of the spell books variable.
        /// </summary>
        public SpellBooks getSpellBooks()
        {
            return spellBooksList;
        }

        /// <summary>
        /// This function returns a copy of the spell levels variable.
        /// </summary>
        public SpellLevels getSpellLevels()
        {
            return spellLevelsList;
        }

        /// <summary>
        /// This function returns a copy of the item types variable.
        /// </summary>
        public ItemTypes getItemTypesList()
        {
            return itemTypesList;
        }

        /// <summary>
        /// This function returns a copy of the items variable.
        /// </summary>
        public GameItems getItemsList()
        {
            return itemsList;
        }

        /// <summary>
        /// This function takes the passed id and checks if there is a damage type associated with it. If so it returns a copy of that damage type.
        /// </summary>
        /// <param name="itemId">
        /// A string with the id of the damage type that needs to be looked up.
        /// </param>
        public GameItem getItemsById(String itemId)
        {
            bool found = false;
            GameItem gameItem = new GameItem();
            GameItems gameItems = getItemsList();

            for (int i = 0; i < gameItems.Item.Length; i++)
            {
                if (gameItems.Item[i].Id == itemId)
                {
                    gameItem = gameItems.Item[i];
                    found = true;
                    break;
                }
            }

            if (found)
                return gameItem;
            else
                return null;
        }

        /// <summary>
        /// This function returns a copy of the racial groups variable.
        /// </summary>
        public RacialGroups getRacialGroupsList()
        {
            return racialGroupsList;
        }

        /// <summary>
        /// This function returns a copy of the races variable.
        /// </summary>
        public Races getRaceList()
        {
            return racesList;
        }

        /// <summary>
        /// This function takes the race id and checks if there is a race associated with it. If so it returns a copy of that race.
        /// </summary>
        /// <param name="raceId">
        /// A string with the id of the race that needs to be looked up.
        /// </param>
        public Race getRaceById(String raceId)
        {
            bool found = false;
            Race race = new Race();
            Races races = getRaceList();

            for (int i = 0; i < races.Race.Length; i++)
            {
                if (races.Race[i].Id == raceId)
                {
                    race = races.Race[i];
                    found = true;
                    break;
                }
            }

            if (found)
                return race;
            else
                return null;
        }

        /// <summary>
        /// This function returns a copy of the class groups variable.
        /// </summary>
        public ClassGroups getClassGroupsList()
        {
            return classGroupsList;
        }

        /// <summary>
        /// This function returns a copy of the classes variable.
        /// </summary>
        public Classes getClassList()
        {
            return classList;
        }

        /// <summary>
        /// This function takes the class id and checks if there is a class associated with it. If so it returns a copy of that class.
        /// </summary>
        /// <param name="classId">
        /// A string with the id of the class that needs to be looked up.
        /// </param>
        public Class getClassById(String classId)
        {
            bool found = false;
            Class gameClass = new Class();
            Classes gameClasses = getClassList();

            for (int i = 0; i < gameClasses.Class.Length; i++)
            {
                if (gameClasses.Class[i].Id == classId)
                {
                    gameClass = gameClasses.Class[i];
                    found = true;
                    break;
                }
            }

            if (found)
                return gameClass;
            else
                return null;
        }

        /// <summary>
        /// This function returns a copy of the attribute groups variable.
        /// </summary>
        public AttributeTypes getAttributeGroups()
        {
            return attributeGroupsList;
        }

        /// <summary>
        /// This function returns a copy of the attributes variable.
        /// </summary>
        public Attributes getAttributes()
        {
            return attributesList;
        }

        /// <summary>
        /// This function takes the attribute id and checks if there is a attribute associated with it. If so it returns a copy of that attribute.
        /// </summary>
        /// <param name="attributeId">
        /// A string with the id of the attribute that needs to be looked up.
        /// </param>
        public Attribute getAttributeById(String attributeId)
        {
            bool found = false;
            Attribute attribute = new Attribute();
            Attributes attributes = getAttributes();
            
            for (int i = 0; i < attributes.Attribute.Length; i++)
            {
                if (attributes.Attribute[i].Id == attributeId)
                {
                    attribute = attributes.Attribute[i];
                    found = true;
                    break;
                }
            }

            if (found)
                return attribute;
            else
                return null;
        }

        /// <summary>
        /// This function returns a copy of the skill groups variable.
        /// </summary>
        public SkillGroups getSkillGroups()
        {
            return skillGroupsList;
        }

        /// <summary>
        /// This function returns a copy of the skills variable.
        /// </summary>
        public Skills getSkills()
        {
            return skillsList;
        }

        /// <summary>
        /// This function takes the skill id and checks if there is a skill associated with it. If so it returns a copy of that skill.
        /// </summary>
        /// <param name="skillId">
        /// A string with the id of the skill that needs to be looked up.
        /// </param>
        public Skill getSkillById(String skillId)
        {
            bool found = false;
            Skill skill = new Skill();
            Skills skills = getSkills();

            for (int i = 0; i < skills.Skill.Length; i++)
            {
                if (skills.Skill[i].Id == skillId)
                {
                    skill = skills.Skill[i];
                    found = true;
                    break;
                }
            }

            if (found)
                return skill;
            else
                return null;
        }

        /// <summary>
        /// This function returns a copy of the feat groups variable.
        /// </summary>
        public FeatGroups getFeatGroups()
        {
            return featGroupsList;
        }

        /// <summary>
        /// This function returns a copy of the feats variable.
        /// </summary>
        public Feats getFeats()
        {
            return featsList;
        }

        /// <summary>
        /// This function takes the feat id and checks if there is a feat associated with it. If so it returns a copy of that feat.
        /// </summary>
        /// <param name="featId">
        /// A string with the id of the feat that needs to be looked up.
        /// </param>
        public Feat getFeatById(String featId)
        {
            bool found = false;
            Feat feat = new Feat();
            Feats feats = getFeats();

            for (int i = 0; i < feats.Feat.Length; i++)
            {
                if (feats.Feat[i].Id == featId)
                {
                    feat = feats.Feat[i];
                    found = true;
                    break;
                }
            }

            if (found)
                return feat;
            else
                return null;
        }

        /// <summary>
        /// This function returns a copy of the spells variable.
        /// </summary>
        public Spells getSpells()
        {
            return spellsList;
        }

        /// <summary>
        /// This function takes the feat id and checks if there is a feat associated with it. If so it returns a copy of that feat.
        /// </summary>
        /// <param name="featId">
        /// A string with the id of the feat that needs to be looked up.
        /// </param>
        public Spell getSpellById(String spellId)
        {
            bool found = false;
            Spell spell = new Spell();
            Spells spells = getSpells();

            for (int i = 0; i < spells.Spell.Length; i++)
            {
                if (spells.Spell[i].Id == spellId)
                {
                    spell = spells.Spell[i];
                    found = true;
                    break;
                }
            }

            if (found)
                return spell;
            else
                return null;
        }

        /// <summary>
        /// This function returns a copy of the characters variable.
        /// </summary>
        public Characters getCharacters()
        {            
            return characterList;
        }

        /// <summary>
        /// This function returns a copy of the party variable.
        /// </summary>
        public Party getParty()
        {
            return theParty;
        }

        /// <summary>
        /// This function takes the character id and checks if there is a party member associated with it. If so it returns a copy of that character.
        /// </summary>
        /// <param name="characterId">
        /// A string with the id of the character that needs to be looked up.
        /// </param>
        public PartyCharacters getPartyCharacterById(String characterId)
        {
            // THIS IS BROKEN!
            bool found = false;
            PartyCharacters character = new PartyCharacters();
            Party party = getParty();

            for (int i = 0; i < party.Parties.Length; i++)
            {
                //if (party.Characters[i].Id == characterId)
                //{
                //    character = party.Characters[i];
                //    found = true;
                //    break;
                //}
            }

            if (found)
                return character;
            else
                return null;
        }

        /// <summary>
        /// This function returns a copy of the party variable.
        /// </summary>
        public Monsters getMonsters()
        {
            return monstersList;
        }

        /// <summary>
        /// This function takes the monster id and checks if there is a monster associated with it. If so it returns a copy of that monster.
        /// </summary>
        /// <param name="monsterId">
        /// A string with the id of the monster that needs to be looked up.
        /// </param>
        public Monster getMonsterById(String monsterId)
        {
            bool found = false;
            Monster monster = new Monster();
            Monsters monsters = getMonsters();

            for (int i = 0; i < monsters.Monster.Length; i++)
            {
                if (monsters.Monster[i].Id == monsterId)
                {
                    monster = monsters.Monster[i];
                    found = true;
                    break;
                }
            }

            if (found)
                return monster;
            else
                return null;
        }
    }
}
