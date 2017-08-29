using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Important to have this attributes tag to because that is the root tag of the file.
[XmlRoot("EffectTypes")]
public class EffectTypes
{
    [XmlElement("EffectType")]
    public EffectType[] EffectType { get; set; }
}

public class EffectType
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
