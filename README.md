# brokenstaffcrpg
Broken Staff CRPG System
Version 0.4 (Alpha 4)

Copyright © 2013-2015 Broken Staff Studios.
Released under the General Attribution License.

===============================================================================

History

Version 0.4  - Updates to characters, items, races, monsters & encounters.
Version 0.3  - Prelaunch coinciding with the system browser utility.
Version 0.2  - Prelaunch with significant changes (March 2014)
Version 0.1  - Prelaunch (March 2014)

===============================================================================

Table of Contents

1.0 Overview
2.0 Basics
	2.1 Effects
	2.2 Attributes
	2.3 Skills
	2.4 Feats
	2.5 Races
	2.6 Classes
	2.7 Items
	2.8 Spells
	2.9 Monsters
	2.10 Encounters
        2.11 Characters
	2.12 Parties

===============================================================================

1.0 Overview

The Broken Staff CRPG is an open-source, custom role-playing system designed by Broken Staff Studios for a number of projects we are working on.

It was mainly influenced by the following games: Wizardry 6/7/8, Might & Magic 4-6, DND 3.5, Darklands, Daggerfall/Morrowind, Quest for Glory 1/2, Grimoire Super Demo and Mount and Blade: Warband.

For news and updates about this system or to get the latest version please go to: http://brokenstaffcrpg.blogspot.com/.

It uses the General Attribution License. You can read more about it here: http://copyfree.org/standard/licenses (General Attribution License.) 

The license effects all the XML files and any included PDF files - the XML is for storing the data and the PDFs are for explaining how the data is used.

What does the license mean in short? You can use this system for anything you want even commercial applications, as long as you include an attribution to Broken Staff Studios. See the license.txt file for more information.

-------------------------------------------------------------------------------

2.0 Basics

The following sections describe the basic elements of the system.

-------------------------------------------------------------------------------

2.1 Effects

At the heart of the Broken Staff CRPG system are effects.

You can find the effect information in two files: Effects.xml and EffectTypes.xml.

EffectTypes.xml currently lists the 6 types of effects used.

Effects.xml lists many types of effects. 

If you wish to add new effects to your game you need to first add a relevant entry in this file. Next you would include the effect in any of the files that make use of it such as in: attributes, skills, feats, races, classes, items, monsters etc. Finally you would add code to your game system to handle the new effect.

-------------------------------------------------------------------------------

2.2 Attributes

The next major element in the system is attributes. This handles the classics such as health points and stamina points as well as resistances and regeneration rates.

You can find the attribute information in two files: Attributes.xml and AttributeTypes.xml.

AttributeTypes.xml currently lists the 4 types of attributes used: primary, secondary, drived and resistances.

Attributes.xml lists all the attributes used by the game. 

If you wish to add new attributess to your game you need to first add a relevant entry in this file. Next you would include the effect in any of the files that make use of it such as in: effects, skills, feats, races, classes, items, monsters etc. Finally you would add code to your game system to handle the new effect.

-------------------------------------------------------------------------------

2.3 Skills

Another big element of the Broken Staff Studio are skills. Skills play a large role similar to such games as Daggerfall and Wizardry 7 - between attributes and skills there is a lot of customization available to your characters.

You can find the skill information in two files: Skills.xml and SkillGroups.xml.

SkillGroups.xml currently lists the 6 types of skills used: combat, athletics, rogue, knowledge, magic and special. Right now the system does not have any special skills - they are meant for modders to add them in.

Skills.xml lists all the skills in the game and what effect they have on characters. 

If you wish to add new skills to your game you need to first add a relevant entry in this file. Next you would include the skills in any of the files that make use of it such as in: effects, attributes, feats, races, classes, items, monsters etc. Finally you would add code to your game system to handle the new effect.


-------------------------------------------------------------------------------

2.4 Feats

One of the best part of the DND 3.0 / DND 3.5 systems were their special abilities called feats. Adding feats to the races,classes and skills added another level of complexity and customization to character development.

Another neat element of DND 3.0 and 3.5 is prestige classes. The Broken Staff CRPG system already has 18 base classes so it does not utilize prestige classes. But it DOES add class specializations using feats - there are ususally 3 class based specializations and 2 race based specializations available for characters that meet their requirements.

You can find the skill information in two files: Feats.xml and FeatGroups.xml.

FeatGroups.xml currently lists the 2 types of skills used: passive and triggered. Passive feats are active all of the time while triggered feats have to be used by the character to take advantage of the effects in them.

Feats.xml lists all the feats in the game and what effect they have on characters. 

If you wish to add new feats to your game you need to first add a relevant entry in this file. Next you would include the skills in any of the files that make use of it such as in: effects, attributes, skills, races, classes, items, monsters etc. Finally you would add code to your game system to handle the new effect.

-------------------------------------------------------------------------------

2.5 Races

Choosing a race gives a character access to certain starting attributes, feats and skills. They also add flavour to character creation.

