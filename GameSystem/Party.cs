using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Important to have this attributes tag to because that is the root tag of the file.
[XmlRoot("Parties")]
public class Party
{
    [XmlElement("Party")]
    public PartiesParty[] Parties { get; set; }

    public string GetPartyCharactersMakeupBlurb(Characters characterList, string PartyId)
    {
        string blurb = "";

        for (int i = 0; i < this.Parties.Length; i++)
        {
            if (this.Parties[i].Id == PartyId)
            {
                // Found given party. Need to add character blurbs (Race / Sex / Class) for each character in party.
                string characterId;
                for (int j = 0; j < this.Parties[i].Characters.Character.Length; j++)
                {
                    characterId = this.Parties[i].Characters.Character[j].Id;

                    for (int k = 0; k < characterList.theCharacter.Length; k++)
                    {
                        if (characterList.theCharacter[k].Id == characterId)
                        {
                            // We have a match. Add the information to the blurb.
                            blurb = blurb + characterList.theCharacter[k].Race.Substring(0,3).ToUpper();
                            blurb = blurb + "/";
                            blurb = blurb + characterList.theCharacter[k].GetCharacterAttributeValue("sex").Substring(0, 1).ToUpper();
                            blurb = blurb + "/";
                            blurb = blurb + characterList.theCharacter[k].GetCharacterFirstClass().Substring(0, 3).ToUpper();

                            // Show if the party leader.
                            if (this.Parties[i].Characters.Character[j].IsLeader.ToUpper() == "YES")
                            {
                                blurb = blurb + "!";
                            }

                            // Show if a hirling.
                            if (this.Parties[i].Characters.Character[j].IsRPC.ToUpper() == "YES")
                            {
                                blurb = blurb + "*";
                            }

                            blurb = blurb + "  ";

                            break;
                        }
                    }
                }
                break;
            }
        }
        
        return blurb;
    }
}

public class PartiesParty
{
    public string Id { get; set; } // link to characters class, in future may put that in here...
    public string Name { get; set; }
    public string Description { get; set; }
    public string Tagline { get; set; }
    public string Gold { get; set; }

    [XmlElement("Characters")]
    public PartyCharacters Characters { get; set; }
}


public class PartyCharacters
{
    [XmlElement("Character")]
    public PartyCharactersCharacter[] Character { get; set; }
}

public class PartyCharactersCharacter
{
    public string Id { get; set; } // link to characters class, in future may put that in here...
    public string Name { get; set; }
    public string IsLeader { get; set; }
    public string IsRPC { get; set; }
}