You can find the skill information in two files: Races.xml and RacialGroups.xml.

RacialGroups.xml currently lists the 8 types of racial groups used: humanoid, beast, outsider, undead, construct, animal, plant and dragon. Humanoid races include the standard fantasy races you are used to. You cannot currently choose races based on constructs, animals, plants or dragons - those are more for NPCs and monsters.

Races.xml lists all the races playable and non-playable in the game system:
	Humanoid: Human, Dwarf, Elf, Hobbit, Gnome, Dark Elf
	Beast: Orc, Minotaur, Ogre, Fe-lion, Rattus, Werewolf, Draconian, Lizardman
	Outsider: Seraphim, Demonspawn, Ignis (Fire), Hydros (Water), Granote (Earth), Aetheri (Air) 
	Undead: Lich, Wampyri

If you wish to add new races to your game you need to first add a relevant entry in this file. Next you would include the skills in any of the files that make use of it such as in: effects, attributes, skills, races, classes, items, monsters etc. Finally you would add code to your game system to handle the new race.

Currently there are generic humanoid and beast races that are used for monsters. This will be updated in future versions of the system.


-------------------------------------------------------------------------------

2.6 Classes

You can find the attribute information in two files: Classes.xml and ClassGroups.xml.

ClassGroups.xml currently lists the 3 types of classes used: Warrior, rogue and spellcaster.

Classes.xml lists all the classes in the game:
	Warrior: Fighter, Berserker, Paladin, Blackguard, Ranger, Spellsword
	Rogue: Swashbuckler, Assassin, Thief, Spy, Adventurer, Bard 
	Spellcaster: Mage, Psionic, Warlock, Priest, Necromancer, Druid

If you wish to add new classes to your game you need to first add a relevant entry in this file. Next you would include the class in any of the files that make use of it such as in: skills, feats, items, monsters etc. Finally you would add code to your game system to handle the new class.


-------------------------------------------------------------------------------

2.7 Items

You can find the item information in two files: Items.xml and ItemTypes.xml.

ItemTypes.xml currently lists the 13 types of items used: 
	Weapon, Body (armour), Helmet, Hand, Foot, Ring, Amulet, Belt, Cloak, Potion, Scroll, Book, Misc


Items.xml lists all the classes in the game:

If you wish to add new items to your game you need to first add a relevant entry in this file. Next you would include the item in any of the files that make use of it such as in: effects, skills, feats, races, classes, characters, monsters etc. Finally you would add code to your game system to handle the new item.

-------------------------------------------------------------------------------

2.8 Spells

You can find the item information in two files: Spells.xml, SpellBooks and SpellLevels.xml.

SpellBooks.xml currently lists the 6 unique spellbooks used: 
	Arcane: Mages, Spellswords, Bards, Adventurers
	Infernal: Warlocks
	Necromancy: Necromancers, Blackguards
	Divine: Priests, Paladins, Bards, Adventurers
	Nature: Druids, Rangers
	Mental: Psionics, Spies, Bards, Adventurers


SpellLevels.xml lists the 7 spell levels used in the game.

Spells.xml lists all the spells in the game. There are currently almost 500 spells in the game split over the 6 spellbooks.

If you wish to add new spells to your game you need to first add a relevant entry in this file. Next you would include the spell in any of the files that make use of it such as in items etc. Finally you would add code to your game system to handle the new spell.


-------------------------------------------------------------------------------

2.9 Monsters

Monsters underwent a massive overheal in v0.4, preparing for the combat engine in v0.5.

Monsters.xml lists the monsters defined in the game:

	Humanoids - 	thug (1), thief (2), bandit (3), rogue (5), catburgler (9), masterthief (16)
					spy (5), secretagent (11) , spymaster (18)
					hiredkiller (5), assassin (12), masterassassin (17)
					fighter (1), warrior (3), mercenary (5), maurauder (7), raubritter (9)
					scout (4), darkranger (8)
					darkknight (5), blackguard (9), infamousblackguard (15)
					
					apprenticemage (1), mage (5), spellbinder (9), magician (13), wizard (17), archmage (21), archwizard (25)
					seer (1), medium (4), telepath (7), mindbender (10), illusionist (13), psion (17), archpsion (21)
					gaian (1), medicineman (4), soothsayer (7), siren (11), druid (15), shaman (19), archdruid (23)
					voodooist (1), witchdoctor (4), apprenticenecromancer (7), blackmagician (14), thaumaturge (17), theurgist (20), necromancer (23)
					occultist (1), conjurer (5), sorcerer (10), witch (15), warlock (20), diabolist (25), cultleader (30)
										
	Beast Races - 	kobald (1), kobaldlurker (2), kobaldscout (2), kobaldwarrior (3), kobaldshaman (4), kobaldchieftain (4)
					forestgoblin (1), forestgoblinwarrior (2), forestgoblinberserker (3), forestgoblinchieftain (4), forestgoblinshaman (5)
					goblin (1), goblinscout (2), goblinwitchdoctor (3), goblinranger (4), goblinwarrior (5), goblinshaman (6), goblinchieftain (7)
					hobgoblin (2), hobgoblinwarrior (4), hobgoblinblackguard (6), hobgoblinshaman (8), hobgoblinchieftain (10)
					lizardman (2), lizardmanscout (3), lizardmanranger (5), lizardmanwarrior (5), lizardmanshaman (9), lizardmanchieftain (11)
					orc (2), orctribesman (3), orcscout (5), orcwarrior (7), orcberserker (9), orcshaman (11), orcwitchdoctor (11), orcchieftain (13)
					urukhai (3), urukhaiscout (6), urukhaiwarrior (8), urukhaiberserker (10), urukhaielite (12), urukhaichieftain (14)
					bugbear (4), bugbearscout (6), bugbearwarrior (9), bugbearberserker (11), bugbearshaman (13), bugbearchieftain (15)
					ogre (6), ogrewarrior (9), ogreberserker (12), ogreshaman (15), ogrechieftain (18)
					troll (5), frosttroll (10), twoheadedtroll (15)
					omegawerewolf (1), gammawerewolf (3), deltawerewolf (5), betawerwwolf (10), sigmawerewolf (15), alphawerewolf (20), ancientwerewolf (28)
					minotaur (4), minotaurscout (8), minotaurpirate (12), minotaurwarrior (16), minotaurberserker (18), minotaurgladiator (22), minotaurdarkpriest (20), minotaurwarlock (22), minotaurking (28)
					
					Future:
					hillgiant (8), hillgiantshaman (14), hillgiantchieftain (22)
					mountaingiant (20), mountaingiantshaman (28), mountaingiantchieftain (36)
					
	Outsider - 		fireelemental, greaterfireelemental, elderfireelemental, fireelementallord
					earthelemental, greaterearthelemental, elderearthelemental, earthelementallord
					waterelemental, greaterwaterelemental, elderwaterelemental, waterelementallord
					airelemental, greaterairelemental, elderairelemental, airelementallord
					iceelemental,
					cloudelemental, windwalker,
					crystalelemental,
					lavaman, burningman,
					darkhound, hellhound,
					felltroll,
					volcanicentity,
					imp, quasit
					cambion, cambionthief, cambionassassin, cambionblackguard, cambionnecromancer, cambionwarlock
					demon, elderdemon, demonlord
					
	Undead - 		skeleton (2), skeletonwarrior (5), skeletonchampion (8)
					shamblingzombie (1), zombie (4), zombiewarrior (7), dreadzombie (10)
					ghoul (6), ghast (9), wight (12), winterwight (15)
					ghost (8), wraith (11), ringwraith (14)
					fledgelingvampire (10), vampire (15), vampirelord (25), vampirepatriarch (35)
					netherlich (20), lich (30), ancientlich (40)
					
	Construct -		mudgolem, mudman
					fleshgolem, 
					stonegolem, 
					irongolem,
					mithrilgolem
					daemonicgolem,
					adamantiumgolem
					
	Animals - 		ferret (1), direferret
					badger (1), direbadger
					wilddog (2), rabiddog (4)
					omegawolf (3), gammawolf (5), deltawolf (7), betawolf (9), sigmawolf (11), alphawolf (13), direwolf (16)
					warg (8), direwarg (18)
					boar (10), direboar (14)
					locustswarm (19), pestilenceswarm (26)
					blackbear (15), brownbear (20), grizzlybear (25), kodiakbear (30), polarbear (35), direbear (40)
					warhawk, firehawk, gianteagle
					aboninablesnowman (), sasquatch ()
					
	Plant - 		treant, shamblingmound
	
	Dragon - 		reddragonling, youngreddragon, reddragon, ancientreddragon
					blackdragonling, youngblackdragon, blackdragon, ancientblackdragon
					bluedragonling, youngbluedragon, bluedragon, ancientbluedragon
					greendragonling, younggreendragon, greendragon, ancientgreendragon
					whitedragonling, youngwhitedragon, whitedragon, ancientwhitedragon
					
	Reptile - 		alligator, crocodile, komododragon
					terradactyl, 
					raptor, 
					albertasaurus, 
					tyranosaurus
					
	Spirit - 		nymph, dryad, 
					wendigo
					
	Bosses - 		named characters and monsters
					cerberus - 3 headed dark hound

-------------------------------------------------------------------------------

2.10 Encounters

Encounters.xml lists random encounters that can happen in the game by tag (location).

-------------------------------------------------------------------------------

2.11 Characcters

Characters.xml lists the predefined characters used by the system. Player
generated players would go there as well.

-------------------------------------------------------------------------------

2.12 Parties

Parties.xml lists the two or three predefined parties used by the system.
Player created parties would go there as well.

-------------------------------------------------------------------------------
